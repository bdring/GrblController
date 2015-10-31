Imports System.IO.Ports

'  This is a class to encapsulate all the communications with grbl
'  
'  *  It manages the flow of commands including single commands, marcos and sending files.
'  *  It can do periodictimer based status requests
'
'  *  It will raise an event when status is available
'
'   TO DO       
'       Cancel a file send
'       Block adding to the queue during file send
'

Public Class GrblInterface
    Private Const GRBL_STATUS_COMMAND As String = "?"
    Private Const MACRO_PROBE_ZERO As String = "***PROBE_ZERO***"

    Private WithEvents mSerialPort As SerialPort
    Private WithEvents StatusTimer As Timer  'used to periodically send the "?" status update command

    Private Queue As List(Of String) 'this is the queue of lines to send

    Private mPortName As String 'the comport name
    Private rxBuffer As String  'this holds the received data before it is process
    Private mGRblState As String 'the state (Alarm,Run,Hold, etc) of grbl
    Private FileRunning As Boolean = False  'if a file is running we can provide progress status

    Private grblResponding As Boolean = False 'has grbl responded yet? This is used to prevent status requests from happening too early

    Private MachinePosition(2) As Double   'status of axes in machine coordinates
    Private WorkPosition(2) As Double      'status of axes in work coordinates
    Private Probe(2) As Double   'status of axes in last probe coordinates

    Private mFileRowCount As Integer  'the number of rows in the current file
    Private mZProbePosition As Double 'where was the last Z probe
    Private mZProbeThickness As Double = 0 'how think is the Z probe.
    Private mLastError As String
    Private mVerbose As Boolean = True  'this supresses some status messages, see the code


    Public Event DataReceived(ByVal rxData As String)  'happens at any serial data received
    Public Event LineSent(ByVal Line As String) 'a line was ent to grbl
    Public Event StatusUpdate(ByVal State As String)  'a repsonse contains new status.  You would ask for status other than state (positions, etc) when handling this event
    Public Event FileLineProcessed(ByVal LineNumber As Integer)  'we finished a gcode line from a file.  This is used to update a progress bar, etc
    Public Event FileSendComplete()     'this can be used to hide a progress bar after the send is complete.
    Public Event GrblError(ByVal ErrorMessage As String)
    Public Event Alarm(ByVal AlarmMessage As String)


    Enum AxisLetter
        X = 0
        Y = 1
        Z = 2
    End Enum

    Enum CoordSystem
        Machine
        Work
        Probe
    End Enum


    Public Sub New()
        mSerialPort = New SerialPort
        Queue = New List(Of String)
        StatusTimer = New Timer

        'these are the basic grbl values
        mSerialPort.BaudRate = 115200
        mSerialPort.DataBits = 8
        mSerialPort.DtrEnable = True  'dtr is the thing that reboots Arduinos on connection
        mSerialPort.StopBits = StopBits.One
        mSerialPort.Parity = Parity.None

        mSerialPort.ReadBufferSize = 4096
        mSerialPort.WriteBufferSize = 80
        mSerialPort.ReceivedBytesThreshold = 1 'get data even if it is as low as one byte

        'initilize the coordinates
        For I As Integer = 0 To 2
            MachinePosition(I) = 0.0
            WorkPosition(I) = 0.0
            Probe(I) = 0.0
        Next


    End Sub

#Region "Serial Port"
    Public Sub Open() 'used to open the serial port
        Try
            mSerialPort.Open()
        Catch ex As Exception
            RaiseEvent GrblError(ex.Message)
        End Try
    End Sub

    Public Sub Close()
        mSerialPort.Close()
    End Sub

    Public ReadOnly Property IsOpen() As Boolean
        Get
            Return mSerialPort.IsOpen
        End Get
    End Property


    Public Property PortName() As String
        Get
            Return mPortName
        End Get
        Set(value As String)
            mPortName = value
            mSerialPort.PortName = mPortName
        End Set
    End Property


    Public Property AutoStatusUpdates() As Boolean 'setting this to true will cause a timer to send regular updates
        Get
            Return StatusTimer.Enabled
        End Get
        Set(value As Boolean)
            StatusTimer.Interval = 250 'this value (milliseconds) should not be less than about 200
            StatusTimer.Enabled = value
        End Set
    End Property

    Public Property Verbose() As Boolean   'set to false to stop status updates in line sent event
        Get
            Return mVerbose
        End Get
        Set(value As Boolean)
            mVerbose = value
        End Set
    End Property


    'this gets the most recent update of the value of an axis in a coordinate system
    'There are two.  Make sure the grbl $10 value supports the system you want or it will return zeros.
    Public Function GetCoordinate(ByVal CoordSystem As CoordSystem, ByVal Axis As AxisLetter)
        Select Case CoordSystem
            Case CoordSystem.Machine
                Return MachinePosition(Axis)
            Case CoordSystem.Work
                Return WorkPosition(Axis)
            Case CoordSystem.Probe
                Return Probe(Axis)
            Case Else
                Return 0
        End Select
    End Function

    'this event occurs everytime at least one charater is received
    Private Sub SerialDataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles mSerialPort.DataReceived
        Dim rxData As String

        rxData = mSerialPort.ReadExisting
        grblResponding = True
        ReceiveData(rxData)
    End Sub


    Private Sub SendNextCommand()

        If Queue.Count > 0 Then
            Dim NextCmd As String

            'QueueDone = False

            NextCmd = Queue.Item(0)
            Queue.RemoveAt(0)

            If mSerialPort.IsOpen() Then

                If NextCmd.Equals(MACRO_PROBE_ZERO) Then 'this command need to be tailored to current conditions
                    NextCmd = "G53 G0 Z" + Probe(2).ToString() + vbCr
                End If


                mSerialPort.Write(NextCmd)

                RaiseEvent LineSent(NextCmd)

                If FileRunning Then
                    RaiseEvent FileLineProcessed(GetCurentFileRow()) 'this allows makea a user interface progress bar easy.
                End If

            End If
        Else
            'the queue is empty.  If this is the end of a file, tell the user
            If FileRunning Then
                FileRunning = False
                mFileRowCount = 0
                RaiseEvent FileSendComplete()
            Else
                'QueueDone = True
            End If
        End If
    End Sub

    'this will send something right away, ahead of queued command and not wait for an OK
    Public Sub SendImmediate(ByVal Command As String) 'FYI these are typically sent without VbCr like "?"
        If mSerialPort.IsOpen Then
            mSerialPort.Write(Command)
            If mVerbose Then
                RaiseEvent LineSent(Command)
            End If
        Else
            'TO DO raise an error
        End If
    End Sub

    Private Sub ReceiveData(rxData As String)
        rxBuffer += rxData  'add incoming characters to a buffer

        While rxBuffer.Contains(vbCrLf)  'only process things in buffer that contain a CR LF...we could have more than one line
            Dim LineEndIndex As Integer
            Dim response As String

            LineEndIndex = rxBuffer.IndexOf(vbCrLf)

            response = rxBuffer.Substring(0, LineEndIndex + 1).Trim  'a response is a full line
            rxBuffer = rxBuffer.Substring(LineEndIndex + 2)  'trim off the response from the buffer

            If response.Length > 0 Then
                ProcessResponse(response)  'we have a line, now process it
            End If
        End While
    End Sub
#End Region

#Region "Queue Stuff"
    Public Sub AddLine(ByVal Command As String, Optional Start As Boolean = True)
        If mSerialPort.IsOpen Then
            Queue.Add(Command)
            If Queue.Count = 1 Then 'this must have been put in an empty queue
                SendNextCommand()
            End If
        Else
            Throw New Exception("Port Not Open")
        End If
    End Sub

    Public Sub Clear()
        Queue.Clear()
    End Sub

#End Region



#Region "Parsing"
    Private Sub ProcessResponse(Resp As String)
        Dim Index As Integer
        Dim gotStatus As Boolean = False

        'see what type of response it is
        Select Case Resp.Substring(0, 1)
            Case "e"  'an error string
                If Resp.Substring(0, 5).Equals("error") Then
                    RaiseEvent GrblError(Resp.Substring(7))
                End If

                RaiseEvent DataReceived(Resp)

            Case "A"
                Dim Message As String = ""


                If Resp.Substring(0, 5).Equals("ALARM") Then
                    Message = Resp.Substring(7)
                    RaiseEvent Alarm(Message)
                    If Message = "Probe fail" Then
                        Queue.Clear()
                    End If
                End If

                    RaiseEvent DataReceived(Resp)

            Case "<" 'response to a ? command

                ' Here is a typical one...<Alarm,MPos:0.000,0.000,0.000,WPos:0.000,0.000,0.000>
                'the type of data is dependant on the $10 setting
                'the State is always supplied

                If mVerbose Then
                    RaiseEvent DataReceived(Resp)
                End If

                mGRblState = Resp.Substring(1, Resp.IndexOf(",") - 1)

                Resp = Resp.Substring(Resp.IndexOf(",") + 1) 'remove the state

                If Resp.Contains("MPos") Then
                    'look for the comma three times
                    Index = 0
                    For I As Integer = 1 To 3
                        If Resp.IndexOf(",", Index + 1) <> -1 Then  'check for comma because this also can end in ">"
                            Index = Resp.IndexOf(",", Index + 1)
                        Else
                            Index = Resp.IndexOf(">", Index + 1)
                        End If
                    Next

                    Dim Mpos As String = Resp.Substring(0, Index)

                    ParseCoordinates(Mpos)

                    Resp = Resp.Substring(Index + 1)

                End If

                If Resp.Contains("WPos") Then
                    Index = 0
                    For I As Integer = 1 To 3
                        If Resp.IndexOf(",", Index + 1) <> -1 Then  'this can end in , or >
                            Index = Resp.IndexOf(",", Index + 1)
                        Else
                            Index = Resp.IndexOf(">", Index + 1)
                        End If

                    Next

                    Dim WPos As String = Resp.Substring(Resp.IndexOf("WPos"))
                    ParseCoordinates(WPos)

                End If

                '----other things not handled yet
                'planner status
                'buffer status
                'line number
                'framerate
                'limit pins
                'control pins

                gotStatus = True

            Case "[" 'probes look like this [PRB:-739.000,-789.000,-9.124:1]
                RaiseEvent DataReceived(Resp)

                If Resp.Contains("PRB") Then
                    Dim ProbePos As String = Resp.TrimStart("[")
                    Index = ProbePos.LastIndexOf(":")
                    ProbePos = ProbePos.Substring(0, Index - 1)
                    ParseCoordinates(ProbePos)
                End If
            Case "o" 'for OK
                If Resp.Equals("ok") Then
                    If mVerbose Then
                        RaiseEvent DataReceived(Resp)
                    End If
                    SendNextCommand()
                End If
            Case Else
                RaiseEvent DataReceived(Resp)
        End Select

        If gotStatus Then
            RaiseEvent StatusUpdate(mGRblState)
        End If
    End Sub

    'the cordinate system data comein on a string.  Parse it into numeric values
    Private Sub ParseCoordinates(ByVal Coords As String)
        Dim axes() As String
        Dim CSys As CoordSystem

        Try
            If Coords.Substring(0, 4).Equals("MPos") Then
                CSys = CoordSystem.Machine
            ElseIf Coords.Substring(0, 4).Equals("WPos") Then
                CSys = CoordSystem.Work
            ElseIf Coords.Substring(0, 3).Equals("PRB") Then
                CSys = CoordSystem.Probe
            End If



            Coords = Coords.Substring(5).TrimEnd(">")  'remove the coord system text and the > at the end

            axes = Coords.Split(",")
            For I As Integer = 0 To 2
                Select Case CSys
                    Case CoordSystem.Machine
                        Double.TryParse(axes(I), MachinePosition(I))
                    Case CoordSystem.Work
                        Double.TryParse(axes(I), WorkPosition(I))
                    Case CoordSystem.Probe
                        Double.TryParse(axes(I), Probe(I))
                End Select
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region



#Region "GCode File"

    Public Sub LoadFile(ByVal FileName As String)
        Dim readline As String
        Dim reader As New System.IO.StreamReader(FileName)

        'the queue should be empty before a file is loaded
        If Queue.Count = 0 Then

            Do While Not reader.EndOfStream
                readline = reader.ReadLine().Trim()
                If readline <> "" Then
                    Queue.Add(readline + vbCr)
                End If
            Loop

            reader.Close()

            mFileRowCount = Queue.Count
        Else
            Throw New Exception("Command queue not empty")
        End If
    End Sub

    Public Sub BeginFileSend()
        If mFileRowCount > 0 Then
            FileRunning = True
            SendNextCommand()
        Else
            Throw New Exception("No file loaded")
        End If
    End Sub

    Public Function GetFileRowCount() As Integer
        Return mFileRowCount
    End Function

    Public Function GetCurentFileRow() As Integer
        Return mFileRowCount - Queue.Count
    End Function

#End Region

    Public Sub DoAutoProbe(ProbeDistance As Double, ProbeRate As Double, ProbeThickness As Double)
        ' Send: G38.2 Z-100 F100    this send the probe down 100mm at 100mm/min looking for the contact.  The vals come from the paramaters
        ' Rec: [PRB:-739.000,-789.000,-9.124:1] 'this tells you where the probe made contact.  It still had to decelerate after this point
        ' Send G53 G0 Zxxx.xxx (where xxx.xx is the z position at touch) it should move up a little to compensate for the decel
        ' Send G10 L20 P0 Z (probe thickness)  'sets the current Z work coordinate to the thickness of the probe. 

        If Queue.Count = 0 Then
            'mAutoProbe = True
            mZProbeThickness = ProbeThickness
            Queue.Add("G38.2 Z-" + ProbeDistance.ToString + " F" + ProbeRate.ToString + vbCr)
            Queue.Add("G4 P0.25" + vbCr) ' a dwell for dramatic effect
            Queue.Add(MACRO_PROBE_ZERO) ' this is a flag for the sender to format the correct command
            Queue.Add("G10 L20 P0 Z" + ProbeThickness.ToString() + vbCr)
            Queue.Add("G4 P0.25" + vbCr) ' a dwell for dramatic effect
            Queue.Add("G91 G0 Z10" + vbCr) 'move up to top of Z
            Queue.Add("G90" + vbCr) 'move up to top of Z
            SendNextCommand()
        Else
            Throw New Exception("Queue must be empty")
        End If
    End Sub

    Private Sub StatusTimer_tick() Handles StatusTimer.Tick
        If mSerialPort.IsOpen And grblResponding Then
            SendImmediate(GRBL_STATUS_COMMAND)
        End If
    End Sub
End Class

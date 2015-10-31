Imports System.IO.Ports

'Grbl Interface Demo Program
'This is is form is only to demonstrate the features of the GrblInterface Class
'It is not meant to be a functional machine controller.  There is very validation on
'inputs or valid modes of operation
'
'Open Source Creative Commons 4.0 Attribution Share Alike
'B. Dring 2015

Public Class FormMain
    Dim WithEvents grbl As GrblInterface
    Dim JogIncrement As Double = 1.0  'the initial jog increment

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbl = New GrblInterface
        refreshPorts()
    End Sub

    Private Sub refreshPorts()
        ToolStripComboBoxPorts.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ToolStripComboBoxPorts.Items.Add(sp)
        Next
    End Sub

#Region "GRBL Events"

    Private Sub grbl_DataReceived(DataReceived As String) Handles grbl.DataReceived
        AddText(TextBoxInfo, DataReceived + vbCrLf)
    End Sub

    Private Sub grbl_LineSEnt(ByVal line As String) Handles grbl.LineSent
        AddText(TextBoxInfo, line + vbCrLf) 'grbl only wants a CR but the control also need an LF
    End Sub

    Private Sub grbl_StatusUpdate(Status As String) Handles grbl.StatusUpdate
        SetText(LabelStatus, "Status: " + Status)

        SetText(LabelXWork, "X: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Work, GrblInterface.AxisLetter.X).ToString())
        SetText(LabelYWork, "Y: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Work, GrblInterface.AxisLetter.Y).ToString())
        SetText(LabelZWork, "Z: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Work, GrblInterface.AxisLetter.Z).ToString())

        SetText(LabelXMachine, "X: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Machine, GrblInterface.AxisLetter.X).ToString())
        SetText(LabelYMachine, "Y: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Machine, GrblInterface.AxisLetter.Y).ToString())
        SetText(LabelZMachine, "Z: " + grbl.GetCoordinate(GrblInterface.CoordSystem.Machine, GrblInterface.AxisLetter.Z).ToString())

    End Sub

    Private Sub grbl_FileLineProcessed(ByVal LineNumber As Integer) Handles grbl.FileLineProcessed
        SetValue(ProgressBarFile, (LineNumber / grbl.GetFileRowCount) * 100)
    End Sub

    Private Sub grbl_FileSendComplete() Handles grbl.FileSendComplete
        SetVisible(ProgressBarFile, False)
    End Sub

    Private Sub grbl_error(ByVal Message As String) Handles grbl.GrblError

        Beep()
        SetText(LabelAlert, Message)

    End Sub

    Private Sub Alarm(ByVal Message As String) Handles grbl.Alarm
        Beep()
        SetText(LabelAlert, Message)

    End Sub

#End Region

#Region "Delegates"

    Delegate Sub SetTextDelagate(ByVal ctrl As Control, ByVal Text As String)

    Public Sub SetText(ByVal ctrl As Control, ByVal Text As String)
        If ctrl.InvokeRequired Then
            Dim del = New SetTextDelagate(AddressOf SetText)
            ctrl.Invoke(del, ctrl, Text)
        Else
            ctrl.Text = Text
        End If
    End Sub


    Delegate Sub AddTextDelagate(ByVal ctrl As TextBox, ByVal Text As String)

    Public Sub AddText(ByVal ctrl As TextBox, ByVal Text As String)
        If ctrl.InvokeRequired Then
            Dim del = New AddTextDelagate(AddressOf AddText)
            ctrl.Invoke(del, ctrl, Text)
        Else
            ctrl.AppendText(Text)
        End If
    End Sub

    Delegate Sub SetValueDelagate(ByVal ctrl As ProgressBar, ByVal Value As Double)

    Public Sub SetValue(ByVal ctrl As ProgressBar, ByVal Value As Double)
        If ctrl.InvokeRequired Then
            Dim del = New SetValueDelagate(AddressOf SetValue)
            ctrl.Invoke(del, ctrl, Value)
        Else
            ctrl.Value = Value
        End If
    End Sub

    Delegate Sub SetVisibleDelagate(ByVal ctrl As Control, ByVal Visible As Boolean)

    Public Sub SetVisible(ByVal ctrl As Control, ByVal Visible As Boolean)
        If ctrl.InvokeRequired Then
            Dim del = New SetVisibleDelagate(AddressOf SetVisible)
            ctrl.Invoke(del, ctrl, Visible)
        Else
            ctrl.Visible = Visible
        End If
    End Sub
#End Region

#Region "Control Events"

    Private Sub ButtonJog_Click(sender As Object, e As EventArgs) Handles ButtonJogXPos.Click, ButtonJogXNeg.Click, ButtonYPos.Click, ButtonYNeg.Click, ButtonZPos.Click, ButtonZNeg.Click
        Dim btn As Button = DirectCast(sender, Button)
        grbl.AddLine("G91 G0" + btn.Tag + JogIncrement.ToString() + vbCr)
    End Sub

    Private Sub ButtonJogInc_Click(sender As Object, e As EventArgs) Handles ButtonJogPt1.Click, ButtonJog1.Click, ButtonJog10.Click, ButtonJog100.Click
        Dim btn As Button = DirectCast(sender, Button)
        JogIncrement = btn.Tag.ToString
        LabelJogInc.Text = btn.Tag
    End Sub

    Private Sub ButtonControl_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click, ButtonG28.Click, ButtonG30.Click, ButtonSafeZ.Click, Button1ZeroX.Click, ButtonZeroY.Click, ButtonZeroZ.Click, ButtonZeroAll.Click
        Dim btn As Button = DirectCast(sender, Button)
        grbl.AddLine(btn.Tag + vbCr)
    End Sub

    Private Sub ButtonImmediate_Click(sender As Object, e As EventArgs) Handles ButtonFeedHold.Click, ButtonResume.Click
        Dim btn As Button = DirectCast(sender, Button)
        grbl.SendImmediate(btn.Tag)
    End Sub



    Private Sub ButtonGetFile_Click(sender As Object, e As EventArgs) Handles ButtonGetFile.Click
        Dim FileName As String = ""

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FileName = OpenFileDialog1.FileName
            grbl.LoadFile(FileName)
        End If

        LabelFileName.Text = "Filen Name: " + FileName
    End Sub

    Private Sub ButtonFileSend_Click(sender As Object, e As EventArgs) Handles ButtonFileSend.Click
        ProgressBarFile.Visible = True
        grbl.BeginFileSend()
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        grbl.AddLine(TextBoxSend.Text + vbCr)
        TextBoxSend.Text = ""
    End Sub

    Private Sub TextBoxSend_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxSend.KeyDown
        'if the user hits the enter key, send the text
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Stops the beep
            grbl.AddLine(TextBoxSend.Text + vbCr)
            TextBoxSend.Text = "" 'clear it after sending
        End If
    End Sub

    Private Sub ButtonProbe_Click(sender As Object, e As EventArgs) Handles ButtonProbe.Click
        grbl.DoAutoProbe(Convert.ToDouble(TextBoxPrbDist.Text), Convert.ToDouble(TextBoxPrbRate.Text), Convert.ToDouble(TextBoxPrbThick.Text))
    End Sub

    Private Sub CheckBoxVerbose_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxVerbose.CheckedChanged
        grbl.Verbose = CheckBoxVerbose.Checked
    End Sub

#End Region

#Region "Toolbar"
    Private Sub ToolStripMenuItemRefreshPorts_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemRefreshPorts.Click
        refreshPorts()
    End Sub

    Private Sub ToolStripMenuItemOpenPort_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemOpenPort.Click
        If ToolStripComboBoxPorts.Text <> "" Then
            If Not grbl.IsOpen Then
                grbl.PortName = ToolStripComboBoxPorts.Text
                grbl.Open()
                grbl.AutoStatusUpdates = True
                grbl.Verbose = CheckBoxVerbose.Checked
            Else
                MessageBox.Show("Port Already Open")
            End If
        Else
            MessageBox.Show("No port selected")
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If grbl.IsOpen Then
            grbl.Close()
        End If
    End Sub

    'this timer always runs.  It clears alert text, but makes sure it get a full interval
    Private Sub TimerClearAlert_Tick(sender As Object, e As EventArgs) Handles TimerClearAlert.Tick
        Static FoundText As Boolean = False 'this gets toggled once to make sure we get a full cycle

        If LabelAlert.Text <> "" And FoundText = False Then
            FoundText = True
        Else
            LabelAlert.Text = ""
            FoundText = False
        End If
    End Sub


#End Region
End Class

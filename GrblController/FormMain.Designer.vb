<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxInfo = New System.Windows.Forms.TextBox()
        Me.LabelXWork = New System.Windows.Forms.Label()
        Me.LabelYWork = New System.Windows.Forms.Label()
        Me.LabelZWork = New System.Windows.Forms.Label()
        Me.LabelXMachine = New System.Windows.Forms.Label()
        Me.LabelYMachine = New System.Windows.Forms.Label()
        Me.LabelZMachine = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonJogXPos = New System.Windows.Forms.Button()
        Me.ButtonGetFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LabelFileName = New System.Windows.Forms.Label()
        Me.ButtonFileSend = New System.Windows.Forms.Button()
        Me.ProgressBarFile = New System.Windows.Forms.ProgressBar()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.TextBoxSend = New System.Windows.Forms.TextBox()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ButtonProbe = New System.Windows.Forms.Button()
        Me.CheckBoxVerbose = New System.Windows.Forms.CheckBox()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageControl = New System.Windows.Forms.TabPage()
        Me.LabelJogInc = New System.Windows.Forms.Label()
        Me.ButtonJog100 = New System.Windows.Forms.Button()
        Me.ButtonJog10 = New System.Windows.Forms.Button()
        Me.ButtonJog1 = New System.Windows.Forms.Button()
        Me.ButtonJogPt1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPrbThick = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPrbRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPrbDist = New System.Windows.Forms.TextBox()
        Me.ButtonSafeZ = New System.Windows.Forms.Button()
        Me.ButtonG30 = New System.Windows.Forms.Button()
        Me.ButtonG28 = New System.Windows.Forms.Button()
        Me.ButtonZNeg = New System.Windows.Forms.Button()
        Me.ButtonZPos = New System.Windows.Forms.Button()
        Me.ButtonYNeg = New System.Windows.Forms.Button()
        Me.ButtonYPos = New System.Windows.Forms.Button()
        Me.ButtonJogXNeg = New System.Windows.Forms.Button()
        Me.TabPageFile = New System.Windows.Forms.TabPage()
        Me.TabPageConsole = New System.Windows.Forms.TabPage()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.LabelAlert = New System.Windows.Forms.Label()
        Me.ButtonZeroAll = New System.Windows.Forms.Button()
        Me.ButtonZeroZ = New System.Windows.Forms.Button()
        Me.ButtonZeroY = New System.Windows.Forms.Button()
        Me.Button1ZeroX = New System.Windows.Forms.Button()
        Me.ButtonResume = New System.Windows.Forms.Button()
        Me.ButtonFeedHold = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemOpenPort = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBoxPorts = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripMenuItemRefreshPorts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerClearAlert = New System.Windows.Forms.Timer(Me.components)
        Me.TabControlMain.SuspendLayout()
        Me.TabPageControl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPageFile.SuspendLayout()
        Me.TabPageConsole.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxInfo
        '
        Me.TextBoxInfo.Location = New System.Drawing.Point(5, 44)
        Me.TextBoxInfo.Multiline = True
        Me.TextBoxInfo.Name = "TextBoxInfo"
        Me.TextBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxInfo.Size = New System.Drawing.Size(495, 216)
        Me.TextBoxInfo.TabIndex = 2
        '
        'LabelXWork
        '
        Me.LabelXWork.AutoSize = True
        Me.LabelXWork.Location = New System.Drawing.Point(248, 90)
        Me.LabelXWork.Name = "LabelXWork"
        Me.LabelXWork.Size = New System.Drawing.Size(43, 20)
        Me.LabelXWork.TabIndex = 3
        Me.LabelXWork.Text = "---.---"
        '
        'LabelYWork
        '
        Me.LabelYWork.AutoSize = True
        Me.LabelYWork.Location = New System.Drawing.Point(248, 146)
        Me.LabelYWork.Name = "LabelYWork"
        Me.LabelYWork.Size = New System.Drawing.Size(43, 20)
        Me.LabelYWork.TabIndex = 4
        Me.LabelYWork.Text = "---.---"
        '
        'LabelZWork
        '
        Me.LabelZWork.AutoSize = True
        Me.LabelZWork.Location = New System.Drawing.Point(249, 202)
        Me.LabelZWork.Name = "LabelZWork"
        Me.LabelZWork.Size = New System.Drawing.Size(43, 20)
        Me.LabelZWork.TabIndex = 5
        Me.LabelZWork.Text = "---.---"
        '
        'LabelXMachine
        '
        Me.LabelXMachine.AutoSize = True
        Me.LabelXMachine.Location = New System.Drawing.Point(380, 90)
        Me.LabelXMachine.Name = "LabelXMachine"
        Me.LabelXMachine.Size = New System.Drawing.Size(43, 20)
        Me.LabelXMachine.TabIndex = 6
        Me.LabelXMachine.Text = "---.---"
        '
        'LabelYMachine
        '
        Me.LabelYMachine.AutoSize = True
        Me.LabelYMachine.Location = New System.Drawing.Point(380, 146)
        Me.LabelYMachine.Name = "LabelYMachine"
        Me.LabelYMachine.Size = New System.Drawing.Size(43, 20)
        Me.LabelYMachine.TabIndex = 7
        Me.LabelYMachine.Text = "---.---"
        '
        'LabelZMachine
        '
        Me.LabelZMachine.AutoSize = True
        Me.LabelZMachine.Location = New System.Drawing.Point(380, 202)
        Me.LabelZMachine.Name = "LabelZMachine"
        Me.LabelZMachine.Size = New System.Drawing.Size(43, 20)
        Me.LabelZMachine.TabIndex = 8
        Me.LabelZMachine.Text = "---.---"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Work"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Machine"
        '
        'ButtonJogXPos
        '
        Me.ButtonJogXPos.Location = New System.Drawing.Point(234, 107)
        Me.ButtonJogXPos.Name = "ButtonJogXPos"
        Me.ButtonJogXPos.Size = New System.Drawing.Size(50, 50)
        Me.ButtonJogXPos.TabIndex = 11
        Me.ButtonJogXPos.Tag = "X+"
        Me.ButtonJogXPos.Text = "X+"
        Me.ButtonJogXPos.UseVisualStyleBackColor = True
        '
        'ButtonGetFile
        '
        Me.ButtonGetFile.Location = New System.Drawing.Point(6, 6)
        Me.ButtonGetFile.Name = "ButtonGetFile"
        Me.ButtonGetFile.Size = New System.Drawing.Size(157, 46)
        Me.ButtonGetFile.TabIndex = 12
        Me.ButtonGetFile.Text = "Get File"
        Me.ButtonGetFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "GCode Files|*.gcode;*.nc;"
        '
        'LabelFileName
        '
        Me.LabelFileName.AutoSize = True
        Me.LabelFileName.Location = New System.Drawing.Point(9, 148)
        Me.LabelFileName.Name = "LabelFileName"
        Me.LabelFileName.Size = New System.Drawing.Size(78, 20)
        Me.LabelFileName.TabIndex = 13
        Me.LabelFileName.Text = "Filename:"
        '
        'ButtonFileSend
        '
        Me.ButtonFileSend.Location = New System.Drawing.Point(6, 58)
        Me.ButtonFileSend.Name = "ButtonFileSend"
        Me.ButtonFileSend.Size = New System.Drawing.Size(157, 46)
        Me.ButtonFileSend.TabIndex = 14
        Me.ButtonFileSend.Text = "Start Sending"
        Me.ButtonFileSend.UseVisualStyleBackColor = True
        '
        'ProgressBarFile
        '
        Me.ProgressBarFile.Location = New System.Drawing.Point(6, 110)
        Me.ProgressBarFile.Name = "ProgressBarFile"
        Me.ProgressBarFile.Size = New System.Drawing.Size(494, 24)
        Me.ProgressBarFile.TabIndex = 15
        Me.ProgressBarFile.Visible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(21, 84)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(56, 20)
        Me.LabelStatus.TabIndex = 16
        Me.LabelStatus.Text = "Status"
        '
        'TextBoxSend
        '
        Me.TextBoxSend.Location = New System.Drawing.Point(5, 12)
        Me.TextBoxSend.Name = "TextBoxSend"
        Me.TextBoxSend.Size = New System.Drawing.Size(411, 26)
        Me.TextBoxSend.TabIndex = 17
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(431, 13)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(69, 24)
        Me.ButtonSend.TabIndex = 18
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ButtonProbe
        '
        Me.ButtonProbe.Location = New System.Drawing.Point(6, 5)
        Me.ButtonProbe.Name = "ButtonProbe"
        Me.ButtonProbe.Size = New System.Drawing.Size(100, 50)
        Me.ButtonProbe.TabIndex = 19
        Me.ButtonProbe.Text = "Probe"
        Me.ButtonProbe.UseVisualStyleBackColor = True
        '
        'CheckBoxVerbose
        '
        Me.CheckBoxVerbose.AutoSize = True
        Me.CheckBoxVerbose.Location = New System.Drawing.Point(13, 266)
        Me.CheckBoxVerbose.Name = "CheckBoxVerbose"
        Me.CheckBoxVerbose.Size = New System.Drawing.Size(95, 24)
        Me.CheckBoxVerbose.TabIndex = 21
        Me.CheckBoxVerbose.Text = "Verbose"
        Me.CheckBoxVerbose.UseVisualStyleBackColor = True
        '
        'ButtonHome
        '
        Me.ButtonHome.Location = New System.Drawing.Point(6, 6)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(100, 50)
        Me.ButtonHome.TabIndex = 22
        Me.ButtonHome.Tag = "$H"
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageControl)
        Me.TabControlMain.Controls.Add(Me.TabPageFile)
        Me.TabControlMain.Controls.Add(Me.TabPageConsole)
        Me.TabControlMain.Location = New System.Drawing.Point(3, 46)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(534, 335)
        Me.TabControlMain.TabIndex = 23
        '
        'TabPageControl
        '
        Me.TabPageControl.Controls.Add(Me.LabelJogInc)
        Me.TabPageControl.Controls.Add(Me.ButtonJog100)
        Me.TabPageControl.Controls.Add(Me.ButtonJog10)
        Me.TabPageControl.Controls.Add(Me.ButtonJog1)
        Me.TabPageControl.Controls.Add(Me.ButtonJogPt1)
        Me.TabPageControl.Controls.Add(Me.Panel1)
        Me.TabPageControl.Controls.Add(Me.ButtonSafeZ)
        Me.TabPageControl.Controls.Add(Me.ButtonG30)
        Me.TabPageControl.Controls.Add(Me.ButtonG28)
        Me.TabPageControl.Controls.Add(Me.ButtonZNeg)
        Me.TabPageControl.Controls.Add(Me.ButtonZPos)
        Me.TabPageControl.Controls.Add(Me.ButtonYNeg)
        Me.TabPageControl.Controls.Add(Me.ButtonYPos)
        Me.TabPageControl.Controls.Add(Me.ButtonJogXNeg)
        Me.TabPageControl.Controls.Add(Me.ButtonHome)
        Me.TabPageControl.Controls.Add(Me.ButtonJogXPos)
        Me.TabPageControl.Location = New System.Drawing.Point(4, 29)
        Me.TabPageControl.Name = "TabPageControl"
        Me.TabPageControl.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageControl.Size = New System.Drawing.Size(526, 302)
        Me.TabPageControl.TabIndex = 0
        Me.TabPageControl.Text = "Control"
        Me.TabPageControl.UseVisualStyleBackColor = True
        '
        'LabelJogInc
        '
        Me.LabelJogInc.Location = New System.Drawing.Point(179, 118)
        Me.LabelJogInc.Name = "LabelJogInc"
        Me.LabelJogInc.Size = New System.Drawing.Size(50, 28)
        Me.LabelJogInc.TabIndex = 36
        Me.LabelJogInc.Text = "1"
        Me.LabelJogInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonJog100
        '
        Me.ButtonJog100.Location = New System.Drawing.Point(407, 6)
        Me.ButtonJog100.Name = "ButtonJog100"
        Me.ButtonJog100.Size = New System.Drawing.Size(50, 50)
        Me.ButtonJog100.TabIndex = 35
        Me.ButtonJog100.Tag = "100"
        Me.ButtonJog100.Text = "100"
        Me.ButtonJog100.UseVisualStyleBackColor = True
        '
        'ButtonJog10
        '
        Me.ButtonJog10.Location = New System.Drawing.Point(407, 62)
        Me.ButtonJog10.Name = "ButtonJog10"
        Me.ButtonJog10.Size = New System.Drawing.Size(50, 50)
        Me.ButtonJog10.TabIndex = 34
        Me.ButtonJog10.Tag = "10"
        Me.ButtonJog10.Text = "10"
        Me.ButtonJog10.UseVisualStyleBackColor = True
        '
        'ButtonJog1
        '
        Me.ButtonJog1.Location = New System.Drawing.Point(407, 118)
        Me.ButtonJog1.Name = "ButtonJog1"
        Me.ButtonJog1.Size = New System.Drawing.Size(50, 50)
        Me.ButtonJog1.TabIndex = 33
        Me.ButtonJog1.Tag = "1"
        Me.ButtonJog1.Text = "1"
        Me.ButtonJog1.UseVisualStyleBackColor = True
        '
        'ButtonJogPt1
        '
        Me.ButtonJogPt1.Location = New System.Drawing.Point(407, 174)
        Me.ButtonJogPt1.Name = "ButtonJogPt1"
        Me.ButtonJogPt1.Size = New System.Drawing.Size(50, 50)
        Me.ButtonJogPt1.TabIndex = 32
        Me.ButtonJogPt1.Tag = "0.1"
        Me.ButtonJogPt1.Text = "0.1"
        Me.ButtonJogPt1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBoxPrbThick)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxPrbRate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBoxPrbDist)
        Me.Panel1.Controls.Add(Me.ButtonProbe)
        Me.Panel1.Location = New System.Drawing.Point(0, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 58)
        Me.Panel1.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Thickness"
        '
        'TextBoxPrbThick
        '
        Me.TextBoxPrbThick.Location = New System.Drawing.Point(351, 16)
        Me.TextBoxPrbThick.Name = "TextBoxPrbThick"
        Me.TextBoxPrbThick.Size = New System.Drawing.Size(52, 26)
        Me.TextBoxPrbThick.TabIndex = 24
        Me.TextBoxPrbThick.Text = "16"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Rate"
        '
        'TextBoxPrbRate
        '
        Me.TextBoxPrbRate.Location = New System.Drawing.Point(249, 17)
        Me.TextBoxPrbRate.Name = "TextBoxPrbRate"
        Me.TextBoxPrbRate.Size = New System.Drawing.Size(52, 26)
        Me.TextBoxPrbRate.TabIndex = 22
        Me.TextBoxPrbRate.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Distance"
        '
        'TextBoxPrbDist
        '
        Me.TextBoxPrbDist.Location = New System.Drawing.Point(113, 17)
        Me.TextBoxPrbDist.Name = "TextBoxPrbDist"
        Me.TextBoxPrbDist.Size = New System.Drawing.Size(52, 26)
        Me.TextBoxPrbDist.TabIndex = 20
        Me.TextBoxPrbDist.Text = "100"
        '
        'ButtonSafeZ
        '
        Me.ButtonSafeZ.Location = New System.Drawing.Point(5, 174)
        Me.ButtonSafeZ.Name = "ButtonSafeZ"
        Me.ButtonSafeZ.Size = New System.Drawing.Size(101, 50)
        Me.ButtonSafeZ.TabIndex = 30
        Me.ButtonSafeZ.Tag = "G53 G0 Z-1"
        Me.ButtonSafeZ.Text = "Safe Z"
        Me.ButtonSafeZ.UseVisualStyleBackColor = True
        '
        'ButtonG30
        '
        Me.ButtonG30.Location = New System.Drawing.Point(6, 118)
        Me.ButtonG30.Name = "ButtonG30"
        Me.ButtonG30.Size = New System.Drawing.Size(100, 50)
        Me.ButtonG30.TabIndex = 29
        Me.ButtonG30.Tag = "G30"
        Me.ButtonG30.Text = "G30"
        Me.ButtonG30.UseVisualStyleBackColor = True
        '
        'ButtonG28
        '
        Me.ButtonG28.Location = New System.Drawing.Point(6, 62)
        Me.ButtonG28.Name = "ButtonG28"
        Me.ButtonG28.Size = New System.Drawing.Size(100, 50)
        Me.ButtonG28.TabIndex = 28
        Me.ButtonG28.Tag = "G28"
        Me.ButtonG28.Text = "G28"
        Me.ButtonG28.UseVisualStyleBackColor = True
        '
        'ButtonZNeg
        '
        Me.ButtonZNeg.Location = New System.Drawing.Point(309, 163)
        Me.ButtonZNeg.Name = "ButtonZNeg"
        Me.ButtonZNeg.Size = New System.Drawing.Size(50, 50)
        Me.ButtonZNeg.TabIndex = 27
        Me.ButtonZNeg.Tag = "Z-"
        Me.ButtonZNeg.Text = "Z-"
        Me.ButtonZNeg.UseVisualStyleBackColor = True
        '
        'ButtonZPos
        '
        Me.ButtonZPos.Location = New System.Drawing.Point(309, 51)
        Me.ButtonZPos.Name = "ButtonZPos"
        Me.ButtonZPos.Size = New System.Drawing.Size(50, 50)
        Me.ButtonZPos.TabIndex = 26
        Me.ButtonZPos.Tag = "Z+"
        Me.ButtonZPos.Text = "Z+"
        Me.ButtonZPos.UseVisualStyleBackColor = True
        '
        'ButtonYNeg
        '
        Me.ButtonYNeg.Location = New System.Drawing.Point(179, 163)
        Me.ButtonYNeg.Name = "ButtonYNeg"
        Me.ButtonYNeg.Size = New System.Drawing.Size(50, 50)
        Me.ButtonYNeg.TabIndex = 25
        Me.ButtonYNeg.Tag = "Y-"
        Me.ButtonYNeg.Text = "Y-"
        Me.ButtonYNeg.UseVisualStyleBackColor = True
        '
        'ButtonYPos
        '
        Me.ButtonYPos.Location = New System.Drawing.Point(179, 51)
        Me.ButtonYPos.Name = "ButtonYPos"
        Me.ButtonYPos.Size = New System.Drawing.Size(50, 50)
        Me.ButtonYPos.TabIndex = 24
        Me.ButtonYPos.Tag = "Y+"
        Me.ButtonYPos.Text = "Y+"
        Me.ButtonYPos.UseVisualStyleBackColor = True
        '
        'ButtonJogXNeg
        '
        Me.ButtonJogXNeg.Location = New System.Drawing.Point(123, 107)
        Me.ButtonJogXNeg.Name = "ButtonJogXNeg"
        Me.ButtonJogXNeg.Size = New System.Drawing.Size(50, 50)
        Me.ButtonJogXNeg.TabIndex = 23
        Me.ButtonJogXNeg.Tag = "X-"
        Me.ButtonJogXNeg.Text = "X-"
        Me.ButtonJogXNeg.UseVisualStyleBackColor = True
        '
        'TabPageFile
        '
        Me.TabPageFile.Controls.Add(Me.ProgressBarFile)
        Me.TabPageFile.Controls.Add(Me.ButtonGetFile)
        Me.TabPageFile.Controls.Add(Me.LabelFileName)
        Me.TabPageFile.Controls.Add(Me.ButtonFileSend)
        Me.TabPageFile.Location = New System.Drawing.Point(4, 29)
        Me.TabPageFile.Name = "TabPageFile"
        Me.TabPageFile.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFile.Size = New System.Drawing.Size(526, 302)
        Me.TabPageFile.TabIndex = 1
        Me.TabPageFile.Text = "File Send"
        Me.TabPageFile.UseVisualStyleBackColor = True
        '
        'TabPageConsole
        '
        Me.TabPageConsole.Controls.Add(Me.CheckBoxVerbose)
        Me.TabPageConsole.Controls.Add(Me.TextBoxInfo)
        Me.TabPageConsole.Controls.Add(Me.ButtonSend)
        Me.TabPageConsole.Controls.Add(Me.TextBoxSend)
        Me.TabPageConsole.Location = New System.Drawing.Point(4, 29)
        Me.TabPageConsole.Name = "TabPageConsole"
        Me.TabPageConsole.Size = New System.Drawing.Size(526, 302)
        Me.TabPageConsole.TabIndex = 2
        Me.TabPageConsole.Text = "Console"
        Me.TabPageConsole.UseVisualStyleBackColor = True
        '
        'PanelControl
        '
        Me.PanelControl.BackColor = System.Drawing.Color.White
        Me.PanelControl.Controls.Add(Me.LabelAlert)
        Me.PanelControl.Controls.Add(Me.ButtonZeroAll)
        Me.PanelControl.Controls.Add(Me.ButtonZeroZ)
        Me.PanelControl.Controls.Add(Me.Label2)
        Me.PanelControl.Controls.Add(Me.ButtonZeroY)
        Me.PanelControl.Controls.Add(Me.Label1)
        Me.PanelControl.Controls.Add(Me.Button1ZeroX)
        Me.PanelControl.Controls.Add(Me.LabelZMachine)
        Me.PanelControl.Controls.Add(Me.ButtonResume)
        Me.PanelControl.Controls.Add(Me.LabelYMachine)
        Me.PanelControl.Controls.Add(Me.ButtonFeedHold)
        Me.PanelControl.Controls.Add(Me.LabelZWork)
        Me.PanelControl.Controls.Add(Me.LabelXMachine)
        Me.PanelControl.Controls.Add(Me.LabelYWork)
        Me.PanelControl.Controls.Add(Me.LabelStatus)
        Me.PanelControl.Controls.Add(Me.LabelXWork)
        Me.PanelControl.Location = New System.Drawing.Point(7, 387)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(530, 309)
        Me.PanelControl.TabIndex = 24
        '
        'LabelAlert
        '
        Me.LabelAlert.BackColor = System.Drawing.Color.Black
        Me.LabelAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlert.ForeColor = System.Drawing.Color.White
        Me.LabelAlert.Location = New System.Drawing.Point(5, 6)
        Me.LabelAlert.Name = "LabelAlert"
        Me.LabelAlert.Size = New System.Drawing.Size(521, 34)
        Me.LabelAlert.TabIndex = 37
        Me.LabelAlert.Text = "---"
        Me.LabelAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonZeroAll
        '
        Me.ButtonZeroAll.Location = New System.Drawing.Point(132, 243)
        Me.ButtonZeroAll.Name = "ButtonZeroAll"
        Me.ButtonZeroAll.Size = New System.Drawing.Size(85, 50)
        Me.ButtonZeroAll.TabIndex = 36
        Me.ButtonZeroAll.Tag = "G10 L20 P0 X0 Y0 Z0"
        Me.ButtonZeroAll.Text = "Zero All"
        Me.ButtonZeroAll.UseVisualStyleBackColor = True
        '
        'ButtonZeroZ
        '
        Me.ButtonZeroZ.Location = New System.Drawing.Point(132, 187)
        Me.ButtonZeroZ.Name = "ButtonZeroZ"
        Me.ButtonZeroZ.Size = New System.Drawing.Size(85, 50)
        Me.ButtonZeroZ.TabIndex = 35
        Me.ButtonZeroZ.Tag = "G10 L20 P0 Z0"
        Me.ButtonZeroZ.Text = "Zero Z"
        Me.ButtonZeroZ.UseVisualStyleBackColor = True
        '
        'ButtonZeroY
        '
        Me.ButtonZeroY.Location = New System.Drawing.Point(132, 131)
        Me.ButtonZeroY.Name = "ButtonZeroY"
        Me.ButtonZeroY.Size = New System.Drawing.Size(85, 50)
        Me.ButtonZeroY.TabIndex = 34
        Me.ButtonZeroY.Tag = "G10 L20 P0 y0"
        Me.ButtonZeroY.Text = "Zero Y"
        Me.ButtonZeroY.UseVisualStyleBackColor = True
        '
        'Button1ZeroX
        '
        Me.Button1ZeroX.Location = New System.Drawing.Point(132, 75)
        Me.Button1ZeroX.Name = "Button1ZeroX"
        Me.Button1ZeroX.Size = New System.Drawing.Size(85, 50)
        Me.Button1ZeroX.TabIndex = 33
        Me.Button1ZeroX.Tag = "G10 L20 P0 X0"
        Me.Button1ZeroX.Text = "Zero X"
        Me.Button1ZeroX.UseVisualStyleBackColor = True
        '
        'ButtonResume
        '
        Me.ButtonResume.Location = New System.Drawing.Point(16, 187)
        Me.ButtonResume.Name = "ButtonResume"
        Me.ButtonResume.Size = New System.Drawing.Size(100, 50)
        Me.ButtonResume.TabIndex = 32
        Me.ButtonResume.Tag = "~"
        Me.ButtonResume.Text = "Resume"
        Me.ButtonResume.UseVisualStyleBackColor = True
        '
        'ButtonFeedHold
        '
        Me.ButtonFeedHold.Location = New System.Drawing.Point(16, 131)
        Me.ButtonFeedHold.Name = "ButtonFeedHold"
        Me.ButtonFeedHold.Size = New System.Drawing.Size(100, 50)
        Me.ButtonFeedHold.TabIndex = 31
        Me.ButtonFeedHold.Tag = "!"
        Me.ButtonFeedHold.Text = "Feed Hold"
        Me.ButtonFeedHold.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemOpenPort, Me.ToolStripComboBoxPorts, Me.ToolStripMenuItemRefreshPorts, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(546, 37)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItemOpenPort
        '
        Me.ToolStripMenuItemOpenPort.Name = "ToolStripMenuItemOpenPort"
        Me.ToolStripMenuItemOpenPort.Size = New System.Drawing.Size(68, 33)
        Me.ToolStripMenuItemOpenPort.Text = "Open"
        '
        'ToolStripComboBoxPorts
        '
        Me.ToolStripComboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxPorts.Name = "ToolStripComboBoxPorts"
        Me.ToolStripComboBoxPorts.Size = New System.Drawing.Size(121, 33)
        '
        'ToolStripMenuItemRefreshPorts
        '
        Me.ToolStripMenuItemRefreshPorts.Name = "ToolStripMenuItemRefreshPorts"
        Me.ToolStripMenuItemRefreshPorts.Size = New System.Drawing.Size(82, 33)
        Me.ToolStripMenuItemRefreshPorts.Text = "Refresh"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(67, 33)
        Me.ToolStripMenuItem3.Text = "Close"
        '
        'TimerClearAlert
        '
        Me.TimerClearAlert.Enabled = True
        Me.TimerClearAlert.Interval = 3000
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 700)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Text = "Grbl Interface Demo"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageControl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPageFile.ResumeLayout(False)
        Me.TabPageFile.PerformLayout()
        Me.TabPageConsole.ResumeLayout(False)
        Me.TabPageConsole.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxInfo As TextBox
    Friend WithEvents LabelXWork As Label
    Friend WithEvents LabelYWork As Label
    Friend WithEvents LabelZWork As Label
    Friend WithEvents LabelXMachine As Label
    Friend WithEvents LabelYMachine As Label
    Friend WithEvents LabelZMachine As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonJogXPos As Button
    Friend WithEvents ButtonGetFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LabelFileName As Label
    Friend WithEvents ButtonFileSend As Button
    Friend WithEvents ProgressBarFile As ProgressBar
    Friend WithEvents LabelStatus As Label
    Friend WithEvents TextBoxSend As TextBox
    Friend WithEvents ButtonSend As Button
    Friend WithEvents ButtonProbe As Button
    Friend WithEvents CheckBoxVerbose As CheckBox
    Friend WithEvents ButtonHome As Button
    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents TabPageControl As TabPage
    Friend WithEvents TabPageFile As TabPage
    Friend WithEvents TabPageConsole As TabPage
    Friend WithEvents ButtonJogXNeg As Button
    Friend WithEvents ButtonYNeg As Button
    Friend WithEvents ButtonYPos As Button
    Friend WithEvents ButtonZNeg As Button
    Friend WithEvents ButtonZPos As Button
    Friend WithEvents ButtonSafeZ As Button
    Friend WithEvents ButtonG30 As Button
    Friend WithEvents ButtonG28 As Button
    Friend WithEvents PanelControl As Panel
    Friend WithEvents ButtonResume As Button
    Friend WithEvents ButtonFeedHold As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPrbThick As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPrbRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPrbDist As TextBox
    Friend WithEvents ButtonJog100 As Button
    Friend WithEvents ButtonJog10 As Button
    Friend WithEvents ButtonJog1 As Button
    Friend WithEvents ButtonJogPt1 As Button
    Friend WithEvents LabelJogInc As Label
    Friend WithEvents ButtonZeroAll As Button
    Friend WithEvents ButtonZeroZ As Button
    Friend WithEvents ButtonZeroY As Button
    Friend WithEvents Button1ZeroX As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItemOpenPort As ToolStripMenuItem
    Friend WithEvents ToolStripComboBoxPorts As ToolStripComboBox
    Friend WithEvents ToolStripMenuItemRefreshPorts As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents LabelAlert As Label
    Friend WithEvents TimerClearAlert As Timer
End Class

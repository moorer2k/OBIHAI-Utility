<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
    Inherits MetroFramework.Forms.MetroForm

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
        Me.ButtonDiscover = New MetroFramework.Controls.MetroButton()
        Me.TextPort = New MetroFramework.Controls.MetroTextBox()
        Me.TextIP = New MetroFramework.Controls.MetroTextBox()
        Me.RadLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.CheckSave = New MetroFramework.Controls.MetroCheckBox()
        Me.TextPass = New MetroFramework.Controls.MetroTextBox()
        Me.TextUser = New MetroFramework.Controls.MetroTextBox()
        Me.RadLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.RadLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ButtonSave = New MetroFramework.Controls.MetroButton()
        Me.ButtonReset = New MetroFramework.Controls.MetroButton()
        Me.ButtonCancel = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.labelStatus = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroToggle2 = New MetroFramework.Controls.MetroToggle()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonDiscover
        '
        Me.ButtonDiscover.Location = New System.Drawing.Point(37, 51)
        Me.ButtonDiscover.Name = "ButtonDiscover"
        Me.ButtonDiscover.Size = New System.Drawing.Size(110, 22)
        Me.ButtonDiscover.TabIndex = 18
        Me.ButtonDiscover.Text = "Start auto discovery"
        '
        'TextPort
        '
        Me.TextPort.Location = New System.Drawing.Point(198, 23)
        Me.TextPort.Name = "TextPort"
        Me.TextPort.Size = New System.Drawing.Size(48, 23)
        Me.TextPort.TabIndex = 17
        Me.TextPort.Text = "80"
        '
        'TextIP
        '
        Me.TextIP.Location = New System.Drawing.Point(37, 22)
        Me.TextIP.Name = "TextIP"
        Me.TextIP.Size = New System.Drawing.Size(110, 23)
        Me.TextIP.TabIndex = 16
        '
        'RadLabel3
        '
        Me.RadLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.RadLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.RadLabel3.Location = New System.Drawing.Point(5, 22)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(26, 22)
        Me.RadLabel3.TabIndex = 14
        Me.RadLabel3.Text = "IP:"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.CheckSave)
        Me.MetroPanel2.Controls.Add(Me.TextPass)
        Me.MetroPanel2.Controls.Add(Me.TextUser)
        Me.MetroPanel2.Controls.Add(Me.RadLabel2)
        Me.MetroPanel2.Controls.Add(Me.RadLabel1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 137)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(251, 95)
        Me.MetroPanel2.TabIndex = 3
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'CheckSave
        '
        Me.CheckSave.Location = New System.Drawing.Point(91, 74)
        Me.CheckSave.Name = "CheckSave"
        Me.CheckSave.Size = New System.Drawing.Size(137, 15)
        Me.CheckSave.TabIndex = 14
        Me.CheckSave.Text = "Remember user/pass."
        Me.CheckSave.UseVisualStyleBackColor = False
        '
        'TextPass
        '
        Me.TextPass.Location = New System.Drawing.Point(49, 48)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextPass.Size = New System.Drawing.Size(179, 20)
        Me.TextPass.TabIndex = 9
        '
        'TextUser
        '
        Me.TextUser.Location = New System.Drawing.Point(49, 26)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.Size = New System.Drawing.Size(179, 20)
        Me.TextUser.TabIndex = 8
        '
        'RadLabel2
        '
        Me.RadLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.RadLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.RadLabel2.Location = New System.Drawing.Point(4, 49)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(39, 19)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "Pass:"
        '
        'RadLabel1
        '
        Me.RadLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.RadLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.RadLabel1.Location = New System.Drawing.Point(4, 26)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(39, 20)
        Me.RadLabel1.TabIndex = 11
        Me.RadLabel1.Text = "User:"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(27, 350)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(85, 22)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(118, 350)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(78, 22)
        Me.ButtonReset.TabIndex = 15
        Me.ButtonReset.Text = "Reset"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(202, 350)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(76, 22)
        Me.ButtonCancel.TabIndex = 16
        Me.ButtonCancel.Text = "Cancel"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(262, 285)
        Me.MetroTabControl1.TabIndex = 17
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroTile2)
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel1)
        Me.MetroTabPage1.Controls.Add(Me.MetroTile1)
        Me.MetroTabPage1.Controls.Add(Me.MetroPanel2)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(254, 246)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "OBI Device Info"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.labelStatus)
        Me.MetroPanel1.Controls.Add(Me.TextPort)
        Me.MetroPanel1.Controls.Add(Me.ButtonDiscover)
        Me.MetroPanel1.Controls.Add(Me.TextIP)
        Me.MetroPanel1.Controls.Add(Me.RadLabel3)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 17)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(251, 111)
        Me.MetroPanel1.TabIndex = 19
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'labelStatus
        '
        Me.labelStatus.Location = New System.Drawing.Point(4, 76)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(241, 24)
        Me.labelStatus.TabIndex = 19
        Me.labelStatus.Text = "Status: Auto-discovery not running."
        Me.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage2.Controls.Add(Me.MetroTile3)
        Me.MetroTabPage2.Controls.Add(Me.MetroToggle2)
        Me.MetroTabPage2.Controls.Add(Me.MetroToggle1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(254, 246)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Notifications"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        '
        'MetroTile1
        '
        Me.MetroTile1.Location = New System.Drawing.Point(0, 134)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(251, 23)
        Me.MetroTile1.TabIndex = 15
        Me.MetroTile1.Text = "Authorization"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(153, 23)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(39, 22)
        Me.MetroLabel1.TabIndex = 20
        Me.MetroLabel1.Text = "Port:"
        '
        'MetroTile2
        '
        Me.MetroTile2.Location = New System.Drawing.Point(0, 3)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(251, 23)
        Me.MetroTile2.TabIndex = 21
        Me.MetroTile2.Text = "Network Settings"
        '
        'MetroToggle2
        '
        Me.MetroToggle2.AutoSize = True
        Me.MetroToggle2.Location = New System.Drawing.Point(169, 73)
        Me.MetroToggle2.Name = "MetroToggle2"
        Me.MetroToggle2.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle2.TabIndex = 5
        Me.MetroToggle2.Text = "Off"
        Me.MetroToggle2.UseVisualStyleBackColor = True
        '
        'MetroToggle1
        '
        Me.MetroToggle1.AutoSize = True
        Me.MetroToggle1.Location = New System.Drawing.Point(169, 38)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle1.TabIndex = 6
        Me.MetroToggle1.Text = "Off"
        Me.MetroToggle1.UseVisualStyleBackColor = True
        '
        'MetroTile3
        '
        Me.MetroTile3.Location = New System.Drawing.Point(3, 3)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(251, 23)
        Me.MetroTile3.TabIndex = 16
        Me.MetroTile3.Text = "Desktop Alerts"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 75)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(111, 15)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Play Sound On Call:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 38)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(114, 15)
        Me.MetroLabel3.TabIndex = 17
        Me.MetroLabel3.Text = "Popup Notification:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(120, 73)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(43, 23)
        Me.MetroButton1.TabIndex = 20
        Me.MetroButton1.Text = "..."
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 390)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonSave)
        Me.MaximizeBox = False
        Me.Name = "FormSettings"
        Me.Resizable = False
        Me.Text = "OBI-Utility Settings"
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents CheckSave As MetroFramework.Controls.MetroCheckBox
    Private WithEvents ButtonDiscover As MetroFramework.Controls.MetroButton
    Private WithEvents RadLabel3 As MetroFramework.Controls.MetroLabel
    Private WithEvents TextPass As MetroFramework.Controls.MetroTextBox
    Private WithEvents TextUser As MetroFramework.Controls.MetroTextBox
    Private WithEvents RadLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents RadLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents TextIP As MetroFramework.Controls.MetroTextBox
    Private WithEvents TextPort As MetroFramework.Controls.MetroTextBox
    Private WithEvents ButtonSave As MetroFramework.Controls.MetroButton
    Private WithEvents ButtonReset As MetroFramework.Controls.MetroButton
    Private WithEvents ButtonCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents labelStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Private WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroToggle2 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroToggle1 As MetroFramework.Controls.MetroToggle
    Private WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class

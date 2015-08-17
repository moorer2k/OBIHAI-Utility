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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.TextPort = New MetroFramework.Controls.MetroTextBox()
        Me.TextIP = New MetroFramework.Controls.MetroTextBox()
        Me.RadLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.RadLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.CheckSave = New MetroFramework.Controls.MetroCheckBox()
        Me.TextPass = New MetroFramework.Controls.MetroTextBox()
        Me.TextUser = New MetroFramework.Controls.MetroTextBox()
        Me.RadLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.RadLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.ButtonSave = New MetroFramework.Controls.MetroButton()
        Me.ButtonReset = New MetroFramework.Controls.MetroButton()
        Me.ButtonCancel = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroButton1)
        Me.MetroPanel1.Controls.Add(Me.TextPort)
        Me.MetroPanel1.Controls.Add(Me.TextIP)
        Me.MetroPanel1.Controls.Add(Me.RadLabel4)
        Me.MetroPanel1.Controls.Add(Me.RadLabel3)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(17, 72)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(229, 76)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(186, 13)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(37, 51)
        Me.MetroButton1.TabIndex = 18
        Me.MetroButton1.Text = "Find"
        '
        'TextPort
        '
        Me.TextPort.Location = New System.Drawing.Point(71, 41)
        Me.TextPort.Name = "TextPort"
        Me.TextPort.Size = New System.Drawing.Size(109, 23)
        Me.TextPort.TabIndex = 17
        Me.TextPort.Text = "80"
        '
        'TextIP
        '
        Me.TextIP.Location = New System.Drawing.Point(71, 12)
        Me.TextIP.Name = "TextIP"
        Me.TextIP.Size = New System.Drawing.Size(109, 23)
        Me.TextIP.TabIndex = 16
        '
        'RadLabel4
        '
        Me.RadLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.RadLabel4.Location = New System.Drawing.Point(6, 41)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(157, 23)
        Me.RadLabel4.TabIndex = 15
        Me.RadLabel4.Text = "Port: "
        '
        'RadLabel3
        '
        Me.RadLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.RadLabel3.Location = New System.Drawing.Point(3, 13)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(157, 22)
        Me.RadLabel3.TabIndex = 14
        Me.RadLabel3.Text = "IP Address: "
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "OBI IP/Port"
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
        Me.MetroPanel2.Location = New System.Drawing.Point(17, 174)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(229, 86)
        Me.MetroPanel2.TabIndex = 3
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'CheckSave
        '
        Me.CheckSave.Location = New System.Drawing.Point(71, 64)
        Me.CheckSave.Name = "CheckSave"
        Me.CheckSave.Size = New System.Drawing.Size(137, 15)
        Me.CheckSave.TabIndex = 14
        Me.CheckSave.Text = "Remember user/pass."
        Me.CheckSave.UseVisualStyleBackColor = False
        '
        'TextPass
        '
        Me.TextPass.Location = New System.Drawing.Point(71, 38)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextPass.Size = New System.Drawing.Size(139, 20)
        Me.TextPass.TabIndex = 9
        '
        'TextUser
        '
        Me.TextUser.Location = New System.Drawing.Point(71, 16)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.Size = New System.Drawing.Size(139, 20)
        Me.TextUser.TabIndex = 8
        '
        'RadLabel2
        '
        Me.RadLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.RadLabel2.Location = New System.Drawing.Point(3, 39)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(215, 19)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "Password: "
        '
        'RadLabel1
        '
        Me.RadLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.RadLabel1.Location = New System.Drawing.Point(3, 16)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(207, 20)
        Me.RadLabel1.TabIndex = 11
        Me.RadLabel1.Text = "Username: "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 161)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "User Credentials"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(17, 269)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(85, 22)
        Me.ButtonSave.TabIndex = 13
        Me.ButtonSave.Text = "Save"
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(108, 269)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(56, 22)
        Me.ButtonReset.TabIndex = 15
        Me.ButtonReset.Text = "Reset"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(170, 269)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(76, 22)
        Me.ButtonCancel.TabIndex = 16
        Me.ButtonCancel.Text = "Cancel"
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 300)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.Name = "FormSettings"
        Me.Resizable = False
        Me.Text = "OBI-Utility Settings"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents CheckSave As MetroFramework.Controls.MetroCheckBox
    Private WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Private WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents RadLabel4 As MetroFramework.Controls.MetroLabel
    Private WithEvents RadLabel3 As MetroFramework.Controls.MetroLabel
    Private WithEvents TextPass As MetroFramework.Controls.MetroTextBox
    Private WithEvents TextUser As MetroFramework.Controls.MetroTextBox
    Private WithEvents RadLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents RadLabel1 As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Private WithEvents TextIP As MetroFramework.Controls.MetroTextBox
    Private WithEvents TextPort As MetroFramework.Controls.MetroTextBox
    Private WithEvents ButtonSave As MetroFramework.Controls.MetroButton
    Private WithEvents ButtonReset As MetroFramework.Controls.MetroButton
    Private WithEvents ButtonCancel As MetroFramework.Controls.MetroButton
End Class



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.ObjectListView1 = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.MetroToggle2 = New MetroFramework.Controls.MetroToggle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.LabelStatus = New MetroFramework.Controls.MetroLabel()
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.ButtonAbout = New MetroFramework.Controls.MetroTile()
        Me.ButtonSettings = New MetroFramework.Controls.MetroTile()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.ButtonStart = New MetroFramework.Controls.MetroTile()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroTabControl1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = False
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 0
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 100)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(434, 301)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = False
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 0
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(434, 301)
        Me.MetroTabControl1.TabIndex = 3
        Me.MetroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.ObjectListView1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarSize = 0
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(426, 262)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Call History"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarSize = 0
        '
        'ObjectListView1
        '
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn1)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn2)
        Me.ObjectListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn2})
        Me.ObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObjectListView1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjectListView1.FullRowSelect = True
        Me.ObjectListView1.HasCollapsibleGroups = False
        Me.ObjectListView1.Location = New System.Drawing.Point(0, 0)
        Me.ObjectListView1.Name = "ObjectListView1"
        Me.ObjectListView1.ShowGroups = False
        Me.ObjectListView1.Size = New System.Drawing.Size(426, 262)
        Me.ObjectListView1.TabIndex = 2
        Me.ObjectListView1.UseCompatibleStateImageBehavior = False
        Me.ObjectListView1.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "PhoneNumber"
        Me.OlvColumn1.CellPadding = Nothing
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Text = "Phone #"
        Me.OlvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Width = 138
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "DateTime"
        Me.OlvColumn2.CellPadding = Nothing
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Text = "Date/Time"
        Me.OlvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Width = 120
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroToggle1)
        Me.MetroTabPage2.Controls.Add(Me.MetroToggle2)
        Me.MetroTabPage2.Controls.Add(Me.GroupBox2)
        Me.MetroTabPage2.Controls.Add(Me.GroupBox1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarSize = 0
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 4)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(426, 262)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Notifications"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarSize = 0
        Me.MetroTabPage2.Visible = False
        '
        'MetroToggle1
        '
        Me.MetroToggle1.AutoSize = True
        Me.MetroToggle1.Location = New System.Drawing.Point(274, 67)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle1.TabIndex = 4
        Me.MetroToggle1.Text = "Off"
        Me.MetroToggle1.UseVisualStyleBackColor = True
        '
        'MetroToggle2
        '
        Me.MetroToggle2.AutoSize = True
        Me.MetroToggle2.Location = New System.Drawing.Point(274, 187)
        Me.MetroToggle2.Name = "MetroToggle2"
        Me.MetroToggle2.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle2.TabIndex = 4
        Me.MetroToggle2.Text = "Off"
        Me.MetroToggle2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.GroupBox2, True)
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(72, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 37)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Desktop Popup Notifications"
        '
        'GroupBox1
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.GroupBox1, True)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.MetroButton1)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(72, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 71)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sound Notifications"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(235, 28)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(38, 23)
        Me.MetroButton1.TabIndex = 8
        Me.MetroButton1.Text = "..."
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Location = New System.Drawing.Point(75, 28)
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroTextBox1.Size = New System.Drawing.Size(154, 23)
        Me.MetroTextBox1.TabIndex = 6
        Me.MetroTextBox1.Text = "MetroTextBox1"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(6, 28)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(63, 23)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "Audio File:"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.LabelStatus)
        Me.MetroTabPage3.Controls.Add(Me.MetroProgressSpinner1)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarSize = 0
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 4)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(426, 262)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Live Statistics"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarSize = 0
        Me.MetroTabPage3.Visible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.CustomForeColor = True
        Me.LabelStatus.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LabelStatus.ForeColor = System.Drawing.Color.Maroon
        Me.LabelStatus.Location = New System.Drawing.Point(0, 90)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(426, 76)
        Me.LabelStatus.Style = MetroFramework.MetroColorStyle.Green
        Me.LabelStatus.TabIndex = 2
        Me.LabelStatus.Text = "Status: Waiting for calls.."
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(175, 3)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(76, 54)
        Me.MetroProgressSpinner1.TabIndex = 5
        '
        'ButtonAbout
        '
        Me.ButtonAbout.Location = New System.Drawing.Point(344, 7)
        Me.ButtonAbout.Name = "ButtonAbout"
        Me.ButtonAbout.Size = New System.Drawing.Size(86, 27)
        Me.ButtonAbout.TabIndex = 2
        Me.ButtonAbout.Text = "About"
        Me.ButtonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonAbout.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.ButtonAbout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        '
        'ButtonSettings
        '
        Me.ButtonSettings.Location = New System.Drawing.Point(173, 7)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(89, 27)
        Me.ButtonSettings.TabIndex = 3
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.ButtonSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroTile1)
        Me.MetroPanel2.Controls.Add(Me.ButtonAbout)
        Me.MetroPanel2.Controls.Add(Me.ButtonStart)
        Me.MetroPanel2.Controls.Add(Me.ButtonSettings)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(434, 40)
        Me.MetroPanel2.TabIndex = 5
        Me.MetroPanel2.VerticalScrollbarBarColor = False
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroTile1
        '
        Me.MetroTile1.Location = New System.Drawing.Point(268, 7)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(70, 27)
        Me.MetroTile1.TabIndex = 5
        Me.MetroTile1.Text = "Exit"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(4, 7)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(139, 27)
        Me.ButtonStart.TabIndex = 4
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonStart.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStart.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.ButtonStart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroToolTip1.SetToolTip(Me.ButtonStart, "Try it baby.")
        Me.ButtonStart.UseTileImage = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 421)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(474, 421)
        Me.Name = "FormMain"
        Me.Resizable = False
        Me.Text = "OBI Utilities v1.0"
        Me.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ObjectListView1 As BrightIdeasSoftware.ObjectListView
    Friend WithEvents MetroToggle2 As MetroFramework.Controls.MetroToggle
    Private WithEvents ButtonAbout As MetroFramework.Controls.MetroTile
    Private WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Private WithEvents ButtonSettings As MetroFramework.Controls.MetroTile
    Public WithEvents ButtonStart As MetroFramework.Controls.MetroTile
    Private WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Private WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Private WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Private WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Private WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Private WithEvents LabelStatus As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MetroToggle1 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class

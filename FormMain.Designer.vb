

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
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.ObjectListView1 = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.ButtonRemoveAll = New MetroFramework.Controls.MetroButton()
        Me.ButtonRefresh = New MetroFramework.Controls.MetroButton()
        Me.ButtonExport = New MetroFramework.Controls.MetroButton()
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
        Me.MetroTabControl2.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel3.SuspendLayout()
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
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(434, 301)
        Me.MetroTabControl1.TabIndex = 3
        Me.MetroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroTabControl2)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarSize = 0
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(426, 262)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Call History"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarSize = 0
        Me.MetroTabPage1.Visible = False
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(426, 262)
        Me.MetroTabControl2.TabIndex = 3
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.ObjectListView1)
        Me.MetroTabPage4.Controls.Add(Me.MetroPanel3)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(418, 223)
        Me.MetroTabPage4.TabIndex = 0
        Me.MetroTabPage4.Text = "Archived Calls"
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        '
        'ObjectListView1
        '
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn1)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn2)
        Me.ObjectListView1.AllColumns.Add(Me.OlvColumn3)
        Me.ObjectListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ObjectListView1.CellEditUseWholeCell = False
        Me.ObjectListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3})
        Me.ObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ObjectListView1.FullRowSelect = True
        Me.ObjectListView1.HasCollapsibleGroups = False
        Me.ObjectListView1.Location = New System.Drawing.Point(0, 0)
        Me.ObjectListView1.Name = "ObjectListView1"
        Me.ObjectListView1.SelectedBackColor = System.Drawing.Color.Transparent
        Me.ObjectListView1.SelectedColumnTint = System.Drawing.Color.Transparent
        Me.ObjectListView1.SelectedForeColor = System.Drawing.Color.Transparent
        Me.ObjectListView1.ShowGroups = False
        Me.ObjectListView1.Size = New System.Drawing.Size(418, 186)
        Me.ObjectListView1.TabIndex = 2
        Me.ObjectListView1.UseCompatibleStateImageBehavior = False
        Me.ObjectListView1.UseHotControls = False
        Me.ObjectListView1.UseTranslucentSelection = True
        Me.ObjectListView1.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "PhoneNumber"
        Me.OlvColumn1.FillsFreeSpace = True
        Me.OlvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn1.Text = "Phone #"
        Me.OlvColumn1.Width = 138
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "DateTime"
        Me.OlvColumn2.FillsFreeSpace = True
        Me.OlvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn2.Text = "Date/Time"
        Me.OlvColumn2.Width = 120
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "Direction"
        Me.OlvColumn3.FillsFreeSpace = True
        Me.OlvColumn3.Text = "Call Type"
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.ButtonRemoveAll)
        Me.MetroPanel3.Controls.Add(Me.ButtonRefresh)
        Me.MetroPanel3.Controls.Add(Me.ButtonExport)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(0, 186)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(418, 37)
        Me.MetroPanel3.TabIndex = 3
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'ButtonRemoveAll
        '
        Me.ButtonRemoveAll.Location = New System.Drawing.Point(105, 3)
        Me.ButtonRemoveAll.Name = "ButtonRemoveAll"
        Me.ButtonRemoveAll.Size = New System.Drawing.Size(96, 31)
        Me.ButtonRemoveAll.TabIndex = 2
        Me.ButtonRemoveAll.Text = "Remove All"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(3, 3)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(96, 31)
        Me.ButtonRefresh.TabIndex = 2
        Me.ButtonRefresh.Text = "Refresh"
        '
        'ButtonExport
        '
        Me.ButtonExport.Location = New System.Drawing.Point(207, 3)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(96, 31)
        Me.ButtonExport.TabIndex = 2
        Me.ButtonExport.Text = "Export"
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
        Me.LabelStatus.Location = New System.Drawing.Point(0, 224)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(426, 38)
        Me.LabelStatus.Style = MetroFramework.MetroColorStyle.Green
        Me.LabelStatus.TabIndex = 2
        Me.LabelStatus.Text = "Status: Not authroized. Please sign in."
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(107, 39)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(208, 165)
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
        Me.ButtonStart.Size = New System.Drawing.Size(163, 27)
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
        Me.MetroTabControl2.ResumeLayout(False)
        Me.MetroTabPage4.ResumeLayout(False)
        CType(Me.ObjectListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel3.ResumeLayout(False)
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
    Private WithEvents ButtonAbout As MetroFramework.Controls.MetroTile
    Private WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Private WithEvents ButtonSettings As MetroFramework.Controls.MetroTile
    Private WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Private WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Private WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Private WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Private WithEvents LabelStatus As MetroFramework.Controls.MetroLabel
    Private WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Public WithEvents ButtonStart As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents ButtonRemoveAll As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonRefresh As MetroFramework.Controls.MetroButton
    Friend WithEvents ButtonExport As MetroFramework.Controls.MetroButton
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Private WithEvents ObjectListView1 As BrightIdeasSoftware.ObjectListView
End Class

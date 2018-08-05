<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ListContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveFirstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveLastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemAfterThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemBeforeThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTheViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AddTotalSpace = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.DontClear = New System.Windows.Forms.CheckBox()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ItemsList = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SizeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OptionsPanel = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuButton = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LocationButton = New System.Windows.Forms.Button()
        Me.TopPanel1 = New System.Windows.Forms.Panel()
        Me.MaximizeButton = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.EndButton = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ContentIcon = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListContextMenuStrip.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        Me.OptionsPanel.SuspendLayout()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel1.SuspendLayout()
        CType(Me.MaximizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContentIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListContextMenuStrip
        '
        Me.ListContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteThisItemToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.MoveUpToolStripMenuItem, Me.MoveDownToolStripMenuItem, Me.MoveFirstToolStripMenuItem, Me.MoveLastToolStripMenuItem, Me.AddItemAfterThisItemToolStripMenuItem, Me.AddItemBeforeThisItemToolStripMenuItem, Me.ChangeTheViewToolStripMenuItem})
        Me.ListContextMenuStrip.Name = "ContextMenuStrip2"
        Me.ListContextMenuStrip.Size = New System.Drawing.Size(210, 202)
        '
        'DeleteThisItemToolStripMenuItem
        '
        Me.DeleteThisItemToolStripMenuItem.Name = "DeleteThisItemToolStripMenuItem"
        Me.DeleteThisItemToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DeleteThisItemToolStripMenuItem.Text = "Delete item\items"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'MoveUpToolStripMenuItem
        '
        Me.MoveUpToolStripMenuItem.Image = CType(resources.GetObject("MoveUpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoveUpToolStripMenuItem.Name = "MoveUpToolStripMenuItem"
        Me.MoveUpToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MoveUpToolStripMenuItem.Text = "Move Up"
        '
        'MoveDownToolStripMenuItem
        '
        Me.MoveDownToolStripMenuItem.Image = CType(resources.GetObject("MoveDownToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoveDownToolStripMenuItem.Name = "MoveDownToolStripMenuItem"
        Me.MoveDownToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MoveDownToolStripMenuItem.Text = "Move Down"
        '
        'MoveFirstToolStripMenuItem
        '
        Me.MoveFirstToolStripMenuItem.Image = CType(resources.GetObject("MoveFirstToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoveFirstToolStripMenuItem.Name = "MoveFirstToolStripMenuItem"
        Me.MoveFirstToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MoveFirstToolStripMenuItem.Text = "Move First"
        '
        'MoveLastToolStripMenuItem
        '
        Me.MoveLastToolStripMenuItem.Image = CType(resources.GetObject("MoveLastToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoveLastToolStripMenuItem.Name = "MoveLastToolStripMenuItem"
        Me.MoveLastToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MoveLastToolStripMenuItem.Text = "Move Last"
        '
        'AddItemAfterThisItemToolStripMenuItem
        '
        Me.AddItemAfterThisItemToolStripMenuItem.Name = "AddItemAfterThisItemToolStripMenuItem"
        Me.AddItemAfterThisItemToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AddItemAfterThisItemToolStripMenuItem.Text = "Add item after this item"
        '
        'AddItemBeforeThisItemToolStripMenuItem
        '
        Me.AddItemBeforeThisItemToolStripMenuItem.Name = "AddItemBeforeThisItemToolStripMenuItem"
        Me.AddItemBeforeThisItemToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AddItemBeforeThisItemToolStripMenuItem.Text = "Add item before this item"
        '
        'ChangeTheViewToolStripMenuItem
        '
        Me.ChangeTheViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsDefaultToolStripMenuItem, Me.ListToolStripMenuItem, Me.TilesToolStripMenuItem})
        Me.ChangeTheViewToolStripMenuItem.Name = "ChangeTheViewToolStripMenuItem"
        Me.ChangeTheViewToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ChangeTheViewToolStripMenuItem.Text = "Change the view"
        '
        'DetailsDefaultToolStripMenuItem
        '
        Me.DetailsDefaultToolStripMenuItem.Name = "DetailsDefaultToolStripMenuItem"
        Me.DetailsDefaultToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DetailsDefaultToolStripMenuItem.Text = "Details (Default)"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'TilesToolStripMenuItem
        '
        Me.TilesToolStripMenuItem.Name = "TilesToolStripMenuItem"
        Me.TilesToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TilesToolStripMenuItem.Text = "Tile"
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LocationLabel.Location = New System.Drawing.Point(307, 9)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(59, 15)
        Me.LocationLabel.TabIndex = 4
        Me.LocationLabel.Text = "Location :"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 372)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(109, 22)
        Me.TextBox2.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Space In MB:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(56, 344)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 22)
        Me.TextBox1.TabIndex = 13
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(0, 260)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(197, 33)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Move Last"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 220)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(197, 33)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Move First"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 179)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(197, 33)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Move Down"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 140)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(197, 33)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Move Up"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(197, 33)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "   Add Custom Item"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AddTotalSpace
        '
        Me.AddTotalSpace.AutoSize = True
        Me.AddTotalSpace.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTotalSpace.Location = New System.Drawing.Point(6, 500)
        Me.AddTotalSpace.Name = "AddTotalSpace"
        Me.AddTotalSpace.Size = New System.Drawing.Size(176, 19)
        Me.AddTotalSpace.TabIndex = 11
        Me.AddTotalSpace.Text = "Add Total Space to save text"
        Me.AddTotalSpace.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(6, 525)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(171, 19)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "Add Total Items to save text"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 588)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Items :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 558)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total Space :"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(6, 475)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(145, 19)
        Me.CheckBox5.TabIndex = 7
        Me.CheckBox5.Text = "Subdirectory included"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(6, 450)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(158, 19)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Space included (Slower)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'DontClear
        '
        Me.DontClear.AutoSize = True
        Me.DontClear.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DontClear.Location = New System.Drawing.Point(6, 425)
        Me.DontClear.Name = "DontClear"
        Me.DontClear.Size = New System.Drawing.Size(84, 19)
        Me.DontClear.TabIndex = 6
        Me.DontClear.Text = "Don't clear"
        Me.ToolTip1.SetToolTip(Me.DontClear, "Don't clear Listbox when changing directory")
        Me.DontClear.UseVisualStyleBackColor = False
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.AlwaysOnTopToolStripMenuItem, Me.AboutToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.MainContextMenuStrip.Name = "ContextMenuStrip1"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(171, 92)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always On Top"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Image = CType(resources.GetObject("EndToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Content Reader"
        Me.SaveFileDialog1.Filter = "Text Document (*.txt)|*.txt|CSV (*.csv)|*.csv"
        Me.SaveFileDialog1.Title = "Save File"
        '
        'ItemsList
        '
        Me.ItemsList.AllowDrop = True
        Me.ItemsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemsList.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ItemsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.SizeColumn})
        Me.ItemsList.ContextMenuStrip = Me.ListContextMenuStrip
        Me.ItemsList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsList.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ItemsList.FullRowSelect = True
        Me.ItemsList.GridLines = True
        Me.ItemsList.LabelEdit = True
        Me.ItemsList.Location = New System.Drawing.Point(205, 39)
        Me.ItemsList.Name = "ItemsList"
        Me.ItemsList.Size = New System.Drawing.Size(475, 595)
        Me.ItemsList.TabIndex = 7
        Me.ItemsList.UseCompatibleStateImageBehavior = False
        Me.ItemsList.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 290
        '
        'SizeColumn
        '
        Me.SizeColumn.Text = "Size"
        Me.SizeColumn.Width = 169
        '
        'OptionsPanel
        '
        Me.OptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OptionsPanel.ContextMenuStrip = Me.MainContextMenuStrip
        Me.OptionsPanel.Controls.Add(Me.Label3)
        Me.OptionsPanel.Controls.Add(Me.Label13)
        Me.OptionsPanel.Controls.Add(Me.AddTotalSpace)
        Me.OptionsPanel.Controls.Add(Me.Label2)
        Me.OptionsPanel.Controls.Add(Me.Label12)
        Me.OptionsPanel.Controls.Add(Me.CheckBox5)
        Me.OptionsPanel.Controls.Add(Me.CheckBox3)
        Me.OptionsPanel.Controls.Add(Me.TextBox2)
        Me.OptionsPanel.Controls.Add(Me.Label11)
        Me.OptionsPanel.Controls.Add(Me.CheckBox2)
        Me.OptionsPanel.Controls.Add(Me.Label5)
        Me.OptionsPanel.Controls.Add(Me.Label10)
        Me.OptionsPanel.Controls.Add(Me.TextBox1)
        Me.OptionsPanel.Controls.Add(Me.DontClear)
        Me.OptionsPanel.Controls.Add(Me.Label4)
        Me.OptionsPanel.Controls.Add(Me.Label9)
        Me.OptionsPanel.Controls.Add(Me.Label8)
        Me.OptionsPanel.Controls.Add(Me.Label7)
        Me.OptionsPanel.Controls.Add(Me.MenuButton)
        Me.OptionsPanel.Controls.Add(Me.Label6)
        Me.OptionsPanel.Controls.Add(Me.LocationButton)
        Me.OptionsPanel.Controls.Add(Me.Button3)
        Me.OptionsPanel.Controls.Add(Me.Button7)
        Me.OptionsPanel.Controls.Add(Me.Button2)
        Me.OptionsPanel.Controls.Add(Me.Button6)
        Me.OptionsPanel.Controls.Add(Me.Button4)
        Me.OptionsPanel.Controls.Add(Me.Button5)
        Me.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.OptionsPanel.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.OptionsPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.OptionsPanel.Location = New System.Drawing.Point(0, 33)
        Me.OptionsPanel.Name = "OptionsPanel"
        Me.OptionsPanel.Size = New System.Drawing.Size(200, 613)
        Me.OptionsPanel.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(0, 550)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 2)
        Me.Label13.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(0, 407)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 2)
        Me.Label12.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(0, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 2)
        Me.Label11.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(0, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 2)
        Me.Label10.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(0, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 2)
        Me.Label9.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(0, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 2)
        Me.Label8.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(0, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 2)
        Me.Label7.TabIndex = 16
        '
        'MenuButton
        '
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.Image = CType(resources.GetObject("MenuButton.Image"), System.Drawing.Image)
        Me.MenuButton.Location = New System.Drawing.Point(162, 6)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(25, 25)
        Me.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MenuButton.TabIndex = 15
        Me.MenuButton.TabStop = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(0, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 2)
        Me.Label6.TabIndex = 14
        '
        'LocationButton
        '
        Me.LocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LocationButton.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LocationButton.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LocationButton.Image = CType(resources.GetObject("LocationButton.Image"), System.Drawing.Image)
        Me.LocationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LocationButton.Location = New System.Drawing.Point(0, 37)
        Me.LocationButton.Name = "LocationButton"
        Me.LocationButton.Size = New System.Drawing.Size(197, 33)
        Me.LocationButton.TabIndex = 1
        Me.LocationButton.Text = ".."
        Me.LocationButton.UseVisualStyleBackColor = True
        '
        'TopPanel1
        '
        Me.TopPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TopPanel1.ContextMenuStrip = Me.MainContextMenuStrip
        Me.TopPanel1.Controls.Add(Me.LocationLabel)
        Me.TopPanel1.Controls.Add(Me.MaximizeButton)
        Me.TopPanel1.Controls.Add(Me.MinimizeButton)
        Me.TopPanel1.Controls.Add(Me.EndButton)
        Me.TopPanel1.Controls.Add(Me.TitleLabel)
        Me.TopPanel1.Controls.Add(Me.ContentIcon)
        Me.TopPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel1.Name = "TopPanel1"
        Me.TopPanel1.Size = New System.Drawing.Size(692, 33)
        Me.TopPanel1.TabIndex = 9
        '
        'MaximizeButton
        '
        Me.MaximizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeButton.Image = CType(resources.GetObject("MaximizeButton.Image"), System.Drawing.Image)
        Me.MaximizeButton.Location = New System.Drawing.Point(636, 6)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(20, 19)
        Me.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaximizeButton.TabIndex = 4
        Me.MaximizeButton.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeButton.Image = CType(resources.GetObject("MinimizeButton.Image"), System.Drawing.Image)
        Me.MinimizeButton.Location = New System.Drawing.Point(610, 6)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(20, 20)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizeButton.TabIndex = 3
        Me.MinimizeButton.TabStop = False
        '
        'EndButton
        '
        Me.EndButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EndButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EndButton.Image = CType(resources.GetObject("EndButton.Image"), System.Drawing.Image)
        Me.EndButton.Location = New System.Drawing.Point(662, 6)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(20, 20)
        Me.EndButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EndButton.TabIndex = 2
        Me.EndButton.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TitleLabel.Location = New System.Drawing.Point(46, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(147, 16)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "B++ -Content Reader-"
        '
        'ContentIcon
        '
        Me.ContentIcon.Image = CType(resources.GetObject("ContentIcon.Image"), System.Drawing.Image)
        Me.ContentIcon.Location = New System.Drawing.Point(12, 6)
        Me.ContentIcon.Name = "ContentIcon"
        Me.ContentIcon.Size = New System.Drawing.Size(28, 24)
        Me.ContentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ContentIcon.TabIndex = 0
        Me.ContentIcon.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.ToolTip1.InitialDelay = 1500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(692, 646)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.OptionsPanel)
        Me.Controls.Add(Me.ItemsList)
        Me.Controls.Add(Me.TopPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Content Reader"
        Me.ListContextMenuStrip.ResumeLayout(False)
        Me.MainContextMenuStrip.ResumeLayout(False)
        Me.OptionsPanel.ResumeLayout(False)
        Me.OptionsPanel.PerformLayout()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel1.ResumeLayout(False)
        Me.TopPanel1.PerformLayout()
        CType(Me.MaximizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContentIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LocationLabel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DontClear As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AddTotalSpace As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MainContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ListContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemsList As System.Windows.Forms.ListView
    Friend WithEvents NameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents SizeColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents MoveUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemAfterThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemBeforeThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MoveFirstToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveLastToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeTheViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OptionsPanel As Panel
    Friend WithEvents TopPanel1 As Panel
    Friend WithEvents MaximizeButton As PictureBox
    Friend WithEvents MinimizeButton As PictureBox
    Friend WithEvents EndButton As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ContentIcon As PictureBox
    Friend WithEvents MenuButton As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LocationButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
End Class

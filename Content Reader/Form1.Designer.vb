<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemAfterThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemBeforeThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MoveFirstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveLastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTheViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select Directory ..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteThisItemToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.MoveUpToolStripMenuItem, Me.MoveDownToolStripMenuItem, Me.MoveFirstToolStripMenuItem, Me.MoveLastToolStripMenuItem, Me.AddItemAfterThisItemToolStripMenuItem, Me.AddItemBeforeThisItemToolStripMenuItem, Me.ChangeTheViewToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(210, 224)
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
        Me.MoveUpToolStripMenuItem.Name = "MoveUpToolStripMenuItem"
        Me.MoveUpToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MoveUpToolStripMenuItem.Text = "Move Up ↑"
        '
        'MoveDownToolStripMenuItem
        '
        Me.MoveDownToolStripMenuItem.Name = "MoveDownToolStripMenuItem"
        Me.MoveDownToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MoveDownToolStripMenuItem.Text = "Move Down ↓"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Location :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(133, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CheckBox5)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 148)
        Me.Panel1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(307, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(359, 51)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(103, 23)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Move Last ↓↓"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(253, 51)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Move First ↑↑"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(359, 28)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Move Down ↓"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(253, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Move Up ↑ "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(214, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Add Item"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(7, 77)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(166, 17)
        Me.CheckBox4.TabIndex = 11
        Me.CheckBox4.Text = "Add Total Space to save text"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(7, 55)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(164, 17)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "Add Total Items to save text"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Items :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total Space :"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(7, 126)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(129, 17)
        Me.CheckBox5.TabIndex = 7
        Me.CheckBox5.Text = "Subdirectory included"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 103)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Space included (Slower)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(235, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Don't clear Listbox when changing directory"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Image = CType(resources.GetObject("EndToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Content Reader"
        Me.SaveFileDialog1.Filter = "Text Document (*.txt)|*.txt|CSV (*.csv)|*.csv"
        Me.SaveFileDialog1.Title = "Save File"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.LabelEdit = True
        Me.ListView1.Location = New System.Drawing.Point(3, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(475, 355)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 272
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Size"
        Me.ColumnHeader2.Width = 169
        '
        'MoveFirstToolStripMenuItem
        '
        Me.MoveFirstToolStripMenuItem.Name = "MoveFirstToolStripMenuItem"
        Me.MoveFirstToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MoveFirstToolStripMenuItem.Text = "Move First ↑↑"
        '
        'MoveLastToolStripMenuItem
        '
        Me.MoveLastToolStripMenuItem.Name = "MoveLastToolStripMenuItem"
        Me.MoveLastToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MoveLastToolStripMenuItem.Text = "Move Last ↓↓"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(482, 524)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Content Reader"
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
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

End Class

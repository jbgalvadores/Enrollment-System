<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadmin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmadmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbladminoption = New System.Windows.Forms.Label()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coledit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.coldelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnsetactive = New System.Windows.Forms.Button()
        Me.btnaddnewyear = New System.Windows.Forms.Button()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.datagridview2 = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coledit2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.coldelete2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnupdatepassword = New System.Windows.Forms.Button()
        Me.btnaddnewaccount = New System.Windows.Forms.Button()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtmaxstudent = New System.Windows.Forms.TextBox()
        Me.btnsavemax = New System.Windows.Forms.Button()
        Me.btneditmax = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.datagridview2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbladminoption)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 39)
        Me.Panel1.TabIndex = 6
        '
        'lbladminoption
        '
        Me.lbladminoption.AutoSize = True
        Me.lbladminoption.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladminoption.ForeColor = System.Drawing.Color.Black
        Me.lbladminoption.Location = New System.Drawing.Point(12, 9)
        Me.lbladminoption.Name = "lbladminoption"
        Me.lbladminoption.Size = New System.Drawing.Size(87, 23)
        Me.lbladminoption.TabIndex = 0
        Me.lbladminoption.Text = "SETTINGS"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MetroTabPage1)
        Me.TabControl1.Controls.Add(Me.MetroTabPage2)
        Me.TabControl1.Controls.Add(Me.MetroTabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(929, 420)
        Me.TabControl1.TabIndex = 7
        Me.TabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.DataGridView1)
        Me.MetroTabPage1.Controls.Add(Me.Panel4)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 2
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(921, 378)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "ACADEMIC YEAR"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column10, Me.Column11, Me.Column4, Me.coledit, Me.coldelete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 35)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(921, 343)
        Me.DataGridView1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "AY Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Year 1"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "Year 2"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column10.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "Term"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'coledit
        '
        Me.coledit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coledit.HeaderText = ""
        Me.coledit.Image = Global.ProjectES.My.Resources.Resources.coledit
        Me.coledit.Name = "coledit"
        Me.coledit.ReadOnly = True
        Me.coledit.Width = 5
        '
        'coldelete
        '
        Me.coldelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldelete.HeaderText = ""
        Me.coldelete.Image = Global.ProjectES.My.Resources.Resources.coldelete
        Me.coldelete.Name = "coldelete"
        Me.coldelete.ReadOnly = True
        Me.coldelete.Width = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnsetactive)
        Me.Panel4.Controls.Add(Me.btnaddnewyear)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(921, 35)
        Me.Panel4.TabIndex = 2
        '
        'btnsetactive
        '
        Me.btnsetactive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsetactive.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnsetactive.FlatAppearance.BorderSize = 0
        Me.btnsetactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsetactive.ForeColor = System.Drawing.Color.White
        Me.btnsetactive.Image = Global.ProjectES.My.Resources.Resources._16
        Me.btnsetactive.Location = New System.Drawing.Point(131, 0)
        Me.btnsetactive.Name = "btnsetactive"
        Me.btnsetactive.Size = New System.Drawing.Size(143, 35)
        Me.btnsetactive.TabIndex = 1
        Me.btnsetactive.Text = "Set as Active"
        Me.btnsetactive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsetactive.UseVisualStyleBackColor = True
        '
        'btnaddnewyear
        '
        Me.btnaddnewyear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddnewyear.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnaddnewyear.FlatAppearance.BorderSize = 0
        Me.btnaddnewyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddnewyear.ForeColor = System.Drawing.Color.White
        Me.btnaddnewyear.Image = Global.ProjectES.My.Resources.Resources.addnew
        Me.btnaddnewyear.Location = New System.Drawing.Point(0, 0)
        Me.btnaddnewyear.Name = "btnaddnewyear"
        Me.btnaddnewyear.Size = New System.Drawing.Size(131, 35)
        Me.btnaddnewyear.TabIndex = 0
        Me.btnaddnewyear.Text = "Add New"
        Me.btnaddnewyear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddnewyear.UseVisualStyleBackColor = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.datagridview2)
        Me.MetroTabPage2.Controls.Add(Me.Panel7)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 2
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(921, 378)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "USER ACCOUNT"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'datagridview2
        '
        Me.datagridview2.AllowUserToAddRows = False
        Me.datagridview2.AllowUserToDeleteRows = False
        Me.datagridview2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.datagridview2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridview2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridview2.ColumnHeadersHeight = 30
        Me.datagridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridview2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9, Me.Column5, Me.Column6, Me.Column7, Me.coledit2, Me.coldelete2})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridview2.DefaultCellStyle = DataGridViewCellStyle4
        Me.datagridview2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridview2.EnableHeadersVisualStyles = False
        Me.datagridview2.Location = New System.Drawing.Point(0, 42)
        Me.datagridview2.MultiSelect = False
        Me.datagridview2.Name = "datagridview2"
        Me.datagridview2.ReadOnly = True
        Me.datagridview2.RowHeadersVisible = False
        Me.datagridview2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview2.Size = New System.Drawing.Size(921, 336)
        Me.datagridview2.TabIndex = 5
        '
        'Column8
        '
        Me.Column8.HeaderText = "#"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.HeaderText = "Image"
        Me.Column9.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 70
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Full Name"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Width = 59
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Username"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 58
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Designation"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'coledit2
        '
        Me.coledit2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coledit2.HeaderText = ""
        Me.coledit2.Image = Global.ProjectES.My.Resources.Resources.coledit
        Me.coledit2.Name = "coledit2"
        Me.coledit2.ReadOnly = True
        Me.coledit2.Width = 5
        '
        'coldelete2
        '
        Me.coldelete2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldelete2.HeaderText = ""
        Me.coldelete2.Image = CType(resources.GetObject("coldelete2.Image"), System.Drawing.Image)
        Me.coldelete2.Name = "coldelete2"
        Me.coldelete2.ReadOnly = True
        Me.coldelete2.Width = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel7.Controls.Add(Me.btnupdatepassword)
        Me.Panel7.Controls.Add(Me.btnaddnewaccount)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(921, 42)
        Me.Panel7.TabIndex = 4
        '
        'btnupdatepassword
        '
        Me.btnupdatepassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdatepassword.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnupdatepassword.FlatAppearance.BorderSize = 0
        Me.btnupdatepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdatepassword.ForeColor = System.Drawing.Color.White
        Me.btnupdatepassword.Image = Global.ProjectES.My.Resources.Resources.update
        Me.btnupdatepassword.Location = New System.Drawing.Point(732, 0)
        Me.btnupdatepassword.Name = "btnupdatepassword"
        Me.btnupdatepassword.Size = New System.Drawing.Size(189, 42)
        Me.btnupdatepassword.TabIndex = 2
        Me.btnupdatepassword.Text = "Update Password"
        Me.btnupdatepassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnupdatepassword.UseVisualStyleBackColor = True
        '
        'btnaddnewaccount
        '
        Me.btnaddnewaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddnewaccount.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnaddnewaccount.FlatAppearance.BorderSize = 0
        Me.btnaddnewaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddnewaccount.ForeColor = System.Drawing.Color.White
        Me.btnaddnewaccount.Image = Global.ProjectES.My.Resources.Resources.addnew
        Me.btnaddnewaccount.Location = New System.Drawing.Point(0, 0)
        Me.btnaddnewaccount.Name = "btnaddnewaccount"
        Me.btnaddnewaccount.Size = New System.Drawing.Size(131, 42)
        Me.btnaddnewaccount.TabIndex = 1
        Me.btnaddnewaccount.Text = "Add New"
        Me.btnaddnewaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddnewaccount.UseVisualStyleBackColor = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.Panel2)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 2
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(921, 378)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "SECTION"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtmaxstudent)
        Me.Panel2.Controls.Add(Me.btnsavemax)
        Me.Panel2.Controls.Add(Me.btneditmax)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 87)
        Me.Panel2.TabIndex = 2
        '
        'txtmaxstudent
        '
        Me.txtmaxstudent.Location = New System.Drawing.Point(349, 34)
        Me.txtmaxstudent.Name = "txtmaxstudent"
        Me.txtmaxstudent.Size = New System.Drawing.Size(160, 21)
        Me.txtmaxstudent.TabIndex = 49
        '
        'btnsavemax
        '
        Me.btnsavemax.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnsavemax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsavemax.Enabled = False
        Me.btnsavemax.FlatAppearance.BorderSize = 0
        Me.btnsavemax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsavemax.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavemax.ForeColor = System.Drawing.Color.White
        Me.btnsavemax.Location = New System.Drawing.Point(593, 32)
        Me.btnsavemax.Name = "btnsavemax"
        Me.btnsavemax.Size = New System.Drawing.Size(71, 28)
        Me.btnsavemax.TabIndex = 48
        Me.btnsavemax.Text = "Save"
        Me.btnsavemax.UseVisualStyleBackColor = False
        '
        'btneditmax
        '
        Me.btneditmax.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btneditmax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneditmax.FlatAppearance.BorderSize = 0
        Me.btneditmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditmax.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditmax.ForeColor = System.Drawing.Color.White
        Me.btneditmax.Location = New System.Drawing.Point(516, 32)
        Me.btneditmax.Name = "btneditmax"
        Me.btneditmax.Size = New System.Drawing.Size(71, 28)
        Me.btneditmax.TabIndex = 47
        Me.btneditmax.Text = "Edit"
        Me.btneditmax.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(213, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Max Student / Sec"
        '
        'frmadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 459)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmadmin"
        Me.Text = "frmadmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        CType(Me.datagridview2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbladminoption As Label
    Friend WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnupdatepassword As Button
    Friend WithEvents btnaddnewaccount As Button
    Friend WithEvents datagridview2 As DataGridView

    Private Sub btnaddnewaccount_Click(sender As Object, e As EventArgs) Handles btnaddnewaccount.Click

    End Sub

    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtmaxstudent As TextBox
    Friend WithEvents btnsavemax As Button
    Friend WithEvents btneditmax As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnsetactive As Button
    Friend WithEvents btnaddnewyear As Button
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents coledit2 As DataGridViewImageColumn
    Friend WithEvents coldelete2 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents coledit As DataGridViewImageColumn
    Friend WithEvents coldelete As DataGridViewImageColumn
End Class

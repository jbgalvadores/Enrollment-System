<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmenrolling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblenrollment = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblstudentenrolled = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblsearchstudent = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtadviser = New System.Windows.Forms.TextBox()
        Me.lblsectionfull = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cbosection = New System.Windows.Forms.ComboBox()
        Me.cbostrand = New System.Windows.Forms.ComboBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtroom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtgradelevel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.txtsid = New System.Windows.Forms.TextBox()
        Me.txtaycode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblenrollment)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 43)
        Me.Panel1.TabIndex = 8
        '
        'lblenrollment
        '
        Me.lblenrollment.AutoSize = True
        Me.lblenrollment.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenrollment.ForeColor = System.Drawing.Color.Black
        Me.lblenrollment.Location = New System.Drawing.Point(14, 10)
        Me.lblenrollment.Name = "lblenrollment"
        Me.lblenrollment.Size = New System.Drawing.Size(118, 23)
        Me.lblenrollment.TabIndex = 0
        Me.lblenrollment.Text = "ENROLLMENT"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblstudentenrolled)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.txtsearch)
        Me.Panel3.Controls.Add(Me.lblsearchstudent)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(995, 46)
        Me.Panel3.TabIndex = 20
        '
        'lblstudentenrolled
        '
        Me.lblstudentenrolled.AutoSize = True
        Me.lblstudentenrolled.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentenrolled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblstudentenrolled.Location = New System.Drawing.Point(482, 13)
        Me.lblstudentenrolled.Name = "lblstudentenrolled"
        Me.lblstudentenrolled.Size = New System.Drawing.Size(253, 23)
        Me.lblstudentenrolled.TabIndex = 49
        Me.lblstudentenrolled.Text = "STUDENT ALREADY ENROLLED!"
        Me.lblstudentenrolled.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(444, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtsearch
        '
        Me.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsearch.Location = New System.Drawing.Point(99, 13)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(339, 20)
        Me.txtsearch.TabIndex = 4
        '
        'lblsearchstudent
        '
        Me.lblsearchstudent.AutoSize = True
        Me.lblsearchstudent.ForeColor = System.Drawing.Color.White
        Me.lblsearchstudent.Location = New System.Drawing.Point(5, 13)
        Me.lblsearchstudent.Name = "lblsearchstudent"
        Me.lblsearchstudent.Size = New System.Drawing.Size(79, 15)
        Me.lblsearchstudent.TabIndex = 3
        Me.lblsearchstudent.Text = "Search Student:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.txtadviser)
        Me.Panel2.Controls.Add(Me.lblsectionfull)
        Me.Panel2.Controls.Add(Me.label9)
        Me.Panel2.Controls.Add(Me.cbosection)
        Me.Panel2.Controls.Add(Me.cbostrand)
        Me.Panel2.Controls.Add(Me.txtstatus)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtroom)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtgradelevel)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtfullname)
        Me.Panel2.Controls.Add(Me.txtsid)
        Me.Panel2.Controls.Add(Me.txtaycode)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 133)
        Me.Panel2.TabIndex = 21
        '
        'txtadviser
        '
        Me.txtadviser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtadviser.Enabled = False
        Me.txtadviser.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtadviser.Location = New System.Drawing.Point(770, 4)
        Me.txtadviser.Name = "txtadviser"
        Me.txtadviser.Size = New System.Drawing.Size(206, 25)
        Me.txtadviser.TabIndex = 47
        '
        'lblsectionfull
        '
        Me.lblsectionfull.AutoSize = True
        Me.lblsectionfull.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsectionfull.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblsectionfull.Location = New System.Drawing.Point(460, 103)
        Me.lblsectionfull.Name = "lblsectionfull"
        Me.lblsectionfull.Size = New System.Drawing.Size(182, 23)
        Me.lblsectionfull.TabIndex = 48
        Me.lblsectionfull.Text = "THIS SECTION IS FULL!"
        Me.lblsectionfull.Visible = False
        '
        'label9
        '
        Me.label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.label9.ForeColor = System.Drawing.Color.Black
        Me.label9.Location = New System.Drawing.Point(705, 8)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(51, 17)
        Me.label9.TabIndex = 46
        Me.label9.Text = "Adviser"
        '
        'cbosection
        '
        Me.cbosection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbosection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbosection.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbosection.FormattingEnabled = True
        Me.cbosection.Location = New System.Drawing.Point(431, 69)
        Me.cbosection.Name = "cbosection"
        Me.cbosection.Size = New System.Drawing.Size(231, 25)
        Me.cbosection.TabIndex = 45
        '
        'cbostrand
        '
        Me.cbostrand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbostrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbostrand.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbostrand.FormattingEnabled = True
        Me.cbostrand.Location = New System.Drawing.Point(431, 36)
        Me.cbostrand.Name = "cbostrand"
        Me.cbostrand.Size = New System.Drawing.Size(231, 25)
        Me.cbostrand.TabIndex = 44
        '
        'txtstatus
        '
        Me.txtstatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtstatus.Enabled = False
        Me.txtstatus.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtstatus.Location = New System.Drawing.Point(770, 69)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(206, 25)
        Me.txtstatus.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(705, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Status"
        '
        'txtroom
        '
        Me.txtroom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtroom.Enabled = False
        Me.txtroom.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtroom.Location = New System.Drawing.Point(770, 36)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(206, 25)
        Me.txtroom.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(705, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Room"
        '
        'txtgradelevel
        '
        Me.txtgradelevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtgradelevel.Enabled = False
        Me.txtgradelevel.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtgradelevel.Location = New System.Drawing.Point(431, 4)
        Me.txtgradelevel.Name = "txtgradelevel"
        Me.txtgradelevel.Size = New System.Drawing.Size(231, 25)
        Me.txtgradelevel.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(340, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Section"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(340, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Strand"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(340, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Grade Level"
        '
        'txtfullname
        '
        Me.txtfullname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfullname.Enabled = False
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtfullname.Location = New System.Drawing.Point(88, 69)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(222, 25)
        Me.txtfullname.TabIndex = 7
        '
        'txtsid
        '
        Me.txtsid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsid.Enabled = False
        Me.txtsid.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtsid.Location = New System.Drawing.Point(88, 36)
        Me.txtsid.Name = "txtsid"
        Me.txtsid.Size = New System.Drawing.Size(222, 25)
        Me.txtsid.TabIndex = 6
        '
        'txtaycode
        '
        Me.txtaycode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaycode.Enabled = False
        Me.txtaycode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtaycode.Location = New System.Drawing.Point(88, 4)
        Me.txtaycode.Name = "txtaycode"
        Me.txtaycode.Size = New System.Drawing.Size(222, 25)
        Me.txtaycode.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LRN"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AY Code"
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(146, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(146, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column28, Me.Column29, Me.Column30, Me.Column31, Me.Column43, Me.Column44, Me.Column42, Me.Column45})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Silver
        Me.DataGridView1.Location = New System.Drawing.Point(0, 222)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(995, 407)
        Me.DataGridView1.TabIndex = 22
        '
        'Column28
        '
        Me.Column28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column28.HeaderText = "Subject Code"
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        Me.Column28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column28.Width = 72
        '
        'Column29
        '
        Me.Column29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column29.HeaderText = "Descriptive Title"
        Me.Column29.Name = "Column29"
        Me.Column29.ReadOnly = True
        Me.Column29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column30
        '
        Me.Column30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column30.HeaderText = "Unit/s"
        Me.Column30.Name = "Column30"
        Me.Column30.ReadOnly = True
        Me.Column30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column30.Width = 38
        '
        'Column31
        '
        Me.Column31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column31.HeaderText = "Type"
        Me.Column31.Name = "Column31"
        Me.Column31.ReadOnly = True
        Me.Column31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column31.Width = 32
        '
        'Column43
        '
        Me.Column43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column43.HeaderText = "Day"
        Me.Column43.Name = "Column43"
        Me.Column43.ReadOnly = True
        Me.Column43.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column43.Width = 28
        '
        'Column44
        '
        Me.Column44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column44.HeaderText = "Time"
        Me.Column44.Name = "Column44"
        Me.Column44.ReadOnly = True
        Me.Column44.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column44.Width = 33
        '
        'Column42
        '
        Me.Column42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column42.HeaderText = "Teacher"
        Me.Column42.Name = "Column42"
        Me.Column42.ReadOnly = True
        Me.Column42.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column42.Width = 46
        '
        'Column45
        '
        Me.Column45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column45.HeaderText = "Room"
        Me.Column45.Name = "Column45"
        Me.Column45.ReadOnly = True
        Me.Column45.Width = 58
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnprint)
        Me.Panel5.Controls.Add(Me.btnsave)
        Me.Panel5.Controls.Add(Me.btncancel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 588)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(995, 41)
        Me.Panel5.TabIndex = 23
        '
        'btnprint
        '
        Me.btnprint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnprint.BackColor = System.Drawing.Color.SeaGreen
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprint.FlatAppearance.BorderSize = 0
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Location = New System.Drawing.Point(739, 7)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(78, 28)
        Me.btnprint.TabIndex = 41
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(823, 7)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 28)
        Me.btnsave.TabIndex = 41
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(907, 7)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 28)
        Me.btncancel.TabIndex = 39
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'frmenrolling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 629)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmenrolling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmenrolling"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblenrollment As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblstudentenrolled As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lblsearchstudent As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtadviser As TextBox
    Friend WithEvents lblsectionfull As Label
    Friend WithEvents label9 As Label
    Friend WithEvents cbosection As ComboBox
    Friend WithEvents cbostrand As ComboBox
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtroom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtgradelevel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents txtsid As TextBox
    Friend WithEvents txtaycode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents Column29 As DataGridViewTextBoxColumn
    Friend WithEvents Column30 As DataGridViewTextBoxColumn
    Friend WithEvents Column31 As DataGridViewTextBoxColumn
    Friend WithEvents Column43 As DataGridViewTextBoxColumn
    Friend WithEvents Column44 As DataGridViewTextBoxColumn
    Friend WithEvents Column42 As DataGridViewTextBoxColumn
    Friend WithEvents Column45 As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnprint As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
End Class

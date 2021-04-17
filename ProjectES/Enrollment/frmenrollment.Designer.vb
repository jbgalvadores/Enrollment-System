<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmenrollment
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
        Me.cbogradelevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboaycode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblsearchstudent = New System.Windows.Forms.Label()
        Me.btnexport = New System.Windows.Forms.Button()
        Me.btnaddnew = New System.Windows.Forms.Button()
        Me.datagridview1 = New System.Windows.Forms.DataGridView()
        Me.SID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STUDENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRADE_LEVEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STRAND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AY_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colupdate = New System.Windows.Forms.DataGridViewImageColumn()
        Me.coldelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblenrollment)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 37)
        Me.Panel1.TabIndex = 7
        '
        'lblenrollment
        '
        Me.lblenrollment.AutoSize = True
        Me.lblenrollment.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenrollment.ForeColor = System.Drawing.Color.Black
        Me.lblenrollment.Location = New System.Drawing.Point(14, 9)
        Me.lblenrollment.Name = "lblenrollment"
        Me.lblenrollment.Size = New System.Drawing.Size(118, 23)
        Me.lblenrollment.TabIndex = 0
        Me.lblenrollment.Text = "ENROLLMENT"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cbogradelevel)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cboaycode)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.txtsearch)
        Me.Panel3.Controls.Add(Me.lblsearchstudent)
        Me.Panel3.Controls.Add(Me.btnexport)
        Me.Panel3.Controls.Add(Me.btnaddnew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1116, 45)
        Me.Panel3.TabIndex = 19
        '
        'cbogradelevel
        '
        Me.cbogradelevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbogradelevel.FormattingEnabled = True
        Me.cbogradelevel.Items.AddRange(New Object() {"GRADE 7", "GRADE 8", "GRADE 9", "GRADE 10", "GRADE 11", "GRADE 12"})
        Me.cbogradelevel.Location = New System.Drawing.Point(815, 8)
        Me.cbogradelevel.Name = "cbogradelevel"
        Me.cbogradelevel.Size = New System.Drawing.Size(131, 24)
        Me.cbogradelevel.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(747, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Grade Level"
        '
        'cboaycode
        '
        Me.cboaycode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboaycode.FormattingEnabled = True
        Me.cboaycode.Location = New System.Drawing.Point(542, 8)
        Me.cboaycode.Name = "cboaycode"
        Me.cboaycode.Size = New System.Drawing.Size(181, 24)
        Me.cboaycode.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(487, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "AY Code"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(415, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtsearch
        '
        Me.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsearch.Location = New System.Drawing.Point(93, 8)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(309, 21)
        Me.txtsearch.TabIndex = 4
        '
        'lblsearchstudent
        '
        Me.lblsearchstudent.AutoSize = True
        Me.lblsearchstudent.ForeColor = System.Drawing.Color.White
        Me.lblsearchstudent.Location = New System.Drawing.Point(5, 11)
        Me.lblsearchstudent.Name = "lblsearchstudent"
        Me.lblsearchstudent.Size = New System.Drawing.Size(82, 16)
        Me.lblsearchstudent.TabIndex = 3
        Me.lblsearchstudent.Text = "Search Student:"
        '
        'btnexport
        '
        Me.btnexport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnexport.FlatAppearance.BorderSize = 0
        Me.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexport.ForeColor = System.Drawing.Color.White
        Me.btnexport.Image = Global.ProjectES.My.Resources.Resources.coledit
        Me.btnexport.Location = New System.Drawing.Point(952, 0)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(82, 45)
        Me.btnexport.TabIndex = 0
        Me.btnexport.Text = "Export"
        Me.btnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexport.UseVisualStyleBackColor = True
        '
        'btnaddnew
        '
        Me.btnaddnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddnew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnaddnew.FlatAppearance.BorderSize = 0
        Me.btnaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddnew.ForeColor = System.Drawing.Color.White
        Me.btnaddnew.Image = Global.ProjectES.My.Resources.Resources.addnew
        Me.btnaddnew.Location = New System.Drawing.Point(1034, 0)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(82, 45)
        Me.btnaddnew.TabIndex = 0
        Me.btnaddnew.Text = "Add New"
        Me.btnaddnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddnew.UseVisualStyleBackColor = True
        '
        'datagridview1
        '
        Me.datagridview1.AllowUserToAddRows = False
        Me.datagridview1.AllowUserToDeleteRows = False
        Me.datagridview1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview1.ColumnHeadersHeight = 30
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SID, Me.AID, Me.LRN, Me.STUDENT_NAME, Me.GRADE_LEVEL, Me.STRAND, Me.SECTION, Me.STATUS, Me.AY_CODE, Me.colupdate, Me.coldelete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridview1.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridview1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridview1.EnableHeadersVisualStyles = False
        Me.datagridview1.Location = New System.Drawing.Point(0, 82)
        Me.datagridview1.MultiSelect = False
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        Me.datagridview1.RowHeadersVisible = False
        Me.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview1.Size = New System.Drawing.Size(1116, 450)
        Me.datagridview1.TabIndex = 20
        '
        'SID
        '
        Me.SID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SID.HeaderText = "Student ID"
        Me.SID.Name = "SID"
        Me.SID.ReadOnly = True
        Me.SID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'AID
        '
        Me.AID.HeaderText = "AID"
        Me.AID.Name = "AID"
        Me.AID.ReadOnly = True
        Me.AID.Width = 130
        '
        'LRN
        '
        Me.LRN.HeaderText = "LRN"
        Me.LRN.Name = "LRN"
        Me.LRN.ReadOnly = True
        Me.LRN.Width = 130
        '
        'STUDENT_NAME
        '
        Me.STUDENT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.STUDENT_NAME.HeaderText = "Full Name"
        Me.STUDENT_NAME.Name = "STUDENT_NAME"
        Me.STUDENT_NAME.ReadOnly = True
        Me.STUDENT_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'GRADE_LEVEL
        '
        Me.GRADE_LEVEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GRADE_LEVEL.HeaderText = "Grade Level"
        Me.GRADE_LEVEL.Name = "GRADE_LEVEL"
        Me.GRADE_LEVEL.ReadOnly = True
        Me.GRADE_LEVEL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.GRADE_LEVEL.Width = 67
        '
        'STRAND
        '
        Me.STRAND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STRAND.HeaderText = "Strand"
        Me.STRAND.Name = "STRAND"
        Me.STRAND.ReadOnly = True
        Me.STRAND.Width = 62
        '
        'SECTION
        '
        Me.SECTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SECTION.HeaderText = "Section"
        Me.SECTION.Name = "SECTION"
        Me.SECTION.ReadOnly = True
        Me.SECTION.Width = 66
        '
        'STATUS
        '
        Me.STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STATUS.HeaderText = "Status"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        Me.STATUS.Width = 60
        '
        'AY_CODE
        '
        Me.AY_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AY_CODE.HeaderText = "AY Code"
        Me.AY_CODE.Name = "AY_CODE"
        Me.AY_CODE.ReadOnly = True
        Me.AY_CODE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AY_CODE.Width = 53
        '
        'colupdate
        '
        Me.colupdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colupdate.HeaderText = ""
        Me.colupdate.Image = Global.ProjectES.My.Resources.Resources.update_24
        Me.colupdate.Name = "colupdate"
        Me.colupdate.ReadOnly = True
        Me.colupdate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colupdate.Width = 5
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
        'frmenrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 532)
        Me.Controls.Add(Me.datagridview1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmenrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmenrollment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblenrollment As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbogradelevel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboaycode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lblsearchstudent As Label
    Friend WithEvents btnaddnew As Button
    Friend WithEvents datagridview1 As DataGridView
    Friend WithEvents btnexport As Button
    Friend WithEvents SID As DataGridViewTextBoxColumn
    Friend WithEvents AID As DataGridViewTextBoxColumn
    Friend WithEvents LRN As DataGridViewTextBoxColumn
    Friend WithEvents STUDENT_NAME As DataGridViewTextBoxColumn
    Friend WithEvents GRADE_LEVEL As DataGridViewTextBoxColumn
    Friend WithEvents STRAND As DataGridViewTextBoxColumn
    Friend WithEvents SECTION As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents AY_CODE As DataGridViewTextBoxColumn
    Friend WithEvents colupdate As DataGridViewImageColumn
    Friend WithEvents coldelete As DataGridViewImageColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrecord
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkAdmClose = New MetroFramework.Controls.MetroButton()
        Me.lblenrollment = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnaddgrade = New MetroFramework.Controls.MetroButton()
        Me.txtlrn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsearchlrnname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbosection = New System.Windows.Forms.ComboBox()
        Me.cbostrand = New System.Windows.Forms.ComboBox()
        Me.txtgradelevel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.txtaycode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblfinalgrade = New System.Windows.Forms.Label()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GradesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GradesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.linkAdmClose)
        Me.Panel1.Controls.Add(Me.lblenrollment)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 38)
        Me.Panel1.TabIndex = 9
        '
        'linkAdmClose
        '
        Me.linkAdmClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAdmClose.Location = New System.Drawing.Point(910, 8)
        Me.linkAdmClose.Name = "linkAdmClose"
        Me.linkAdmClose.Size = New System.Drawing.Size(75, 23)
        Me.linkAdmClose.TabIndex = 66
        Me.linkAdmClose.Text = "CLOSE"
        Me.linkAdmClose.UseSelectable = True
        '
        'lblenrollment
        '
        Me.lblenrollment.AutoSize = True
        Me.lblenrollment.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenrollment.ForeColor = System.Drawing.Color.Black
        Me.lblenrollment.Location = New System.Drawing.Point(14, 8)
        Me.lblenrollment.Name = "lblenrollment"
        Me.lblenrollment.Size = New System.Drawing.Size(86, 23)
        Me.lblenrollment.TabIndex = 0
        Me.lblenrollment.Text = "RECORDS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btnaddgrade)
        Me.Panel2.Controls.Add(Me.txtlrn)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtsearchlrnname)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cbosection)
        Me.Panel2.Controls.Add(Me.cbostrand)
        Me.Panel2.Controls.Add(Me.txtgradelevel)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtfullname)
        Me.Panel2.Controls.Add(Me.txtaycode)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 149)
        Me.Panel2.TabIndex = 22
        '
        'btnaddgrade
        '
        Me.btnaddgrade.Location = New System.Drawing.Point(603, 113)
        Me.btnaddgrade.Name = "btnaddgrade"
        Me.btnaddgrade.Size = New System.Drawing.Size(75, 23)
        Me.btnaddgrade.TabIndex = 65
        Me.btnaddgrade.Text = "ADD"
        Me.btnaddgrade.UseSelectable = True
        '
        'txtlrn
        '
        Me.txtlrn.Enabled = False
        Me.txtlrn.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtlrn.Location = New System.Drawing.Point(124, 41)
        Me.txtlrn.Name = "txtlrn"
        Me.txtlrn.Size = New System.Drawing.Size(288, 25)
        Me.txtlrn.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(30, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "LRN"
        '
        'txtsearchlrnname
        '
        Me.txtsearchlrnname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsearchlrnname.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtsearchlrnname.Location = New System.Drawing.Point(124, 6)
        Me.txtsearchlrnname.Name = "txtsearchlrnname"
        Me.txtsearchlrnname.Size = New System.Drawing.Size(288, 25)
        Me.txtsearchlrnname.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LRN or Name"
        '
        'cbosection
        '
        Me.cbosection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbosection.Enabled = False
        Me.cbosection.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbosection.FormattingEnabled = True
        Me.cbosection.Location = New System.Drawing.Point(545, 76)
        Me.cbosection.Name = "cbosection"
        Me.cbosection.Size = New System.Drawing.Size(188, 25)
        Me.cbosection.TabIndex = 45
        '
        'cbostrand
        '
        Me.cbostrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbostrand.Enabled = False
        Me.cbostrand.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cbostrand.FormattingEnabled = True
        Me.cbostrand.Location = New System.Drawing.Point(545, 7)
        Me.cbostrand.Name = "cbostrand"
        Me.cbostrand.Size = New System.Drawing.Size(188, 25)
        Me.cbostrand.TabIndex = 44
        '
        'txtgradelevel
        '
        Me.txtgradelevel.Enabled = False
        Me.txtgradelevel.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtgradelevel.Location = New System.Drawing.Point(545, 44)
        Me.txtgradelevel.Name = "txtgradelevel"
        Me.txtgradelevel.Size = New System.Drawing.Size(188, 25)
        Me.txtgradelevel.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(454, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Section"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(454, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Strand"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(454, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Grade Level"
        '
        'txtfullname
        '
        Me.txtfullname.Enabled = False
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtfullname.Location = New System.Drawing.Point(124, 113)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(288, 25)
        Me.txtfullname.TabIndex = 7
        '
        'txtaycode
        '
        Me.txtaycode.Enabled = False
        Me.txtaycode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtaycode.Location = New System.Drawing.Point(124, 78)
        Me.txtaycode.Name = "txtaycode"
        Me.txtaycode.Size = New System.Drawing.Size(288, 25)
        Me.txtaycode.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AY Code"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblfinalgrade)
        Me.Panel5.Controls.Add(Me.btnprint)
        Me.Panel5.Controls.Add(Me.btnsave)
        Me.Panel5.Controls.Add(Me.btncancel)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 532)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(997, 41)
        Me.Panel5.TabIndex = 24
        '
        'lblfinalgrade
        '
        Me.lblfinalgrade.AutoSize = True
        Me.lblfinalgrade.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfinalgrade.ForeColor = System.Drawing.Color.White
        Me.lblfinalgrade.Location = New System.Drawing.Point(106, 11)
        Me.lblfinalgrade.Name = "lblfinalgrade"
        Me.lblfinalgrade.Size = New System.Drawing.Size(0, 20)
        Me.lblfinalgrade.TabIndex = 42
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
        Me.btnprint.Location = New System.Drawing.Point(719, 6)
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
        Me.btnsave.Location = New System.Drawing.Point(803, 6)
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
        Me.btncancel.Location = New System.Drawing.Point(887, 6)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 28)
        Me.btncancel.TabIndex = 39
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Overall Grade:"
        '
        'GradesDataGridView
        '
        Me.GradesDataGridView.AllowUserToAddRows = False
        Me.GradesDataGridView.AllowUserToDeleteRows = False
        Me.GradesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GradesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GradesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GradesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(146, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(146, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GradesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GradesDataGridView.ColumnHeadersHeight = 30
        Me.GradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GradesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column28, Me.Column29, Me.Column30, Me.Column31})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GradesDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.GradesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradesDataGridView.EnableHeadersVisualStyles = False
        Me.GradesDataGridView.GridColor = System.Drawing.Color.Silver
        Me.GradesDataGridView.Location = New System.Drawing.Point(0, 187)
        Me.GradesDataGridView.MultiSelect = False
        Me.GradesDataGridView.Name = "GradesDataGridView"
        Me.GradesDataGridView.ReadOnly = True
        Me.GradesDataGridView.RowHeadersVisible = False
        Me.GradesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GradesDataGridView.Size = New System.Drawing.Size(997, 345)
        Me.GradesDataGridView.TabIndex = 25
        '
        'Column28
        '
        Me.Column28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column28.HeaderText = "Subject Code"
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        Me.Column28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column28.Width = 96
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
        Me.Column30.Width = 49
        '
        'Column31
        '
        Me.Column31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column31.HeaderText = "Grade"
        Me.Column31.Name = "Column31"
        Me.Column31.ReadOnly = True
        Me.Column31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column31.Width = 50
        '
        'frmrecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 573)
        Me.Controls.Add(Me.GradesDataGridView)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmrecord"
        Me.Text = "frmrecord"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.GradesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblenrollment As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbosection As ComboBox
    Friend WithEvents cbostrand As ComboBox
    Friend WithEvents txtgradelevel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents txtsearchlrnname As TextBox
    Friend WithEvents txtaycode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnprint As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GradesDataGridView As DataGridView
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents Column29 As DataGridViewTextBoxColumn
    Friend WithEvents Column30 As DataGridViewTextBoxColumn
    Friend WithEvents Column31 As DataGridViewTextBoxColumn
    Friend WithEvents btnaddgrade As MetroFramework.Controls.MetroButton
    Friend WithEvents linkAdmClose As MetroFramework.Controls.MetroButton
    Friend WithEvents lblfinalgrade As Label
    Friend WithEvents txtlrn As TextBox
    Friend WithEvents Label8 As Label
End Class

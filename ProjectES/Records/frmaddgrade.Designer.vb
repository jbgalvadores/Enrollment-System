<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmaddgrade
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
        Me.txtsubdesc = New System.Windows.Forms.TextBox()
        Me.txtsubjectcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkAdmClose = New MetroFramework.Controls.MetroButton()
        Me.lblenrollment = New System.Windows.Forms.Label()
        Me.btncanel = New MetroFramework.Controls.MetroButton()
        Me.btnadd = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textsubcodedesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgradelevel = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtunits = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.textsubexams = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textsubprojects = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textsubquizzes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textsubattendance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblgraderemarks = New System.Windows.Forms.Label()
        Me.lblgradestanding = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsubdesc
        '
        Me.txtsubdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsubdesc.Enabled = False
        Me.txtsubdesc.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtsubdesc.Location = New System.Drawing.Point(117, 65)
        Me.txtsubdesc.Name = "txtsubdesc"
        Me.txtsubdesc.Size = New System.Drawing.Size(431, 25)
        Me.txtsubdesc.TabIndex = 10
        '
        'txtsubjectcode
        '
        Me.txtsubjectcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsubjectcode.Enabled = False
        Me.txtsubjectcode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtsubjectcode.Location = New System.Drawing.Point(117, 25)
        Me.txtsubjectcode.Name = "txtsubjectcode"
        Me.txtsubjectcode.Size = New System.Drawing.Size(431, 25)
        Me.txtsubjectcode.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DESCRIPTION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SUBJECT CODE"
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
        Me.Panel1.Size = New System.Drawing.Size(630, 38)
        Me.Panel1.TabIndex = 11
        '
        'linkAdmClose
        '
        Me.linkAdmClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAdmClose.Location = New System.Drawing.Point(543, 8)
        Me.linkAdmClose.Name = "linkAdmClose"
        Me.linkAdmClose.Size = New System.Drawing.Size(75, 23)
        Me.linkAdmClose.TabIndex = 63
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
        Me.lblenrollment.Size = New System.Drawing.Size(102, 23)
        Me.lblenrollment.TabIndex = 0
        Me.lblenrollment.Text = "ADD GRADE"
        '
        'btncanel
        '
        Me.btncanel.Location = New System.Drawing.Point(502, 498)
        Me.btncanel.Name = "btncanel"
        Me.btncanel.Size = New System.Drawing.Size(75, 23)
        Me.btncanel.TabIndex = 62
        Me.btncanel.Text = "CANCEL"
        Me.btncanel.UseSelectable = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(392, 498)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 63
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SUBJECT CODE or SUBJECT"
        '
        'textsubcodedesc
        '
        Me.textsubcodedesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textsubcodedesc.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.textsubcodedesc.Location = New System.Drawing.Point(192, 51)
        Me.textsubcodedesc.Name = "textsubcodedesc"
        Me.textsubcodedesc.Size = New System.Drawing.Size(360, 25)
        Me.textsubcodedesc.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "GRADE LEVEL"
        '
        'txtgradelevel
        '
        Me.txtgradelevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgradelevel.Enabled = False
        Me.txtgradelevel.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtgradelevel.Location = New System.Drawing.Point(117, 138)
        Me.txtgradelevel.Name = "txtgradelevel"
        Me.txtgradelevel.Size = New System.Drawing.Size(431, 25)
        Me.txtgradelevel.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtunits)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsubjectcode)
        Me.GroupBox1.Controls.Add(Me.txtsubdesc)
        Me.GroupBox1.Controls.Add(Me.txtgradelevel)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 195)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "UNITS"
        '
        'txtunits
        '
        Me.txtunits.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtunits.Enabled = False
        Me.txtunits.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtunits.Location = New System.Drawing.Point(117, 99)
        Me.txtunits.Name = "txtunits"
        Me.txtunits.Size = New System.Drawing.Size(431, 25)
        Me.txtunits.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textsubexams)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.textsubprojects)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.textsubquizzes)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.textsubattendance)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 310)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 243)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STANDINGS"
        '
        'textsubexams
        '
        Me.textsubexams.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textsubexams.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.textsubexams.Location = New System.Drawing.Point(113, 185)
        Me.textsubexams.Name = "textsubexams"
        Me.textsubexams.Size = New System.Drawing.Size(158, 25)
        Me.textsubexams.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "EXAMS"
        '
        'textsubprojects
        '
        Me.textsubprojects.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textsubprojects.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.textsubprojects.Location = New System.Drawing.Point(113, 137)
        Me.textsubprojects.Name = "textsubprojects"
        Me.textsubprojects.Size = New System.Drawing.Size(158, 25)
        Me.textsubprojects.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "PROJECTS"
        '
        'textsubquizzes
        '
        Me.textsubquizzes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textsubquizzes.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.textsubquizzes.Location = New System.Drawing.Point(113, 84)
        Me.textsubquizzes.Name = "textsubquizzes"
        Me.textsubquizzes.Size = New System.Drawing.Size(158, 25)
        Me.textsubquizzes.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "QUIZZES"
        '
        'textsubattendance
        '
        Me.textsubattendance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textsubattendance.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.textsubattendance.Location = New System.Drawing.Point(113, 32)
        Me.textsubattendance.Name = "textsubattendance"
        Me.textsubattendance.Size = New System.Drawing.Size(158, 25)
        Me.textsubattendance.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ATTENDANCE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblgraderemarks)
        Me.GroupBox3.Controls.Add(Me.lblgradestanding)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(370, 310)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 148)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULT"
        '
        'lblgraderemarks
        '
        Me.lblgraderemarks.AutoSize = True
        Me.lblgraderemarks.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgraderemarks.Location = New System.Drawing.Point(72, 102)
        Me.lblgraderemarks.Name = "lblgraderemarks"
        Me.lblgraderemarks.Size = New System.Drawing.Size(0, 27)
        Me.lblgraderemarks.TabIndex = 2
        '
        'lblgradestanding
        '
        Me.lblgradestanding.AutoSize = True
        Me.lblgradestanding.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgradestanding.Location = New System.Drawing.Point(89, 72)
        Me.lblgradestanding.Name = "lblgradestanding"
        Me.lblgradestanding.Size = New System.Drawing.Size(0, 20)
        Me.lblgradestanding.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(69, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "YOUR GRADE:"
        '
        'frmaddgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 564)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncanel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.textsubcodedesc)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmaddgrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmaddgrade"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsubdesc As TextBox
    Friend WithEvents txtsubjectcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblenrollment As Label
    Friend WithEvents linkAdmClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btncanel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnadd As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As Label
    Friend WithEvents textsubcodedesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtgradelevel As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtunits As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textsubexams As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents textsubprojects As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textsubquizzes As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents textsubattendance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblgraderemarks As Label
    Friend WithEvents lblgradestanding As Label
    Friend WithEvents Label11 As Label
End Class

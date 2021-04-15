<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeacher
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblteacher = New System.Windows.Forms.Label()
        Me.txtspecialization = New System.Windows.Forms.TextBox()
        Me.txtdegree = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.picTeacher = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnclose = New MetroFramework.Controls.MetroButton()
        Me.btnupdate = New MetroFramework.Controls.MetroButton()
        Me.btnsave = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        CType(Me.picTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblteacher)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 34)
        Me.Panel1.TabIndex = 71
        '
        'lblteacher
        '
        Me.lblteacher.AutoSize = True
        Me.lblteacher.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblteacher.ForeColor = System.Drawing.Color.Black
        Me.lblteacher.Location = New System.Drawing.Point(12, 9)
        Me.lblteacher.Name = "lblteacher"
        Me.lblteacher.Size = New System.Drawing.Size(85, 16)
        Me.lblteacher.TabIndex = 0
        Me.lblteacher.Text = "ADD TEACHER"
        '
        'txtspecialization
        '
        Me.txtspecialization.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtspecialization.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtspecialization.Location = New System.Drawing.Point(102, 220)
        Me.txtspecialization.Name = "txtspecialization"
        Me.txtspecialization.Size = New System.Drawing.Size(403, 22)
        Me.txtspecialization.TabIndex = 93
        '
        'txtdegree
        '
        Me.txtdegree.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdegree.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtdegree.Location = New System.Drawing.Point(102, 187)
        Me.txtdegree.Name = "txtdegree"
        Me.txtdegree.Size = New System.Drawing.Size(403, 22)
        Me.txtdegree.TabIndex = 92
        '
        'txtmname
        '
        Me.txtmname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtmname.Location = New System.Drawing.Point(102, 154)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(403, 22)
        Me.txtmname.TabIndex = 91
        '
        'txtfname
        '
        Me.txtfname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtfname.Location = New System.Drawing.Point(102, 121)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(403, 22)
        Me.txtfname.TabIndex = 90
        '
        'txtlname
        '
        Me.txtlname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtlname.Location = New System.Drawing.Point(102, 88)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(403, 22)
        Me.txtlname.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(17, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Specialization"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(17, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Degree"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(561, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Image"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(17, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(17, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(17, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Last Name"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblid.Location = New System.Drawing.Point(17, 55)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(59, 13)
        Me.lblid.TabIndex = 79
        Me.lblid.Text = "Teacher ID"
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtid.Location = New System.Drawing.Point(102, 55)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(403, 22)
        Me.txtid.TabIndex = 88
        '
        'btnbrowse
        '
        Me.btnbrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbrowse.FlatAppearance.BorderSize = 0
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Location = New System.Drawing.Point(533, 173)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(97, 28)
        Me.btnbrowse.TabIndex = 84
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'picTeacher
        '
        Me.picTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picTeacher.Location = New System.Drawing.Point(533, 81)
        Me.picTeacher.Name = "picTeacher"
        Me.picTeacher.Size = New System.Drawing.Size(97, 86)
        Me.picTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTeacher.TabIndex = 83
        Me.picTeacher.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(379, 258)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 94
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseSelectable = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(298, 258)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 95
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseSelectable = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(217, 258)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 96
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseSelectable = True
        '
        'frmTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 300)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtspecialization)
        Me.Controls.Add(Me.txtdegree)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.picTeacher)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTeacher"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblteacher As Label
    Friend WithEvents txtspecialization As TextBox
    Friend WithEvents txtdegree As TextBox
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents picTeacher As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblid As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents btnbrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnclose As MetroFramework.Controls.MetroButton
    Friend WithEvents btnupdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnsave As MetroFramework.Controls.MetroButton
End Class

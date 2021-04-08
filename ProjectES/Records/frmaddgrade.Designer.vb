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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textsubgrade = New System.Windows.Forms.TextBox()
        Me.btncanel = New MetroFramework.Controls.MetroButton()
        Me.btnadd = New MetroFramework.Controls.MetroButton()
        Me.btnsearch = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textsubcodedesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgradelevel = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(626, 38)
        Me.Panel1.TabIndex = 11
        '
        'linkAdmClose
        '
        Me.linkAdmClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkAdmClose.Location = New System.Drawing.Point(539, 8)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "GRADE"
        '
        'textsubgrade
        '
        Me.textsubgrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textsubgrade.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.textsubgrade.Location = New System.Drawing.Point(80, 281)
        Me.textsubgrade.Name = "textsubgrade"
        Me.textsubgrade.Size = New System.Drawing.Size(158, 25)
        Me.textsubgrade.TabIndex = 9
        '
        'btncanel
        '
        Me.btncanel.Location = New System.Drawing.Point(526, 284)
        Me.btncanel.Name = "btncanel"
        Me.btncanel.Size = New System.Drawing.Size(75, 23)
        Me.btncanel.TabIndex = 62
        Me.btncanel.Text = "CANCEL"
        Me.btncanel.UseSelectable = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(445, 284)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 63
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseSelectable = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(192, 82)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 64
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseSelectable = True
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
        Me.textsubcodedesc.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 111)
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
        Me.txtgradelevel.Location = New System.Drawing.Point(117, 108)
        Me.txtgradelevel.Name = "txtgradelevel"
        Me.txtgradelevel.Size = New System.Drawing.Size(431, 25)
        Me.txtgradelevel.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsubjectcode)
        Me.GroupBox1.Controls.Add(Me.txtsubdesc)
        Me.GroupBox1.Controls.Add(Me.txtgradelevel)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 158)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULT"
        '
        'frmaddgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 326)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncanel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.textsubgrade)
        Me.Controls.Add(Me.textsubcodedesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmaddgrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmaddgrade"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsubdesc As TextBox
    Friend WithEvents txtsubjectcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblenrollment As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textsubgrade As TextBox
    Friend WithEvents linkAdmClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btncanel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnadd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnsearch As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As Label
    Friend WithEvents textsubcodedesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtgradelevel As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

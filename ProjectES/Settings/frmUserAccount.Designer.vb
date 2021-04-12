<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccount
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
        Me.lbladdnewuser = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.cbodesignation = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtconfirmpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.pichide = New System.Windows.Forms.PictureBox()
        Me.picshow = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbladdnewuser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 34)
        Me.Panel1.TabIndex = 44
        '
        'lbladdnewuser
        '
        Me.lbladdnewuser.AutoSize = True
        Me.lbladdnewuser.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdnewuser.ForeColor = System.Drawing.Color.Black
        Me.lbladdnewuser.Location = New System.Drawing.Point(12, 9)
        Me.lbladdnewuser.Name = "lbladdnewuser"
        Me.lbladdnewuser.Size = New System.Drawing.Size(95, 16)
        Me.lbladdnewuser.TabIndex = 0
        Me.lbladdnewuser.Text = "USER ACCOUNT"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(583, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Image"
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
        Me.btnsave.Location = New System.Drawing.Point(290, 307)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 28)
        Me.btnsave.TabIndex = 62
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnupdate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Enabled = False
        Me.btnupdate.FlatAppearance.BorderSize = 0
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(374, 307)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(78, 28)
        Me.btnupdate.TabIndex = 61
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
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
        Me.btncancel.Location = New System.Drawing.Point(458, 307)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 28)
        Me.btncancel.TabIndex = 60
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'cbodesignation
        '
        Me.cbodesignation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbodesignation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbodesignation.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbodesignation.FormattingEnabled = True
        Me.cbodesignation.Items.AddRange(New Object() {"Administrator", "Teacher", "Registrar", "Guest User"})
        Me.cbodesignation.Location = New System.Drawing.Point(133, 274)
        Me.cbodesignation.Name = "cbodesignation"
        Me.cbodesignation.Size = New System.Drawing.Size(403, 21)
        Me.cbodesignation.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(17, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Designation"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(17, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Confirm Pass"
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtconfirmpass.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtconfirmpass.Location = New System.Drawing.Point(133, 241)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.Size = New System.Drawing.Size(403, 22)
        Me.txtconfirmpass.TabIndex = 55
        Me.txtconfirmpass.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(17, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Password"
        '
        'txtpass
        '
        Me.txtpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtpass.Location = New System.Drawing.Point(133, 208)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(403, 22)
        Me.txtpass.TabIndex = 53
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(17, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtusername.Location = New System.Drawing.Point(133, 175)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(403, 22)
        Me.txtusername.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(17, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Middle Name"
        '
        'txtmname
        '
        Me.txtmname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtmname.Location = New System.Drawing.Point(133, 142)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(403, 22)
        Me.txtmname.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(17, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "First Name"
        '
        'txtfname
        '
        Me.txtfname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtfname.Location = New System.Drawing.Point(133, 109)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(403, 22)
        Me.txtfname.TabIndex = 47
        '
        'lbllname
        '
        Me.lbllname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllname.AutoSize = True
        Me.lbllname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbllname.Location = New System.Drawing.Point(17, 80)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(60, 13)
        Me.lbllname.TabIndex = 46
        Me.lbllname.Text = "Last Name"
        '
        'txtlname
        '
        Me.txtlname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtlname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtlname.Location = New System.Drawing.Point(133, 76)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(403, 22)
        Me.txtlname.TabIndex = 45
        '
        'btnbrowse
        '
        Me.btnbrowse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnbrowse.BackColor = System.Drawing.Color.SeaGreen
        Me.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbrowse.FlatAppearance.BorderSize = 0
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Location = New System.Drawing.Point(562, 167)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(97, 28)
        Me.btnbrowse.TabIndex = 63
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnbrowse.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'picUser
        '
        Me.picUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picUser.Location = New System.Drawing.Point(562, 75)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(97, 86)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 59
        Me.picUser.TabStop = False
        '
        'pichide
        '
        Me.pichide.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pichide.Image = Global.ProjectES.My.Resources.Resources.hideblack1
        Me.pichide.Location = New System.Drawing.Point(542, 206)
        Me.pichide.Name = "pichide"
        Me.pichide.Size = New System.Drawing.Size(32, 33)
        Me.pichide.TabIndex = 65
        Me.pichide.TabStop = False
        '
        'picshow
        '
        Me.picshow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picshow.Location = New System.Drawing.Point(542, 206)
        Me.picshow.Name = "picshow"
        Me.picshow.Size = New System.Drawing.Size(32, 33)
        Me.picshow.TabIndex = 66
        Me.picshow.TabStop = False
        '
        'frmUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 383)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.cbodesignation)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.pichide)
        Me.Controls.Add(Me.picshow)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUserAccount"
        Me.Text = "frmUserAccount"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbladdnewuser As Label
    Friend WithEvents picUser As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents cbodesignation As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtconfirmpass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents lbllname As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents pichide As PictureBox
    Friend WithEvents picshow As PictureBox
    Friend WithEvents btnbrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class

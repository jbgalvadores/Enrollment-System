<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.pichide = New System.Windows.Forms.PictureBox()
        Me.imgLoginButton = New System.Windows.Forms.PictureBox()
        Me.imgCancelButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.pichide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLoginButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtpassword.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtpassword.Location = New System.Drawing.Point(391, 362)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(308, 25)
        Me.txtpassword.TabIndex = 9
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtusername.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtusername.Location = New System.Drawing.Point(391, 322)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(308, 25)
        Me.txtusername.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(301, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PASSWORD:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(301, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "USERNAME:"
        '
        'lbltitle
        '
        Me.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltitle.Location = New System.Drawing.Point(442, 207)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(330, 29)
        Me.lbltitle.TabIndex = 8
        Me.lbltitle.Text = "STUDENT ENROLLMENT SYSTEM"
        '
        'pichide
        '
        Me.pichide.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pichide.Image = Global.ProjectES.My.Resources.Resources.hideblack
        Me.pichide.Location = New System.Drawing.Point(705, 362)
        Me.pichide.Name = "pichide"
        Me.pichide.Size = New System.Drawing.Size(22, 24)
        Me.pichide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pichide.TabIndex = 13
        Me.pichide.TabStop = False
        '
        'imgLoginButton
        '
        Me.imgLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgLoginButton.Image = Global.ProjectES.My.Resources.Resources.check_icon
        Me.imgLoginButton.Location = New System.Drawing.Point(473, 417)
        Me.imgLoginButton.Name = "imgLoginButton"
        Me.imgLoginButton.Size = New System.Drawing.Size(44, 42)
        Me.imgLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLoginButton.TabIndex = 11
        Me.imgLoginButton.TabStop = False
        '
        'imgCancelButton
        '
        Me.imgCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgCancelButton.Image = Global.ProjectES.My.Resources.Resources.delete3
        Me.imgCancelButton.Location = New System.Drawing.Point(575, 417)
        Me.imgCancelButton.Name = "imgCancelButton"
        Me.imgCancelButton.Size = New System.Drawing.Size(44, 42)
        Me.imgCancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCancelButton.TabIndex = 12
        Me.imgCancelButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.ProjectES.My.Resources.Resources.PCHS_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(265, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 575)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 100)
        Me.Panel2.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(797, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 475)
        Me.Panel3.TabIndex = 16
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(200, 509)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(597, 66)
        Me.Panel4.TabIndex = 17
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(997, 575)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pichide)
        Me.Controls.Add(Me.imgLoginButton)
        Me.Controls.Add(Me.imgCancelButton)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmlogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pichide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLoginButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLoginButton As PictureBox
    Friend WithEvents imgCancelButton As PictureBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pichide As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class

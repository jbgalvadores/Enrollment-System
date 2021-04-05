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
        Me.imgLoginButton = New System.Windows.Forms.PictureBox()
        Me.imgCancelButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pichide = New System.Windows.Forms.PictureBox()
        CType(Me.imgLoginButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtpassword.Location = New System.Drawing.Point(145, 285)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(142, 25)
        Me.txtpassword.TabIndex = 9
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtusername.Location = New System.Drawing.Point(145, 245)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(142, 25)
        Me.txtusername.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(55, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PASSWORD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(55, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "USERNAME:"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbltitle.Location = New System.Drawing.Point(74, 199)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(213, 20)
        Me.lbltitle.TabIndex = 8
        Me.lbltitle.Text = "STUDENT ENROLLMENT SYSTEM"
        '
        'imgLoginButton
        '
        Me.imgLoginButton.Image = Global.ProjectES.My.Resources.Resources.check_icon
        Me.imgLoginButton.Location = New System.Drawing.Point(110, 332)
        Me.imgLoginButton.Name = "imgLoginButton"
        Me.imgLoginButton.Size = New System.Drawing.Size(44, 42)
        Me.imgLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLoginButton.TabIndex = 11
        Me.imgLoginButton.TabStop = False
        '
        'imgCancelButton
        '
        Me.imgCancelButton.Image = Global.ProjectES.My.Resources.Resources.delete3
        Me.imgCancelButton.Location = New System.Drawing.Point(212, 332)
        Me.imgCancelButton.Name = "imgCancelButton"
        Me.imgCancelButton.Size = New System.Drawing.Size(44, 42)
        Me.imgCancelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCancelButton.TabIndex = 12
        Me.imgCancelButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectES.My.Resources.Resources.PCHS_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(77, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'pichide
        '
        Me.pichide.Location = New System.Drawing.Point(293, 286)
        Me.pichide.Name = "pichide"
        Me.pichide.Size = New System.Drawing.Size(22, 24)
        Me.pichide.TabIndex = 13
        Me.pichide.TabStop = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 394)
        Me.Controls.Add(Me.pichide)
        Me.Controls.Add(Me.imgLoginButton)
        Me.Controls.Add(Me.imgCancelButton)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmlogin"
        CType(Me.imgLoginButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichide, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class

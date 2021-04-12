<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpassword
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
        Me.lnkclose = New MetroFramework.Controls.MetroButton()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lnkclose)
        Me.Panel1.Controls.Add(Me.lblpassword)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 34)
        Me.Panel1.TabIndex = 45
        '
        'lnkclose
        '
        Me.lnkclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkclose.Location = New System.Drawing.Point(278, 7)
        Me.lnkclose.Name = "lnkclose"
        Me.lnkclose.Size = New System.Drawing.Size(75, 23)
        Me.lnkclose.TabIndex = 8
        Me.lnkclose.Text = "CLOSE"
        Me.lnkclose.UseSelectable = True
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.Color.Black
        Me.lblpassword.Location = New System.Drawing.Point(12, 9)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(112, 16)
        Me.lblpassword.TabIndex = 0
        Me.lblpassword.Text = "ENTER PASSWORD"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(128, 92)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(88, 28)
        Me.btnsave.TabIndex = 47
        Me.btnsave.Text = "OK"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(47, 54)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(278, 20)
        Me.txtpassword.TabIndex = 46
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'frmpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 144)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblpassword As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lnkclose As MetroFramework.Controls.MetroButton
End Class

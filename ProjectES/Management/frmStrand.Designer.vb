<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStrand
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblstrand = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstrand = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnclose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblstrand)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 34)
        Me.Panel1.TabIndex = 34
        '
        'lblstrand
        '
        Me.lblstrand.AutoSize = True
        Me.lblstrand.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstrand.ForeColor = System.Drawing.Color.Black
        Me.lblstrand.Location = New System.Drawing.Point(12, 9)
        Me.lblstrand.Name = "lblstrand"
        Me.lblstrand.Size = New System.Drawing.Size(79, 16)
        Me.lblstrand.TabIndex = 0
        Me.lblstrand.Text = "ADD STRAND"
        '
        'txtdescription
        '
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(129, 108)
        Me.txtdescription.MaxLength = 10000
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(305, 22)
        Me.txtdescription.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "DESCRIPTION"
        '
        'txtstrand
        '
        Me.txtstrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstrand.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstrand.Location = New System.Drawing.Point(130, 67)
        Me.txtstrand.MaxLength = 10
        Me.txtstrand.Name = "txtstrand"
        Me.txtstrand.Size = New System.Drawing.Size(304, 22)
        Me.txtstrand.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "ENTER STRAND"
        '
        'btnclose
        '
        Me.btnclose.Animated = True
        Me.btnclose.CheckedState.Parent = Me.btnclose
        Me.btnclose.CustomImages.Parent = Me.btnclose
        Me.btnclose.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.HoverState.Parent = Me.btnclose
        Me.btnclose.Image = Global.ProjectES.My.Resources.Resources.delete3
        Me.btnclose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnclose.Location = New System.Drawing.Point(291, 156)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.ShadowDecoration.Parent = Me.btnclose
        Me.btnclose.Size = New System.Drawing.Size(90, 31)
        Me.btnclose.TabIndex = 37
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnupdate
        '
        Me.btnupdate.Animated = True
        Me.btnupdate.CheckedState.Parent = Me.btnupdate
        Me.btnupdate.CustomImages.Parent = Me.btnupdate
        Me.btnupdate.Enabled = False
        Me.btnupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.HoverState.Parent = Me.btnupdate
        Me.btnupdate.Image = Global.ProjectES.My.Resources.Resources.update
        Me.btnupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnupdate.Location = New System.Drawing.Point(196, 156)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.ShadowDecoration.Parent = Me.btnupdate
        Me.btnupdate.Size = New System.Drawing.Size(90, 31)
        Me.btnupdate.TabIndex = 36
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnsave
        '
        Me.btnsave.Animated = True
        Me.btnsave.CheckedState.Parent = Me.btnsave
        Me.btnsave.CustomImages.Parent = Me.btnsave
        Me.btnsave.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.HoverState.Parent = Me.btnsave
        Me.btnsave.Image = Global.ProjectES.My.Resources.Resources._16
        Me.btnsave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnsave.Location = New System.Drawing.Point(101, 156)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.ShadowDecoration.Parent = Me.btnsave
        Me.btnsave.Size = New System.Drawing.Size(90, 31)
        Me.btnsave.TabIndex = 35
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmStrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 215)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstrand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStrand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStrand"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblstrand As Label
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtstrand As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnclose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
End Class

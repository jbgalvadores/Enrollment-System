<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        Me.lbladdroom = New System.Windows.Forms.Label()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtroom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbladdroom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 34)
        Me.Panel1.TabIndex = 43
        '
        'lbladdroom
        '
        Me.lbladdroom.AutoSize = True
        Me.lbladdroom.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdroom.ForeColor = System.Drawing.Color.Black
        Me.lbladdroom.Location = New System.Drawing.Point(12, 9)
        Me.lbladdroom.Name = "lbladdroom"
        Me.lbladdroom.Size = New System.Drawing.Size(67, 16)
        Me.lbladdroom.TabIndex = 0
        Me.lbladdroom.Text = "ADD ROOM"
        '
        'cbostatus
        '
        Me.cbostatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbostatus.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"USED", "UNUSED"})
        Me.cbostatus.Location = New System.Drawing.Point(119, 129)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(300, 21)
        Me.cbostatus.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(44, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Status"
        '
        'txtdescription
        '
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtdescription.Location = New System.Drawing.Point(119, 96)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(300, 22)
        Me.txtdescription.TabIndex = 64
        '
        'txtroom
        '
        Me.txtroom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtroom.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtroom.Location = New System.Drawing.Point(119, 63)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(300, 22)
        Me.txtroom.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(44, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Room"
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
        Me.btnclose.Location = New System.Drawing.Point(288, 178)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.ShadowDecoration.Parent = Me.btnclose
        Me.btnclose.Size = New System.Drawing.Size(90, 31)
        Me.btnclose.TabIndex = 69
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
        Me.btnupdate.Location = New System.Drawing.Point(193, 178)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.ShadowDecoration.Parent = Me.btnupdate
        Me.btnupdate.Size = New System.Drawing.Size(90, 31)
        Me.btnupdate.TabIndex = 68
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
        Me.btnsave.Location = New System.Drawing.Point(98, 178)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.ShadowDecoration.Parent = Me.btnsave
        Me.btnsave.Size = New System.Drawing.Size(90, 31)
        Me.btnsave.TabIndex = 67
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 240)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txtroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRoom"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbladdroom As Label
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents txtroom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnclose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubject
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
        Me.lbladdsubject = New System.Windows.Forms.Label()
        Me.btnclose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbostrand = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbogradelevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbosy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbotype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtunits = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbladdsubject)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(727, 34)
        Me.Panel1.TabIndex = 70
        '
        'lbladdsubject
        '
        Me.lbladdsubject.AutoSize = True
        Me.lbladdsubject.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdsubject.ForeColor = System.Drawing.Color.Black
        Me.lbladdsubject.Location = New System.Drawing.Point(12, 9)
        Me.lbladdsubject.Name = "lbladdsubject"
        Me.lbladdsubject.Size = New System.Drawing.Size(85, 16)
        Me.lbladdsubject.TabIndex = 0
        Me.lbladdsubject.Text = "ADD SUBJECT"
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
        Me.btnclose.Location = New System.Drawing.Point(617, 312)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.ShadowDecoration.Parent = Me.btnclose
        Me.btnclose.Size = New System.Drawing.Size(90, 31)
        Me.btnclose.TabIndex = 73
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
        Me.btnupdate.Location = New System.Drawing.Point(114, 312)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.ShadowDecoration.Parent = Me.btnupdate
        Me.btnupdate.Size = New System.Drawing.Size(90, 31)
        Me.btnupdate.TabIndex = 72
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
        Me.btnsave.Location = New System.Drawing.Point(19, 312)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.ShadowDecoration.Parent = Me.btnsave
        Me.btnsave.Size = New System.Drawing.Size(90, 31)
        Me.btnsave.TabIndex = 71
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel6.Controls.Add(Me.cbostrand)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.cbogradelevel)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.cbosy)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 34)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(727, 57)
        Me.Panel6.TabIndex = 74
        '
        'cbostrand
        '
        Me.cbostrand.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbostrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbostrand.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbostrand.FormattingEnabled = True
        Me.cbostrand.Location = New System.Drawing.Point(576, 17)
        Me.cbostrand.Name = "cbostrand"
        Me.cbostrand.Size = New System.Drawing.Size(131, 21)
        Me.cbostrand.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(516, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Strand:"
        '
        'cbogradelevel
        '
        Me.cbogradelevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbogradelevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbogradelevel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbogradelevel.FormattingEnabled = True
        Me.cbogradelevel.Items.AddRange(New Object() {"GRADE 7", "GRADE 8", "GRADE 9", "GRADE 10", "GRADE 11", "GRADE 12"})
        Me.cbogradelevel.Location = New System.Drawing.Point(379, 17)
        Me.cbogradelevel.Name = "cbogradelevel"
        Me.cbogradelevel.Size = New System.Drawing.Size(131, 21)
        Me.cbogradelevel.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(280, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grade Level:"
        '
        'cbosy
        '
        Me.cbosy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbosy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbosy.Enabled = False
        Me.cbosy.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbosy.FormattingEnabled = True
        Me.cbosy.Location = New System.Drawing.Point(81, 17)
        Me.cbosy.Name = "cbosy"
        Me.cbosy.Size = New System.Drawing.Size(188, 21)
        Me.cbosy.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AY Code:"
        '
        'cbotype
        '
        Me.cbotype.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbotype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbotype.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbotype.FormattingEnabled = True
        Me.cbotype.Items.AddRange(New Object() {"CORE", "APPLIED", "SPECIALIZED"})
        Me.cbotype.Location = New System.Drawing.Point(234, 241)
        Me.cbotype.Name = "cbotype"
        Me.cbotype.Size = New System.Drawing.Size(325, 21)
        Me.cbotype.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(139, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Type"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(139, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "No. of Unit/s"
        '
        'txtunits
        '
        Me.txtunits.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtunits.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtunits.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtunits.Location = New System.Drawing.Point(234, 196)
        Me.txtunits.Name = "txtunits"
        Me.txtunits.Size = New System.Drawing.Size(325, 22)
        Me.txtunits.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(139, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Descriptive Title"
        '
        'txttitle
        '
        Me.txttitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txttitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txttitle.Location = New System.Drawing.Point(234, 152)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(325, 22)
        Me.txttitle.TabIndex = 77
        '
        'lbllname
        '
        Me.lbllname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllname.AutoSize = True
        Me.lbllname.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbllname.Location = New System.Drawing.Point(139, 110)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(74, 13)
        Me.lbllname.TabIndex = 76
        Me.lbllname.Text = "Subject Code"
        '
        'txtcode
        '
        Me.txtcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcode.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtcode.Location = New System.Drawing.Point(234, 110)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(325, 22)
        Me.txtcode.TabIndex = 75
        '
        'frmSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 355)
        Me.Controls.Add(Me.cbotype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtunits)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSubject"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbladdsubject As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbostrand As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbogradelevel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbosy As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbotype As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtunits As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttitle As TextBox
    Friend WithEvents lbllname As Label
    Friend WithEvents txtcode As TextBox
End Class

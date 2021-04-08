<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSection
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
        Me.lbladdsection = New System.Windows.Forms.Label()
        Me.cboroom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboteacher = New System.Windows.Forms.ComboBox()
        Me.lblteacher = New System.Windows.Forms.Label()
        Me.txtteacherid = New System.Windows.Forms.TextBox()
        Me.lblteacherid = New System.Windows.Forms.Label()
        Me.cbostrand = New System.Windows.Forms.ComboBox()
        Me.cbogradelevel = New System.Windows.Forms.ComboBox()
        Me.lblsection = New System.Windows.Forms.Label()
        Me.txtsection = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.btnsave = New MetroFramework.Controls.MetroButton()
        Me.btnupdate = New MetroFramework.Controls.MetroButton()
        Me.btnclose = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbladdsection)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 34)
        Me.Panel1.TabIndex = 42
        '
        'lbladdsection
        '
        Me.lbladdsection.AutoSize = True
        Me.lbladdsection.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdsection.ForeColor = System.Drawing.Color.Black
        Me.lbladdsection.Location = New System.Drawing.Point(12, 9)
        Me.lbladdsection.Name = "lbladdsection"
        Me.lbladdsection.Size = New System.Drawing.Size(83, 16)
        Me.lbladdsection.TabIndex = 0
        Me.lbladdsection.Text = "ADD SECTION"
        '
        'cboroom
        '
        Me.cboroom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboroom.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboroom.FormattingEnabled = True
        Me.cboroom.Location = New System.Drawing.Point(133, 151)
        Me.cboroom.Name = "cboroom"
        Me.cboroom.Size = New System.Drawing.Size(289, 21)
        Me.cboroom.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Room"
        '
        'cboteacher
        '
        Me.cboteacher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboteacher.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboteacher.FormattingEnabled = True
        Me.cboteacher.Location = New System.Drawing.Point(133, 217)
        Me.cboteacher.Name = "cboteacher"
        Me.cboteacher.Size = New System.Drawing.Size(289, 21)
        Me.cboteacher.TabIndex = 58
        '
        'lblteacher
        '
        Me.lblteacher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblteacher.AutoSize = True
        Me.lblteacher.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblteacher.ForeColor = System.Drawing.Color.Black
        Me.lblteacher.Location = New System.Drawing.Point(51, 223)
        Me.lblteacher.Name = "lblteacher"
        Me.lblteacher.Size = New System.Drawing.Size(45, 13)
        Me.lblteacher.TabIndex = 57
        Me.lblteacher.Text = "Teacher"
        '
        'txtteacherid
        '
        Me.txtteacherid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtteacherid.Enabled = False
        Me.txtteacherid.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtteacherid.Location = New System.Drawing.Point(133, 184)
        Me.txtteacherid.Name = "txtteacherid"
        Me.txtteacherid.Size = New System.Drawing.Size(289, 22)
        Me.txtteacherid.TabIndex = 56
        '
        'lblteacherid
        '
        Me.lblteacherid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblteacherid.AutoSize = True
        Me.lblteacherid.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblteacherid.ForeColor = System.Drawing.Color.Black
        Me.lblteacherid.Location = New System.Drawing.Point(51, 190)
        Me.lblteacherid.Name = "lblteacherid"
        Me.lblteacherid.Size = New System.Drawing.Size(59, 13)
        Me.lblteacherid.TabIndex = 55
        Me.lblteacherid.Text = "Teacher ID"
        '
        'cbostrand
        '
        Me.cbostrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbostrand.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbostrand.FormattingEnabled = True
        Me.cbostrand.Location = New System.Drawing.Point(133, 85)
        Me.cbostrand.Name = "cbostrand"
        Me.cbostrand.Size = New System.Drawing.Size(289, 21)
        Me.cbostrand.TabIndex = 54
        '
        'cbogradelevel
        '
        Me.cbogradelevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbogradelevel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbogradelevel.FormattingEnabled = True
        Me.cbogradelevel.Items.AddRange(New Object() {"GRADE 7", "GRADE 8", "GRADE 9", "GRADE 10", "GRADE 11", "GRADE 12"})
        Me.cbogradelevel.Location = New System.Drawing.Point(133, 52)
        Me.cbogradelevel.Name = "cbogradelevel"
        Me.cbogradelevel.Size = New System.Drawing.Size(289, 21)
        Me.cbogradelevel.TabIndex = 53
        '
        'lblsection
        '
        Me.lblsection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsection.AutoSize = True
        Me.lblsection.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblsection.ForeColor = System.Drawing.Color.Black
        Me.lblsection.Location = New System.Drawing.Point(51, 122)
        Me.lblsection.Name = "lblsection"
        Me.lblsection.Size = New System.Drawing.Size(44, 13)
        Me.lblsection.TabIndex = 52
        Me.lblsection.Text = "Section"
        '
        'txtsection
        '
        Me.txtsection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsection.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtsection.Location = New System.Drawing.Point(133, 118)
        Me.txtsection.Name = "txtsection"
        Me.txtsection.Size = New System.Drawing.Size(289, 22)
        Me.txtsection.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(51, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Strand"
        '
        'lblgrade
        '
        Me.lblgrade.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblgrade.ForeColor = System.Drawing.Color.Black
        Me.lblgrade.Location = New System.Drawing.Point(51, 56)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(67, 13)
        Me.lblgrade.TabIndex = 49
        Me.lblgrade.Text = "Grade Level"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(129, 262)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 61
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseSelectable = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(210, 262)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 61
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseSelectable = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(291, 262)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 61
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseSelectable = True
        '
        'frmAddSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(494, 313)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cboroom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboteacher)
        Me.Controls.Add(Me.lblteacher)
        Me.Controls.Add(Me.txtteacherid)
        Me.Controls.Add(Me.lblteacherid)
        Me.Controls.Add(Me.lblgrade)
        Me.Controls.Add(Me.cbostrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbogradelevel)
        Me.Controls.Add(Me.txtsection)
        Me.Controls.Add(Me.lblsection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddSection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddSection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbladdsection As Label
    Friend WithEvents cboroom As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboteacher As ComboBox
    Friend WithEvents lblteacher As Label
    Friend WithEvents txtteacherid As TextBox
    Friend WithEvents lblteacherid As Label
    Friend WithEvents cbostrand As ComboBox
    Friend WithEvents cbogradelevel As ComboBox
    Friend WithEvents lblsection As Label
    Friend WithEvents txtsection As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblgrade As Label
    Friend WithEvents btnsave As MetroFramework.Controls.MetroButton
    Friend WithEvents btnupdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnclose As MetroFramework.Controls.MetroButton
End Class

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
        Me.lblenrollment = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textsubgrade = New System.Windows.Forms.TextBox()
        Me.btncanel = New MetroFramework.Controls.MetroButton()
        Me.btnadd = New MetroFramework.Controls.MetroButton()
        Me.btnsearch = New MetroFramework.Controls.MetroButton()
        Me.linkAdmClose = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtsubdesc
        '
        Me.txtsubdesc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsubdesc.Enabled = False
        Me.txtsubdesc.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtsubdesc.Location = New System.Drawing.Point(121, 110)
        Me.txtsubdesc.Name = "txtsubdesc"
        Me.txtsubdesc.Size = New System.Drawing.Size(431, 25)
        Me.txtsubdesc.TabIndex = 10
        '
        'txtsubjectcode
        '
        Me.txtsubjectcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsubjectcode.Enabled = False
        Me.txtsubjectcode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtsubjectcode.Location = New System.Drawing.Point(121, 70)
        Me.txtsubjectcode.Name = "txtsubjectcode"
        Me.txtsubjectcode.Size = New System.Drawing.Size(158, 25)
        Me.txtsubjectcode.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DESCRIPTION"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 70)
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
        Me.Panel1.Size = New System.Drawing.Size(566, 38)
        Me.Panel1.TabIndex = 11
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
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(339, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "GRADE"
        '
        'textsubgrade
        '
        Me.textsubgrade.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textsubgrade.Enabled = False
        Me.textsubgrade.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.textsubgrade.Location = New System.Drawing.Point(394, 70)
        Me.textsubgrade.Name = "textsubgrade"
        Me.textsubgrade.Size = New System.Drawing.Size(158, 25)
        Me.textsubgrade.TabIndex = 9
        '
        'btncanel
        '
        Me.btncanel.Location = New System.Drawing.Point(477, 162)
        Me.btncanel.Name = "btncanel"
        Me.btncanel.Size = New System.Drawing.Size(75, 23)
        Me.btncanel.TabIndex = 62
        Me.btncanel.Text = "CANCEL"
        Me.btncanel.UseSelectable = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(396, 162)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 63
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseSelectable = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(31, 162)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 64
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseSelectable = True
        '
        'linkAdmClose
        '
        Me.linkAdmClose.Location = New System.Drawing.Point(477, 8)
        Me.linkAdmClose.Name = "linkAdmClose"
        Me.linkAdmClose.Size = New System.Drawing.Size(75, 23)
        Me.linkAdmClose.TabIndex = 63
        Me.linkAdmClose.Text = "CLOSE"
        Me.linkAdmClose.UseSelectable = True
        '
        'frmaddgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 205)
        Me.Controls.Add(Me.btncanel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtsubdesc)
        Me.Controls.Add(Me.textsubgrade)
        Me.Controls.Add(Me.txtsubjectcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmaddgrade"
        Me.Text = "frmaddgrade"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class

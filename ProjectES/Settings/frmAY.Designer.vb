<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAY
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
        Me.cboterm = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtyear2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtyear1 = New System.Windows.Forms.TextBox()
        Me.lblyear2 = New System.Windows.Forms.Label()
        Me.lblyear1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(426, 34)
        Me.Panel1.TabIndex = 43
        '
        'lbladdnewuser
        '
        Me.lbladdnewuser.AutoSize = True
        Me.lbladdnewuser.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdnewuser.ForeColor = System.Drawing.Color.Black
        Me.lbladdnewuser.Location = New System.Drawing.Point(12, 9)
        Me.lbladdnewuser.Name = "lbladdnewuser"
        Me.lbladdnewuser.Size = New System.Drawing.Size(98, 16)
        Me.lbladdnewuser.TabIndex = 0
        Me.lbladdnewuser.Text = "ACADEMIC YEAR"
        '
        'cboterm
        '
        Me.cboterm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboterm.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cboterm.FormattingEnabled = True
        Me.cboterm.Items.AddRange(New Object() {"1ST TERM", "2ND TERM"})
        Me.cboterm.Location = New System.Drawing.Point(112, 118)
        Me.cboterm.Name = "cboterm"
        Me.cboterm.Size = New System.Drawing.Size(277, 21)
        Me.cboterm.TabIndex = 53
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(107, 159)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(78, 26)
        Me.btnsave.TabIndex = 52
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Enabled = False
        Me.btnupdate.FlatAppearance.BorderSize = 0
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(191, 159)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(78, 26)
        Me.btnupdate.TabIndex = 51
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(275, 159)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(78, 26)
        Me.btncancel.TabIndex = 50
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtyear2
        '
        Me.txtyear2.Enabled = False
        Me.txtyear2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtyear2.Location = New System.Drawing.Point(112, 85)
        Me.txtyear2.Name = "txtyear2"
        Me.txtyear2.Size = New System.Drawing.Size(277, 22)
        Me.txtyear2.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(33, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Term"
        '
        'txtyear1
        '
        Me.txtyear1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtyear1.Location = New System.Drawing.Point(112, 52)
        Me.txtyear1.Name = "txtyear1"
        Me.txtyear1.Size = New System.Drawing.Size(277, 22)
        Me.txtyear1.TabIndex = 48
        '
        'lblyear2
        '
        Me.lblyear2.AutoSize = True
        Me.lblyear2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblyear2.Location = New System.Drawing.Point(33, 85)
        Me.lblyear2.Name = "lblyear2"
        Me.lblyear2.Size = New System.Drawing.Size(37, 13)
        Me.lblyear2.TabIndex = 47
        Me.lblyear2.Text = "Year 2"
        '
        'lblyear1
        '
        Me.lblyear1.AutoSize = True
        Me.lblyear1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblyear1.Location = New System.Drawing.Point(33, 56)
        Me.lblyear1.Name = "lblyear1"
        Me.lblyear1.Size = New System.Drawing.Size(35, 13)
        Me.lblyear1.TabIndex = 45
        Me.lblyear1.Text = "Year 1"
        '
        'frmAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 218)
        Me.Controls.Add(Me.cboterm)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtyear2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtyear1)
        Me.Controls.Add(Me.lblyear2)
        Me.Controls.Add(Me.lblyear1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbladdnewuser As Label
    Friend WithEvents cboterm As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents txtyear2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtyear1 As TextBox
    Friend WithEvents lblyear2 As Label
    Friend WithEvents lblyear1 As Label
End Class

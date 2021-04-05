<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaintenance
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
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.lblModule = New System.Windows.Forms.Label()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.buttonSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textSchoolDivision = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textSchoolRegion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textSchoolAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textSchoolName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textSchoolID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textMaxStudent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textMessage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.textEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblModule)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 59)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Animated = True
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnClose.ImageSize = New System.Drawing.Size(0, 0)
        Me.btnClose.Location = New System.Drawing.Point(870, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "CLOSE"
        '
        'lblModule
        '
        Me.lblModule.AutoSize = True
        Me.lblModule.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModule.Location = New System.Drawing.Point(17, 19)
        Me.lblModule.Name = "lblModule"
        Me.lblModule.Size = New System.Drawing.Size(123, 23)
        Me.lblModule.TabIndex = 0
        Me.lblModule.Text = "MAINTENANCE"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(12, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(933, 607)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.buttonSave)
        Me.MetroTabPage1.Controls.Add(Me.Label5)
        Me.MetroTabPage1.Controls.Add(Me.Label4)
        Me.MetroTabPage1.Controls.Add(Me.Label2)
        Me.MetroTabPage1.Controls.Add(Me.Label3)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.Controls.Add(Me.textSchoolDivision)
        Me.MetroTabPage1.Controls.Add(Me.textSchoolRegion)
        Me.MetroTabPage1.Controls.Add(Me.textSchoolAddress)
        Me.MetroTabPage1.Controls.Add(Me.textSchoolName)
        Me.MetroTabPage1.Controls.Add(Me.textSchoolID)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 4
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(925, 565)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "SCHOOL SETUP"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'buttonSave
        '
        Me.buttonSave.CheckedState.Parent = Me.buttonSave
        Me.buttonSave.CustomImages.Parent = Me.buttonSave
        Me.buttonSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.buttonSave.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSave.ForeColor = System.Drawing.Color.White
        Me.buttonSave.HoverState.Parent = Me.buttonSave
        Me.buttonSave.Location = New System.Drawing.Point(180, 452)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.ShadowDecoration.Parent = Me.buttonSave
        Me.buttonSave.Size = New System.Drawing.Size(98, 32)
        Me.buttonSave.TabIndex = 4
        Me.buttonSave.Text = "SAVE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "DIVISION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "REGION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SCHOOL NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SCHOOL ADDRESS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "STUDENT ID"
        '
        'textSchoolDivision
        '
        Me.textSchoolDivision.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textSchoolDivision.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textSchoolDivision.DefaultText = ""
        Me.textSchoolDivision.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textSchoolDivision.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textSchoolDivision.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolDivision.DisabledState.Parent = Me.textSchoolDivision
        Me.textSchoolDivision.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolDivision.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolDivision.FocusedState.Parent = Me.textSchoolDivision
        Me.textSchoolDivision.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSchoolDivision.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolDivision.HoverState.Parent = Me.textSchoolDivision
        Me.textSchoolDivision.Location = New System.Drawing.Point(180, 409)
        Me.textSchoolDivision.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textSchoolDivision.Name = "textSchoolDivision"
        Me.textSchoolDivision.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textSchoolDivision.PlaceholderText = ""
        Me.textSchoolDivision.SelectedText = ""
        Me.textSchoolDivision.ShadowDecoration.Parent = Me.textSchoolDivision
        Me.textSchoolDivision.Size = New System.Drawing.Size(532, 28)
        Me.textSchoolDivision.TabIndex = 2
        '
        'textSchoolRegion
        '
        Me.textSchoolRegion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textSchoolRegion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textSchoolRegion.DefaultText = ""
        Me.textSchoolRegion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textSchoolRegion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textSchoolRegion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolRegion.DisabledState.Parent = Me.textSchoolRegion
        Me.textSchoolRegion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolRegion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolRegion.FocusedState.Parent = Me.textSchoolRegion
        Me.textSchoolRegion.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSchoolRegion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolRegion.HoverState.Parent = Me.textSchoolRegion
        Me.textSchoolRegion.Location = New System.Drawing.Point(180, 311)
        Me.textSchoolRegion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textSchoolRegion.Name = "textSchoolRegion"
        Me.textSchoolRegion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textSchoolRegion.PlaceholderText = ""
        Me.textSchoolRegion.SelectedText = ""
        Me.textSchoolRegion.ShadowDecoration.Parent = Me.textSchoolRegion
        Me.textSchoolRegion.Size = New System.Drawing.Size(532, 28)
        Me.textSchoolRegion.TabIndex = 2
        '
        'textSchoolAddress
        '
        Me.textSchoolAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textSchoolAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textSchoolAddress.DefaultText = ""
        Me.textSchoolAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textSchoolAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textSchoolAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolAddress.DisabledState.Parent = Me.textSchoolAddress
        Me.textSchoolAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolAddress.FocusedState.Parent = Me.textSchoolAddress
        Me.textSchoolAddress.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSchoolAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolAddress.HoverState.Parent = Me.textSchoolAddress
        Me.textSchoolAddress.Location = New System.Drawing.Point(180, 219)
        Me.textSchoolAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textSchoolAddress.Name = "textSchoolAddress"
        Me.textSchoolAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textSchoolAddress.PlaceholderText = ""
        Me.textSchoolAddress.SelectedText = ""
        Me.textSchoolAddress.ShadowDecoration.Parent = Me.textSchoolAddress
        Me.textSchoolAddress.Size = New System.Drawing.Size(532, 28)
        Me.textSchoolAddress.TabIndex = 2
        '
        'textSchoolName
        '
        Me.textSchoolName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textSchoolName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textSchoolName.DefaultText = ""
        Me.textSchoolName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textSchoolName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textSchoolName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolName.DisabledState.Parent = Me.textSchoolName
        Me.textSchoolName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolName.FocusedState.Parent = Me.textSchoolName
        Me.textSchoolName.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSchoolName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolName.HoverState.Parent = Me.textSchoolName
        Me.textSchoolName.Location = New System.Drawing.Point(180, 129)
        Me.textSchoolName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textSchoolName.Name = "textSchoolName"
        Me.textSchoolName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textSchoolName.PlaceholderText = ""
        Me.textSchoolName.SelectedText = ""
        Me.textSchoolName.ShadowDecoration.Parent = Me.textSchoolName
        Me.textSchoolName.Size = New System.Drawing.Size(532, 28)
        Me.textSchoolName.TabIndex = 2
        '
        'textSchoolID
        '
        Me.textSchoolID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textSchoolID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textSchoolID.DefaultText = ""
        Me.textSchoolID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textSchoolID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textSchoolID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolID.DisabledState.Parent = Me.textSchoolID
        Me.textSchoolID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textSchoolID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolID.FocusedState.Parent = Me.textSchoolID
        Me.textSchoolID.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSchoolID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textSchoolID.HoverState.Parent = Me.textSchoolID
        Me.textSchoolID.Location = New System.Drawing.Point(180, 53)
        Me.textSchoolID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textSchoolID.Name = "textSchoolID"
        Me.textSchoolID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textSchoolID.PlaceholderText = ""
        Me.textSchoolID.SelectedText = ""
        Me.textSchoolID.ShadowDecoration.Parent = Me.textSchoolID
        Me.textSchoolID.Size = New System.Drawing.Size(532, 28)
        Me.textSchoolID.TabIndex = 2
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Guna2Button1)
        Me.MetroTabPage2.Controls.Add(Me.Label6)
        Me.MetroTabPage2.Controls.Add(Me.textMaxStudent)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 4
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(925, 565)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "MAX STUDENT /SECTION"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(180, 87)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(98, 32)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "SAVE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(176, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ENTER MAX STUDENT PER SECTION"
        '
        'textMaxStudent
        '
        Me.textMaxStudent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textMaxStudent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textMaxStudent.DefaultText = ""
        Me.textMaxStudent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textMaxStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textMaxStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textMaxStudent.DisabledState.Parent = Me.textMaxStudent
        Me.textMaxStudent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textMaxStudent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textMaxStudent.FocusedState.Parent = Me.textMaxStudent
        Me.textMaxStudent.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textMaxStudent.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textMaxStudent.HoverState.Parent = Me.textMaxStudent
        Me.textMaxStudent.Location = New System.Drawing.Point(180, 53)
        Me.textMaxStudent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textMaxStudent.Name = "textMaxStudent"
        Me.textMaxStudent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textMaxStudent.PlaceholderText = ""
        Me.textMaxStudent.SelectedText = ""
        Me.textMaxStudent.ShadowDecoration.Parent = Me.textMaxStudent
        Me.textMaxStudent.Size = New System.Drawing.Size(532, 28)
        Me.textMaxStudent.TabIndex = 4
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.Guna2Button2)
        Me.MetroTabPage3.Controls.Add(Me.Label9)
        Me.MetroTabPage3.Controls.Add(Me.Label8)
        Me.MetroTabPage3.Controls.Add(Me.Label7)
        Me.MetroTabPage3.Controls.Add(Me.textMessage)
        Me.MetroTabPage3.Controls.Add(Me.textPassword)
        Me.MetroTabPage3.Controls.Add(Me.textEmail)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 4
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(925, 565)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "EMAIL SETTINGS FOR SENDING"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(178, 233)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(98, 32)
        Me.Guna2Button2.TabIndex = 7
        Me.Guna2Button2.Text = "SAVE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(176, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "MESSAGE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(176, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(176, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "EMAIL"
        '
        'textMessage
        '
        Me.textMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textMessage.DefaultText = ""
        Me.textMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textMessage.DisabledState.Parent = Me.textMessage
        Me.textMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textMessage.FocusedState.Parent = Me.textMessage
        Me.textMessage.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textMessage.HoverState.Parent = Me.textMessage
        Me.textMessage.Location = New System.Drawing.Point(180, 194)
        Me.textMessage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textMessage.Name = "textMessage"
        Me.textMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textMessage.PlaceholderText = ""
        Me.textMessage.SelectedText = ""
        Me.textMessage.ShadowDecoration.Parent = Me.textMessage
        Me.textMessage.Size = New System.Drawing.Size(532, 33)
        Me.textMessage.TabIndex = 4
        '
        'textPassword
        '
        Me.textPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textPassword.DefaultText = ""
        Me.textPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textPassword.DisabledState.Parent = Me.textPassword
        Me.textPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textPassword.FocusedState.Parent = Me.textPassword
        Me.textPassword.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textPassword.HoverState.Parent = Me.textPassword
        Me.textPassword.Location = New System.Drawing.Point(180, 122)
        Me.textPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textPassword.PlaceholderText = ""
        Me.textPassword.SelectedText = ""
        Me.textPassword.ShadowDecoration.Parent = Me.textPassword
        Me.textPassword.Size = New System.Drawing.Size(532, 28)
        Me.textPassword.TabIndex = 4
        Me.textPassword.UseSystemPasswordChar = True
        '
        'textEmail
        '
        Me.textEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textEmail.DefaultText = ""
        Me.textEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.textEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.textEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textEmail.DisabledState.Parent = Me.textEmail
        Me.textEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.textEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textEmail.FocusedState.Parent = Me.textEmail
        Me.textEmail.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.textEmail.HoverState.Parent = Me.textEmail
        Me.textEmail.Location = New System.Drawing.Point(180, 53)
        Me.textEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.textEmail.Name = "textEmail"
        Me.textEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textEmail.PlaceholderText = ""
        Me.textEmail.SelectedText = ""
        Me.textEmail.ShadowDecoration.Parent = Me.textEmail
        Me.textEmail.Size = New System.Drawing.Size(532, 28)
        Me.textEmail.TabIndex = 4
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 687)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMaintenance"
        Me.Text = "frmMaintenance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblModule As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents textSchoolID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents textSchoolName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents buttonSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textSchoolDivision As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textSchoolRegion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textSchoolAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textMaxStudent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents textPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents textMessage As Guna.UI2.WinForms.Guna2TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbldesignation = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.sectionpanel = New System.Windows.Forms.Panel()
        Me.lbltotalsection = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.academicpanel = New System.Windows.Forms.Panel()
        Me.lblacademicyear = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.enrolledpanel = New System.Windows.Forms.Panel()
        Me.lbltotalenrolled = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studentpanel = New System.Windows.Forms.Panel()
        Me.lbltotalstudents = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDataEntry = New Guna.UI2.WinForms.Guna2Button()
        Me.btnManagement = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRecords = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnrollment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdmission = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaintenance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbldatelog = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.mainpanel.SuspendLayout()
        Me.sectionpanel.SuspendLayout()
        Me.academicpanel.SuspendLayout()
        Me.enrolledpanel.SuspendLayout()
        Me.studentpanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 123)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(146, 123)
        Me.Panel4.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(139, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(761, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PANGANTUCAN COMMUNITY HIGH SCHOOL ENROLLMENT SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnDataEntry)
        Me.Panel2.Controls.Add(Me.btnManagement)
        Me.Panel2.Controls.Add(Me.btnRecords)
        Me.Panel2.Controls.Add(Me.btnEnrollment)
        Me.Panel2.Controls.Add(Me.btnAdmission)
        Me.Panel2.Controls.Add(Me.btnMaintenance)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 523)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbldesignation)
        Me.Panel3.Controls.Add(Me.lblfullname)
        Me.Panel3.Controls.Add(Me.picUser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(182, 177)
        Me.Panel3.TabIndex = 0
        '
        'lbldesignation
        '
        Me.lbldesignation.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesignation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldesignation.Location = New System.Drawing.Point(0, 127)
        Me.lbldesignation.Name = "lbldesignation"
        Me.lbldesignation.Size = New System.Drawing.Size(169, 24)
        Me.lbldesignation.TabIndex = 1
        Me.lbldesignation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfullname
        '
        Me.lblfullname.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblfullname.Location = New System.Drawing.Point(0, 110)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(169, 24)
        Me.lblfullname.TabIndex = 1
        Me.lblfullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.sectionpanel)
        Me.mainpanel.Controls.Add(Me.academicpanel)
        Me.mainpanel.Controls.Add(Me.enrolledpanel)
        Me.mainpanel.Controls.Add(Me.studentpanel)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(182, 123)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(873, 523)
        Me.mainpanel.TabIndex = 2
        '
        'sectionpanel
        '
        Me.sectionpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sectionpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.sectionpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sectionpanel.Controls.Add(Me.lbltotalsection)
        Me.sectionpanel.Controls.Add(Me.PictureBox5)
        Me.sectionpanel.Controls.Add(Me.Label5)
        Me.sectionpanel.Location = New System.Drawing.Point(481, 268)
        Me.sectionpanel.Name = "sectionpanel"
        Me.sectionpanel.Size = New System.Drawing.Size(317, 188)
        Me.sectionpanel.TabIndex = 29
        '
        'lbltotalsection
        '
        Me.lbltotalsection.AutoSize = True
        Me.lbltotalsection.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalsection.ForeColor = System.Drawing.Color.White
        Me.lbltotalsection.Location = New System.Drawing.Point(3, 0)
        Me.lbltotalsection.Name = "lbltotalsection"
        Me.lbltotalsection.Size = New System.Drawing.Size(0, 36)
        Me.lbltotalsection.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(97, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Total Sections"
        '
        'academicpanel
        '
        Me.academicpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.academicpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.academicpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.academicpanel.Controls.Add(Me.lblacademicyear)
        Me.academicpanel.Controls.Add(Me.PictureBox4)
        Me.academicpanel.Controls.Add(Me.Label4)
        Me.academicpanel.Location = New System.Drawing.Point(103, 268)
        Me.academicpanel.Name = "academicpanel"
        Me.academicpanel.Size = New System.Drawing.Size(317, 188)
        Me.academicpanel.TabIndex = 28
        '
        'lblacademicyear
        '
        Me.lblacademicyear.AutoSize = True
        Me.lblacademicyear.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacademicyear.ForeColor = System.Drawing.Color.White
        Me.lblacademicyear.Location = New System.Drawing.Point(3, 0)
        Me.lblacademicyear.Name = "lblacademicyear"
        Me.lblacademicyear.Size = New System.Drawing.Size(0, 36)
        Me.lblacademicyear.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(92, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 26)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Academic Year"
        '
        'enrolledpanel
        '
        Me.enrolledpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.enrolledpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.enrolledpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.enrolledpanel.Controls.Add(Me.lbltotalenrolled)
        Me.enrolledpanel.Controls.Add(Me.PictureBox3)
        Me.enrolledpanel.Controls.Add(Me.Label3)
        Me.enrolledpanel.Location = New System.Drawing.Point(481, 33)
        Me.enrolledpanel.Name = "enrolledpanel"
        Me.enrolledpanel.Size = New System.Drawing.Size(317, 188)
        Me.enrolledpanel.TabIndex = 27
        '
        'lbltotalenrolled
        '
        Me.lbltotalenrolled.AutoSize = True
        Me.lbltotalenrolled.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalenrolled.ForeColor = System.Drawing.Color.White
        Me.lbltotalenrolled.Location = New System.Drawing.Point(3, 0)
        Me.lbltotalenrolled.Name = "lbltotalenrolled"
        Me.lbltotalenrolled.Size = New System.Drawing.Size(0, 36)
        Me.lbltotalenrolled.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(97, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Enrolled"
        '
        'studentpanel
        '
        Me.studentpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.studentpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.studentpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.studentpanel.Controls.Add(Me.lbltotalstudents)
        Me.studentpanel.Controls.Add(Me.PictureBox2)
        Me.studentpanel.Controls.Add(Me.Label2)
        Me.studentpanel.Location = New System.Drawing.Point(103, 33)
        Me.studentpanel.Name = "studentpanel"
        Me.studentpanel.Size = New System.Drawing.Size(317, 188)
        Me.studentpanel.TabIndex = 26
        '
        'lbltotalstudents
        '
        Me.lbltotalstudents.AutoSize = True
        Me.lbltotalstudents.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalstudents.ForeColor = System.Drawing.Color.White
        Me.lbltotalstudents.Location = New System.Drawing.Point(5, -2)
        Me.lbltotalstudents.Name = "lbltotalstudents"
        Me.lbltotalstudents.Size = New System.Drawing.Size(0, 36)
        Me.lbltotalstudents.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(90, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Students"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblusername)
        Me.Panel5.Controls.Add(Me.lbldatelog)
        Me.Panel5.Controls.Add(Me.lbldate)
        Me.Panel5.Controls.Add(Me.lbltime)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(182, 618)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(873, 28)
        Me.Panel5.TabIndex = 3
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(118, 65)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(122, 65)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(122, 65)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(118, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = Global.ProjectES.My.Resources.Resources.back
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.Location = New System.Drawing.Point(0, 485)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(182, 38)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnDataEntry
        '
        Me.btnDataEntry.Animated = True
        Me.btnDataEntry.CheckedState.Parent = Me.btnDataEntry
        Me.btnDataEntry.CustomImages.Parent = Me.btnDataEntry
        Me.btnDataEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDataEntry.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnDataEntry.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataEntry.ForeColor = System.Drawing.Color.White
        Me.btnDataEntry.HoverState.Parent = Me.btnDataEntry
        Me.btnDataEntry.Image = Global.ProjectES.My.Resources.Resources.enrollment
        Me.btnDataEntry.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDataEntry.Location = New System.Drawing.Point(0, 405)
        Me.btnDataEntry.Name = "btnDataEntry"
        Me.btnDataEntry.ShadowDecoration.Parent = Me.btnDataEntry
        Me.btnDataEntry.Size = New System.Drawing.Size(182, 38)
        Me.btnDataEntry.TabIndex = 7
        Me.btnDataEntry.Text = "DATA ENTRY"
        Me.btnDataEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDataEntry.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnManagement
        '
        Me.btnManagement.Animated = True
        Me.btnManagement.CheckedState.Parent = Me.btnManagement
        Me.btnManagement.CustomImages.Parent = Me.btnManagement
        Me.btnManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManagement.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnManagement.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagement.ForeColor = System.Drawing.Color.White
        Me.btnManagement.HoverState.Parent = Me.btnManagement
        Me.btnManagement.Image = Global.ProjectES.My.Resources.Resources.reservation_icon
        Me.btnManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnManagement.Location = New System.Drawing.Point(0, 367)
        Me.btnManagement.Name = "btnManagement"
        Me.btnManagement.ShadowDecoration.Parent = Me.btnManagement
        Me.btnManagement.Size = New System.Drawing.Size(182, 38)
        Me.btnManagement.TabIndex = 6
        Me.btnManagement.Text = "MANAGEMENT"
        Me.btnManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnManagement.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnRecords
        '
        Me.btnRecords.Animated = True
        Me.btnRecords.CheckedState.Parent = Me.btnRecords
        Me.btnRecords.CustomImages.Parent = Me.btnRecords
        Me.btnRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecords.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnRecords.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.ForeColor = System.Drawing.Color.White
        Me.btnRecords.HoverState.Parent = Me.btnRecords
        Me.btnRecords.Image = Global.ProjectES.My.Resources.Resources.archive
        Me.btnRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRecords.Location = New System.Drawing.Point(0, 329)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.ShadowDecoration.Parent = Me.btnRecords
        Me.btnRecords.Size = New System.Drawing.Size(182, 38)
        Me.btnRecords.TabIndex = 5
        Me.btnRecords.Text = "RECORDS"
        Me.btnRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRecords.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnEnrollment
        '
        Me.btnEnrollment.Animated = True
        Me.btnEnrollment.CheckedState.Parent = Me.btnEnrollment
        Me.btnEnrollment.CustomImages.Parent = Me.btnEnrollment
        Me.btnEnrollment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnrollment.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnEnrollment.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrollment.ForeColor = System.Drawing.Color.White
        Me.btnEnrollment.HoverState.Parent = Me.btnEnrollment
        Me.btnEnrollment.Image = Global.ProjectES.My.Resources.Resources.business
        Me.btnEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEnrollment.Location = New System.Drawing.Point(0, 291)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.ShadowDecoration.Parent = Me.btnEnrollment
        Me.btnEnrollment.Size = New System.Drawing.Size(182, 38)
        Me.btnEnrollment.TabIndex = 4
        Me.btnEnrollment.Text = "ENROLLMENT"
        Me.btnEnrollment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEnrollment.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnAdmission
        '
        Me.btnAdmission.Animated = True
        Me.btnAdmission.CheckedState.Parent = Me.btnAdmission
        Me.btnAdmission.CustomImages.Parent = Me.btnAdmission
        Me.btnAdmission.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdmission.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAdmission.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmission.ForeColor = System.Drawing.Color.White
        Me.btnAdmission.HoverState.Parent = Me.btnAdmission
        Me.btnAdmission.Image = Global.ProjectES.My.Resources.Resources.admission1
        Me.btnAdmission.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdmission.Location = New System.Drawing.Point(0, 253)
        Me.btnAdmission.Name = "btnAdmission"
        Me.btnAdmission.ShadowDecoration.Parent = Me.btnAdmission
        Me.btnAdmission.Size = New System.Drawing.Size(182, 38)
        Me.btnAdmission.TabIndex = 3
        Me.btnAdmission.Text = "ADMISSION"
        Me.btnAdmission.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAdmission.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Animated = True
        Me.btnMaintenance.CheckedState.Parent = Me.btnMaintenance
        Me.btnMaintenance.CustomImages.Parent = Me.btnMaintenance
        Me.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMaintenance.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnMaintenance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.ForeColor = System.Drawing.Color.White
        Me.btnMaintenance.HoverState.Parent = Me.btnMaintenance
        Me.btnMaintenance.Image = Global.ProjectES.My.Resources.Resources.Settings
        Me.btnMaintenance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMaintenance.Location = New System.Drawing.Point(0, 215)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.ShadowDecoration.Parent = Me.btnMaintenance
        Me.btnMaintenance.Size = New System.Drawing.Size(182, 38)
        Me.btnMaintenance.TabIndex = 2
        Me.btnMaintenance.Text = "SETTINGS"
        Me.btnMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMaintenance.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnDashboard
        '
        Me.btnDashboard.Animated = True
        Me.btnDashboard.CheckedState.Parent = Me.btnDashboard
        Me.btnDashboard.CustomImages.Parent = Me.btnDashboard
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnDashboard.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.HoverState.Parent = Me.btnDashboard
        Me.btnDashboard.Image = Global.ProjectES.My.Resources.Resources.check_icon
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.Location = New System.Drawing.Point(0, 177)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.ShadowDecoration.Parent = Me.btnDashboard
        Me.btnDashboard.Size = New System.Drawing.Size(182, 38)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "DASHBOARD"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.TextOffset = New System.Drawing.Point(20, 0)
        '
        'picUser
        '
        Me.picUser.Image = Global.ProjectES.My.Resources.Resources.teacher
        Me.picUser.Location = New System.Drawing.Point(38, 22)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(90, 85)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser.TabIndex = 0
        Me.picUser.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectES.My.Resources.Resources.PCHS_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "DATE LOGGED IN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "USER:"
        '
        'lbltime
        '
        Me.lbltime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Silver
        Me.lbltime.Location = New System.Drawing.Point(824, 5)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(0, 25)
        Me.lbltime.TabIndex = 24
        '
        'lbldate
        '
        Me.lbldate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Silver
        Me.lbldate.Location = New System.Drawing.Point(728, 1)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(0, 25)
        Me.lbldate.TabIndex = 25
        '
        'lbldatelog
        '
        Me.lbldatelog.AutoSize = True
        Me.lbldatelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatelog.ForeColor = System.Drawing.Color.Silver
        Me.lbldatelog.Location = New System.Drawing.Point(387, 8)
        Me.lbldatelog.Name = "lbldatelog"
        Me.lbldatelog.Size = New System.Drawing.Size(0, 20)
        Me.lbldatelog.TabIndex = 26
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.Silver
        Me.lblusername.Location = New System.Drawing.Point(59, 2)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(0, 20)
        Me.lblusername.TabIndex = 27
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 646)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.mainpanel.ResumeLayout(False)
        Me.sectionpanel.ResumeLayout(False)
        Me.sectionpanel.PerformLayout()
        Me.academicpanel.ResumeLayout(False)
        Me.academicpanel.PerformLayout()
        Me.enrolledpanel.ResumeLayout(False)
        Me.enrolledpanel.PerformLayout()
        Me.studentpanel.ResumeLayout(False)
        Me.studentpanel.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picUser As PictureBox
    Friend WithEvents lbldesignation As Label
    Friend WithEvents lblfullname As Label
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaintenance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEnrollment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdmission As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRecords As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnManagement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDataEntry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mainpanel As Panel
    Friend WithEvents studentpanel As Panel
    Friend WithEvents lbltotalstudents As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents sectionpanel As Panel
    Friend WithEvents lbltotalsection As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents academicpanel As Panel
    Friend WithEvents lblacademicyear As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents enrolledpanel As Panel
    Friend WithEvents lbltotalenrolled As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblusername As Label
    Friend WithEvents lbldatelog As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
End Class

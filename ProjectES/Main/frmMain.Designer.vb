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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lbldatelog = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbldesignation = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnAdmission = New System.Windows.Forms.Button()
        Me.btnEnrollment = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnManagement = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainpanel.SuspendLayout()
        Me.sectionpanel.SuspendLayout()
        Me.academicpanel.SuspendLayout()
        Me.enrolledpanel.SuspendLayout()
        Me.studentpanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 123)
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
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.sectionpanel)
        Me.mainpanel.Controls.Add(Me.academicpanel)
        Me.mainpanel.Controls.Add(Me.enrolledpanel)
        Me.mainpanel.Controls.Add(Me.studentpanel)
        Me.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainpanel.Location = New System.Drawing.Point(182, 123)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(838, 583)
        Me.mainpanel.TabIndex = 2
        '
        'sectionpanel
        '
        Me.sectionpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sectionpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.sectionpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sectionpanel.Controls.Add(Me.lbltotalsection)
        Me.sectionpanel.Controls.Add(Me.Label5)
        Me.sectionpanel.Location = New System.Drawing.Point(464, 298)
        Me.sectionpanel.Name = "sectionpanel"
        Me.sectionpanel.Size = New System.Drawing.Size(317, 188)
        Me.sectionpanel.TabIndex = 29
        '
        'lbltotalsection
        '
        Me.lbltotalsection.AutoSize = True
        Me.lbltotalsection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbltotalsection.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lbltotalsection.ForeColor = System.Drawing.Color.White
        Me.lbltotalsection.Location = New System.Drawing.Point(0, 0)
        Me.lbltotalsection.Name = "lbltotalsection"
        Me.lbltotalsection.Size = New System.Drawing.Size(0, 42)
        Me.lbltotalsection.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(75, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "TOTAL SECTIONS"
        '
        'academicpanel
        '
        Me.academicpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.academicpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.academicpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.academicpanel.Controls.Add(Me.lblacademicyear)
        Me.academicpanel.Controls.Add(Me.Label4)
        Me.academicpanel.Location = New System.Drawing.Point(86, 298)
        Me.academicpanel.Name = "academicpanel"
        Me.academicpanel.Size = New System.Drawing.Size(317, 188)
        Me.academicpanel.TabIndex = 28
        '
        'lblacademicyear
        '
        Me.lblacademicyear.AutoSize = True
        Me.lblacademicyear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblacademicyear.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblacademicyear.ForeColor = System.Drawing.Color.White
        Me.lblacademicyear.Location = New System.Drawing.Point(0, 0)
        Me.lblacademicyear.Name = "lblacademicyear"
        Me.lblacademicyear.Size = New System.Drawing.Size(0, 42)
        Me.lblacademicyear.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ACADEMIC YEAR"
        '
        'enrolledpanel
        '
        Me.enrolledpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.enrolledpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.enrolledpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.enrolledpanel.Controls.Add(Me.lbltotalenrolled)
        Me.enrolledpanel.Controls.Add(Me.Label3)
        Me.enrolledpanel.Location = New System.Drawing.Point(464, 63)
        Me.enrolledpanel.Name = "enrolledpanel"
        Me.enrolledpanel.Size = New System.Drawing.Size(317, 188)
        Me.enrolledpanel.TabIndex = 27
        '
        'lbltotalenrolled
        '
        Me.lbltotalenrolled.AutoSize = True
        Me.lbltotalenrolled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbltotalenrolled.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lbltotalenrolled.ForeColor = System.Drawing.Color.White
        Me.lbltotalenrolled.Location = New System.Drawing.Point(0, 0)
        Me.lbltotalenrolled.Name = "lbltotalenrolled"
        Me.lbltotalenrolled.Size = New System.Drawing.Size(0, 42)
        Me.lbltotalenrolled.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(75, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TOTAL ENROLLED"
        '
        'studentpanel
        '
        Me.studentpanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.studentpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.studentpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.studentpanel.Controls.Add(Me.lbltotalstudents)
        Me.studentpanel.Controls.Add(Me.Label2)
        Me.studentpanel.Location = New System.Drawing.Point(86, 63)
        Me.studentpanel.Name = "studentpanel"
        Me.studentpanel.Size = New System.Drawing.Size(317, 188)
        Me.studentpanel.TabIndex = 26
        '
        'lbltotalstudents
        '
        Me.lbltotalstudents.AutoSize = True
        Me.lbltotalstudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbltotalstudents.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalstudents.ForeColor = System.Drawing.Color.White
        Me.lbltotalstudents.Location = New System.Drawing.Point(0, 0)
        Me.lbltotalstudents.Name = "lbltotalstudents"
        Me.lbltotalstudents.Size = New System.Drawing.Size(0, 42)
        Me.lbltotalstudents.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(75, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TOTAL STUDENTS"
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
        Me.Panel5.Location = New System.Drawing.Point(182, 678)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(838, 28)
        Me.Panel5.TabIndex = 3
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.Black
        Me.lblusername.Location = New System.Drawing.Point(59, 0)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(0, 20)
        Me.lblusername.TabIndex = 27
        '
        'lbldatelog
        '
        Me.lbldatelog.AutoSize = True
        Me.lbldatelog.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatelog.ForeColor = System.Drawing.Color.Black
        Me.lbldatelog.Location = New System.Drawing.Point(387, 2)
        Me.lbldatelog.Name = "lbldatelog"
        Me.lbldatelog.Size = New System.Drawing.Size(0, 20)
        Me.lbldatelog.TabIndex = 26
        '
        'lbldate
        '
        Me.lbldate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Silver
        Me.lbldate.Location = New System.Drawing.Point(693, 1)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(0, 25)
        Me.lbldate.TabIndex = 25
        '
        'lbltime
        '
        Me.lbltime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Silver
        Me.lbltime.Location = New System.Drawing.Point(789, 5)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(0, 25)
        Me.lbltime.TabIndex = 24
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "DATE LOGGED IN:"
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
        Me.lbldesignation.Size = New System.Drawing.Size(182, 24)
        Me.lbldesignation.TabIndex = 1
        Me.lbldesignation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfullname
        '
        Me.lblfullname.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblfullname.Location = New System.Drawing.Point(0, 110)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(182, 24)
        Me.lblfullname.TabIndex = 1
        Me.lblfullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picUser
        '
        Me.picUser.Image = Global.ProjectES.My.Resources.Resources.teacher
        Me.picUser.Location = New System.Drawing.Point(44, 22)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(90, 85)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUser.TabIndex = 0
        Me.picUser.TabStop = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 177)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(182, 44)
        Me.btnDashboard.TabIndex = 10
        Me.btnDashboard.Text = "DASHBOARD"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnAdmission
        '
        Me.btnAdmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnAdmission.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdmission.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmission.Location = New System.Drawing.Point(0, 221)
        Me.btnAdmission.Name = "btnAdmission"
        Me.btnAdmission.Size = New System.Drawing.Size(182, 44)
        Me.btnAdmission.TabIndex = 11
        Me.btnAdmission.Text = "ADMISSION"
        Me.btnAdmission.UseVisualStyleBackColor = False
        '
        'btnEnrollment
        '
        Me.btnEnrollment.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnEnrollment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnrollment.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEnrollment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnrollment.Location = New System.Drawing.Point(0, 265)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(182, 44)
        Me.btnEnrollment.TabIndex = 12
        Me.btnEnrollment.Text = "ENROLLMENT"
        Me.btnEnrollment.UseVisualStyleBackColor = False
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRecords.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.Location = New System.Drawing.Point(0, 309)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(182, 44)
        Me.btnRecords.TabIndex = 13
        Me.btnRecords.Text = "RECORDS"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnManagement
        '
        Me.btnManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManagement.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManagement.Location = New System.Drawing.Point(0, 353)
        Me.btnManagement.Name = "btnManagement"
        Me.btnManagement.Size = New System.Drawing.Size(182, 44)
        Me.btnManagement.TabIndex = 14
        Me.btnManagement.Text = "MANAGEMENT"
        Me.btnManagement.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 397)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(182, 44)
        Me.btnSettings.TabIndex = 15
        Me.btnSettings.Text = "SETTINGS"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 539)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(182, 44)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnSettings)
        Me.Panel2.Controls.Add(Me.btnManagement)
        Me.Panel2.Controls.Add(Me.btnRecords)
        Me.Panel2.Controls.Add(Me.btnEnrollment)
        Me.Panel2.Controls.Add(Me.btnAdmission)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 583)
        Me.Panel2.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 706)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.mainpanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pangantucan Enrollment System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel3.ResumeLayout(False)
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents mainpanel As Panel
    Friend WithEvents studentpanel As Panel
    Friend WithEvents lbltotalstudents As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sectionpanel As Panel
    Friend WithEvents lbltotalsection As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents academicpanel As Panel
    Friend WithEvents lblacademicyear As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents enrolledpanel As Panel
    Friend WithEvents lbltotalenrolled As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblusername As Label
    Friend WithEvents lbldatelog As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbldesignation As Label
    Friend WithEvents lblfullname As Label
    Friend WithEvents picUser As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnAdmission As Button
    Friend WithEvents btnEnrollment As Button
    Friend WithEvents btnRecords As Button
    Friend WithEvents btnManagement As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel2 As Panel
End Class

Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Runtime.Hosting

Public Class frmMain

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = Screen.GetWorkingArea(Me).Width
        Me.Height = Screen.GetWorkingArea(Me).Height + 1
        DoubleBufferedControl(Panel2)
    End Sub




    Public Sub countenrolled()
        opencon()
        Try
            cmd = New OleDbCommand("select count(student_id) from Status_Enrollment where Status=@status", con)
            cmd.Parameters.AddWithValue("@status", "ENROLLED")
            result = cmd.ExecuteScalar
            lbltotalenrolled.Text = result
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countstudent()
        countenrolled()
        Call loadtotalsection()
        Call loadlog()
        Call loadaycode()
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        lbldate.Text = Format(Now, "D")

    End Sub

    Public Sub loadlog()
        opencon()
        Try
            cmd = New OleDbCommand("select * from qlog where ID in (select max(id) from qlog)", con)
            dr = cmd.ExecuteReader
            While dr.Read
                lblusername.Text = dr.Item("username").ToString
                lblfullname.Text = dr.Item("fullname").ToString
                lbldesignation.Text = dr.Item("designation").ToString
                lbldatelog.Text = dr.Item("datetimelog").ToString.ToUpper
            End While
            dr.Close()
            con.Close()
            con.Open()

            cmd = New OleDbCommand("select image from UserAccount where username=@username", con)
            With cmd
                .Parameters.AddWithValue("@username", lblusername.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                Dim arrImage As Byte()
                arrImage = dr.Item("image")
                Dim ms As New System.IO.MemoryStream(arrImage)
                picUser.Image = System.Drawing.Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Public Sub countstudent()
        opencon()
        Try
            cmd = New OleDbCommand("select count(*) from Status_Enrollment", con)
            result = cmd.ExecuteScalar
            lbltotalstudents.Text = result
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub


    Public Sub loadaycode()
        opencon()
        Try
            cmd = New OleDbCommand("select * from aycode where Status='Active'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblacademicyear.Text = dr.Item("aycode").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Public Sub loadtotalsection()
        opencon()
        Try
            cmd = New OleDbCommand("select count(*) from [Section]", con)
            result = cmd.ExecuteScalar
            lbltotalsection.Text = result
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub


    Public Sub closeallforms()
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms(i) IsNot Me Then
                My.Application.OpenForms(i).Dispose()
            End If
        Next
    End Sub




    Private Sub btnManagement_Click(sender As Object, e As EventArgs) Handles btnManagement.Click
        With frmManagement
            .Width = mainpanel.Width
            .Height = mainpanel.Height
            .TopLevel = False
            mainpanel.Controls.Add(frmManagement)
            .BringToFront()
            .loadteacher()
            .loadsection()
            .loadstrand()
            .loadsubject()
            .loadroom()
            .recordfoundroom()
            .recordfoundstrand()
            .recordfoundsection()
            .recordfoundsubject()
            .recordfoundteacher()
            .getay()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Do you want to sign out?", vbQuestion + vbYesNo) = vbYes Then
            frmlogin.txtusername.Clear()
            frmlogin.txtpassword.Clear()
            frmlogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAdmission_Click(sender As Object, e As EventArgs) Handles btnAdmission.Click

        With frmAdmission
            .Width = mainpanel.Width
            .Height = mainpanel.Height
            .TopLevel = False
            mainpanel.Controls.Add(frmAdmission)
            .BringToFront()
            .Show()
        End With

    End Sub



    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click

        If IsNothing(frmenrollment) Then
            frmenrollment = New Form
            frmenrollment.Show()
        End If


        With frmenrollment
            .Width = mainpanel.Width
            .Height = mainpanel.Height
            .TopLevel = False
            mainpanel.Controls.Add(frmenrollment)
            .BringToFront()
            .loadstatus()
            .autosearch()
            .getay()
            .Show()
        End With
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click

        With frmrecord
            .Width = mainpanel.Width
            .Height = mainpanel.Height
            .TopLevel = False
            mainpanel.Controls.Add(frmrecord)

            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        With frmadmin
            .Width = mainpanel.Width
            .Height = mainpanel.Height
            .TopLevel = False
            mainpanel.Controls.Add(frmadmin)

            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        frmrecord.Close()
        frmAdmission.Close()
        frmManagement.Close()
        frmenrollment.Close()
        frmadmin.Close()
    End Sub
End Class

Imports System.Data.OleDb
Imports System.Net.NetworkInformation

Public Class frmAdmission
    Private Sub lnkclose_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click

        Dim f As New Form
        Try
            With f
                .WindowState = FormWindowState.Maximized
                .StartPosition = FormStartPosition.Manual
                .BackColor = Color.Black
                .Opacity = 0.5
                .ShowInTaskbar = False
                .FormBorderStyle = FormBorderStyle.None
                .Show()
                frmAddStudent.Owner = f
                frmAddStudent.ShowDialog()
                lbladmission.Select()
            End With
        Catch ex As Exception
        Finally
            f.Dispose()
        End Try



    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lbladmission.Select()
        If txtsearch.Text = "" Then
            MsgBox("Please select student first", vbExclamation)
            Exit Sub
        End If
        opencon()
        Try

            cmd = New OleDbCommand("select * from Status_Enrollment where aid=@aid", con)
            With cmd
                .Parameters.AddWithValue("@aid", cboaid.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                MsgBox("This student has already been added", vbExclamation)
                Exit Sub
            End If
            dr.Close()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("select max(student_id) from Status_Enrollment", con)
            str = cmd.ExecuteScalar.ToString
            If String.IsNullOrEmpty(str) Then
                str = "S10001"
            Else
                str = str.Substring(1)
                Convert.ToInt32(str)
                Dim i As Integer
                i = str + 1
                str = "S" + i.ToString
            End If
            con.Close()



            con.Open()
            cmd = New OleDbCommand("select *  from StudentInfo where lrn=@lrn", con)
            With cmd
                .Parameters.AddWithValue("@lrn", cbolrn.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            Dim aid As String = String.Empty
            Dim sy As String = String.Empty
            Dim yearlevel As String = String.Empty
            Dim fullname As String = String.Empty
            Dim lrn As String = String.Empty
            If dr.HasRows Then
                aid = dr.Item("aid").ToString
                sy = dr.Item("sy").ToString
                yearlevel = dr.Item("incoming_year").ToString
                fullname = dr.Item("fullname").ToString
                lrn = dr.Item("lrn").ToString
            End If
            con.Close()
            dr.Close()



            If MsgBox("Do you want to save this student?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("insert into Status_Enrollment (student_id,aycode,aid,lrn,fullname,grade_level) values (@student_id,@aycode,@aid,@lrn,@fullname,@grade_level)", con)
                With cmd
                    .Parameters.AddWithValue("student_id", str)
                    .Parameters.AddWithValue("aycode", sy)
                    .Parameters.AddWithValue("@aid", aid)
                    .Parameters.AddWithValue("@lrn", lrn)
                    .Parameters.AddWithValue("fullname", fullname)
                    .Parameters.AddWithValue("grade_level", yearlevel)
                    .ExecuteNonQuery()
                End With
                con.Close()
                con.Open()


                Dim card As String
                Dim form As String
                Dim birth As String
                Dim pic As String
                Dim status As String
                If chkreportcard.Checked = True Then
                    card = "Submitted"
                Else
                    card = "Not Submitted"
                End If
                If chkform.Checked = True Then
                    form = "Submitted"
                Else
                    form = "Not Submitted"
                End If
                If chkbirth.Checked = True Then
                    birth = "Submitted"
                Else
                    birth = "Not Submitted"
                End If
                If chkpic.Checked = True Then
                    pic = "Submitted"
                Else
                    pic = "Not Submitted"
                End If
                If chkbirth.Checked = False And chkform.Checked = False And chkpic.Checked = False And chkreportcard.Checked = False Then
                    status = "Not Submitted"
                ElseIf chkbirth.Checked = True And chkform.Checked = True And chkpic.Checked = True And chkreportcard.Checked = True Then
                    status = "Fully Completed"
                Else
                    status = "Partially Completed"
                End If
                cmd = New OleDbCommand("insert into Requirements (aycode,student_id,aid,full_name,card,enroll_form,birth,pic,status) values (@aycode,@student_id,@aid,@full_name,@card,@enroll_form,@birth,@pic,@status)", con)
                With cmd
                    .Parameters.AddWithValue("@aycode", sy)
                    .Parameters.AddWithValue("@student_id", str)
                    .Parameters.AddWithValue("@aid", cboaid.Text)
                    .Parameters.AddWithValue("@full_name", fullname)
                    .Parameters.AddWithValue("@card", card)
                    .Parameters.AddWithValue("@enroll_form", form)
                    .Parameters.AddWithValue("@birth", birth)
                    .Parameters.AddWithValue("@pic", pic)
                    .Parameters.AddWithValue("@status", status)
                    .ExecuteNonQuery()
                End With
                MsgBox("Student has been saved! Your Student ID is" & " " & str, vbInformation)
                frmMain.countstudent()
                clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub frmAdmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autosearch()
    End Sub
    Public Sub autosearch()
        opencon()
        Try
            str = "select aid,fullname from StudentInfo"
            da = New OleDbDataAdapter(str, con)
            ds = New DataSet
            da.Fill(ds)

            Dim col As New AutoCompleteStringCollection
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("aid").ToString)
                col.Add(ds.Tables(0).Rows(i)("fullname").ToString)
            Next

            txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtsearch.AutoCompleteCustomSource = col
            txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text = String.Empty Then
            clear()
        End If

        opencon()
        Try
            cmd = New OleDbCommand("select * from StudentInfo where aid=@aid or fullname=@fullname", con)
            With cmd
                .Parameters.AddWithValue("@aid", txtsearch.Text)
                .Parameters.AddWithValue("@fullname", txtsearch.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                cbotype.Text = dr.Item("student_type").ToString
                cboaid.Text = dr.Item("aid").ToString
                cbolrn.Text = dr.Item("lrn").ToString
                txtlname.Text = dr.Item("lname").ToString
                txtfname.Text = dr.Item("fname").ToString
                txtmname.Text = dr.Item("mname").ToString
                txtage.Text = dr.Item("age").ToString
                dtpdob.Value = dr.Item("dob")
                txtpob.Text = dr.Item("pob").ToString
                cbosy.Text = dr.Item("sy").ToString
                cboincomingyear.Text = dr.Item("incoming_year").ToString
                txtcontact.Text = dr.Item("contact_no").ToString
                cbogender.Text = dr.Item("gender").ToString
                cbostatus.Text = dr.Item("marital_status").ToString
                txtcitizenship.Text = dr.Item("citizenship").ToString
                txtreligion.Text = dr.Item("religion").ToString
                txtaddress.Text = dr.Item("address").ToString
                txtmlname.Text = dr.Item("mlname").ToString
                txtmfname.Text = dr.Item("mfname").ToString
                txtmmname.Text = dr.Item("mmname").ToString
                txtmocc.Text = dr.Item("mocc").ToString
                txtmcontact.Text = dr.Item("mcontact").ToString
                txtmaddress.Text = dr.Item("maddress").ToString
                txtflname.Text = dr.Item("flname").ToString
                txtffname.Text = dr.Item("ffname").ToString
                txtfmname.Text = dr.Item("fmname").ToString
                txtfocc.Text = dr.Item("focc").ToString
                txtfcontact.Text = dr.Item("fcontact").ToString
                txtfaddress.Text = dr.Item("faddress").ToString
                txtglname.Text = dr.Item("glname").ToString
                txtgfname.Text = dr.Item("gfname").ToString
                txtgmname.Text = dr.Item("gmname").ToString
                txtgcontact.Text = dr.Item("gcontact").ToString
                txtgaddress.Text = dr.Item("gaddress").ToString
                txtpsaddress.Text = dr.Item("psaddress").ToString
                txtpsattended.Text = dr.Item("psattended").ToString
                txtpsyeargraduated.Text = dr.Item("psygraduated").ToString
                txtgeneralave.Text = dr.Item("genave").ToString
            End If
            added()
            requirements()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Sub clear()
        For Each c As Control In TabControl1.TabPages
            For Each text As Control In c.Controls
                If TypeOf text Is TextBox Then
                    text.Text = ""
                End If
            Next
        Next
        For Each c As Control In GroupBox3.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        For Each c As Control In GroupBox2.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        cboaid.Text = ""
        cbosy.Items.Clear()
        cbosy.SelectedIndex = -1
        cbosy.Text = ""
        cbolrn.Text = ""
        cbogender.SelectedIndex = -1
        cboincomingyear.SelectedIndex = -1
        cbostatus.SelectedIndex = -1
        cbotype.SelectedIndex = -1
        dtpdob.ResetText()
        txtage.Text = ""
        txtsearch.Text = ""
        cbostatus.SelectedIndex = -1
        cbogender.SelectedIndex = -1
        cboincomingyear.SelectedIndex = -1
        chkbirth.Checked = False
        chkform.Checked = False
        chkpic.Checked = False
        chkreportcard.Checked = False
        lbladded.Hide()
        chkbirth.Enabled = True
        chkform.Enabled = True
        chkpic.Enabled = True
        chkreportcard.Enabled = True
    End Sub
    Public Sub added()
        opencon()
        Try
            cmd = New OleDbCommand("select * from Status_Enrollment where aid=@aid", con)
            With cmd
                .Parameters.AddWithValue("@aid", cboaid.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                lbladded.Visible = True
                chkreportcard.Enabled = False
                chkpic.Enabled = False
                chkform.Enabled = False
                chkbirth.Enabled = False
            Else
                lbladded.Visible = False
                chkreportcard.Enabled = True
                chkpic.Enabled = True
                chkform.Enabled = True
                chkbirth.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub requirements()
        opencon()
        Try
            Dim card As String = "Submitted"
            Dim birth As String = "Submitted"
            Dim form As String = "Submitted"
            Dim pic As String = "Submitted"
            cmd = New OleDbCommand("select * from Requirements where aid =@aid", con)
            With cmd
                .Parameters.AddWithValue("@aid", cboaid.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                If dr.Item("card") = card Then
                    chkreportcard.Checked = True
                    chkreportcard.Enabled = False
                Else
                    chkreportcard.Checked = False
                End If
                If dr.Item("enroll_form") = form Then
                    chkform.Checked = True
                    chkform.Enabled = False
                Else
                    chkform.Checked = False
                End If
                If dr.Item("birth") = birth Then
                    chkbirth.Checked = True
                    chkbirth.Enabled = False
                Else
                    chkbirth.Checked = False
                End If
                If dr.Item("pic") = pic Then
                    chkpic.Checked = True
                    chkpic.Enabled = False
                Else
                    chkpic.Checked = False
                End If
            Else
                chkreportcard.Checked = False
                chkreportcard.Enabled = True
                chkform.Checked = False
                chkform.Enabled = True
                chkbirth.Checked = False
                chkbirth.Enabled = True
                chkpic.Checked = False
                chkpic.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
End Class
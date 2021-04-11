Imports System.Data.OleDb
Imports System.Data.SqlTypes

Public Class frmAddStudent
    Public Sub clear()
        For Each c As Control In TabControl1.TabPages
            For Each text As Control In c.Controls
                If TypeOf text Is TextBox Then
                    text.Text = ""
                End If
            Next
        Next
        For Each c As Control In GroupBox1.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        For Each c As Control In GroupBox2.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        txtlrn.Text = ""
        cbogender.Text = ""
        cboincomingyear.Text = ""
        cbostatus.Text = ""
        cbotype.Text = ""
        dtpdob.ResetText()
        txtage.Text = ""
        autoid()
    End Sub




    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub lnkclose_Click(sender As Object, e As EventArgs) Handles lnkclose.Click
        Me.Dispose()
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboincomingyear.KeyPress, cbogender.KeyPress, cbostatus.KeyPress, cbotype.KeyPress, cbobeneficiary.KeyPress
        e.Handled = True
    End Sub
    Public Sub autoid()
        opencon()
        Try
            cmd = New OleDbCommand("select max (aid) from StudentInfo", con)
            str = cmd.ExecuteScalar.ToString

            If String.IsNullOrEmpty(str) Then
                str = "AID202110001"
                cboaid.Text = str
            Else
                str = str.Substring(3)
                Convert.ToInt32(str)
                Dim i As Integer
                i = str + 1
                str = "AID" + i.ToString
                cboaid.Text = str
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub
    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoid()
        getay()
    End Sub
    Public Sub getay()
        opencon()
        Try
            cmd = New OleDbCommand("select aycode from aycode where Status='Active'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                cbosy.Text = dr.Item("aycode")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub dtpdob_ValueChanged(sender As Object, e As EventArgs) Handles dtpdob.ValueChanged
        Dim age As Double = Math.Floor(DateDiff(DateInterval.Month, dtpdob.Value, System.DateTime.Now) / 12)
        txtage.Text = age
    End Sub

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress, txtfcontact.KeyPress, txtmcontact.KeyPress, txtgcontact.KeyPress, txtlrn.KeyPress, txtpsyeargraduated.KeyPress, txtgeneralave.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 46 Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lbladmission.Select()
        For Each c As Control In Panel2.Controls
            If TypeOf c Is ComboBox Then
                If c.Text = "" Then
                    MsgBox("Please complete all details", vbExclamation)
                    Return
                End If
            End If
        Next

        For Each c As Control In TabControl1.TabPages
            For Each control As Control In c.Controls
                If TypeOf control Is TextBox Then
                    If control.Text = "" Then
                        MsgBox("Please complete all details", vbExclamation)
                        Return
                    End If
                End If
                If control.HasChildren Then
                    For Each text As Control In control.Controls
                        If TypeOf text Is TextBox Then
                            If text.Text = "" Then
                                MsgBox("Please complete all details", vbExclamation)
                                Return
                            End If
                        End If
                    Next
                End If
            Next
        Next


        If txtlrn.Text = "" Or cbogender.Text = "" Or cbostatus.Text = "" Then
            MsgBox("Please complete all details", vbExclamation)
            Return
        End If
        opencon()
        Try
            cmd = New OleDbCommand("select lrn from StudentInfo where lrn=@lrn", con)
            With cmd
                .Parameters.AddWithValue("@lrn", txtlrn.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                MsgBox("LRN has duplicate value", vbExclamation)
                Exit Sub
            End If
            con.Close()
            dr.Close()
            If MsgBox("Do you want to save this student?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("insert into StudentInfo (aid,sy,incoming_year,student_type,lrn,lname,fname,mname,fullname,age,dob,pob,contact_no,gender,marital_status,beneficiary,ethnic_group,religion,address,mlname,mfname,mmname,mocc,mcontact,maddress,flname,ffname,fmname,focc,fcontact,faddress,glname,gfname,gmname,gcontact,gaddress,psattended,psygraduated,psaddress,genave) values (@aid,@sy,@incoming_year,@student_type,@lrn,@lname,@fname,@mname,@fullname,@age,@dob,pob,@contact_no,@gender,@marital_status,@beneficiary,@ethnic_group,@religion,@address,@mlname,@mfname,@mmname,mocc,@mcontact,@maddress,@flname,@ffname,fmname,@focc,@fcontact,@faddress,@glname,@gfname,@gmname,@gcontact,@gaddress,@psattended,@psygraduated,@psaddress,@genave)", con)
                With cmd
                    .Parameters.AddWithValue("@aid", cboaid.Text)
                    .Parameters.AddWithValue("@sy", cbosy.Text)
                    .Parameters.AddWithValue("@incoming_year", cboincomingyear.Text)
                    .Parameters.AddWithValue("@student_type", cbotype.Text)
                    .Parameters.AddWithValue("@lrn", txtlrn.Text)
                    .Parameters.AddWithValue("@lname", txtlname.Text)
                    .Parameters.AddWithValue("@fname", txtfname.Text)
                    .Parameters.AddWithValue("@mname", txtmname.Text)
                    .Parameters.AddWithValue("@fullname", txtfname.Text & " " & txtmname.Text.Substring(0, 1) & ". " & txtlname.Text)
                    .Parameters.AddWithValue("@age", txtage.Text)
                    .Parameters.AddWithValue("@dob", dtpdob.Value.Date.ToShortDateString)
                    .Parameters.AddWithValue("@pob", txtpob.Text)
                    .Parameters.AddWithValue("@contact_no", txtcontact.Text)
                    .Parameters.AddWithValue("@gender", cbogender.Text)
                    .Parameters.AddWithValue("@marital_status", cbostatus.Text)
                    .Parameters.AddWithValue("@beneficiary", cbobeneficiary.Text)
                    .Parameters.AddWithValue("@ethnic_group", txtethnicgroup.Text)
                    .Parameters.AddWithValue("@religion", txtreligion.Text)
                    .Parameters.AddWithValue("@address", txtaddress.Text)
                    .Parameters.AddWithValue("@mlname", txtmlname.Text)
                    .Parameters.AddWithValue("@mfname", txtmfname.Text)
                    .Parameters.AddWithValue("@mmname", txtmmname.Text)
                    .Parameters.AddWithValue("@mocc", txtmocc.Text)
                    .Parameters.AddWithValue("@mcontact", txtmcontact.Text)
                    .Parameters.AddWithValue("@maddress", txtmaddress.Text)
                    .Parameters.AddWithValue("@flname", txtflname.Text)
                    .Parameters.AddWithValue("@ffname", txtffname.Text)
                    .Parameters.AddWithValue("@fmname", txtfmname.Text)
                    .Parameters.AddWithValue("@focc", txtfocc.Text)
                    .Parameters.AddWithValue("@fcontact", txtfcontact.Text)
                    .Parameters.AddWithValue("@faddress", txtfaddress.Text)
                    .Parameters.AddWithValue("@glname", txtglname.Text)
                    .Parameters.AddWithValue("@gfname", txtgfname.Text)
                    .Parameters.AddWithValue("@gmname", txtgmname.Text)
                    .Parameters.AddWithValue("@gcontact", txtgcontact.Text)
                    .Parameters.AddWithValue("@gaddress", txtgaddress.Text)
                    .Parameters.AddWithValue("@psattended", txtpsattended.Text)
                    .Parameters.AddWithValue("@psygrduated", txtpsyeargraduated.Text)
                    .Parameters.AddWithValue("@psaddress", txtpsaddress.Text)
                    .Parameters.AddWithValue("@genave", txtgeneralave.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Student has been saved", vbInformation)
                frmAdmission.autosearch()
                clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click, lnkclose.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        lbladmission.Select()
        clear()
    End Sub


End Class
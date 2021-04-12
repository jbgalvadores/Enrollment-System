Imports System.Data.OleDb
Public Class frmadmin
    Sub maxstudent()
        opencon()
        Try
            cmd = New OleDbCommand("select maxstudent from max_student", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtmaxstudent.Text = dr.Item("maxstudent").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub frmadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maxstudent()
        Call loaday()
        Call loadaccounts()
    End Sub
    Public Sub loadaccounts()
        datagridview2.Rows.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from UserAccount", con)
            dr = cmd.ExecuteReader
            While dr.Read
                datagridview2.Rows.Add(dr.Item("ID").ToString, dr.Item("image"), dr.Item("fullname").ToString, dr.Item("username").ToString, dr.Item("designation").ToString)
            End While
            For i = 0 To datagridview2.Rows.Count - 1
                datagridview2.Rows(i).Height = 60
            Next
            datagridview2.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub
    Public Sub loaday()
        DataGridView1.Rows.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from aycode order by aycode asc", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID").ToString, dr.Item("aycode").ToString, dr.Item("Year1").ToString, dr.Item("Year2").ToString, dr.Item("Term").ToString, dr.Item("Status").ToString)
            End While
            For i = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(i).Height = 30
            Next
            DataGridView1.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        DataGridView1.ClearSelection()
        datagridview2.ClearSelection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnaddnewyear.Click
        lbladminoption.Select()
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
                frmTeacher.Owner = f
                frmAY.ShowDialog()
            End With
        Catch ex As Exception
        Finally
            f.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        lbladminoption.Select()
        Dim col As String = DataGridView1.Columns(e.ColumnIndex).Name
        opencon()
        Try
            If col = "coledit" Then
                With frmAY
                    .txtyear1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtyear2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                    .cboterm.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                    .btnupdate.Enabled = True
                    .btnsave.Enabled = False
                    .ShowDialog()
                End With
            ElseIf col = "coldelete" Then
                If DataGridView1.Rows(e.RowIndex).Cells(5).Value = "Active" Then
                    MsgBox("You cannot delete active year", vbExclamation)
                    Exit Sub
                End If
                con.Close()

                If MsgBox("Do you want to delete this academic year?", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New OleDbCommand("delete from aycode where ID=@id", con)
                    With cmd
                        .Parameters.AddWithValue("@id", DataGridView1.Rows(e.RowIndex).Cells(0).Value)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Academic year" & " " & DataGridView1.Rows(e.RowIndex).Cells(1).Value & " " & "has been deleted", vbInformation)
                    Call loaday()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsetactive.Click
        lbladminoption.Select()

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Please select academic year first", vbExclamation)
            Exit Sub
        ElseIf DataGridView1.CurrentRow.Cells(5).Value = "Active" Then
            MsgBox("This academic year is already set as active", vbExclamation)
            Exit Sub
        End If



        If MsgBox("Do you want to set this year as active?", vbQuestion + vbYesNo) = vbYes Then
            opencon()
            Try

                cmd = New OleDbCommand("update aycode set Status='Inactive'", con)
                cmd.ExecuteNonQuery()

                con.Close()
                con.Open()
                cmd = New OleDbCommand("update aycode set Status='Active' where ID=@id", con)
                With cmd
                    .Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                con.Close()

                MsgBox(DataGridView1.CurrentRow.Cells(1).Value & " " & "has been set as active", vbInformation)
                Call loaday()
                Call frmMain.loadaycode()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
            con.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnaddnewaccount.Click
        lbladminoption.Select()
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
                frmTeacher.Owner = f
                frmUserAccount.ShowDialog()
        End With
        Catch ex As Exception
        Finally
        f.Dispose()
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview2.CellContentClick
        lbladminoption.Select()
        Dim col As String = datagridview2.Columns(e.ColumnIndex).Name
        opencon()
        Try
            If col = "coledit2" Then

                cmd = New OleDbCommand("select * from UserAccount where ID =@id", con)
                With cmd
                    .Parameters.AddWithValue("@id", datagridview2.Rows(e.RowIndex).Cells(0).Value)
                    dr = .ExecuteReader
                End With
                dr.Read()
                If dr.HasRows Then
                    With frmUserAccount
                        .txtlname.Text = dr.Item("lname").ToString
                        .txtfname.Text = dr.Item("fname").ToString
                        .txtmname.Text = dr.Item("mname").ToString
                        .txtusername.Text = dr.Item("username").ToString
                        .txtpass.Text = dr.Item("password").ToString
                        .txtconfirmpass.Text = dr.Item("confirmpassword").ToString
                        .cbodesignation.Text = dr.Item("designation").ToString
                        Dim arrImage As Byte()
                        arrImage = dr.Item("image")
                        Dim ms As New System.IO.MemoryStream(arrImage)
                        .picUser.Image = System.Drawing.Image.FromStream(ms)
                        .btnsave.Enabled = False
                        .btnupdate.Enabled = True
                        .ShowDialog()
                    End With
                End If
            ElseIf col = "coldelete2" Then
                If datagridview2.CurrentRow.Cells(3).Value = "Administrator" Then
                    MsgBox("You cannot delete administrator account", vbExclamation)
                    Exit Sub
                End If

                If MsgBox("Do you want to delete this user?", vbQuestion + vbYesNo) = vbYes Then
                    con.Close()
                    con.Open()
                    cmd = New OleDbCommand("delete from UserAccount where ID=@id", con)
                    With cmd
                        .Parameters.AddWithValue("@id", datagridview2.Rows(e.RowIndex).Cells(0).Value)
                        .ExecuteNonQuery()
                        MsgBox("User has been deleted", vbInformation)
                        Call loadaccounts()
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub



    Private Sub btnupdatepassword_Click(sender As Object, e As EventArgs) Handles btnupdatepassword.Click
        lbladminoption.Select()
        Dim f As New Form
        Try
            With frmpassword
                .WindowState = FormWindowState.Maximized
                .StartPosition = FormStartPosition.Manual
                .BackColor = Color.Black
                .Opacity = 0.5
                .ShowInTaskbar = False
                .FormBorderStyle = FormBorderStyle.None
                .Show()
                .btnsave.Text = "UPDATE"
                .txtpassword.Select()
                .ShowDialog()
            End With
        Catch ex As Exception
        Finally
            f.Dispose()
        End Try
    End Sub


    Private Sub txtmaxstudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmaxstudent.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = False
        End If
    End Sub





    Private Sub btneditmax_Click(sender As Object, e As EventArgs) Handles btneditmax.Click
        lbladminoption.Select()
        btneditmax.Enabled = False
        btnsavemax.Enabled = True
        txtmaxstudent.Enabled = True
        txtmaxstudent.Select()
    End Sub

    Private Sub btnsavemax_Click(sender As Object, e As EventArgs) Handles btnsavemax.Click
        lbladminoption.Select()
        opencon()

        Try
            If txtmaxstudent.Text = String.Empty Then
                MsgBox("Please type in school name", vbExclamation)
                Return
            End If



            If MsgBox("Do you want to update the max student no. to " & txtmaxstudent.Text & "?", vbQuestion + vbYesNo) = vbYes Then

                cmd = New OleDbCommand("update max_student set maxstudent=@maxstudent", con)
                With cmd
                    .Parameters.AddWithValue("@maxstudent", txtmaxstudent.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Max student no. has been set to " & txtmaxstudent.Text, vbInformation)
                btneditmax.Enabled = True
                btnsavemax.Enabled = False
                txtmaxstudent.Enabled = False
                maxstudent()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub linkAdmClose_Click(sender As Object, e As EventArgs) Handles linkAdmClose.Click
        Me.Dispose()
    End Sub
End Class
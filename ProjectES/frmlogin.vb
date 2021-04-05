Imports System.Data.OleDb
Public Class frmlogin



    Private Sub frmlogin_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltitle.Select()
        txtusername.Text = "Enter Username"
        txtpassword.Text = "Enter Password"
        txtusername.ForeColor = Color.Black
        txtpassword.ForeColor = Color.Black
        txtpassword.UseSystemPasswordChar = False
    End Sub
    Private Sub txtusername_GotFocus(sender As Object, e As EventArgs) Handles txtusername.GotFocus
        If txtusername.Text = "Enter Username" Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtusername_LostFocus(sender As Object, e As EventArgs) Handles txtusername.LostFocus
        If txtusername.Text = "" Then
            txtusername.Text = "Enter Username"
            txtusername.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtpassword_GotFocus(sender As Object, e As EventArgs) Handles txtpassword.GotFocus

        If txtpassword.Text = "Enter Password" Then
            txtpassword.Text = "1"
            txtpassword.UseSystemPasswordChar = True
            txtpassword.Clear()
            txtpassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpassword_LostFocus(sender As Object, e As EventArgs) Handles txtpassword.LostFocus
        If txtpassword.Text = "" Then
            txtpassword.Text = "Enter Password"
            txtpassword.UseSystemPasswordChar = False
            txtpassword.ForeColor = Color.Silver
        End If
    End Sub





    Private Sub imgLoginButton_Click(sender As Object, e As EventArgs) Handles imgLoginButton.Click
        If txtusername.Text = "Enter Username" Or txtpassword.Text = "Enter Password" Then
            MsgBox("Enter username and password", vbExclamation)
            Exit Sub
        End If
        opencon()
        Try
            cmd = New OleDbCommand("select * from UserAccount where username=@username and password=@password", con)
            With cmd
                .Parameters.AddWithValue("@username", txtusername.Text)
                .Parameters.AddWithValue("@password", txtpassword.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                Dim username As String
                Dim fullname As String
                Dim designation As String
                cmd = New OleDbCommand("select * from UserAccount where username=@username", con)
                With cmd
                    .Parameters.AddWithValue("@username", txtusername.Text)
                    dr = .ExecuteReader
                End With
                dr.Read()
                If dr.HasRows Then
                    username = dr.Item("username").ToString
                    fullname = dr.Item("fullname").ToString
                    designation = dr.Item("designation").ToString
                Else
                    username = ""
                    fullname = ""
                    designation = ""
                End If
                dr.Close()
                con.Close()

                con.Open()
                cmd = New OleDbCommand("insert into Log (username,fullname,designation,[datetimelog]) values (@username,@fullname,@designation,@datelog)", con)
                With cmd

                    Dim dt As System.DateTime = System.DateTime.Now.ToString

                    .Parameters.AddWithValue("@username", username)
                    .Parameters.AddWithValue("@fullname", fullname)
                    .Parameters.AddWithValue("@designation", designation)
                    .Parameters.AddWithValue("@datelog", dt)
                    .ExecuteNonQuery()
                End With
                frmMain.Show()
                Me.Hide()
            Else
                MsgBox("Username or password is invalid", vbExclamation)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub imgCancelButton_Click(sender As Object, e As EventArgs) Handles imgCancelButton.Click
        Me.Dispose()
    End Sub
End Class
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Imaging
Public Class frmUserAccount
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbodesignation.KeyPress
        e.Handled = True
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        lbllname.Select()
        Dim ofd As New OpenFileDialog
        ofd.FileName = "Select Image"
        ofd.Filter = "Image Files (*.JPG;*.PNG) | *.JPG;*.PNG"
        ofd.Multiselect = False
        If ofd.ShowDialog = DialogResult.OK Then
            picUser.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lbllname.Select()

        If txtconfirmpass.Text = "" Or txtfname.Text = "" Or txtlname.Text = "" Or txtmname.Text = "" Or txtpass.Text = "" Or txtusername.Text = "" Or cbodesignation.Text = "" Then
            MsgBox("Fill in required field", vbExclamation)
            Exit Sub
        ElseIf txtpass.Text <> txtconfirmpass.Text Then
            MsgBox("Password do not match", vbExclamation)
            Exit Sub
        End If

        opencon()
        Try
            cmd = New OleDbCommand("select username from UserAccount", con)
            dr = cmd.ExecuteReader
            While dr.Read
                If dr.Item("username") = txtusername.Text Then
                    MsgBox("Username already taken", vbExclamation)
                    Exit Sub
                End If
            End While

            If MsgBox("Do you want to add this user?", vbQuestion + vbYesNo) = vbYes Then
                con.Close()
                con.Open()
                Dim ms As New System.IO.MemoryStream
                picUser.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                Dim arrImage As Byte() = ms.GetBuffer

                cmd = New OleDbCommand("insert into [UserAccount] ([lname],[fname],[mname],[fullname],[username],[password],[confirmpassword],[designation],[image]) values(@lname,@fname,@mname,@fullname,@user,@pass,@confirmpass,@designation,@image)", con)
                With cmd
                    .Parameters.AddWithValue("@lname", txtlname.Text)
                    .Parameters.AddWithValue("@fname", txtfname.Text)
                    .Parameters.AddWithValue("@mname", txtmname.Text)
                    .Parameters.AddWithValue("@fullname", txtfname.Text & " " & txtmname.Text.Substring(0, 1) & "." & " " & txtlname.Text)
                    .Parameters.AddWithValue("@user", txtusername.Text)
                    .Parameters.AddWithValue("@pass", txtpass.Text)
                    .Parameters.AddWithValue("@confirmpass", txtconfirmpass.Text)
                    .Parameters.AddWithValue("@designation", cbodesignation.Text)
                    .Parameters.AddWithValue("@image", arrImage)
                    .ExecuteNonQuery()
                End With
                MsgBox("New user has been added", vbInformation)
                Call clear()
                Call frmadmin.loadaccounts()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub
    Sub clear()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        cbodesignation.Text = ""
        picUser.Image = My.Resources.avatar
    End Sub
    Private Sub pichide_MouseHover(sender As Object, e As EventArgs) Handles pichide.MouseHover
        pichide.Hide()
        picshow.Show()
    End Sub
    Private Sub picshow_MouseHover(sender As Object, e As EventArgs) Handles picshow.MouseHover
        txtpass.UseSystemPasswordChar = False
    End Sub
    Private Sub picshow_MouseLeave(sender As Object, e As EventArgs) Handles picshow.MouseLeave
        pichide.Show()
        txtpass.UseSystemPasswordChar = True
    End Sub

    Private Sub frmUserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbladdnewuser.Select()
        If txtusername.Text = "" And txtpass.Text = "" And txtmname.Text = "" And txtlname.Text = "" And txtfname.Text = "" And txtconfirmpass.Text = "" Then
            picUser.Image = My.Resources.avatar
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        lbllname.Select()
        opencon()
        Try


            If txtpass.Text <> txtconfirmpass.Text Then
                MsgBox("Password do not match", vbExclamation)
                Exit Sub
            End If

            cmd = New OleDbCommand("select username from UserAccount where ID<>@id", con)
            With cmd
                .Parameters.AddWithValue("@id", frmadmin.datagridview2.CurrentRow.Cells(0).Value)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("username") = txtusername.Text Then
                    MsgBox("Username already taken", vbExclamation)
                    Exit Sub
                End If
            End While
            con.Close()
            Dim ms As New System.IO.MemoryStream
            picUser.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Dim arrImage As Byte() = ms.GetBuffer
            If MsgBox("Do you want to update user?", vbQuestion + vbYesNo) = vbYes Then

                con.Open()
                If OpenFileDialog1.FileName <> "Select Image" Then
                    cmd = New OleDbCommand("update UserAccount set lname=@lname,fname=@fname,mname=@mname,fullname=@fullname,username=@username,[password]=@password,
                [confirmpassword]=@confirm,designation=@designation,[image]=@image where ID=@id", con)
                Else
                    cmd = New OleDbCommand("update UserAccount set lname=@lname,fname=@fname,mname=@mname,fullname=@fullname,username=@username,[password]=@password,
                [confirmpassword]=@confirm,designation=@designation where ID=@id", con)
                End If
                With cmd
                    .Parameters.AddWithValue("@lname", txtlname.Text)
                    .Parameters.AddWithValue("@fname", txtfname.Text)
                    .Parameters.AddWithValue("@mname", txtmname.Text)
                    .Parameters.AddWithValue("@fullname", txtfname.Text & " " & txtmname.Text.Substring(0, 1) & "." & " " & txtlname.Text)
                    .Parameters.AddWithValue("@username", txtusername.Text)
                    .Parameters.AddWithValue("@password", txtpass.Text)
                    .Parameters.AddWithValue("@confirmpassword", txtconfirmpass.Text)
                    .Parameters.AddWithValue("@designation", cbodesignation.Text)
                    If OpenFileDialog1.FileName <> "Select Image" Then .Parameters.AddWithValue("@image", arrImage)
                    .Parameters.AddWithValue("@id", frmadmin.datagridview2.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MsgBox("User has been updated", vbInformation)
                Call reload()
                Call frmadmin.loadaccounts()
                Me.Dispose()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub reload()
        If frmadmin.datagridview2.CurrentRow.Cells(2).Value = frmMain.lblusername.Text Then
            MsgBox("Please sign in again to continue", vbInformation)
            Application.Restart()
        End If
    End Sub
End Class
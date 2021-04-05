Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Reflection
Imports System.Data.SqlTypes
Public Class frmTeacher


    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
            e.Handled = False
        End If

    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        lblteacher.Select()
        Dim ofd As New OpenFileDialog
        With ofd
            .Multiselect = False
            .FileName = "Select Image"
            .Filter = "Image Files (*.PNG;*.JPG) | *.PNG;*.JPG"
        End With
        If ofd.ShowDialog = DialogResult.OK Then
            picTeacher.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lblteacher.Select()
        If txtdegree.Text = "" Or txtfname.Text = "" Or txtid.Text = "" Or txtlname.Text = "" Or txtmname.Text = "" Or txtspecialization.Text = "" Then
            MsgBox("Please fill in all field", vbExclamation)
            Exit Sub
        End If
        opencon()
        Try
            cmd = New OleDbCommand("select teacher_id from Teacher where teacher_id=@id", con)
            With cmd
                .Parameters.AddWithValue("teacher_id", txtid.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                MsgBox("Teacher ID is already been added", vbExclamation)
                Exit Sub
            End If
            con.Close()
            dr.Close()

            Dim ms As New System.IO.MemoryStream
            picTeacher.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Dim arrImage As Byte() = ms.GetBuffer
            If MsgBox("Do you want to add this teacher?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("insert into Teacher (teacher_id,lname,fname,mname,fullname,degree,specialization,[image]) values (@teacher_id,@lname,@fname,@mname,@fullname,@degree,@specialization,@image)", con)
                With cmd
                    .Parameters.AddWithValue("@teacher_id", txtid.Text)
                    .Parameters.AddWithValue("@lname", txtlname.Text)
                    .Parameters.AddWithValue("@fname", txtfname.Text)
                    .Parameters.AddWithValue("@mname", txtmname.Text)
                    .Parameters.AddWithValue("@fullname", txtfname.Text & " " & txtmname.Text.Substring(0, 1) & "." & " " & txtlname.Text)
                    .Parameters.AddWithValue("@degree", txtdegree.Text)
                    .Parameters.AddWithValue("@specialization", txtspecialization.Text)
                    .Parameters.AddWithValue("@image", arrImage)
                    .ExecuteNonQuery()
                End With
                MsgBox("New teacher has been added", vbInformation)
                frmManagement.loadteacher()
                frmManagement.recordfoundteacher()
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Sub clear()
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        picTeacher.Image = My.Resources.user
    End Sub

    Private Sub frmTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtdegree.Text = "" And txtfname.Text = "" And txtid.Text = "" And txtlname.Text = "" And txtmname.Text = "" And txtspecialization.Text = "" Then
            picTeacher.Image = My.Resources.user
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        lblteacher.Select()
        If txtdegree.Text = "" Or txtfname.Text = "" Or txtid.Text = "" Or txtlname.Text = "" Or txtmname.Text = "" Or txtspecialization.Text = "" Then
            MsgBox("Please fill in all field", vbExclamation)
            Exit Sub
        End If
        opencon()
        Try


            Dim ms As New System.IO.MemoryStream
            picTeacher.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Dim arrImage As Byte() = ms.GetBuffer

            If MsgBox("Do you want to update this teacher?", vbQuestion + vbYesNo) = vbYes Then

                If OpenFileDialog1.FileName <> "Select Image" Then
                    cmd = New OleDbCommand("update Teacher set lname=@lname,fname=@fname,mname=@mname,fullname=@fullname,degree=@degree,specialization=@specialization,[image]=@image where teacher_id=@id", con)
                Else
                    cmd = New OleDbCommand("update Teacher set lname=@lname,fname=@fname,mname=@mname,fullname=@fullname,degree=@degree,specialization=@specialization where teacher_id=@id", con)
                End If
                With cmd

                    .Parameters.AddWithValue("@lname", txtlname.Text)
                    .Parameters.AddWithValue("@fname", txtfname.Text)
                    .Parameters.AddWithValue("@mname", txtmname.Text)
                    .Parameters.AddWithValue("@fullname", txtfname.Text & " " & txtmname.Text.Substring(0, 1) & "." & " " & txtlname.Text)
                    .Parameters.AddWithValue("@degree", txtdegree.Text)
                    .Parameters.AddWithValue("@specialization", txtspecialization.Text)
                    If OpenFileDialog1.FileName <> "Select Image" Then .Parameters.AddWithValue("@image", arrImage)
                    .Parameters.AddWithValue("@id", frmManagement.DataGridView5.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With

                con.Close()
                con.Open()

                cmd = New OleDbCommand("select * from Teacher where teacher_id=@id", con)
                With cmd
                    .Parameters.AddWithValue("@id", txtid.Text)
                    dr = .ExecuteReader
                End With
                dr.Read()
                Dim fullname As String = String.Empty
                If dr.HasRows Then
                    fullname = dr.Item("fullname").ToString
                End If
                con.Close()
                dr.Close()

                con.Open()
                cmd = New OleDbCommand("update [Section] set teacher_name=@fullname where teacher_id=@id", con)
                With cmd
                    .Parameters.AddWithValue("@fullname", fullname)
                    .Parameters.AddWithValue("@id", txtid.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Teacher has been updated", vbInformation)
                frmManagement.loadteacher()
                frmManagement.loadschedule()
                frmManagement.loadsection()
                frmManagement.room_adviser_id_adviser_name()
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class
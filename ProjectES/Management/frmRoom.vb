Imports System.Data.OleDb
Public Class frmRoom


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lbladdroom.Select()
        If txtroom.Text = "" Or cbostatus.Text = "" Then
            MsgBox("Please fill in Room field", vbExclamation)
            Exit Sub
        End If

        opencon()
        Try
            cmd = New OleDbCommand("select Room from Room", con)
            dr = cmd.ExecuteReader
            While dr.Read
                If dr.Item("Room") = txtroom.Text Then
                    MsgBox("This room is already been added", vbExclamation)
                    Exit Sub
                End If
            End While
            con.Close()



            If MsgBox("Do you want to add this room?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("insert into Room (Room,Description,Status) values (@room,@description,@status)", con)
                With cmd
                    .Parameters.AddWithValue("@room", txtroom.Text)
                    .Parameters.AddWithValue("@description", txtdescription.Text)
                    .Parameters.AddWithValue("@status", cbostatus.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("New room has been added", vbInformation)
                frmManagement.loadroom()
                frmManagement.recordfoundroom()
                txtroom.Clear()
                txtdescription.Clear()
                cbostatus.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        lbladdroom.Select()
        If txtroom.Text = "" Or cbostatus.Text = "" Then
            MsgBox("Please fill in Room field", vbExclamation)
            Exit Sub
        End If

        opencon()
        Try
            cmd = New OleDbCommand("select * from Room where ID=@id", con)
            With cmd
                .Parameters.AddWithValue("@id", frmManagement.DataGridView3.CurrentRow.Cells(0).Value)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("Room") = txtroom.Text And dr.Item("Description") = txtdescription.Text And dr.Item("Status") = cbostatus.Text Then
                    MsgBox("No record has been updated", vbInformation)
                    Exit Sub
                End If
            End While
            con.Close()
            dr.Close()




            If MsgBox("Do you want to update this room?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("update Room set Room=@room,Description=@description,Status=@status where ID=@id", con)
                With cmd
                    .Parameters.AddWithValue("room", txtroom.Text)
                    .Parameters.AddWithValue("description", txtdescription.Text)
                    .Parameters.AddWithValue("status", cbostatus.Text)
                    .Parameters.AddWithValue("id", frmManagement.DataGridView3.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MsgBox("Room has been updated", vbInformation)
                frmManagement.loadroom()
                Me.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub cbostatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbostatus.KeyPress
        e.Handled = True
    End Sub

End Class
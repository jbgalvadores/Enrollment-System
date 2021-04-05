Imports System.Data.OleDb
Public Class frmStrand
    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        lblstrand.Select()
        If txtdescription.Text = "" Or txtstrand.Text = "" Then
            MsgBox("Please fill in all field", vbExclamation)
            Exit Sub
        End If

        Try
            opencon()
            cmd = New OleDbCommand("select * from Strand where ID=@id", con)
            With cmd
                .Parameters.AddWithValue("@id", frmManagement.DataGridView1.CurrentRow.Cells(0).Value)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("Strand") = txtstrand.Text And dr.Item("Description") = txtdescription.Text Then
                    MsgBox("No record has been updated", vbInformation)
                    Exit Sub
                End If
            End While

            con.Close()
            con.Open()
            cmd = New OleDbCommand("select * from Strand where ID<>@id", con)
            With cmd
                .Parameters.AddWithValue("@id", frmManagement.DataGridView1.CurrentRow.Cells(0).Value)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("Strand") = txtstrand.Text Or dr.Item("Description") = txtdescription.Text Then
                    MsgBox("This strand is already been added", vbExclamation)
                    con.Close()
                    dr.Close()
                    Exit Sub
                End If
            End While
            con.Close()

            If MsgBox("Do you want to update this strand?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("update Strand set Strand=@strand,Description=@description where ID=@id", con)
                With cmd
                    .Parameters.AddWithValue("@strand", txtstrand.Text)
                    .Parameters.AddWithValue("@description", txtdescription.Text)
                    .Parameters.AddWithValue("@id", frmManagement.DataGridView1.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MsgBox("Strand has been updated", vbInformation)
                frmManagement.loadstrand()
                con.Close()
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lblstrand.Select()

        If txtdescription.Text = "" Or txtstrand.Text = "" Then
            MsgBox("Please fill in all field", vbExclamation)
            Exit Sub
        End If

        Try
            opencon()
            cmd = New OleDbCommand("select * from Strand", con)
            dr = cmd.ExecuteReader
            While dr.Read
                If dr.Item("Strand") = txtstrand.Text Or dr.Item("Description") = txtdescription.Text Then
                    MsgBox("This strand is already been added", vbExclamation)
                    con.Close()
                    dr.Close()
                    Exit Sub
                End If
            End While
            con.Close()

            If MsgBox("Do you want to add this strand?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("insert into Strand (Strand,Description) values (@strand,@description)", con)
                With cmd
                    .Parameters.AddWithValue("@strand", txtstrand.Text)
                    .Parameters.AddWithValue("@description", txtdescription.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("New strand has been added", vbInformation)
                con.Close()
                frmManagement.loadstrand()
                frmManagement.recordfoundstrand()
                txtdescription.Clear()
                txtstrand.Clear()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub
End Class
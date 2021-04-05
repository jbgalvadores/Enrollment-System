Imports System.Data.OleDb

Public Class frmMaintenance
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub textSchoolID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textSchoolID.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 57
            Case Else
                e.Handled = True
        End Select
    End Sub

    Sub LoadMaintenance()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM tblMaintenance", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                textSchoolID.Text = dr.Item("school_id").ToString
                textSchoolName.Text = dr.Item("school_name").ToString
                textSchoolAddress.Text = dr.Item("school_address").ToString
                textSchoolRegion.Text = dr.Item("region").ToString
                textSchoolDivision.Text = dr.Item("division").ToString
                textMaxStudent.Text = dr.Item("max_student").ToString
                textEmail.Text = dr.Item("email").ToString
                textPassword.Text = dr.Item("pass").ToString
                textMessage.Text = dr.Item("message").ToString
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Class
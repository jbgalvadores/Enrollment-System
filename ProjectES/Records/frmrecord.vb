Imports System.Data.OleDb
Public Class frmrecord

    Sub clear()
        If txtsearchlrnname.Text = "" Then
            txtfullname.Clear()
            txtaycode.Clear()
            txtgradelevel.Clear()
            cbostrand.Text = ""
            cbosection.Text = ""
        End If
    End Sub

    Public Sub loadgraderecord()
        GradesDataGridView.Rows.Clear()
        opencon()
        cmd = New OleDbCommand("select * from Grade", con)
        dr = cmd.ExecuteReader
        While dr.Read
            GradesDataGridView.Rows.Add(dr.Item("subject_code").ToString, dr.Item("subject_description").ToString, dr.Item("units").ToString, dr.Item("grade").ToString)
        End While
        For i = 0 To GradesDataGridView.Rows.Count - 1
            GradesDataGridView.Rows(i).Height = 30
        Next
        GradesDataGridView.ClearSelection()
        con.Close()
        dr.Close()
    End Sub

    Private Sub btnaddgrade_Click(sender As Object, e As EventArgs) Handles btnaddgrade.Click
        If cbosection.Text = "N/A" Then
            MessageBox.Show("Student must be enrolled.", "Enrollment System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

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
                    frmaddgrade.Owner = f
                    frmaddgrade.ShowDialog()
                End With
            Catch ex As Exception
            Finally
                f.Dispose()
            End Try
        End If
    End Sub



    Private Sub txtlrn_TextChanged(sender As Object, e As EventArgs) Handles txtsearchlrnname.TextChanged, txtlrn.TextChanged
        opencon()
        Try
            cmd = New OleDbCommand("select * from Status_Enrollment where lrn=@lrn or fullname=@fullname", con)
            With cmd
                .Parameters.AddWithValue("@lrn", txtsearchlrnname.Text)
                .Parameters.AddWithValue("@fullname", txtsearchlrnname.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                txtlrn.Text = dr.Item("lrn").ToString
                txtfullname.Text = dr.Item("fullname").ToString
                txtaycode.Text = dr.Item("aycode").ToString
                txtgradelevel.Text = dr.Item("grade_level").ToString
                cbostrand.Text = dr.Item("strand").ToString
                cbosection.Text = dr.Item("Section").ToString
            End If
        Catch ex As Exception

        End Try
        con.Close()
        dr.Close()
        clear()
    End Sub

    Private Sub linkAdmClose_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
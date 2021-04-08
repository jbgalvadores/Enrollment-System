Imports System.Data.OleDb
Public Class frmrecord

    Sub clear()
        If txtlrn.Text = "" Then
            txtfullname.Clear()
            txtaycode.Clear()
            txtgradelevel.Clear()
            cbostrand.Text = ""
            cbosection.Text = ""
        End If
    End Sub

    Private Sub btnaddgrade_Click(sender As Object, e As EventArgs) Handles btnaddgrade.Click
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
    End Sub

    Private Sub btnsearchs_Click(sender As Object, e As EventArgs) Handles btnsearchs.Click, linkAdmClose.Click
        opencon()
        Try
            cmd = New OleDbCommand("select * from Status_Enrollment where lrn=@lrn or fullname=@fullname", con)
            With cmd
                .Parameters.AddWithValue("@lrn", txtlrn.Text)
                .Parameters.AddWithValue("@fullname", txtlrn.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                txtfullname.Text = dr.Item("fullname").ToString
                txtaycode.Text = dr.Item("aycode").ToString
                txtgradelevel.Text = dr.Item("grade_level").ToString
                cbostrand.Text = dr.Item("strand").ToString
                cbosection.Text = dr.Item("Section").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
        clear()
    End Sub

    Private Sub txtlrn_TextChanged(sender As Object, e As EventArgs) Handles txtlrn.TextChanged
        opencon()
        Try
            cmd = New OleDbCommand("select * from Status_Enrollment where lrn=@lrn or fullname=@fullname", con)
            With cmd
                .Parameters.AddWithValue("@lrn", txtlrn.Text)
                .Parameters.AddWithValue("@fullname", txtlrn.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                txtfullname.Text = dr.Item("fullname").ToString
                txtaycode.Text = dr.Item("aycode").ToString
                txtgradelevel.Text = dr.Item("grade_level").ToString
                cbostrand.Text = dr.Item("strand").ToString
                cbosection.Text = dr.Item("Section").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
        clear()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

    End Sub
End Class
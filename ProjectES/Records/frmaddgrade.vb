Imports System.Data.OleDb

Public Class frmaddgrade

    Sub clear()
        If textsubcodedesc.Text = "" Then
            txtsubjectcode.Clear()
            txtsubdesc.Clear()
            textsubgrade.Clear()
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        opencon()
        Try
            cmd = New OleDbCommand("select * from Subject where subj_code=@subj_code or descriptive_title=@descriptive_title", con)
            With cmd
                .Parameters.AddWithValue("@subj_code", textsubcodedesc.Text)
                .Parameters.AddWithValue("@descriptive_title", textsubcodedesc.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                txtsubjectcode.Text = dr.Item("subj_code").ToString
                txtsubdesc.Text = dr.Item("descriptive_title").ToString
                txtgradelevel.Text = dr.Item("grade_level").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
        clear()
    End Sub

    Private Sub linkAdmClose_Click(sender As Object, e As EventArgs) Handles linkAdmClose.Click
        Me.Close()
    End Sub

    Private Sub textsubcodedesc_TextChanged(sender As Object, e As EventArgs) Handles textsubcodedesc.TextChanged
        opencon()
        Try
            cmd = New OleDbCommand("select * from Subject where subj_code=@subj_code or descriptive_title=@descriptive_title", con)
            With cmd
                .Parameters.AddWithValue("@subj_code", textsubcodedesc.Text)
                .Parameters.AddWithValue("@descriptive_title", textsubcodedesc.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                txtsubjectcode.Text = dr.Item("subj_code").ToString
                txtsubdesc.Text = dr.Item("descriptive_title").ToString
                txtgradelevel.Text = dr.Item("grade_level").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
        clear()
    End Sub
End Class
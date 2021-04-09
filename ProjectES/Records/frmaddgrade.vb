Imports System.Data.OleDb

Public Class frmaddgrade

    Sub clear()
        If textsubcodedesc.Text = "" Then
            txtsubjectcode.Clear()
            txtsubdesc.Clear()
            textsubgrade.Clear()
        End If
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
                txtunits.Text = dr.Item("no_of_units").ToString
                txtgradelevel.Text = dr.Item("grade_level").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
        clear()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        con.Open()
        Try
            cmd = New OleDbCommand("insert into Grade (lrn,ay_code,full_name,grade_level,strand,subject_code,subject_description,units,grade) values (@lrn,@ay_code,@full_name,@grade_level,@strand,@subject_code,@subject_description,@units,@grade)", con)
            With cmd
                .Parameters.AddWithValue("@lrn", frmrecord.txtlrn.Text)
                .Parameters.AddWithValue("@ay_code", frmrecord.txtaycode.Text)
                .Parameters.AddWithValue("@full_name", frmrecord.txtfullname.Text)
                .Parameters.AddWithValue("@grade_level", frmrecord.txtgradelevel.Text)
                .Parameters.AddWithValue("@strand", frmrecord.cbostrand.Text)
                '.Parameters.AddWithValue("@section", frmrecord.cbosection.Text)
                .Parameters.AddWithValue("@subject_code", txtsubjectcode.Text)
                .Parameters.AddWithValue("@subject_description", txtsubdesc.Text)
                .Parameters.AddWithValue("@units", txtunits.Text)
                .Parameters.AddWithValue("@grade", textsubgrade.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Grade added.", vbInformation)
            con.Close()
            frmrecord.loadgraderecord()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class
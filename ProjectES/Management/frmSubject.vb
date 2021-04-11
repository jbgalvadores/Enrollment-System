Imports System.Data.OleDb
Public Class frmSubject
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lbladdsubject.Select()

        If cbogradelevel.Text = "" Or cbostrand.Text = "" Or cbotype.Text = "" Or txtcode.Text = "" Or txttitle.Text = "" Or txtunits.Text = "" Then
            MsgBox("Please fill in all field", vbExclamation)
            Exit Sub
        End If

        opencon()
        Try
            cmd = New OleDbCommand("select subj_code,descriptive_title from Subject where grade_level=@grade and Strand=@strand", con)
            With cmd
                .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                .Parameters.AddWithValue("@strand", cbostrand.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("subj_code") = txtcode.Text Or dr.Item("descriptive_title") = txttitle.Text Then
                    MsgBox("This subject is already been added", vbExclamation)
                    Exit Sub
                End If
            End While
            con.Close()
            dr.Close()

            If MsgBox("Do you want to add this subject?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("insert into Subject (sy,grade_level,strand,subj_code,descriptive_title,no_of_units,type) values (@sy,@grade_level,@strand,@subj_code,@descriptive_title,@no_of_units,@type)", con)
                With cmd
                    .Parameters.AddWithValue("@sy", cbosy.Text)
                    .Parameters.AddWithValue("@grade_level", cbogradelevel.Text)
                    .Parameters.AddWithValue("@strand", cbostrand.Text)
                    .Parameters.AddWithValue("@subj_code", txtcode.Text)
                    .Parameters.AddWithValue("@descriptive_title", txttitle.Text)
                    .Parameters.AddWithValue("@no_of_units", txtunits.Text)
                    .Parameters.AddWithValue("@type", cbotype.Text)
                    .ExecuteNonQuery()
                    MsgBox("New subject has been added", vbInformation)
                    frmManagement.loadsubject()
                    frmManagement.recordfoundsubject()
                    clear()
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Sub clear()
        cbogradelevel.Text = ""
        cbostrand.Text = ""
        cbotype.Text = ""
        txtcode.Clear()
        txttitle.Clear()
        txtunits.Clear()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub


End Class
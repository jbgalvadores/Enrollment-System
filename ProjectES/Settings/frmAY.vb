Imports System.Data.OleDb
Public Class frmAY
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        lblyear1.Select()
        Me.Dispose()
    End Sub

    Private Sub txtyear1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtyear1.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If txtyear1.TextLength = 4 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtyear2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtyear2.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If txtyear2.TextLength = 4 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lblyear1.Select()
        If txtyear1.Text = "" Or txtyear2.Text = "" Or cboterm.Text = "" Then
            MsgBox("Fill in required field", vbExclamation)
            Exit Sub
        End If
        opencon()
        Try
            cmd = New OleDbCommand("select * from aycode where Year1=@year1 and Year2=@year2 and Term=@term", con)
            With cmd
                .Parameters.AddWithValue("@year1", txtyear1.Text)
                .Parameters.AddWithValue("@year2", txtyear2.Text)
                .Parameters.AddWithValue("@term", cboterm.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                MsgBox("This academic year has already been added", vbExclamation)
                Exit Sub
            End If
            If MsgBox("Do you want to add this academic year?", vbQuestion + vbYesNo) = vbYes Then
                con.Close()
                con.Open()
                cmd = New OleDbCommand("insert into aycode (aycode,Year1,Year2,Term) values (@aycode,@year1,@year2,@term)", con)
                With cmd
                    .Parameters.AddWithValue("@aycode", txtyear1.Text & "-" & txtyear2.Text & " " & cboterm.Text)
                    .Parameters.AddWithValue("@year1", txtyear1.Text)
                    .Parameters.AddWithValue("@year2", txtyear2.Text)
                    .Parameters.AddWithValue("@term", cboterm.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("New academic year has been added", vbInformation)
                Call frmadmin.loaday()
                Call clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        lblyear1.Select()
        If txtyear1.Text = "" Or txtyear2.Text = "" Or cboterm.Text = "" Then
            MsgBox("Fill in required field", vbExclamation)
            Exit Sub
        End If

        opencon()
        Try
            cmd = New OleDbCommand("select * from aycode where ID<>@id", con)
            With cmd
                .Parameters.AddWithValue("@id", frmadmin.DataGridView1.CurrentRow.Cells(0).Value)
                dr = .ExecuteReader
            End With

            While dr.Read
                If dr.Item("year1") = txtyear1.Text And dr.Item("year2") = txtyear2.Text And dr.Item("Term") = cboterm.Text Then
                    MsgBox("This academic year has already been added", vbExclamation)
                    Exit Sub
                End If
            End While
            con.Close()


            If MsgBox("Do you want to update this academic year?", vbQuestion + vbYesNo) = vbYes Then


                con.Open()

                cmd = New OleDbCommand("update aycode set aycode=@aycode,Year1=@year1,Year2=@year2,Term=@term where ID=@id", con)
                With cmd
                    .Parameters.AddWithValue("@aycode", txtyear1.Text & "-" & txtyear2.Text & " " & cboterm.Text)
                    .Parameters.AddWithValue("@year1", txtyear1.Text)
                    .Parameters.AddWithValue("@year2", txtyear2.Text)
                    .Parameters.AddWithValue("@term", cboterm.Text)
                    .Parameters.AddWithValue("@id", frmadmin.DataGridView1.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MsgBox("Academic year has been succesfully updated", vbInformation)
                Call frmadmin.loaday()
                frmMain.loadaycode()
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Sub clear()
        cboterm.Text = ""
        txtyear1.Clear()
        txtyear2.Clear()
    End Sub

    Private Sub txtyear1_TextChanged(sender As Object, e As EventArgs) Handles txtyear1.TextChanged
        If txtyear1.Text = String.Empty Then
            clear()
        Else
            txtyear2.Text = Val(txtyear1.Text) + 1
        End If
    End Sub

    Private Sub cboterm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboterm.KeyPress
        e.Handled = True
    End Sub
End Class
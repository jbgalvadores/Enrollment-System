Imports System.Data.OleDb
Public Class frmpassword

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lblpassword.Select()
        opencon()

        Try
            If btnsave.Text = "OK" Then
                If txtpassword.Text = String.Empty Then
                    MsgBox("Please type in password", vbExclamation)
                    Return
                End If

                cmd = New OleDbCommand("select [password] from pass_word where [password] like '" & txtpassword.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    For i = My.Application.OpenForms.Count - 1 To 0 Step -1
                        If My.Application.OpenForms(i).Name <> "frmAdmin" And My.Application.OpenForms(i).Name <> "frmMain" Then
                            My.Application.OpenForms(i).Dispose()
                        End If
                    Next
                    With frmadmin
                        .TopLevel = False
                        frmMain.mainpanel.Controls.Add(frmadmin)
                        .BringToFront()
                        .Show()
                    End With
                    dr.Close()
                    con.Close()
                    Me.Dispose()
                Else
                    MsgBox("Password is incorrect", vbExclamation)
                    txtpassword.Focus()
                End If
            ElseIf btnsave.Text = "UPDATE" Then
                If txtpassword.Text = String.Empty Then
                    MsgBox("Please type in  password", vbExclamation)
                    Return
                End If
                cmd = New OleDbCommand("select [password] from pass_word where [password] like '" & txtpassword.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("New password cannot be the same as the current password", vbExclamation)
                    dr.Close()
                    con.Close()
                    Return
                Else
                    If MsgBox("Do you want to change password?", vbQuestion + vbYesNo) = vbYes Then
                        cmd = New OleDbCommand("update pass_word set [password]=@password", con)
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Password has been successfully changed!", vbInformation)
                        dr.Close()
                        con.Close()
                        Me.Dispose()
                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub lnkclose_Click(sender As Object, e As EventArgs) Handles lnkclose.Click
        Me.Dispose()
    End Sub
End Class
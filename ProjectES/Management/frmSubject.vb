Imports System.Data.OleDb
Public Class frmSubject
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub ComboBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbostrand.KeyPress, cbogradelevel.KeyPress, cbosy.KeyPress
        e.Handled = True
    End Sub

    Private Sub frmSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getstrand()
        getay()
    End Sub
    Public Sub getay()
        opencon()
        Try
            cmd = New OleDbCommand("select * from aycode where Status='Active'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbosy.Items.Add(dr.Item("aycode").ToString)
                cbosy.Text = dr.Item("aycode").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub getstrand()
        cbostrand.Items.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from Strand", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbostrand.Items.Add(dr.Item("Strand").ToString)
            End While
            cbostrand.Items.Add("N/A")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub txtunits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtunits.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cbotype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbotype.KeyPress
        e.Handled = True
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        x = Windows.Forms.Cursor.Position.X - Left
        y = Windows.Forms.Cursor.Position.Y - Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag = True Then
            Left = Windows.Forms.Cursor.Position.X - x
            Top = Windows.Forms.Cursor.Position.Y - y
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsave.Click
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

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        lbladdsubject.Select()
        If cbogradelevel.Text = "" Or cbostrand.Text = "" Or cbotype.Text = "" Or txtcode.Text = "" Or txttitle.Text = "" Or txtunits.Text = "" Then
            MsgBox("Please fill in all field", vbExclamation)
            Exit Sub
        End If
        opencon()

        Try

            cmd = New OleDbCommand("select subj_code,descriptive_title from Subject where ID<>@id", con)
            With cmd
                .Parameters.AddWithValue("@id", frmManagement.DataGridView4.CurrentRow.Cells(0).Value)
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

            If MsgBox("Do you want to update this subject?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("update Subject set sy=@sy,grade_level=@grade_level,strand=@strand,subj_code=@subj_code,descriptive_title=@descriptive_title,no_of_units=@no_of_units,type=@type where ID=@id", con)
                With cmd
                    .Parameters.AddWithValue("@sy", cbosy.Text)
                    .Parameters.AddWithValue("@grade_level", cbogradelevel.Text)
                    .Parameters.AddWithValue("@strand", cbostrand.Text)
                    .Parameters.AddWithValue("@subj_code", txtcode.Text)
                    .Parameters.AddWithValue("@descriptive_title", txttitle.Text)
                    .Parameters.AddWithValue("@no_of_units", txtunits.Text)
                    .Parameters.AddWithValue("@type", cbotype.Text)
                    .Parameters.AddWithValue("@id", frmManagement.DataGridView4.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MsgBox("Subject has been updated", vbInformation)
                frmManagement.loadsubject()
                frmManagement.loadschedule()
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
End Class
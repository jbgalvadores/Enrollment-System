Imports System.Data.OleDb
Public Class frmAddSection

    Public Sub getteacher()
        cboteacher.Items.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select fullname from Teacher", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cboteacher.Items.Add(dr.Item("fullname").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub getroom()
        cboroom.Items.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select Room from Room where Status='UNUSED'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cboroom.Items.Add(dr.Item("Room").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Private Sub frmAddSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getroom()
        getteacher()
        lbladdsection.Select()
        getstrand()
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
            con.Close()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub
    Public Sub updateroom()
        opencon()
        Try
            cmd = New OleDbCommand("update Room set Status='USED' where Room=@Room", con)
            With cmd
                .Parameters.AddWithValue("@Room", cboroom.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lbladdsection.Select()
        If txtsection.Text = "" Or cbogradelevel.Text = "" Or cbostrand.Text = "" Or cboteacher.Text = "" Or cboroom.Text = "" Then
            MsgBox("Please fill in all field", vbExclamation)
            Exit Sub
        End If

        opencon()
        cmd = New OleDbCommand("select * from [Section]", con)
        dr = cmd.ExecuteReader
        While dr.Read
            If dr.Item("Section") = txtsection.Text Then
                MsgBox("This section has already been added", vbExclamation)
                Return
            End If
        End While

        con.Close()
        dr.Close()

        con.Open()
        cmd = New OleDbCommand("select * from [Section] where teacher_id =@id", con)
        With cmd
            .Parameters.AddWithValue("teacher_id", txtteacherid.Text)
            dr = .ExecuteReader
        End With
        dr.Read()
        If dr.HasRows Then
            MsgBox("This teacher has already a section", vbExclamation)
            Return
        End If
        dr.Close()
        con.Close()

        con.Open()
        cmd = New OleDbCommand("select * from teacher where teacher_id=@teacher_id", con)
        Dim teacher_id As String = String.Empty
        Dim teacher_name As String = String.Empty
        With cmd
            .Parameters.AddWithValue("@teacher_id", txtteacherid.Text)
            dr = .ExecuteReader
        End With
        dr.Read()
        If dr.HasRows Then
            teacher_id = dr.Item("teacher_id").ToString
            teacher_name = dr.Item("fullname").ToString
        End If
        dr.Close()
        con.Close()


        If MsgBox("Do you want to save this section?", vbQuestion + vbYesNo) = vbYes Then
            con.Open()
            Try
                cmd = New OleDbCommand("insert into [Section] (Grade_Level,Strand,[Section],Room,teacher_id,teacher_name) values (@grade,@strand,@section,@Room,@teacher_id,@teacher_name)", con)
                With cmd
                    .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                    .Parameters.AddWithValue("@strand", cbostrand.Text)
                    .Parameters.AddWithValue("@section", txtsection.Text)
                    .Parameters.AddWithValue("@Room", cboroom.Text)
                    .Parameters.AddWithValue("@teacher_id", teacher_id)
                    .Parameters.AddWithValue("@teacher_name", teacher_name)
                    .ExecuteNonQuery()
                End With
                MsgBox("New section has been added", vbInformation)
                updateroom()
                getroom()
                frmManagement.loadroom()
                frmManagement.loadsection()
                frmMain.loadtotalsection()
                frmManagement.recordfoundsection()
                txtsection.Clear()
                cbogradelevel.Text = ""
                cbostrand.Text = ""
                txtteacherid.Text = ""
                cboteacher.Text = ""
                cboroom.Text = ""
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        lbladdsection.Select()
        If txtsection.Text = "" Or cbostrand.Text = "" Or cbogradelevel.Text = "" Or cboteacher.Text = "" Then
            MsgBox("Please fill in all field", vbExclamation)
            Exit Sub
        End If

        opencon()
        Try


            cmd = New OleDbCommand("select * from [Section] where ID<>@id", con)
            With cmd
                .Parameters.AddWithValue("@id", frmManagement.datagridview2.CurrentRow.Cells(0).Value)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("Section") = txtsection.Text Then
                    MsgBox("This section has already been added", vbExclamation)
                    Return
                End If
            End While
            dr.Close()
            con.Close()

            con.Open()
            cmd = New OleDbCommand("select teacher_id from [Section] where ID<>@id", con)
            With cmd
                .Parameters.AddWithValue("id", frmManagement.datagridview2.CurrentRow.Cells(0).Value)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("teacher_id") = txtteacherid.Text Then
                    MsgBox("This teacher has already a section", vbExclamation)
                    Return
                End If
            End While
            dr.Close()
            con.Close()



            If MsgBox("Do you want to update this grade and section?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("update Room set Status='UNUSED' where Room=@room", con)
                With cmd
                    .Parameters.AddWithValue("@room", frmManagement.datagridview2.CurrentRow.Cells(4).Value)
                    .ExecuteNonQuery()
                End With
                con.Close()
                con.Open()
                cmd = New OleDbCommand("update [Section] set Grade_Level=@grade,Strand=@strand,[Section]=@section,Room=@Room,teacher_id=@teacher_id,teacher_name=@teacher_name where ID=@id", con)
                With cmd
                    .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                    .Parameters.AddWithValue("@strand", cbostrand.Text)
                    .Parameters.AddWithValue("@section", txtsection.Text)
                    .Parameters.AddWithValue("@Room", cboroom.Text)
                    .Parameters.AddWithValue("@teacher_id", txtteacherid.Text)
                    .Parameters.AddWithValue("@teacher_name", cboteacher.Text)
                    .Parameters.AddWithValue("@id", frmManagement.datagridview2.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                con.Close()

                con.Open()
                cmd = New OleDbCommand("update Room set Status='USED' where Room=@room", con)
                With cmd
                    .Parameters.AddWithValue("@room", cboroom.Text)
                    .ExecuteNonQuery()
                End With


                MsgBox("Grade and section has been updated", vbInformation)
                'frmManagement.loadsection()
                'frmManagement.room_adviser_id_adviser_name()
                'frmManagement.loadroom()
                'frmManagement.loadschedule()
                con.Close()
                Me.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub cboteacher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboteacher.SelectedIndexChanged
        lbladdsection.Select()
        opencon()
        Try
            cmd = New OleDbCommand("select teacher_id from Teacher where fullname=@fullname", con)
            With cmd
                .Parameters.AddWithValue("@fullname", cboteacher.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                txtteacherid.Text = dr.Item("teacher_id").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub cbogradelevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbogradelevel.SelectedIndexChanged
        If cbogradelevel.Text = "GRADE 11" Or cbogradelevel.Text = "GRADE 12" Then
            cbostrand.Enabled = True
            cbostrand.SelectedIndex = -1
        Else
            cbostrand.Text = "N/A"
            cbostrand.Enabled = False
        End If
    End Sub



End Class
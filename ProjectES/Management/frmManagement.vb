Imports System.ComponentModel
Imports System.Data.OleDb
Public Class frmManagement
    Public Sub recordfoundteacher()
        opencon()
        Try
            cmd = New OleDbCommand("select count (*) from Teacher", con)
            result = cmd.ExecuteScalar
            lblrecordfoundteacher.Text = "(" & result & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub
    Public Sub recordfoundsubject()
        opencon()
        Try
            cmd = New OleDbCommand("select count(*) from Subject", con)
            result = cmd.ExecuteScalar
            lblrecordfoundsubject.Text = "(" & result & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub
    Public Sub recordfoundsection()
        opencon()
        Try
            cmd = New OleDbCommand("select count(*) from [Section]", con)
            result = cmd.ExecuteScalar
            Label2.Text = "(" & result & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub
    Public Sub recordfoundstrand()
        opencon()
        Try
            cmd = New OleDbCommand("select count(*) from Strand", con)
            result = cmd.ExecuteScalar
            lblstrandfound.Text = "(" & result & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Public Sub recordfoundroom()
        opencon()
        Try
            cmd = New OleDbCommand("select count(*) from Room", con)
            result = cmd.ExecuteScalar
            lblroomfound.Text = "(" & result & ")"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub


    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddsection.Click
        lblmanagement.Select()
        frmAddSection.ShowDialog()
    End Sub
    Public Sub loadsection()
        datagridview2.Rows.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from [Section] order by strand asc", con)
            dr = cmd.ExecuteReader
            While dr.Read
                datagridview2.Rows.Add(dr.Item("ID").ToString, dr.Item("Grade_Level").ToString, dr.Item("Strand").ToString, dr.Item("Section").ToString, dr.Item("Room").ToString, dr.Item("teacher_id").ToString, dr.Item("teacher_name").ToString)
            End While
            For i = 0 To datagridview2.Rows.Count - 1
                datagridview2.Rows(i).Height = 30
            Next
            datagridview2.ClearSelection()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
            dr.Close()
        End Try
    End Sub
    Public Sub loadstrand()
        DataGridView1.Rows.Clear()
        opencon()
        cmd = New OleDbCommand("select * from Strand", con)
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("ID").ToString, dr.Item("Strand").ToString, dr.Item("Description").ToString)
        End While
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Height = 30
        Next
        DataGridView1.ClearSelection()
        con.Close()
        dr.Close()
    End Sub
    Public Sub loadroom()
        DataGridView3.Rows.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from Room order by Room asc", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView3.Rows.Add(dr.Item("ID").ToString, dr.Item("Room").ToString, dr.Item("Description").ToString, dr.Item("Status").ToString)
            End While
            For i = 0 To DataGridView3.Rows.Count - 1
                DataGridView3.Rows(i).Height = 30
            Next
            DataGridView3.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub loadsubject()
        DataGridView4.Rows.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from Subject", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView4.Rows.Add(dr.Item("ID").ToString, dr.Item("sy").ToString, dr.Item("grade_level").ToString, dr.Item("Strand").ToString, dr.Item("subj_code").ToString, dr.Item("descriptive_title").ToString, dr.Item("no_of_units").ToString, dr.Item("type").ToString)
            End While
            cbofiltergrade.Text = ""
            cbofilterstrand.Items.Clear()
            cbofilterstrand.Text = ""
            For i = 0 To DataGridView4.Rows.Count - 1
                DataGridView4.Rows(i).Height = 30
            Next
            recordfoundsubject()
            DataGridView4.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub filtersubject()
        cbofilterstrand.Items.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select Strand from Strand", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbofilterstrand.Items.Add(dr.Item("Strand").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub loadteacher()
        DataGridView5.Rows.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from Teacher", con)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView5.Rows.Add(dr.Item("teacher_id").ToString, dr.Item("fullname").ToString, dr.Item("degree").ToString, dr.Item("specialization").ToString)
            End While
            For i = 0 To DataGridView5.Rows.Count - 1
                DataGridView5.Rows(i).Height = 30
            Next
            DataGridView5.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub
    Public Sub getay()
        opencon()
        cboaycode.Items.Clear()

        Try
            cmd = New OleDbCommand("select * from aycode order by aycode asc", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cboaycode.Items.Add(dr.Item("aycode").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub btnaddstrand_Click(sender As Object, e As EventArgs) Handles btnaddstrand.Click
        lblmanagement.Select()
        frmStrand.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "coleditstrand" Then
            With frmStrand
                .txtstrand.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtdescription.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .txtstrand.Enabled = False
                .btnsave.Enabled = False
                .btnupdate.Enabled = True
                .ShowDialog()
            End With
        ElseIf colname = "coldeletestrand" Then
            If MsgBox("Do you want to delete this strand?", vbQuestion + vbYesNo) = vbYes Then
                opencon()
                Try
                    cmd = New OleDbCommand("delete from Strand where ID=@id", con)
                    With cmd
                        .Parameters.AddWithValue("@id", DataGridView1.Rows(e.RowIndex).Cells(0).Value)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    con.Open()

                    cmd = New OleDbCommand("select Room from [Section] where Strand=@strand", con)
                    With cmd
                        .Parameters.AddWithValue("@strand", DataGridView1.Rows(e.RowIndex).Cells(1).Value)
                        dr = .ExecuteReader
                    End With
                    dr.Read()
                    Dim room As String = String.Empty
                    If dr.HasRows Then
                        room = dr.Item("Room").ToString
                    End If
                    con.Close()
                    dr.Close()


                    con.Open()
                    cmd = New OleDbCommand("Update Room set Status='UNUSED' where Room=@room", con)
                    With cmd
                        .Parameters.AddWithValue("@room", room)
                        .ExecuteNonQuery()
                    End With
                    con.Close()

                    con.Open()
                    cmd = New OleDbCommand("delete from [Section] where Strand=@strand", con)
                    With cmd
                        .Parameters.AddWithValue("@strand", DataGridView1.Rows(e.RowIndex).Cells(1).Value)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    con.Open()
                    cmd = New OleDbCommand("delete from Subject where strand=@strand", con)
                    With cmd
                        .Parameters.AddWithValue("@strand", DataGridView1.Rows(e.RowIndex).Cells(1).Value)
                        .ExecuteNonQuery()
                    End With
                    con.Close()

                    MsgBox("Strand has been deleted", vbInformation)
                    loadsubject()
                    loadstrand()
                    recordfoundstrand()
                    loadsection()
                    loadroom()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                    con.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        lblmanagement.Select()
        DataGridView1.ClearSelection()
        datagridview2.ClearSelection()
        DataGridView3.ClearSelection()
        DataGridView4.ClearSelection()
        DataGridView5.ClearSelection()
        DataGridView6.ClearSelection()
    End Sub

    Private Sub datagridview2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview2.CellContentClick
        lblmanagement.Select()
        Dim colname As String = datagridview2.Columns(e.ColumnIndex).Name
        If colname = "coleditsection" Then
            With frmAddSection
                .cbogradelevel.Text = datagridview2.Rows(e.RowIndex).Cells(1).Value.ToString
                .cbostrand.Text = datagridview2.Rows(e.RowIndex).Cells(2).Value.ToString
                .txtsection.Text = datagridview2.Rows(e.RowIndex).Cells(3).Value.ToString
                .cboroom.Text = datagridview2.Rows(e.RowIndex).Cells(4).Value.ToString
                .txtteacherid.Text = datagridview2.Rows(e.RowIndex).Cells(5).Value.ToString
                .cboteacher.Text = datagridview2.Rows(e.RowIndex).Cells(6).Value.ToString
                .cbostrand.Enabled = False
                .cbogradelevel.Enabled = False
                .btnsave.Enabled = False
                .btnupdate.Enabled = True
                .ShowDialog()
            End With
        ElseIf colname = "coldeletesection" Then
            opencon()
            Try
                If MsgBox("Do you want to delete this section?", vbQuestion + vbYesNo) = vbYes Then
                    cmd = New OleDbCommand("update Room set Status='UNUSED' where Room=@room", con)
                    With cmd
                        .Parameters.AddWithValue("@room", datagridview2.Rows(e.RowIndex).Cells(4).Value)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    con.Open()
                    cmd = New OleDbCommand("delete from [Section] where ID=@id", con)
                    With cmd
                        .Parameters.AddWithValue("@id", datagridview2.CurrentRow.Cells(0).Value)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Section has been deleted", vbInformation)
                    loadroom()
                    loadsection()
                    recordfoundsection()
                    frmMain.loadtotalsection()
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btnaddroom_Click(sender As Object, e As EventArgs) Handles btnaddroom.Click
        lblmanagement.Select()
        frmRoom.ShowDialog()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim colname As String = DataGridView3.Columns(e.ColumnIndex).Name

        Try
            If colname = "coleditroom" Then
                With frmRoom
                    .txtroom.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtdescription.Text = DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString
                    .cbostatus.Text = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtroom.Enabled = False
                    .btnsave.Enabled = False
                    .btnupdate.Enabled = True
                    .ShowDialog()
                End With
            ElseIf colname = "coldeleteroom" Then
                If MsgBox("Do you want to delete this room?", vbQuestion + vbYesNo) = vbYes Then
                    opencon()
                    cmd = New OleDbCommand("delete from Room where ID=@id", con)
                    With cmd
                        .Parameters.AddWithValue("@id", DataGridView3.Rows(e.RowIndex).Cells(0).Value)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Room has been deleted", vbInformation)
                    loadroom()
                    recordfoundroom()
                    loadsection()
                    recordfoundsection()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblmanagement.Select()
        frmSubject.ShowDialog()
    End Sub

    Private Sub cbofiltergrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofiltergrade.SelectedIndexChanged
        cbofilterstrand.Items.Clear()
        cbofilterstrand.Text = ""
        DataGridView4.Rows.Clear()
        opencon()
        Try
            If cbofiltergrade.Text = "GRADE 11" Or cbofiltergrade.Text = "GRADE 12" Then
                cmd = New OleDbCommand("select Strand from Strand", con)
                dr = cmd.ExecuteReader
                While dr.Read
                    cbofilterstrand.Items.Add(dr.Item("Strand").ToString)
                End While
            End If

            con.Close()
            con.Open()
            cmd = New OleDbCommand("select * from Subject where grade_level=@grade", con)
            With cmd
                .Parameters.AddWithValue("@grade", cbofiltergrade.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                DataGridView4.Rows.Add(dr.Item("ID").ToString, dr.Item("sy").ToString, dr.Item("grade_level").ToString, dr.Item("strand").ToString, dr.Item("subj_code").ToString, dr.Item("descriptive_title").ToString, dr.Item("no_of_units").ToString, dr.Item("type").ToString)
                For i = 0 To DataGridView4.Rows.Count - 1
                    DataGridView4.Rows(i).Height = 30
                Next
            End While
            lblrecordfoundsubject.Text = "(" & DataGridView4.Rows.Count & ")"
            DataGridView4.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub cbofiltergrade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbofilterstrand.KeyPress, cbofiltergrade.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblmanagement.Select()
        cbofiltergrade.Text = ""
        cbofilterstrand.Items.Clear()
        cbofilterstrand.Text = ""
        loadsubject()
    End Sub

    Private Sub cbofilterstrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofilterstrand.SelectedIndexChanged
        DataGridView4.Rows.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from Subject where grade_level=@grade and strand=@strand", con)
            With cmd
                .Parameters.AddWithValue("@grade", cbofiltergrade.Text)
                .Parameters.AddWithValue("@strand", cbofilterstrand.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                DataGridView4.Rows.Add(dr.Item("ID").ToString, dr.Item("sy").ToString, dr.Item("grade_level").ToString, dr.Item("strand").ToString, dr.Item("subj_code").ToString, dr.Item("descriptive_title").ToString, dr.Item("no_of_units").ToString, dr.Item("type").ToString)
                For i = 0 To DataGridView4.Rows.Count - 1
                    DataGridView4.Rows(i).Height = 30
                Next
            End While
            lblrecordfoundsubject.Text = "(" & DataGridView4.Rows.Count & ")"
            DataGridView4.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        lblmanagement.Select()
        Dim colname As String = DataGridView4.Columns(e.ColumnIndex).Name
        opencon()
        Try
            If colname = "coleditsubject" Then
                With frmSubject
                    .cbosy.Text = DataGridView4.Rows(e.RowIndex).Cells(1).Value.ToString
                    .cbogradelevel.Text = DataGridView4.Rows(e.RowIndex).Cells(2).Value.ToString
                    .cbostrand.Text = DataGridView4.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtcode.Text = DataGridView4.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txttitle.Text = DataGridView4.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtunits.Text = DataGridView4.Rows(e.RowIndex).Cells(6).Value.ToString
                    .cbotype.Text = DataGridView4.Rows(e.RowIndex).Cells(7).Value.ToString
                    .cbostrand.Enabled = False
                    .cbogradelevel.Enabled = False
                    .btnsave.Enabled = False
                    .btnupdate.Enabled = True
                    .ShowDialog()
                End With
            ElseIf colname = "coldeletesubject" Then
                If MsgBox("Do you want to delete this subject?", vbQuestion + vbYesNo) = vbYes Then
                    cmd = New OleDbCommand("delete from Subject where ID=@id", con)
                    With cmd
                        .Parameters.AddWithValue("@id", DataGridView4.Rows(e.RowIndex).Cells(0).Value)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Subject has been deleted", vbInformation)
                    loadsubject()
                    recordfoundsubject()
                    loadschedule()
                    cbofiltergrade.Text = ""
                    cbofilterstrand.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub btnaddteacher_Click(sender As Object, e As EventArgs) Handles btnaddteacher.Click
        lblmanagement.Select()
        frmTeacher.ShowDialog()
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        lblmanagement.Select()
        opencon()
        Dim colname As String = DataGridView5.Columns(e.ColumnIndex).Name
        Try

            If colname = "coleditteacher" Then

                cmd = New OleDbCommand("select * from Teacher where teacher_id=@id", con)
                With cmd
                    .Parameters.AddWithValue("@id", DataGridView5.Rows(e.RowIndex).Cells(0).Value)
                    dr = .ExecuteReader
                End With
                dr.Read()
                If dr.HasRows Then
                    With frmTeacher
                        .txtid.Text = dr.Item("teacher_id")
                        .txtlname.Text = dr.Item("lname")
                        .txtfname.Text = dr.Item("fname")
                        .txtmname.Text = dr.Item("mname")
                        .txtdegree.Text = dr.Item("degree")
                        .txtspecialization.Text = dr.Item("specialization")
                        Dim arrImage As Byte()
                        arrImage = dr.Item("image")
                        Dim ms As New System.IO.MemoryStream(arrImage)
                        .picTeacher.Image = System.Drawing.Image.FromStream(ms)
                        .txtid.Enabled = False
                        .btnsave.Enabled = False
                        .btnupdate.Enabled = True
                        .ShowDialog()
                    End With
                End If
                con.Close()
                dr.Close()
            ElseIf colname = "coldeleteteacher" Then
                If MsgBox("Do you want to delete this teacher?", vbQuestion + vbYesNo) = vbYes Then
                    cmd = New OleDbCommand("delete from Teacher where teacher_id=@id", con)
                    With cmd
                        .Parameters.AddWithValue("@id", DataGridView5.Rows(e.RowIndex).Cells(0).Value)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Teacher has been deleted", vbInformation)
                    loadteacher()
                    recordfoundteacher()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Private Sub cbostrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboteacher.KeyPress, cbostrand.KeyPress, cbosection.KeyPress, cbogradelevel.KeyPress, cbocode.KeyPress, cboaycode.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbostrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostrand.SelectedIndexChanged
        DataGridView6.Enabled = True
        clear()
        txtroom.Clear()
        txtadviser.Clear()
        txtadviserid.Clear()
        cbosection.Items.Clear()
        cbosection.Text = ""
        opencon()
        Try
            cmd = New OleDbCommand("select [Section] from [Section] where Grade_Level=@grade and Strand=@strand", con)
            With cmd
                .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                .Parameters.AddWithValue("@strand", cbostrand.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                cbosection.Items.Add(dr.Item("Section").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cbogradelevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbogradelevel.SelectedIndexChanged

        DataGridView6.Enabled = True
        clear()
        txtroom.Clear()
        txtadviser.Clear()
        txtadviserid.Clear()
        cbostrand.Items.Clear()
        cbostrand.Text = ""
        cbosection.Items.Clear()
        cbosection.Text = ""
        opencon()
        Try
            cmd = New OleDbCommand("select Strand from Strand", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbostrand.Items.Add(dr.Item("Strand").ToString)
            End While
            cbostrand.Items.Add("N/A").ToString()

            If cbogradelevel.Text = "GRADE 11" Or cbogradelevel.Text = "GRADE 12" Then
                cbostrand.SelectedIndex = -1
                cbostrand.Enabled = True
            Else
                cbostrand.Text = "N/A"
                cbostrand.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub room_adviser_id_adviser_name()
        opencon()
        Try
            cmd = New OleDbCommand("select * from [Section] where Grade_Level=@grade and Strand=@strand and [Section]=@Section", con)
            With cmd
                .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                .Parameters.AddWithValue("@Strand", cbostrand.Text)
                .Parameters.AddWithValue("@Section", cbosection.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                txtroom.Text = dr.Item("Room").ToString
                txtadviserid.Text = dr.Item("teacher_id").ToString
                txtadviser.Text = dr.Item("teacher_name").ToString
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Private Sub cbosection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosection.SelectedIndexChanged
        DataGridView6.Enabled = True
        lblmanagement.Select()
        clear()
        loadschedule()
        getsubjects()
        room_adviser_id_adviser_name()
    End Sub

    Private Sub cbocode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocode.SelectedIndexChanged
        lblmanagement.Select()
        txttitle.Clear()
        txtunits.Clear()
        cboteacher.Items.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select descriptive_title,no_of_units from Subject where subj_code=@code", con)
            With cmd
                .Parameters.AddWithValue("@code", cbocode.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                txttitle.Text = dr.Item("descriptive_title").ToString
                txtunits.Text = dr.Item("no_of_units").ToString
            End If
            con.Close()
            dr.Close()

            con.Open()
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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lblmanagement.Select()

        For Each c As Control In Panel9.Controls
            If TypeOf c Is ComboBox Then
                If c.Text = "" Then
                    MsgBox("Please fill in all field", vbExclamation)
                    Return
                End If
            End If
        Next

        opencon()
        Try


            cmd = New OleDbCommand("select teacher_id from Teacher where fullname=@fullname", con)
            With cmd
                .Parameters.AddWithValue("@fullname", cboteacher.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            Dim teacher_id As String = String.Empty

            If dr.HasRows Then
                teacher_id = dr.Item("teacher_id").ToString
            End If
            con.Close()
            dr.Close()



            con.Open()
            cmd = New OleDbCommand("select ID from [Section] where [Section]=@section", con)
            With cmd
                .Parameters.AddWithValue("@section", cbosection.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            Dim sec_id As Integer
            If dr.HasRows Then
                sec_id = dr.Item("ID")
            End If
            con.Close()
            dr.Close()

            con.Open()
            cmd = New OleDbCommand("select ID from Subject where subj_code=code", con)
            With cmd
                .Parameters.AddWithValue("@code", cbocode.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            Dim sub_code_id As Integer
            If dr.HasRows Then
                sub_code_id = dr.Item("ID")
            End If
            con.Close()
            dr.Close()

            con.Open()
            cmd = New OleDbCommand("select ID from Room where Room=@room", con)
            With cmd
                .Parameters.AddWithValue("@room", txtroom.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            Dim room_id As Integer
            If dr.HasRows Then
                room_id = dr.Item("ID")
            End If
            con.Close()
            dr.Close()

            'For validation
            Dim m As String
            Dim t As String
            Dim w As String
            Dim th As String
            Dim f As String
            Dim s As String
            Dim day As String = String.Empty
            Dim time As String = txttimefrom.Text & "-" & txttimeto.Text
            If chkm.Checked = True Then m = "M" Else m = ""
            If chkt.Checked = True Then t = "T" Else t = ""
            If chkw.Checked = True Then w = "W" Else w = ""
            If chkth.Checked = True Then th = "TH" Else th = ""
            If chkf.Checked = True Then f = "F" Else f = ""
            If chks.Checked = True Then s = "S" Else s = ""

            If chkm.Checked = True Then day = "M"
            If chkt.Checked = True Then day += "T"
            If chkw.Checked = True Then day += "W"
            If chkth.Checked = True Then day += "TH"
            If chkf.Checked = True Then day += "F"
            If chks.Checked = True Then day += "S"

            con.Open()
            cmd = New OleDbCommand("select * from qsched where Grade_Level=@grade and Strand=@strand and [Section]=@section", con)
            With cmd
                .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                .Parameters.AddWithValue("@strand", cbostrand.Text)
                .Parameters.AddWithValue("@section", cbosection.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("Subj_code") = cbocode.Text Or dr.Item("descriptive_title") = txttitle.Text Then
                    MsgBox("This subject has already been added", vbExclamation)
                    Return
                End If

                If dr.Item("day") = day And dr.Item("time") = time Then
                    MsgBox("The schedule has conflict", vbExclamation)
                    Return
                End If
            End While
            con.Close()
            dr.Close()
            con.Open()
            cmd = New OleDbCommand("select * from qsched where [Section]<>@section", con)
            With cmd
                .Parameters.AddWithValue("@section", cbosection.Text)
                .Parameters.AddWithValue("@fullname", cboteacher.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("fullname") = cboteacher.Text And dr.Item("day") = day And dr.Item("time") = time Then
                    MsgBox("The schedule has conflict", vbExclamation)
                    Return
                End If
            End While
            con.Close()
            dr.Close()




            If MsgBox("Do you want to insert this schedule?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("insert into Schedule (aycode,sec_id,sub_code_id,mon,tue,wed,thu,fri,sat,[day],timefrom,timeto,[time],teacher_id) values (@aycode,@sec_id,@sub_code_id,@mon,@tue,@wed,@thu,@fri,@sat,@day,@timefrom,@timeto,@time,@teacher_id)", con)
                With cmd
                    .Parameters.AddWithValue("@aycode", cboaycode.Text)
                    .Parameters.AddWithValue("@sec_id", sec_id)
                    .Parameters.AddWithValue("@sub_code_id", sub_code_id)
                    .Parameters.AddWithValue("@mon", m)
                    .Parameters.AddWithValue("@tue", t)
                    .Parameters.AddWithValue("@wed", w)
                    .Parameters.AddWithValue("@thu", th)
                    .Parameters.AddWithValue("@fri", f)
                    .Parameters.AddWithValue("@sat", s)
                    .Parameters.AddWithValue("@day", day)
                    .Parameters.AddWithValue("@timefrom", txttimefrom.Text)
                    .Parameters.AddWithValue("@timeto", txttimeto.Text)
                    .Parameters.AddWithValue("@time", time)
                    .Parameters.AddWithValue("@teacher_id", teacher_id)
                    .ExecuteNonQuery()
                End With
                MsgBox("New schedule has been added", vbInformation)
                loadschedule()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub txttimefrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttimefrom.KeyPress, txttimeto.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub
    Public Sub getsubjects()
        cbocode.Items.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select subj_code from Subject where sy=@sy and  grade_level=@grade and strand=@strand", con)
            With cmd
                .Parameters.AddWithValue("@sy", cboaycode.Text)
                .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                .Parameters.AddWithValue("@strand", cbostrand.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                cbocode.Items.Add(dr.Item("subj_code").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub
    Sub clear()
        txttitle.Clear()
        txtunits.Clear()
        cbocode.Items.Clear()
        cbocode.Text = ""
        DataGridView6.Rows.Clear()
        txtteacherid.Clear()
        cboteacher.Items.Clear()
        cboteacher.Text = ""
        txttimefrom.Clear()
        txttimeto.Clear()
        chkf.Checked = False
        chkm.Checked = False
        chks.Checked = False
        chkt.Checked = False
        chkth.Checked = False
        chkw.Checked = False
    End Sub
    Public Sub loadschedule()
        DataGridView6.Rows.Clear()
        txttitle.Clear()
        txtunits.Clear()
        cbocode.Text = ""
        DataGridView6.Rows.Clear()
        txtteacherid.Clear()
        cboteacher.Items.Clear()
        cboteacher.Text = ""
        txttimefrom.Clear()
        txttimeto.Clear()
        chkf.Checked = False
        chkm.Checked = False
        chks.Checked = False
        chkt.Checked = False
        chkth.Checked = False
        chkw.Checked = False
        opencon()
        Try
            cmd = New OleDbCommand("select * from qsched  where sy=@sy and Grade_Level=@grade and Strand=@strand and [Section]=@section order by type asc", con)
            With cmd
                .Parameters.AddWithValue("@sy", cboaycode.Text)
                .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                .Parameters.AddWithValue("@strand", cbostrand.Text)
                .Parameters.AddWithValue("@section", cbosection.Text)
                dr = .ExecuteReader
            End With
            While dr.Read

                DataGridView6.Rows.Add(dr.Item("ID").ToString, dr.Item("sy").ToString, dr.Item("Grade_Level").ToString, dr.Item("Strand").ToString, dr.Item("Section").ToString, dr.Item("subj_code").ToString, dr.Item("descriptive_title").ToString, dr.Item("no_of_units").ToString, dr.Item("type").ToString, dr.Item("mon").ToString, dr.Item("tue").ToString, dr.Item("wed").ToString, dr.Item("thu").ToString, dr.Item("fri").ToString, dr.Item("sat").ToString, dr.Item("day").ToString, dr.Item("timefrom").ToString, dr.Item("timeto").ToString, dr.Item("time").ToString, dr.Item("teacher_id").ToString, dr.Item("fullname").ToString, dr.Item("Room").ToString)
            End While

            For i = 0 To DataGridView6.Rows.Count - 1
                DataGridView6.Rows(i).Height = 30
            Next
            DataGridView6.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub cboteacher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboteacher.SelectedIndexChanged
        lblmanagement.Select()
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
        con.Close()
        dr.Close()
    End Sub

    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick
        lblmanagement.Select()
        Dim colname As String = DataGridView6.Columns(e.ColumnIndex).Name
        opencon()
        Try
            If colname = "coldeletesched" Then
                If MsgBox("Do you want to delete this schedule? This subject will be deleted also!", vbQuestion + vbYesNo) = vbYes Then
                    cmd = New OleDbCommand("delete from subject where subj_code=code", con)
                    With cmd
                        .Parameters.AddWithValue("@code", DataGridView6.Rows(e.RowIndex).Cells(5).Value)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Schedule has been deleted", vbInformation)
                    loadschedule()
                    loadsubject()
                    con.Close()
                End If
            ElseIf colname = "coleditschedule" Then
                DataGridView6.Enabled = False
                cboaycode.Enabled = False
                cbogradelevel.Enabled = False
                cbostrand.Enabled = False
                cbosection.Enabled = False
                txtteacherid.Text = DataGridView6.Rows(e.RowIndex).Cells(19).Value.ToString
                txtunits.Text = DataGridView6.Rows(e.RowIndex).Cells(7).Value.ToString
                txttitle.Text = DataGridView6.Rows(e.RowIndex).Cells(6).Value.ToString
                cbocode.Text = DataGridView6.Rows(e.RowIndex).Cells(5).Value.ToString
                txttimefrom.Text = DataGridView6.Rows(e.RowIndex).Cells(16).Value.ToString
                txttimeto.Text = DataGridView6.Rows(e.RowIndex).Cells(17).Value.ToString
                cboteacher.Text = DataGridView6.Rows(e.RowIndex).Cells(20).Value.ToString
                If DataGridView6.Rows(e.RowIndex).Cells(9).Value = "M" Then chkm.Checked = True Else chkm.Checked = False
                If DataGridView6.Rows(e.RowIndex).Cells(10).Value = "T" Then chkt.Checked = True Else chkt.Checked = False
                If DataGridView6.Rows(e.RowIndex).Cells(11).Value = "W" Then chkw.Checked = True Else chkw.Checked = False
                If DataGridView6.Rows(e.RowIndex).Cells(12).Value = "TH" Then chkth.Checked = True Else chkth.Checked = False
                If DataGridView6.Rows(e.RowIndex).Cells(13).Value = "F" Then chkf.Checked = True Else chkf.Checked = False
                If DataGridView6.Rows(e.RowIndex).Cells(14).Value = "S" Then chks.Checked = True Else chks.Checked = False
                btnsave.Enabled = False
                btnupdate.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        lblmanagement.Select()
        cboaycode.Enabled = True
        cbogradelevel.Enabled = True
        cbostrand.Enabled = True
        cbosection.Enabled = True
        DataGridView6.Enabled = True
        txttimeto.Clear()
        txttitle.Clear()
        txtunits.Clear()
        cboteacher.Items.Clear()
        txttimefrom.Clear()
        cboteacher.Text = ""
        txtteacherid.Clear()
        chkf.Checked = False
        chkm.Checked = False
        chks.Checked = False
        chkt.Checked = False
        chkth.Checked = False
        chkw.Checked = False
        cbocode.Text = ""
        btnupdate.Enabled = False
        btnsave.Enabled = True
        DataGridView6.ClearSelection()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        lblmanagement.Select()

        opencon()
        Try

            cmd = New OleDbCommand("select teacher_id from Teacher where fullname=@fullname", con)
            With cmd
                .Parameters.AddWithValue("@fullname", cboteacher.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            Dim teacher_id As String = String.Empty

            If dr.HasRows Then
                teacher_id = dr.Item("teacher_id").ToString
            End If
            con.Close()
            dr.Close()



            con.Open()
            cmd = New OleDbCommand("select ID from [Section] where [Section]=@section", con)
            With cmd
                .Parameters.AddWithValue("@section", cbosection.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            Dim sec_id As Integer
            If dr.HasRows Then
                sec_id = dr.Item("ID")
            End If
            con.Close()
            dr.Close()

            con.Open()
            cmd = New OleDbCommand("select ID from Subject where subj_code=code", con)
            With cmd
                .Parameters.AddWithValue("@code", cbocode.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            Dim sub_code_id As Integer
            If dr.HasRows Then
                sub_code_id = dr.Item("ID")
            End If
            con.Close()
            dr.Close()


            'For validation
            Dim m As String
            Dim t As String
            Dim w As String
            Dim th As String
            Dim f As String
            Dim s As String
            Dim day As String = String.Empty
            Dim time As String = txttimefrom.Text & "-" & txttimeto.Text
            If chkm.Checked = True Then m = "M" Else m = ""
            If chkt.Checked = True Then t = "T" Else t = ""
            If chkw.Checked = True Then w = "W" Else w = ""
            If chkth.Checked = True Then th = "TH" Else th = ""
            If chkf.Checked = True Then f = "F" Else f = ""
            If chks.Checked = True Then s = "S" Else s = ""

            If chkm.Checked = True Then day = "M"
            If chkt.Checked = True Then day += "T"
            If chkw.Checked = True Then day += "W"
            If chkth.Checked = True Then day += "TH"
            If chkf.Checked = True Then day += "F"
            If chks.Checked = True Then day += "S"


            con.Open()
            cmd = New OleDbCommand("select * from qsched where Grade_Level=@grade and Strand=@strand and [Section]=@section and ID<>@id", con)
            With cmd
                .Parameters.AddWithValue("@grade", cbogradelevel.Text)
                .Parameters.AddWithValue("@strand", cbostrand.Text)
                .Parameters.AddWithValue("@section", cbosection.Text)
                .Parameters.AddWithValue("@id", DataGridView6.CurrentRow.Cells(0).Value)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("Subj_code") = cbocode.Text Or dr.Item("descriptive_title") = txttitle.Text Then
                    MsgBox("This subject has already been added", vbExclamation)
                    Return
                End If

                If dr.Item("day") = day And dr.Item("time") = time Then
                    MsgBox("The schedule has conflict", vbExclamation)
                    Return
                End If
            End While
            con.Close()
            dr.Close()
            con.Open()
            cmd = New OleDbCommand("select * from qsched where [Section]<>@section", con)
            With cmd
                .Parameters.AddWithValue("@section", cbosection.Text)
                .Parameters.AddWithValue("@fullname", cboteacher.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                If dr.Item("fullname") = cboteacher.Text And dr.Item("day") = day And dr.Item("time") = time Then
                    MsgBox("The schedule has conflict", vbExclamation)
                    Return
                End If
            End While
            con.Close()
            dr.Close()


            If MsgBox("Do you want to update this schedule?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New OleDbCommand("update Schedule set aycode=@aycode, sec_id=@sec_id, sub_code_id=@sub_id_code, mon=@mon, tue=@tue, wed=@wed, thu=@thu, fri=@fri, sat=@sat, [day]=@day, timefrom=@timefrom ,timeto=@timeto, [time]=@time, teacher_id=@teacher_id where ID=@id", con)

                With cmd
                    .Parameters.AddWithValue("@aycode", cboaycode.Text)
                    .Parameters.AddWithValue("@sec_id", sec_id)
                    .Parameters.AddWithValue("@sub_code_id", sub_code_id)
                    .Parameters.AddWithValue("@mon", m)
                    .Parameters.AddWithValue("@tue", t)
                    .Parameters.AddWithValue("@wed", w)
                    .Parameters.AddWithValue("@thu", th)
                    .Parameters.AddWithValue("@fri", f)
                    .Parameters.AddWithValue("@sat", s)
                    .Parameters.AddWithValue("@day", day)
                    .Parameters.AddWithValue("@timefrom", txttimefrom.Text)
                    .Parameters.AddWithValue("@timeto", txttimeto.Text)
                    .Parameters.AddWithValue("@time", time)
                    .Parameters.AddWithValue("@teacher_id", teacher_id)
                    .Parameters.AddWithValue("@id", DataGridView6.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MsgBox("The schedule has been updated", vbInformation)
                loadschedule()
                btnupdate.Enabled = False
                btnsave.Enabled = True
                DataGridView6.Enabled = True
                DataGridView6.Enabled = True
                cboaycode.Enabled = True
                cbogradelevel.Enabled = True
                cbostrand.Enabled = True
                cbosection.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub

    Private Sub chkm_Click(sender As Object, e As EventArgs) Handles chkw.Click, chkth.Click, chkt.Click, chks.Click, chkm.Click, chkf.Click
        lblmanagement.Select()
    End Sub

    Private Sub cboaycode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboaycode.SelectedIndexChanged
        DataGridView6.Rows.Clear()
        cbogradelevel.Text = ""
        cbostrand.Items.Clear()
        cbostrand.Text = ""
        cbosection.Items.Clear()
        cbosection.Text = ""
        txtroom.Clear()
        txtadviser.Clear()
        txtadviserid.Clear()
    End Sub


End Class
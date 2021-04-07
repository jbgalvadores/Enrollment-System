Imports System.Data.OleDb
Public Class frmenrolling


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

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbosection.KeyPress, cbostrand.KeyPress
        e.Handled = True
    End Sub
    Public Sub autosearch()
        opencon()
        Try
            da = New OleDbDataAdapter("select * from Status_Enrollment where Status<>'DROPPED'", con)
            ds = New DataSet
            da.Fill(ds)
            Dim col As New AutoCompleteStringCollection

            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("student_id").ToString)
            Next
            txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtsearch.AutoCompleteCustomSource = col
            txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
    End Sub
    Public Sub getstrand()
        cbostrand.Items.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select Strand from Strand", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cbostrand.Items.Add(dr.Item("Strand").ToString)
            End While
            cbostrand.Items.Add("N/A").ToString()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub

    Public Sub loadrecord()
        opencon()
        Try
            cmd = New OleDbCommand("select * from Status_Enrollment where student_id like '" & txtsearch.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtaycode.Text = dr.Item("aycode").ToString
                txtsid.Text = dr.Item("student_id").ToString
                txtfullname.Text = dr.Item("fullname").ToString
                txtgradelevel.Text = dr.Item("grade_level").ToString
                txtstatus.Text = dr.Item("Status").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub
    Sub clear()
        For Each c As Control In Panel2.Controls
            cbostrand.Enabled = True
            cbosection.Enabled = True
            lblstudentenrolled.Visible = False
            lblsectionfull.Visible = False
            txtsearch.Clear()
            cbosection.Items.Clear()
            DataGridView1.Rows.Clear()
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        For Each c As Control In Panel2.Controls
            If TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text = "" Then clear()
        loadrecord()

        Try
            opencon()
            cmd = New OleDbCommand("select * from Status_Enrollment where student_id=@student_id", con)
            With cmd
                .Parameters.AddWithValue("student_id", txtsid.Text)
                dr = .ExecuteReader
            End With
            dr.Read()
            If dr.HasRows Then
                If dr.Item("Status") = "ENROLLED" Then
                    cbostrand.Text = dr.Item("strand").ToString
                    cbosection.Text = dr.Item("Section").ToString
                    con.Close()
                    dr.Close()

                    con.Open()
                    cmd = New OleDbCommand("select * from [Section] where Grade_Level=@grade and Strand=@strand and [Section]=@section ", con)
                    With cmd
                        .Parameters.AddWithValue("@grade", txtgradelevel.Text)
                        .Parameters.AddWithValue("@strand", cbostrand.Text)
                        .Parameters.AddWithValue("section", cbosection.Text)
                        dr = .ExecuteReader
                    End With
                    dr.Read()
                    If dr.HasRows Then
                        txtadviser.Text = dr.Item("teacher_name").ToString
                        txtroom.Text = dr.Item("Room").ToString
                    End If
                    dr.Close()
                    con.Close()

                    con.Open()
                    cmd = New OleDbCommand("select * from qsched where sy=@sy and Grade_Level=@grade and Strand=@strand and [Section]=@section", con)
                    With cmd
                        .Parameters.AddWithValue("@sy", txtaycode.Text)
                        .Parameters.AddWithValue("@grade", txtgradelevel.Text)
                        .Parameters.AddWithValue("@strand", cbostrand.Text)
                        .Parameters.AddWithValue("@section", cbosection.Text)
                        dr = .ExecuteReader
                    End With
                    DataGridView1.Rows.Clear()

                    While dr.Read
                        DataGridView1.Rows.Add(dr.Item("subj_code").ToString, dr.Item("descriptive_title").ToString, dr.Item("no_of_units").ToString, dr.Item("type").ToString, dr.Item("Day").ToString, dr.Item("Time").ToString, dr.Item("fullname").ToString, dr.Item("Room").ToString)
                    End While
                    For i = 0 To DataGridView1.Rows.Count - 1
                        DataGridView1.Rows(i).Height = 30
                    Next
                    DataGridView1.ClearSelection()
                    cbosection.Enabled = False
                    cbostrand.Enabled = False
                    lblstudentenrolled.Visible = True
                    dr.Close()
                    con.Close()
                ElseIf dr.Item("Status") = "NOT ENROLLED" Then
                    cbosection.Enabled = True
                    cbostrand.Enabled = True
                    lblstudentenrolled.Visible = False
                    DataGridView1.Rows.Clear()
                    txtadviser.Clear()
                    txtroom.Clear()
                    cbostrand.Text = ""
                    cbosection.Items.Clear()
                    cbosection.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clear()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

    End Sub
    Private Sub txtsearch_GotFocus(sender As Object, e As EventArgs) Handles txtsearch.GotFocus
        If txtsearch.Text = "ENTER STUDENT ID ONLY" Then
            txtsearch.Text = ""
            txtsearch.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtsearch_LostFocus(sender As Object, e As EventArgs) Handles txtsearch.LostFocus
        If txtsearch.Text = "" Then
            txtsearch.Text = "ENTER STUDENT ID ONLY"
            txtsearch.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub cbostrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostrand.SelectedIndexChanged
        If txtstatus.Text = "NOT ENROLLED" Then
            lblenrollment.Select()
            cbosection.Items.Clear()
            cbosection.Text = ""
            txtadviser.Clear()
            txtroom.Clear()
            opencon()
            Try
                cmd = New OleDbCommand("select [Section] from [Section] where Grade_Level=@grade and Strand=@strand", con)
                With cmd
                    .Parameters.AddWithValue("@grade", txtgradelevel.Text)
                    .Parameters.AddWithValue("@strand", cbostrand.Text)
                    dr = .ExecuteReader
                End With
                While dr.Read
                    cbosection.Items.Add(dr.Item("Section").ToString)
                End While
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
            dr.Close()
            con.Close()
        End If
    End Sub

    Private Sub cbosection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosection.TextChanged

        opencon()
        Try
            cmd = New OleDbCommand("select count(student_id) from qsection where grade_level=@grade and strand=@strand and [Section]=@section", con)
            With cmd
                .Parameters.AddWithValue("@grade", txtgradelevel.Text)
                .Parameters.AddWithValue("@strand", cbostrand.Text)
                .Parameters.AddWithValue("@section", cbosection.Text)
            End With
            result = cmd.ExecuteScalar
            con.Close()

            con.Open()
            cmd = New OleDbCommand("select maxstudent from max_student", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If Convert.ToInt32(dr.Item("maxstudent")) <= result Then
                    lblsectionfull.Visible = True
                Else
                    lblsectionfull.Visible = False
                End If
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()

        If txtstatus.Text = "NOT ENROLLED" Then
            opencon()
            Try
                cmd = New OleDbCommand("select * from [Section] where Grade_Level=@grade and Strand=@strand and [Section]=@section ", con)
                With cmd
                    .Parameters.AddWithValue("@grade", txtgradelevel.Text)
                    .Parameters.AddWithValue("@strand", cbostrand.Text)
                    .Parameters.AddWithValue("section", cbosection.Text)
                    dr = .ExecuteReader
                End With
                dr.Read()
                If dr.HasRows Then
                    txtadviser.Text = dr.Item("teacher_name").ToString
                    txtroom.Text = dr.Item("Room").ToString
                End If
                dr.Close()
                con.Close()


                con.Open()
                cmd = New OleDbCommand("select * from qsched where sy=@sy and Grade_Level=@grade and Strand=@strand and [Section]=@section", con)
                With cmd
                    .Parameters.AddWithValue("@sy", txtaycode.Text)
                    .Parameters.AddWithValue("@grade", txtgradelevel.Text)
                    .Parameters.AddWithValue("@strand", cbostrand.Text)
                    .Parameters.AddWithValue("@section", cbosection.Text)
                    dr = .ExecuteReader
                End With
                DataGridView1.Rows.Clear()

                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("subj_code").ToString, dr.Item("descriptive_title").ToString, dr.Item("no_of_units").ToString, dr.Item("type").ToString, dr.Item("Day").ToString, dr.Item("Time").ToString, dr.Item("fullname").ToString, dr.Item("Room").ToString)
                End While
                For i = 0 To DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(i).Height = 30
                Next
                DataGridView1.ClearSelection()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
            dr.Close()
            con.Close()
        End If
    End Sub


End Class
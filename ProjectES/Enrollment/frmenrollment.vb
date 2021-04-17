Imports System.Data.OleDb
Imports System.IO
Public Class frmenrollment

    Public Sub loadrecord()

        opencon()
        Try
            cmd = New OleDbCommand("select * from Status_Enrollment where student_id=@student_id  or aid=@aid or fullname=@fullname", con)
            With cmd
                .Parameters.AddWithValue("@student_id", txtsearch.Text)
                .Parameters.AddWithValue("@aid", txtsearch.Text)
                .Parameters.AddWithValue("@fullname", txtsearch.Text)
                dr = .ExecuteReader
            End With
            While dr.Read
                datagridview1.Rows.Clear()
                datagridview1.Rows.Add(dr.Item("student_id").ToString, dr.Item("aid").ToString, dr.Item("lrn").ToString, dr.Item("fullname").ToString, dr.Item("grade_level").ToString, dr.Item("strand").ToString, dr.Item("Section").ToString, dr.Item("Status").ToString, dr.Item("aycode").ToString)
            End While
            For i = 0 To datagridview1.Rows.Count - 1
                datagridview1.Rows(i).Height = 30
            Next
            datagridview1.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub
    Public Sub autosearch()
        opencon()
        Try
            da = New OleDbDataAdapter("select * from Status_Enrollment where Status<>'DROPPED'", con)
            ds = New DataSet
            da.Fill(ds)

            Dim col As New AutoCompleteStringCollection
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("fullname").ToString)
                col.Add(ds.Tables(0).Rows(i)("student_id").ToString)
                col.Add(ds.Tables(0).Rows(i)("aid").ToString)
            Next

            txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtsearch.AutoCompleteCustomSource = col
            txtsearch.AutoCompleteMode = AutoCompleteMode.Suggest
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        dr.Close()
        con.Close()
    End Sub
    Public Sub loadstatus()
        datagridview1.Rows.Clear()
        opencon()
        Try
            cmd = New OleDbCommand("select * from Status_Enrollment where Status<>'DROPPED'order by student_id asc", con)
            dr = cmd.ExecuteReader
            While dr.Read
                datagridview1.Rows.Add(dr.Item("student_id").ToString, dr.Item("aid").ToString, dr.Item("lrn").ToString, dr.Item("fullname").ToString, dr.Item("grade_level").ToString, dr.Item("strand").ToString, dr.Item("Section").ToString, dr.Item("Status").ToString, dr.Item("aycode").ToString)
            End While
            For i = 0 To datagridview1.Rows.Count - 1
                datagridview1.Rows(i).Height = 30
            Next
            datagridview1.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()
        dr.Close()
    End Sub

    Public Sub getay()
        cboaycode.Items.Clear()
        opencon()

        Try
            cmd = New OleDbCommand("select aycode from aycode order by aycode asc", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cboaycode.Items.Add(dr.Item("aycode").ToString)
            End While
            cboaycode.Items.Add("ALL YEAR")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub cboaycode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbogradelevel.KeyPress, cboaycode.KeyPress
        e.Handled = True
    End Sub


    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        lblenrollment.Select()
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
                frmenrolling.Owner = f
                frmenrolling.ShowDialog()
            End With
        Catch ex As Exception
        Finally
            f.Dispose()
        End Try
    End Sub


    Private Sub datagridview1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridview1.CellContentClick
        Dim colname As String = datagridview1.Columns(e.ColumnIndex).Name
        Try
            If colname = "coldelete" Then
                If MsgBox("Do you want to delete this student?", vbQuestion + vbYesNo) = vbYes Then
                    opencon()
                    cmd = New OleDbCommand("delete from Status_Enrollment where aid=@aid ", con)
                    With cmd
                        .Parameters.AddWithValue("@aid", datagridview1.Rows(e.RowIndex).Cells(1).Value)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    con.Open()
                    cmd = New OleDbCommand("delete from StudentInfo where aid=@aid ", con)
                    With cmd
                        .Parameters.AddWithValue("@aid", datagridview1.Rows(e.RowIndex).Cells(1).Value)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                    con.Open()
                    cmd = New OleDbCommand("delete from Requirements where aid=@aid ", con)
                    With cmd
                        .Parameters.AddWithValue("@aid", datagridview1.Rows(e.RowIndex).Cells(1).Value)
                        .ExecuteNonQuery()
                    End With
                    con.Close()

                    MsgBox("Student has been successfully deleted", vbInformation)
                    con.Close()
                    loadstatus()
                    frmMain.countenrolled()
                    frmMain.countstudent()
                    con.Close()
                End If
            ElseIf colname = "colupdate" Then
                opencon()
                cmd = New OleDbCommand("select aycode from aycode where Status='Active'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                Dim aycode As String = String.Empty
                If dr.HasRows Then
                    aycode = dr.Item("aycode").ToString
                End If
                con.Close()
                dr.Close()
                If MsgBox("Do you want to update this student to " & aycode, vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New OleDbCommand("update Status_Enrollment set aycode=@aycode where student_id=@student_id", con)
                    With cmd
                        .Parameters.AddWithValue("@aycode", aycode)
                        .Parameters.AddWithValue("@student_id", datagridview1.Rows(e.RowIndex).Cells(0).Value)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Student " & datagridview1.Rows(e.RowIndex).Cells(0).Value & " has been updated to " & aycode, vbInformation)
                    loadstatus()
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
        dr.Close()
        con.Close()
    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        Dim savefile As New SaveFileDialog()
        savefile.FileName = "Student-Data"
        savefile.Filter = "CSV File | *.csv"

        If savefile.ShowDialog() = DialogResult.OK Then

            Using sw As StreamWriter = File.CreateText(savefile.FileName)
                Dim DataGridColumnNames As List(Of String) = datagridview1.Columns.
                    Cast(Of DataGridViewColumn).ToList().
                    Select(Function(c) c.Name).ToList()

                sw.WriteLine(String.Join(",", DataGridColumnNames))

                For Each row As DataGridViewRow In datagridview1.Rows

                    Dim rowData As New List(Of String)
                    For Each col As DataGridViewColumn In datagridview1.Columns
                        rowData.Add(Convert.ToString(row.Cells(col.Name).Value))
                    Next
                    sw.WriteLine(String.Join(",", rowData))
                Next

            End Using
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    End Sub
End Class

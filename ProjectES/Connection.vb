Imports System.Data.OleDb
Module Connection
    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public str As String
    Public result As Integer
    Public drag As Boolean
    Public x, y As Integer
    Public dt As New DataTable
    Sub opencon()
        Try
            With con
                If con.State = ConnectionState.Open Then con.Close()
                .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Enrollment System.accdb"
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub DoubleBufferedControl(ByVal obj As Object)
        Dim type As Type = obj.GetType
        Dim pi As System.Reflection.PropertyInfo = type.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        pi.SetValue(obj, True, Nothing)
    End Sub

End Module

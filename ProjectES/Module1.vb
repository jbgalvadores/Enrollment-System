Imports System.Data.OleDb

Module Module1

    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader


    Sub DoubleBufferedControl(ByVal obj As Object)
        Dim type As Type = obj.GetType
        Dim pi As System.Reflection.PropertyInfo = type.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.Public)
        pi.SetValue(obj, True, Nothing)
    End Sub

    Sub opencon()
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Projects\ProjectES\EnrollmentSystem.accdb"
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Module

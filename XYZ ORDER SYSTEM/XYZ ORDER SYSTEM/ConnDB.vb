Imports System.Data.OleDb
Module ConnDB
    Public con As OleDbConnection = Nothing
    Public cmd As OleDbCommand = Nothing
    Public dr As OleDbDataReader = Nothing
    Public da As OleDbDataAdapter = Nothing
    Public dt As DataTable = Nothing
    Public ds As DataSet = Nothing
    Public sql As String = Nothing
    Public ConnectionString As String = Nothing

    Public Sub OleConnection(ByVal sql As String)
        If con.State = ConnectionState.open Then
            con.Close()
        End If
        ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Rian\Desktop\XYZ ORDER SYSTEM\DB\XYZORDERDB.accdb;"
        con.ConnectionString = ConnectionString
        con.Open()
    End Sub
End Module

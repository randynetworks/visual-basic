Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public Sub koneksi()
        Dim Str As String
        Str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\jualbuku.accdb"
        con = New OleDbConnection(Str)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
End Module

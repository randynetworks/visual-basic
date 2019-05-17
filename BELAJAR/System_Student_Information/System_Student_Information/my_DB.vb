Imports MySql.Data.MySqlClient
Public Class my_DB

    Private Con As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=vbnet_student_db")

    ReadOnly Property GetConnection() As MySqlConnection
        Get
            Return Con
        End Get
    End Property


    Sub openConnection()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
    End Sub

    Sub closeConnection()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub
End Class

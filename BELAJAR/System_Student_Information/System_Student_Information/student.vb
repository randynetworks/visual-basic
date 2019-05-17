Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Student
    Dim db As New my_DB()

    'for create new student
    Public Function insertStudent(id As Integer, ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal phone As String, ByVal address As String, ByVal picture As MemoryStream) As Boolean
        Dim command As New MySqlCommand("INSERT INTO `student`(`first_Name`, `last_Name`, `birth_date`,`gender`, `phone` , `address`, `picture`) VALUES (@fn, @ln, @btd,@gdr, @phn, @ad, @pic)", db.GetConnection)
        '@fn, @ln, @btd, @gdr, @phn, @ad, @pic

        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@btd", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery = 1 Then
            Return True
        Else
            Return False
        End If

        db.closeConnection()
    End Function

    'function to get all student data in database
    Function getStudent() As DataTable
        Dim command As New MySqlCommand("SELECT * FROM `student`")
        command.Connection = db.GetConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table
    End Function

    Public Function deleteStudent(ByVal id As Integer) As Boolean
        Dim command As New MySqlCommand("DELETE FROM `student` WHERE `id` = @studentID ", db.GetConnection)
        command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id

        db.openConnection()

        If command.ExecuteNonQuery = 1 Then
            Return True
        Else
            Return False
        End If

        db.closeConnection()

    End Function

    Friend Function insertStudent(fname As String, lname As String, bdate As Date, gender As String, phone As String, adrs As String, pic As MemoryStream) As Boolean
        Throw New NotImplementedException()
    End Function

    'for update a student
    Public Function UpdateStudent(ByVal id As Integer, ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal phone As String, ByVal address As String, ByVal picture As MemoryStream) As Boolean
        Dim command As New MySqlCommand("UPDATE `student` SET `first_Name`= @fn,`last_Name`= @ln,`birth_date`= @btd,`gender`= @gdr,`phone`= @phn,`address`= @ad,`picture`= @pic WHERE id=@ID", db.GetConnection)
        '@fn, @ln, @btd, @gdr, @phn, @ad, @pic

        command.Parameters.Add("@id", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@btd", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery = 1 Then
            Return True
        Else
            Return False
        End If

        db.closeConnection()
    End Function
End Class

Imports System.IO
Public Class UpdateDeleteStudent
    Dim student As New Student
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Try
            Dim studentID As Integer = Convert.ToInt32(tbId.Text)
            'FOR CONFIRM
            If MsgBox("Are You sure want to Delete this?", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then
                If student.deleteStudent(studentID) Then
                    MsgBox("Student Deleted!", MsgBoxStyle.Information, "Student Delete")
                Else
                    MsgBox("Student is not Delete!", MsgBoxStyle.Exclamation, "Student Delete")
                End If
            End If

        Catch ex As Exception
            MsgBox("Enter Valid ID", MsgBoxStyle.OkOnly, "Error")
        End Try


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim student As New Student()
        Dim fname As String = tbFirstName.Text
        Dim lname As String = tbLastName.Text
        Dim bdate As Date = datePicker.Value
        Dim phone As String = tbphone.Text
        Dim adrs As String = tbAddress.Text
        Dim gender As String = "Male"
        'gender check
        If RadioButton2.Checked Then
            gender = "Female"
        End If

        Dim pic As New MemoryStream




        'check condition age must beetwen 10 and 100
        Dim born_year As Integer = datePicker.Value.Year
        Dim today_year As Integer = Date.Now.Year

        If today_year - born_year < 10 Or today_year - born_year = 100 Then
            MsgBox("Date year must beetwen 10 and 100 years", MsgBoxStyle.Information, "Date Error!")
        Else
            If verif() Then
                Dim id As Integer = Convert.ToInt32(tbId.Text)
                PictureBox1.Image.Save(pic, PictureBox1.Image.RawFormat)

                If student.UpdateStudent(id, fname, lname, bdate, gender, phone, adrs, pic) Then
                    MsgBox("Student Data Edited", MsgBoxStyle.Information, "Edit Student")
                Else

                    MsgBox("Error!", MsgBoxStyle.Critical, "Edit Student")
                End If
            Else
                MsgBox("Data Empty!", MsgBoxStyle.Critical, "Edit Student")
            End If
        End If

    End Sub


    'create function to verify data
    Function verif() As Boolean
        If tbFirstName.Text.Trim = "" Or tbLastName.Text.Trim = "" Or
            tbphone.Text.Trim = "" Or tbAddress.Text.Trim = "" Or
            PictureBox1.Image Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
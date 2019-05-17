Imports System.IO
Public Class AddStudentForm
    Private Sub tbPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbphone.KeyPress
        'allow numerik can input
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim ops As New OpenFileDialog()
        ops.Filter = "Select image (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif"
        If ops.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ops.FileName)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
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

        Dim pic As MemoryStream




        'check condition age must beetwen 10 and 100
        Dim born_year As Integer = datePicker.Value.Year
        Dim today_year As Integer = Date.Now.Year

        If today_year - born_year < 10 Or today_year - born_year = 100 Then
            MsgBox("Date year must beetwen 10 and 100 years", MsgBoxStyle.Information, "Date Error!")
        Else
            If verif() Then
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                PictureBox1.Image.Save(pic, PictureBox1.Image.RawFormat)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

                If student.insertStudent(fname, lname, bdate, gender, phone, adrs, pic) Then

                    MsgBox("New Student Added", MsgBoxStyle.Information, "Add Student")
                Else

                    MsgBox("Error!", MsgBoxStyle.Critical, "Add Student")
                End If
            Else
                MsgBox("Data Empty!", MsgBoxStyle.Critical, "Add Student")
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
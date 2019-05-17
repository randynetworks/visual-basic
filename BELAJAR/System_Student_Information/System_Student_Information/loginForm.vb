Imports MySql.Data.MySqlClient
Public Class loginForm
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureLogin.ImageLocation = "../../myimage/userIcon.png"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        If tbPassword.UseSystemPasswordChar Then
            'for see password
            tbPassword.UseSystemPasswordChar = False
        Else
            'for hide password
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As New my_DB()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `user` WHERE  `username`= @usn AND `password` = @pass", db.GetConnection)

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = tbUsername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPassword.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Dim mainForm As New MainForm()
            mainForm.Show()
            Me.Close()
        Else
            MsgBox("Username or Password Incorrect", MsgBoxStyle.Critical, "Login Error")
        End If
    End Sub
End Class

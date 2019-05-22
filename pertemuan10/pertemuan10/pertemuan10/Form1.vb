Public Class Form1
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        rm.Clear()
        nama.Clear()
        alamat.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

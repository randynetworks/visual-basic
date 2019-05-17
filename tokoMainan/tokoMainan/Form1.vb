Public Class Form1
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        kode.Clear()
        nama.Text = " "
        harga.Clear()
        jumlah.Clear()
        subTotal.Clear()
        pajak.Clear()
        total.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Nama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nama.SelectedIndexChanged
        If nama.Text = "MOBIL" Then
            harga.Text = 75000
        ElseIf nama.Text = "MOTOR" Then
            harga.Text = 50000
        ElseIf nama.Text = "BONEKA" Then
            harga.Text = 65000
        End If
    End Sub
End Class

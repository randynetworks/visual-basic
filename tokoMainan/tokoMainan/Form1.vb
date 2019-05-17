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
End Class

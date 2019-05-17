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

    Private Sub Jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged
        subTotal.Text = Val(harga.Text) * Val(jumlah.Text)
    End Sub

    Private Sub SubTotal_TextChanged(sender As Object, e As EventArgs) Handles subTotal.TextChanged
        pajak.Text = Val(harga.Text) * 0.1
    End Sub

    Private Sub Pajak_TextChanged(sender As Object, e As EventArgs) Handles pajak.TextChanged
        total.Text = Val(subTotal.Text) + Val(pajak.Text)
    End Sub
End Class

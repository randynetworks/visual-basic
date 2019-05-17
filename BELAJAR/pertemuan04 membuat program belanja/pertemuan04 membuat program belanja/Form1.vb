Public Class Form1
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbNamaBarang.Text = " "
        tbHargaSatuan.Text = " "
        tbJumlahBarang.Text = " "
        tbTotalHarga.Text = " "
        tbDiskon.Text = " "
        tbTotalBayar.Text = " "
        tbBonus.Text = " "
        tbNamaBarang.Focus()

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus As String

        harga = tbHargaSatuan.Text
        jumlah = tbJumlahBarang.Text
        total = harga * jumlah

        If total >= 500000 Then
            diskon = 0.2 * total
            bonus = "Tas Pinggang"
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Payung"
        ElseIf total >= 100000 Then
            diskon = 0.1 * total
            bonus = "Kaos"
        ElseIf total >= 50000 Then
            diskon = 0.05 * total
            bonus = "Cangkir"
        Else
            diskon = 0
            bonus = "Tidak Ada"
        End If

        bayar = total - diskon

        tbTotalBayar.Text = bayar
        tbDiskon.Text = diskon
        tbBonus.Text = bonus
        tbTotalHarga.Text = total
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End

    End Sub
End Class

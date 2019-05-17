Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        kode.Clear()
        tanggal.Clear()
        nama.Clear()
        alamat.Clear()
        cbjenis.Text = " "
        harga.Clear()
        jumlah.Clear()
        subHarga.Clear()
        potongan.Clear()
        subGrand.Clear()
        pajak.Clear()
        grand.Clear()

    End Sub

    Private Sub Cbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjenis.SelectedIndexChanged
        If cbjenis.Text = "PSP" Then
            harga.Text = 1300000
        ElseIf cbjenis.Text = "PLAYSTATION 1" Then
            harga.Text = 300000
        ElseIf cbjenis.Text = "PLAYSTATION HDD" Then
            harga.Text = 1200000
        ElseIf cbjenis.Text = "PLAYSTATION 2" Then
            harga.Text = 800000
        ElseIf cbjenis.Text = "NITENDO" Then
            harga.Text = 1800000
        ElseIf cbjenis.Text = "DVD GAME" Then
            harga.Text = 5000
        End If
    End Sub

    Private Sub Jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged
        subHarga.Text = Val(jumlah.Text) * Val(harga.Text)
    End Sub

    Private Sub SubHarga_TextChanged(sender As Object, e As EventArgs) Handles subHarga.TextChanged
        potongan.Text = Val(subHarga.Text) * 0.1
    End Sub

    Private Sub Potongan_TextChanged(sender As Object, e As EventArgs) Handles potongan.TextChanged
        subGrand.Text = Val(subHarga.Text) - Val(potongan.Text)
    End Sub

    Private Sub SubGrand_TextChanged(sender As Object, e As EventArgs) Handles subGrand.TextChanged
        pajak.Text = Val(subGrand.Text) * 0.1
    End Sub

    Private Sub Pajak_TextChanged(sender As Object, e As EventArgs) Handles pajak.TextChanged
        grand.Text = Val(subGrand.Text) + Val(pajak.Text)
    End Sub

End Class

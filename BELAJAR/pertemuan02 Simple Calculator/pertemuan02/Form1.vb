Public Class frmkalkulator
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtangka1.Text)
        Angka2 = Val(txtangka2.Text)
        Hasil = Angka1 + Angka2
        txthasil.Text = Hasil
    End Sub

    Private Sub btnkurang_Click(sender As Object, e As EventArgs) Handles btnkurang.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtangka1.Text)
        Angka2 = Val(txtangka2.Text)
        Hasil = Angka1 - Angka2
        txthasil.Text = Hasil
    End Sub

    Private Sub btnkali_Click(sender As Object, e As EventArgs) Handles btnkali.Click
        Dim Angka1, Angka2, hasil As Double
        Angka1 = Val(txtangka1.Text)
        Angka2 = Val(txtangka2.Text)
        hasil = Angka1 * Angka2
        txthasil.Text = hasil
    End Sub

    Private Sub btnbagi_Click(sender As Object, e As EventArgs) Handles btnbagi.Click
        Dim Angka1, Angka2, Hasil As Double
        Angka1 = Val(txtangka1.Text)
        Angka2 = Val(txtangka2.Text)
        Hasil = Angka1 / Angka2
        txthasil.Text = Hasil
    End Sub
End Class

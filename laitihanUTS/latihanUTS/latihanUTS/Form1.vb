Public Class Form1

    Sub Reset()
        cbpilih.Text = " "
        cbSatuan.Text = " "
        tbSisi.Clear()
        tbSisi.Enabled = False
        tbPanjang.Clear()
        tbPanjang.Enabled = False
        tbLebar.Clear()
        tbLebar.Enabled = False
        tbTinggi.Clear()
        tbTinggi.Enabled = False
        tbAlas.Clear()
        tbAlas.Enabled = False
        tbAtas.Clear()
        tbAtas.Enabled = False
        tbJari.Clear()
        tbJari.Enabled = False
        tbDiagonal1.Clear()
        tbDiagonal1.Enabled = False
        tbDiagonal2.Clear()
        tbDiagonal2.Enabled = False
        tbHasil.Clear()
        tbHasil.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Reset()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call Reset()
    End Sub

    Private Sub Cbpilih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpilih.SelectedIndexChanged
        If cbpilih.Text = "Luas Persegi" Then
            tbSisi.Enabled = True
        ElseIf cbpilih.Text = "Luas Persegi Panjang" Then
            tbPanjang.Enabled = True
            tbLebar.Enabled = True
        ElseIf cbpilih.Text = "Luas Lingkaran" Then
            tbJari.Enabled = True
        ElseIf cbpilih.Text = "Luas Segitiga" Then
            tbAlas.Enabled = True
            tbTinggi.Enabled = True
        ElseIf cbpilih.Text = "Luas Trapesium" Then
            tbAtas.Enabled = True
            tbAlas.Enabled = True
        ElseIf cbpilih.Text = "Luas Layang Layang" Then
            tbDiagonal1.Enabled = True
            tbDiagonal2.Enabled = True
        ElseIf cbpilih.Text = "Luas Jajar Genjang" Then
            tbAlas.Enabled = True
            tbTinggi.Enabled = True
        End If
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, panjang, lebar, tinggi, alas, atas, jari, diagonal1, diagonal2, hasil As Single
        sisi = Val(tbSisi.Text)
        panjang = Val(tbPanjang.Text)
        lebar = Val(tbLebar.Text)
        tinggi = Val(tbTinggi.Text)
        alas = Val(tbAlas.Text)
        atas = Val(tbAtas.Text)
        jari = Val(tbJari.Text)
        diagonal1 = Val(tbDiagonal1.Text)
        diagonal2 = Val(tbDiagonal2.Text)


        If cbpilih.Text = "Luas Persegi" Then
            If cbSatuan.Text = "CM2" Then
                hasil = sisi * sisi
                tbHasil.Text = hasil
            Else
                hasil = sisi * sisi / 100
                tbHasil.Text = hasil
            End If

        ElseIf cbpilih.Text = "Luas Persegi Panjang" Then
            If cbSatuan.Text = "CM2" Then
                hasil = panjang * lebar
                tbHasil.Text = hasil
            Else
                hasil = panjang * lebar / 100
                tbHasil.Text = hasil
            End If

        ElseIf cbpilih.Text = "Luas Lingkaran" Then
            If cbSatuan.Text = "CM2" Then
                hasil = 3.14 * jari * jari
                tbHasil.Text = hasil
            Else
                hasil = 3.14 * jari * jari / 100
                tbHasil.Text = hasil
            End If

        ElseIf cbpilih.Text = "Luas Segitiga" Then
            If cbSatuan.Text = "CM2" Then
                hasil = 0.5 * alas * tinggi
                tbHasil.Text = hasil
            Else
                hasil = 0.5 * alas * tinggi / 100
                tbHasil.Text = hasil
            End If

        ElseIf cbpilih.Text = "Luas Trapesium" Then
            If cbSatuan.Text = "CM2" Then
                hasil = (alas + atas) / 2 * tinggi
                tbHasil.Text = hasil
            Else
                hasil = (alas + atas) / 2 * tinggi / 100
                tbHasil.Text = hasil
            End If

        ElseIf cbpilih.Text = "Luas Layang Layang" Then
            If cbSatuan.Text = "CM2" Then
                hasil = 0.5 * diagonal1 * diagonal2
                tbHasil.Text = hasil
            Else
                hasil = 0.5 * diagonal1 * diagonal2 / 100
                tbHasil.Text = hasil
            End If

        ElseIf cbpilih.Text = "Luas Jajar Genjang" Then
            If cbSatuan.Text = "CM2" Then
                hasil = alas * tinggi
                tbHasil.Text = hasil
            Else
                hasil = alas * tinggi / 100
                tbHasil.Text = hasil
            End If

        End If
    End Sub
End Class

Public Class Form1

    Sub reset()
        cbSatuan.Text = " "
        cbPilih.Text = " "
        tbSisi.Enabled = False
        tbSisi.Text = " "
        tbPanjang.Enabled = False
        tbPanjang.Text = " "
        tbLebar.Enabled = False
        tbLebar.Text = " "
        tbTinggi.Enabled = False
        tbTinggi.Clear()
        tbAlas.Enabled = False
        tbAlas.Clear()
        tbAtas.Enabled = False
        tbAtas.Clear()
        tbJari.Enabled = False
        tbJari.Clear()
        tbDiameter.Enabled = False
        tbDiameter.Clear()
        tbMiring.Enabled = False
        tbMiring.Clear()
        tbDiagonal1.Enabled = False
        tbDiagonal1.Clear()
        tbDiagonal2.Enabled = False
        tbDiagonal2.Clear()
        tbHasil.Enabled = False
        tbHasil.Clear()
        tbPersegi.Enabled = False
        tbPersegi.Clear()
        tbLingkaran.Enabled = False
        tbLingkaran.Clear()
        tbSegitiga.Enabled = False
        tbSegitiga.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call reset()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call reset()
        MessageBox.Show("Terhapus", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CbPilih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPilih.SelectedIndexChanged
        'luas
        If cbPilih.Text = "Luas Persegi" Then
            tbSisi.Enabled = True
        ElseIf cbPilih.Text = "Luas Persegi Panjang" Then
            tbPanjang.Enabled = True
            tbLebar.Enabled = True
        ElseIf cbPilih.Text = "Luas Trapesium" Then
            tbAlas.Enabled = True
            tbAtas.Enabled = True
            tbTinggi.Enabled = True
        ElseIf cbPilih.Text = "Luas Lingkaran" Then
            tbJari.Enabled = True
        ElseIf cbPilih.Text = " Luas Belah Ketupat" Then
            tbDiagonal1.Enabled = True
            tbDiagonal2.Enabled = True
        ElseIf cbPilih.Text = "Luas Jajar Genjang" Then
            tbAlas.Enabled = True
            tbTinggi.Enabled = True
        ElseIf cbPilih.Text = "Luas Layang-Layang" Then
            tbDiagonal1.Enabled = True
            tbDiagonal2.Enabled = True
        ElseIf cbPilih.Text = "Luas Segitiga" Then
            tbAlas.Enabled = True
            tbTinggi.Enabled = True
            'volume
        ElseIf cbPilih.Text = "Volume Kubus" Then
            tbSisi.Enabled = True
        ElseIf cbPilih.Text = "Volume Balok" Then
            tbPanjang.Enabled = True
            tbLebar.Enabled = True
            tbTinggi.Enabled = True
        ElseIf cbPilih.Text = "Volume Prisma" Then
            tbSegitiga.Enabled = True
            tbPersegi.Enabled = True
        ElseIf cbPilih.Text = "Volume Tabung" Then
            tbJari.Enabled = True
            tbTinggi.Enabled = True
        ElseIf cbPilih.Text = "Volume Limas" Then
            tbSegitiga.Enabled = True
            tbTinggi.Enabled = True
        End If
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, panjang, lebar, tinggi, alas, atas, jari, diameter, miring, diagonal1, diagonal2, hasil, persegi, lingkaran, segitiga As Single
        sisi = Val(tbSisi.Text)
        panjang = Val(tbPanjang.Text)
        lebar = Val(tbLebar.Text)
        tinggi = Val(tbTinggi.Text)
        alas = Val(tbAlas.Text)
        atas = Val(tbAtas.Text)
        jari = Val(tbJari.Text)
        diameter = Val(tbDiameter.Text)
        miring = Val(tbMiring.Text)
        diagonal1 = Val(tbDiagonal1.Text)
        diagonal2 = Val(tbDiagonal2.Text)
        persegi = Val(tbPersegi.Text)
        segitiga = Val(tbSegitiga.Text)
        lingkaran = Val(tbLingkaran.Text)
        hasil = Val(tbHasil.Text)
        'perhitungan dua dimensi
        If cbPilih.Text = "Luas Persegi" Then
            If cbSatuan.Text = "cm2" Then
                hasil = sisi * sisi
                tbHasil.Text = hasil
            ElseIf cbSatuan.text = "m2" Then
                hasil /= 100
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbpilih.text = "Luas Persegi Panjang" Then
            If cbSatuan.Text = "cm2" Then
                hasil = panjang * lebar
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m2" Then
                hasil /= 100
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbPilih.Text = "Luas Trapesium" Then
            If cbSatuan.Text = "cm2" Then
                hasil = (alas + atas) / 2 * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m2" Then
                hasil /= 100
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbpilih.text = "Luas Lingkaran" Then
            If cbSatuan.Text = "cm2" Then
                hasil = 3.14 * jari * jari
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m2" Then
                hasil /= 100
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbpilih.text = "Luas Belah Ketupat" Then
            If cbSatuan.Text = "cm2" Then
                hasil = 0.5 * diagonal1 * diagonal2
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m2" Then
                hasil /= 100
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbpilih.text = "Luas Jajar Genjang" Then
            If cbSatuan.Text = "cm2" Then
                hasil = alas * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m2" Then
                hasil /= 100
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbpilih.text = "Luas Layang-Layang" Then
            If cbSatuan.Text = "cm2" Then
                hasil = 0.5 * diagonal1 * diagonal2
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m2" Then
                hasil /= 100
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If



            'perhitungan 3 dimensi
        ElseIf cbpilih.text = "Volume Kubus" Then
            If cbSatuan.Text = "cm3" Then
                hasil = sisi * sisi * sisi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m3" Then
                hasil /= 1000000
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbPilih.Text = "Volume Balok" Then
            If cbSatuan.Text = "cm3" Then
                hasil = panjang * lebar * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m3" Then
                hasil /= 1000000
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbPilih.Text = "Volume Prisma" Then
            If cbSatuan.Text = "cm3" Then
                hasil = 4 * segitiga * persegi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m3" Then
                hasil /= 1000000
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbPilih.Text = "Volume Tabung" Then
            If cbSatuan.Text = "cm3" Then
                hasil = lingkaran * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m3" Then
                hasil /= 1000000
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If
        ElseIf cbPilih.Text = "Volume Limas" Then
            If cbSatuan.Text = "cm3" Then
                hasil = 0.3 * persegi * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "m3" Then
                hasil /= 1000000
                tbHasil.Text = hasil
            Else
                tbHasil.Text = "ERROR"
            End If

        End If
    End Sub
End Class

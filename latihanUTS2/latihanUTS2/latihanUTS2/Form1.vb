Public Class Form1
    Sub reset()
        cbpilih.Text = " "
        cbsatuan.Text = " "
        tbsisi.Clear()
        tbsisi.Enabled = False
        tbpanjang.Clear()
        tbpanjang.Enabled = False
        tblebar.Clear()
        tblebar.Enabled = False
        tbtinggi.Clear()
        tbtinggi.Enabled = False
        tbalas.Clear()
        tbalas.Enabled = False
        tbatas.Clear()
        tbatas.Enabled = False
        tbjari.Clear()
        tbjari.Enabled = False
        tbdiameter.Clear()
        tbdiameter.Enabled = False
        tbmiring.Clear()
        tbmiring.Enabled = False
        tbdiagonal1.Clear()
        tbdiagonal1.Enabled = False
        tbdiagonal2.Clear()
        tbdiagonal2.Enabled = False
        tbhasil.Clear()
        tbhasil.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call reset()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call reset()
        MessageBox.Show("Clear", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Cbpilih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpilih.SelectedIndexChanged
        If cbpilih.Text = "Luas Persegi" Then


            tbsisi.Enabled = True
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Clear()
            tbtinggi.Enabled = False
            tbalas.Clear()
            tbalas.Enabled = False
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Luas Persegi Panjang" Then


            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Enabled = True
            tblebar.Enabled = True
            tbtinggi.Clear()
            tbtinggi.Enabled = False
            tbalas.Clear()
            tbalas.Enabled = False
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Luas Trapesium" Then


            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Enabled = True
            tbalas.Clear()
            tbalas.Enabled = True
            tbatas.Enabled = True
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Luas Lingkaran" Then


            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Clear()
            tbtinggi.Enabled = False
            tbalas.Clear()
            tbalas.Enabled = False
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Enabled = True
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Luas Belah Ketupat" Then
            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Clear()
            tbtinggi.Enabled = False
            tbalas.Clear()
            tbalas.Enabled = False
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False

            tbdiagonal1.Enabled = True

            tbdiagonal2.Enabled = True
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Luas Jajar Genjang" Then


            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Enabled = True
            tbalas.Enabled = True
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Luas Layang Layang" Then


            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Clear()
            tbtinggi.Enabled = False
            tbalas.Clear()
            tbalas.Enabled = False
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Enabled = True
            tbdiagonal2.Enabled = True
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Luas Segitiga" Then

            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Enabled = True
            tbalas.Enabled = True
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Volume Kubus" Then

            tbsisi.Enabled = True
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Clear()
            tbtinggi.Enabled = False
            tbalas.Clear()
            tbalas.Enabled = False
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False

        ElseIf cbpilih.Text = "Volume Balok" Then
            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Enabled = True
            tblebar.Enabled = True
            tbtinggi.Enabled = True
            tbalas.Clear()
            tbalas.Enabled = False
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False

        ElseIf cbpilih.Text = "Volume Prisma" Then

            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Enabled = True
            tbalas.Enabled = True
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False
        ElseIf cbpilih.Text = "Volume Tambung" Then
            cbsatuan.Text = " "
            tbsisi.Clear()
            tbsisi.Enabled = False
            tbpanjang.Clear()
            tbpanjang.Enabled = False
            tblebar.Clear()
            tblebar.Enabled = False
            tbtinggi.Enabled = True
            tbalas.Enabled = True
            tbatas.Clear()
            tbatas.Enabled = False
            tbjari.Clear()
            tbjari.Enabled = False
            tbdiameter.Clear()
            tbdiameter.Enabled = False
            tbmiring.Clear()
            tbmiring.Enabled = False
            tbdiagonal1.Clear()
            tbdiagonal1.Enabled = False
            tbdiagonal2.Clear()
            tbdiagonal2.Enabled = False
            tbhasil.Clear()
            tbhasil.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sisi, panjang, lebar, tinggi, alas, atas, jari, diameter, miring, diag1, diag2, hasil As Single
        sisi = Val(tbsisi.Text)
        panjang = Val(tbpanjang.Text)
        lebar = Val(tblebar.Text)
        tinggi = Val(tbtinggi.Text)
        alas = Val(tbalas.Text)
        atas = Val(tbatas.Text)
        jari = Val(tbjari.Text)
        diameter = Val(tbdiameter.Text)
        miring = Val(tbmiring.Text)
        diag1 = Val(tbdiagonal1.Text)
        diag2 = Val(tbdiagonal2.Text)

        'if
        If cbpilih.Text = "Luas Persegi" Then
            If cbsatuan.Text = "CM2" Then
                hasil = sisi * sisi
                tbhasil.Text = hasil
            Else
                hasil = sisi * sisi / 100
                tbhasil.Text = hasil
            End If
        ElseIf cbpilih.Text = "Luas Persegi Panjang" Then
            If cbsatuan.Text = "CM2" Then
                hasil = panjang * lebar
                tbhasil.Text = hasil
            Else
                hasil = panjang * lebar / 100
                tbhasil.Text = hasil
            End If
        ElseIf cbpilih.Text = "Luas Trapesium" Then
            If cbsatuan.Text = "CM2" Then
                hasil = (alas + atas) / 2 * tinggi
                tbhasil.Text = hasil
            Else
                hasil = (alas + atas) / 2 * tinggi / 100
                tbhasil.Text = hasil

            End If
        ElseIf cbpilih.Text = "Luas Lingkaran" Then
            If cbsatuan.Text = "CM2" Then
                hasil = 3.14 * jari * jari
                tbhasil.Text = hasil
            Else
                hasil = 3.14 * jari * jari / 100
                tbhasil.Text = hasil
            End If
        ElseIf cbpilih.Text = "Luas Belah Ketupat" Then
            If cbsatuan.Text = "CM2" Then
                hasil = diag1 * diag2
                tbhasil.Text = hasil
            Else
                hasil = diag1 * diag2 / 100
                tbhasil.Text = hasil
            End If
        ElseIf cbpilih.Text = "Luas Jajar Genjang" Then
            If cbsatuan.Text = "CM2" Then
                hasil = alas * tinggi
                tbhasil.Text = hasil
            Else
                hasil = alas * tinggi / 100
                tbhasil.Text = hasil
            End If
        ElseIf cbpilih.Text = "Luas Layang Layang" Then
            If cbsatuan.Text = "CM2" Then
                hasil = diag1 * diag2
                tbhasil.Text = hasil
            Else
                hasil = diag1 * diag2 / 100
                tbhasil.Text = hasil
            End If
        ElseIf cbpilih.Text = "Luas Segitiga" Then
            If cbsatuan.Text = "CM2" Then
                hasil = 0.5 * alas * tinggi
                tbhasil.Text = hasil
            Else
                hasil = 0.5 * alas * tinggi / 100
                tbhasil.Text = hasil
            End If
        Else
            MessageBox.Show("Input atau satuan salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class

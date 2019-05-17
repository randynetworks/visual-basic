Public Class luaskeliling

    Sub reset()
        cbSatuan.Text = " "
        lbKet.Text = " "
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
        tbDiameter.Clear()
        tbDiameter.Enabled = False
        tbDiagonal1.Clear()
        tbDiagonal1.Enabled = False
        tbDiagonal2.Clear()
        tbDiagonal2.Enabled = False
        tbMiring.Clear()
        tbMiring.Enabled = False
        tbA.Clear()
        tbA.Enabled = False
        tbB.Clear()
        tbB.Enabled = False
        tbC.Clear()
        tbC.Enabled = False
        tbD.Clear()
        tbD.Enabled = False
        tbHasil.Clear()
        tbHasil.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call reset()
        cbPilih.Text = " "
    End Sub

    Private Sub Luaskeliling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call reset()
    End Sub

    Private Sub CbPilih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPilih.SelectedIndexChanged


        If cbPilih.Text = "L. PERSEGI" Then
            Call reset()
            cbPilih.Text = "L. PERSEGI"
            lbKet.Text = "Sisi"
            tbSisi.Enabled = True

        ElseIf cbPilih.Text = "L. PERSEGI PANJANG" Then
            Call reset()
            cbPilih.Text = "L. PERSEGI PANJANG"
            lbKet.Text = "Panjang dan Lebar"
            tbPanjang.Enabled = True
            tbLebar.Enabled = True

        ElseIf cbPilih.Text = "L. TRAPESIUM" Then
            Call reset()
            cbPilih.Text = "L. TRAPESIUM"
            lbKet.Text = "Alas, Atas dan Tinggi"
            tbTinggi.Enabled = True
            tbAlas.Enabled = True
            tbAtas.Enabled = True

        ElseIf cbPilih.Text = "L. LINGKARAN" Then
            Call reset()
            cbPilih.Text = "L. LINGKARAN"
            lbKet.Text = "Jari"
            tbJari.Enabled = True

        ElseIf cbPilih.Text = "L. BELAH KETUPAT" Then
            Call reset()
            cbPilih.Text = "L. BELAH KETUPAT"
            lbKet.Text = "Diagonal 1 dan Diagonal 2"
            tbDiagonal1.Enabled = True
            tbDiagonal2.Enabled = True
        ElseIf cbPilih.Text = "L. JAJAR GENJANG" Then
            Call reset()
            cbPilih.Text = "L. JAJAR GENJANG"
            lbKet.Text = "Alas dan Tinggi"
            tbTinggi.Enabled = True
            tbAlas.Enabled = True

        ElseIf cbPilih.Text = "L. LAYANG LAYANG" Then
            Call reset()
            cbPilih.Text = "L. LAYANG LAYANG"
            lbKet.Text = "Diagonal 1 dan Diagonal 2"
            tbDiagonal1.Enabled = True
            tbDiagonal2.Enabled = True

        ElseIf cbPilih.Text = "L. SEGITIGA" Then
            Call reset()
            cbPilih.Text = "L. SEGITIGA"
            lbKet.Text = "Alas dan Tinggi"
            tbAlas.Enabled = True
            tbTinggi.Enabled = True

        ElseIf cbPilih.Text = "K. PERSEGI" Then
            Call reset()
            cbPilih.Text = "K. PERSEGI"
            lbKet.Text = "Sisi"
            tbSisi.Enabled = True
        ElseIf cbPilih.Text = "K. PERSEGI PANJANG" Then
            Call reset()
            cbPilih.Text = "K. PERSEGI PANJANG"
            lbKet.Text = "Panjang dan Lebar"
            tbPanjang.Enabled = True
            tbLebar.Enabled = True

        ElseIf cbPilih.Text = "K. TRAPESIUM" Then
            Call reset()
            cbPilih.Text = "K. TRAPESIUM"
            lbKet.Text = " Tambahan : a, b , c dan d"
            tbA.Enabled = True
            tbB.Enabled = True
            tbC.Enabled = True
            tbD.Enabled = True

        ElseIf cbPilih.Text = "K. LINGKARAN" Then
            Call reset()
            cbPilih.Text = "K. LINGKARAN"
            lbKet.Text = "Diameter"
            tbDiameter.Enabled = True

        ElseIf cbPilih.Text = "K. BELAH KETUPAT" Then
            Call reset()
            cbPilih.Text = "K. BELAH KETUPAT"
            lbKet.Text = "Sisi"
            tbSisi.Enabled = True

        ElseIf cbPilih.Text = "K. JAJAR GENJANG" Then
            Call reset()
            cbPilih.Text = "K. JAJAR GENJANG"
            lbKet.Text = " Tambahan : a, b , c dan d"
            tbA.Enabled = True
            tbB.Enabled = True
            tbC.Enabled = True
            tbD.Enabled = True

        ElseIf cbPilih.Text = "K. LAYANG LAYANG" Then
            Call reset()
            cbPilih.Text = "K. LAYANG LAYANG"
            lbKet.Text = " Tambahan : a, b , c dan d"
            tbA.Enabled = True
            tbB.Enabled = True
            tbC.Enabled = True
            tbD.Enabled = True

        ElseIf cbPilih.Text = "K. SEGITIGA" Then
            Call reset()
            cbPilih.Text = "K. SEGITIGA"
            lbKet.Text = " Tambahan : a, b dan c"
            tbA.Enabled = True
            tbB.Enabled = True
            tbC.Enabled = True
        End If
    End Sub
    '======================================== input ================================
    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim a, b, c, d, sisi, panjang, lebar, tinggi, alas, atas, jari, diameter, miring, diag1, diag2, hasil As Double
        sisi = Val(tbSisi.Text)
        panjang = Val(tbPanjang.Text)
        lebar = Val(tbLebar.Text)
        tinggi = Val(tbTinggi.Text)
        alas = Val(tbAlas.Text)
        atas = Val(tbAtas.Text)
        jari = Val(tbJari.Text)
        diameter = Val(tbDiameter.Text)
        miring = Val(tbMiring.Text)
        diag1 = Val(tbDiagonal1.Text)
        diag2 = Val(tbDiagonal2.Text)
        hasil = Val(tbHasil.Text)
        a = Val(tbA.Text)
        b = Val(tbB.Text)
        c = Val(tbC.Text)
        d = Val(tbD.Text)
        ' ==================================== LUAS ===============================================
        If cbPilih.Text = "L. PERSEGI" Then
            If cbSatuan.Text = "CM2" Then
                hasil = sisi * sisi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M2" Then
                hasil = sisi * sisi / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "L. PERSEGI PANJANG" Then
            If cbSatuan.Text = "CM2" Then
                hasil = panjang * lebar
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M2" Then
                hasil = panjang * lebar / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "L. TRAPESIUM" Then
            If cbSatuan.Text = "CM2" Then
                hasil = (alas + atas) / 2 * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M2" Then
                hasil = (alas + atas) / 2 * tinggi / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf cbPilih.Text = "L. LINGKARAN" Then
            If cbSatuan.Text = "CM2" Then
                hasil = 3.14 * jari
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M2" Then
                hasil = 3.14 * jari / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "L. BELAH KETUPAT" Then
            If cbSatuan.Text = "CM2" Then
                hasil = diag1 * diag2 / 2
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M2" Then
                hasil = diag1 * diag2 / 2 / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf cbPilih.Text = "L. JAJAR GENJANG" Then
            If cbSatuan.Text = "CM2" Then
                hasil = alas * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M2" Then
                hasil = alas * tinggi / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "L. LAYANG LAYANG" Then
            If cbSatuan.Text = "CM2" Then
                hasil = diag1 * diag2 / 2
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M2" Then
                hasil = diag1 * diag2 / 2 / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "L. SEGITIGA" Then
            If cbSatuan.Text = "CM2" Then
                hasil = alas * tinggi / 2
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M2" Then
                hasil = alas * tinggi / 2 / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' ==================================== KELILING ===============================================
        ElseIf cbPilih.Text = "K. PERSEGI" Then
            If cbSatuan.Text = "CM" Then
                hasil = 4 * sisi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M" Then
                hasil = 4 * sisi / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf cbPilih.Text = "K. PERSEGI PANJANG" Then
            If cbSatuan.Text = "CM" Then
                hasil = (2 * panjang) + (2 * lebar)
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M" Then
                hasil = (2 * panjang) + (2 * lebar) / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf cbPilih.Text = "K. TRAPESIUM" Then
            If cbSatuan.Text = "CM" Then
                hasil = a + b + c + d
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M" Then
                hasil = a + b + c + d / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf cbPilih.Text = "K. LINGKARAN" Then
            If cbSatuan.Text = "CM" Then
                hasil = diameter * 3.14
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M" Then
                hasil = diameter * 3.14 / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "K. BELAH KETUPAT" Then
            If cbSatuan.Text = "CM" Then
                hasil = 4 * sisi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M" Then
                hasil = 4 * sisi / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "K. JAJAR GENJANG" Then
            If cbSatuan.Text = "CM" Then
                hasil = a + b + c + d
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M" Then
                hasil = a + b + c + d / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "K. LAYANG LAYANG" Then
            If cbSatuan.Text = "CM" Then
                hasil = a + b + c + d
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M" Then
                hasil = a + b + c + d / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "K. SEGITIGA" Then
            If cbSatuan.Text = "CM" Then
                hasil = a + b + c
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M" Then
                hasil = a + b + c / 100
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Masukan Pilihan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
End Class
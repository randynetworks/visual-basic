Public Class Volume
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
        tbLPersegi.Clear()
        tbLPersegi.Enabled = False
        tbLSegitiga.Clear()
        tbLSegitiga.Enabled = False
        tbLLingkaran.Clear()
        tbLLingkaran.Enabled = False
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

    Private Sub CbPilih_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPilih.SelectedIndexChanged
        If cbPilih.Text = "V. KUBUS" Then
            Call reset()
            cbPilih.Text = "V. KUBUS"
            lbKet.Text = "Sisi"
            tbSisi.Enabled = True

        ElseIf cbPilih.Text = "V. BALOK" Then
            Call reset()
            cbPilih.Text = "V. BALOK"
            lbKet.Text = "Panjang, Lebar Dan Tinggi"
            tbPanjang.Enabled = True
            tbLebar.Enabled = True
            tbTinggi.Enabled = True

        ElseIf cbPilih.Text = "V. PRISMA" Then
            Call reset()
            cbPilih.Text = "V. PRISMA"
            lbKet.Text = "Luas Segitiga dan Tinggi"
            tbTinggi.Enabled = True
            tbLSegitiga.Enabled = True

        ElseIf cbPilih.Text = "V. TABUNG" Then
            Call reset()
            cbPilih.Text = "V. TABUNG"
            lbKet.Text = "Luas Lingkaran dan Tinggi"
            tbLLingkaran.Enabled = True
            tbTinggi.Enabled = True

        ElseIf cbPilih.Text = "V. LIMAS" Then
            Call reset()
            cbPilih.Text = "V. LIMAS"
            lbKet.Text = "Luas Persegi dan Tinggi"
            tbLPersegi.Enabled = True
            tbTinggi.Enabled = True
        End If
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim persegi, segitiga, lingkaran, sisi, panjang, lebar, tinggi, alas, atas, jari, diameter, miring, diag1, diag2, hasil As Double
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
        persegi = Val(tbLPersegi.Text)
        segitiga = Val(tbLSegitiga.Text)
        lingkaran = Val(tbLLingkaran.Text)

        If cbPilih.Text = "V. KUBUS" Then
            If cbSatuan.Text = "CM3" Then
                hasil = sisi * sisi * sisi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M3" Then
                hasil = sisi * sisi * sisi / 1000000
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf cbPilih.Text = "V. BALOK" Then
            If cbSatuan.Text = "CM3" Then
                hasil = panjang * lebar * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M3" Then
                hasil = sisi * sisi * sisi / 1000000
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf cbPilih.Text = "V. PRISMA" Then
            If cbSatuan.Text = "CM3" Then
                hasil = panjang * lebar * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M3" Then
                hasil = lingkaran * tinggi / 1000000
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "V. TABUNG" Then
            If cbSatuan.Text = "CM3" Then
                hasil = lingkaran * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M3" Then
                hasil = lingkaran * tinggi / 1000000
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf cbPilih.Text = "V. LIMAS" Then
            If cbSatuan.Text = "CM3" Then
                hasil = persegi * tinggi
                tbHasil.Text = hasil
            ElseIf cbSatuan.Text = "M3" Then
                hasil = persegi * tinggi / 1000000
                tbHasil.Text = hasil
            Else
                MessageBox.Show("Periksa Kembali satuan atau angka yang dimasukan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Masukan Pilihan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub Volume_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call reset()
    End Sub
End Class
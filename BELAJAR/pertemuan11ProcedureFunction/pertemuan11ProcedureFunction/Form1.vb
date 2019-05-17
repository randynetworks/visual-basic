Public Class ProcedureFunction
    Sub bersih()
        tbKode.Text = ""
        tbNama.Text = ""
        tbSatuan.Text = ""
        tbHarga.Text = ""
        tbTotal.Text = ""
        tbJumlah.Text = ""
        tbKode.Focus()
        tbTotal.Enabled = False

    End Sub
    Private Sub ProcedureFunction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call bersih()
    End Sub

    Private Function hitung()
        Dim jumlah, hargaSatuan, total As Integer
        jumlah = tbJumlah.Text
        hargaSatuan = tbHarga.Text
        total = jumlah * hargaSatuan
        tbTotal.Text = total
        Return total
    End Function
    Sub cekDataKosong()
        If tbKode.Text = "" Then
            MessageBox.Show("Kode Barang Harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbKode.Focus()
        ElseIf tbNama.Text = "" Then
            MessageBox.Show("Nama Barang Harus di isi", "konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbNama.Focus()
        ElseIf tbSatuan.Text = "" Then
            MessageBox.Show("Satuan Barang Harus di isi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbSatuan.Focus()
        ElseIf tbHarga.Text = "" Then
            MessageBox.Show("Harga Satuan Barang Harus di isi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbHarga.Focus()
        ElseIf tbJumlah.Text = "" Then
            MessageBox.Show("Jumlah Barang Harus di isi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbJumlah.Focus()
        Else
            Call hitung()
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Call cekDataKosong()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim tutup As String
        tutup = MessageBox.Show("Mau Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class

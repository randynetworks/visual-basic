Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        tbKode.Clear()
        tbNama.Clear()
        tbAlamat.Clear()
        tbTanggal.Text = Today
        cbJenis.Text = ""
        tbHarga.Clear()
        tbJumlah.Clear()
        tbSub.Clear()
        tbPotongan.Clear()
        tbSubGrand.Clear()
        tbPajak.Clear()
        tbGrand.Clear()

    End Sub
    Private Sub CbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        If cbJenis.Text = "CPU" Then
            tbHarga.Text = 6000000
        ElseIf cbJenis.Text = "MONITOR LG" Then
            tbHarga.Text = 800000
        ElseIf cbJenis.Text = "MOUSE" Then
            tbHarga.Text = 30000
        ElseIf cbJenis.Text = "KEYBOARD" Then
            tbHarga.Text = 70000
        ElseIf cbJenis.Text = "PRINTER" Then
            tbHarga.Text = 400000
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTanggal.Text = Today
    End Sub

    Private Sub TbJumlah_TextChanged(sender As Object, e As EventArgs) Handles tbJumlah.TextChanged
        tbSub.Text = Val(tbJumlah.Text) * Val(tbHarga.Text)
    End Sub

    Private Sub TbSub_TextChanged(sender As Object, e As EventArgs) Handles tbSub.TextChanged
        tbPotongan.Text = Val(tbSub.Text) * 0.1
    End Sub

    Private Sub TbPotongan_TextChanged(sender As Object, e As EventArgs) Handles tbPotongan.TextChanged
        tbSubGrand.Text = Val(tbSub.Text) - Val(tbPotongan.Text)
    End Sub

    Private Sub TbSubGrand_TextChanged(sender As Object, e As EventArgs) Handles tbSubGrand.TextChanged
        tbPajak.Text = Val(tbSubGrand.Text) * 0.1
    End Sub

    Private Sub TbPajak_TextChanged(sender As Object, e As EventArgs) Handles tbPajak.TextChanged
        tbGrand.Text = Val(tbSubGrand.Text) + Val(tbPajak.Text)
    End Sub
End Class

Public Class kisikisi

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        txtKode.Clear()
        txtTanggal.Text = Today
        cbJenis.Text = " "
        txtHarga.Clear()
        txtPotongan.Clear()
        txtSub.Clear()
        txtPajak.Clear()
        txtTotal.Clear()
        MessageBox.Show("Data Baru", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        If cbJenis.Text = "HONDA" Then
            txtHarga.Text = 15000000
        ElseIf cbJenis.Text = "SUZUKI" Then
            txtHarga.Text = 17500000
        ElseIf cbJenis.Text = "KAWASAKI" Then
            txtHarga.Text = 930303
        ElseIf cbJenis.Text = "YAMAHA" Then
            txtHarga.Text = 21000000
        End If
    End Sub
    Private Sub TxtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged
        txtPotongan.Text = Val(txtHarga.Text) * 0.005
    End Sub
    Private Sub TxtPotongan_TextChanged(sender As Object, e As EventArgs) Handles txtPotongan.TextChanged
        txtSub.Text = Val(txtHarga.Text) - Val(txtPotongan.Text)
    End Sub

    Private Sub Kisikisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTanggal.Text = Today
    End Sub

    Private Sub TxtSub_TextChanged(sender As Object, e As EventArgs) Handles txtSub.TextChanged
        txtPajak.Text = Val(txtSub.Text) * 0.1
    End Sub

    Private Sub TxtPajak_TextChanged(sender As Object, e As EventArgs) Handles txtPajak.TextChanged
        txtTotal.Text = Val(txtSub.Text) + Val(txtPajak.Text)
    End Sub
End Class

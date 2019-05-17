Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    'menghapus data
    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        input1.Clear()
        input2.Clear()
        inputAngka.Clear()
        hasil.Clear()
        jenis.Text = " "
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'perhitungan sederhana
    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        If jenis.Text = "PENJUMLAHAN" Then
            hasil.Text = Val(input1.Text) + Val(input2.Text)
        ElseIf jenis.Text = "PENGURANGAN" Then
            hasil.Text = Val(input1.Text) - Val(input2.Text)
        ElseIf jenis.Text = "PERKALIAN" Then
            hasil.Text = Val(input1.Text) * Val(input2.Text)
        ElseIf jenis.Text = "PEMBAGIAN" Then
            hasil.Text = Val(input1.Text) / Val(input2.Text)
        End If
    End Sub
    'mengecek kondisi angka genap dan ganjil
    Private Sub Cek_Click(sender As Object, e As EventArgs) Handles cek.Click
        Dim angka As Integer
        angka = Val(inputAngka.Text)
        If angka Mod 2 = 0 Then
            MsgBox("Ini angka Genap")
        Else
            MsgBox("Ini angka Ganjil")
        End If

    End Sub
End Class

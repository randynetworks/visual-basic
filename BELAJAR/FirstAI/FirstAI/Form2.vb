Public Class kalkulatorsimple


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim angka1, angka2, jumlah As Double
        angka1 = Val(tbAngka1.Text)
        angka2 = Val(tbAngka2.Text)
        jumlah = angka1 + angka2
        tbHasil.Text = jumlah
        tbAngka1.Focus()

    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click

        Dim angka1, angka2, jumlah As Double
        angka1 = Val(tbAngka1.Text)
        angka2 = Val(tbAngka2.Text)
        jumlah = angka1 - angka2
        tbHasil.Text = jumlah
        tbAngka1.Focus()
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click

        Dim angka1, angka2, jumlah As Double
        angka1 = Val(tbAngka1.Text)
        angka2 = Val(tbAngka2.Text)
        jumlah = angka1 * angka2
        tbHasil.Text = jumlah
        tbAngka1.Focus()
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click

        Dim angka1, angka2, jumlah As Double
        angka1 = Val(tbAngka1.Text)
        angka2 = Val(tbAngka2.Text)
        jumlah = angka1 / angka2
        tbHasil.Text = jumlah
        tbAngka1.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        tbAngka1.Clear()
        tbAngka2.Clear()
        tbHasil.Clear()
    End Sub
End Class
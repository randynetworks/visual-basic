Public Class frmHitungNilai
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim TatapMuka, MidTest, FinalTest, Hasil As Double
        TatapMuka = Val(tbTatapMuka.Text)
        MidTest = Val(tbMidTest.Text)
        FinalTest = Val(tbFinalTest.Text)
        Hasil = (TatapMuka + MidTest + FinalTest) / 3
        tbHasil.Text = Hasil
    End Sub
End Class

Public Class Form3

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub BtnPasien_Click(sender As Object, e As EventArgs) Handles btnPasien.Click
        Form1.Show()
    End Sub

    Private Sub DataPenyakit_Click(sender As Object, e As EventArgs) Handles dataPenyakit.Click
        Form2.Show()
    End Sub

    Private Sub DataDokter_Click(sender As Object, e As EventArgs) Handles DataDokter.Click
        Form4.Show()
    End Sub
End Class
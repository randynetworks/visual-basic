Public Class Frmcoba
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show(txtnama.Text & cboJenisKelamin.Text & cboFakultas.Text,
                        "Hasil Input", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class

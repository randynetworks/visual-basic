Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
        If cbPilih.Text = "=== PERHITUNGAN LUAS KELILING ===" Then
            luaskeliling.Show()
            cbPilih.Text = " "
        ElseIf cbPilih.Text = "=== PERHITUNGAN VOLUME ===" Then
            Volume.Show()
            cbPilih.Text = " "
        ElseIf cbPilih.Text = "=== PERHITUNGAN ARITMATIKA ===" Then
            aritmatika.Show()
            cbPilih.Text = " "
        Else
            MessageBox.Show("Error, masukan Pilihan perhitungan!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class

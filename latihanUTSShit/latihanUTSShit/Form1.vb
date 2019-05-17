Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        kode.Clear()
        nama.Clear()
        alamat.Clear()
        cbjenis.Text = " "
        harga.Clear()
        potongan.Clear()
        total.Clear()
    End Sub

    Private Sub Cbjenis_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cbjenis.Text = "MONITOR" Then
            harga.Text = 5000000
        ElseIf cbjenis.Text = "CPU" Then
            harga.Text = 15000000
        ElseIf cbjenis.Text = "MOUSE" Then
            harga.Text = 500000
        ElseIf cbjenis.Text = "KEYBOARD" Then
            harga.Text = 1000000
        End If
    End Sub

    Private Sub Harga_TextChanged(sender As Object, e As EventArgs)
        potongan.Text = Val(harga.Text) * 0.1
    End Sub

    Private Sub Potongan_TextChanged(sender As Object, e As EventArgs)
        total.Text = Val(harga.Text) - Val(potongan.Text)
    End Sub
End Class

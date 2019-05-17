Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbkali.Text = Val(tbAngka1.Text) * Val(tbAngka2.Text)
        tbbagi.Text = Val(tbAngka1.Text) / Val(tbAngka2.Text)
        tbkurang.Text = Val(tbAngka1.Text) - Val(tbAngka2.Text)
        tbtambah.Text = Val(tbAngka1.Text) + Val(tbAngka2.Text)
    End Sub
End Class

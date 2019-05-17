Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbHasil.Text = Val(tbAngka1.Text) * Val(tbAngka2.Text)
    End Sub

    Private Sub TbClear_Click(sender As Object, e As EventArgs) Handles tbClear.Click
        tbHasil.Clear()
        tbAngka1.Clear()
        tbAngka2.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tbHasil.Text = Val(tbAngka1.Text) / Val(tbAngka2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tbHasil.Text = Val(tbAngka1.Text) + Val(tbAngka2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tbHasil.Text = Val(tbAngka1.Text) - Val(tbAngka2.Text)
    End Sub
End Class

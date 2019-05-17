Public Class aritmatika
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cbOperator.Text = "KALI" Then
            hasil.Text = Val(tb1.Text) * Val(tb2.Text)
        ElseIf cbOperator.Text = "BAGI" Then
            hasil.Text = Val(tb1.Text) / Val(tb2.Text)
        ElseIf cbOperator.Text = "KURANG" Then
            hasil.Text = Val(tb1.Text) - Val(tb2.Text)
        ElseIf cbOperator.Text = "TAMBAH" Then
            hasil.Text = Val(tb1.Text) + Val(tb2.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tb1.Clear()
        tb2.Clear()
        hasil.Clear()
        cbOperator.Text = " "

    End Sub
End Class
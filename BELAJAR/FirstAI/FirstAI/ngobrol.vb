Public Class ngobrol

    Private Sub BtnAyo_Click(sender As Object, e As EventArgs) Handles btnAyo.Click
        Dim tombol As MsgBoxResult
        If cbPertanyaan.Text = "Hari ini ngapain?" Then
            tombol = MessageBox.Show("haloo, hari ini mu ngapain?", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If tombol = MsgBoxResult.Ok Then
                inputNgobrol.Show()
                Me.Hide()
            End If
        ElseIf cbPertanyaan.Text = "Udah makan belum?" Then
            tombol = MessageBox.Show("Kamu udah makan belum?", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If tombol = MsgBoxResult.Ok Then
                inputNgobrol.Show()
                Me.Hide()
            End If
        ElseIf cbPertanyaan.Text = "Mau pergi kemana hari ini?" Then
            tombol = MessageBox.Show("klo hari ini kamu mau pergi kemana?", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If tombol = MsgBoxResult.Ok Then
                inputNgobrol.Show()
                Me.Hide()
            End If
        ElseIf cbPertanyaan.Text = "Suasananya gimana disana?" Then
            tombol = MessageBox.Show("Di tempat alex selalu sejuk, karena disini Alex pake Cooler hehe, gimana disana? ", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If tombol = MsgBoxResult.Ok Then
                inputNgobrol.Show()
                Me.Hide()
            End If
        End If
    End Sub
End Class
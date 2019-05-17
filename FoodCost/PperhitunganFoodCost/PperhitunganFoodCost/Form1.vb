Public Class main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbCataogry.SelectedIndex = -1
        tbPorsi.Clear()
        tbTotal.Clear()
        tbCost.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub tbTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTotal.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub tbPorsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPorsi.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub btnEntry_Click(sender As Object, e As EventArgs) Handles btnEntry.Click

        If cbCataogry.Text = "Food" Then

            tbCost.Text = Val(tbTotal.Text) * 100 / Val(tbPorsi.Text) + 0.1 * Val(tbTotal.Text)

        ElseIf cbCataogry.Text = "Beverage" Then
            tbCost.Text = Val(tbTotal.Text) * 100 / Val(tbPorsi.Text) + 0.05 * Val(tbTotal.Text)
        Else
            MsgBox("Wrong Input!", MsgBoxStyle.Critical, "Error!")
        End If

    End Sub


End Class

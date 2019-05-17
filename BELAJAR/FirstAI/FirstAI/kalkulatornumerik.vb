Public Class kalkulatornumerik

    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles  btnClear.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btn0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
        If button.Name = "btn1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
        If button.Name = "btn2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
        If button.Name = "btn3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
        If button.Name = "btn4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
        If button.Name = "btn5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
        If button.Name = "btn6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
        If button.Name = "btn7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
        If button.Name = "btn8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
        If button.Name = "btn9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
        If button.Name = "btnTambah" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If
        If button.Name = "btnKurang" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If
        If button.Name = "btnKali" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If
        If button.Name = "btnBagi" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If
        If button.Name = "btnTitik" Then
            TextBox1.Text = TextBox1.Text + "."
        End If
        If button.Name = "btnHapus" Then
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
        If button.Name = "btnHasil" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result
        End If
    End Sub
End Class
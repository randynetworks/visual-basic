
Public Class main
    Private ngorol As Object

    Sub obrolan()
        ngobrol.Show()
        Me.Hide()
    End Sub
    Sub perintah()
        tbInput.Clear()
        tbInput.Focus()
    End Sub

    Sub perkenalan()
        Dim user As String
        Dim input As String
        user = tbNama.Text
        input = tbInput.Text
        MessageBox.Show("Perkenalkan Saya Alex, saya adalah Artificial Intelegent, saya akan menjadi teman ngobrol " & user & " Dalam beberapa waktu kedepan. Semoga " & user & " dapat terhibur dengan saya :D", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub datedantime()
        MessageBox.Show("hari ini adalah " & DateTime.Today.ToString("dddd, dd MMMM yyyy"), "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub lagiapa()
        Dim user As String
        Dim input As String
        user = tbNama.Text
        input = tbInput.Text
        MessageBox.Show("Saya sedang mencoba berinteraksi dengan " & user & " cobalah untuk menanyakan sesuatu lagi!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub waktu()
        Dim user As String
        Dim input As String
        user = tbNama.Text
        input = tbInput.Text
        MessageBox.Show("Sekarang jam di Laptop " & user & " yaitu, Jam " & TimeOfDay.ToString("h:mm"), "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub makan()
        Dim user As String
        Dim input As String
        user = tbNama.Text
        input = tbInput.Text
        MessageBox.Show("Maaf Alex engga bisa makan hehe :D, Alex hanya program, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub pernyataanCinta()
        Dim user As String
        Dim input As String
        user = tbNama.Text
        input = tbInput.Text
        MessageBox.Show("terima kasih " & user & ", Alex sangat menghargai semua itu, tapi maaf Alex hanyalah sebuah program :D", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub apakabar()
        MessageBox.Show("Baik baik saja, terima kasih sudah bertanya kepada Alex", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub adaYangMarah()
        MessageBox.Show("Engga ada kok :D, Alex masih jomblo da hehe", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub nanyaMakan()
        Dim user As String
        user = tbNama.Text

        Dim hasil As DialogResult = MessageBox.Show("Kalo " & user & " udah makan?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            MessageBox.Show("Syukurlah kalo " & user & " udah makan", "output", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show("yahhh Alex suapin aaaaaaaaaa ", "output", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        tbNama.Clear()
        tbInput.Clear()
    End Sub



    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim user As String
        Dim input As String
        user = tbNama.Text
        input = tbInput.Text



        'warning sessage
        If user = "" Then
            MessageBox.Show("Masukan Nama kamu dulu!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf input = "" Then
            MessageBox.Show("Masukan perintah kamu!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'start sapaan
        ElseIf input = "halo" Then
            MessageBox.Show("Halo, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perkenalan()
            Call datedantime()
            Call perintah()
        ElseIf input = "hello" Then

            MessageBox.Show("Hello, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perkenalan()
            Call datedantime()
            Call perintah()
            'end hallo

        ElseIf input = "pagi" Then
            MessageBox.Show("Selamat " & input & ", " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perkenalan()
            Call datedantime()
            Call perintah()
        ElseIf input = "selamat pagi" Then
            MessageBox.Show("Selamat Pagi, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perkenalan()
            Call datedantime()
            Call perintah()
            'end pagi

        ElseIf input = "siang" Then
            MessageBox.Show("Selamat Siang, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perkenalan()
            Call datedantime()
            Call perintah()
        ElseIf input = "selamat siang" Then
            MessageBox.Show("Selamat Siang, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perkenalan()
            Call datedantime()
            Call perintah()
            'end siang

        ElseIf input = "malam" Then
            MessageBox.Show("Selamat Malam, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perkenalan()
            Call datedantime()
            Call perintah()
        ElseIf input = "selamat malam" Then
            MessageBox.Show("Selamat Malam, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perkenalan()
            Call datedantime()
            Call perintah()
            'end sapaan

            'start terimakasih
        ElseIf input = "terima kasih" Then
            MessageBox.Show("sama sama, " & user, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call perintah()
            'end terimakasih

            'start lagiapa
        ElseIf input = "lagi apa?" Then
            Call lagiapa()
            Call perintah()
        ElseIf input = "lagi apa" Then
            Call lagiapa()
            Call perintah()
            'end lagiapa

            'tentang AI
        ElseIf input = "apa itu kamu?" Then
            Call perkenalan()
            Call perintah()
        ElseIf input = "apa itu kamu" Then
            Call perkenalan()
            Call perintah()
        ElseIf input = "kamu itu apa?" Then
            Call perkenalan()
            Call perintah()
        ElseIf input = "kamu itu apa" Then
            Call perkenalan()
            Call perintah()
        ElseIf input = "siapa kamu?" Then
            Call perkenalan()
            Call perintah()
        ElseIf input = "siapa kamu" Then
            Call perkenalan()
            Call perintah()
        ElseIf input = "kamu siapa?" Then
            Call perkenalan()
            Call perintah()
        ElseIf input = "kamu siapa" Then
            Call perkenalan()
            Call perintah()
            'end tetang AI

            'waktu
        ElseIf input = "jam berapa sekarang?" Then
            Call waktu()
            Call perintah()
        ElseIf input = "jam berapa sekarang" Then
            Call waktu()
            Call perintah()
        ElseIf input = "jam" Then
            Call waktu()
            Call perintah()
        ElseIf input = "hari apa ini?" Then
            Call datedantime()
            Call perintah()
        ElseIf input = "hari apa ini" Then
            Call datedantime()
            Call perintah()
            'end waktu

            'start pernyataan cinta
        ElseIf input = "aku sayang kamu" Then
            Call pernyataanCinta()
        ElseIf input = "aku cinta kamu" Then
            Call pernyataanCinta()
            'end pernyataan cinta

            'start makan
        ElseIf input = "udah makan?" Then
            Call makan()
            Call nanyaMakan()

        ElseIf input = "udah makan" Then
            Call makan()
            Call nanyaMakan()
        ElseIf input = "sudah makan?" Then
            Call makan()
            Call nanyaMakan()
        ElseIf input = "sudah makan" Then
            Call makan()
            Call nanyaMakan()
            'end makan

            'calculator Alex
        ElseIf input = "buka kalkulator" Then
            MessageBox.Show("Baiklah ini dia!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kalkulatorsimple.Show()
        ElseIf input = "tampilkan kalkulator" Then
            MessageBox.Show("Baiklah ini dia!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kalkulatorsimple.Show()
        ElseIf input = "kalkulator" Then
            MessageBox.Show("Baiklah ini dia!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kalkulatorsimple.Show()

            'numerik
        ElseIf input = "kalkulator numerik" Then
            MessageBox.Show("Baiklah ini dia!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kalkulatornumerik.Show()
        ElseIf input = "tampilkan kalkulator numerik" Then
            MessageBox.Show("Baiklah ini dia!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kalkulatornumerik.Show()
        ElseIf input = "kalkulator lainnya" Then
            MessageBox.Show("Baiklah ini dia!", "Output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kalkulatornumerik.Show()
            'end calculator alex

            'start kabar 
        ElseIf input = "apa kabar?" Then
            Call apakabar()
        ElseIf input = "apa kabar" Then
            Call apakabar()
        ElseIf input = "gimana kabarnya?" Then
            Call apakabar()
        ElseIf input = "gimana kabarnya" Then
            Call apakabar()
            'end kabar

            'start kalo yang marah

        ElseIf input = "kalo aku chat gini ada yang marah ga?" Then
            Call adaYangMarah()

        ElseIf input = "kalo aku chat gini ada yang marah ga" Then
            Call adaYangMarah()
        ElseIf input = "kalau aku chat gini ada yang marah ga?" Then
            Call adaYangMarah()
        ElseIf input = "kalau aku chat gini ada yang marah ga?" Then
            Call adaYangMarah()
        ElseIf input = "ada yang marah ga kalo aku chat gini?" Then
            Call adaYangMarah()
        ElseIf input = "kalo aku chat gini ada yang marah ga" Then
            Call adaYangMarah()
            'end klo ada yang marah

            'komunikasi dengan user

        ElseIf input = "alex ngobrol dong" Then
            Call obrolan()


        Else
            MessageBox.Show("Maaf " & user & " Perintah kamu belum bisa di jalankan, karena masih dalam tahap pengembangan, Alex yakin suatu saat perintah kamu bisa di jalankan : D", "Outpput", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call perintah()
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim user As String
        Dim tutup As String
        user = tbNama.Text
        tutup = MessageBox.Show("yakin " & user & " mau keluar? :(", "Output", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            MessageBox.Show("yahhhh :'( terimakasih udah mau jadi teman ngobrol Alex, Alex mengharapkan kehadirian " & user & " lagi :D bye byee", "output", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Else MessageBox.Show("Yeayy, Baiklah kita kembali ngobrol lagi :D")
        End If
    End Sub


End Class

Public Class Form1

    Sub bersih()
        tbID.Clear()
        '========= MAKANAN =============='
        'hamburger
        cbHamburger.Checked = False
        tbJumlahHam.Clear()
        tbhargaHam.Clear()

        'spageti
        cbSpaghetti.Checked = False
        tbJumlahSpag.Clear()
        tbhargaSpag.Clear()

        'pizza
        cbPizza.Checked = False
        tbHargaPiz.Clear()
        tbJumlahPiz.Clear()

        'total
        tbTotalHargaMakanan.Clear()

        '============ MINUMAN =============='
        'thai
        cbThai.Checked = False
        tbJumlahThai.Clear()
        tbHargaThai.Clear()

        'green
        cbGreen.Checked = False
        tbJumlahGreen.Clear()
        tbHargaGreen.Clear()

        'affogoto
        cbaff.Checked = False
        tbJumlahAffo.Clear()
        tbHargaAffo.Clear()

        'total
        tbhargaminuman.Clear()

        '============ Perhitungan ==========='
        tbTotalKeseluruhan.Clear()
        tbBayar.Clear()
        tbKembali.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub


    Private Sub cbHamburger_CheckedChanged(sender As Object, e As EventArgs) Handles cbHamburger.CheckedChanged
        If cbHamburger.Checked = True Then
            tbhargaHam.Text = Val(tbJumlahHam.Text) * 20000
            tbTotalHargaMakanan.Text = Val(tbhargaHam.Text) + Val(tbhargaSpag.Text) + Val(tbHargaPiz.Text)
        End If
    End Sub

    Private Sub cbSpaghetti_CheckedChanged(sender As Object, e As EventArgs) Handles cbSpaghetti.CheckedChanged
        If cbSpaghetti.Checked = True Then
            tbhargaSpag.Text = Val(tbJumlahSpag.Text) * 20000
            tbTotalHargaMakanan.Text = Val(tbhargaHam.Text) + Val(tbhargaSpag.Text) + Val(tbHargaPiz.Text)
        End If
    End Sub

    Private Sub cbPizza_CheckedChanged(sender As Object, e As EventArgs) Handles cbPizza.CheckedChanged
        If cbPizza.Checked = True Then
            tbHargaPiz.Text = Val(tbJumlahPiz.Text) * 20000
            tbTotalHargaMakanan.Text = Val(tbhargaHam.Text) + Val(tbhargaSpag.Text) + Val(tbHargaPiz.Text)
        End If
    End Sub


    Private Sub cbThai_CheckedChanged(sender As Object, e As EventArgs) Handles cbThai.CheckedChanged
        If cbThai.Checked = True Then
            tbHargaThai.Text = Val(tbJumlahThai.Text) * 20000
            tbhargaminuman.Text = Val(tbHargaGreen.Text) + Val(tbHargaThai.Text) + Val(tbHargaAffo.Text)
        End If
    End Sub

    Private Sub cbGreen_CheckedChanged(sender As Object, e As EventArgs) Handles cbGreen.CheckedChanged
        If cbGreen.Checked = True Then
            tbHargaGreen.Text = Val(tbJumlahGreen.Text) * 20000
            tbhargaminuman.Text = Val(tbHargaGreen.Text) + Val(tbHargaThai.Text) + Val(tbHargaAffo.Text)
        End If
    End Sub

    Private Sub cbaff_CheckedChanged(sender As Object, e As EventArgs) Handles cbaff.CheckedChanged
        If cbaff.Checked = True Then
            tbHargaAffo.Text = Val(tbJumlahAffo.Text) * 20000
            tbhargaminuman.Text = Val(tbHargaGreen.Text) + Val(tbHargaThai.Text) + Val(tbHargaAffo.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbTotalKeseluruhan.Text = val(tbTotalHargaMakanan.text) + Val(tbhargaminuman.text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bersih()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tbKembali.Text = Val(tbTotalKeseluruhan.Text) - Val(tbBayar.Text)
    End Sub
End Class
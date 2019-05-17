Public Class Form1

    Const Price_AyamBakar As Decimal = 15000
    Const Price_HotTea As Decimal = 5000
    Const Price_MilkShake As Decimal = 7000
    Const Price_MineralWater As Decimal = 3000
    Const Price_NasiGoreng As Decimal = 12000
    Const Price_Rendang As Decimal = 7000
    Const Price_Spaghetti As Decimal = 15000
    Const Price_IceTea As Decimal = 6000
    Const Tax_rate As Decimal = 5
    Const Tax_rateCard As Decimal = 3

    Dim itax As Decimal
    Dim ihasil As Decimal
    Dim iChanges As Decimal
    Dim iSubTotal As Decimal
    Dim icash As Decimal
    Dim iCost(8) As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim btnExit As DialogResult
        btnExit = MessageBox.Show("Do You want To Exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If btnExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each txt In {tbPaymentMethod, tbAyamBakar, tbHotTea, tbMilkShake, tbMineralWater, tbNasiGoreng, tbRendang, tbSpaghetti, tbIceTea}
            txt.Clear()
            txt.Text = "0"
        Next
        tbChange.Text = ""
        tbTotal.Text = ""
        tbTax.Text = ""
        tbSubTotal.Text = ""
        cmbPaymentMethod.Text = ""
        tbPaymentMethod.Enabled = False

        For Each ck In {ckAyamBakar, ckHotTea, ckMilkShake, ckMineralWater, ckNasiGoreng, ckRendang, ckSpaghetti, ckIceTea}
            ck.Checked = False
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each txt In {tbPaymentMethod, tbAyamBakar, tbHotTea, tbMilkShake, tbMineralWater, tbNasiGoreng, tbRendang, tbSpaghetti, tbIceTea}
            txt.Enabled = False
        Next

        cmbPaymentMethod.Items.Add("")
        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("Master Card")
        cmbPaymentMethod.Items.Add("Visa Card")
        cmbPaymentMethod.Items.Add("Debit Card")
    End Sub



    Private Sub Numbers_only(sender As Object, e As KeyPressEventArgs) Handles tbSpaghetti.KeyPress, tbRendang.KeyPress, tbNasiGoreng.KeyPress, tbMineralWater.KeyPress, tbMilkShake.KeyPress, tbIceTea.KeyPress, tbHotTea.KeyPress, tbAyamBakar.KeyPress, tbPaymentMethod.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ckNasiGoreng_CheckedChanged(sender As Object, e As EventArgs) Handles ckNasiGoreng.CheckedChanged

        If ckNasiGoreng.Checked = True Then
            tbNasiGoreng.Enabled = True
            tbNasiGoreng.Text = ""
            tbNasiGoreng.Focus()
        Else
            tbNasiGoreng.Enabled = False
            tbNasiGoreng.Clear()
            tbNasiGoreng.Text = "0"
        End If


    End Sub

    Private Sub ckAyamBakar_CheckedChanged(sender As Object, e As EventArgs) Handles ckAyamBakar.CheckedChanged
        If ckAyamBakar.Checked = True Then
            tbAyamBakar.Enabled = True
            tbAyamBakar.Text = ""
            tbAyamBakar.Focus()
        Else
            tbAyamBakar.Enabled = False
            tbAyamBakar.Clear()
            tbAyamBakar.Text = "0"
        End If
    End Sub

    Private Sub ckRendang_CheckedChanged(sender As Object, e As EventArgs) Handles ckRendang.CheckedChanged
        If ckRendang.Checked = True Then
            tbRendang.Enabled = True
            tbRendang.Text = ""
            tbRendang.Focus()
        Else
            tbRendang.Enabled = False
            tbRendang.Clear()
            tbRendang.Text = "0"
        End If
    End Sub

    Private Sub ckSpaghetti_CheckedChanged(sender As Object, e As EventArgs) Handles ckSpaghetti.CheckedChanged
        If ckSpaghetti.Checked = True Then
            tbSpaghetti.Enabled = True
            tbSpaghetti.Text = ""
            tbSpaghetti.Focus()
        Else
            tbSpaghetti.Enabled = False
            tbSpaghetti.Clear()
            tbSpaghetti.Text = "0"
        End If
    End Sub

    Private Sub ckMilkShake_CheckedChanged(sender As Object, e As EventArgs) Handles ckMilkShake.CheckedChanged
        If ckMilkShake.Checked = True Then
            tbMilkShake.Enabled = True
            tbMilkShake.Text = ""
            tbMilkShake.Focus()
        Else
            tbMilkShake.Enabled = False
            tbMilkShake.Clear()
            tbMilkShake.Text = "0"

        End If
    End Sub

    Private Sub ckIceTea_CheckedChanged(sender As Object, e As EventArgs) Handles ckIceTea.CheckedChanged
        If ckIceTea.Checked = True Then
            tbIceTea.Enabled = True
            tbIceTea.Text = ""
            tbIceTea.Focus()
        Else
            tbIceTea.Enabled = False
            tbIceTea.Clear()
            tbIceTea.Text = "0"
        End If
    End Sub

    Private Sub ckHotTea_CheckedChanged(sender As Object, e As EventArgs) Handles ckHotTea.CheckedChanged
        If ckHotTea.Checked = True Then
            tbHotTea.Enabled = True
            tbHotTea.Text = ""
            tbHotTea.Focus()
        Else
            tbHotTea.Enabled = False
            tbHotTea.Clear()
            tbHotTea.Text = "0"
        End If
    End Sub

    Private Sub ckMineralWater_CheckedChanged(sender As Object, e As EventArgs) Handles ckMineralWater.CheckedChanged
        If ckMineralWater.Checked = True Then
            tbMineralWater.Enabled = True
            tbMineralWater.Text = ""
            tbMineralWater.Focus()
        Else
            tbMineralWater.Enabled = False
            tbMineralWater.Clear()
            tbMineralWater.Text = "0"
        End If
    End Sub

    Private Sub cmbPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentMethod.SelectedIndexChanged
        If cmbPaymentMethod.Text = "Cash" Then
            tbPaymentMethod.Enabled = True
            tbPaymentMethod.Text = ""
            tbPaymentMethod.Focus()

        ElseIf cmbPaymentMethod.Text = "Visa Card" Or cmbPaymentMethod.Text = "Master Card" Or cmbPaymentMethod.Text = "Debit Card" Then
            tbPaymentMethod.Enabled = True
            tbPaymentMethod.Text = ""
            tbPaymentMethod.Focus()
        Else

            tbPaymentMethod.Enabled = False
            tbPaymentMethod.Text = "0"
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        iCost(0) = Convert.ToDecimal(tbAyamBakar.Text) * Price_AyamBakar
        iCost(1) = Convert.ToDecimal(tbHotTea.Text) * Price_HotTea
        iCost(2) = Convert.ToDecimal(tbIceTea.Text) * Price_IceTea
        iCost(3) = Convert.ToDecimal(tbMilkShake.Text) * Price_MilkShake
        iCost(4) = Convert.ToDecimal(tbMineralWater.Text) * Price_MineralWater
        iCost(5) = Convert.ToDecimal(tbNasiGoreng.Text) * Price_NasiGoreng
        iCost(6) = Convert.ToDecimal(tbRendang.Text) * Price_Rendang
        iCost(7) = Convert.ToDecimal(tbSpaghetti.Text) * Price_Spaghetti

        Dim Cost As Decimal

        If cmbPaymentMethod.Text = "Cash" Then
            iSubTotal = iCost(0) + iCost(1) + iCost(2) + iCost(3) + iCost(4) + iCost(5) + iCost(6) + iCost(7)
            tbSubTotal.Text = iSubTotal
            itax = (iSubTotal * Tax_rate) / 100
            tbTax.Text = itax
            tbTotal.Text = itax + iSubTotal
            tbChange.Text = tbPaymentMethod.Text - tbTotal.Text

            tbChange.Text = FormatCurrency(tbChange.Text)
            tbTax.Text = FormatCurrency(tbTax.Text)
            tbSubTotal.Text = FormatCurrency(tbSubTotal.Text)
            tbTotal.Text = FormatCurrency(tbTotal.Text)

        ElseIf cmbPaymentMethod.Text = "Visa Card" Or cmbPaymentMethod.Text = "Master Card" Or cmbPaymentMethod.Text = "Debit Card" Then
            iSubTotal = iCost(0) + iCost(1) + iCost(2) + iCost(3) + iCost(4) + iCost(5) + iCost(6) + iCost(7)
            tbSubTotal.Text = iSubTotal
            itax = (iSubTotal * Tax_rateCard) / 100
            tbTax.Text = itax
            tbTotal.Text = itax + iSubTotal
            tbChange.Text = tbPaymentMethod.Text - tbTotal.Text

            tbChange.Text = FormatCurrency(tbChange.Text)
            tbTax.Text = FormatCurrency(tbTax.Text)
            tbSubTotal.Text = FormatCurrency(tbSubTotal.Text)
            tbTotal.Text = FormatCurrency(tbTotal.Text)


            For Each txt In {tbPaymentMethod, tbAyamBakar, tbHotTea, tbMilkShake, tbMineralWater, tbNasiGoreng, tbRendang, tbSpaghetti, tbIceTea}
                txt.Clear()
                txt.Text = "0"
            Next
        End If
    End Sub

    Private Sub tbPaymentMethod_TextChanged(sender As Object, e As EventArgs) Handles tbPaymentMethod.TextChanged

    End Sub
End Class

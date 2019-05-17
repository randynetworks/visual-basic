Public Class foodOrder
    Public hargaMakanan, HargaMinuman As Integer

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                lbHargaMinuman.Text = "Rp 3000,-"
                HargaMinuman = 3000
            Case "Jus Alpukat"
                lbHargaMinuman.Text = "Rp 7000,-"
                HargaMinuman = 7000
            Case "Teh Manis"
                lbHargaMinuman.Text = "Rp 4000,-"
                HargaMinuman = 4000
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Uduk"
                lbHargaMakanan.Text = "Rp 3500,-"
                hargaMakanan = 3500
            Case "Baso"
                lbHargaMakanan.Text = "Rp 6000,-"
                hargaMakanan = 6000
            Case "Mie Ayam"
                lbHargaMakanan.Text = "Rp 7000,-"
                hargaMakanan = 7000
        End Select
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ComboBox2.Visible = False
        lbHargaMinuman.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim porsiMakanan, porsiMunuman, jumlah As Integer
        porsiMakanan = tbPorsiMakanan.Text
        porsiMunuman = tbPorsiMinuman.Text
        jumlah = (hargaMakanan * porsiMakanan) + (HargaMinuman * porsiMunuman)
        lbHasil.Text = "Rp. " & jumlah.ToString
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Enabled = False Then
            ComboBox2.Visible = False
        End If
        If CheckBox1.Enabled = True Then
            ComboBox2.Visible = True
            lbHargaMinuman.Visible = True
        End If
    End Sub
End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNim.Text = 1
        Dim arr(3, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "NAMA"
        arr(1, 0) = "JENIS KELAMIN"
        arr(1, 1) = "PRODI"
        arr(2, 0) = "LAKI - LAKI"
        arr(2, 1) = "PEREMPUAN"
        arr(3, 0) = "SISTEM INFORMASI"
        arr(3, 1) = "REKAM MEDIS"

        ListView1.GridLines = True
        ListView1.View = View.Details

        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next kolom
        Next baris

        For baris = 2 To 2
            For kolom = 0 To 1
                cbKelamin.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 3 To 3
            For kolom = 0 To 1
                cbProdi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        Dim Arr(3) As String

        Arr(0) = tbNim.Text
        Arr(1) = tbNama.Text
        Arr(2) = cbKelamin.Text
        Arr(3) = cbProdi.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        listitem.SubItems.Add(Arr(3))

        tbNim.Text = tbNim.Text + 1
        tbNama.Text = " "
        cbKelamin.Text = " "
        cbProdi.Text = " "
        tbNama.Focus()

    End Sub
End Class

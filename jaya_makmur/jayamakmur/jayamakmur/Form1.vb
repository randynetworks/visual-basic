Public Class Form1

    'fungsi mengosongkan data di textbox
    Sub bersih()
        KodeTextBox.Clear()
        Nama_barangTextBox.Clear()
        HargaTextBox.Clear()
        JumlahTextBox.Clear()
    End Sub

    Private Sub BarangBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InventoryDataSet)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.InventoryDataSet.barang)

        'mengosongkan data di textbox
        bersih()

    End Sub

    'Button Tutup
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    'Button Simpan
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        'untuk mengupdate data
        Me.BarangTableAdapter.InsertQueryData(KodeTextBox.Text, Nama_barangTextBox.Text, HargaTextBox.Text, JumlahTextBox.Text)

        'untuk refresh data di datagridview
        Me.BarangTableAdapter.Fill(Me.InventoryDataSet.barang)


        'mengosongkan data di textbox
        bersih()
    End Sub

    'Button Hapus
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        'untuk menghapus data
        Me.BarangTableAdapter.Delete(KodeTextBox.Text, Nama_barangTextBox.Text, HargaTextBox.Text, JumlahTextBox.Text)

        'untuk refresh data di datagridview
        Me.BarangTableAdapter.Fill(Me.InventoryDataSet.barang)


        'mengosongkan data di textbox
        bersih()
    End Sub

    'Button Update
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        'untuk mengubah data
        Me.BarangTableAdapter.UpdateQueryData(KodeTextBox.Text, Nama_barangTextBox.Text, HargaTextBox.Text, JumlahTextBox.Text, KodeTextBox.Text)

        'untuk refresh data di datagridview
        Me.BarangTableAdapter.Fill(Me.InventoryDataSet.barang)

        'mengosongkan data di textbox
        bersih()
    End Sub
End Class

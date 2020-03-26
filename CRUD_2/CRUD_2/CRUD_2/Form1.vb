Public Class Form1

    Private idPenjualanyangSedangDiEdit As Integer
    Sub bersih()
        Id_supplierTextBox.Clear()
        Nama_supplierTextBox.Clear()
        AlamatTextBox.Clear()
        No_telpTextBox.Clear()
    End Sub

    Private Sub Tb_supplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_supplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_penjualanDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_penjualanDataSet.tb_supplier' table. You can move, or remove it, as needed.
        Me.Tb_supplierTableAdapter.Fill(Me.Db_penjualanDataSet.tb_supplier)
        bersih()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        bersih()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        'menyimpan data
        Me.Tb_supplierTableAdapter.Insert(Id_supplierTextBox.Text, Nama_supplierTextBox.Text, AlamatTextBox.Text, No_telpTextBox.Text)

        'memperbaharui data setelah menekan tombol simpan
        Me.Tb_supplierTableAdapter.Fill(Me.Db_penjualanDataSet.tb_supplier)

        'bersihkan form
        bersih()
    End Sub

    Private Sub supplierDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles supplierDGV.CellDoubleClick
        If e.RowIndex >= 0 And e.RowIndex < supplierDGV.RowCount - 1 Then

            'data dari baris yang di double clik, ditampilkan pada textbox 

            With supplierDGV.Rows(e.RowIndex)
                idPenjualanyangSedangDiEdit = .Cells(0).Value
                Nama_supplierTextBox.Text = .Cells(1).Value.ToString
                AlamatTextBox.Text = .Cells(2).Value.ToString
                No_telpTextBox.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        'menghapus data
        Me.Tb_supplierTableAdapter.DeleteQueryMenggunakanID(idPenjualanyangSedangDiEdit)

        'memperbaharui data setelah menekan tombol simpan
        Me.Tb_supplierTableAdapter.Fill(Me.Db_penjualanDataSet.tb_supplier)

        'bersihkan form
        bersih()
    End Sub
End Class

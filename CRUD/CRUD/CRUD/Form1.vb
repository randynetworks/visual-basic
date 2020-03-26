Public Class Form1
    Private Sub KonsumenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.KonsumenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KonsumenDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        'TODO: This line of code loads data into the 'KonsumenDataSet.konsumen' table. You can move, or remove it, as needed.
        Me.KonsumenTableAdapter.Fill(Me.KonsumenDataSet.konsumen)

    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.KonsumenTableAdapter.Insert(NamaTextBox.Text, Tgl_DaftarDateTimePicker.Value.Date, OpenFileDialog1.FileName, ComboBox1.SelectedValue)
        KonsumenTableAdapter.Fill(KonsumenDataSet.konsumen)
        dgv.DataSource = Me.KonsumenDataSet.konsumen
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KonsumenDataSet.wilayah' table. You can move, or remove it, as needed.
        Me.WilayahTableAdapter.Fill(Me.KonsumenDataSet.wilayah)

    End Sub

End Class

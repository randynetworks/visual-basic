Public Class Form1
    Private Sub MahasiswaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MahasiswaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AkademikDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AkademikDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.AkademikDataSet.mahasiswa)

    End Sub
End Class

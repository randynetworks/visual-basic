Imports System.IO
Public Class studentList

    Private Sub studentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim student As New Student()
        DataGridView1.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()
        DataGridView1.RowTemplate.Height = 80
        DataGridView1.DataSource = student.getStudent()
        DataGridView1.AllowUserToAddRows = False


        picCol = DataGridView1.Columns(7)
        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        'display to select data with double click and can edit or delete

        'DATA ORDER => id - fn - ln - bd - gdr - phn - adr - pic
        Dim updateDelete As New UpdateDeleteStudent()
        updateDelete.tbId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        updateDelete.tbFirstName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        updateDelete.tbLastName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        updateDelete.datePicker.Value = DataGridView1.CurrentRow.Cells(3).Value

        'gender
        If DataGridView1.CurrentRow.Cells(4).Value.ToString() = "Female" Then
            updateDelete.RadioButton2.Checked = True
        End If
        updateDelete.tbphone.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        updateDelete.tbAddress.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()

        'picture display
        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        updateDelete.PictureBox1.Image = Image.FromStream(picture)

        updateDelete.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim student As New Student()
        DataGridView1.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()
        DataGridView1.RowTemplate.Height = 80
        DataGridView1.DataSource = student.getStudent()
        DataGridView1.AllowUserToAddRows = False


        picCol = DataGridView1.Columns(7)
        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub
End Class
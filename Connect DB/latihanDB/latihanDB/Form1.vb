Public Class Form1
    Private Sub DataMahasiswaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DataMahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LatihannDataSet)

    End Sub

    Private Sub DataMahasiswaBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DataMahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LatihannDataSet)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        DataMahasiswaBindingSource.MoveNext()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        DataMahasiswaBindingSource.MovePrevious()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            DataMahasiswaBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(LatihannDataSet)
            MsgBox("Sucess")
        Catch ex As Exception
            MsgBox("Error, Please Check Field and Try again!.")

        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DataMahasiswaBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(LatihannDataSet)
        MsgBox("deleted!")
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        DataMahasiswaBindingSource.AddNew()
    End Sub
End Class

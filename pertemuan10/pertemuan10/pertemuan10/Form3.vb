Public Class Form3
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DataPasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPasienToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub DataPenyakitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenyakitToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub DataDosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDosenToolStripMenuItem.Click
        Form4.Show()
    End Sub


End Class
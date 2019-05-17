Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = Image.FromFile("../../myImage/bg.jpg")
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        Dim addstudentForm As New AddStudentForm()
        addstudentForm.Show(Me)

    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        Dim studentlist As New studentList()
        studentlist.Show(Me)
    End Sub


End Class
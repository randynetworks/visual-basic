Public Class Form3

    Public koneksi, sql As String 'isi nya string, 
    Public conn As OleDb.OleDbConnection 'oleDb = panggilan koneksi
    Public cmd As OleDb.OleDbCommand 'cmd untuk command
    Private Sub BntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\VB\BELAJAR\pertemuan8\akademik.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
        conn.Open()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim a, b As String 'variable local
        a = NIDN.Text
        b = nama.Text

        sql = "insert into dosen values('" & a & "', '" & b & "')" '  '"& insert 1 & "','"& insert 2 & "'
        cmd = New OleDb.OleDbCommand(Sql, conn) 'menjalankannya menggunakan database
        cmd.ExecuteNonQuery() 'dijalankan
        MessageBox.Show("Data Disimpan", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim pesan As String
        pesan = InputBox("Masukan NIDN!")

        sql = "delete from dosen where NIDN ='" & pesan & "'"
        cmd = New OleDb.OleDbCommand(Sql, conn) 'menjalankannya menggunakan database
        cmd.ExecuteNonQuery() 'dijalankan
        MessageBox.Show("Data Terhapus", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        nama.Clear()
        NIDN.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class
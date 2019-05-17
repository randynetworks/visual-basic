Public Class Form1
    'public = global deklarasi
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
        a = npm.Text
        b = nama.Text

        sql = "insert into mahasiswa values('" & a & "', '" & b & "')" '  '"& insert 1 & "','"& insert 2 & "'
        cmd = New OleDb.OleDbCommand(sql, conn) 'menjalankannya menggunakan database
        cmd.ExecuteNonQuery() 'dijalankan
        MessageBox.Show("Data Disimpan", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim pesan As String
        pesan = InputBox("Masukan NPM!")
        If pesan = "" Then
            MessageBox.Show("Masukan Data terlebih dahulu!", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sql = "delete from mahasiswa where npm ='" & pesan & "'"
            cmd = New OleDb.OleDbCommand(sql, conn) 'menjalankannya menggunakan database
            cmd.ExecuteNonQuery() 'dijalankan
            MessageBox.Show("Data Terhapus", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        nama.Clear()
        npm.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

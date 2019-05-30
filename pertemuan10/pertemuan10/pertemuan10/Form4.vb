Public Class Form4
    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttable As New DataTable

    Sub daftar() 'untuk menampilkan data di dtransaksi
        sql = "select * from dokter"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttable.Clear()
        dtadapter.Fill(ttable)
        dgdokter.DataSource = ttable
    End Sub

    Sub simpan()
        Dim a, b, c, d As String
        a = kodeDokter.Text
        b = nama.Text
        c = spesialist.Text
        d = noTelp.Text
        sql = "insert into dokter values('" & a & "', '" & b & "' , '" & c & "', '" & d & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub hapus()
        Dim a, b, c, d, pesan As String
        pesan = InputBox("Masukan kode")
        a = kodeDokter.Text
        b = nama.Text
        c = spesialist.Text
        d = noTelp.Text
        sql = "delete from penyakit where kodeDokter='" & pesan & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        simpan()
        MessageBox.Show("Data Tersimpan", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        daftar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\GitHub\visual-basic\pertemuan10\rumahsakit.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
        conn.Open()
        daftar()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        hapus()
        MessageBox.Show("Data Terhapus", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        daftar()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        kodeDokter.Clear()
        nama.Clear()
        spesialist.Clear()
        noTelp.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
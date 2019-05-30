Public Class Form4
    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttable As New DataTable

    Sub daftar() 'untuk menampilkan data di dtransaksi
        sql = "select * from penyakit"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttable.Clear()
        dtadapter.Fill(ttable)
        dgPasien.DataSource = ttable
    End Sub

    Sub simpan()
        Dim a, b As String
        a = kode.Text
        b = nama.Text
        sql = "insert into penyakit values('" & a & "', '" & b & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub hapus()
        Dim a, b, pesan As String
        pesan = InputBox("Masukan kode")
        a = kode.Text
        b = nama.Text
        sql = "delete from penyakit where kode='" & pesan & "'"
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
        kode.Clear()
        nama.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
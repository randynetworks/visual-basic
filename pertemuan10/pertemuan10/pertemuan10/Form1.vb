Public Class Form1
    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttable As New DataTable

    Sub daftar() 'untuk menampilkan data di dtransaksi
        sql = "select * from pasien"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttable.Clear()
        dtadapter.Fill(ttable)
        dgPasien.DataSource = ttable
    End Sub

    Sub simpan()
        Dim a, b, c As String
        a = rm.Text
        b = nama.Text
        c = alamat.Text
        sql = "insert into pasien values('" & a & "', '" & b & "', '" & c & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub hapus()
        Dim a, b, c, pesan As String
        pesan = InputBox("Masukan kode")
        a = rm.Text
        b = nama.Text
        c = alamat.Text
        sql = "delete from pasien where norm='" & pesan & "'"
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
        rm.Clear()
        nama.Clear()
        alamat.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

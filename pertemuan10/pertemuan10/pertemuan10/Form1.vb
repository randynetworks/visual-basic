Public Class Form1
    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttable As New DataTable
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim a, b, c As String
        a = rm.Text
        b = nama.Text
        c = alamat.Text
        sql = "insert into pasien values('" & a & "', '" & b & "', '" & c & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Tersimpan", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\GitHub\visual-basic\pertemuan10\rumahsakit.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
        conn.Open()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        rm.Clear()
        nama.Clear()
        alamat.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

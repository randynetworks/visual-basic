Public Class Form1
    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttransaksi As New DataTable

    Sub daftar()
        sql = "select * from Transaksi"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttransaksi.Clear()
        dtadapter.Fill(ttransaksi)
        dgTransaksi.DataSource = ttransaksi

    End Sub

    Sub simpan()
        Dim a, b, c, d As String
        a = tbKode.Text
        b = tbTanggal.Text
        c = cbJenis.Text
        d = tbHarga.Text
        sql = "insert into Transaksi values('" & a & "', '" & b & "', '" & c & "', '" & d & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub hapus()
        Dim a As String
        a = MsgBox("Masukan Kode")
        sql = "delete from Transaksi where kode='" & a & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub bersih()
        tbKode.Clear()
        tbTanggal.Clear()
        cbJenis.Text = ""
        tbHarga.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTanggal.Text = Today
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\GitHub\visual-basic\PROJECT TERAKHIR VB\apotik.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
        conn.Open()
        daftar()

    End Sub

    Private Sub CbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        If cbJenis.Text = "Luar" Then
            tbHarga.Text = 5000
        Else
            tbHarga.Text = 7500
        End If
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        bersih()
        MsgBox("DATA BARU")
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        simpan()
        daftar()
        bersih()
        MsgBox("DATA TERSIMPAN")
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        hapus()
        daftar()
        bersih()
        MsgBox("DATA TERHAPUS")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class

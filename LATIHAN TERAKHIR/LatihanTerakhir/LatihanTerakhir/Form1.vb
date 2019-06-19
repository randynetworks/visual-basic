Public Class Form1
    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttransaksi As New DataTable

    Sub daftar()
        sql = "select * from transaksi"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttransaksi.Clear()
        dtadapter.Fill(ttransaksi)
        dgTransaksi.DataSource = ttransaksi
    End Sub

    Sub simpan()
        Dim a, b, c, d, e, f As String
        a = tbKode.Text
        b = tbTanggal.Text
        c = cbJenis.Text
        d = tbHarga.Text
        e = tbJumlah.Text
        f = tbTotal.Text

        sql = "insert into transaksi values('" & a & "','" & b & "', '" & c & "', '" & d & "', '" & e & "', '" & f & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Tersimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub hapus()
        Dim a As String
        a = InputBox("Masukan Kode :")
        sql = "delete from transaksi where kode ='" & a & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub bersih()
        tbKode.Clear()
        tbTanggal.Clear()
        cbJenis.Text = ""
        tbHarga.Clear()
        tbJumlah.Clear()
        tbTotal.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\GitHub\visual-basic\LATIHAN TERAKHIR\penjualan.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
        conn.Open()
        daftar()
    End Sub

    Private Sub CbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        If cbJenis.Text = "CD" Then
            tbHarga.Text = 1500
        Else
            tbHarga.Text = 2500
        End If
    End Sub

    Private Sub TbJumlah_TextChanged(sender As Object, e As EventArgs) Handles tbJumlah.TextChanged
        tbTotal.Text = Val(tbJumlah.Text) * Val(tbHarga.Text)
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        bersih()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        simpan()
        daftar()
        bersih()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        hapus()
        daftar()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class

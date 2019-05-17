Public Class Form1
    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttable As New DataTable

    Sub daftar() 'untuk menampilkan data di dtransaksi
        sql = "select * from transaksi"
        dtadapter = New OleDb.OleDbDataAdapter(sql, conn)
        ttable.Clear()
        dtadapter.Fill(ttable)
        dgtransaksi.DataSource = ttable
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim a, b, c, d, pesan As String
        pesan = InputBox("Masukan kode")
        a = kode.Text
        b = tanggal.Text
        c = jenis.Text
        d = harga.Text
        sql = "delete from transaksi where kode='" & pesan & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Terhapus", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        daftar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DatabasePenjualanDataSet.transaksi' table. You can move, or remove it, as needed.
        Me.TransaksiTableAdapter.Fill(Me.DatabasePenjualanDataSet.transaksi)
        tanggal.Text = Today

        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\GitHub\Visual-Basic-Project\Visual-basic-2019\pertemuan9\DatabasePenjualan.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
        conn.Open()
        daftar()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        kode.Clear()
        tanggal.Text = Today
        jenis.Text = " "
        harga.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim a, b, c, d As String
        a = kode.Text
        b = tanggal.Text
        c = jenis.Text
        d = harga.Text
        sql = "insert into transaksi values('" & a & "', '" & b & "', '" & c & "', '" & d & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Tersimpan", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        daftar()
    End Sub



    Private Sub Jenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenis.SelectedIndexChanged
        If jenis.Text = "OPAK" Then
            harga.Text = 12000
        ElseIf jenis.Text = "RANGINANG" Then
            harga.Text = 17500
        ElseIf jenis.Text = "DOROKDOK" Then
            harga.Text = 18000
        ElseIf jenis.Text = "KICIMPRING" Then
            harga.Text = 21000
        End If
    End Sub
End Class

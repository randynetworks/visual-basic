Public Class Form1

    Public koneksi, sql As String
    Public conn As OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public dtadapter As OleDb.OleDbDataAdapter
    Public ttable As New DataTable


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        kode.Clear()
        nama.Text = " "
        harga.Clear()
        jumlah.Clear()
        subTotal.Clear()
        pajak.Clear()
        total.Clear()
        MessageBox.Show("Data Baru", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Nama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nama.SelectedIndexChanged
        If nama.Text = "MOBIL" Then
            harga.Text = 75000
        ElseIf nama.Text = "MOTOR" Then
            harga.Text = 50000
        ElseIf nama.Text = "BONEKA" Then
            harga.Text = 65000
        End If
    End Sub

    Private Sub Jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged
        subTotal.Text = Val(harga.Text) * Val(jumlah.Text)
    End Sub

    Private Sub SubTotal_TextChanged(sender As Object, e As EventArgs) Handles subTotal.TextChanged
        pajak.Text = Val(harga.Text) * 0.1
    End Sub

    Private Sub Pajak_TextChanged(sender As Object, e As EventArgs) Handles pajak.TextChanged
        total.Text = Val(subTotal.Text) + Val(pajak.Text)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim a, b, c, d, ee, f, g As String
        a = kode.Text
        b = nama.Text
        c = harga.Text
        d = jumlah.Text
        ee = subTotal.Text
        f = pajak.Text
        g = total.Text

        sql = "insert into transaksi values ('" & a & "', '" & b & "','" & c & "','" & d & "','" & ee & "','" & f & "','" & g & "')"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Tersimpan", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim pesan As String
        pesan = InputBox("masukan Kode")
        sql = "delete from transaksi where kode='" & pesan & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Terhapus", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\GitHub\visual-basic\tokoMainan\toko.mdb"
        conn = New OleDb.OleDbConnection(koneksi)
        conn.Open()
    End Sub
End Class

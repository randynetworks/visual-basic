Imports System.Data.OleDb
Public Class Form1
    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
    Sub isi()
        TextBox2.Clear()
        TextBox2.Focus()
    End Sub
    Sub tampilJenis()
        da = New OleDbDataAdapter("Select * From Jenis", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Jenis")
        DataGridView1.DataSource = ds.Tables("Jenis")
        DataGridView1.Refresh()
    End Sub
    Sub autogrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(0).HeaderText = "KODE JENIS"
        DataGridView1.Columns(1).HeaderText = "NAMA JENIS"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilJenis()
        Call kosong()
        Call autogrid()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Belum lengkap..!")
            TextBox1.Focus()
            Exit Sub
        Else cmd = New OleDbCommand("Select * From Jenis where KodeJenis='" & TextBox1.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim Simpan As String = "Insert into Jenis(KodeJenis, Jenis)values" & "('" & TextBox1.Text & "'," & TextBox2.Text & "')"
                cmd = New OleDbCommand(Simpan, con)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan data Sukses...!", MsgBoxStyle.Information, "Perhatian")
            End If
            Call tampilJenis()
            Call kosong()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox1.MaxLength = 50
        If e.KeyChar = Chr(13) Then
            TextBox2.Text = UCase(TextBox2.Text)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.TextBox1.Text = .Cells(0).Value
            Me.TextBox1.Text = .Cells(1).Value

        End With
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode Jenis Belum Di isi")
            TextBox1.Focus()
            Exit Sub
        Else
            Dim ubah As String = "update Jenis set " & "Jenis='" & TextBox2.Text & "' " & "where KodeJenis='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(ubah, con)
            cmd.ExecuteNonQuery()
            MsgBox("Ubah data Sukses...!", MsgBoxStyle.Information, "Perhatian")
            Call tampilJenis()
            Call kosong()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode Buku harus di isi")
            TextBox1.Focus()
            Exit Sub
        ElseIf MessageBox.Show("Yakin Mau menghapus data Jenis " & TextBox1.Text & " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New OleDbCommand("Delete * From Jenis where KodeJenis='" & TextBox1.Text & "'", con)
            cmd.ExecuteNonQuery()
            Call kosong()
            Call tampilJenis()
        Else
            Call kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call kosong()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 2
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("Select * From Jenis KodeJenis='" & TextBox1.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                TextBox2.Text = rd.Item(1)
                TextBox2.Focus()
            Else
                Call isi()
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        cmd = New OleDbCommand("Select * From Jenis where KodeJenis like '%" & TextBox3.Text & "%'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            da = New OleDbDataAdapter("Select * From Jenis where KodeJenis like '%" & TextBox3.Text & "%'", con)
            ds = New DataSet
            da.Fill(ds, "Dapat")
            DataGridView1.DataSource = ds.Tables("Dapat")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub
End Class

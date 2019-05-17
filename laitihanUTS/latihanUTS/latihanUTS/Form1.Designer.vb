<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbpilih = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbDiagonal2 = New System.Windows.Forms.TextBox()
        Me.tbDiagonal1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbJari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAtas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbAlas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbTinggi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbLebar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPanjang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.tbHasil = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbSisi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbSatuan = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(765, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(99, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(585, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aplikasi Penghitung Luas Bangun Datar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(49, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pilihlah :"
        '
        'cbpilih
        '
        Me.cbpilih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpilih.FormattingEnabled = True
        Me.cbpilih.Items.AddRange(New Object() {" ", "Luas Persegi", "Luas Persegi Panjang", "Luas Segitiga", "Luas Lingkaran", "Luas Trapesium", "Luas Jajar Genjang", "Luas Layang Layang"})
        Me.cbpilih.Location = New System.Drawing.Point(52, 91)
        Me.cbpilih.Name = "cbpilih"
        Me.cbpilih.Size = New System.Drawing.Size(149, 24)
        Me.cbpilih.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbSisi)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tbDiagonal2)
        Me.GroupBox1.Controls.Add(Me.tbDiagonal1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbJari)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbAtas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbAlas)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbTinggi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbLebar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbPanjang)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(34, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 172)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(348, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Diagonal 2 :"
        '
        'tbDiagonal2
        '
        Me.tbDiagonal2.Location = New System.Drawing.Point(351, 132)
        Me.tbDiagonal2.Name = "tbDiagonal2"
        Me.tbDiagonal2.Size = New System.Drawing.Size(149, 22)
        Me.tbDiagonal2.TabIndex = 15
        '
        'tbDiagonal1
        '
        Me.tbDiagonal1.Location = New System.Drawing.Point(351, 87)
        Me.tbDiagonal1.Name = "tbDiagonal1"
        Me.tbDiagonal1.Size = New System.Drawing.Size(149, 22)
        Me.tbDiagonal1.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(348, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Diagonal 1 :"
        '
        'tbJari
        '
        Me.tbJari.Location = New System.Drawing.Point(351, 42)
        Me.tbJari.Name = "tbJari"
        Me.tbJari.Size = New System.Drawing.Size(149, 22)
        Me.tbJari.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(348, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jari Jari :"
        '
        'tbAtas
        '
        Me.tbAtas.Location = New System.Drawing.Point(179, 132)
        Me.tbAtas.Name = "tbAtas"
        Me.tbAtas.Size = New System.Drawing.Size(149, 22)
        Me.tbAtas.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(176, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Atas :"
        '
        'tbAlas
        '
        Me.tbAlas.Location = New System.Drawing.Point(179, 87)
        Me.tbAlas.Name = "tbAlas"
        Me.tbAlas.Size = New System.Drawing.Size(149, 22)
        Me.tbAlas.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Alas :"
        '
        'tbTinggi
        '
        Me.tbTinggi.Location = New System.Drawing.Point(179, 42)
        Me.tbTinggi.Name = "tbTinggi"
        Me.tbTinggi.Size = New System.Drawing.Size(149, 22)
        Me.tbTinggi.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tinggi :"
        '
        'tbLebar
        '
        Me.tbLebar.Location = New System.Drawing.Point(18, 132)
        Me.tbLebar.Name = "tbLebar"
        Me.tbLebar.Size = New System.Drawing.Size(149, 22)
        Me.tbLebar.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Lebar :"
        '
        'tbPanjang
        '
        Me.tbPanjang.Location = New System.Drawing.Point(18, 87)
        Me.tbPanjang.Name = "tbPanjang"
        Me.tbPanjang.Size = New System.Drawing.Size(149, 22)
        Me.tbPanjang.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Panjang :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Controls.Add(Me.btnHitung)
        Me.GroupBox2.Controls.Add(Me.tbHasil)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(571, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 132)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prosses"
        '
        'btnReset
        '
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReset.Location = New System.Drawing.Point(105, 79)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 27)
        Me.btnReset.TabIndex = 24
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHitung.Location = New System.Drawing.Point(24, 78)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 28)
        Me.btnHitung.TabIndex = 23
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'tbHasil
        '
        Me.tbHasil.Location = New System.Drawing.Point(24, 51)
        Me.tbHasil.Name = "tbHasil"
        Me.tbHasil.Size = New System.Drawing.Size(156, 22)
        Me.tbHasil.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(21, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Hasil :"
        '
        'tbSisi
        '
        Me.tbSisi.Location = New System.Drawing.Point(18, 42)
        Me.tbSisi.Name = "tbSisi"
        Me.tbSisi.Size = New System.Drawing.Size(149, 22)
        Me.tbSisi.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Sisi :"
        '
        'cbSatuan
        '
        Me.cbSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSatuan.FormattingEnabled = True
        Me.cbSatuan.Items.AddRange(New Object() {" ", "CM2", "M2"})
        Me.cbSatuan.Location = New System.Drawing.Point(213, 91)
        Me.cbSatuan.Name = "cbSatuan"
        Me.cbSatuan.Size = New System.Drawing.Size(149, 24)
        Me.cbSatuan.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(210, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 18)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Satuan :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(566, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(177, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Develop by Raini Software"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(800, 325)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbSatuan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbpilih)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbpilih As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbDiagonal2 As TextBox
    Friend WithEvents tbDiagonal1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbJari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbAtas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbAlas As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbTinggi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbLebar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPanjang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnHitung As Button
    Friend WithEvents tbHasil As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbSisi As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbSatuan As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foodOrder
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbHargaMakanan = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lbHargaMinuman = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbHasil = New System.Windows.Forms.Label()
        Me.tbPorsiMinuman = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.tbPorsiMakanan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nasi Uduk", "Baso", "Mie Ayam"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Harga"
        '
        'lbHargaMakanan
        '
        Me.lbHargaMakanan.AutoSize = True
        Me.lbHargaMakanan.Location = New System.Drawing.Point(279, 15)
        Me.lbHargaMakanan.Name = "lbHargaMakanan"
        Me.lbHargaMakanan.Size = New System.Drawing.Size(0, 13)
        Me.lbHargaMakanan.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 50)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Termasuk Dengan Minuman"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lbHargaMinuman
        '
        Me.lbHargaMinuman.AutoSize = True
        Me.lbHargaMinuman.Location = New System.Drawing.Point(279, 85)
        Me.lbHargaMinuman.Name = "lbHargaMinuman"
        Me.lbHargaMinuman.Size = New System.Drawing.Size(0, 13)
        Me.lbHargaMinuman.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Harga"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Es Jeruk", "Jus Alpukat", "Teh Manis"})
        Me.ComboBox2.Location = New System.Drawing.Point(12, 82)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbHasil)
        Me.GroupBox1.Controls.Add(Me.tbPorsiMinuman)
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.tbPorsiMakanan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 168)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Pesanan"
        '
        'lbHasil
        '
        Me.lbHasil.AutoSize = True
        Me.lbHasil.Location = New System.Drawing.Point(162, 116)
        Me.lbHasil.Name = "lbHasil"
        Me.lbHasil.Size = New System.Drawing.Size(0, 13)
        Me.lbHasil.TabIndex = 9
        '
        'tbPorsiMinuman
        '
        Me.tbPorsiMinuman.Location = New System.Drawing.Point(165, 64)
        Me.tbPorsiMinuman.Name = "tbPorsiMinuman"
        Me.tbPorsiMinuman.Size = New System.Drawing.Size(95, 20)
        Me.tbPorsiMinuman.TabIndex = 11
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(29, 111)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 8
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'tbPorsiMakanan
        '
        Me.tbPorsiMakanan.Location = New System.Drawing.Point(165, 31)
        Me.tbPorsiMakanan.Name = "tbPorsiMakanan"
        Me.tbPorsiMakanan.Size = New System.Drawing.Size(95, 20)
        Me.tbPorsiMakanan.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Porsi Minuman"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Porsi Makanan"
        '
        'foodOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 341)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbHargaMinuman)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lbHargaMakanan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "foodOrder"
        Me.Text = "Basic Food Order "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbHargaMakanan As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lbHargaMinuman As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbPorsiMinuman As TextBox
    Friend WithEvents tbPorsiMakanan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbHasil As Label
    Friend WithEvents btnHitung As Button
End Class

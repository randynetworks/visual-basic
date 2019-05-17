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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbMineralWater = New System.Windows.Forms.TextBox()
        Me.tbHotTea = New System.Windows.Forms.TextBox()
        Me.tbIceTea = New System.Windows.Forms.TextBox()
        Me.tbMilkShake = New System.Windows.Forms.TextBox()
        Me.tbSpaghetti = New System.Windows.Forms.TextBox()
        Me.tbRendang = New System.Windows.Forms.TextBox()
        Me.tbAyamBakar = New System.Windows.Forms.TextBox()
        Me.tbNasiGoreng = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckSpaghetti = New System.Windows.Forms.CheckBox()
        Me.ckRendang = New System.Windows.Forms.CheckBox()
        Me.ckMineralWater = New System.Windows.Forms.CheckBox()
        Me.ckHotTea = New System.Windows.Forms.CheckBox()
        Me.ckIceTea = New System.Windows.Forms.CheckBox()
        Me.ckMilkShake = New System.Windows.Forms.CheckBox()
        Me.ckAyamBakar = New System.Windows.Forms.CheckBox()
        Me.ckNasiGoreng = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbSubTotal = New System.Windows.Forms.TextBox()
        Me.tbTax = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbChange = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbPaymentMethod = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(214, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESTAURANT CASHIER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Harrington", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(274, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jl. Sukasirna No. 73 RT 09 RW 13"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tbMineralWater)
        Me.GroupBox1.Controls.Add(Me.tbHotTea)
        Me.GroupBox1.Controls.Add(Me.tbIceTea)
        Me.GroupBox1.Controls.Add(Me.tbMilkShake)
        Me.GroupBox1.Controls.Add(Me.tbSpaghetti)
        Me.GroupBox1.Controls.Add(Me.tbRendang)
        Me.GroupBox1.Controls.Add(Me.tbAyamBakar)
        Me.GroupBox1.Controls.Add(Me.tbNasiGoreng)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ckSpaghetti)
        Me.GroupBox1.Controls.Add(Me.ckRendang)
        Me.GroupBox1.Controls.Add(Me.ckMineralWater)
        Me.GroupBox1.Controls.Add(Me.ckHotTea)
        Me.GroupBox1.Controls.Add(Me.ckIceTea)
        Me.GroupBox1.Controls.Add(Me.ckMilkShake)
        Me.GroupBox1.Controls.Add(Me.ckAyamBakar)
        Me.GroupBox1.Controls.Add(Me.ckNasiGoreng)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(37, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 282)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENU"
        '
        'tbMineralWater
        '
        Me.tbMineralWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMineralWater.Location = New System.Drawing.Point(203, 250)
        Me.tbMineralWater.Name = "tbMineralWater"
        Me.tbMineralWater.Size = New System.Drawing.Size(62, 24)
        Me.tbMineralWater.TabIndex = 2
        Me.tbMineralWater.Text = "0"
        Me.tbMineralWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbHotTea
        '
        Me.tbHotTea.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHotTea.Location = New System.Drawing.Point(203, 224)
        Me.tbHotTea.Name = "tbHotTea"
        Me.tbHotTea.Size = New System.Drawing.Size(62, 24)
        Me.tbHotTea.TabIndex = 2
        Me.tbHotTea.Text = "0"
        Me.tbHotTea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbIceTea
        '
        Me.tbIceTea.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIceTea.Location = New System.Drawing.Point(203, 198)
        Me.tbIceTea.Name = "tbIceTea"
        Me.tbIceTea.Size = New System.Drawing.Size(62, 24)
        Me.tbIceTea.TabIndex = 2
        Me.tbIceTea.Text = "0"
        Me.tbIceTea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbMilkShake
        '
        Me.tbMilkShake.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMilkShake.Location = New System.Drawing.Point(203, 172)
        Me.tbMilkShake.Name = "tbMilkShake"
        Me.tbMilkShake.Size = New System.Drawing.Size(62, 24)
        Me.tbMilkShake.TabIndex = 2
        Me.tbMilkShake.Text = "0"
        Me.tbMilkShake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSpaghetti
        '
        Me.tbSpaghetti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSpaghetti.Location = New System.Drawing.Point(203, 121)
        Me.tbSpaghetti.Name = "tbSpaghetti"
        Me.tbSpaghetti.Size = New System.Drawing.Size(62, 24)
        Me.tbSpaghetti.TabIndex = 2
        Me.tbSpaghetti.Text = "0"
        Me.tbSpaghetti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRendang
        '
        Me.tbRendang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRendang.Location = New System.Drawing.Point(203, 93)
        Me.tbRendang.Name = "tbRendang"
        Me.tbRendang.Size = New System.Drawing.Size(62, 24)
        Me.tbRendang.TabIndex = 2
        Me.tbRendang.Text = "0"
        Me.tbRendang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbAyamBakar
        '
        Me.tbAyamBakar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAyamBakar.Location = New System.Drawing.Point(203, 68)
        Me.tbAyamBakar.Name = "tbAyamBakar"
        Me.tbAyamBakar.Size = New System.Drawing.Size(62, 24)
        Me.tbAyamBakar.TabIndex = 2
        Me.tbAyamBakar.Text = "0"
        Me.tbAyamBakar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbNasiGoreng
        '
        Me.tbNasiGoreng.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNasiGoreng.Location = New System.Drawing.Point(203, 43)
        Me.tbNasiGoreng.Name = "tbNasiGoreng"
        Me.tbNasiGoreng.Size = New System.Drawing.Size(62, 24)
        Me.tbNasiGoreng.TabIndex = 2
        Me.tbNasiGoreng.Text = "0"
        Me.tbNasiGoreng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Beverage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Food"
        '
        'ckSpaghetti
        '
        Me.ckSpaghetti.AutoSize = True
        Me.ckSpaghetti.Font = New System.Drawing.Font("Roboto Cn", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckSpaghetti.Location = New System.Drawing.Point(25, 123)
        Me.ckSpaghetti.Name = "ckSpaghetti"
        Me.ckSpaghetti.Size = New System.Drawing.Size(152, 22)
        Me.ckSpaghetti.TabIndex = 0
        Me.ckSpaghetti.Text = "Spaghetti Bolognaise"
        Me.ckSpaghetti.UseVisualStyleBackColor = True
        '
        'ckRendang
        '
        Me.ckRendang.AutoSize = True
        Me.ckRendang.Font = New System.Drawing.Font("Roboto Cn", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckRendang.Location = New System.Drawing.Point(25, 97)
        Me.ckRendang.Name = "ckRendang"
        Me.ckRendang.Size = New System.Drawing.Size(77, 22)
        Me.ckRendang.TabIndex = 0
        Me.ckRendang.Text = "Rendang"
        Me.ckRendang.UseVisualStyleBackColor = True
        '
        'ckMineralWater
        '
        Me.ckMineralWater.AutoSize = True
        Me.ckMineralWater.Font = New System.Drawing.Font("Roboto Cn", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckMineralWater.Location = New System.Drawing.Point(25, 254)
        Me.ckMineralWater.Name = "ckMineralWater"
        Me.ckMineralWater.Size = New System.Drawing.Size(110, 22)
        Me.ckMineralWater.TabIndex = 0
        Me.ckMineralWater.Text = "Mineral Water"
        Me.ckMineralWater.UseVisualStyleBackColor = True
        '
        'ckHotTea
        '
        Me.ckHotTea.AutoSize = True
        Me.ckHotTea.Font = New System.Drawing.Font("Roboto Cn", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckHotTea.Location = New System.Drawing.Point(25, 228)
        Me.ckHotTea.Name = "ckHotTea"
        Me.ckHotTea.Size = New System.Drawing.Size(72, 22)
        Me.ckHotTea.TabIndex = 0
        Me.ckHotTea.Text = "Hot Tea"
        Me.ckHotTea.UseVisualStyleBackColor = True
        '
        'ckIceTea
        '
        Me.ckIceTea.AutoSize = True
        Me.ckIceTea.Font = New System.Drawing.Font("Roboto Cn", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckIceTea.Location = New System.Drawing.Point(25, 202)
        Me.ckIceTea.Name = "ckIceTea"
        Me.ckIceTea.Size = New System.Drawing.Size(69, 22)
        Me.ckIceTea.TabIndex = 0
        Me.ckIceTea.Text = "Ice Tea"
        Me.ckIceTea.UseVisualStyleBackColor = True
        '
        'ckMilkShake
        '
        Me.ckMilkShake.AutoSize = True
        Me.ckMilkShake.Font = New System.Drawing.Font("Roboto Cn", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckMilkShake.Location = New System.Drawing.Point(25, 176)
        Me.ckMilkShake.Name = "ckMilkShake"
        Me.ckMilkShake.Size = New System.Drawing.Size(150, 22)
        Me.ckMilkShake.TabIndex = 0
        Me.ckMilkShake.Text = "Milk Shake ( V/C/GT)"
        Me.ckMilkShake.UseVisualStyleBackColor = True
        '
        'ckAyamBakar
        '
        Me.ckAyamBakar.AutoSize = True
        Me.ckAyamBakar.Font = New System.Drawing.Font("Roboto Cn", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckAyamBakar.Location = New System.Drawing.Point(25, 71)
        Me.ckAyamBakar.Name = "ckAyamBakar"
        Me.ckAyamBakar.Size = New System.Drawing.Size(97, 22)
        Me.ckAyamBakar.TabIndex = 0
        Me.ckAyamBakar.Text = "Ayam Bakar"
        Me.ckAyamBakar.UseVisualStyleBackColor = True
        '
        'ckNasiGoreng
        '
        Me.ckNasiGoreng.AutoSize = True
        Me.ckNasiGoreng.Font = New System.Drawing.Font("Roboto Cn", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckNasiGoreng.Location = New System.Drawing.Point(25, 45)
        Me.ckNasiGoreng.Name = "ckNasiGoreng"
        Me.ckNasiGoreng.Size = New System.Drawing.Size(99, 22)
        Me.ckNasiGoreng.TabIndex = 0
        Me.ckNasiGoreng.Text = "Nasi Goreng"
        Me.ckNasiGoreng.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tbTotal)
        Me.GroupBox2.Controls.Add(Me.tbSubTotal)
        Me.GroupBox2.Controls.Add(Me.tbTax)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tbChange)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(337, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 143)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PERHITUNGAN"
        '
        'tbTotal
        '
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.Location = New System.Drawing.Point(88, 114)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(108, 24)
        Me.tbTotal.TabIndex = 2
        '
        'tbSubTotal
        '
        Me.tbSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubTotal.Location = New System.Drawing.Point(88, 84)
        Me.tbSubTotal.Name = "tbSubTotal"
        Me.tbSubTotal.Size = New System.Drawing.Size(108, 24)
        Me.tbSubTotal.TabIndex = 2
        '
        'tbTax
        '
        Me.tbTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTax.Location = New System.Drawing.Point(88, 54)
        Me.tbTax.Name = "tbTax"
        Me.tbTax.Size = New System.Drawing.Size(108, 24)
        Me.tbTax.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "SubTotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Change"
        '
        'tbChange
        '
        Me.tbChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChange.Location = New System.Drawing.Point(88, 24)
        Me.tbChange.Name = "tbChange"
        Me.tbChange.Size = New System.Drawing.Size(108, 24)
        Me.tbChange.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Method"
        '
        'tbPaymentMethod
        '
        Me.tbPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPaymentMethod.Location = New System.Drawing.Point(86, 51)
        Me.tbPaymentMethod.Name = "tbPaymentMethod"
        Me.tbPaymentMethod.Size = New System.Drawing.Size(110, 24)
        Me.tbPaymentMethod.TabIndex = 2
        Me.tbPaymentMethod.Text = "0"
        Me.tbPaymentMethod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.Transparent
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnHitung.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHitung.Location = New System.Drawing.Point(572, 102)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(115, 72)
        Me.btnHitung.TabIndex = 3
        Me.btnHitung.Text = "HITUNG"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReset.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReset.Location = New System.Drawing.Point(572, 204)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 72)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(572, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 72)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmbPaymentMethod)
        Me.GroupBox3.Controls.Add(Me.tbPaymentMethod)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(337, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 91)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PEMBAYARAN"
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(86, 24)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(110, 23)
        Me.cmbPaymentMethod.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(337, 196)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(214, 40)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Bohinj_ECO_Hotel_Restaurant_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(752, 421)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Cashier"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ckSpaghetti As CheckBox
    Friend WithEvents ckRendang As CheckBox
    Friend WithEvents ckMilkShake As CheckBox
    Friend WithEvents ckAyamBakar As CheckBox
    Friend WithEvents ckNasiGoreng As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ckMineralWater As CheckBox
    Friend WithEvents ckHotTea As CheckBox
    Friend WithEvents ckIceTea As CheckBox
    Friend WithEvents tbMineralWater As TextBox
    Friend WithEvents tbHotTea As TextBox
    Friend WithEvents tbIceTea As TextBox
    Friend WithEvents tbMilkShake As TextBox
    Friend WithEvents tbSpaghetti As TextBox
    Friend WithEvents tbRendang As TextBox
    Friend WithEvents tbAyamBakar As TextBox
    Friend WithEvents tbNasiGoreng As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbPaymentMethod As TextBox
    Friend WithEvents tbSubTotal As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbTax As TextBox
    Friend WithEvents tbChange As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
End Class

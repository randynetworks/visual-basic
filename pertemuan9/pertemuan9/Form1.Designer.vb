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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kode = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.jenis = New System.Windows.Forms.ComboBox()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.DatabasePenjualanDataSet = New pertemuan9.DatabasePenjualanDataSet()
        Me.dgtransaksi = New System.Windows.Forms.DataGridView()
        Me.KodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransaksiTableAdapter = New pertemuan9.DatabasePenjualanDataSetTableAdapters.transaksiTableAdapter()
        CType(Me.DatabasePenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSAKSI PENJUALAN KERUPUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jenis Kerupuk"
        '
        'kode
        '
        Me.kode.Location = New System.Drawing.Point(148, 71)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(118, 20)
        Me.kode.TabIndex = 5
        Me.kode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(148, 105)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(118, 20)
        Me.tanggal.TabIndex = 6
        Me.tanggal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(148, 174)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(118, 20)
        Me.harga.TabIndex = 8
        Me.harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'jenis
        '
        Me.jenis.FormattingEnabled = True
        Me.jenis.Items.AddRange(New Object() {" ", "OPAK", "RANGINANG", "DOROKDOK", "KICIMPRING"})
        Me.jenis.Location = New System.Drawing.Point(148, 139)
        Me.jenis.Name = "jenis"
        Me.jenis.Size = New System.Drawing.Size(118, 21)
        Me.jenis.TabIndex = 9
        '
        'btnBaru
        '
        Me.btnBaru.Location = New System.Drawing.Point(22, 204)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 23)
        Me.btnBaru.TabIndex = 10
        Me.btnBaru.Text = "Baru"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(114, 204)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(298, 204)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 13
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(206, 204)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'DatabasePenjualanDataSet
        '
        Me.DatabasePenjualanDataSet.DataSetName = "DatabasePenjualanDataSet"
        Me.DatabasePenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgtransaksi
        '
        Me.dgtransaksi.AutoGenerateColumns = False
        Me.dgtransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn, Me.JenisDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn})
        Me.dgtransaksi.DataSource = Me.TransaksiBindingSource
        Me.dgtransaksi.Location = New System.Drawing.Point(28, 233)
        Me.dgtransaksi.Name = "dgtransaksi"
        Me.dgtransaksi.Size = New System.Drawing.Size(351, 150)
        Me.dgtransaksi.TabIndex = 14
        '
        'KodeDataGridViewTextBoxColumn
        '
        Me.KodeDataGridViewTextBoxColumn.DataPropertyName = "kode"
        Me.KodeDataGridViewTextBoxColumn.HeaderText = "kode"
        Me.KodeDataGridViewTextBoxColumn.Name = "KodeDataGridViewTextBoxColumn"
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        '
        'JenisDataGridViewTextBoxColumn
        '
        Me.JenisDataGridViewTextBoxColumn.DataPropertyName = "jenis"
        Me.JenisDataGridViewTextBoxColumn.HeaderText = "jenis"
        Me.JenisDataGridViewTextBoxColumn.Name = "JenisDataGridViewTextBoxColumn"
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'TransaksiBindingSource
        '
        Me.TransaksiBindingSource.DataMember = "transaksi"
        Me.TransaksiBindingSource.DataSource = Me.DatabasePenjualanDataSet
        '
        'TransaksiTableAdapter
        '
        Me.TransaksiTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(400, 406)
        Me.Controls.Add(Me.dgtransaksi)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.jenis)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DatabasePenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents kode As TextBox
    Friend WithEvents tanggal As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents jenis As ComboBox
    Friend WithEvents btnBaru As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents DatabasePenjualanDataSet As DatabasePenjualanDataSet
    Friend WithEvents dgtransaksi As DataGridView
    Friend WithEvents TransaksiBindingSource As BindingSource
    Friend WithEvents TransaksiTableAdapter As DatabasePenjualanDataSetTableAdapters.transaksiTableAdapter
    Friend WithEvents KodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Tgl_DaftarLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim ID_wilayahLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.KonsumenDataSet = New CRUD.konsumenDataSet()
        Me.KonsumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KonsumenTableAdapter = New CRUD.konsumenDataSetTableAdapters.konsumenTableAdapter()
        Me.TableAdapterManager = New CRUD.konsumenDataSetTableAdapters.TableAdapterManager()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglDaftarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDwilayahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KonsumenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Tgl_DaftarDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.WilayahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WilayahTableAdapter = New CRUD.konsumenDataSetTableAdapters.wilayahTableAdapter()
        Me.KonsumenBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        NamaLabel = New System.Windows.Forms.Label()
        Tgl_DaftarLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        ID_wilayahLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.KonsumenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KonsumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KonsumenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WilayahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KonsumenBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(11, 46)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(36, 13)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "nama:"
        '
        'Tgl_DaftarLabel
        '
        Tgl_DaftarLabel.AutoSize = True
        Tgl_DaftarLabel.Location = New System.Drawing.Point(11, 73)
        Tgl_DaftarLabel.Name = "Tgl_DaftarLabel"
        Tgl_DaftarLabel.Size = New System.Drawing.Size(53, 13)
        Tgl_DaftarLabel.TabIndex = 5
        Tgl_DaftarLabel.Text = "tgl Daftar:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(11, 98)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(28, 13)
        FotoLabel.TabIndex = 7
        FotoLabel.Text = "foto:"
        '
        'ID_wilayahLabel
        '
        ID_wilayahLabel.AutoSize = True
        ID_wilayahLabel.Location = New System.Drawing.Point(11, 124)
        ID_wilayahLabel.Name = "ID_wilayahLabel"
        ID_wilayahLabel.Size = New System.Drawing.Size(59, 13)
        ID_wilayahLabel.TabIndex = 9
        ID_wilayahLabel.Text = "ID wilayah:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(188, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(208, 25)
        Label1.TabIndex = 11
        Label1.Text = "DATA KONSUMEN"
        '
        'KonsumenDataSet
        '
        Me.KonsumenDataSet.DataSetName = "konsumenDataSet"
        Me.KonsumenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KonsumenBindingSource
        '
        Me.KonsumenBindingSource.DataMember = "konsumen"
        Me.KonsumenBindingSource.DataSource = Me.KonsumenDataSet
        '
        'KonsumenTableAdapter
        '
        Me.KonsumenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.konsumenTableAdapter = Me.KonsumenTableAdapter
        Me.TableAdapterManager.UpdateOrder = CRUD.konsumenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wilayahTableAdapter = Nothing
        '
        'dgv
        '
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.TglDaftarDataGridViewTextBoxColumn, Me.FotoDataGridViewTextBoxColumn, Me.IDwilayahDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.KonsumenBindingSource1
        Me.dgv.Location = New System.Drawing.Point(14, 157)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(545, 150)
        Me.dgv.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'TglDaftarDataGridViewTextBoxColumn
        '
        Me.TglDaftarDataGridViewTextBoxColumn.DataPropertyName = "tgl_Daftar"
        Me.TglDaftarDataGridViewTextBoxColumn.HeaderText = "tgl_Daftar"
        Me.TglDaftarDataGridViewTextBoxColumn.Name = "TglDaftarDataGridViewTextBoxColumn"
        '
        'FotoDataGridViewTextBoxColumn
        '
        Me.FotoDataGridViewTextBoxColumn.DataPropertyName = "foto"
        Me.FotoDataGridViewTextBoxColumn.HeaderText = "foto"
        Me.FotoDataGridViewTextBoxColumn.Name = "FotoDataGridViewTextBoxColumn"
        '
        'IDwilayahDataGridViewTextBoxColumn
        '
        Me.IDwilayahDataGridViewTextBoxColumn.DataPropertyName = "ID_wilayah"
        Me.IDwilayahDataGridViewTextBoxColumn.HeaderText = "ID_wilayah"
        Me.IDwilayahDataGridViewTextBoxColumn.Name = "IDwilayahDataGridViewTextBoxColumn"
        '
        'KonsumenBindingSource1
        '
        Me.KonsumenBindingSource1.DataMember = "konsumen"
        Me.KonsumenBindingSource1.DataSource = Me.KonsumenDataSet
        '
        'NamaTextBox
        '
        Me.NamaTextBox.Location = New System.Drawing.Point(76, 43)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(218, 20)
        Me.NamaTextBox.TabIndex = 4
        '
        'Tgl_DaftarDateTimePicker
        '
        Me.Tgl_DaftarDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KonsumenBindingSource, "tgl_Daftar", True))
        Me.Tgl_DaftarDateTimePicker.Location = New System.Drawing.Point(76, 69)
        Me.Tgl_DaftarDateTimePicker.Name = "Tgl_DaftarDateTimePicker"
        Me.Tgl_DaftarDateTimePicker.Size = New System.Drawing.Size(218, 20)
        Me.Tgl_DaftarDateTimePicker.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "&Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(76, 95)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(75, 20)
        Me.btnPilih.TabIndex = 13
        Me.btnPilih.Text = "&Pilih Foto..."
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(311, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.WilayahBindingSource
        Me.ComboBox1.DisplayMember = "nama"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.ValueMember = "ID_wilayah"
        '
        'WilayahBindingSource
        '
        Me.WilayahBindingSource.DataMember = "wilayah"
        Me.WilayahBindingSource.DataSource = Me.KonsumenDataSet
        '
        'WilayahTableAdapter
        '
        Me.WilayahTableAdapter.ClearBeforeFill = True
        '
        'KonsumenBindingSource2
        '
        Me.KonsumenBindingSource2.DataMember = "konsumen"
        Me.KonsumenBindingSource2.DataSource = Me.KonsumenDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 319)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(Tgl_DaftarLabel)
        Me.Controls.Add(Me.Tgl_DaftarDateTimePicker)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(ID_wilayahLabel)
        Me.Controls.Add(Me.dgv)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD"
        CType(Me.KonsumenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KonsumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KonsumenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WilayahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KonsumenBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KonsumenDataSet As konsumenDataSet
    Friend WithEvents KonsumenBindingSource As BindingSource
    Friend WithEvents KonsumenTableAdapter As konsumenDataSetTableAdapters.konsumenTableAdapter
    Friend WithEvents TableAdapterManager As konsumenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgv As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglDaftarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDwilayahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KonsumenBindingSource1 As BindingSource
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents Tgl_DaftarDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPilih As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents WilayahBindingSource As BindingSource
    Friend WithEvents WilayahTableAdapter As konsumenDataSetTableAdapters.wilayahTableAdapter
    Friend WithEvents KonsumenBindingSource2 As BindingSource
End Class

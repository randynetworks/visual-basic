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
        Dim Id_supplierLabel As System.Windows.Forms.Label
        Dim Nama_supplierLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim No_telpLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Db_penjualanDataSet = New CRUD_2.db_penjualanDataSet()
        Me.Tb_supplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_supplierTableAdapter = New CRUD_2.db_penjualanDataSetTableAdapters.tb_supplierTableAdapter()
        Me.TableAdapterManager = New CRUD_2.db_penjualanDataSetTableAdapters.TableAdapterManager()
        Me.Id_supplierTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_supplierTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.No_telpTextBox = New System.Windows.Forms.TextBox()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.supplierDGV = New System.Windows.Forms.DataGridView()
        Me.IdsupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_supplierLabel = New System.Windows.Forms.Label()
        Nama_supplierLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        No_telpLabel = New System.Windows.Forms.Label()
        CType(Me.Db_penjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_supplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.supplierDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_supplierLabel
        '
        Id_supplierLabel.AutoSize = True
        Id_supplierLabel.Location = New System.Drawing.Point(29, 87)
        Id_supplierLabel.Name = "Id_supplierLabel"
        Id_supplierLabel.Size = New System.Drawing.Size(57, 13)
        Id_supplierLabel.TabIndex = 2
        Id_supplierLabel.Text = "id supplier:"
        '
        'Nama_supplierLabel
        '
        Nama_supplierLabel.AutoSize = True
        Nama_supplierLabel.Location = New System.Drawing.Point(29, 113)
        Nama_supplierLabel.Name = "Nama_supplierLabel"
        Nama_supplierLabel.Size = New System.Drawing.Size(75, 13)
        Nama_supplierLabel.TabIndex = 4
        Nama_supplierLabel.Text = "nama supplier:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(29, 139)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(41, 13)
        AlamatLabel.TabIndex = 6
        AlamatLabel.Text = "alamat:"
        '
        'No_telpLabel
        '
        No_telpLabel.AutoSize = True
        No_telpLabel.Location = New System.Drawing.Point(29, 211)
        No_telpLabel.Name = "No_telpLabel"
        No_telpLabel.Size = New System.Drawing.Size(42, 13)
        No_telpLabel.TabIndex = 8
        No_telpLabel.Text = "no telp:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Supplier"
        '
        'Db_penjualanDataSet
        '
        Me.Db_penjualanDataSet.DataSetName = "db_penjualanDataSet"
        Me.Db_penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_supplierBindingSource
        '
        Me.Tb_supplierBindingSource.DataMember = "tb_supplier"
        Me.Tb_supplierBindingSource.DataSource = Me.Db_penjualanDataSet
        '
        'Tb_supplierTableAdapter
        '
        Me.Tb_supplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_supplierTableAdapter = Me.Tb_supplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = CRUD_2.db_penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Id_supplierTextBox
        '
        Me.Id_supplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_supplierBindingSource, "id_supplier", True))
        Me.Id_supplierTextBox.Location = New System.Drawing.Point(110, 84)
        Me.Id_supplierTextBox.Name = "Id_supplierTextBox"
        Me.Id_supplierTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Id_supplierTextBox.TabIndex = 3
        '
        'Nama_supplierTextBox
        '
        Me.Nama_supplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_supplierBindingSource, "nama_supplier", True))
        Me.Nama_supplierTextBox.Location = New System.Drawing.Point(110, 110)
        Me.Nama_supplierTextBox.Name = "Nama_supplierTextBox"
        Me.Nama_supplierTextBox.Size = New System.Drawing.Size(181, 20)
        Me.Nama_supplierTextBox.TabIndex = 5
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_supplierBindingSource, "alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(110, 136)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(181, 66)
        Me.AlamatTextBox.TabIndex = 7
        '
        'No_telpTextBox
        '
        Me.No_telpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_supplierBindingSource, "no_telp", True))
        Me.No_telpTextBox.Location = New System.Drawing.Point(110, 208)
        Me.No_telpTextBox.Name = "No_telpTextBox"
        Me.No_telpTextBox.Size = New System.Drawing.Size(128, 20)
        Me.No_telpTextBox.TabIndex = 9
        '
        'btnBaru
        '
        Me.btnBaru.Location = New System.Drawing.Point(12, 253)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(75, 23)
        Me.btnBaru.TabIndex = 11
        Me.btnBaru.Text = "&Baru"
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(93, 253)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(255, 253)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 14
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(174, 253)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'supplierDGV
        '
        Me.supplierDGV.AutoGenerateColumns = False
        Me.supplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.supplierDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsupplierDataGridViewTextBoxColumn, Me.NamasupplierDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NotelpDataGridViewTextBoxColumn})
        Me.supplierDGV.DataSource = Me.Tb_supplierBindingSource
        Me.supplierDGV.Location = New System.Drawing.Point(12, 282)
        Me.supplierDGV.Name = "supplierDGV"
        Me.supplierDGV.ReadOnly = True
        Me.supplierDGV.Size = New System.Drawing.Size(318, 150)
        Me.supplierDGV.TabIndex = 15
        '
        'IdsupplierDataGridViewTextBoxColumn
        '
        Me.IdsupplierDataGridViewTextBoxColumn.DataPropertyName = "id_supplier"
        Me.IdsupplierDataGridViewTextBoxColumn.HeaderText = "id_supplier"
        Me.IdsupplierDataGridViewTextBoxColumn.Name = "IdsupplierDataGridViewTextBoxColumn"
        '
        'NamasupplierDataGridViewTextBoxColumn
        '
        Me.NamasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier"
        Me.NamasupplierDataGridViewTextBoxColumn.HeaderText = "nama_supplier"
        Me.NamasupplierDataGridViewTextBoxColumn.Name = "NamasupplierDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'NotelpDataGridViewTextBoxColumn
        '
        Me.NotelpDataGridViewTextBoxColumn.DataPropertyName = "no_telp"
        Me.NotelpDataGridViewTextBoxColumn.HeaderText = "no_telp"
        Me.NotelpDataGridViewTextBoxColumn.Name = "NotelpDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 443)
        Me.Controls.Add(Me.supplierDGV)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Id_supplierLabel)
        Me.Controls.Add(Me.Id_supplierTextBox)
        Me.Controls.Add(Nama_supplierLabel)
        Me.Controls.Add(Me.Nama_supplierTextBox)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(No_telpLabel)
        Me.Controls.Add(Me.No_telpTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Data Supplier"
        CType(Me.Db_penjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_supplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.supplierDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Db_penjualanDataSet As db_penjualanDataSet
    Friend WithEvents Tb_supplierBindingSource As BindingSource
    Friend WithEvents Tb_supplierTableAdapter As db_penjualanDataSetTableAdapters.tb_supplierTableAdapter
    Friend WithEvents TableAdapterManager As db_penjualanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_supplierTextBox As TextBox
    Friend WithEvents Nama_supplierTextBox As TextBox
    Friend WithEvents AlamatTextBox As TextBox
    Friend WithEvents No_telpTextBox As TextBox
    Friend WithEvents btnBaru As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents supplierDGV As DataGridView
    Friend WithEvents IdsupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamasupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotelpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

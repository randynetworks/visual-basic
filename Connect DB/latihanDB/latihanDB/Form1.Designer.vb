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
        Dim Label1 As System.Windows.Forms.Label
        Dim NPMLabel As System.Windows.Forms.Label
        Dim NamaLengkapLabel As System.Windows.Forms.Label
        Dim PanggilanLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim TempatTanggalLahirLabel As System.Windows.Forms.Label
        Dim NoTelpLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.LatihannDataSet = New latihanDB.latihannDataSet()
        Me.DataMahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataMahasiswaTableAdapter = New latihanDB.latihannDataSetTableAdapters.dataMahasiswaTableAdapter()
        Me.TableAdapterManager = New latihanDB.latihannDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NPMTextBox = New System.Windows.Forms.TextBox()
        Me.NamaLengkapTextBox = New System.Windows.Forms.TextBox()
        Me.PanggilanTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.TempatTanggalLahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoTelpTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        NPMLabel = New System.Windows.Forms.Label()
        NamaLengkapLabel = New System.Windows.Forms.Label()
        PanggilanLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        TempatTanggalLahirLabel = New System.Windows.Forms.Label()
        NoTelpLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.LatihannDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataMahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LatihannDataSet
        '
        Me.LatihannDataSet.DataSetName = "latihannDataSet"
        Me.LatihannDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataMahasiswaBindingSource
        '
        Me.DataMahasiswaBindingSource.DataMember = "dataMahasiswa"
        Me.DataMahasiswaBindingSource.DataSource = Me.LatihannDataSet
        '
        'DataMahasiswaTableAdapter
        '
        Me.DataMahasiswaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dataMahasiswaTableAdapter = Me.DataMahasiswaTableAdapter
        Me.TableAdapterManager.UpdateOrder = latihanDB.latihannDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.Control
        Label1.Location = New System.Drawing.Point(97, 12)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(369, 43)
        Label1.TabIndex = 15
        Label1.Text = "DATA MAHASISWA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(493, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NPMLabel)
        Me.GroupBox1.Controls.Add(Me.NPMTextBox)
        Me.GroupBox1.Controls.Add(NamaLengkapLabel)
        Me.GroupBox1.Controls.Add(Me.NamaLengkapTextBox)
        Me.GroupBox1.Controls.Add(PanggilanLabel)
        Me.GroupBox1.Controls.Add(Me.PanggilanTextBox)
        Me.GroupBox1.Controls.Add(AlamatLabel)
        Me.GroupBox1.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox1.Controls.Add(TempatTanggalLahirLabel)
        Me.GroupBox1.Controls.Add(Me.TempatTanggalLahirDateTimePicker)
        Me.GroupBox1.Controls.Add(NoTelpLabel)
        Me.GroupBox1.Controls.Add(Me.NoTelpTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 386)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'NPMLabel
        '
        NPMLabel.AutoSize = True
        NPMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NPMLabel.ForeColor = System.Drawing.SystemColors.Control
        NPMLabel.Location = New System.Drawing.Point(23, 29)
        NPMLabel.Name = "NPMLabel"
        NPMLabel.Size = New System.Drawing.Size(47, 20)
        NPMLabel.TabIndex = 15
        NPMLabel.Text = "NPM:"
        '
        'NPMTextBox
        '
        Me.NPMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataMahasiswaBindingSource, "NPM", True))
        Me.NPMTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NPMTextBox.Location = New System.Drawing.Point(191, 29)
        Me.NPMTextBox.Name = "NPMTextBox"
        Me.NPMTextBox.Size = New System.Drawing.Size(117, 26)
        Me.NPMTextBox.TabIndex = 16
        '
        'NamaLengkapLabel
        '
        NamaLengkapLabel.AutoSize = True
        NamaLengkapLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamaLengkapLabel.ForeColor = System.Drawing.SystemColors.Control
        NamaLengkapLabel.Location = New System.Drawing.Point(23, 67)
        NamaLengkapLabel.Name = "NamaLengkapLabel"
        NamaLengkapLabel.Size = New System.Drawing.Size(121, 20)
        NamaLengkapLabel.TabIndex = 17
        NamaLengkapLabel.Text = "Nama Lengkap:"
        '
        'NamaLengkapTextBox
        '
        Me.NamaLengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataMahasiswaBindingSource, "NamaLengkap", True))
        Me.NamaLengkapTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLengkapTextBox.Location = New System.Drawing.Point(191, 66)
        Me.NamaLengkapTextBox.Name = "NamaLengkapTextBox"
        Me.NamaLengkapTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NamaLengkapTextBox.TabIndex = 18
        '
        'PanggilanLabel
        '
        PanggilanLabel.AutoSize = True
        PanggilanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PanggilanLabel.ForeColor = System.Drawing.SystemColors.Control
        PanggilanLabel.Location = New System.Drawing.Point(23, 105)
        PanggilanLabel.Name = "PanggilanLabel"
        PanggilanLabel.Size = New System.Drawing.Size(83, 20)
        PanggilanLabel.TabIndex = 19
        PanggilanLabel.Text = "Panggilan:"
        '
        'PanggilanTextBox
        '
        Me.PanggilanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataMahasiswaBindingSource, "Panggilan", True))
        Me.PanggilanTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanggilanTextBox.Location = New System.Drawing.Point(191, 103)
        Me.PanggilanTextBox.Name = "PanggilanTextBox"
        Me.PanggilanTextBox.Size = New System.Drawing.Size(117, 26)
        Me.PanggilanTextBox.TabIndex = 20
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AlamatLabel.ForeColor = System.Drawing.SystemColors.Control
        AlamatLabel.Location = New System.Drawing.Point(23, 143)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(63, 20)
        AlamatLabel.TabIndex = 21
        AlamatLabel.Text = "Alamat:"
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataMahasiswaBindingSource, "alamat", True))
        Me.AlamatTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatTextBox.Location = New System.Drawing.Point(191, 143)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(200, 94)
        Me.AlamatTextBox.TabIndex = 22
        '
        'TempatTanggalLahirLabel
        '
        TempatTanggalLahirLabel.AutoSize = True
        TempatTanggalLahirLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TempatTanggalLahirLabel.ForeColor = System.Drawing.SystemColors.Control
        TempatTanggalLahirLabel.Location = New System.Drawing.Point(23, 259)
        TempatTanggalLahirLabel.Name = "TempatTanggalLahirLabel"
        TempatTanggalLahirLabel.Size = New System.Drawing.Size(163, 20)
        TempatTanggalLahirLabel.TabIndex = 23
        TempatTanggalLahirLabel.Text = "tempat Tanggal Lahir:"
        '
        'TempatTanggalLahirDateTimePicker
        '
        Me.TempatTanggalLahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataMahasiswaBindingSource, "tempatTanggalLahir", True))
        Me.TempatTanggalLahirDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempatTanggalLahirDateTimePicker.Location = New System.Drawing.Point(191, 255)
        Me.TempatTanggalLahirDateTimePicker.Name = "TempatTanggalLahirDateTimePicker"
        Me.TempatTanggalLahirDateTimePicker.Size = New System.Drawing.Size(273, 26)
        Me.TempatTanggalLahirDateTimePicker.TabIndex = 24
        '
        'NoTelpLabel
        '
        NoTelpLabel.AutoSize = True
        NoTelpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoTelpLabel.ForeColor = System.Drawing.SystemColors.Control
        NoTelpLabel.Location = New System.Drawing.Point(23, 305)
        NoTelpLabel.Name = "NoTelpLabel"
        NoTelpLabel.Size = New System.Drawing.Size(67, 20)
        NoTelpLabel.TabIndex = 25
        NoTelpLabel.Text = "No Telp:"
        '
        'NoTelpTextBox
        '
        Me.NoTelpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataMahasiswaBindingSource, "NoTelp", True))
        Me.NoTelpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTelpTextBox.Location = New System.Drawing.Point(191, 300)
        Me.NoTelpTextBox.Name = "NoTelpTextBox"
        Me.NoTelpTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NoTelpTextBox.TabIndex = 26
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.Control
        EmailLabel.Location = New System.Drawing.Point(23, 343)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(50, 20)
        EmailLabel.TabIndex = 27
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataMahasiswaBindingSource, "email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(191, 337)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 26)
        Me.EmailTextBox.TabIndex = 28
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(54, 471)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 33)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Tag = ""
        Me.btnBack.Text = "<<<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(136, 471)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 33)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save Data"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(300, 471)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 33)
        Me.btnNew.TabIndex = 21
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(218, 471)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(382, 471)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 33)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = ">>>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(533, 525)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Mahasiwa"
        CType(Me.LatihannDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataMahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LatihannDataSet As latihannDataSet
    Friend WithEvents DataMahasiswaBindingSource As BindingSource
    Friend WithEvents DataMahasiswaTableAdapter As latihannDataSetTableAdapters.dataMahasiswaTableAdapter
    Friend WithEvents TableAdapterManager As latihannDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NPMTextBox As TextBox
    Friend WithEvents NamaLengkapTextBox As TextBox
    Friend WithEvents PanggilanTextBox As TextBox
    Friend WithEvents AlamatTextBox As TextBox
    Friend WithEvents TempatTanggalLahirDateTimePicker As DateTimePicker
    Friend WithEvents NoTelpTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNext As Button
End Class

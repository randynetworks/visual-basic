<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmcoba
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cboJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.cboFakultas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fakultas"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(150, 25)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(144, 20)
        Me.txtnama.TabIndex = 3
        '
        'cboJenisKelamin
        '
        Me.cboJenisKelamin.FormattingEnabled = True
        Me.cboJenisKelamin.Items.AddRange(New Object() {" Laki - Laki", " Perempuan"})
        Me.cboJenisKelamin.Location = New System.Drawing.Point(150, 51)
        Me.cboJenisKelamin.Name = "cboJenisKelamin"
        Me.cboJenisKelamin.Size = New System.Drawing.Size(144, 21)
        Me.cboJenisKelamin.TabIndex = 4
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(150, 106)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(144, 23)
        Me.btnTampilkan.TabIndex = 6
        Me.btnTampilkan.Text = "Tampilkan Data"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'cboFakultas
        '
        Me.cboFakultas.FormattingEnabled = True
        Me.cboFakultas.Items.AddRange(New Object() {" MSI", " MIF", " TIK", " KMA"})
        Me.cboFakultas.Location = New System.Drawing.Point(150, 78)
        Me.cboFakultas.Name = "cboFakultas"
        Me.cboFakultas.Size = New System.Drawing.Size(144, 21)
        Me.cboFakultas.TabIndex = 5
        '
        'Frmcoba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 161)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.cboFakultas)
        Me.Controls.Add(Me.cboJenisKelamin)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmcoba"
        Me.Text = "Percobaan Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents cboJenisKelamin As ComboBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents cboFakultas As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class kalkulatorsimple
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
        Me.tbAngka1 = New System.Windows.Forms.TextBox()
        Me.tbAngka2 = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKurang = New System.Windows.Forms.Button()
        Me.btnKali = New System.Windows.Forms.Button()
        Me.btnBagi = New System.Windows.Forms.Button()
        Me.tbHasil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka 2"
        '
        'tbAngka1
        '
        Me.tbAngka1.Location = New System.Drawing.Point(36, 38)
        Me.tbAngka1.Name = "tbAngka1"
        Me.tbAngka1.Size = New System.Drawing.Size(100, 20)
        Me.tbAngka1.TabIndex = 2
        '
        'tbAngka2
        '
        Me.tbAngka2.Location = New System.Drawing.Point(36, 88)
        Me.tbAngka2.Name = "tbAngka2"
        Me.tbAngka2.Size = New System.Drawing.Size(100, 20)
        Me.tbAngka2.TabIndex = 3
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(153, 38)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(82, 26)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "+"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnKurang
        '
        Me.btnKurang.Location = New System.Drawing.Point(153, 70)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(82, 26)
        Me.btnKurang.TabIndex = 5
        Me.btnKurang.Text = "-"
        Me.btnKurang.UseVisualStyleBackColor = True
        '
        'btnKali
        '
        Me.btnKali.Location = New System.Drawing.Point(153, 102)
        Me.btnKali.Name = "btnKali"
        Me.btnKali.Size = New System.Drawing.Size(82, 26)
        Me.btnKali.TabIndex = 6
        Me.btnKali.Text = "*"
        Me.btnKali.UseVisualStyleBackColor = True
        '
        'btnBagi
        '
        Me.btnBagi.Location = New System.Drawing.Point(153, 134)
        Me.btnBagi.Name = "btnBagi"
        Me.btnBagi.Size = New System.Drawing.Size(82, 26)
        Me.btnBagi.TabIndex = 7
        Me.btnBagi.Text = "/"
        Me.btnBagi.UseVisualStyleBackColor = True
        '
        'tbHasil
        '
        Me.tbHasil.Location = New System.Drawing.Point(36, 140)
        Me.tbHasil.Name = "tbHasil"
        Me.tbHasil.Size = New System.Drawing.Size(100, 20)
        Me.tbHasil.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hasil"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(36, 175)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(199, 26)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'kalkulatorsimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 223)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbHasil)
        Me.Controls.Add(Me.btnBagi)
        Me.Controls.Add(Me.btnKali)
        Me.Controls.Add(Me.btnKurang)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.tbAngka2)
        Me.Controls.Add(Me.tbAngka1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "kalkulatorsimple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alex's Calculator Simple"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbAngka1 As TextBox
    Friend WithEvents tbAngka2 As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnKali As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents tbHasil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHapus As Button
End Class

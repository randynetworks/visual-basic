<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHitungNilai
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTatapMuka = New System.Windows.Forms.TextBox()
        Me.tbMidTest = New System.Windows.Forms.TextBox()
        Me.tbFinalTest = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbHasil = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tatap Muka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mid Test"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Final Test"
        '
        'tbTatapMuka
        '
        Me.tbTatapMuka.Location = New System.Drawing.Point(107, 79)
        Me.tbTatapMuka.Name = "tbTatapMuka"
        Me.tbTatapMuka.Size = New System.Drawing.Size(109, 20)
        Me.tbTatapMuka.TabIndex = 3
        '
        'tbMidTest
        '
        Me.tbMidTest.Location = New System.Drawing.Point(107, 106)
        Me.tbMidTest.Name = "tbMidTest"
        Me.tbMidTest.Size = New System.Drawing.Size(109, 20)
        Me.tbMidTest.TabIndex = 4
        '
        'tbFinalTest
        '
        Me.tbFinalTest.Location = New System.Drawing.Point(107, 132)
        Me.tbFinalTest.Name = "tbFinalTest"
        Me.tbFinalTest.Size = New System.Drawing.Size(109, 20)
        Me.tbFinalTest.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Perhitungan Nilai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hasil"
        '
        'tbHasil
        '
        Me.tbHasil.Location = New System.Drawing.Point(107, 199)
        Me.tbHasil.Name = "tbHasil"
        Me.tbHasil.Size = New System.Drawing.Size(109, 20)
        Me.tbHasil.TabIndex = 8
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(107, 159)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(109, 34)
        Me.btnHitung.TabIndex = 9
        Me.btnHitung.Text = "Hitung Nilai"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'frmHitungNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 251)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.tbHasil)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbFinalTest)
        Me.Controls.Add(Me.tbMidTest)
        Me.Controls.Add(Me.tbTatapMuka)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHitungNilai"
        Me.Text = "Perhitungan Nilai Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTatapMuka As TextBox
    Friend WithEvents tbMidTest As TextBox
    Friend WithEvents tbFinalTest As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbHasil As TextBox
    Friend WithEvents btnHitung As Button
End Class

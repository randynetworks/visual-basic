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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAngka1 = New System.Windows.Forms.TextBox()
        Me.tbAngka2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbBagi = New System.Windows.Forms.Label()
        Me.lbkali = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbbagi = New System.Windows.Forms.TextBox()
        Me.tbkali = New System.Windows.Forms.TextBox()
        Me.tbtambah = New System.Windows.Forms.TextBox()
        Me.tbkurang = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculator Sederhana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka Pertama"
        '
        'tbAngka1
        '
        Me.tbAngka1.Location = New System.Drawing.Point(15, 84)
        Me.tbAngka1.Name = "tbAngka1"
        Me.tbAngka1.Size = New System.Drawing.Size(100, 20)
        Me.tbAngka1.TabIndex = 2
        '
        'tbAngka2
        '
        Me.tbAngka2.Location = New System.Drawing.Point(15, 130)
        Me.tbAngka2.Name = "tbAngka2"
        Me.tbAngka2.Size = New System.Drawing.Size(100, 20)
        Me.tbAngka2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Angka Kedua"
        '
        'lbBagi
        '
        Me.lbBagi.AutoSize = True
        Me.lbBagi.Location = New System.Drawing.Point(131, 101)
        Me.lbBagi.Name = "lbBagi"
        Me.lbBagi.Size = New System.Drawing.Size(28, 13)
        Me.lbBagi.TabIndex = 6
        Me.lbBagi.Text = "Bagi"
        '
        'lbkali
        '
        Me.lbkali.AutoSize = True
        Me.lbkali.Location = New System.Drawing.Point(131, 67)
        Me.lbkali.Name = "lbkali"
        Me.lbkali.Size = New System.Drawing.Size(24, 13)
        Me.lbkali.TabIndex = 5
        Me.lbkali.Text = "Kali"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "tambah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "kurang"
        '
        'tbbagi
        '
        Me.tbbagi.Location = New System.Drawing.Point(192, 101)
        Me.tbbagi.Name = "tbbagi"
        Me.tbbagi.Size = New System.Drawing.Size(100, 20)
        Me.tbbagi.TabIndex = 10
        '
        'tbkali
        '
        Me.tbkali.Location = New System.Drawing.Point(192, 64)
        Me.tbkali.Name = "tbkali"
        Me.tbkali.Size = New System.Drawing.Size(100, 20)
        Me.tbkali.TabIndex = 9
        '
        'tbtambah
        '
        Me.tbtambah.Location = New System.Drawing.Point(192, 164)
        Me.tbtambah.Name = "tbtambah"
        Me.tbtambah.Size = New System.Drawing.Size(100, 20)
        Me.tbtambah.TabIndex = 12
        '
        'tbkurang
        '
        Me.tbkurang.Location = New System.Drawing.Point(192, 133)
        Me.tbkurang.Name = "tbkurang"
        Me.tbkurang.Size = New System.Drawing.Size(100, 20)
        Me.tbkurang.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Hasil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 203)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbtambah)
        Me.Controls.Add(Me.tbkurang)
        Me.Controls.Add(Me.tbbagi)
        Me.Controls.Add(Me.tbkali)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbBagi)
        Me.Controls.Add(Me.lbkali)
        Me.Controls.Add(Me.tbAngka2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbAngka1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbAngka1 As TextBox
    Friend WithEvents tbAngka2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbBagi As Label
    Friend WithEvents lbkali As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbbagi As TextBox
    Friend WithEvents tbkali As TextBox
    Friend WithEvents tbtambah As TextBox
    Friend WithEvents tbkurang As TextBox
    Friend WithEvents Button1 As Button
End Class

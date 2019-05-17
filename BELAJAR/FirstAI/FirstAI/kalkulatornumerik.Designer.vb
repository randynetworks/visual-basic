<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kalkulatornumerik
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHasil = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnTitik = New System.Windows.Forms.Button()
        Me.btnKurang = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnBagi = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnKali = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Fax", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 39)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(216, 24)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 38)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(216, 241)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(60, 48)
        Me.btnTambah.TabIndex = 32
        Me.btnTambah.Text = "+"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHasil
        '
        Me.btnHasil.BackColor = System.Drawing.Color.Blue
        Me.btnHasil.FlatAppearance.BorderSize = 0
        Me.btnHasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHasil.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnHasil.Location = New System.Drawing.Point(150, 241)
        Me.btnHasil.Name = "btnHasil"
        Me.btnHasil.Size = New System.Drawing.Size(60, 48)
        Me.btnHasil.TabIndex = 31
        Me.btnHasil.Text = "="
        Me.btnHasil.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(84, 241)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(60, 48)
        Me.btn0.TabIndex = 30
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnTitik
        '
        Me.btnTitik.Location = New System.Drawing.Point(18, 241)
        Me.btnTitik.Name = "btnTitik"
        Me.btnTitik.Size = New System.Drawing.Size(60, 48)
        Me.btnTitik.TabIndex = 29
        Me.btnTitik.Text = "."
        Me.btnTitik.UseVisualStyleBackColor = True
        '
        'btnKurang
        '
        Me.btnKurang.Location = New System.Drawing.Point(216, 187)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(60, 48)
        Me.btnKurang.TabIndex = 28
        Me.btnKurang.Text = "-"
        Me.btnKurang.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(150, 187)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(60, 48)
        Me.btn3.TabIndex = 27
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(84, 187)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(60, 48)
        Me.btn2.TabIndex = 26
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(18, 187)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(60, 48)
        Me.btn1.TabIndex = 25
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnBagi
        '
        Me.btnBagi.Location = New System.Drawing.Point(216, 133)
        Me.btnBagi.Name = "btnBagi"
        Me.btnBagi.Size = New System.Drawing.Size(60, 48)
        Me.btnBagi.TabIndex = 24
        Me.btnBagi.Text = "/"
        Me.btnBagi.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(150, 133)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(60, 48)
        Me.btn6.TabIndex = 23
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(84, 133)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(60, 48)
        Me.btn5.TabIndex = 22
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(18, 133)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(60, 48)
        Me.btn4.TabIndex = 21
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnKali
        '
        Me.btnKali.Location = New System.Drawing.Point(216, 79)
        Me.btnKali.Name = "btnKali"
        Me.btnKali.Size = New System.Drawing.Size(60, 48)
        Me.btnKali.TabIndex = 20
        Me.btnKali.Text = "x"
        Me.btnKali.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(150, 79)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(60, 48)
        Me.btn9.TabIndex = 19
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(84, 79)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(60, 48)
        Me.btn8.TabIndex = 18
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(18, 79)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(60, 48)
        Me.btn7.TabIndex = 17
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'kalkulatornumerik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 318)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHasil)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnTitik)
        Me.Controls.Add(Me.btnKurang)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnBagi)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnKali)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "kalkulatornumerik"
        Me.Text = "Alex's Calkulator Numerik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHasil As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnTitik As Button
    Friend WithEvents btnKurang As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnKali As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
End Class

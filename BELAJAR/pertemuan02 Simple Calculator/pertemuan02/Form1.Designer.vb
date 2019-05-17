<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkalkulator
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
        Me.txtangka1 = New System.Windows.Forms.TextBox()
        Me.txtangka2 = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnkurang = New System.Windows.Forms.Button()
        Me.btnkali = New System.Windows.Forms.Button()
        Me.btnbagi = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txthasil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka Pertama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka Kedua"
        '
        'txtangka1
        '
        Me.txtangka1.Location = New System.Drawing.Point(156, 48)
        Me.txtangka1.Name = "txtangka1"
        Me.txtangka1.Size = New System.Drawing.Size(137, 20)
        Me.txtangka1.TabIndex = 2
        '
        'txtangka2
        '
        Me.txtangka2.Location = New System.Drawing.Point(156, 77)
        Me.txtangka2.Name = "txtangka2"
        Me.txtangka2.Size = New System.Drawing.Size(137, 20)
        Me.txtangka2.TabIndex = 3
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(59, 111)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(54, 23)
        Me.btntambah.TabIndex = 4
        Me.btntambah.Text = "+"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnkurang
        '
        Me.btnkurang.Location = New System.Drawing.Point(119, 111)
        Me.btnkurang.Name = "btnkurang"
        Me.btnkurang.Size = New System.Drawing.Size(54, 23)
        Me.btnkurang.TabIndex = 5
        Me.btnkurang.Text = "-"
        Me.btnkurang.UseVisualStyleBackColor = True
        '
        'btnkali
        '
        Me.btnkali.Location = New System.Drawing.Point(179, 111)
        Me.btnkali.Name = "btnkali"
        Me.btnkali.Size = New System.Drawing.Size(54, 23)
        Me.btnkali.TabIndex = 6
        Me.btnkali.Text = "*"
        Me.btnkali.UseVisualStyleBackColor = True
        '
        'btnbagi
        '
        Me.btnbagi.Location = New System.Drawing.Point(239, 111)
        Me.btnbagi.Name = "btnbagi"
        Me.btnbagi.Size = New System.Drawing.Size(54, 23)
        Me.btnbagi.TabIndex = 7
        Me.btnbagi.Text = "/"
        Me.btnbagi.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hasil"
        '
        'txthasil
        '
        Me.txthasil.Location = New System.Drawing.Point(156, 145)
        Me.txthasil.Name = "txthasil"
        Me.txthasil.Size = New System.Drawing.Size(137, 20)
        Me.txthasil.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Let's Calculate!"
        '
        'frmkalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 187)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txthasil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbagi)
        Me.Controls.Add(Me.btnkali)
        Me.Controls.Add(Me.btnkurang)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtangka2)
        Me.Controls.Add(Me.txtangka1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmkalkulator"
        Me.Text = "Simple Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtangka1 As TextBox
    Friend WithEvents txtangka2 As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnkurang As Button
    Friend WithEvents btnkali As Button
    Friend WithEvents btnbagi As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txthasil As TextBox
    Friend WithEvents Label4 As Label
End Class

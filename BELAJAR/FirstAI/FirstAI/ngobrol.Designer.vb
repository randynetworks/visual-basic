<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ngobrol
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
        Me.cbPertanyaan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAyo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbPertanyaan
        '
        Me.cbPertanyaan.FormattingEnabled = True
        Me.cbPertanyaan.Items.AddRange(New Object() {"Hari ini ngapain?", "Udah makan belum?", "Mau pergi kemana hari ini?", "Suasananya gimana disana?", "Dingin engga?"})
        Me.cbPertanyaan.Location = New System.Drawing.Point(12, 35)
        Me.cbPertanyaan.Name = "cbPertanyaan"
        Me.cbPertanyaan.Size = New System.Drawing.Size(188, 21)
        Me.cbPertanyaan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kamu mau ngobrol apa?"
        '
        'btnAyo
        '
        Me.btnAyo.Location = New System.Drawing.Point(216, 12)
        Me.btnAyo.Name = "btnAyo"
        Me.btnAyo.Size = New System.Drawing.Size(60, 44)
        Me.btnAyo.TabIndex = 2
        Me.btnAyo.Text = "Ayo!"
        Me.btnAyo.UseVisualStyleBackColor = True
        '
        'ngobrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 68)
        Me.Controls.Add(Me.btnAyo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPertanyaan)
        Me.Name = "ngobrol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ngobrol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPertanyaan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAyo As Button
End Class

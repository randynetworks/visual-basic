<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPasien = New System.Windows.Forms.Button()
        Me.dataPenyakit = New System.Windows.Forms.Button()
        Me.DataDokter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.DataDokter)
        Me.GroupBox1.Controls.Add(Me.dataPenyakit)
        Me.GroupBox1.Controls.Add(Me.btnPasien)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(996, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnPasien
        '
        Me.btnPasien.Location = New System.Drawing.Point(2, 9)
        Me.btnPasien.Name = "btnPasien"
        Me.btnPasien.Size = New System.Drawing.Size(100, 43)
        Me.btnPasien.TabIndex = 0
        Me.btnPasien.Text = "Data Pasien"
        Me.btnPasien.UseVisualStyleBackColor = True
        '
        'dataPenyakit
        '
        Me.dataPenyakit.Location = New System.Drawing.Point(108, 9)
        Me.dataPenyakit.Name = "dataPenyakit"
        Me.dataPenyakit.Size = New System.Drawing.Size(100, 43)
        Me.dataPenyakit.TabIndex = 1
        Me.dataPenyakit.Text = "Data Penyakit"
        Me.dataPenyakit.UseVisualStyleBackColor = True
        '
        'DataDokter
        '
        Me.DataDokter.Location = New System.Drawing.Point(214, 9)
        Me.DataDokter.Name = "DataDokter"
        Me.DataDokter.Size = New System.Drawing.Size(100, 43)
        Me.DataDokter.TabIndex = 2
        Me.DataDokter.Text = "Data Dokter"
        Me.DataDokter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(890, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 43)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = Global.pertemuan10.My.Resources.Resources.LOGO_100
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(996, 853)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPasien As Button
    Friend WithEvents DataDokter As Button
    Friend WithEvents dataPenyakit As Button
    Friend WithEvents btnExit As Button
End Class

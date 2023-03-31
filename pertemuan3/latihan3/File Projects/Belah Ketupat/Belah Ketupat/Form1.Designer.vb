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
        Me.txtSisi = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtD2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtD1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtSisi
        '
        Me.txtSisi.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSisi.Location = New System.Drawing.Point(371, 298)
        Me.txtSisi.Name = "txtSisi"
        Me.txtSisi.Size = New System.Drawing.Size(191, 29)
        Me.txtSisi.TabIndex = 0
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.Lime
        Me.btnHitung.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(395, 349)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(128, 36)
        Me.btnHitung.TabIndex = 1
        Me.btnHitung.Text = "Hitung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'txtLuas
        '
        Me.txtLuas.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuas.Location = New System.Drawing.Point(371, 405)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(191, 29)
        Me.txtLuas.TabIndex = 2
        '
        'txtKeliling
        '
        Me.txtKeliling.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeliling.Location = New System.Drawing.Point(371, 460)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(191, 29)
        Me.txtKeliling.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(212, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sisi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(215, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Luas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(212, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Keliling" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(80, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(700, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Program Menghitung Luas dan Kelilling Belah Ketupat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(212, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Diagonal 2"
        '
        'txtD2
        '
        Me.txtD2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD2.Location = New System.Drawing.Point(371, 236)
        Me.txtD2.Name = "txtD2"
        Me.txtD2.Size = New System.Drawing.Size(191, 29)
        Me.txtD2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(212, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Diagonal 1"
        '
        'txtD1
        '
        Me.txtD1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtD1.Location = New System.Drawing.Point(371, 181)
        Me.txtD1.Name = "txtD1"
        Me.txtD1.Size = New System.Drawing.Size(191, 29)
        Me.txtD1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(858, 597)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtD1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtD2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtSisi)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Belah Ketupat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisi As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtD2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtD1 As TextBox
End Class

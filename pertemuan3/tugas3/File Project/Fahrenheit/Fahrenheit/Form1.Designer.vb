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
        Me.btnKonversi = New System.Windows.Forms.Button()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnKonversi
        '
        Me.btnKonversi.BackColor = System.Drawing.Color.Lime
        Me.btnKonversi.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKonversi.Location = New System.Drawing.Point(245, 206)
        Me.btnKonversi.Name = "btnKonversi"
        Me.btnKonversi.Size = New System.Drawing.Size(128, 36)
        Me.btnKonversi.TabIndex = 1
        Me.btnKonversi.Text = "Konversi"
        Me.btnKonversi.UseVisualStyleBackColor = False
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(223, 151)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(191, 29)
        Me.txtFahrenheit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(81, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fahrenheit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(81, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Reamur"
        '
        'txtReamur
        '
        Me.txtReamur.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReamur.Location = New System.Drawing.Point(223, 262)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(191, 29)
        Me.txtReamur.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(103, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(325, 87)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Program Konversi Suhu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fahrenheit ke Reamur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(549, 361)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.btnKonversi)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konversi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKonversi As Button
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents Label7 As Label
End Class

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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReamur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKelvin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FloralWhite
        Me.btnConvert.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.Purple
        Me.btnConvert.Location = New System.Drawing.Point(263, 216)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(205, 58)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.BackColor = System.Drawing.Color.FloralWhite
        Me.txtFahrenheit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFahrenheit.Location = New System.Drawing.Point(238, 364)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(255, 29)
        Me.txtFahrenheit.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label2.Location = New System.Drawing.Point(89, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fahrenheit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label6.Location = New System.Drawing.Point(89, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Celcius"
        '
        'txtCelcius
        '
        Me.txtCelcius.BackColor = System.Drawing.Color.FloralWhite
        Me.txtCelcius.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelcius.Location = New System.Drawing.Point(238, 307)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(255, 29)
        Me.txtCelcius.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label7.Location = New System.Drawing.Point(101, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(425, 58)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Program Konversi Suhu Kelvin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ke Celcius, Fahrenheit, Reamur"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(89, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Reamur"
        '
        'txtReamur
        '
        Me.txtReamur.BackColor = System.Drawing.Color.FloralWhite
        Me.txtReamur.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReamur.Location = New System.Drawing.Point(238, 425)
        Me.txtReamur.Name = "txtReamur"
        Me.txtReamur.Size = New System.Drawing.Size(255, 29)
        Me.txtReamur.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label3.Location = New System.Drawing.Point(89, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Kelvin"
        '
        'txtKelvin
        '
        Me.txtKelvin.BackColor = System.Drawing.Color.FloralWhite
        Me.txtKelvin.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKelvin.Location = New System.Drawing.Point(238, 156)
        Me.txtKelvin.Name = "txtKelvin"
        Me.txtKelvin.Size = New System.Drawing.Size(255, 29)
        Me.txtKelvin.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(619, 515)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKelvin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReamur)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.btnConvert)
        Me.ForeColor = System.Drawing.Color.Purple
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConvert As Button
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKelvin As TextBox
End Class

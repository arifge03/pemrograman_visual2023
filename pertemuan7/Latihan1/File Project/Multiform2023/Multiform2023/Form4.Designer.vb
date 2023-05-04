<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Form2 = New System.Windows.Forms.Button()
        Me.Form5 = New System.Windows.Forms.Button()
        Me.Form1 = New System.Windows.Forms.Button()
        Me.Form3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 46)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Form 4"
        '
        'Form2
        '
        Me.Form2.Location = New System.Drawing.Point(199, 86)
        Me.Form2.Name = "Form2"
        Me.Form2.Size = New System.Drawing.Size(75, 47)
        Me.Form2.TabIndex = 19
        Me.Form2.Text = "Form 2"
        Me.Form2.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.Form5.Location = New System.Drawing.Point(199, 192)
        Me.Form5.Name = "Form5"
        Me.Form5.Size = New System.Drawing.Size(75, 47)
        Me.Form5.TabIndex = 18
        Me.Form5.Text = "Form 5"
        Me.Form5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.Form1.Location = New System.Drawing.Point(199, 33)
        Me.Form1.Name = "Form1"
        Me.Form1.Size = New System.Drawing.Size(75, 47)
        Me.Form1.TabIndex = 16
        Me.Form1.Text = "Form 1"
        Me.Form1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.Form3.Location = New System.Drawing.Point(199, 139)
        Me.Form3.Name = "Form3"
        Me.Form3.Size = New System.Drawing.Size(75, 47)
        Me.Form3.TabIndex = 20
        Me.Form3.Text = "Form 3"
        Me.Form3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 269)
        Me.Controls.Add(Me.Form3)
        Me.Controls.Add(Me.Form2)
        Me.Controls.Add(Me.Form5)
        Me.Controls.Add(Me.Form1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Form2 As Button
    Friend WithEvents Form5 As Button
    Friend WithEvents Form1 As Button
    Friend WithEvents Form3 As Button
End Class

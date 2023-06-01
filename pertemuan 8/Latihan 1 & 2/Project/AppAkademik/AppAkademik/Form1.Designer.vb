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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtJK = New System.Windows.Forms.TextBox()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 359)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(867, 324)
        Me.DataGridView1.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(729, 81)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 45)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(292, 61)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(318, 26)
        Me.txtNIM.TabIndex = 2
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(292, 126)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(318, 26)
        Me.txtNama.TabIndex = 3
        '
        'txtJK
        '
        Me.txtJK.Location = New System.Drawing.Point(292, 201)
        Me.txtJK.Name = "txtJK"
        Me.txtJK.Size = New System.Drawing.Size(318, 26)
        Me.txtJK.TabIndex = 4
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(292, 271)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(318, 26)
        Me.txtProdi.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Prodi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 709)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.txtJK)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReset As Button
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtJK As TextBox
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKamar))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtHARGA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJENISKAMAR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNMKAMAR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(542, 205)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 40)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(542, 102)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(141, 40)
        Me.btnSubmit.TabIndex = 34
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(542, 152)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(141, 40)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtHARGA
        '
        Me.txtHARGA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHARGA.Location = New System.Drawing.Point(168, 211)
        Me.txtHARGA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHARGA.Name = "txtHARGA"
        Me.txtHARGA.Size = New System.Drawing.Size(302, 28)
        Me.txtHARGA.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Harga"
        '
        'txtJENISKAMAR
        '
        Me.txtJENISKAMAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJENISKAMAR.Location = New System.Drawing.Point(168, 157)
        Me.txtJENISKAMAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJENISKAMAR.Name = "txtJENISKAMAR"
        Me.txtJENISKAMAR.Size = New System.Drawing.Size(302, 28)
        Me.txtJENISKAMAR.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Jenis Kamar"
        '
        'txtNMKAMAR
        '
        Me.txtNMKAMAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNMKAMAR.Location = New System.Drawing.Point(168, 107)
        Me.txtNMKAMAR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNMKAMAR.Name = "txtNMKAMAR"
        Me.txtNMKAMAR.Size = New System.Drawing.Size(302, 28)
        Me.txtNMKAMAR.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Kamar"
        '
        'dgvData
        '
        Me.dgvData.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.GridColor = System.Drawing.Color.Yellow
        Me.dgvData.Location = New System.Drawing.Point(25, 254)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(658, 304)
        Me.dgvData.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(285, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 32)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Daftar Kamar"
        '
        'FormKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(723, 581)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtHARGA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJENISKAMAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNMKAMAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormKamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kamar"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtHARGA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJENISKAMAR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNMKAMAR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label1 As Label
End Class

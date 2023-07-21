<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPSSWD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUSERNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbPenyewa = New System.Windows.Forms.RadioButton()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(284, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 32)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Form Registrasi"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(559, 233)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 40)
        Me.btnDelete.TabIndex = 68
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(559, 130)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(141, 40)
        Me.btnSubmit.TabIndex = 67
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(559, 180)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(141, 40)
        Me.btnClear.TabIndex = 66
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Rolename"
        '
        'txtPSSWD
        '
        Me.txtPSSWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPSSWD.Location = New System.Drawing.Point(183, 191)
        Me.txtPSSWD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPSSWD.Name = "txtPSSWD"
        Me.txtPSSWD.Size = New System.Drawing.Size(299, 28)
        Me.txtPSSWD.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 24)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Password"
        '
        'txtUSERNAME
        '
        Me.txtUSERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSERNAME.Location = New System.Drawing.Point(183, 141)
        Me.txtUSERNAME.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUSERNAME.Name = "txtUSERNAME"
        Me.txtUSERNAME.Size = New System.Drawing.Size(299, 28)
        Me.txtUSERNAME.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Username"
        '
        'dgvData
        '
        Me.dgvData.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.GridColor = System.Drawing.Color.Yellow
        Me.dgvData.Location = New System.Drawing.Point(40, 288)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(660, 304)
        Me.dgvData.TabIndex = 59
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.BackColor = System.Drawing.Color.MediumOrchid
        Me.rbAdmin.Location = New System.Drawing.Point(183, 249)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(79, 24)
        Me.rbAdmin.TabIndex = 70
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = False
        '
        'rbPenyewa
        '
        Me.rbPenyewa.AutoSize = True
        Me.rbPenyewa.BackColor = System.Drawing.Color.MediumOrchid
        Me.rbPenyewa.Location = New System.Drawing.Point(384, 249)
        Me.rbPenyewa.Name = "rbPenyewa"
        Me.rbPenyewa.Size = New System.Drawing.Size(98, 24)
        Me.rbPenyewa.TabIndex = 71
        Me.rbPenyewa.TabStop = True
        Me.rbPenyewa.Text = "Penyewa"
        Me.rbPenyewa.UseVisualStyleBackColor = False
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(748, 630)
        Me.Controls.Add(Me.rbPenyewa)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPSSWD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUSERNAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPSSWD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUSERNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbPenyewa As RadioButton
End Class

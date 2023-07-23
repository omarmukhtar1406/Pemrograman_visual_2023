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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSP = New System.Windows.Forms.TextBox()
        Me.txtJK = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(328, 59)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(328, 89)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(328, 118)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 174)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(391, 200)
        Me.dgvData.TabIndex = 3
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(88, 45)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(172, 20)
        Me.txtNIP.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Spesialis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "JK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nama"
        '
        'txtSP
        '
        Me.txtSP.Location = New System.Drawing.Point(88, 135)
        Me.txtSP.Name = "txtSP"
        Me.txtSP.Size = New System.Drawing.Size(172, 20)
        Me.txtSP.TabIndex = 9
        '
        'txtJK
        '
        Me.txtJK.Location = New System.Drawing.Point(88, 105)
        Me.txtJK.Name = "txtJK"
        Me.txtJK.Size = New System.Drawing.Size(172, 20)
        Me.txtJK.TabIndex = 10
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(88, 75)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(172, 20)
        Me.txtNama.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quiz Visual 2023_Omar Mukhtariansyah_200511098_20TIF D"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 386)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtJK)
        Me.Controls.Add(Me.txtSP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dokter"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSP As TextBox
    Friend WithEvents txtJK As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
End Class

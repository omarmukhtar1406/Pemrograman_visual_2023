<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenyewa
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
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtTOTALBIAYA = New System.Windows.Forms.TextBox()
        Me.txtTELEPON = New System.Windows.Forms.TextBox()
        Me.txtNMPENYEWA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.txtMASUK = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKELUAR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJUMLAHHARI = New System.Windows.Forms.TextBox()
        Me.txtIDMOBIL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNMMOBIL = New System.Windows.Forms.TextBox()
        Me.txtHARGA = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 304)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(910, 150)
        Me.dgvData.TabIndex = 35
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Thistle
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(151, 274)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 24)
        Me.btnClear.TabIndex = 34
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Magenta
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(686, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 24)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Violet
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(415, 274)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 24)
        Me.btnSubmit.TabIndex = 32
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtTOTALBIAYA
        '
        Me.txtTOTALBIAYA.Location = New System.Drawing.Point(393, 238)
        Me.txtTOTALBIAYA.Name = "txtTOTALBIAYA"
        Me.txtTOTALBIAYA.Size = New System.Drawing.Size(138, 20)
        Me.txtTOTALBIAYA.TabIndex = 31
        '
        'txtTELEPON
        '
        Me.txtTELEPON.Location = New System.Drawing.Point(169, 110)
        Me.txtTELEPON.Name = "txtTELEPON"
        Me.txtTELEPON.Size = New System.Drawing.Size(186, 20)
        Me.txtTELEPON.TabIndex = 30
        '
        'txtNMPENYEWA
        '
        Me.txtNMPENYEWA.Location = New System.Drawing.Point(169, 76)
        Me.txtNMPENYEWA.Name = "txtNMPENYEWA"
        Me.txtNMPENYEWA.Size = New System.Drawing.Size(186, 20)
        Me.txtNMPENYEWA.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(415, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Total Biaya"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "No Telpon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nama Penyewa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Gothic Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Form Pemesanan Mobil"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(4, 6)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(927, 459)
        Me.ListBox2.TabIndex = 24
        '
        'txtMASUK
        '
        Me.txtMASUK.Location = New System.Drawing.Point(26, 181)
        Me.txtMASUK.Name = "txtMASUK"
        Me.txtMASUK.Size = New System.Drawing.Size(329, 20)
        Me.txtMASUK.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tanggal Sewa"
        '
        'txtKELUAR
        '
        Me.txtKELUAR.Location = New System.Drawing.Point(654, 181)
        Me.txtKELUAR.Name = "txtKELUAR"
        Me.txtKELUAR.Size = New System.Drawing.Size(253, 20)
        Me.txtKELUAR.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(763, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Tanggal Kembali"
        '
        'txtJUMLAHHARI
        '
        Me.txtJUMLAHHARI.Location = New System.Drawing.Point(654, 110)
        Me.txtJUMLAHHARI.Name = "txtJUMLAHHARI"
        Me.txtJUMLAHHARI.Size = New System.Drawing.Size(254, 20)
        Me.txtJUMLAHHARI.TabIndex = 41
        '
        'txtIDMOBIL
        '
        Me.txtIDMOBIL.Location = New System.Drawing.Point(654, 76)
        Me.txtIDMOBIL.Name = "txtIDMOBIL"
        Me.txtIDMOBIL.Size = New System.Drawing.Size(52, 20)
        Me.txtIDMOBIL.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(545, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Jumlah Hari"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(545, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 19)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Id Mobil"
        '
        'txtNMMOBIL
        '
        Me.txtNMMOBIL.Location = New System.Drawing.Point(712, 76)
        Me.txtNMMOBIL.Name = "txtNMMOBIL"
        Me.txtNMMOBIL.Size = New System.Drawing.Size(102, 20)
        Me.txtNMMOBIL.TabIndex = 44
        '
        'txtHARGA
        '
        Me.txtHARGA.Location = New System.Drawing.Point(820, 76)
        Me.txtHARGA.Name = "txtHARGA"
        Me.txtHARGA.Size = New System.Drawing.Size(87, 20)
        Me.txtHARGA.TabIndex = 45
        '
        'FormPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 471)
        Me.Controls.Add(Me.txtHARGA)
        Me.Controls.Add(Me.txtNMMOBIL)
        Me.Controls.Add(Me.txtKELUAR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtJUMLAHHARI)
        Me.Controls.Add(Me.txtIDMOBIL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMASUK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtTOTALBIAYA)
        Me.Controls.Add(Me.txtTELEPON)
        Me.Controls.Add(Me.txtNMPENYEWA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Name = "FormPenyewa"
        Me.Text = "FormPenyewa"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtTOTALBIAYA As TextBox
    Friend WithEvents txtTELEPON As TextBox
    Friend WithEvents txtNMPENYEWA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents txtMASUK As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKELUAR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJUMLAHHARI As TextBox
    Friend WithEvents txtIDMOBIL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNMMOBIL As TextBox
    Friend WithEvents txtHARGA As TextBox
End Class

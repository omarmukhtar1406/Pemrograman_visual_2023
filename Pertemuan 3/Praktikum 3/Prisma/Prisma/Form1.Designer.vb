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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnbersihkan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKelAlas = New System.Windows.Forms.TextBox()
        Me.txtLuasAlas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(104, 144)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Hitung"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txtTinggi
        '
        Me.txtTinggi.Location = New System.Drawing.Point(261, 61)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(100, 20)
        Me.txtTinggi.TabIndex = 1
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(261, 188)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(100, 20)
        Me.txtLuas.TabIndex = 3
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(85, 188)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(100, 20)
        Me.txtVolume.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tinggi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(21, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Volume"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(206, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Luas"
        '
        'btnbersihkan
        '
        Me.btnbersihkan.Location = New System.Drawing.Point(195, 144)
        Me.btnbersihkan.Name = "btnbersihkan"
        Me.btnbersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnbersihkan.TabIndex = 9
        Me.btnbersihkan.Text = "Bersihkan"
        Me.btnbersihkan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Keliling Alas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Luas Alas"
        '
        'txtKelAlas
        '
        Me.txtKelAlas.Location = New System.Drawing.Point(85, 95)
        Me.txtKelAlas.Name = "txtKelAlas"
        Me.txtKelAlas.Size = New System.Drawing.Size(100, 20)
        Me.txtKelAlas.TabIndex = 11
        '
        'txtLuasAlas
        '
        Me.txtLuasAlas.Location = New System.Drawing.Point(85, 61)
        Me.txtLuasAlas.Name = "txtLuasAlas"
        Me.txtLuasAlas.Size = New System.Drawing.Size(100, 20)
        Me.txtLuasAlas.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Geometr415 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 14)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Omar Mukhtariansyah 200511098"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKelAlas)
        Me.Controls.Add(Me.txtLuasAlas)
        Me.Controls.Add(Me.btnbersihkan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.txtTinggi)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volume dan Luas Permukaan Prisma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents txtVolume As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnbersihkan As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKelAlas As TextBox
    Friend WithEvents txtLuasAlas As TextBox
    Friend WithEvents Label8 As Label
End Class

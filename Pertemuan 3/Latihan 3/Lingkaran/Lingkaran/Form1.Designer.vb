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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJarijari = New System.Windows.Forms.TextBox()
        Me.txtLuas = New System.Windows.Forms.TextBox()
        Me.txtKeliling = New System.Windows.Forms.TextBox()
        Me.btnhitung1 = New System.Windows.Forms.Button()
        Me.btnbersihkan = New System.Windows.Forms.Button()
        Me.btnhitung2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jari-jari :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Luas :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Keliling :"
        '
        'txtJarijari
        '
        Me.txtJarijari.Location = New System.Drawing.Point(163, 50)
        Me.txtJarijari.Name = "txtJarijari"
        Me.txtJarijari.Size = New System.Drawing.Size(100, 20)
        Me.txtJarijari.TabIndex = 4
        '
        'txtLuas
        '
        Me.txtLuas.Location = New System.Drawing.Point(163, 170)
        Me.txtLuas.Name = "txtLuas"
        Me.txtLuas.Size = New System.Drawing.Size(100, 20)
        Me.txtLuas.TabIndex = 5
        '
        'txtKeliling
        '
        Me.txtKeliling.Location = New System.Drawing.Point(163, 213)
        Me.txtKeliling.Name = "txtKeliling"
        Me.txtKeliling.Size = New System.Drawing.Size(100, 20)
        Me.txtKeliling.TabIndex = 6
        '
        'btnhitung1
        '
        Me.btnhitung1.Location = New System.Drawing.Point(88, 89)
        Me.btnhitung1.Name = "btnhitung1"
        Me.btnhitung1.Size = New System.Drawing.Size(77, 36)
        Me.btnhitung1.TabIndex = 7
        Me.btnhitung1.Text = "Hitung π = 3,14"
        Me.btnhitung1.UseVisualStyleBackColor = True
        '
        'btnbersihkan
        '
        Me.btnbersihkan.Location = New System.Drawing.Point(130, 132)
        Me.btnbersihkan.Name = "btnbersihkan"
        Me.btnbersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnbersihkan.TabIndex = 9
        Me.btnbersihkan.Text = "Bersihkan"
        Me.btnbersihkan.UseVisualStyleBackColor = True
        '
        'btnhitung2
        '
        Me.btnhitung2.Location = New System.Drawing.Point(169, 89)
        Me.btnhitung2.Name = "btnhitung2"
        Me.btnhitung2.Size = New System.Drawing.Size(77, 36)
        Me.btnhitung2.TabIndex = 10
        Me.btnhitung2.Text = "Hitung π = 22/7"
        Me.btnhitung2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Geometr415 Blk BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Omar Mukhtariansyah 200511098"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnhitung2)
        Me.Controls.Add(Me.btnbersihkan)
        Me.Controls.Add(Me.btnhitung1)
        Me.Controls.Add(Me.txtKeliling)
        Me.Controls.Add(Me.txtLuas)
        Me.Controls.Add(Me.txtJarijari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Luas dan Keliling Lingkaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJarijari As TextBox
    Friend WithEvents txtLuas As TextBox
    Friend WithEvents txtKeliling As TextBox
    Friend WithEvents btnhitung1 As Button
    Friend WithEvents btnbersihkan As Button
    Friend WithEvents btnhitung2 As Button
    Friend WithEvents Label4 As Label
End Class

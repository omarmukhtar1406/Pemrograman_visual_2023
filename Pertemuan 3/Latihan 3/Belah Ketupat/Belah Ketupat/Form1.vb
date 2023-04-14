Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim sisi, sa, sb, luas, keliling As Integer

        sisi = Val(txtSisi.Text)
        sa = Val(txta.Text)
        sb = Val(txtb.Text)
        If txtSisi.Text = "" Or txta.Text = "" Or txtb.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "BELAH KETUPAT")
        Else
            luas = (sa * sb) / 2
            keliling = sisi + sisi + sisi + sisi

            txtLuas.Text = Str(luas)
            txtKeliling.Text = Str(keliling)
        End If

    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtSisi.Text = ""
        txta.Text = ""
        txtb.Text = ""
        txtLuas.Text = ""
        txtKeliling.Text = ""

    End Sub
End Class

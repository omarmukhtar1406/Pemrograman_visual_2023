Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim diagonal1, diagonal2, sa, sb, sc, sd, luas, keliling As Integer


        diagonal1 = Val(txtd1.Text)
        diagonal2 = Val(txtd2.Text)
        sa = Val(txta.Text)
        sb = Val(txtb.Text)
        sc = Val(txtc.Text)
        sd = Val(txtd.Text)
        If txtd.Text = "" Or txtd1.Text = "" Or txtd2.Text = "" Or txta.Text = "" Or txtb.Text = "" Or txtc.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "LAYANG-LAYANG")
        Else
            luas = (diagonal1 * diagonal2) / 2
            keliling = sa + sb + sc + sd

            txtLuas.Text = Str(luas)
            txtKeliling.Text = Str(keliling)
        End If

    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtd.Text = ""
        txtd1.Text = ""
        txta.Text = ""
        txtb.Text = ""
        txtc.Text = ""
        txtLuas.Text = ""
        txtKeliling.Text = ""

    End Sub
End Class
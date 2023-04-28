Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim sd, tinggi, sa, sb, sc, luas, keliling As Integer

        sd = Val(txtAlas.Text)
        tinggi = Val(txtTinggi.Text)
        sa = Val(txta.Text)
        sb = Val(txtb.Text)
        sc = Val(txtc.Text)
        If txtAlas.Text = "" Or txtTinggi.Text = "" Or txta.Text = "" Or txtb.Text = "" Or txtc.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "TRAPESIUM")
        Else
            luas = ((sa + sb) * tinggi) / 2
            keliling = sa + sb + sc + sd

            txtLuas.Text = Str(luas)
            txtKeliling.Text = Str(keliling)
        End If

    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtAlas.Text = ""
        txtTinggi.Text = ""
        txta.Text = ""
        txtb.Text = ""
        txtc.Text = ""
        txtLuas.Text = ""
        txtKeliling.Text = ""

    End Sub
End Class

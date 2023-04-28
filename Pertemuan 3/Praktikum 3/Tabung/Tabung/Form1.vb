Public Class Form1
    Private Function HitungVolume(jari As Integer, tinggi As Integer)
        Dim volume As Integer
        volume = Math.PI * (jari * jari) * tinggi
        Return volume
    End Function
    Private Function HitungLP(jari As Integer, tinggi As Integer)
        Dim luaspermukaan As Integer
        luaspermukaan = 2 * Math.PI * jari * (jari + tinggi)
        Return luaspermukaan
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim jari, tinggi, volume, luaspermukaan As Integer

        jari = Val(txtJari.Text)
        tinggi = Val(txtTinggi.Text)
        If txtTinggi.Text = "" Or txtJari.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "TABUNG")
        Else
            volume = HitungVolume(jari, tinggi)
            luaspermukaan = HitungLP(jari, tinggi)

            txtVolume.Text = Str(volume)
            txtLuas.Text = Str(luaspermukaan)
        End If

    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtTinggi.Text = ""
        txtJari.Text = ""
        txtLuas.Text = ""
        txtVolume.Text = ""

    End Sub
End Class

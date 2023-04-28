Public Class Form1
    Private Function HitungVolume(jari As Integer)
        Dim volume As Integer
        volume = 4 / 3 * Math.PI * (jari * jari * jari)
        Return volume
    End Function
    Private Function HitungLP(jari As Integer)
        Dim luaspermukaan As Integer
        luaspermukaan = 4 * Math.PI * (jari * jari)
        Return luaspermukaan
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim jari, volume, luaspermukaan As Integer

        jari = Val(txtJari.Text)
        If txtJari.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "BOLA")
        Else
            volume = HitungVolume(jari)
            luaspermukaan = HitungLP(jari)

            txtVolume.Text = Str(volume)
            txtLuas.Text = Str(luaspermukaan)
        End If

    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtJari.Text = ""
        txtLuas.Text = ""
        txtVolume.Text = ""

    End Sub
End Class

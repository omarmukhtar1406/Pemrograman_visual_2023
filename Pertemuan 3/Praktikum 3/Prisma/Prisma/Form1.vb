Public Class Form1
    Private Function HitungVolume(luasalas As Integer, tinggi As Integer)
        Dim volume As Integer
        volume = luasalas * tinggi
        Return volume
    End Function
    Private Function HitungLP(luasalas As Integer, kelilingalas As Integer, tinggi As Integer)
        Dim luaspermukaan As Integer
        luaspermukaan = ((2 * luasalas) + (tinggi * kelilingalas))
        Return luaspermukaan
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim luasalas, kelilingalas, tinggi, volume, luaspermukaan As Integer

        luasalas = Val(txtLuasAlas.Text)
        kelilingalas = Val(txtKelAlas.Text)
        tinggi = Val(txtTinggi.Text)
        If txtTinggi.Text = "" Or txtLuasAlas.Text = "" Or txtKelAlas.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "PRISMA")
        Else
            volume = HitungVolume(luasalas, tinggi)
            luaspermukaan = HitungLP(luasalas, kelilingalas, tinggi)

            txtVolume.Text = Str(volume)
            txtLuas.Text = Str(luaspermukaan)
        End If

    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtTinggi.Text = ""
        txtLuasAlas.Text = ""
        txtKelAlas.Text = ""
        txtLuas.Text = ""
        txtVolume.Text = ""

    End Sub
End Class

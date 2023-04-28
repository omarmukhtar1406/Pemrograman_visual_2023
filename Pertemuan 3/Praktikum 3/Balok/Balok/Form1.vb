Public Class Form1
    Private Function HitungVolume(panjang As Integer, lebar As Integer, tinggi As Integer)
        Dim volume As Integer
        volume = panjang * lebar * tinggi
        Return volume
    End Function
    Private Function HitungLP(panjang As Integer, lebar As Integer, tinggi As Integer)
        Dim luaspermukaan As Integer
        luaspermukaan = 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi))
        Return luaspermukaan
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim panjang, lebar, tinggi, volume, luaspermukaan As Integer

        panjang = Val(txtPanjang.Text)
        lebar = Val(txtLebar.Text)
        tinggi = Val(txtTinggi.Text)
        If txtTinggi.Text = "" Or txtPanjang.Text = "" Or txtLebar.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "BALOK")
        Else
            volume = HitungVolume(panjang, lebar, tinggi)
            luaspermukaan = HitungLP(panjang, lebar, tinggi)

            txtVolume.Text = Str(volume)
            txtLuas.Text = Str(luaspermukaan)
        End If

    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtTinggi.Text = ""
        txtPanjang.Text = ""
        txtLebar.Text = ""
        txtLuas.Text = ""
        txtVolume.Text = ""

    End Sub
End Class

Public Class Form1
    Private Function HitungVolume(sisi As Integer)
        Dim volume As Integer
        volume = sisi * sisi * sisi
        Return volume
    End Function
    Private Function HitungLP(sisi As Integer)
        Dim luaspermukaan As Integer
        luaspermukaan = 6 * (sisi * sisi)
        Return luaspermukaan
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim sisi, volume, luaspermukaan As Integer

        sisi = Val(txtSisi.Text)
        If txtSisi.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "KUBUS")
        Else
            volume = HitungVolume(sisi)
            luaspermukaan = HitungLP(sisi)

            txtVolume.Text = Str(volume)
            txtLuas.Text = Str(luaspermukaan)
        End If

    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtSisi.Text = ""
        txtLuas.Text = ""
        txtVolume.Text = ""

    End Sub
End Class

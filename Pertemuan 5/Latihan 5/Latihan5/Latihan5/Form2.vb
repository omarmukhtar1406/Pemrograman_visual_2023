Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan Voucher Umroh"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan Bonus 5x Gaji"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan Bonus 2x Gaji"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Anda mendapat Handphone IOS"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class
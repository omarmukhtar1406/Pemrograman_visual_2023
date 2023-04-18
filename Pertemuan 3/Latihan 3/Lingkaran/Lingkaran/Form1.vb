Public Class Form1
    Private Sub btnhitung1_Click(sender As Object, e As EventArgs) Handles btnhitung1.Click
        Dim phi, jarijari, luas, keliling As Double

        phi = 3.14
        jarijari = Val(txtJarijari.Text)
        If txtJarijari.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "LINGKARAN")
        Else
            luas = phi * jarijari * jarijari
            keliling = 2 * phi * jarijari

            txtLuas.Text = Str(luas)
            txtKeliling.Text = Str(keliling)
        End If


    End Sub

    Private Sub btnhitung2_Click(sender As Object, e As EventArgs) Handles btnhitung2.Click
        Dim phi, jarijari, luas, keliling As Double

        phi = 22 / 7
        jarijari = Val(txtJarijari.Text)
        If txtJarijari.Text = "" Then
            MsgBox("Informasi tidak lengkap", vbInformation, "LINGKARAN")
        Else
            luas = phi * jarijari * jarijari
            keliling = 2 * phi * jarijari

            txtLuas.Text = Str(luas)
            txtKeliling.Text = Str(keliling)
        End If


    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtJarijari.Text = ""
        txtLuas.Text = ""
        txtKeliling.Text = ""

    End Sub
End Class

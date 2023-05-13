Public Class Form1
    Private Function convert(reamur As Integer) As Integer
        Dim konversi As Integer
        konversi = 5 / 4 * (reamur + 273)
        Return konversi
    End Function
    Private Sub btnhtg_Click(sender As Object, e As EventArgs) Handles btnhtg.Click
        Dim reamur, kelvin As Integer
        reamur = Val(txtReamur.Text)
        kelvin = convert(reamur)
        txtKelvin.Text = Str(kelvin)
    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtReamur.Text = ""
        txtKelvin.Text = ""
    End Sub
End Class
Public Class Form1
    Private Sub btnhtg_Click(sender As Object, e As EventArgs) Handles btnhtg.Click
        Dim F, C, R, K As Decimal
        F = CDec(txtFahrenheit.Text)
        C = ToCelcius(F)
        R = ToReamur(F)
        K = ToKelvin(F)

        txtCelcius.Text = Str(C)
        txtReamur.Text = Str(R)
        txtKelvin.Text = Str(K)
    End Sub

    Private Function ToCelcius(suhu As Decimal) As Decimal
        Dim C As Decimal
        C = 5 / 9 * (suhu - 32)
        Return C
    End Function

    Private Function ToReamur(suhu As Decimal) As Decimal
        Dim R As Decimal
        R = 4 / 9 * (suhu - 32)
        Return R
    End Function

    Private Function ToKelvin(suhu As Decimal) As Decimal
        Dim K As Decimal
        K = 5 / 9 * (suhu - 32) + 273
        Return K
    End Function

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtFahrenheit.Text = ""
        txtCelcius.Text = ""
        txtReamur.Text = ""
        txtKelvin.Text = ""
    End Sub
End Class

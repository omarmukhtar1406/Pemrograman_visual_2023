Public Class Form1
    Private Function convert(celcius As Integer) As Integer
        Dim konversi As Integer
        konversi = (9 / 5 * celcius) + 32
        Return konversi
    End Function
    Private Sub btnhtg_Click(sender As Object, e As EventArgs) Handles btnhtg.Click
        Dim celcius, fahrenheit As Integer
        celcius = Val(txtCelcius.Text)
        fahrenheit = convert(celcius)
        txtFahrenheit.Text = Str(fahrenheit)
    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtCelcius.Text = ""
        txtFahrenheit.Text = ""
    End Sub
End Class
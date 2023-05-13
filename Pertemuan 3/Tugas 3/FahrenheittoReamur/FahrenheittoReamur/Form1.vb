Public Class Form1
    Private Function convert(fahrenheit As Integer) As Integer
        Dim konversi As Integer
        konversi = (4 / 9) * (fahrenheit - 32)
        Return konversi
    End Function
    Private Sub btnhtg_Click(sender As Object, e As EventArgs) Handles btnhtg.Click
        Dim fahrenheit, reamur As Integer
        fahrenheit = Val(txtFahrenheit.Text)
        reamur = convert(fahrenheit)
        txtReamur.Text = Str(reamur)
    End Sub

    Private Sub btnbersihkan_Click(sender As Object, e As EventArgs) Handles btnbersihkan.Click
        txtFahrenheit.Text = ""
        txtReamur.Text = ""
    End Sub
End Class

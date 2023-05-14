Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case txtMotor.Text
            Case "HY2" : txtketerangan.Text = "New Vario 125 CBS"

            Case "EV1" : txtketerangan.Text = "New CB 150R Streetfire"

            Case "HL9" : txtketerangan.Text = "BeAT Sporty CBS ISS MMC"

            Case "HP2" : txtketerangan.Text = "All New Scoopy Stylish"

            Case "GE4" : txtketerangan.Text = "Supra X 125 SW MMC"

            Case Else : txtketerangan.Text = "Tidak Ditemukan"
        End Select
    End Sub
End Class
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case txtMakanan.Text
            Case "MYM" : txtketerangan.Text = "Mie Ayam"

            Case "BSO" : txtketerangan.Text = "Bakso"

            Case "MYB" : txtketerangan.Text = "Mie Ayam Bakso"

            Case "STS" : txtketerangan.Text = "Soto Sapi"

            Case "STA" : txtketerangan.Text = "Soto Ayam"

            Case Else : txtketerangan.Text = "Tidak Ditemukan"
        End Select
    End Sub
End Class

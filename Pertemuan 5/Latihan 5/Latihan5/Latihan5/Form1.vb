Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(txtnilaiakhir.Text) >= 60) Then
            txtketerangan.Text = "Anda Lulus"
        Else
            txtketerangan.Text = "Anda tidak Lulus, Silahkan mengulang tahun depan"
        End If
    End Sub
End Class

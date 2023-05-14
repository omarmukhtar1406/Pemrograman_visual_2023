Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(txtTensi.Text) >= 125) Then
            txtketerangan.Text = "Anda Mengalami Hipertensi"

        ElseIf (txtTensi.Text >= 110) Then
            txtketerangan.Text = "Tensi Darah Anda Normal"

        Else
            txtketerangan.Text = "Anda Mengalami Hipotensi"
        End If
    End Sub
End Class
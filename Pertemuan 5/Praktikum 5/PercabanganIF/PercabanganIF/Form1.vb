Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(txtNilai.Text) >= 130) Then
            txtketerangan.Text = "Very Superior (Cerdas)"

        ElseIf (txtNilai.Text >= 120) Then
            txtketerangan.Text = "Superior (Di Atas Rata-rata)"

        ElseIf (txtNilai.Text >= 110) Then
            txtketerangan.Text = "High Average (Rata-rata Tinggi)"

        ElseIf (txtNilai.Text >= 90) Then
            txtketerangan.Text = "Average (Rata-rata)"

        ElseIf (txtNilai.Text >= 80) Then
            txtketerangan.Text = "Low Average (Rata-rata Rendah)"

        ElseIf (txtNilai.Text >= 70) Then
            txtketerangan.Text = "Borderline (Batas Fungsi Intelektual)"

        Else
            txtketerangan.Text = "Intellectual Disability (Sangat Rendah)"
        End If
    End Sub
End Class

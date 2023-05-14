Public Class Form1
    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem1.Click
        Dim F2 As New Form2
        F2.ShowDialog()
    End Sub

    Private Sub Form3ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Dim F3 As New Form3
        F3.ShowDialog()
    End Sub
End Class

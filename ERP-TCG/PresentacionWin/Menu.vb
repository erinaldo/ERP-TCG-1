Public Class Menu

    Private Sub NuevoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
Public Class Form1
    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvedoresToolStripMenuItem.Click
        Provedores.ShowDialog()
    End Sub

    Private Sub ContratosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContratosToolStripMenuItem1.Click
        Contratos.ShowDialog()
    End Sub

    Private Sub RemisionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemisionesToolStripMenuItem.Click
        Remisiones.ShowDialog()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        Pagos.ShowDialog()
    End Sub
End Class

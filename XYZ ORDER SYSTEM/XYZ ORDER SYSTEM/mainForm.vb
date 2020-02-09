Public Class mainForm

    Private Sub CostumersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostumersToolStripMenuItem.Click
        CustomersForm.Show()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsToolStripMenuItem.Click
        itemsForm.Show()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdersToolStripMenuItem.Click
        ordersForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class


Public Class Main
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TShirtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TShirtToolStripMenuItem1.Click
        Dim TshirtForm As New Tshirt_stock
        TshirtForm.Show()
    End Sub

    Private Sub ShowDesignsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDesignsToolStripMenuItem.Click
        Dim designForm As New designlibrary
        designForm.Show()
    End Sub

    Private Sub HoodiesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HoodiesToolStripMenuItem1.Click
        Dim HoodieForm As New Hoodie_stock
        HoodieForm.Show()
    End Sub

    Private Sub SweatshirtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SweatshirtToolStripMenuItem1.Click
        Dim sweatForm As New sweat_stock
        sweatForm.Show()
    End Sub

    Private Sub ToteBagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToteBagToolStripMenuItem.Click
        Dim ToteForm As New Totebag_stock
        ToteForm.Show()
    End Sub

    Private Sub HoodiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoodiesToolStripMenuItem.Click
        Dim addProducts As New add_product
        addProducts.Show()
    End Sub
End Class

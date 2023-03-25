Public Class add_product
    Private Sub add_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RstcDataSet.CATEGORY' table. You can move, or remove it, as needed.
        Me.CATEGORYTableAdapter.Fill(Me.RstcDataSet.CATEGORY)


    End Sub


End Class
Public Class OrderHistoryForm
    Private Sub OrderHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RstcDataSet1.HISTORY' table. You can move, or remove it, as needed.
        Me.HISTORYTableAdapter.Fill(Me.RstcDataSet1.HISTORY)

    End Sub


End Class
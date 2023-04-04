Public Class OrderMsgBoxForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addProduct1 As New add_product
        addProduct1.Show()
        Main.Timer1.Stop()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.Timer1.Stop()
        Me.Close()
    End Sub


End Class
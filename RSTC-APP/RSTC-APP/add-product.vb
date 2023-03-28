Imports System.Data
Imports System.Data.SqlClient

Public Class add_product

    Private Sub add_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RstcDataSet.CATEGORY' table. You can move, or remove it, as needed.
        Me.CATEGORYTableAdapter.Fill(Me.RstcDataSet.CATEGORY)


    End Sub



    Private Sub AddProButton_Click(sender As Object, e As EventArgs) Handles AddProButton.Click
        Dim con As New SqlConnection
        
        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con.Open()
        'cmd = con.CreateCommand()
        'cmd.CommandType = CommandType.Text
        Dim cmd As New SqlCommand("INSERT INTO PRODUCT (PROD_NAME,CATEGORY,SIZE,COLOR) VALUES(@PROD_NAME,@CATEGORY,@SIZE,@COLOR)", con)
        cmd.Parameters.AddWithValue("@PROD_NAME", ProdName1.Text)
        cmd.Parameters.AddWithValue("@CATEGORY", ProdCate1.Text)
        cmd.Parameters.AddWithValue("@SIZE", ProdSize1.Text)
        cmd.Parameters.AddWithValue("@COLOR", ProdCol1.Text)
        'Error handling to be added
        If cmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Product added")
        Else
            MessageBox.Show("Product not added")
        End If
        con.Close()
    End Sub
End Class
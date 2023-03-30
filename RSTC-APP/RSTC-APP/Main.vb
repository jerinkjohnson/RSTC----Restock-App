Imports System.Data
Imports System.Data.SqlClient

Public Class Main

    Private Sub TShirtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TShirtToolStripMenuItem1.Click
        Dim TshirtForm As New tshirtForm
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

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT count(PROD_ID) as TShirt_STOCK FROM PRODUCT where CATEGORY = 10;"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        'hoodie
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT count(PROD_ID) as Hoodie_STOCK FROM PRODUCT where CATEGORY = 20;"
        cmd.ExecuteNonQuery()
        Dim dt1 As New DataTable
        Dim da1 As New SqlDataAdapter(cmd)
        da1.Fill(dt1)
        DataGridView2.DataSource = dt1


        'sweatshirt
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT count(PROD_ID) as SweatShirt_STOCK FROM PRODUCT where CATEGORY = 30;"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable
        Dim da2 As New SqlDataAdapter(cmd)
        da2.Fill(dt2)
        DataGridView3.DataSource = dt2


        'totebag
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT count(PROD_ID) as ToteBag_STOCK FROM PRODUCT where CATEGORY = 40;"
        cmd.ExecuteNonQuery()
        Dim dt3 As New DataTable
        Dim da13 As New SqlDataAdapter(cmd)
        da1.Fill(dt3)
        DataGridView4.DataSource = dt3
        con.Close()

    End Sub

    Public Sub refreshDashBoard()
        DataGridView1.Refresh()
        DataGridView2.Refresh()
        DataGridView3.Refresh()
        DataGridView4.Refresh()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim Delete_forms As New deleteForms
        Delete_forms.Show()
    End Sub
End Class


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

        addProducts.OrderButton.Hide()
        addProducts.Show()
    End Sub

    'Stock count variables
    Dim HoodieC As Integer
    Dim TshirtC As Integer
    Dim SweatC As Integer
    Dim ToteC As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Tshirt
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT  SUM(quantity) FROM PRODUCT WHERE CATEGORY = 10"
        Dim count1 As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        TshirtC = count1
        Label12.Text = TshirtC
        cmd.ExecuteNonQuery()


        'hoodie
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT  SUM(quantity) FROM PRODUCT WHERE CATEGORY = 20"
        Dim count2 As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        HoodieC = count2
        Label13.Text = HoodieC
        cmd.ExecuteNonQuery()



        'sweatshirt
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT  SUM(quantity) FROM PRODUCT WHERE CATEGORY = 30"
        Dim count3 As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        SweatC = count3
        Label14.Text = SweatC
        cmd.ExecuteNonQuery()



        'totebag
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT  SUM(quantity) FROM PRODUCT WHERE CATEGORY = 40"
        Dim count4 As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        ToteC = count4
        Label15.Text = ToteC
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub



    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim Delete_forms As New deleteForms
        Delete_forms.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim countH As Integer
        Dim Hstock As Integer
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        con1.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con1.Open()
        cmd1 = con1.CreateCommand()
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "SELECT count(PROD_ID) as TShirt_STOCK, SUM(quantity) as Total_Quantity FROM PRODUCT WHERE CATEGORY = 20 GROUP BY CATEGORY;"
        countH = Convert.ToInt32(cmd1.ExecuteScalar())
        Hstock = countH

        cmd1.ExecuteNonQuery()
        con1.Close()


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT count(PROD_ID) as TShirt_STOCK FROM PRODUCT where CATEGORY = 10;"


        cmd.ExecuteNonQuery()
        con.Close()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Order_Msg As New OrderMsgBoxForm


        If TshirtC < 50 Then
            Timer1.Start()
            Order_Msg.Show()
            Order_Msg.Label1.Text = "T-Shirt Stock running low!!!"
        End If
        If HoodieC < 50 Then
            Timer1.Start()
            Order_Msg.Show()
            Order_Msg.Label2.Text = "Hoodie Stock running low!!!"
        End If
        If SweatC < 50 Then
            Timer1.Start()
            Order_Msg.Show()
            Order_Msg.Label3.Text = "Sweatshirt Stock running low!!!"
        End If
        If ToteC < 50 Then
            Timer1.Start()
            Order_Msg.Show()
            Order_Msg.Label4.Text = "Tote Bag Stock running low!!!"
        End If

    End Sub

    Private Sub PlaceOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaceOrderToolStripMenuItem.Click

        add_product.Show()
        add_product.AddProButton.Hide()
    End Sub

    Private Sub OrderHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderHistoryToolStripMenuItem.Click
        OrderHistoryForm.Show()
    End Sub

    Private Sub AutoAlertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoAlertToolStripMenuItem.Click

        Timer1.Start()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DisableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableToolStripMenuItem.Click
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub


    Private Sub OfflineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfflineToolStripMenuItem.Click
        Timer2.Stop()
    End Sub

    Private Sub OnlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineToolStripMenuItem.Click

        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE PRODUCT SET QUANTITY = QUANTITY - 1 WHERE QUANTITY >= 0;"
        cmd.ExecuteNonQuery()

        'For testing sales
        'MsgBox("SALES ONLINE")
        con.Close()
    End Sub


End Class



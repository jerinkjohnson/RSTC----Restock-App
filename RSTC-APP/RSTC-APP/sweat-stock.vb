﻿Imports System.Data
Imports System.Data.SqlClient
Public Class sweat_stock
    Private Sub sweat_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Product.PROD_ID, Product.PROD_NAME,Product.QUANTITY , Size.SIZE_NAME FROM Product JOIN Size ON Product.SIZE = Size.SIZE_NO AND Product.SIZE = Size.SIZE_NO"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub
End Class
﻿Imports System.Data.SqlClient

Public Class add_product



    Private Sub AddProButton_Click(sender As Object, e As EventArgs) Handles AddProButton.Click
        ComboBox1.Hide()
        Dim con As New SqlConnection

        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con.Open()
        'cmd = con.CreateCommand()
        'cmd.CommandType = CommandType.Text
        Dim cmd As New SqlCommand("INSERT INTO PRODUCT (PROD_NAME,CATEGORY,SIZE,COLOR,QUANTITY) VALUES(@PROD_NAME,@CATEGORY,@SIZE,@COLOR,@QUANTITY)", con)

        cmd.Parameters.AddWithValue("@PROD_NAME", ProdName1.Text)
        cmd.Parameters.AddWithValue("@CATEGORY", ComboBox1.SelectedValue)
        cmd.Parameters.AddWithValue("@SIZE", ComboBox2.SelectedValue)
        cmd.Parameters.AddWithValue("@COLOR", ComboBox3.SelectedValue)
        cmd.Parameters.AddWithValue("@QUANTITY", TextBox1.Text)
        'Dim ProdName As String = ProdName1.Text


        'Error handling to be added

        If cmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Product added")

            ProdName1.Clear()
            TextBox1.Clear()
        Else
            MessageBox.Show("Product not added")
        End If

        'Dim cmd1 As New SqlCommand("INSERT INTO HISTORY (ORDER_HISTORY) VALUES (@ORDER_HISTORY)", con)
        'cmd1.Parameters.AddWithValue("@ORDER_HISTORY", ProdName)
        'cmd1.ExecuteNonQuery()
        'con.Close()
    End Sub



    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.CATEGORYTableAdapter.FillBy(Me.RstcDataSet.CATEGORY)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub add_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RstcDataSet.PRODUCT' table. You can move, or remove it, as needed.
        Me.PRODUCTTableAdapter.Fill(Me.RstcDataSet.PRODUCT)
        'TODO: This line of code loads data into the 'RstcDataSet.PRODUCT' table. You can move, or remove it, as needed.
        Me.PRODUCTTableAdapter.Fill(Me.RstcDataSet.PRODUCT)
        'TODO: This line of code loads data into the 'RstcDataSet1.COLOR' table. You can move, or remove it, as needed.
        Me.COLORTableAdapter.Fill(Me.RstcDataSet1.COLOR)
        'TODO: This line of code loads data into the 'RstcDataSet.SIZE' table. You can move, or remove it, as needed.
        Me.SIZETableAdapter.Fill(Me.RstcDataSet.SIZE)
        'TODO: This line of code loads data into the 'RstcDataSet.CATEGORY' table. You can move, or remove it, as needed.
        Me.CATEGORYTableAdapter.Fill(Me.RstcDataSet.CATEGORY)

    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        ProdName1.Hide()

        Dim con As New SqlConnection

        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        con.Open()
        Dim cmd As New SqlCommand("INSERT INTO PRODUCT (PROD_NAME,CATEGORY,SIZE,COLOR,QUANTITY) VALUES(@PROD_NAME,@CATEGORY,@SIZE,@COLOR,@QUANTITY)", con)

        cmd.Parameters.AddWithValue("@PROD_NAME", ProdName1.Text)
        cmd.Parameters.AddWithValue("@CATEGORY", ComboBox1.SelectedValue)
        cmd.Parameters.AddWithValue("@SIZE", ComboBox2.SelectedValue)
        cmd.Parameters.AddWithValue("@COLOR", ComboBox3.SelectedValue)
        cmd.Parameters.AddWithValue("@QUANTITY", TextBox1.Text)
        Dim OrderInfo As String = TimeString & " : Placed Order of " & TextBox1.Text & " " & ProdName1.Text & " from the " & ComboBox1.Text & " section of size " & ComboBox2.Text & " and of color " & ComboBox3.Text & " "



        'Error handling to be added

        If cmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Product added")

            ProdName1.Clear()

        Else
            MessageBox.Show("Product not added")
        End If

        Dim cmd1 As New SqlCommand("INSERT INTO HISTORY (ORDER_HISTORY) VALUES (@ORDER_HISTORY)", con)
        cmd1.Parameters.AddWithValue("@ORDER_HISTORY", OrderInfo)
        cmd1.ExecuteNonQuery()
        con.Close()
    End Sub


End Class
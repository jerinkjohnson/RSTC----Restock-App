Imports System.Data
Imports System.Data.SqlClient
Public Class deleteForms
    Private Sub deleteForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RstcDataSet.PRODUCT' table. You can move, or remove it, as needed.
        Me.PRODUCTTableAdapter.Fill(Me.RstcDataSet.PRODUCT)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=Grace;Initial Catalog=rstc;Persist Security Info=True;User ID=sa;Password=Devjerin@2023"
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM PRODUCT WHERE PROD_ID = " & ComboBox1.SelectedValue

        Else
            Me.Close()
        End If
        If cmd.ExecuteNonQuery() = 1 Then

            MsgBox("Successfully Deleted")
        End If
    End Sub
End Class
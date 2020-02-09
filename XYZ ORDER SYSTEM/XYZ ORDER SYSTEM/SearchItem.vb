Imports System.Data.OleDb
Public Class SearchItem

    Private Sub SearchItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
    End Sub
    Private Sub searchItems()
        sql = "SELECT * FROM ITEMS WHERE NAME LIKE '%" & Me.SearchItemTextBox.Text & "%' OR DESCRIPTION LIKE '%" & Me.SearchItemTextBox.Text & "%'"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            ordersForm.OrderItemIDTextBox.Text = dr("I_ID")

            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub SearchItemTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchItemTextBox.TextChanged
        searchItems()
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        Me.Close()
    End Sub
End Class
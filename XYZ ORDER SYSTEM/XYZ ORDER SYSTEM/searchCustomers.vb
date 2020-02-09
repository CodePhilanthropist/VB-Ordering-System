Imports System.Data.OleDb
Public Class searchCustomers

    Private Sub searchCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
    End Sub
    Private Sub searchCustomers()
        sql = "SELECT * FROM CUSTOMERS WHERE LASTNAME LIKE '%" & Me.SearchLTextBox.Text & "%' OR FIRSTNAME LIKE '%" & Me.SearchLTextBox.Text & "%' OR MIDDLENAME LIKE '%" & Me.SearchLTextBox.Text & "%'"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            ordersForm.OrderCusTextBox.Text = dr("CUS_ID")
            ordersForm.loanern = dr("LASTNAME") & dr("FIRSTNAME") & " , " & dr("MIDDLENAME")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub SearchLTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchLTextBox.TextChanged
        searchCustomers()
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        Me.Close()
    End Sub
End Class
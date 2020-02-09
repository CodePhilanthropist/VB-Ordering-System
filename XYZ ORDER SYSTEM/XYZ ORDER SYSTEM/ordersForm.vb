Imports System.Data.OleDb
Public Class ordersForm
    Public loanern, itemn, itemquant As String
    Private Sub ordersForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateOrders()
    End Sub
    Private Sub populateOrders()
        sql = "SELECT ORDERS.OR_ID, ORDERS.RECEIPTNO, ORDERS.ORDATE, CUSTOMERS.LASTNAME, CUSTOMERS.FIRSTNAME, CUSTOMERS.MIDDLENAME, ITEMS.NAME AS ITEM_NAME, ITEMS.QUANTITY FROM ((ORDERS " & "INNER JOIN CUSTOMERS ON ORDERS.CUS_ID=CUSTOMERS.CUS_ID)" & "INNER JOIN ITEMS ON ORDERS.I_ID=ITEMS.I_ID) ORDER BY ORDERS.OR_ID ASC"


        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.OrderDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub CountOrderID()
        Dim cmid As Integer
        sql = "SELECT COUNT(*) AS ORDER_ID FROM ORDERS"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            cmid = dr("ORDER_ID")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.Order_IDTextBox.Text = cmid + 1
    End Sub

    Private Sub ItemAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemAddButton.Click
        CountOrderID()
        Me.OrderCusTextBox.Clear()
        Me.OrderItemIDTextBox.Clear()
        Me.OrderDateTextBox.Text = Today
        Me.OrderCusTextBox.Focus()
        Me.RTextBox.Text = "RECEIPT" & Order_IDTextBox.Text & Today.Day & Today.Month & Today.Year
        loanern = ""
        itemn = ""
    End Sub

    Private Sub ItemSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemSaveButton.Click
        sql = "INSERT INTO ORDERS(OR_ID, CUS_ID, I_ID, ORDATE, RECEIPTNO)VALUES(" & CInt(Me.Order_IDTextBox.Text) & ", " & CInt(Me.OrderCusTextBox.Text) & ", " & CInt(Me.OrderItemIDTextBox.Text) & ", '" & CDate(Me.OrderDateTextBox.Text) & "', '" & Me.RTextBox.Text & "')"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            populateOrders()
            MessageBox.Show("New Order has been added!")
            getInfoForPrinting()
            ReceiptForm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ItemUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemUpdateButton.Click
        sql = "UPDATE ORDERS SET CUS_ID='" & CInt(Me.OrderCusTextBox.Text) & "', I_ID='" & CInt(Me.OrderItemIDTextBox.Text) & "', ORDATE='" & CDate(Me.OrderDateTextBox.Text) & "', RECEIPTNO='" & Me.RTextBox.Text & "' WHERE OR_ID=" & CInt(Me.Order_IDTextBox.Text) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            populateOrders()
            MessageBox.Show("The order has been Updated!")
            getInfoForPrinting()
            ReceiptForm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub OrderExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderExitButton.Click
        Me.Hide()
    End Sub

    Private Sub SearchCustomerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCustomerButton.Click
        Dim searchDialog As New searchCustomers
        searchCustomers.ShowDialog()
    End Sub

    Private Sub SearchItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchItemButton.Click
        Dim searchDialog As New SearchItem
        SearchItem.ShowDialog()
    End Sub

    Private Sub OrderDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OrderDataGridView.CellContentClick
        sql = "SELECT * FROM ORDERS WHERE OR_ID =" & CInt(Me.OrderDataGridView.CurrentCell.Value) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.Order_IDTextBox.Text = dr("OR_ID")
            Me.OrderCusTextBox.Text = dr("CUS_ID")
            Me.OrderItemIDTextBox.Text = dr("I_ID")
            Me.OrderDateTextBox.Text = dr("ORDATE")
            Me.RTextBox.Text = dr("RECEIPTNO")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
    Private Sub getInfoForPrinting()
        sql = "SELECT ITEMS.QUANTITY AS ITEMS_QUANT, ITEMS.NAME AS ITEMS_NAME, CUSTOMERS.LASTNAME AS CUS_LAST,CUSTOMERS.FIRSTNAME AS CUS_FIRST, CUSTOMERS.MIDDLENAME AS CUS_MID " &
         "FROM ((ORDERS " &
         "INNER JOIN ITEMS ON ORDERS.I_ID=ITEMS.I_ID)" &
        "INNER JOIN CUSTOMERS ON ORDERS.CUS_ID=CUSTOMERS.CUS_ID)" & "WHERE (ORDERS.OR_ID=" & CInt(Me.Order_IDTextBox.Text) & ")" & "AND CUSTOMERS.CUS_ID=" & CInt(Me.OrderCusTextBox.Text) & "" &
        "AND ITEMS.I_ID=" & CInt(OrderItemIDTextBox.Text) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            itemquant = dr("ITEMS_QUANT")
            itemn = dr("ITEMS_NAME")
            loanern = dr("CUS_LAST") & ",   " & dr("CUS_FIRST") & ",   " & dr("CUS_MID")
            'typen = dr("DN")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ItemPrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemPrintButton.Click
        getInfoForPrinting()
        ReceiptForm.Show()
    End Sub
End Class
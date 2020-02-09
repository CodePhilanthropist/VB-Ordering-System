Imports System.Data.OleDb
Public Class CustomersForm

    Private Sub CustomersForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populate()
    End Sub
    Private Sub populate()
        sql = "SELECT * FROM CUSTOMERS ORDER BY CUS_ID ASC"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.CustomerDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub CountCusID()
        Dim cmid As Integer
        sql = "SELECT COUNT(*) AS CUSID FROM CUSTOMERS"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            cmid = dr("CUSID")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.Cus_IDTextBox.Text = cmid + 1
    End Sub


    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        CountCusID()
        Me.LastNameTextBox.Clear()
        Me.FirstNameTextBox.Clear()
        Me.MiddleNameTextBox.Clear()
        Me.ContactNoTextBox.Clear()
        Me.AddressTextBox.Clear()
        Me.LastNameTextBox.Focus()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        sql = "INSERT INTO CUSTOMERS(CUS_ID, LASTNAME, FIRSTNAME, MIDDLENAME, CONTACTNO, ADDRESS) VALUES ('" & CInt(Me.Cus_IDTextBox.Text) & "', '" & Me.LastNameTextBox.Text & "', '" & Me.FirstNameTextBox.Text & "', '" & Me.MiddleNameTextBox.Text & "', '" & Me.ContactNoTextBox.Text & "', '" & Me.AddressTextBox.Text & "')"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            populate()
            MessageBox.Show("New Customer has been added!")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        sql = "UPDATE CUSTOMERS SET LASTNAME='" & Me.LastNameTextBox.Text & "', FIRSTNAME='" & Me.FirstNameTextBox.Text & "', MIDDLENAME='" & Me.LastNameTextBox.Text & "', CONTACTNO='" & Me.ContactNoTextBox.Text & "', ADDRESS='" & Me.AddressTextBox.Text & "' WHERE CUS_ID=" & CInt(Me.Cus_IDTextBox.Text) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            populate()
            MessageBox.Show("The customer details has been Updated!")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub CustomerDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick
        sql = "SELECT * FROM CUSTOMERS WHERE CUS_ID =" & CInt(Me.CustomerDataGridView.CurrentCell.Value) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.Cus_IDTextBox.Text = dr("CUS_ID")
            Me.LastNameTextBox.Text = dr("LASTNAME")
            Me.FirstNameTextBox.Text = dr("FIRSTNAME")
            Me.MiddleNameTextBox.Text = dr("MIDDLENAME")
            Me.ContactNoTextBox.Text = dr("CONTACTNO")
            Me.AddressTextBox.Text = dr("ADDRESS")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Hide()
    End Sub
End Class
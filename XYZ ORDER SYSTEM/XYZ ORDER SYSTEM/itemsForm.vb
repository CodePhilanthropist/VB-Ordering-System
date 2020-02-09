Imports System.Data.OleDb
Public Class itemsForm


    Private Sub itemsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection(ConnectionString)
        OleConnection(sql)
        populateItems()
    End Sub

    Private Sub populateItems()
        sql = "SELECT * FROM ITEMS ORDER BY I_ID ASC"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
            Me.ItemDataGridView.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub CountItemID()
        Dim cmid As Integer
        sql = "SELECT COUNT(*) AS IT_ID FROM ITEMS"
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            cmid = dr("IT_ID")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        Me.Item_IDTextBox.Text = cmid + 1
    End Sub

    Private Sub ItemAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemAddButton.Click
        CountItemID()
        Me.ItemNameTextBox.Clear()
        Me.ItemDescTextBox.Clear()
        Me.ItemQuantityTextBox.Clear()
        Me.ItemNameTextBox.Focus()
    End Sub

    Private Sub ItemSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemSaveButton.Click
        sql = "INSERT INTO ITEMS(I_ID, NAME, DESCRIPTION, QUANTITY)VALUES('" & CInt(Me.Item_IDTextBox.Text) & "', '" & Me.ItemNameTextBox.Text & "', '" & Me.ItemDescTextBox.Text & "', '" & Me.ItemQuantityTextBox.Text & "')"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            populateItems()
            MessageBox.Show("New Item has been added!")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ItemUpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemUpdateButton.Click
        sql = "UPDATE ITEMS SET NAME='" & Me.ItemNameTextBox.Text & "', DESCRIPTION='" & Me.ItemDescTextBox.Text & "', QUANTITY='" & Me.ItemQuantityTextBox.Text & "' WHERE I_ID=" & CInt(Item_IDTextBox.Text) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            populateItems()
            MessageBox.Show("The item details has been Updated!")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ItemDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ItemDataGridView.CellContentClick
        sql = "SELECT * FROM ITEMS WHERE I_ID =" & CInt(Me.ItemDataGridView.CurrentCell.Value) & ""
        cmd = New OleDbCommand(sql, con)
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            Me.Item_IDTextBox.Text = dr("I_ID")
            Me.ItemNameTextBox.Text = dr("NAME")
            Me.ItemDescTextBox.Text = dr("DESCRIPTION")
            Me.ItemQuantityTextBox.Text = dr("QUANTITY")
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ItemExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemExitButton.Click
        Me.Hide()
    End Sub
End Class
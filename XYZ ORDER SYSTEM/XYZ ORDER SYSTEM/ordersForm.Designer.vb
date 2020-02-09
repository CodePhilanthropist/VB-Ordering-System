<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Order_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderCusTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OrderItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OrderDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItemPrintButton = New System.Windows.Forms.Button()
        Me.ItemUpdateButton = New System.Windows.Forms.Button()
        Me.ItemSaveButton = New System.Windows.Forms.Button()
        Me.ItemAddButton = New System.Windows.Forms.Button()
        Me.OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.SearchCustomerButton = New System.Windows.Forms.Button()
        Me.OrderExitButton = New System.Windows.Forms.Button()
        Me.SearchItemButton = New System.Windows.Forms.Button()
        Me.RTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_IDTextBox
        '
        Me.Order_IDTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_IDTextBox.Location = New System.Drawing.Point(193, 52)
        Me.Order_IDTextBox.Multiline = True
        Me.Order_IDTextBox.Name = "Order_IDTextBox"
        Me.Order_IDTextBox.Size = New System.Drawing.Size(240, 41)
        Me.Order_IDTextBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Order ID:"
        '
        'OrderCusTextBox
        '
        Me.OrderCusTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderCusTextBox.Location = New System.Drawing.Point(193, 103)
        Me.OrderCusTextBox.Multiline = True
        Me.OrderCusTextBox.Name = "OrderCusTextBox"
        Me.OrderCusTextBox.Size = New System.Drawing.Size(240, 41)
        Me.OrderCusTextBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Costumer ID:"
        '
        'OrderItemIDTextBox
        '
        Me.OrderItemIDTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderItemIDTextBox.Location = New System.Drawing.Point(193, 150)
        Me.OrderItemIDTextBox.Multiline = True
        Me.OrderItemIDTextBox.Name = "OrderItemIDTextBox"
        Me.OrderItemIDTextBox.Size = New System.Drawing.Size(240, 41)
        Me.OrderItemIDTextBox.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Item ID:"
        '
        'OrderDateTextBox
        '
        Me.OrderDateTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDateTextBox.Location = New System.Drawing.Point(193, 197)
        Me.OrderDateTextBox.Multiline = True
        Me.OrderDateTextBox.Name = "OrderDateTextBox"
        Me.OrderDateTextBox.Size = New System.Drawing.Size(240, 41)
        Me.OrderDateTextBox.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Order Date:"
        '
        'ItemPrintButton
        '
        Me.ItemPrintButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemPrintButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemPrintButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemPrintButton.Location = New System.Drawing.Point(544, 293)
        Me.ItemPrintButton.Name = "ItemPrintButton"
        Me.ItemPrintButton.Size = New System.Drawing.Size(160, 58)
        Me.ItemPrintButton.TabIndex = 24
        Me.ItemPrintButton.Text = "Print"
        Me.ItemPrintButton.UseVisualStyleBackColor = False
        '
        'ItemUpdateButton
        '
        Me.ItemUpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemUpdateButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemUpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemUpdateButton.Location = New System.Drawing.Point(544, 165)
        Me.ItemUpdateButton.Name = "ItemUpdateButton"
        Me.ItemUpdateButton.Size = New System.Drawing.Size(160, 58)
        Me.ItemUpdateButton.TabIndex = 23
        Me.ItemUpdateButton.Text = "Update"
        Me.ItemUpdateButton.UseVisualStyleBackColor = False
        '
        'ItemSaveButton
        '
        Me.ItemSaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemSaveButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemSaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemSaveButton.Location = New System.Drawing.Point(544, 100)
        Me.ItemSaveButton.Name = "ItemSaveButton"
        Me.ItemSaveButton.Size = New System.Drawing.Size(160, 58)
        Me.ItemSaveButton.TabIndex = 22
        Me.ItemSaveButton.Text = "Save"
        Me.ItemSaveButton.UseVisualStyleBackColor = False
        '
        'ItemAddButton
        '
        Me.ItemAddButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemAddButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemAddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemAddButton.Location = New System.Drawing.Point(544, 35)
        Me.ItemAddButton.Name = "ItemAddButton"
        Me.ItemAddButton.Size = New System.Drawing.Size(160, 58)
        Me.ItemAddButton.TabIndex = 21
        Me.ItemAddButton.Text = "Add"
        Me.ItemAddButton.UseVisualStyleBackColor = False
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Location = New System.Drawing.Point(50, 374)
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.Size = New System.Drawing.Size(573, 153)
        Me.OrderDataGridView.TabIndex = 25
        '
        'SearchCustomerButton
        '
        Me.SearchCustomerButton.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCustomerButton.Location = New System.Drawing.Point(447, 108)
        Me.SearchCustomerButton.Name = "SearchCustomerButton"
        Me.SearchCustomerButton.Size = New System.Drawing.Size(41, 34)
        Me.SearchCustomerButton.TabIndex = 26
        Me.SearchCustomerButton.Text = "..."
        Me.SearchCustomerButton.UseVisualStyleBackColor = True
        '
        'OrderExitButton
        '
        Me.OrderExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OrderExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderExitButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OrderExitButton.Location = New System.Drawing.Point(544, 229)
        Me.OrderExitButton.Name = "OrderExitButton"
        Me.OrderExitButton.Size = New System.Drawing.Size(160, 58)
        Me.OrderExitButton.TabIndex = 27
        Me.OrderExitButton.Text = "Exit"
        Me.OrderExitButton.UseVisualStyleBackColor = False
        '
        'SearchItemButton
        '
        Me.SearchItemButton.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchItemButton.Location = New System.Drawing.Point(447, 153)
        Me.SearchItemButton.Name = "SearchItemButton"
        Me.SearchItemButton.Size = New System.Drawing.Size(41, 34)
        Me.SearchItemButton.TabIndex = 28
        Me.SearchItemButton.Text = "..."
        Me.SearchItemButton.UseVisualStyleBackColor = True
        '
        'RTextBox
        '
        Me.RTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTextBox.Location = New System.Drawing.Point(193, 249)
        Me.RTextBox.Multiline = True
        Me.RTextBox.Name = "RTextBox"
        Me.RTextBox.Size = New System.Drawing.Size(240, 41)
        Me.RTextBox.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 28)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Receipt No:"
        '
        'ordersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 553)
        Me.Controls.Add(Me.RTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SearchItemButton)
        Me.Controls.Add(Me.OrderExitButton)
        Me.Controls.Add(Me.SearchCustomerButton)
        Me.Controls.Add(Me.OrderDataGridView)
        Me.Controls.Add(Me.ItemPrintButton)
        Me.Controls.Add(Me.ItemUpdateButton)
        Me.Controls.Add(Me.ItemSaveButton)
        Me.Controls.Add(Me.ItemAddButton)
        Me.Controls.Add(Me.OrderDateTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OrderItemIDTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OrderCusTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Order_IDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ordersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Form"
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Order_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderCusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OrderItemIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OrderDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ItemPrintButton As System.Windows.Forms.Button
    Friend WithEvents ItemUpdateButton As System.Windows.Forms.Button
    Friend WithEvents ItemSaveButton As System.Windows.Forms.Button
    Friend WithEvents ItemAddButton As System.Windows.Forms.Button
    Friend WithEvents OrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SearchCustomerButton As System.Windows.Forms.Button
    Friend WithEvents OrderExitButton As System.Windows.Forms.Button
    Friend WithEvents SearchItemButton As System.Windows.Forms.Button
    Friend WithEvents RTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

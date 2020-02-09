<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemsForm
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
        Me.Item_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItemDescTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItemUpdateButton = New System.Windows.Forms.Button()
        Me.ItemSaveButton = New System.Windows.Forms.Button()
        Me.ItemAddButton = New System.Windows.Forms.Button()
        Me.ItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemExitButton = New System.Windows.Forms.Button()
        CType(Me.ItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item_IDTextBox
        '
        Me.Item_IDTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_IDTextBox.Location = New System.Drawing.Point(209, 32)
        Me.Item_IDTextBox.Multiline = True
        Me.Item_IDTextBox.Name = "Item_IDTextBox"
        Me.Item_IDTextBox.Size = New System.Drawing.Size(318, 41)
        Me.Item_IDTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Item ID:"
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameTextBox.Location = New System.Drawing.Point(209, 88)
        Me.ItemNameTextBox.Multiline = True
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(318, 41)
        Me.ItemNameTextBox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name:"
        '
        'ItemDescTextBox
        '
        Me.ItemDescTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemDescTextBox.Location = New System.Drawing.Point(209, 146)
        Me.ItemDescTextBox.Multiline = True
        Me.ItemDescTextBox.Name = "ItemDescTextBox"
        Me.ItemDescTextBox.Size = New System.Drawing.Size(318, 41)
        Me.ItemDescTextBox.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 28)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Description:"
        '
        'ItemQuantityTextBox
        '
        Me.ItemQuantityTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemQuantityTextBox.Location = New System.Drawing.Point(209, 204)
        Me.ItemQuantityTextBox.Multiline = True
        Me.ItemQuantityTextBox.Name = "ItemQuantityTextBox"
        Me.ItemQuantityTextBox.Size = New System.Drawing.Size(318, 41)
        Me.ItemQuantityTextBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quantity:"
        '
        'ItemUpdateButton
        '
        Me.ItemUpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemUpdateButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemUpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemUpdateButton.Location = New System.Drawing.Point(562, 162)
        Me.ItemUpdateButton.Name = "ItemUpdateButton"
        Me.ItemUpdateButton.Size = New System.Drawing.Size(160, 58)
        Me.ItemUpdateButton.TabIndex = 19
        Me.ItemUpdateButton.Text = "Update"
        Me.ItemUpdateButton.UseVisualStyleBackColor = False
        '
        'ItemSaveButton
        '
        Me.ItemSaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemSaveButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemSaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemSaveButton.Location = New System.Drawing.Point(562, 97)
        Me.ItemSaveButton.Name = "ItemSaveButton"
        Me.ItemSaveButton.Size = New System.Drawing.Size(160, 58)
        Me.ItemSaveButton.TabIndex = 18
        Me.ItemSaveButton.Text = "Save"
        Me.ItemSaveButton.UseVisualStyleBackColor = False
        '
        'ItemAddButton
        '
        Me.ItemAddButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemAddButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemAddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemAddButton.Location = New System.Drawing.Point(562, 32)
        Me.ItemAddButton.Name = "ItemAddButton"
        Me.ItemAddButton.Size = New System.Drawing.Size(160, 58)
        Me.ItemAddButton.TabIndex = 17
        Me.ItemAddButton.Text = "Add"
        Me.ItemAddButton.UseVisualStyleBackColor = False
        '
        'ItemDataGridView
        '
        Me.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemDataGridView.Location = New System.Drawing.Point(149, 303)
        Me.ItemDataGridView.Name = "ItemDataGridView"
        Me.ItemDataGridView.Size = New System.Drawing.Size(450, 152)
        Me.ItemDataGridView.TabIndex = 21
        '
        'ItemExitButton
        '
        Me.ItemExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemExitButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ItemExitButton.Location = New System.Drawing.Point(562, 222)
        Me.ItemExitButton.Name = "ItemExitButton"
        Me.ItemExitButton.Size = New System.Drawing.Size(160, 58)
        Me.ItemExitButton.TabIndex = 22
        Me.ItemExitButton.Text = "Exit"
        Me.ItemExitButton.UseVisualStyleBackColor = False
        '
        'itemsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 484)
        Me.Controls.Add(Me.ItemExitButton)
        Me.Controls.Add(Me.ItemDataGridView)
        Me.Controls.Add(Me.ItemUpdateButton)
        Me.Controls.Add(Me.ItemSaveButton)
        Me.Controls.Add(Me.ItemAddButton)
        Me.Controls.Add(Me.ItemQuantityTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ItemDescTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Item_IDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "itemsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items Form"
        CType(Me.ItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Item_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ItemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ItemDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ItemQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ItemUpdateButton As System.Windows.Forms.Button
    Friend WithEvents ItemSaveButton As System.Windows.Forms.Button
    Friend WithEvents ItemAddButton As System.Windows.Forms.Button
    Friend WithEvents ItemDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemExitButton As System.Windows.Forms.Button
End Class

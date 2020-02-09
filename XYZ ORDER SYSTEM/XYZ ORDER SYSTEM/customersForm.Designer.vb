<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cus_IDTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Middle Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact No:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address:"
        '
        'Cus_IDTextBox
        '
        Me.Cus_IDTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cus_IDTextBox.Location = New System.Drawing.Point(190, 36)
        Me.Cus_IDTextBox.Multiline = True
        Me.Cus_IDTextBox.Name = "Cus_IDTextBox"
        Me.Cus_IDTextBox.Size = New System.Drawing.Size(318, 41)
        Me.Cus_IDTextBox.TabIndex = 6
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(190, 94)
        Me.LastNameTextBox.Multiline = True
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(318, 41)
        Me.LastNameTextBox.TabIndex = 7
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(190, 141)
        Me.FirstNameTextBox.Multiline = True
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(318, 41)
        Me.FirstNameTextBox.TabIndex = 8
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(190, 197)
        Me.MiddleNameTextBox.Multiline = True
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(318, 41)
        Me.MiddleNameTextBox.TabIndex = 9
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNoTextBox.Location = New System.Drawing.Point(190, 251)
        Me.ContactNoTextBox.Multiline = True
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(318, 41)
        Me.ContactNoTextBox.TabIndex = 10
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(190, 307)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(420, 106)
        Me.AddressTextBox.TabIndex = 11
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Location = New System.Drawing.Point(64, 434)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(609, 139)
        Me.CustomerDataGridView.TabIndex = 12
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddButton.Location = New System.Drawing.Point(553, 28)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(160, 58)
        Me.AddButton.TabIndex = 13
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaveButton.Location = New System.Drawing.Point(553, 93)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(160, 58)
        Me.SaveButton.TabIndex = 14
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UpdateButton.Location = New System.Drawing.Point(553, 158)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(160, 58)
        Me.UpdateButton.TabIndex = 15
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitButton.Location = New System.Drawing.Point(553, 221)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(160, 58)
        Me.ExitButton.TabIndex = 16
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'CustomersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 603)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.ContactNoTextBox)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Cus_IDTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CustomersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers Form"
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cus_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class

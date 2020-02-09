<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchCustomers
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
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.SearchLTextBox = New System.Windows.Forms.TextBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(19, 27)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(178, 26)
        Me.UsernameLabel.TabIndex = 18
        Me.UsernameLabel.Text = "Search Customer:"
        '
        'SearchLTextBox
        '
        Me.SearchLTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLTextBox.Location = New System.Drawing.Point(208, 19)
        Me.SearchLTextBox.Multiline = True
        Me.SearchLTextBox.Name = "SearchLTextBox"
        Me.SearchLTextBox.Size = New System.Drawing.Size(277, 45)
        Me.SearchLTextBox.TabIndex = 17
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.Black
        Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkButton.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OkButton.Location = New System.Drawing.Point(520, 16)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(159, 46)
        Me.OkButton.TabIndex = 16
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'searchCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 87)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.SearchLTextBox)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "searchCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents SearchLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OkButton As System.Windows.Forms.Button
End Class

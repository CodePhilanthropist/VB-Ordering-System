Public Class ReceiptForm

    Private Sub ReceiptForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DateLabel.Text = ordersForm.OrderDateTextBox.Text
        Me.Usa.Text = ordersForm.loanern
        Me.Duha.Text = ordersForm.itemn
        Me.Tulo.Text = ordersForm.itemquant
        Me.Resibo.Text = ordersForm.RTextBox.Text


        PrintForm1.Form.Width = Me.Width
        PrintForm1.Form.Height = Me.Height
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0.75
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 0.75
        PrintForm1.PrinterSettings.PrinterName = "Microsoft XPS Document Writer"
        'PrintForm1.PrinterSettings.PrinterName = "\\IIT-PC\EPSON L360 Series"
        'PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0.75
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0.75
        'PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        'PrintForm1.Print(Me, Powerpacks, Printing.PrintForm.PrintOption.Scrollable)

    End Sub
    Private Sub ReceiptForm_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        PrintForm1.Print()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
Public Class AddItem
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim invCount As Integer
        Dim purPrice As Decimal
        Dim markUpMargin As Decimal

        lblStatus.Text = ""

        If txtNewUPC.Text = "" Then
            lblStatus.Text = String.Format("Error: UPC Field Cannot Be Blank!")
            Return
        End If

        If txtNewInvCount.Text = "" Then
            lblStatus.Text = String.Format("Error: Inventory Count Cannot Be Blank!")
            Return
        End If
        If Not Integer.TryParse(txtNewInvCount.Text, invCount) Then
            lblStatus.Text = String.Format("Error: Inventory Count Must Be A Valid Number!")
            Return
        End If
        If invCount < 0 Then
            lblStatus.Text = String.Format("Error: Cannot Add Item With Negetive Inventory Count.")
            Return
        End If

        If txtNewPurPrice.Text = "" Then
            lblStatus.Text = String.Format("Error: Purchase Price Cannot Be Blank!")
            Return
        End If
        If Not Decimal.TryParse(txtNewPurPrice.Text, purPrice) Then
            lblStatus.Text = String.Format("Error: Purchase Price Must Be A Valid Number!")
            Return
        End If
        If purPrice < 0 Then
            lblStatus.Text = String.Format("Error: Cannot Add Item With Negetive Purchase Price.")
            Return
        End If

        If txtNewMarkup.Text = "" Then
            lblStatus.Text = String.Format("Error: Mark-Up Field Cannot Be Blank!")
            Return
        End If
        If Not Decimal.TryParse(txtNewInvCount.Text, markUpMargin) Then
            lblStatus.Text = String.Format("Error: Mark-Up Margin Must Be A Valid Number!")
            Return
        End If
        If markUpMargin < 0 Then
            lblStatus.Text = String.Format("Error: Cannot Add Item With Negetive Mark-Up Margin.")
            Return
        End If

    End Sub
End Class
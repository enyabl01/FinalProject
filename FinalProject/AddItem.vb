Public Class AddItem
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim invCount As Integer
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
        End If

    End Sub
End Class
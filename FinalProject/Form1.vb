Public Class Form1

    Private mItemObject As New ItemObject
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        AddItem.ShowDialog()
    End Sub

    Private Sub CatagoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatagoryToolStripMenuItem.Click
        AddCatagory.ShowDialog()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        AddDepartment.ShowDialog()
    End Sub
End Class

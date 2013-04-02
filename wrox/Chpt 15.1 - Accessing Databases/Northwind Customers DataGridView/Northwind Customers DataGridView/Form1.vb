Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Northwind_2007DataSet.CustomerQuery' table. You can move, or remove it, as needed.
        Me.CustomerQueryTableAdapter.Fill(Me.Northwind_2007DataSet.CustomerQuery)

    End Sub
End Class

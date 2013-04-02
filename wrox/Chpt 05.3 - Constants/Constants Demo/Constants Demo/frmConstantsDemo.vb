Public Class frmConstantsDemo
    'File name constant
    Private Const strFileName As String = "C:\Temp\Hello.txt"

    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        'Using a constant
        MessageBox.Show("1: " & strFileName, "Constants Demo")
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        'Using the constant again
        MessageBox.Show("2: " & strFileName, "Constants Demo")
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        'Reusing the constant one more time
        MessageBox.Show("3: " & strFileName, "Constants Demo")
    End Sub
End Class

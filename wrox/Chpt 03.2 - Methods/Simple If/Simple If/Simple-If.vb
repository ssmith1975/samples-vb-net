Public Class Simple_If

    Private Sub btnIf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIf.Click
        'Declare and set variable
        Dim intNumber As Integer = 27

        'Here's where you make a decision
        'and tell the user what happened
        If intNumber = 27 Then
            MessageBox.Show("'intNumber' is, indeed, 27!", "Simple If")
        End If

    End Sub

    Private Sub btnAnotherIf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnotherIf.Click
        Dim intNumber As Integer = 27

        'Here's where you make a decision
        'and tell the user what happened
        If intNumber = 1000 Then
            MessageBox.Show("'intNumber' is, indeed, 1000!", "Simple If")
        ElseIf intNumber = 27 Then
            MessageBox.Show("'intNumber' is  27!", "Simple If")
        Else
            MessageBox.Show("'intNumber' is not 1000!", "Simple If")
        End If
    End Sub
End Class

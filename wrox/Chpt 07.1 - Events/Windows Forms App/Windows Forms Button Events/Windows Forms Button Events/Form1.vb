Public Class Form1

    Private Sub btnSayHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSayHello.Click
        MessageBox.Show("Hello World!", Me.Text)
    End Sub

    Private Sub btnSayHello_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSayHello.MouseEnter
        'Change the Button text
        btnSayHello.Text = "The mouse is here!"
    End Sub

    Private Sub btnSayHello_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSayHello.MouseLeave
        'Change the Button text
        btnSayHello.Text = "The mouse has gone!"
    End Sub
End Class

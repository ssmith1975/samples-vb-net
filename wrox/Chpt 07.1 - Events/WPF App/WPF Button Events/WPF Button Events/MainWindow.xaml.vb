Class MainWindow 

    Private Sub btnSayHello_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnSayHello.Click
        MessageBox.Show("Hello World!", Me.Title)
    End Sub

    Private Sub btnSayHello_MouseEnter(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles btnSayHello.MouseEnter
        btnSayHello.Content = "The mouse is here!"
    End Sub

    Private Sub btnSayHello_MouseLeave(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles btnSayHello.MouseLeave
        btnSayHello.Content = "The mouse has gone!"
    End Sub
End Class

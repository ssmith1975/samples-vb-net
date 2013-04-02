Class frmWordCounter
    ''' <summary>
    ''' Count the characters in a block of text
    ''' </summary>
    ''' <param name="text">The string containing the text to count
    ''' characters in</param>
    ''' <returns>The number of characters in the string</returns>
    ''' <remarks></remarks>
    Private Function CountCharacters(ByVal text As String) As Integer
        Return text.Length
    End Function

    ''' <summary>
    ''' Count the number of words in a block of text
    ''' </summary>
    ''' <param name="text">The string containing the text to count</param>
    ''' <returns>The number of words in the string</returns>
    ''' <remarks></remarks>
    Private Function CountWords(ByVal text As String) As Integer
        'Is the text empty?
        If text.Trim.Length = 0 Then Return 0

        'Split the words
        Dim strWords() As String = text.Split(" "c)

        'Return the number of words
        Return strWords.Length
    End Function
    Private Sub UpdateDisplay()
        'If the window has not completed initialization then exit
        'this procedure as the radCountWords radio button has not
        'been created yet
        If Not Me.IsInitialized Then Exit Sub

        'Do we want to count words?
        If radCountWords.IsChecked Then
            'Update the results with words
            lblResults.Content = CountWords(txtWords.Text) & " words"
        Else
            'Update the results with words
            lblResults.Content = CountCharacters(txtWords.Text) & " characters"
        End If

    End Sub

    Private Sub txtWords_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.TextChangedEventArgs) Handles txtWords.TextChanged
        'Something changed so display the results
        UpdateDisplay()
    End Sub


    Private Sub radCountChars_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles radCountChars.Checked
        'Something changed so display the results
        UpdateDisplay()
    End Sub

    Private Sub radCountWords_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles radCountWords.Checked
        'Something changed so display the results
        UpdateDisplay()
    End Sub
End Class

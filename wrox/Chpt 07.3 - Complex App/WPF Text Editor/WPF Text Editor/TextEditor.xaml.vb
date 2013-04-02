Class TextEditor
    'Gets or sets the text on the status bar
    Public Property StatusText() As String
        Get
            Return sbiStatus.Content.ToString
        End Get
        Set(ByVal value As String)
            sbiStatus.Content = value
        End Set
    End Property

    'Gets or sets the text you're editing
    Public Property EditText() As String
        Get
            Return txtEdit.Text
        End Get
        Set(ByVal value As String)
            txtEdit.Text = value
        End Set
    End Property

    'Clears the txtEdit control
    Public Sub ClearEditBox()
        'Set the EditText property
        EditText = String.Empty

        'Reset the font color
        txtEdit.Foreground = Brushes.Black

        'Set the status bar text
        StatusText = "Text box cleared"
    End Sub

    Public Sub RedText()
        'Make the text red
        txtEdit.Foreground = Brushes.Red

        'Update the status bar text
        StatusText = "The text is red"
    End Sub

    Public Sub BlueText()
        'Make the text blue
        txtEdit.Foreground = Brushes.Blue

        'Set the status bar text
        StatusText = "The text is blue"

    End Sub

    Public Sub UpperCaseText()
        'Make the text uppercase
        EditText = EditText.ToUpper

        'Update the status bar text
        StatusText = "The text is all uppercase"
    End Sub

    Public Sub LowerCaseText()
        'Make the text lowercase
        EditText = EditText.ToLower

        'Update the status bar text
        StatusText = "The text is all lowercase"
    End Sub

    Private Sub txtEdit_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.TextChangedEventArgs) Handles txtEdit.TextChanged
        'Reset the status bar text
        StatusText = "Ready"
    End Sub


    Private Sub tbrClear_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles tbrClear.Click
        'Clear the edit box
        ClearEditBox()
    End Sub

    Private Sub tbrRed_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles tbrRed.Click
        'Make the text red
        RedText()
    End Sub

    Private Sub tbrBlue_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles tbrBlue.Click
        'Make the text blue
        BlueText()
    End Sub

    Private Sub tbrUpperCase_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles tbrUpperCase.Click
        'Make the text uppercase
        UpperCaseText()
    End Sub

    Private Sub tbrLowerCase_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles tbrLowerCase.Click
        'Make the text lowercase
        LowerCaseText()
    End Sub
    Public Sub ShowAboutBox()
        'Display the About dialog box
        Using objAbout As New About
            objAbout.ShowDialog()
        End Using
    End Sub



    Private Sub tbrHelpAbout_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles tbrHelpAbout.Click
        'Display the About dialog box
        ShowAboutBox()
    End Sub
End Class

Imports System.Text

Class MainWindow
    ' Private variable
    Private strStates() As String = {"AK", "AL", "AZ", "AR", "CA", "CO"}

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        cboState.ItemsSource = strStates

    End Sub

    Private Sub btnApplyNow_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnApplyNow.Click
        'Declare and instantiate a StringBuilder object
        Dim objStringBuilder As New StringBuilder

        'Add the question
        objStringBuilder.AppendLine("Is your personal " & _
            "information listed here correct?")
        objStringBuilder.AppendLine(String.Empty)

        'Add the personal information
        objStringBuilder.AppendLine(txtFirstName.Text & " " & _
            txtLastName.Text)
        objStringBuilder.AppendLine(txtAddress.Text)
        objStringBuilder.AppendLine(txtCity.Text & ", " & _
            cboState.SelectedItem.ToString() & " " & txtPostalCode.Text)

        'Display a message box to verify the informaiton
        If MessageBox.Show(objStringBuilder.ToString, _
            My.Application.Info.Title, MessageBoxButton.YesNo, _
            MessageBoxImage.Question) = MessageBoxResult.Yes Then

            'Do some processing here

        Else
            'Return to the window and let the user correct
            'their information
        End If
    End Sub
End Class

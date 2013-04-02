Public Class frmSelectCase

    Private Sub lstData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstData.SelectedIndexChanged
        'Declare variables
        Dim strName As String
        Dim strFavoriteColor As String

        'Get the selected name
        strName = lstData.Items(lstData.SelectedIndex).ToString

        'Use a Select Case statement to get the favorite color
        'of the selected name
        Select Case strName.ToLower
            Case "bryan"
                strFavoriteColor = "Madras Yellow"
            Case "ashley"
                strFavoriteColor = "Sea Blue"
            Case "jennifer"
                strFavoriteColor = "Morning Mist"
            Case "eddie"
                strFavoriteColor = "Passionate Purple"
            Case "katelyn"
                strFavoriteColor = "Red"
            Case Else
                strFavoriteColor = "Unknown"
        End Select

        'Display the the favorite color of the selected name
        MessageBox.Show(strName & "'s favorite color is " & strFavoriteColor, "Select Demo")

        'Use the Select Case statement to display the person's gender
        Select Case strName.ToLower
            Case "bryan", "eddie", "ashley"
                MessageBox.Show("This person's gender is male.", "Select Demo")
            Case "jennifer", "katelyn"
                MessageBox.Show("This peron's gender is female.", "Select Demo")
            Case Else
                MessageBox.Show("I don't know this peron's gender.", "Select Demo")
        End Select

    End Sub
End Class

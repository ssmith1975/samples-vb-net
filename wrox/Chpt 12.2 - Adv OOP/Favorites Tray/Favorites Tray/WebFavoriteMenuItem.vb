Imports Internet_Favorites

Public Class WebFavoriteMenuItem
    Inherits MenuItem

    'Public member
    Public Favorite As WebFavorite

    'Constructor
    Public Sub New(ByVal newFavorite As WebFavorite)
        'Set the property
        Favorite = newFavorite

        'Update the text
        Text = Favorite.Name
    End Sub

    Private Sub WebFavoriteMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        'Open the favorite
        If Not Favorite Is Nothing Then
            Process.Start(Favorite.URL)
        End If
    End Sub
End Class

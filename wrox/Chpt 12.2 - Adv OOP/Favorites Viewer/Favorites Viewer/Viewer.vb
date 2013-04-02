Imports Internet_Favorites

Public Class Viewer
    'Public member
    Public objFavorites As New Favorites()

    Private Sub Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Create and use a new instance of the Favorites class
            Using objFavorites As New Favorites

                'Scan the Favorites folder
                objFavorites.ScanFavorites()

                'Proces each objWebFavorite object in the
                'favorites collection
                For Each objWebFavorite As WebFavorite In _
                    objFavorites.FavoritesCollection

                    'Declare a ListViewItem object
                    Dim objListViewItem As New ListViewItem

                    'Set the properties of the ListViewItem object
                    objListViewItem.Text = objWebFavorite.Name
                    objListViewItem.SubItems.Add(objWebFavorite.URL)

                    'Add the ListViewItem object to the ListView
                    lvwFavorites.Items.Add(objListViewItem)
                Next

            End Using
        Catch ExceptionErr As Exception
            'Display the error
            MessageBox.Show(ExceptionErr.Message, "Favorites Viewer", _
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lvwFavorites_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwFavorites.Click
        'Update the link label control Text property
        lnkURL.Text = "Visit " & lvwFavorites.SelectedItems.Item(0).Text

        'Clear the default hyperlink
        lnkURL.Links.Clear()

        'Add the selected hyperlink to the LinkCollection
        lnkURL.Links.Add(6, lvwFavorites.SelectedItems.Item(0).Text.Length, _
            lvwFavorites.SelectedItems.Item(0).SubItems(1).Text)
    End Sub

    Private Sub lnkURL_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkURL.LinkClicked
        'Process the selected link
        Process.Start(e.Link.LinkData)
    End Sub
End Class

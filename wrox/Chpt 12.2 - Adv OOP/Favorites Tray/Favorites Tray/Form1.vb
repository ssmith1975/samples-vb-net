
Imports Internet_Favorites
Public Class Form1
    'Public member
    Public Favorites As New Favorites()

    'Private member
    Private blnLoadCalled As Boolean = False

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load the favorites
        Favorites.ScanFavorites()

        'Create a new context menu
        Dim objMenu As New ContextMenu()

        'Process each favorite
        For Each objWebFavorite As WebFavorite In Favorites.FavoritesCollection
            'Create a menu item
            Dim objItem As New WebFavoriteMenuItem(objWebFavorite)

            'Add  it to the menu
            objMenu.MenuItems.Add(objItem)
        Next

        'Add a separator menu item
        objMenu.MenuItems.Add("-")

        'Now add the Exit menu item
        objMenu.MenuItems.Add(New ExitMenuItem())

        'Finally, tell the tray icon to use this menu
        icnNotify.ContextMenu = objMenu

        'Set the load flag and hide  ourselves
        blnLoadCalled = True
        Me.Hide()
    End Sub


    Private Sub Form1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        'Don't set the Visible property until the Load event has
        'been processed
        If blnLoadCalled = False Then
            Return
        End If

        'If the user can see us, hide us
        If Me.Visible = True Then Me.Visible = False
    End Sub
End Class

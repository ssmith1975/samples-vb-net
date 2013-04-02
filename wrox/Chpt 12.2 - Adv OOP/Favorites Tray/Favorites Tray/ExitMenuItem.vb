Public Class ExitMenuItem
    Inherits MenuItem

    'Constructor
    Public Sub New()
        Text = "Exit"
    End Sub


    Private Sub ExitMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Application.Exit()
    End Sub
End Class

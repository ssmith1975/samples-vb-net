Public Class frmScopeDemo

    Private Sub btnScope_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScope.Click
        'Call a method
        DisplayBalthazarsName()
    End Sub

    Private Sub DisplaySebastiansName()
        'Declare variable and set value
        Dim strName As String
        strName = "Sebastian Blackwood"

        'Display results
        MessageBox.Show(strName, "Scope Demo")

    End Sub

    Private Sub DisplayBalthazarsName()
        'Declare variable and set value
        Dim strName As String
        strName = "Balthazar Keech"

        'Display results
        MessageBox.Show(strName, "Scope Demo")
    End Sub
End Class

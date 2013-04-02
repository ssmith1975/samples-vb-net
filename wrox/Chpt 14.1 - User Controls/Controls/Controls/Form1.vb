Public Class Form1

    Private Sub btnTaskbarHeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaskbarHeight.Click
        MessageBox.Show("Taskbar Height = " & _
            MyNamespace1.TaskBarHeight & " pixels", "Form1")
    End Sub


    Private Sub MyNamespace1_ApplicationCopyrightChanged(ByVal text As String)
        txtApplicationCopyright.Text = text
    End Sub

    Private Sub MyNamespace1_ScreenBoundsChanged(ByVal bounds As System.Drawing.Rectangle)
        txtScreenBounds.Text = bounds.ToString
    End Sub

    Private Sub MyNamespace1_ScreenWorkingAreaChanged(ByVal bounds As System.Drawing.Rectangle)
        txtScreenWorkingArea.Text = bounds.ToString
    End Sub

    Private Sub MyNamespace1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

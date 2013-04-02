Public Class frmMessageBox

    Private Sub frmMessageBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn2Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2Buttons.Click
        If MessageBox.Show("Your Internet connection will now be closed.", _
            "Network Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, _
            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

            lblResults.Text = "OK Clicked"
            'Call some method
        Else
            lblResults.Text = "Cancel Clicked"
            'Call some method here
        End If
    End Sub

    Private Sub btn3Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3Buttons.Click
        'Declare local variable
        Dim intResult As DialogResult

        'Get the results of the button clicked
        intResult = _
            MessageBox.Show("Do you want to save changes to the New Document?", _
                "My Word Processor", MessageBoxButtons.YesNoCancel, _
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3)

        'Process the results of the button clicked
        Select Case intResult
            Case Windows.Forms.DialogResult.Yes
                lblResults.Text = "Yes Clicked"
                'Do yes processing here
            Case Windows.Forms.DialogResult.No
                lblResults.Text = "No Clicked"
                'Do no processing here
            Case Windows.Forms.DialogResult.Cancel
                lblResults.Text = "Cancel Clicked"
                'Do cancel processing here

        End Select
    End Sub
End Class

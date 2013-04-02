Public Class frmMenuDemo

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        'Clear the text boxes
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty

        'Set focus to the first text box
        TextBox1.Focus()

    End Sub

    'New
    Private Sub NewToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'Call the NewToolStripMenuItem_Click procedure
        NewToolStripMenuItem_Click(sender, e)
    End Sub

    'Exit
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the form and end
        Me.Close()
    End Sub

    'Undo
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        'Undo the last operation
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Undo()
        End If
    End Sub

    Private Sub ContextUndoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextUndoToolStripMenuItem.Click
        'Call the UndoToolStripMenuItem_Click procedure
        UndoToolStripMenuItem_Click(sender, e)
    End Sub

    'Copy
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        'Copy the text to the clipboard 
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub
    Private Sub CopyToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        'Call the CopyToolStripMenuItem_Click procedure
        CopyToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub ContextCopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextCopyToolStripMenuItem.Click
        'Call the CopyToolStripMenuItem_Click procedure
        CopyToolStripMenuItem_Click(sender, e)
    End Sub



    'Cut
    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        'Copy the text to the clipboard and clear the field
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Cut()
        End If
    End Sub


    Private Sub CutToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click
        'Call the CutToolStripMenuItem_Click procedure
        CutToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ContextCutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextCutToolStripMenuItem.Click
        'Call the CutToolStripMenuItem_Click procedure
        CutToolStripMenuItem_Click(sender, e)
    End Sub

    'Paste
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        'Copy the text from the clipboard to the textbox
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Paste()
        End If
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        'Call the PasteToolStripMenuItem_Click procedure
        PasteToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub ContextPasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextPasteToolStripMenuItem.Click
        'Call the PasteToolStripMenuItem_Click procedure
        PasteToolStripMenuItem_Click(sender, e)
    End Sub

    'Select All
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        'Select all the text in the text box
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).SelectAll()
        End If
    End Sub

    Private Sub ContextSelectAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextSelectAllToolStripMenuItem.Click
        'Call the SelectAllToolStripMenuItem_Click procedure
        SelectAllToolStripMenuItem_Click(sender, e)
    End Sub

    'Main ToolStrip Menu Item Toggle
    Private Sub MainToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainToolStripMenuItem.Click
        'Toggle the visibility of the Main toolbar
        'based on the menu item's Checked property

        If MainToolStripMenuItem.Checked Then
            tspMain.Visible = True

        Else
            tspMain.Visible = False
        End If
    End Sub

    Private Sub FormattingToolStripMenuItem_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormattingToolStripMenuItem.Click
        'Toggle the visibility of the Formatting toolbar
        'based on the menu item's Checked property

        If FormattingToolStripMenuItem.Checked Then
            tspFormatting.Visible = True
        Else
            tspFormatting.Visible = False
        End If
    End Sub

    Private Sub ToggleMenus()
        'Declare a TextBox object and set it to the ActiveControl
        Dim objTextBox As TextBox = CType(Me.ActiveControl, TextBox)

        'Declare and set a Boolean variable
        Dim blnEnabled As Boolean = CType(objTextBox.SelectionLength, Boolean)

        'Toggle the Undo menu items
        UndoToolStripMenuItem.Enabled = objTextBox.CanUndo
        ContextUndoToolStripMenuItem.Enabled = objTextBox.CanUndo

        'Toggle the Cut toolbar button and items
        CutToolStripButton.Enabled = blnEnabled
        CutToolStripMenuItem.Enabled = blnEnabled
        ContextCutToolStripMenuItem.Enabled = blnEnabled

        'Toggle the Copy toolbar button and items
        CopyToolStripButton.Enabled = blnEnabled
        CopyToolStripMenuItem.Enabled = blnEnabled
        ContextCopyToolStripMenuItem.Enabled = blnEnabled

        'Reset the blnEnabled variable
        blnEnabled = My.Computer.Clipboard.ContainsText

        'Toggle the Paste toolbar button and menu items
        PasteToolStripButton.Enabled = blnEnabled
        PasteToolStripMenuItem.Enabled = blnEnabled
        ContextPasteToolStripMenuItem.Enabled = blnEnabled

        'Reset the blnEnabled variable
        If objTextBox.SelectionLength < objTextBox.TextLength Then
            blnEnabled = True
        Else
            blnEnabled = False

        End If


        'Toggle the Select All menu items
        SelectAllToolStripMenuItem.Enabled = blnEnabled
        ContextSelectAllToolStripMenuItem.Enabled = blnEnabled


    End Sub






    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Toggle toolbar and menu items
        ToggleMenus()
    End Sub
End Class

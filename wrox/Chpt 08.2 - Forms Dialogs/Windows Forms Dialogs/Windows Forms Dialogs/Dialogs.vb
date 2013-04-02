Imports System.Drawing.Printing

Public Class Dialogs
    'Declare variable
    Private strFileName As String
    Private strPrintRecord As String
    Private WithEvents DialogsPrintDocument As PrintDocument 'PrintDocument object

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        'Set the Open dialog properties with OpenFileDialog1
        With OpenFileDialog1
            .Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Demo Open File Dialog"
        End With

        'Show the Open dialog and if the user clicks the Open button,
        'load the file
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save the file path and name
                strFileName = OpenFileDialog1.FileName

                Dim fileContents As String
                fileContents = My.Computer.FileSystem.ReadAllText(strFileName)

                'Display the file contents in the text box
                txtFile.Text = fileContents


            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Set the Save dialog properties
        With SaveFileDialog1
            .DefaultExt = "txt"
            .FileName = strFileName
            .Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Demo Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save the file path and name
                strFileName = SaveFileDialog1.FileName

                My.Computer.FileSystem.WriteAllText(strFileName, txtFile.Text, False)
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, _
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        'Set the Font properties
        FontDialog1.ShowColor = True

        'Show the Font dilaog and if the user clicks the OK button,
        'update the font and color in the text box
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFile.Font = FontDialog1.Font
            txtFile.ForeColor = FontDialog1.Color
        End If
    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        'Show the Color dialog and if the user clicks the OK button,
        'update the background color of the form
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub


    Private Sub DialogsPrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles DialogsPrintDocument.PrintPage
        'Declare variables
        Dim intCharactersToPrint As Integer
        Dim intLinesPerPage As Integer
        Dim strPrintData As String
        Dim objStringFormat As New StringFormat
        Dim objPrintFont As New Font("Arial", 10)
        Dim objPageBoundaries As RectangleF
        Dim objPrintArea As SizeF

        'Get the page boundaries
        objPageBoundaries = New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, _
                            e.MarginBounds.Height)

        'Get the print area based on page margins and font used
        objPrintArea = New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - objPrintFont.GetHeight(e.Graphics))

        'Break in between the words on a line
        objStringFormat.Trimming = StringTrimming.Word

        'Get the number of characters to print
        e.Graphics.MeasureString(strPrintRecord, objPrintFont, objPrintArea, objStringFormat, intCharactersToPrint, _
                        intLinesPerPage)

        'Get the print data from the print record
        strPrintData = strPrintRecord.Substring(0, intCharactersToPrint)

        'Print the page
        e.Graphics.DrawString(strPrintData, objPrintFont, Brushes.Black, objPageBoundaries, objStringFormat)

        'If more lines exist, print another page
        If intCharactersToPrint < strPrintRecord.Length Then
            'Remove printed text from print record
            strPrintRecord = strPrintRecord.Remove(0, intCharactersToPrint)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Instantiate a new instance of the PrintDocument
        DialogsPrintDocument = New PrintDocument

        'Set the PrintDialog properties
        With PrintDialog1
            .AllowCurrentPage = False
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = False
            .Document = DialogsPrintDocument
            .PrinterSettings.DefaultPageSettings.Margins.Top = 25
            .PrinterSettings.DefaultPageSettings.Margins.Bottom = 25
            .PrinterSettings.DefaultPageSettings.Margins.Left = 25
            .PrinterSettings.DefaultPageSettings.Margins.Right = 25
        End With

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            'Set the selected printer settings in the PrintDocument
            DialogsPrintDocument.PrinterSettings = PrintDialog1.PrinterSettings

            'Get the print data
            strPrintRecord = txtFile.Text

            'Invoke the Print method on the PrintDocument
            DialogsPrintDocument.Print()

        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        'Set the FolderBrowser dialog properties
        With FolderBrowserDialog1
            .Description = "Select a backup folder"
            .RootFolder = Environment.SpecialFolder.MyComputer
            .ShowNewFolderButton = False
        End With

        'Show the FolderBrowser dialog and if the user clicks the 
        'OK button, display the selected folder
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFile.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class

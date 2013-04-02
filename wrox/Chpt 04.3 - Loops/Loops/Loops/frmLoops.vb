Public Class frmLoops

    Private Sub btnForNextLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForNextLoop.Click
        'Declare variable
        Dim intCount As Integer

        'Clear list
        ClearList()

        'Perform a loop
        For intCount = 1 To 5
            'Add the item to the list
            lstData.Items.Add("I'm item " & intCount.ToString & _
                              " in the list !")
        Next
    End Sub

    Private Sub ClearList()
        'Clear the list
        lstData.Items.Clear()
    End Sub

    Private Sub btnForNextLoopWithStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForNextLoopWithStep.Click
        'Clear the list
        ClearList()

        'Perform a loop
        For intCount As Integer = 4 To 62 Step 7
            'Add the item to the list
            lstData.Items.Add(intCount.ToString)
        Next
    End Sub

    Private Sub btnBackwardsForNextLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackwardsForNextLoop.Click
        'Clear the list
        ClearList()

        'Perform a loop
        For intCount As Integer = 10 To 1 Step -1
            'Add the item to the list
            lstData.Items.Add(intCount.ToString)
        Next
    End Sub

    Private Sub btnForEachLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForEachLoop.Click
        'Clear the list
        ClearList()

        'List each folder at the root of your C drive
        For Each strFolder As String In _
            My.Computer.FileSystem.GetDirectories("C:\")
            'Add the item to the list
            lstData.Items.Add(strFolder)
        Next
    End Sub

    Private Sub btnDoUntilLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoUntilLoop.Click
        'Declare variables
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0

        'Clear the list
        ClearList()

        'Process the loop util intRandomNumber = 0
        Do Until intRandomNumber = 10
            'Get a random number between 0 and 24
            intRandomNumber = objRandom.Next(25)

            'Add the number to the list
            lstData.Items.Add(intRandomNumber.ToString)
        Loop
    End Sub

    Private Sub btnDoWhileLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWhileLoop.Click
        'Declare variables
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0

        'Clear the list
        ClearList()

        'Process the loop while intRandomNumber < 15
        Do While intRandomNumber < 15
            'Get the random number between 0 and 24
            intRandomNumber = objRandom.Next(25)

            'Add the number to the list
            lstData.Items.Add(intRandomNumber.ToString)
        Loop



    End Sub

    Private Sub btnNestedLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNestedLoop.Click
        'Clear the list
        ClearList()

        'Process the outer loop
        For intOuterLoop As Integer = 1 To 2
            'Process the inner loop
            For intInnerLoop As Integer = 1 To 3
                lstData.Items.Add(intOuterLoop.ToString & _
                    ", " & intInnerLoop.ToString)
            Next
        Next
    End Sub

    Private Sub btnQuittingAForLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuittingAForLoop.Click
        'Clear the list
        ClearList()

        'List each folder at the root of your C drive
        For Each strFolder As String In _
            My.Computer.FileSystem.GetDirectories("C:\")

            'Add the item to the list
            lstData.Items.Add(strFolder)

            'Do you have the folder C:\Program Files?
            If String.Compare(strFolder, "C:\program files", True) = 0 Then
                'Tell the user
                MessageBox.Show("Found it, exiting the loop now.", "Loops")

                'Quit the loop early
                Exit For
            End If
        Next
    End Sub

    Private Sub btnQuittingADoLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuittingADoLoop.Click
        'Declare variable
        Dim intCount As Integer = 0

        'Clear the list
        ClearList()

        'Process the loop
        Do While intCount < 10
            'Add the item to the list
            lstData.Items.Add(intCount.ToString)

            'Increment the count by 1
            intCount += 1

            'Should you quit the  loop
            If intCount = 3 Then
                Exit Do
            End If
        Loop
    End Sub
End Class

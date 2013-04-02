Public Class frmDateDemo

    Private Sub btnShowDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowDate.Click
        'Declare variable
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now

        'Display the results
        MessageBox.Show(dteResults.ToString, "Date Demo")

        'Display dates
        MessageBox.Show(dteResults.ToLongDateString, "Date Demo")
        MessageBox.Show(dteResults.ToShortDateString, "Date Demo")

        'Display times
        MessageBox.Show(dteResults.ToLongTimeString, "Date Demo")
        MessageBox.Show(dteResults.ToShortTimeString, "Date Demo")

        '

    End Sub

    Private Sub btnDateProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateProperties.Click
        'Declare variable
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now

        'Display the various date properties
        MessageBox.Show("Month: " & dteResults.Month, "Date Demo")
        MessageBox.Show("Day: " & dteResults.Day, "Date Demo")
        MessageBox.Show("Year: " & dteResults.Year, "Date Demo")
        MessageBox.Show("Hour: " & dteResults.Hour, "Date Demo")
        MessageBox.Show("Minute: " & dteResults.Minute, "Date Demo")
        MessageBox.Show("Second: " & dteResults.Second, "Date Demo")
        MessageBox.Show("Day of Week: " & dteResults.DayOfWeek, "Date Demo")
        MessageBox.Show("Day of Year: " & dteResults.DayOfYear, "Date Demo")
    End Sub

    Private Sub btnDateNames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateNames.Click
        'Declare variable
        Dim dteResults As Date

        'Get the current date and time
        dteResults = Now

        MessageBox.Show("Weekday name: " & dteResults.ToString("dddd"), "Date Demo")
        MessageBox.Show("Month name: " & dteResults.ToString("MMMM"), "Date Demo")
    End Sub

    Private Sub btnDateLiteral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateLiteral.Click
        'Declare variable
        Dim dteResults As Date

        'Set a date and time
        dteResults = #1/1/2010 8:01:00 AM#

        'Display the date and time
        MessageBox.Show(dteResults.ToLongDateString & " " & dteResults.ToLongTimeString, "Date Demo")

    End Sub

    Private Sub btnDateManipulation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateManipulation.Click
        'Declare variables
        Dim dteStartDate As Date
        Dim dteChangedDate As Date

        'Start in the year 2400
        dteStartDate = #2/28/2400#

        'Add a day and display the results
        dteChangedDate = dteStartDate.AddDays(1)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")

        'Add some months and display the results
        dteChangedDate = dteStartDate.AddMonths(6)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")

        'Subtract a year and display the results
        dteChangedDate = dteStartDate.AddYears(-1)
        MessageBox.Show(dteChangedDate.ToLongDateString, "Date Demo")
    End Sub
End Class

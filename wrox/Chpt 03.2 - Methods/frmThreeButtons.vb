Public Class frmThreeButtons

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Declare variable
        Dim dblArea As Double

        'Calculate the area of a cirle with a radius of 100
        dblArea = CalculateAreaFromRadius(100)

        'Display the results
        MessageBox.Show(dblArea.ToString, "Area of 100")

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Call your method
        SayHello()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Call your method
        SayHello()
    End Sub
    Private Sub SayHello()
        MessageBox.Show("I have changed!", "Three Buttons")
    End Sub

    'CalculateAreaFromRadius-find the area of a circle
    Private Function CalculateAreaFromRadius(ByVal radius As Double) As Double
        'Declare variables
        Dim dblRadiusSquared As Double
        Dim dblResult As Double

        'Square the radius
        dblRadiusSquared = radius * radius

        'Multiply it by pi
        dblResult = dblRadiusSquared * Math.PI

        'Return the result
        Return dblResult
    End Function
End Class

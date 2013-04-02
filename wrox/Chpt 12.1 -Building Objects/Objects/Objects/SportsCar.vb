Imports MyCodeWidgets.CarPerformance


Public Class SportsCar
    Inherits Car

    Public Weight As Integer

    'Constructor
    Public Sub New()
        'Change the default values
        Color = "Green"
        NumberOfDoors = 2
    End Sub

    'GetPowerToWeightRatio-work out the power to weight
    Public Function GetPowerToWeightRatio() As Double
        'Calculate the horsepower
        Return CType(HorsePower, Double) / CType(Weight, Double)
    End Function

    'CalculateAccelerationRate-take the power/weight into consideration
    Public Overrides Function CalculateAccelerationRate() As Double
        'You'll assume the sae 4.2 value, but you'll multiply it
        'by the power/weight ratio
        Return 4.2 * GetPowerToWeightRatio()
    End Function
End Class

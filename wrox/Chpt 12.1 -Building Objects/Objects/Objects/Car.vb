
Namespace CarPerformance


    Public Class Car
        Public Color As String
        Public HorsePower As Integer
        Private intSpeed As Integer
        Private intNumberOfDoors As Integer


        'Constructor
        Public Sub New()
            'Set the default values
            Color = "White"
            intSpeed = 0
            intNumberOfDoors = 5
        End Sub

        'NumberOfDoors-get/set the number of doors
        Public Property NumberOfDoors() As Integer
            'Called when the property is read
            Get
                Return intNumberOfDoors
            End Get
            'Called when the property is set
            Set(ByVal value As Integer)
                'Is the new value between two and five
                If value >= 2 And value <= 5 Then
                    intNumberOfDoors = value
                End If
            End Set
        End Property

        'Speed-read-only property to return the speed
        Public ReadOnly Property Speed() As Integer
            Get
                Return intSpeed
            End Get
        End Property

        'Accelerate-add mph to the speed
        Public Sub Accelerate(ByVal accelerateBy As Integer)
            'Adjust the speed
            intSpeed += accelerateBy
        End Sub

        'IsMoving-is the car moving?
        Public Function IsMoving() As Boolean
            'Is the car's speed zero?
            If Speed = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        'CalculateAccelerationRate-assume a constant for a normal car
        Public Overridable Function CalculateAccelerationRate() As Double
            'If we assume a normal car goes from 0-60 in 14 seconds,
            'that's an average rate of 4.2 mph/s
            Return 4.2
        End Function

    End Class
End Namespace
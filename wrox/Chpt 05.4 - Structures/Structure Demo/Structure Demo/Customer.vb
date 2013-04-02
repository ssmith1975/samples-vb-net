Public Structure Customer
    'Public members
    Public FirstName As String
    Public LastNAme As String
    Public Email As String

    'Name property
    Public ReadOnly Property Name() As String
        Get
            Return FirstName & " " & LastNAme
        End Get
    End Property

  

    '" <summary>
    '" Overrides the default ToString method
    '" </summary>
    '" <returns>String</returns>
    '" <remarks>Returns the customer name and email
    '" address</remarks>

    Public Overrides Function ToString() As String
        Return Name & "(" & Email & ")"
    End Function
End Structure

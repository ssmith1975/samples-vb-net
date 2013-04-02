Public Class Computer
    Implements IDisposable

#Region "IDisposable Support"

    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects)
            'and override Finalize() below.
            ' TODO: set large fields to null.
        End If

        Me.disposedValue = True
    End Sub

    ' TODO: override Finalized() only if Dispose(ByVal disposing As
    ' Boolean) above has code to free unmanaged
    'Protected Overrides SubFinalize()
    '   ' Do not change this code. Put cleanup code in Dispose
    ' (ByVal disposing As Boolean) avoe.
    '   Dispose(False)
    '   MyBase.Finalize()
    'End Sub

    'This code added by Visual Basic to correctly implement the 
    'disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code
        'in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
    Public ReadOnly Property FreeMemory() As String
        Get
            'Using the My namespace
            Return Format(( _
                          My.Computer.Info.AvailablePhysicalMemory.ToString \ 1024), _
                      "#,###,##0") & " K"
        End Get
    End Property

    Public ReadOnly Property TotalMemory() As String
        Get
            'Using the My namespace
            Return Format(( _
                          My.Computer.Info.TotalPhysicalMemory.ToString \ 1024), _
                      "#,###,##0") & " K"
        End Get
    End Property
End Class

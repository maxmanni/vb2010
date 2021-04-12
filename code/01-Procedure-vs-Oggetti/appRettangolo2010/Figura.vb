Public Class Figura

    Public Params() As Single

    Public Sub New(ByVal ParamArray params() As Single)
        Me.Params = params
    End Sub

    Public Overridable Function IsValid() As Boolean
        For Each param As Single In Params
            If param <= 0 Then
                Return False
            End If
        Next
        Return True
    End Function
End Class

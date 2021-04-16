Public Class Rettangolo
    Inherits Figura

    Private Property b As Single
    Private Property h As Single

    Public Sub New(ByVal nome As String, ByVal b As Single, ByVal h As Single)
        MyBase.New(Nome)
        Me.b = b
        Me.h = h
    End Sub

    Public Overrides Function CalcolaPerimetro() As Single
        Return (b + h) * 2
    End Function
    Public Overrides Function CalcolaArea() As Single
        Return b * h
    End Function

    Public Function GetDiagonale() As Single
        Return Math.Sqrt(b * b + h * h)
    End Function

End Class

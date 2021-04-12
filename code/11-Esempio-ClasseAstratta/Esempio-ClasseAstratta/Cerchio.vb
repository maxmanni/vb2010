Public Class Cerchio
    Inherits Figura

    Private Property r As Single

    Public Sub New(ByVal nome As String, ByVal r As Single)
        MyBase.New(nome)
        Me.r = r
    End Sub

    Public Overrides Function CalcolaPerimetro() As Single
        Return 2 * Math.PI * r
    End Function
    Public Overrides Function CalcolaArea() As Single
        Return r * r * Math.PI
    End Function

End Class


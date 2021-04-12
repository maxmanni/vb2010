Public Class Triangolo
    Inherits Figura

    Public Property Lato1 As Integer
    Public Property Lato2 As Integer
    Public Property Lato3 As Integer

    Public Sub New(ByVal lato1 As Single, ByVal lato2 As Single, ByVal lato3 As Single)
        MyBase.new(lato1, lato2, lato3)
        Me.Lato1 = lato1
        Me.Lato2 = lato2
        Me.Lato3 = lato3
    End Sub

    Public Overrides Function IsValid() As Boolean
        Return MyBase.IsValid() And (Lato1 <= Lato2 + Lato3) And (Lato2 <= Lato1 + Lato3) And (Lato3 <= Lato1 + Lato2)
    End Function

    Public Function CalcolaArea() As Single
        Dim sp As Single
        sp = (Lato1 + Lato2 + Lato3) / 2
        Return Math.Sqrt(sp * (sp - Lato1) * (sp - Lato2) * (sp - Lato3))
    End Function

    Public Function CalcolaPerimetro() As Single
        Return Lato1 + Lato2 + Lato3
    End Function

    Public Function CalcolaPerimetro(ByVal x As String) As Single
        Return x
    End Function
End Class

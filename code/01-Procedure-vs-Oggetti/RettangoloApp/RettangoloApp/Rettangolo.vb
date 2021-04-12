Public Class Rettangolo
    Public Property Base As Integer
    Public Property Altezza As Integer

    Public Sub New(b As Integer, h As Integer)

        Base = b
        Altezza = h

    End Sub

    Public Function CalcolaArea() As Integer

        CalcolaArea = Base * Altezza

    End Function

    Public Function CalcolaPerimetro() As Integer

        CalcolaPerimetro = 2 * (Base + Altezza)

    End Function
End Class


Public Class Rettangolo
    Inherits Figura

    Public Property Base As Single
    Public Property Altezza As Single

    Public Sub New(ByVal b As Single, ByVal h As Single)
        MyBase.new(b, h)
        Base = b
        Altezza = h
    End Sub

    Public Function CalcolaArea() As Single
        Return Base * Altezza
    End Function

    Public Function CalcolaPerimetro() As Single
        Return 2 * (Base + Altezza)
    End Function

    Public Overrides Function ToString() As String
        Return "Rettangolo base = " + Str(Base) + " h = " + Str(Altezza)
    End Function
End Class


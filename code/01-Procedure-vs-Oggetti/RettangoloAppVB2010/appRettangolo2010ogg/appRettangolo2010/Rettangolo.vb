Public Class Rettangolo
    Public Property Base As Integer
    Public Property Altezza As Integer
    Private Property nome As String


    Public Sub New(ByVal b As Integer, ByVal h As Integer)
        nome = "ciao" + Now().ToString()
        Base = b
        Altezza = h

    End Sub

    Private Function CalcolaArea() As Integer

        Return Base * Altezza

    End Function

    Public Function CalcolaPerimetro() As Integer

        Return 2 * (Base + Altezza)

    End Function
End Class


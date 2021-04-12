Public Class PrismaConEredita
    Inherits PoligonoRegolare

    Public Property Altezza As Single

    Public Sub New(ByVal lato As Single, ByVal n As Integer, ByVal altezza As Single)
        MyBase.New(lato, n)
        Me.Altezza = altezza
    End Sub

    Public Function GetAreaLaterale() As Single
        Return GetPerimetro() * Altezza
    End Function

    Public Function GetAreaTotale() As Single
        Return GetAreaLaterale() + 2 * GetArea()
    End Function

    Public Function GetVolume() As Single
        Return GetArea() * Altezza
    End Function
End Class

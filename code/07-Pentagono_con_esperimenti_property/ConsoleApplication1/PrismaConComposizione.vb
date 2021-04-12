Public Class PrismaConComposizione

    Public Property Base As PoligonoRegolare
    Public Property Altezza As Single

    Public Sub New(ByVal lato As Single, ByVal n As Integer, ByVal altezza As Single)
        Me.Base = New PoligonoRegolare(lato, n)
        Me.Altezza = altezza
    End Sub

    Public Function GetAreaLaterale() As Single
        Return Base.GetPerimetro() * Altezza
    End Function

    Public Function GetAreaTotale() As Single
        Return GetAreaLaterale() + 2 * Base.GetArea()
    End Function

    Public Function GetVolume() As Single
        Return Base.GetArea() * Altezza
    End Function


    Public Overrides Function ToString() As String
        Return "prismaaaaaaaaaaaaa compo = " + Altezza.ToString()
    End Function
End Class

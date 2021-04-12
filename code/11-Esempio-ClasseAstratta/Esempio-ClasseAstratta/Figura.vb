Public MustInherit Class Figura 'classe astratte = classe con almeno un metodo astratto
    Public ReadOnly Nome As String
    Public MustOverride Function CalcolaPerimetro() As Single 'metodo astratto
    Public MustOverride Function CalcolaArea() As Single

    Public Sub New(ByVal nome As String)
        Me.Nome = nome
    End Sub

    Public Overrides Function ToString() As String
        Return "Figura nome = " + Nome
    End Function
End Class

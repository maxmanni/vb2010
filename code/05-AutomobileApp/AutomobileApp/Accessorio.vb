Public Class Accessorio
    Public Property Nome As String
    Public Property Prezzo As Decimal

    Public Sub New(ByVal nome As String, ByVal prezzo As String)
        Me.Nome = nome
        Me.Prezzo = prezzo
    End Sub
End Class

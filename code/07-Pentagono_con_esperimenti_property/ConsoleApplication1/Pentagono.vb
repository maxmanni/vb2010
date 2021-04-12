Public Class Pentagono
    Inherits PoligonoRegolare

    Public Property Colore As String

    Public Sub New(ByVal lato As Single, ByVal colore As String)
        MyBase.New(lato, 5)
        Me.Colore = colore
    End Sub

    Public Function metodoSoloDiPentagono() As String
        Return MyBase.sCompatta
    End Function

End Class

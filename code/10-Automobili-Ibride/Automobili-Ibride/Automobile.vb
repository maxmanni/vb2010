'Public MustInherit Class Automobile
Public Class Automobile

    Public ReadOnly Marca As String
    Public ReadOnly Modello As String

    'Public MustOverride Function PuoPartire() As Boolean

    Public Sub New(ByVal marca As String, ByVal modello As String)
        Me.Marca = marca
        Me.Modello = modello
    End Sub
End Class

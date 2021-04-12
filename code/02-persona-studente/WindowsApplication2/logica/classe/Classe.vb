Public Class Classe

    Public Property Corso As String
    Public Property Anno As Integer
    Public Property Sezione As String

    Public Sub New(ByVal corso As String, ByVal anno As Integer, ByVal sezione As String)
        Me.Corso = corso
        Me.Anno = anno
        Me.Sezione = sezione
    End Sub

    Public Overrides Function ToString() As String
        Return Corso + " " + Anno.ToString() + Sezione
    End Function
End Class

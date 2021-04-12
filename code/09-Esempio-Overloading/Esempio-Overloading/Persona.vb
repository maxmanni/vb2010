Public Class Persona
    Public Property Nome As String
    Public Property Cognome As String
    Public Property DataDiNascita As Date
    Public Property Bellezza As Integer

    Public Sub New(ByVal nome As String, ByVal cognome As String)
        Me.Nome = nome
        Me.Cognome = cognome
    End Sub

    Public Sub New(ByVal nome As String, ByVal cognome As String, ByVal bellezza As Integer)
        Me.new(nome, cognome)
        Me.Bellezza = bellezza
    End Sub

    Public Overrides Function ToString() As String
        Return Nome + " " + Cognome + " " + DataDiNascita.ToString() + " bellezza=" + Str(Bellezza)
    End Function
End Class

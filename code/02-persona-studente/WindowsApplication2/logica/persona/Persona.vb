Public Class Persona
    Public Property Nome As String
    Public Property Cognome As String
    Public Property DataDiNascita As Date

    Public Sub New(ByVal nome As String, ByVal cognome As String, ByVal dataDiNascita As Date)
        Me.Nome = nome
        Me.Cognome = cognome
        Me.DataDiNascita = dataDiNascita
    End Sub

    Public Overrides Function ToString() As String
        Return "Persona: " + Nome + " " + Cognome
    End Function

End Class

Public Class Studente
    Inherits Persona

    Public Sub New(ByVal nome As String, ByVal cognome As String, ByVal dataDiNascita As Date)
        MyBase.New(nome, cognome, dataDiNascita)
    End Sub

    Public Overrides Function ToString() As String
        Return "Studente: " + Nome + " " + Cognome
    End Function
End Class

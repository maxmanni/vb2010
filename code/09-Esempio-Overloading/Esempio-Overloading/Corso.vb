Public Class Corso
    Public ReadOnly NomeCorso As String
    Public ReadOnly Iscritti As List(Of Persona)

    Public Sub New(ByVal nomeCorso As String)
        Me.NomeCorso = nomeCorso
        Iscritti = New List(Of Persona)
    End Sub

    Public Sub AggiungiIscritto(ByVal nome As String, ByVal cognome As String)
        Dim p As New Persona(nome, cognome)
        Iscritti.Add(p)
    End Sub

    Public Sub AggiungiIscritto(ByVal cognome As String)
        AggiungiIscritto("[sconosciuto]", cognome)
    End Sub

    Public Sub AggiungiIscritto(ByVal p As Persona)
        Iscritti.Add(p)
    End Sub

    Public Sub AggiungiIscritto(ByVal nome As String, ByVal cognome As String, ByVal dataDiNascita As Date)
        Dim p As New Persona(nome, cognome)
        p.DataDiNascita = dataDiNascita
        Iscritti.Add(p)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String
        s = String.Empty
        For Each p As Persona In Iscritti
            s += p.ToString() + vbCrLf
        Next
        Return s
    End Function
End Class


Public Class CorsoPerPersoneBelle
    Inherits Corso
    Private Property LivelloMinBellezza

    Public Sub New(ByVal nomeCorso As String, ByVal livelloMinBellezza As Integer)
        MyBase.New(nomeCorso)
        Me.LivelloMinBellezza = livelloMinBellezza
    End Sub

    Public Overloads Sub AggiungiIscritto(ByVal p As Persona, ByVal bonusSimpatia As Integer)
        If (p.Bellezza + bonusSimpatia >= LivelloMinBellezza) Then
            Iscritti.Add(p)
            Debug.WriteLine(p.ToString() + " non sei bello ma simpatico, puoi entrare!!! ")
        End If
    End Sub

    Public Overloads Function AggiungiIscritto(ByVal nome As String, ByVal cognome As String, ByVal dataDiNascita As Date, ByVal bellezza As Integer) As Boolean
        If (bellezza >= LivelloMinBellezza) Then
            Dim p As New Persona(nome, cognome, bellezza)
            p.DataDiNascita = dataDiNascita
            Iscritti.Add(p)
            Return True
        End If
        Return False
    End Function

End Class

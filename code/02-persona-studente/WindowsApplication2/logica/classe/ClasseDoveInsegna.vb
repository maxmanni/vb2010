Public Class ClasseDoveInsegna
    Inherits Classe

    Public Property Studenti As List(Of Studente)
    Public Property Disciplina As Disciplina

    Public Property Ore As Integer
    Public Property Lezioni As List(Of String)

    Public Property DocenteDiLaboratorio As Docente
    Public Property HasLab As Boolean
    Public Property OreLab As Integer
    Public Property LezioniLab As List(Of String)

    Public Sub New(ByVal corso As String, ByVal anno As Integer, ByVal sezione As String, ByRef disciplina As Disciplina, ByVal ore As Integer)
        MyBase.New(corso, anno, sezione)
        Me.Disciplina = disciplina
        Me.Studenti = New List(Of Studente)
        Me.Lezioni = New List(Of String)
        Me.Ore = ore
    End Sub

    Public Sub AggiungiLezione(ByVal lezione As String)
        Me.Lezioni.Add(lezione)
    End Sub
    Public Sub AggiungiLezioneLab(ByVal lezione As String)
        Me.LezioniLab.Add(lezione)
    End Sub

    Public Sub AggiungiStudente(ByRef studente As Studente)
        Me.Studenti.Add(studente)
    End Sub

    Public Sub AggiungiLaboratorio(ByVal oreLab As Integer, ByRef docenteDiLaboratorio As Docente)
        Me.HasLab = True
        Me.OreLab = oreLab
        Me.DocenteDiLaboratorio = docenteDiLaboratorio
        LezioniLab = New List(Of String)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String
        s = "Corso: " + Corso + " " + Anno.ToString() + Sezione + " " + Disciplina.ToString() + " " + Ore.ToString() + " ore"
        If (HasLab) Then
            s += ", Lab: " + OreLab.ToString() + " ore, docente di lab.: " + DocenteDiLaboratorio.ToString()
        End If
        s += vbCrLf + "Elenco studenti:" + vbCrLf
        For Each studente In Me.Studenti
            s += studente.ToString() + vbCrLf
        Next
        Return s
    End Function
End Class

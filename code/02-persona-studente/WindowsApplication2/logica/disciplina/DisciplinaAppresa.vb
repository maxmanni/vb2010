Public Class DisciplinaAppresa
    Inherits Disciplina

    Public Property Docente As Docente

    Public Property Ore As Integer
    Public Property Lezioni As List(Of String)

    Public Property HaLab As Boolean
    Public Property OreLab As Integer
    Public Property DocenteLab As Docente
    Public Property LezioniLab As List(Of String)

    Public Sub New(ByVal nome As String, ByVal ore As Integer, ByRef docente As Docente)
        MyBase.New(nome)
        Me.Ore = ore
        Me.Docente = docente
    End Sub

    Public Sub ImpostaLaboratorio(ByVal oreLab As Integer, ByRef docenteLab As Docente)
        Me.OreLab = oreLab
        Me.HaLab = True
        Me.LezioniLab = New List(Of String)
        Me.DocenteLab = docenteLab
    End Sub

    Public Sub AggiungiLezione(ByVal lezione As String)
        Me.Lezioni.Add(lezione)
    End Sub

    Public Sub AggiungiLezioneLab(ByVal lezioneLab As String)
        Me.LezioniLab.Add(lezioneLab)
    End Sub

    Public Overrides Function ToString() As String
        Return Nome + " (Ore:" + Ore + ", ore lab: " + OreLab + ")"
    End Function
End Class

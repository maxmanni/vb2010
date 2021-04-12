Public Class ClasseFrequentata
    Inherits Classe

    Public Property Discipline As List(Of DisciplinaAppresa)

    Public Sub New(ByVal corso As String, ByVal anno As Integer, ByVal sezione As String)
        MyBase.New(corso, anno, sezione)
        Discipline = New List(Of DisciplinaAppresa)
    End Sub

    Public Sub AggiungiDisciplina(ByVal disciplinaAppresa As DisciplinaAppresa)
        Discipline.Add(disciplinaAppresa)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String
        s = MyBase.ToString()
        s += vbCrLf + "Elenco discipline:" + vbCrLf
        For Each d In Me.Discipline
            s += d.ToString() + vbCrLf
        Next
        Return s
    End Function
End Class

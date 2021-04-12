Public Class StudenteConClasse
    Inherits Studente

    Public Property ClasseFrequentata As ClasseFrequentata

    Public Sub New(ByVal nome As String, ByVal cognome As String, ByVal dataDiNascita As Date, ByRef classeFrequentata As ClasseFrequentata)
        MyBase.New(nome, cognome, dataDiNascita)
        Me.ClasseFrequentata = classeFrequentata
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() + " (" + ClasseFrequentata.ToString() + ")"
    End Function

End Class

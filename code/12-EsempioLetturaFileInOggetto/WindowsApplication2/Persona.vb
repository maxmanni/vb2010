Public Class Persona
    Private nome As String
    Private cognome As String
    Private colore As String
    Private anno As Integer
    Private animale As String

    Public Sub New(ByVal nome As String, ByVal cognome As String, ByVal colore As String, ByVal anno As Integer, ByVal animale As String)
        Me.nome = nome
        Me.cognome = cognome
        Me.colore = colore
        Me.anno = anno
        Me.animale = animale

    End Sub

    Public Overrides Function ToString() As String
        Return "nome = " + nome + vbCrLf + "cognome = " + cognome + vbCrLf + "colore = " + colore + vbCrLf + "anno = " + Str(anno) + vbCrLf + "animale = " + animale
    End Function


End Class

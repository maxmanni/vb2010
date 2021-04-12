Public Class Disciplina

    Public Property Nome As String

    Public Sub New(ByVal nome As String)
        Me.Nome = nome
    End Sub

    Public Overrides Function ToString() As String
        Return "Disciplina:" + Nome
    End Function
End Class

Public Class Persona
    Public Property Nome As String
    Public Property Cognome As String
    Private Property _eta As Integer
    Private Property _soprannome As String
    Public i As Integer

    Public Sub New(ByVal nome As String, ByVal cognome As String)
        Me.Nome = nome
        Me.Cognome = cognome
        Me._eta = 0
        Me._soprannome = String.Empty

        Dim v(1) As Integer
        v(0) = 3
        v(1) = 24
        v(2) = 124

        Dim m(1, 1) As Integer
        m(0, 0) = 1
        m(0, 1) = 2
        m(1, 0) = 3
        m(1, 1) = 4

        Dim carattere As Char
        carattere = "c"



    End Sub

    Public Function GetNomeCompleto() As String
        Return Nome + " " + Cognome
    End Function

    'override del metodo Object.ToString()
    Public Overrides Function ToString() As String
        Return """" + GetNomeCompleto() + """"
    End Function
End Class


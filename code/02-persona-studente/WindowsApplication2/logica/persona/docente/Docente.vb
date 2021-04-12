Public Class Docente
    Inherits Persona

    Public Property TitoloDiStudio As String
    Public Property Laureato As Boolean

    Private ReadOnly Property laureatoAsString As String
        Get
            If Laureato Then
                Return "laureato/a"
            Else
                Return "diplomato/a"
            End If
        End Get
    End Property

    Public Sub New(ByVal nome As String, ByVal cognome As String, ByVal dataDiNascita As Date, ByVal titoloDiStudio As String, ByVal laureato As Boolean)
        MyBase.New(nome, cognome, dataDiNascita)
        Me.TitoloDiStudio = titoloDiStudio
        Me.Laureato = laureato
    End Sub

    Public Overrides Function ToString() As String
        Return "Docente: " + Nome + " " + Cognome + ", " + laureatoAsString + " (" + TitoloDiStudio + ")"
    End Function
End Class

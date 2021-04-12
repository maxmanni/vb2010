Public Class DocenteConClassi
    Inherits Docente

    Public Property Classi As List(Of ClasseDoveInsegna)

    Public Sub New(ByVal nome As String, ByVal cognome As String, ByVal dataDiNascita As Date, ByVal titoloDiStudio As String, ByVal laureato As Boolean)
        MyBase.New(nome, cognome, dataDiNascita, titoloDiStudio, laureato)
        Classi = New List(Of ClasseDoveInsegna)
    End Sub

    Public Sub AggiungiClasse(ByVal classe As ClasseDoveInsegna)
        Me.Classi.Add(classe)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String
        s = MyBase.ToString()
        If (Classi.Count > 0) Then
            s += vbCrLf + "Elenco classi in cui il docente insegna: " + vbCrLf
            For Each c In Classi
                s += c.ToString() + vbCrLf
            Next
        End If
        Return s
    End Function
End Class

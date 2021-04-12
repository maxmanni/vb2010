Public Class Spezzata
   
    Protected _punti As List(Of Punto)

    Public Sub New()
        _punti = New List(Of Punto)
    End Sub

    Public Sub AggiungiPunto(ByVal p As Punto)
        _punti.Add(p)
    End Sub

    Public Overridable Sub Disegna(ByVal g As System.Drawing.Graphics, ByVal c As MieiColori)
        For i = 0 To _punti.Count - 1
            Dim puntoCorrente As Punto
            puntoCorrente = _punti(i)
            puntoCorrente.Disegna(g, c)
            If i > 0 Then
                Dim puntoPrecedente As Punto
                puntoPrecedente = _punti(i - 1)
                Dim linea As New Linea(puntoPrecedente, puntoCorrente)
                linea.Disegna(g, c)
            End If
        Next
    End Sub
End Class

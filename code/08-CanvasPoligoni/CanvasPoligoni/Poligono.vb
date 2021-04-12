Public Class Poligono
    Inherits Spezzata

    Public Overrides Sub Disegna(ByVal g As System.Drawing.Graphics, ByVal c As MieiColori)
        MyBase.Disegna(g, c)
        Dim n As Integer
        n = _punti.Count
        If n > 1 Then
            Dim pIniziale = _punti(0)
            Dim pFinale = _punti(n - 1)
            Dim lineaDiChiusura = New Linea(pIniziale, pFinale)
            lineaDiChiusura.Disegna(g, c)
        End If
    End Sub
End Class

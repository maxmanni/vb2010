'
'Questo è come un vettore di interi: 0, 1, 2, 3
Public Enum MieiColori
    Nero '0
    Blu '1
    Rosso '2
    Verde '3
End Enum


'Esempio di utilizzo: (questa classe non va inclusa nei diagrammi è solo un esempio)
Public Class A
    Dim c As MieiColori 'equivale a dichiarare un intero
    Dim c2 As Integer
    Dim ss() As String = {"Black", "Blue", "Red", "Green"}

    Public Sub New()
        c = MieiColori.Rosso 'anche c in realtà equivale a un intero di valore 2
        c2 = 2
        Dim s, s2 As String
        s = ss(c)
        s2 = ss(c2)
        Debug.WriteLine(s + "-" + s2) 'questo stampa Red-Red
    End Sub
End Class
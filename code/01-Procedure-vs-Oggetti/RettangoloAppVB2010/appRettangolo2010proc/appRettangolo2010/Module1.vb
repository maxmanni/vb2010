Module Module1

    Sub Main()

        Dim base, altezza As Integer
        base = 5
        altezza = 2

        Dim perimetro, area As Integer

        perimetro = CalcolaPerimetro(base, altezza)
        Console.WriteLine("perimetro = " + perimetro.ToString())

        area = CalcolaArea(base, altezza)
        Console.WriteLine("area = " + area.ToString())

        Console.WriteLine("base = " + base.ToString())

        Console.WriteLine("Premi un tasto per continuare")
        Console.ReadKey()


    End Sub

    Private Function CalcolaPerimetro(ByVal b As Integer, ByVal h As Integer) As Integer

        Return 2 * (b + h)

    End Function

    Private Function CalcolaArea(ByRef b As Integer, ByVal h As Integer) As Integer
        b = 100
        Return b * h
    End Function

End Module

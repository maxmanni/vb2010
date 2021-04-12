Imports System

Module Program

    Sub Main(args As String())

        Dim base, altezza As Integer
        base = 5
        altezza = 2

        Dim perimetro, area As Integer

        perimetro = CalcolaPerimetro(base, altezza)
        Console.WriteLine("perimetro = " + perimetro.ToString())

        area = CalcolaArea(base, altezza)
        Console.WriteLine("area = " + area.ToString())

        Console.WriteLine("Premi un tasto per continuare")
        Console.ReadKey()


    End Sub

    Private Function CalcolaPerimetro(b As Integer, h As Integer) As Integer
        CalcolaPerimetro = 2 * (b + h)

    End Function

    Private Function CalcolaArea(b As Integer, h As Integer) As Integer
        CalcolaArea = b * h
    End Function
End Module

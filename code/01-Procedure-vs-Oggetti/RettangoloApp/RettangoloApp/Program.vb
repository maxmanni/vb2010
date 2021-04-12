Imports System

Module Program
    Sub Main(args As String())
        Dim rett As Rettangolo
        rett = New Rettangolo(7, 3)
        Dim area, perimetro As Integer

        perimetro = rett.CalcolaPerimetro()
        Console.WriteLine("perimetro = " + perimetro.ToString())

        area = rett.CalcolaArea()
        Console.WriteLine("area = " + area.ToString())

        Console.WriteLine("Premi un tasto per continuare")
        Console.ReadKey()
    End Sub
End Module

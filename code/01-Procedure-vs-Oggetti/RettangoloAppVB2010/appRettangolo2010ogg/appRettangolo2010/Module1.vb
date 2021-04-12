Module Module1

    Sub Main()
        Dim rett As Rettangolo
        rett = New Rettangolo(7, 3)
        Dim area, perimetro As Integer

        Console.WriteLine("base = " + rett.Base.ToString())

        perimetro = rett.CalcolaPerimetro()
        Console.WriteLine("perimetro = " + perimetro.ToString())

        area = rett.CalcolaArea()
        Console.WriteLine("area = " + area.ToString())

        Console.WriteLine("Premi un tasto per continuare")
        Console.ReadKey()
    End Sub

End Module

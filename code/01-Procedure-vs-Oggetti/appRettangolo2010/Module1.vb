Module Module1

    Sub Main()

        Dim figure(0 To 1) As Figura

        Dim rett As Rettangolo
        rett = New Rettangolo(7, 4)
        figure(0) = rett
        Console.WriteLine("Rettangolo (b={0} h={1}): perimetro={2}, area={3} ", rett.Base, rett.Altezza, rett.CalcolaPerimetro(), rett.CalcolaArea())

        Dim tri As Triangolo
        tri = New Triangolo(3, 4, 50)
        figure(1) = tri
        If (tri.IsValid()) Then
            Console.WriteLine("Triangolo (lati={0} {1} {2}): perimetro={3}, area={4} ", tri.Lato1, tri.Lato2, tri.Lato3, tri.CalcolaPerimetro(), tri.CalcolaArea())
        Else
            Console.WriteLine("Triangolo impossibile!!!")
        End If

        For Each f In figure
            Console.WriteLine("f is " & f.GetType().FullName & " and isValid = " & f.IsValid())
        Next

        Console.WriteLine("Premi un tasto per continuare")
        Console.ReadKey()

    End Sub

End Module

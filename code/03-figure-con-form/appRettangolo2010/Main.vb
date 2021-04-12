Module Main

    Sub Main()

        'Dim form As Form1
        'form = New Form1()
        'form.Show()


        Dim figure(0 To 1) As Figura

        Dim rett As Rettangolo
        rett = New Rettangolo(7, -4)
        rett.Altezza = 3
        figure(0) = rett
        Console.WriteLine("Rettangolo (b={0} h={1}): perimetro={2}, area={3}", rett.Base, rett.Altezza, rett.Perimetro, rett.Area)

        Dim tri As Triangolo
        'tri = New Triangolo(3, 4, 5)
        tri = New Triangolo(1, 1, 1)
        figure(1) = tri
        If (tri.IsValid()) Then
            Console.WriteLine("Triangolo (lati={0} {1} {2}): perimetro={3}, area={4} ", tri.Lato1, tri.Lato2, tri.Lato3, tri.Perimetro, tri.Area)
        Else
            Console.WriteLine("Triangolo impossibile!!!")
        End If

        For Each f In figure
            Console.WriteLine("f is " & f.GetType().FullName & " and isValid (static) = " & f.IsValid())
            If TypeOf (f) Is Triangolo Then
                Dim t As Triangolo
                t = f
                Console.WriteLine("t isValid (dynamic) = " & t.IsValid())
            End If
            If TypeOf (f) Is Rettangolo Then
                Dim r As Rettangolo
                r = f
                Console.WriteLine("r isValid (dynamic) = " & r.IsValid())
            End If
        Next

        Console.WriteLine("Premi un tasto per continuare")
        Dim s As String
        s = Console.ReadLine()
        Console.WriteLine(s)


        Console.ReadKey()


    End Sub

End Module

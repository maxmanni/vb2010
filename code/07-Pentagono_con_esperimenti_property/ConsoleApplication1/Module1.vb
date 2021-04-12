Module Module1
    Sub main()
        Dim pent As New Pentagono(21.53, "giallo")

        Dim valore As String
        valore = pent.valore
        pent.valore = "asdasd"

        Dim comp As String
        comp = pent.sCompatta

        Dim est As String
        est = pent.sEstesa

        pent.sCompatta = "c"

        pent.sEstesa = "e"

        pent.stringaFuoriCheEUnNumeroDentro = "64"
        pent.CalcolaRadice()
        Dim valStringa As String
        valStringa = pent.stringaFuoriCheEUnNumeroDentro
        Debug.WriteLine("valStringa= " + valStringa)

        Dim valoreCheNonHaUnSensoLogico As Single
        valoreCheNonHaUnSensoLogico = pent.metodoSoloDiPentagono()
        Debug.WriteLine("valoreCheNonHaUnSensoLogico= " + Str(valoreCheNonHaUnSensoLogico))
        Dim p, a As Single

        Debug.WriteLine("PENTAGONO")
        Debug.WriteLine("lato = " + pent.Lato.ToString() + " cm")
        p = pent.GetPerimetro() / 100
        a = pent.GetPerimetro() / (100 * 100)
        Debug.WriteLine("perimetro p = " + p.ToString() + " m")
        Debug.WriteLine("area a = " + a.ToString() + " m2")

        Debug.WriteLine("PRISMA")
        Dim prisma As New PrismaConComposizione(21.53, 5, 10)
        Dim s, v As Single
        s = prisma.GetAreaTotale() / (100 * 100)
        v = prisma.GetVolume() / (100 * 100 * 100)
        Debug.WriteLine("superficie s = " + s.ToString() + " m2")
        Debug.WriteLine("volume v = " + v.ToString() + " m3")


        Debug.WriteLine("VETTORE DI PRISMI")
        Const n As Integer = 100
        Dim vett(0 To n - 1) As PrismaConComposizione
        Dim sm, vm As Single

        sm = 0
        vm = 0
        For i = 0 To n - 1
            vett(i) = New PrismaConComposizione(i + 1, 5, 10) 'lato i e altezza 10 in cm
            sm += vett(i).GetAreaTotale() / (100 * 100) 'superficie in m2
            vm += vett(i).GetVolume() / (100 * 100 * 100) 'volume in m3
        Next

        sm = sm / n
        vm = vm / n

        Debug.WriteLine("superficie media s = " + sm.ToString() + " m2")
        Debug.WriteLine("volume medio v = " + vm.ToString() + " m3")
        Debug.WriteLine(String.Format("vett(0) = {0} {1}", vett(0), sm))
        Console.ReadKey()
    End Sub
End Module

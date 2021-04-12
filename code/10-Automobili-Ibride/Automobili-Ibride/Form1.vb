Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Debug.WriteLine("Creo una macchina elettrica")
        Dim benz As New AutoConMotoreAScoppio("Ford", "Fiesta", Combustibile.Benzina, 40)
        Debug.WriteLine("Prima: carburante = " + Str(benz.QuantitàAttualeCombustibile) + " può partire  = " + Str(benz.PuoPartire()))
        benz.AggiungiCombustibile(30)
        Debug.WriteLine("Dopo: carburante = " + Str(benz.QuantitàAttualeCombustibile) + " può partire  = " + Str(benz.PuoPartire()))

        Dim ele As New AutoElettrica("Ford", "FiestaElettrica", 100)
        Debug.WriteLine("Prima: batteria = " + Str(ele.CaricaAttualeBatteria) + " può partire  = " + Str(ele.PuoPartire()))
        ele.CaricaBatteria(90)
        Debug.WriteLine("Dopo: batteria = " + Str(ele.CaricaAttualeBatteria) + " può partire  = " + Str(ele.PuoPartire()))

        'TODO: mostrare ai ragazzi come fare a poter fare questo (far diventare automobile una classe astratta)
        'Dim a(0 To 1) As Automobile
        'a(0) = benz
        'a(1) = ele

        'Dim i As Integer
        'For i = 0 To a.Length - 1
        '    a(0).PuoPartire()
        'Next

    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clima As New Accessorio("Clima", 200)
        Dim sediliPelle As New Accessorio("SediliPelle", 299)
        Dim volantePeloso As New Accessorio("VolantePeloso", 1)

        Dim fiesta As New Auto("Ford", "Fiesta", 11000)

        fiesta.AggiungiAccessorio(clima)
        fiesta.AggiungiAccessorio(sediliPelle)
        fiesta.AggiungiAccessorio(volantePeloso)

        Debug.WriteLine("prezzo fiesta base: " + fiesta.Prezzo.ToString())
        Debug.WriteLine("prezzo fiesta con accessori (" + String.Join(",", fiesta.GetElencoAccessori()) + "): " + fiesta.GetPrezzoTotale().ToString())

        Dim panda As New Auto("Fiat", "Panda", 9000)
        panda.AggiungiAccessorio(clima)

        Debug.WriteLine("prezzo fiesta base: " + panda.Prezzo.ToString())
        Debug.WriteLine("prezzo fiesta con accessori (" + String.Join(",", panda.GetElencoAccessori()) + "): " + panda.GetPrezzoTotale().ToString())

        If (panda.ConfrontaPrezzoTotale(fiesta) > 0) Then
            Debug.WriteLine("Costa di più la panda")
        Else
            Debug.WriteLine("Costa di più la fiesta")
        End If

    End Sub
End Class

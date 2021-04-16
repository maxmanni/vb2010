Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim figure(1) As Figura

        figure(0) = New Cerchio("cerchio1", 1)
        figure(1) = New Rettangolo("rett2x3", 2, 3)


        Dim i As Integer

        For i = 0 To figure.Length - 1
            Dim f As Figura
            f = figure(i)
            Debug.WriteLine(f.Nome + " perimetro = " + Str(f.CalcolaPerimetro()) + " area =" + Str(f.CalcolaArea()))
            If f.GetType() Is GetType(Cerchio) Then
                Dim c As Cerchio
                c = f
                Debug.WriteLine(" diametro =" + Str(c.GetDiametro()))
            ElseIf f.GetType() Is GetType(Rettangolo) Then
                Dim r As Rettangolo
                r = f
                Debug.WriteLine(" diagonale =" + Str(r.GetDiagonale()))

            End If
        Next


    End Sub
End Class

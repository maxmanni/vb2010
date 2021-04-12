Public Class Form1

    Dim OriginOffset As Size
    Dim Scaling As Integer = 1

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim mousePos As Point
        mousePos = New Point((e.Location.X - OriginOffset.Width) \ Scaling, (OriginOffset.Height - e.Location.Y) \ Scaling)
        Me.Text = " mousePos=" + mousePos.ToString() + " ClientRectangle=" + ClientRectangle.ToString()
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Debug.WriteLine("Form1_Paint")
        e.Graphics.TranslateTransform(OriginOffset.Width, OriginOffset.Height) 'posizione della nuova origine degli assi
        e.Graphics.ScaleTransform(Scaling, -Scaling) 'inverto la direzione dell'asse y

        'disegno gli assi con il nuovo sistema di coordinate
        e.Graphics.DrawLine(Pens.Black, New Point(-OriginOffset.Width, 0), New Point(OriginOffset.Width, 0))
        e.Graphics.DrawLine(Pens.Black, New Point(0, -OriginOffset.Height), New Point(0, OriginOffset.Height))
        e.Graphics.DrawString("0", SystemFonts.DefaultFont, Brushes.Black, New Point(0, 0))

        'disegno una funzione
        Dim ss = 1
        For x = -OriginOffset.Width To OriginOffset.Width Step ss
            'e.Graphics.DrawLine(Pens.Blue, New Point(x, f(x)), New Point(x + 1, f(x + 1)))
            Dim linea As New Linea(x, f(x), x + ss, f(x + ss))
            linea.Disegna(e.Graphics, MieiColori.Blu)
        Next

        'disegno di una spezzata
        Dim oggettoDaDisegnare As New Poligono() 'Poligono()
        oggettoDaDisegnare.AggiungiPunto(New Punto(10, 10))
        oggettoDaDisegnare.AggiungiPunto(New Punto(20, 40))
        oggettoDaDisegnare.AggiungiPunto(New Punto(-10, 100))
        oggettoDaDisegnare.AggiungiPunto(New Punto(-100, -70))
        oggettoDaDisegnare.Disegna(e.Graphics, MieiColori.Verde)


        Timer2.Enabled = False

        'sdasdasd
        Dim p As New Punto(0, 4)
        p.Prova = 2
        Dim s As Single
        s = p.Prova

        '
        Debug.WriteLine("angolo = " + Str(p.AngoloInGradi))
        p.AngoloInGradi = 270
        Debug.WriteLine("x = " + Str(p.X))
        Debug.WriteLine("x = " + Str(p.Y))
    End Sub

    Private Function f(ByVal x As Integer) As Integer
        'Return 2 * x + 4
        Return 50 * Math.Sin(x / 100)

    End Function

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        OriginOffset = New Size(ClientRectangle.Width / 2, ClientRectangle.Height / 2)
        Invalidate() 'ogni volta che ridimensiono la finestra, ridisegno --> chiama Paint()
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        OriginOffset = New Size(ClientRectangle.Width / 2, ClientRectangle.Height / 2)
        Debug.WriteLine("Shown")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = "asdfasfa"
        Debug.WriteLine("Load")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'viene chiamata ogni scatta il timer
        Debug.WriteLine("Timer1_Tick")
    End Sub
    Private Sub ciao(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'viene chiamata ogni scatta il timer
        Debug.WriteLine("ciaoasdasd")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As A
        a = New A()
    End Sub
End Class

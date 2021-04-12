Public Class Punto 'punto con coordinate decimali
    Private _x As Single
    Private _y As Single

    Private _r As Single
    Private _angolo As Single

    Private Pennelli() As System.Drawing.Brush = {Brushes.Black, Brushes.Blue, Brushes.Red, Brushes.DarkSeaGreen}

    Public Sub New()
    End Sub

    Public Sub New(ByVal x As Single, ByVal y As Single)
        _x = x
        _y = y
        _calcolaRaggioEAngolo()

    End Sub

    'Quando si fa overloading di metodi (e quindi anche per i costruttori) è necessario
    'che differiscano per numero e/o tipo di parametri
    'Public Sub New (Byval r as Single, Byval angolo as Single) 
    '_r = r
    '_angolo = angolo
    '_calcolaXY ()
    'End Sub

    Public Sub ImpostaRaggioEAngolo(ByVal r As Single, ByVal angolo As Single)
        _r = r
        _angolo = angolo
        _calcolaXY()
    End Sub


    Private _prova As Single
    'Public Property Prova As Single
    Public Property Prova() As Single
        Get
            Return _prova
        End Get
        Set(ByVal value As Single)
            _prova = value
        End Set
    End Property

    Public Property X() As Single
        Get
            Return _x
        End Get
        Set(ByVal value As Single)
            _x = value
            _calcolaRaggioEAngolo()
        End Set
    End Property

    Public Property Y() As Single
        Get
            Return _y
        End Get
        Set(ByVal value As Single)
            _y = value
            _calcolaRaggioEAngolo()
        End Set
    End Property


    Public Property R() As Single
        Get
            Return _r
        End Get
        Set(ByVal value As Single)
            _r = value
            _calcolaXY()
        End Set
    End Property

    Public Property Angolo() As Single 'in radianti
        Get
            Return _angolo
        End Get
        Set(ByVal value As Single)
            _angolo = value
            _calcolaXY()
        End Set
    End Property

    'rad:grad = pi:180
    Public Property AngoloInGradi() As Single 'in gradi
        Get
            Return _angolo * 180 / Math.PI
        End Get
        Set(ByVal value As Single)
            _angolo = value * Math.PI / 180
            _calcolaXY()
        End Set
    End Property

    Private Sub _calcolaRaggioEAngolo()
        _r = Math.Sqrt(_x ^ 2 + _y ^ 2)
        _angolo = Math.Atan(_y / _x)
    End Sub

    Private Sub _calcolaXY()
        _x = _r * Math.Cos(_angolo)
        _y = _r * Math.Sin(_angolo)
    End Sub

    Public Sub Disegna(ByVal g As System.Drawing.Graphics, ByVal c As MieiColori)
        Dim pennello As System.Drawing.Brush
        pennello = Pennelli(c)
        Dim r As Integer = 5
        Dim rect As New RectangleF(_x - r / 2, _y - r / 2, r, r)
        g.FillEllipse(pennello, rect)
    End Sub
End Class


Public Class Rettangolo
    Inherits Figura

    '---------------------------------------
    'proprietà
    '---------------------------------------
    Public Property Base() As Double
        Get
            Return Parametri(0)
        End Get
        Set(ByVal value As Double)
            Parametri(0) = value
        End Set
    End Property
    Public Property Altezza() As Double
        Get
            Return Parametri(1)
        End Get
        Set(ByVal value As Double)
            Parametri(1) = value
        End Set
    End Property


    'Public Function CalcolaPerimetro() As Double
    '    Return 2 * (Base + Altezza)
    'End Function
    Public ReadOnly Property Perimetro() As Double
        Get
            Return 2 * (Base + Altezza)
        End Get
    End Property

    'Public Function CalcolaArea() As Double
    '    Return Base * Altezza
    'End Function
    Public ReadOnly Property Area() As Double
        Get
            Return Base * Altezza
        End Get
    End Property


    '---------------------------------------
    'costruttori
    '---------------------------------------
    Public Sub New(ByVal b As Double, ByVal h As Double)
        MyBase.new(b, h)
        Base = b
        Altezza = h
    End Sub

    Public Sub New()
        Me.new(1, 1)
    End Sub

End Class

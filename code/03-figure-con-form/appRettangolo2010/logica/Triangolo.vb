Public Class Triangolo
    Inherits Figura

    '---------------------------------------
    'proprietà
    '---------------------------------------
    Public Property Lato1() As Double
        Get
            Return Parametri(0)
        End Get
        Set(ByVal value As Double)
            Parametri(0) = value
        End Set
    End Property
    Public Property Lato2() As Double
        Get
            Return Parametri(1)
        End Get
        Set(ByVal value As Double)
            Parametri(1) = value
        End Set
    End Property
    Public Property Lato3() As Double
        Get
            Return Parametri(2)
        End Get
        Set(ByVal value As Double)
            Parametri(2) = value
        End Set
    End Property

    Public Overrides ReadOnly Property IsValid() As Boolean
        Get
            Return MyBase.IsValid And (Lato1 <= Lato2 + Lato3) And (Lato2 <= Lato1 + Lato3) And (Lato3 <= Lato1 + Lato2)
        End Get
    End Property

    'Public Function CalcolaPerimetro() As Double
    '    Return Lato1 + Lato2 + Lato3
    'End Function
    Public ReadOnly Property Perimetro() As Double
        Get
            Return Lato1 + Lato2 + Lato3
        End Get
    End Property

    'Public Function CalcolaArea() As Double
    '    Dim sp As Double
    '    sp = CalcolaPerimetro() / 2
    '    Return Math.Sqrt(sp * (sp - Lato1) * (sp - Lato2) * (sp - Lato3))
    'End Function
    Public ReadOnly Property Area() As Double
        Get
            Dim sp As Double
            sp = Perimetro / 2
            Return Math.Sqrt(sp * (sp - Lato1) * (sp - Lato2) * (sp - Lato3))
        End Get
    End Property


    '---------------------------------------
    'costruttori
    '---------------------------------------
    Public Sub New(ByVal lato1 As Double, ByVal lato2 As Double, ByVal lato3 As Double)
        MyBase.new(lato1, lato2, lato3)
    End Sub

    Public Sub New()
        Me.new(1, 1, 1)
    End Sub


End Class

Public Class PoligonoRegolare

    Public Property Lato As Single
    Public Property N As Integer

    Public valore As String

    Public Property sCompatta As String

    Private _ss As String
    Public Property sEstesa() As String
        Get
            Return _ss
        End Get
        Set(ByVal value As String)
            _ss = value
        End Set
    End Property

    Private _numero As Single
    Public Property stringaFuoriCheEUnNumeroDentro() As String
        Get
            Return Convert.ToString(_numero)
        End Get
        Set(ByVal value As String)
            _numero = Convert.ToSingle(value)
        End Set
    End Property

    Public Sub CalcolaRadice()
        _numero = Math.Sqrt(_numero)
    End Sub


    Private ReadOnly numeriFissi() As Single = {0.289, 0.5, 0.688, 0.866, 1.038, 1.207, 1.374, 1.539}

    Private ReadOnly Property apotema() As Single
        Get
            Return Lato * numeriFissi(N - 3)
        End Get
    End Property

    Public Sub New(ByVal lato As Single, ByVal n As Integer)
        Me.N = n
        Me.Lato = lato
    End Sub

    Public Function GetPerimetro() As Single
        Return N * Lato
    End Function

    Public Function GetArea() As Single
        Return GetPerimetro() * apotema / 2
    End Function
End Class

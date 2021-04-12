Public Enum Combustibile
    Benzina
    Diesel
    Metano
End Enum

Public Class AutoConMotoreAScoppio
    Inherits Automobile

    Public ReadOnly TipoCombustibile As Combustibile
    Public Property CapacitaSerbatoio As Single

    Private _quantitàAttualeCombustibile As Single
    'TODO: aggiungere proprietà pubblica per mostrare all'esterno (sola lettura) il valore di _quantitàAttualeCombustibile
    Public ReadOnly Property QuantitàAttualeCombustibile As Single
        Get
            Return _quantitàAttualeCombustibile
        End Get
    End Property


    Public Sub New(ByVal modello As String, ByVal marca As String, ByVal tipoCombustibile As Combustibile, ByVal capacitaSerbatoio As Single)
        MyBase.New(modello, marca)
        Me.TipoCombustibile = tipoCombustibile
        Me.CapacitaSerbatoio = capacitaSerbatoio
    End Sub

    Public Sub AggiungiCombustibile() 'fai il pieno
        _quantitàAttualeCombustibile = CapacitaSerbatoio
    End Sub

    Public Sub AggiungiCombustibile(ByVal quantita As Single) 'aggiungi un po' di combustibile
        _quantitàAttualeCombustibile += quantita
        If (_quantitàAttualeCombustibile > CapacitaSerbatoio) Then
            _quantitàAttualeCombustibile = CapacitaSerbatoio
        End If
    End Sub

    'Public Overrides Function PuoPartire() As Boolean
    Public Function PuoPartire() As Boolean
        Return (_quantitàAttualeCombustibile > 0)
    End Function

    'TODO: aggiungere metodo ToString()
End Class

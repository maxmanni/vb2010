Public Class AutoElettrica
    Inherits Automobile

    Public ReadOnly CapacitaBatteria As Single

    Private _caricaAttualeBatteria As Single
    Public ReadOnly Property CaricaAttualeBatteria As Single
        Get
            Return _caricaAttualeBatteria
        End Get
    End Property

    Public Sub New(ByVal modello As String, ByVal marca As String, ByVal capacitaSerbatoio As Single)
        MyBase.New(modello, marca)
        Me.CapacitaBatteria = capacitaSerbatoio
    End Sub

    Public Sub CaricaBatteria() 'carica la batteria al 100%
        _caricaAttualeBatteria = CapacitaBatteria
    End Sub

    Public Sub CaricaBatteria(ByVal quantita As Single) 'carica un po' la batteria
        _caricaAttualeBatteria += quantita
        If (_caricaAttualeBatteria > CapacitaBatteria) Then
            _caricaAttualeBatteria = CapacitaBatteria
        End If
    End Sub

    'Public Overrides Function PuoPartire() As Boolean
    Public Function PuoPartire() As Boolean
        Return (_caricaAttualeBatteria > 0)
    End Function

    'TODO: aggiungere metodo ToString()
End Class


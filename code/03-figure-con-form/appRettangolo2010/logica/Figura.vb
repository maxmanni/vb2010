Public Class Figura
    '---------------------------------------
    'proprietà
    '---------------------------------------
    Public Property Parametri As List(Of Double)

    Public Overridable ReadOnly Property IsValid() As Boolean
        Get
            If Parametri Is Nothing Then
                Return False
            End If
            For Each param As Double In Parametri
                If param <= 0 Then
                    Return False
                End If
            Next
            Return True
        End Get
    End Property

    '---------------------------------------
    'costruttori
    '---------------------------------------
    Public Sub New(ByVal ParamArray parametri() As Double)
        Me.Parametri = parametri.ToList()
    End Sub


    '---------------------------------------
    'metodi
    '---------------------------------------
    Public Overrides Function ToString() As String
        Dim s As String
        Dim i As Integer
        s = Me.GetType().Name + " ("
        i = 1
        For Each param As Double In Parametri
            If i > 1 Then
                s += "; "
            End If
            s += String.Format("{0}", param.ToString())
            i += 1
        Next
        s += ")"
        Return s
    End Function
End Class

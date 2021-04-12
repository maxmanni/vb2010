Public Class Auto
    Public Property Marca As String
    Public Property Modello As String
    Public Property Prezzo As Decimal

    Public accessori(5) As Accessorio

    'Public accessori As List(Of Accessorio)


    Private nAcc As Integer

    Public Sub New(ByVal marca As String, ByVal modello As String, ByVal prezzo As Decimal)
        Me.Marca = marca
        Me.Modello = modello
        Me.Prezzo = prezzo
        'accessori = New List(Of Accessorio)
    End Sub

    Public Sub AggiungiAccessorio(ByVal a As Accessorio)
        If nAcc <= 5 Then
            accessori(nAcc) = a
            '
            'accessori.Add(a)
            nAcc += 1
        End If
    End Sub

    Public Function GetElencoAccessori() As String()
        Dim elencoNomi(nAcc) As String
        Dim i As Integer
        For i = 0 To nAcc - 1
            elencoNomi(i) = accessori(i).Nome
        Next
        Return elencoNomi
    End Function

    Public Function GetPrezzoTotale() As Decimal
        Dim tot As Decimal
        Dim i As Integer
        tot = Prezzo
        For i = 0 To nAcc - 1
            tot += accessori(i).Prezzo
        Next
        Return tot
    End Function

    Public Function ConfrontaPrezzoTotale(ByVal altraAuto As Auto) As Decimal
        Return Me.GetPrezzoTotale() - altraAuto.GetPrezzoTotale()
    End Function
End Class

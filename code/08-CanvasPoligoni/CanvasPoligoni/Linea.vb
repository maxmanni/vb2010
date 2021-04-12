Public Class Linea
    Public ReadOnly StartPoint As Point 'punto con coordinate intere
    Public ReadOnly EndPoint As Point 'punto con coordinate intere

    Private Penne() As System.Drawing.Pen = {Pens.Black, Pens.Blue, Pens.Red, Pens.DarkSeaGreen}

    Public Sub New(ByVal xStart As Integer, ByVal yStart As Integer, ByVal xEnd As Integer, ByVal yEnd As Integer)
        StartPoint = New Point(xStart, yStart)
        EndPoint = New Point(xEnd, yEnd)
    End Sub

    Public Sub New(ByVal pStart As Punto, ByVal pEnd As Punto)
        StartPoint = New Point(pStart.X, pStart.Y)
        EndPoint = New Point(pEnd.X, pEnd.Y)
    End Sub


    Public Sub Disegna(ByVal g As System.Drawing.Graphics, ByVal c As MieiColori)
        Dim penna As System.Drawing.Pen
        penna = Penne(c)
        g.DrawLine(penna, StartPoint, EndPoint)
    End Sub
End Class

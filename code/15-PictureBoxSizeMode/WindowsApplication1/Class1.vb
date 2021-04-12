Public Class DataDiNascita
    Public data As Date

    Public Function confronta(ByVal d As DataDiNascita) As Integer
        Return data.CompareTo(d.data)
    End Function

End Class

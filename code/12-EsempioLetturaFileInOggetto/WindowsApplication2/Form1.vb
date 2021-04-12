Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lines As String()
        lines = File.ReadAllLines("D:\Data\max\insegnamento\saraceno-romegialli\CartelleCondivise\classi\SIA-4A\Lezioni\29\EsempioLetturaFileInOggetto\WindowsApplication2\bin\Debug\prova.txt")

        Dim i As Integer
        For i = 0 To lines.Length - 1
            'Debug.WriteLine(lines(i))

            Dim record As String()
            record = lines(i).Split(",")

            Dim p As New Persona(record(0), record(1), record(2), Convert.ToInt32(record(3)), record(4))
            

            MsgBox(p.ToString())

        Next



    End Sub
End Class

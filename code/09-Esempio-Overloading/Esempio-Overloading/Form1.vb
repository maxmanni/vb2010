Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim corso As New Corso("Matematica")

        Dim cognome As String
        cognome = InputBox("inserisci cognome")
        corso.AggiungiIscritto(cognome)
        corso.AggiungiIscritto(New Persona("Mario", "Rossi"))
        corso.AggiungiIscritto("Luigi", "Verdi")
        corso.AggiungiIscritto("Carla", "Bianchi", "09/11/1970")
        Debug.WriteLine(corso)

        Dim cb As New CorsoPerPersoneBelle("Informatica", 5)
        If cb.AggiungiIscritto("Luca", "Neri", "01/01/1950", 2) Then
            Debug.WriteLine("Persona aggiunta con successo")
        Else
            Debug.WriteLine(cb.ToString() + "Persona troppo brutta !!!")
        End If
        Debug.WriteLine(cb)

        cb.AggiungiIscritto(New Persona("Mario", "Grigi", 3), 10)
        Me.BackColor = Color.Red



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim corso As New Corso("Matematica")

        corso.AggiungiIscritto(cognome.Text)

        Debug.WriteLine(corso)


        'Dim label As New Label()
        'label.Text = "asfdasf"
        'label.Location = New Point(20, 30)
        'Me.Controls.Add(label)
    End Sub
End Class

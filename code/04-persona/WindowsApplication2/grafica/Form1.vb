Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim p As Persona
        rtb.Text = "Hello World!"
        rtb.AppendText(vbCrLf + "Sono una Rich Text Box usata per loggare messaggi")

    End Sub

    Private Sub CreaPersona1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreaPersona1.Click
        If (tbNome.Text <> String.Empty And tbCognome.Text <> String.Empty) Then
            Dim p As Persona
            p = New Persona(tbNome.Text, tbCognome.Text)

            'p.Nome = tbNome.Text
            'p.Cognome = tbCognome.Text
            rtb.AppendText(vbCrLf + "Ho creato la Persona p = " + p.ToString())

            listaDiPersone.Items.Add(p)
            rtb.AppendText(vbCrLf + "Ho aggiunto la Persona p = " + p.ToString() + " alla lista delle persone.")

            tbNome.Text = String.Empty
            tbCognome.Text = String.Empty
        Else
            MsgBox("Inserisci nome e cognome validi!")
        End If
    End Sub

    Private Sub listaDiPersone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaDiPersone.SelectedIndexChanged
        Dim p As Persona
        p = listaDiPersone.SelectedItem
        If Not p Is Nothing Then
            tbNomeSelezionato.Text = p.Nome
            tbCognomeSelezionato.Text = p.Cognome
            rtb.AppendText(vbCrLf + "Hai selezionato la Persona p = " + p.ToString())
        Else
            rtb.AppendText(vbCrLf + "Nessun elemento selezionato")
        End If
    End Sub

    Private Sub RimuoviPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RimuoviPersona.Click
        Dim p As Persona
        p = listaDiPersone.SelectedItem
        If Not p Is Nothing Then
            listaDiPersone.Items.Remove(p)
            listaDiPersone.Refresh()
            tbNomeSelezionato.Text = String.Empty
            tbCognomeSelezionato.Text = String.Empty
        Else
            rtb.AppendText(vbCrLf + "Devi prima selezionare l'elemento da rimuovere")
        End If
    End Sub

    Private Sub ModificaPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificaPersona.Click
        Dim p As Persona
        p = listaDiPersone.SelectedItem
        If Not p Is Nothing Then
            rtb.AppendText(vbCrLf + "Stai per modificare la Persona p = " + p.ToString() + " (vecchio valore)")
            p.Nome = tbNomeSelezionato.Text
            p.Cognome = tbCognomeSelezionato.Text

            'per aggiornare la lista devo eliminare l'elemento e reinserirlo
            Dim index As Integer
            index = listaDiPersone.SelectedIndex
            listaDiPersone.Items.Remove(p)
            listaDiPersone.Items.Insert(index, p)
            listaDiPersone.Refresh()

            rtb.AppendText(vbCrLf + "Hai modificato la Persona p = " + p.ToString() + " (nuovo valore)")
        Else
            rtb.AppendText(vbCrLf + "Devi prima selezionare l'elemento da modificare")
        End If

    End Sub
End Class

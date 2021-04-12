Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim elencoDiscipline = New List(Of Disciplina)

        Dim informatica As Disciplina
        informatica = New Disciplina("Informatica")
        elencoDiscipline.Add(informatica)

        Dim inglese As Disciplina
        inglese = New Disciplina("Inglese")
        elencoDiscipline.Add(inglese)

        RichTextBox1.AppendText(vbCrLf + "Elenco discipline:" + vbCrLf)
        For Each d In elencoDiscipline
            RichTextBox1.AppendText(d.ToString + vbCrLf)
        Next


        'elenco studenti
        Dim s1_sia5A = New Studente("Nome1", "Cognome1", New Date(2002, 1, 1))
        Dim s2_sia5A = New Studente("Nome2", "Cognome2", New Date(2002, 1, 2))
        Dim s3_sia5A = New Studente("Nome3", "Cognome3", New Date(2002, 1, 3))
        Dim s1_sia4A = New Studente("Nome4", "Cognome4", New Date(2003, 2, 1))
        Dim s2_sia4A = New Studente("Nome5", "Cognome5", New Date(2003, 2, 2))
        Dim s3_sia4A = New Studente("Nome6", "Cognome6", New Date(2003, 2, 3))
        Dim s1_sia3A = New Studente("Nome7", "Cognome7", New Date(2004, 3, 1))
        Dim s2_sia3A = New Studente("Nome8", "Cognome8", New Date(2004, 3, 2))
        Dim s3_sia3A = New Studente("Nome9", "Cognome9", New Date(2004, 3, 3))
        Dim s1_afm4A = New Studente("Nome10", "Cognome10", New Date(2003, 4, 1))
        Dim s2_afm4A = New Studente("Nome11", "Cognome11", New Date(2003, 4, 2))
        Dim s3_afm4A = New Studente("Nome12", "Cognome12", New Date(2003, 4, 3))

        'elenco classi (per disciplina)
        Dim elencoClassi As List(Of ClasseDoveInsegna)
        elencoClassi = New List(Of ClasseDoveInsegna)

        Dim fiori As DocenteConClassi
        fiori = New DocenteConClassi("Fabrizio", "Fiori", New Date(1994, 1, 1), "Diploma di Perito Informatico", False)

        Dim sia5A_Informatica = New ClasseDoveInsegna("SIA", 5, "A", informatica, 5)
        sia5A_Informatica.AggiungiStudente(s1_sia5A)
        sia5A_Informatica.AggiungiStudente(s2_sia5A)
        sia5A_Informatica.AggiungiStudente(s3_sia5A)
        sia5A_Informatica.AggiungiLaboratorio(2, fiori)
        elencoClassi.Add(sia5A_Informatica)

        Dim sia4A_Informatica = New ClasseDoveInsegna("SIA", 4, "A", informatica, 5)
        sia4A_Informatica.AggiungiStudente(s1_sia4A)
        sia4A_Informatica.AggiungiStudente(s2_sia4A)
        sia4A_Informatica.AggiungiStudente(s3_sia4A)
        sia4A_Informatica.AggiungiLaboratorio(2, fiori)
        elencoClassi.Add(sia4A_Informatica)

        Dim afm4A_Informatica = New ClasseDoveInsegna("AFM", 4, "A", informatica, 2)
        afm4A_Informatica.AggiungiStudente(s1_afm4A)
        afm4A_Informatica.AggiungiStudente(s2_afm4A)
        afm4A_Informatica.AggiungiStudente(s3_afm4A)
        elencoClassi.Add(afm4A_Informatica)

        Dim sia3A_Informatica = New ClasseDoveInsegna("SIA", 3, "A", informatica, 5)
        sia3A_Informatica.AggiungiStudente(s1_sia3A)
        sia3A_Informatica.AggiungiStudente(s2_sia3A)
        sia3A_Informatica.AggiungiStudente(s3_sia3A)
        sia3A_Informatica.AggiungiLaboratorio(2, fiori)
        elencoClassi.Add(sia3A_Informatica)

        Dim sia5A_Inglese = New ClasseDoveInsegna("SIA", 5, "A", inglese, 4)
        sia5A_Inglese.AggiungiStudente(s1_sia5A)
        sia5A_Inglese.AggiungiStudente(s2_sia5A)
        sia5A_Inglese.AggiungiStudente(s3_sia5A)
        elencoClassi.Add(sia5A_Inglese)

        RichTextBox1.AppendText(vbCrLf + "Elenco classi:" + vbCrLf)
        For Each c In elencoClassi
            RichTextBox1.AppendText(c.ToString + vbCrLf)
        Next


        'elenco docenti
        Dim elencoDocentiConClassi = New List(Of DocenteConClassi)
        Dim manni, rossi, bongini As DocenteConClassi

        manni = New DocenteConClassi("Massimiliano", "Manni", New Date(1986, 3, 26), "Laurea Specialistica in Ingegneria Informatica", True)
        manni.AggiungiClasse(sia4A_Informatica)
        manni.AggiungiClasse(sia5A_Informatica)
        manni.AggiungiClasse(afm4A_Informatica)
        elencoDocentiConClassi.Add(manni)

        rossi = New DocenteConClassi("Raffaela", "Rossi", New Date(1975, 1, 1), "Laurea Magistrale in Lingua Inglese", True)
        rossi.AggiungiClasse(sia5A_Inglese)
        elencoDocentiConClassi.Add(rossi)

        bongini = New DocenteConClassi("Claudio", "Bongini", New Date(1976, 1, 1), "Laurea Magistrale in Ingegneria Informatica", True)
        bongini.AggiungiClasse(sia3A_Informatica)
        elencoDocentiConClassi.Add(bongini)

        RichTextBox1.AppendText(vbCrLf + "Elenco docenti:" + vbCrLf)
        For Each d In elencoDocentiConClassi
            RichTextBox1.AppendText(d.ToString + vbCrLf)
        Next

    End Sub
End Class

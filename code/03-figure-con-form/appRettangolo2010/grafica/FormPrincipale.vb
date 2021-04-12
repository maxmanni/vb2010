Public Class FormPrincipale

    Private formTriangolo As FormTriangolo
    Private formRettangolo As FormRettangolo

    '---------------------------------------
    'metodi
    '---------------------------------------
   

    '---------------------------------------
    'metodi chiamati da eventi grafici
    '---------------------------------------
    Private Sub btnNuovoRettangolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovoRettangolo.Click
        'mostro il form rettangolo (DataContext vuoto)
        formRettangolo.ShowDialog()
    End Sub

    Private Sub btnNuovoTriangolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovoTriangolo.Click
        'mostro il form triangolo (DataContext vuoto)
        formTriangolo.ShowDialog()
    End Sub

    Private Sub FormPrincipale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'creo un form rettangolo, ma non lo mostro (resta invisibile)
        formRettangolo = New FormRettangolo()
        formRettangolo.FormPrincipale = Me

        'creo un form triangolo, ma non lo mostro (resta invisibile)
        formTriangolo = New FormTriangolo()
        formTriangolo.FormPrincipale = Me
    End Sub

    Private Sub ListaTriangoli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaTriangoli.SelectedIndexChanged
        If Not ListaTriangoli.SelectedItem Is Nothing Then
            formTriangolo.DataContext = ListaTriangoli.SelectedItem
            formTriangolo.ShowDialog()
        End If
    End Sub

    Private Sub ListaRettangoli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaRettangoli.SelectedIndexChanged
        If Not ListaRettangoli.SelectedItem Is Nothing Then
            formRettangolo.DataContext = ListaRettangoli.SelectedItem
            formRettangolo.ShowDialog()
        End If
    End Sub
End Class
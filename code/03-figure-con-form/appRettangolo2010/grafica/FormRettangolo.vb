Public Class FormRettangolo
    '---------------------------------------
    'proprietà
    '---------------------------------------
    Public Property FormPrincipale As FormPrincipale
    Public Property DataContext As Rettangolo
    Private isEdit As Boolean

    '---------------------------------------
    'metodi
    '---------------------------------------
    

    '---------------------------------------
    'metodi chiamati da eventi grafici
    '---------------------------------------
    
    Private Sub ButtonRicalcola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRicalcola.Click
        Dim oldBase, oldAltezza As Double
        oldBase = DataContext.Base
        oldAltezza = DataContext.Altezza

        DataContext.Base = TextBase.Text
        DataContext.Altezza = TextAltezza.Text

        If DataContext.IsValid Then
            LabelPerimetro.Text = DataContext.Perimetro
            LabelArea.Text = DataContext.Area
        Else
            DataContext.Base = oldBase
            DataContext.Altezza = oldAltezza
            TextBase.Text = oldBase
            TextAltezza.Text = oldAltezza
            MsgBox("Rettangolo non valido", MsgBoxStyle.Critical)
        End If

    End Sub


    Private Sub ButtonSalva_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalva.Click

        Dim oldBase, oldAltezza As Double
        oldBase = DataContext.Base
        oldAltezza = DataContext.Altezza

        DataContext.Base = TextBase.Text
        DataContext.Altezza = TextAltezza.Text

        If DataContext.IsValid Then
            If Not isEdit Then
                FormPrincipale.ListaRettangoli.Items.Add(DataContext)
                FormPrincipale.ListaFigure.Items.Add(DataContext)
            Else
                'aggiorna lista rettangoli
                Dim rIndex = FormPrincipale.ListaRettangoli.Items.IndexOf(DataContext)
                FormPrincipale.ListaRettangoli.Items.Remove(DataContext)
                FormPrincipale.ListaRettangoli.Items.Insert(rIndex, DataContext)
                'aggiorna lista figure
                Dim fIndex = FormPrincipale.ListaFigure.Items.IndexOf(DataContext)
                FormPrincipale.ListaFigure.Items.Remove(DataContext)
                FormPrincipale.ListaFigure.Items.Insert(fIndex, DataContext)
            End If
            Hide()
        Else
            DataContext.Base = oldBase
            DataContext.Altezza = oldAltezza
            TextBase.Text = oldBase
            TextAltezza.Text = oldAltezza
            MsgBox("Rettangolo non valido", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FormRettangolo_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Visible Then
            If DataContext Is Nothing Then
                'add
                DataContext = New Rettangolo()
                ButtonSalva.Text = "Aggiungi"
                Text = "Nuovo Rettangolo"
                isEdit = False
            Else
                'edit
                ButtonSalva.Text = "Salva"
                Text = "Modifica Rettangolo"
                isEdit = True
            End If
            TextBase.Text = DataContext.Base
            TextAltezza.Text = DataContext.Altezza
            LabelArea.Text = String.Empty
            LabelPerimetro.Text = String.Empty
            ButtonElimina.Enabled = isEdit
        Else
            FormPrincipale.ListaRettangoli.Refresh()
            FormPrincipale.ListaRettangoli.Update()
            FormPrincipale.ListaFigure.Refresh()
            FormPrincipale.ListaFigure.Update()
            DataContext = Nothing
        End If
    End Sub

    Private Sub ButtonElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonElimina.Click
        If isEdit Then
            FormPrincipale.ListaRettangoli.Items.Remove(DataContext)
            FormPrincipale.ListaRettangoli.SelectedItem = Nothing
            FormPrincipale.ListaFigure.Items.Remove(DataContext)
            FormPrincipale.ListaFigure.SelectedItem = Nothing
            Hide()
        End If
    End Sub
End Class
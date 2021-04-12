Public Class FormTriangolo
    '---------------------------------------
    'proprietà
    '---------------------------------------
    Public Property FormPrincipale As FormPrincipale
    Public Property DataContext As Triangolo
    Private Property IsEdit As Boolean

    Private Sub ButtonCalcola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRicalcola.Click
        Dim old1, old2, old3 As Double
        old1 = DataContext.Lato1
        old2 = DataContext.Lato2
        old3 = DataContext.Lato3

        DataContext.Lato1 = TextLato1.Text
        DataContext.Lato2 = TextLato2.Text
        DataContext.Lato3 = TextLato3.Text
        If DataContext.IsValid Then
            LabelPerimetro.Text = DataContext.Perimetro
            LabelArea.Text = DataContext.Area
        Else
            DataContext.Lato1 = old1
            DataContext.Lato2 = old2
            DataContext.Lato3 = old3
            TextLato1.Text = old1
            TextLato2.Text = old2
            TextLato3.Text = old3
            MsgBox("Triangolo non valido", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub ButtonSalva_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalva.Click

        Dim old1, old2, old3 As Double
        old1 = DataContext.Lato1
        old2 = DataContext.Lato2
        old3 = DataContext.Lato3

        DataContext.Lato1 = TextLato1.Text
        DataContext.Lato2 = TextLato2.Text
        DataContext.Lato3 = TextLato3.Text

        If DataContext.IsValid Then
            If Not IsEdit Then
                FormPrincipale.ListaTriangoli.Items.Add(DataContext)
                FormPrincipale.ListaFigure.Items.Add(DataContext)
            Else
                'aggiorna lista triangoli
                Dim tIndex = FormPrincipale.ListaTriangoli.Items.IndexOf(DataContext)
                FormPrincipale.ListaTriangoli.Items.Remove(DataContext)
                FormPrincipale.ListaTriangoli.Items.Insert(tIndex, DataContext)
                'aggiorna lista figure
                Dim fIndex = FormPrincipale.ListaFigure.Items.IndexOf(DataContext)
                FormPrincipale.ListaFigure.Items.Remove(DataContext)
                FormPrincipale.ListaFigure.Items.Insert(fIndex, DataContext)
            End If
            Hide()
        Else
            DataContext.Lato1 = old1
            DataContext.Lato2 = old2
            DataContext.Lato3 = old3
            TextLato1.Text = old1
            TextLato2.Text = old2
            TextLato3.Text = old3
            MsgBox("Triangolo non valido", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub FormTriangolo_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Visible Then
            If DataContext Is Nothing Then
                'add
                DataContext = New Triangolo()
                ButtonSalva.Text = "Aggiungi"
                Text = "Nuovo Triangolo"
                IsEdit = False
            Else
                'edit
                ButtonSalva.Text = "Salva"
                Text = "Modifica Triangolo"
                IsEdit = True
            End If
            TextLato1.Text = DataContext.Lato1
            TextLato2.Text = DataContext.Lato2
            TextLato3.Text = DataContext.Lato3
            LabelArea.Text = String.Empty
            LabelPerimetro.Text = String.Empty
            ButtonElimina.Enabled = IsEdit
        Else
            FormPrincipale.ListaTriangoli.Refresh()
            FormPrincipale.ListaTriangoli.Update()
            FormPrincipale.ListaFigure.Refresh()
            FormPrincipale.ListaFigure.Update()
            DataContext = Nothing
        End If
    End Sub

    Private Sub ButtonElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonElimina.Click
        If IsEdit Then
            FormPrincipale.ListaTriangoli.Items.Remove(DataContext)
            FormPrincipale.ListaFigure.Items.Remove(DataContext)
            Hide()
        End If
    End Sub
End Class
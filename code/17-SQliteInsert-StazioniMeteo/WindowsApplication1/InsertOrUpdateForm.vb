Public Class InsertOrUpdateForm

    Private listOfFields As New List(Of TextBox)
    Public OkAction As Action(Of List(Of Object))

    Private Function CreateFieldPanel(ByVal i As Integer, ByVal fieldName As String, ByVal fieldValue As String, ByVal enabled As Boolean) As TextBox
        Dim fpanel = New FlowLayoutPanel()
        fpanel.FlowDirection = FlowDirection.LeftToRight
        fpanel.Height = 24
        fpanel.Width = fieldsPanel.Width - 10
        Dim label As New Label()
        label.Name = String.Format("Label{0} ", i + 1)
        label.Text = fieldName
        label.Width = fpanel.Width / 3
        label.Height = fpanel.Height
        label.TextAlign = ContentAlignment.MiddleRight
        fpanel.Controls.Add(label)
        Dim textbox As New TextBox()
        textbox.Name = String.Format("Field{0} ", i + 1)
        textbox.Width = fpanel.Width / 3
        textbox.Height = fpanel.Height
        textbox.Text = fieldValue
        textbox.Enabled = enabled
        fpanel.Controls.Add(textbox)
        fieldsPanel.Controls.Add(fpanel)
        Return textbox
    End Function

    Public Sub SetFields(ByVal fieldNames As List(Of String), ByVal pkName As String, ByVal pkFieldValue As String)
        Dim i As Integer
        'Me.Controls.Clear()
        For Each fieldName As String In fieldNames
            Dim fieldValue As String
            Dim fieldEnabled As Boolean
            If fieldName = pkName Then
                fieldValue = pkFieldValue
                fieldEnabled = False
            Else
                fieldValue = String.Empty
                fieldEnabled = True
            End If
            Dim textbox As TextBox = CreateFieldPanel(i, fieldName, fieldValue, fieldEnabled)
            listOfFields.Add(textbox)
        Next
    End Sub

    Public Sub SetFieldValues(ByVal fieldValues As List(Of String))
        Dim i As Integer
        For Each field As TextBox In listOfFields
            field.Text = fieldValues(i)
            i = i + 1
        Next
    End Sub

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        If Not IsNothing(OkAction) Then
            Dim fieldValues As New List(Of Object)
            For Each field In listOfFields
                If Not String.IsNullOrEmpty(field.Text) Then
                    fieldValues.Add(field.Text)
                Else
                    fieldValues.Add(Nothing)
                End If
            Next
            OkAction(fieldValues)
        End If
        Me.Close()
    End Sub


    Private Sub fieldsPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles fieldsPanel.Paint

    End Sub
End Class
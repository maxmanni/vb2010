Imports System.Data.SQLite

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Using connection As New SQLiteConnection("Data Source=world.db")

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()

            command.CommandText = "Select count(*) from city where name like 'MA%';"
            Dim rowCount As Integer
            rowCount = Convert.ToInt32(command.ExecuteScalar())
            'MsgBox(rowCount)

            command.CommandText = "Select * from city where name like 'MA%';"
            'command.Parameters.AddWithValue("$name", "M%")

            'see https://zetcode.com/csharp/sqlite/

            Using reader As SQLiteDataReader = command.ExecuteReader()

                griglia.ColumnCount = reader.FieldCount
                griglia.RowCount = rowCount


                'nomi delle colonne
                Dim c As Integer
                For c = 0 To reader.FieldCount - 1
                    griglia.Columns(c).HeaderText = reader.GetName(c)
                Next

                Dim r As Integer

                While reader.Read() 'scorro tutte le righe
                    For c = 0 To reader.FieldCount - 1
                        Dim tipo As String
                        tipo = reader.GetDataTypeName(c)
                        If tipo = "INT" Then
                            griglia.Rows(r).Cells(c).Value = reader.GetInt32(c).ToString()
                        Else
                            griglia.Rows(r).Cells(c).Value = reader.GetString(c)
                        End If
                    Next
                    r = r + 1

                End While
            End Using



        End Using


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        nomePaziente.Visible = True
        ' Set the Multiline property to true.
        nomePaziente.Multiline = True
        ' Add vertical scroll bars to the TextBox control.
        nomePaziente.ScrollBars = ScrollBars.Vertical
        ' Allow the RETURN key in the TextBox control.
        nomePaziente.AcceptsReturn = True
        ' Allow the TAB key to be entered in the TextBox control.
        nomePaziente.AcceptsTab = True
        ' Set WordWrap to true to allow text to wrap to the next line.
        nomePaziente.WordWrap = True
        ' Set the default text of the control.
        nomePaziente.Text = "Welcome!" & Environment.NewLine & "Second Line"
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        nomePaziente.Clear()
    End Sub
End Class

Imports System.Data.SQLite

Public Class Form1

    Public Const databaseName = "stazioni.db"

    Public Const tableComune = "comune"
    Public Const pkComune = "Id"
    Public fieldsComune = New List(Of String) From {pkComune, "Nome", "Popolazione"}

    Public Const tableStazione = "stazione"
    Public Const pkStazione = "Id"
    Public fieldsStazione = New List(Of String) From {pkStazione, "IdComune", "Indirizzo", "Nome", "Latitudine", "Longitudine", "Altitudine"}

    Public Const tableRilevazione = "rilevazione"
    Public fieldsRilevazione = New List(Of String) From {"NumeroProgressivo", "IdStazione", "DataOra", "Temperatura", "Pressione"}


    Public Sub readTable(ByVal databasename As String, ByVal tableName As String, ByVal dgv As DataGridView)

        Dim rowCount As Integer = countRows(databasename, tableName)

        Using connection As New SQLiteConnection("Data Source=" + databasename)

            dgv.Rows.Clear()
            dgv.RowCount = rowCount

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = "Select * from " + tableName

            Using reader As SQLiteDataReader = command.ExecuteReader()

                Dim fieldCount = reader.FieldCount
                dgv.ColumnCount = fieldCount

                'nomi delle colonne
                Dim c As Integer
                For c = 0 To reader.FieldCount - 1
                    dgv.Columns(c).HeaderText = reader.GetName(c)
                Next

                Dim r As Integer
                While reader.Read() 'scorro tutte le righe
                    For c = 0 To reader.FieldCount - 1 'scorro tutti i campi della riga
                        Dim objectValue As Object
                        Dim tipo As String
                        tipo = reader.GetDataTypeName(c)
                        If tipo.IndexOf("int", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                            objectValue = reader.GetInt32(c).ToString()
                        ElseIf tipo.IndexOf("decimal", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                            objectValue = reader.GetDecimal(c).ToString()
                        Else
                            objectValue = reader.GetString(c)
                        End If
                        dgv.Rows(r).Cells(c).Value = objectValue
                    Next
                    r = r + 1
                End While
            End Using

        End Using
    End Sub

    Private Function getParamName(ByVal paramIndex As Integer) As String
        Return String.Format("@param{0}", paramIndex)
    End Function

    Private Function getParamNames(ByVal n As Integer) As List(Of String)
        Dim params As New List(Of String)
        Dim i As Integer
        For i = 0 To n - 1
            params.Add(getParamName(i))
        Next
        Return params
    End Function

    Public Sub insertIntoTable(ByVal databasename As String,
                               ByVal tableName As String,
                               ByRef fieldNames As List(Of String),
                               ByRef row As List(Of String))
        Dim rows As New List(Of List(Of String))
        rows.Add(row)
        insertIntoTable(databasename, tableName, fieldNames, rows)
    End Sub

    Public Sub insertIntoTable(ByVal databasename As String,
                               ByVal tableName As String,
                               ByRef fields As List(Of String),
                               ByRef rows As List(Of List(Of String)))

        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim fieldsCount As Integer = fields.Count
            Dim fieldsString As String = String.Join(", ", fields)
            Dim params As List(Of String) = getParamNames(fieldsCount)
            Dim paramsString As String = String.Join(", ", params)

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Insert into {0}({1}) values ({2})", tableName, fieldsString, paramsString)
            'MsgBox(command.CommandText)

            For Each row As List(Of String) In rows
                command.Parameters.Clear()

                Dim fieldValuesCount = row.Count

                Dim i As Integer = 0
                While i < fieldsCount
                    Dim fieldValue As String
                    If i < fieldValuesCount Then
                        fieldValue = row(i)
                    Else
                        fieldValue = vbNull
                    End If
                    command.Parameters.AddWithValue(params(i), fieldValue)
                    i = i + 1
                End While

                command.ExecuteNonQuery()
            Next
        End Using
    End Sub

    Public Function getMaxId(ByVal databasename As String, ByVal tableName As String, ByVal idFieldName As String) As Integer
        Using connection As New SQLiteConnection("Data Source=" + databaseName)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Select max({0}) from {1}", idFieldName, tableName)
            Return Convert.ToInt32(command.ExecuteScalar())

        End Using
    End Function

    Public Function countRows(ByVal databasename As String, ByVal tableName As String) As Integer
        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Select count(*) from {0}", tableName)
            Return Convert.ToInt32(command.ExecuteScalar())

        End Using
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        readTable(databaseName, tableComune, dgvComuni)
        readTable(databaseName, tableStazione, dgvStazioni)
        readTable(databaseName, tableRilevazione, dgvRilevazioni)

    End Sub

    Private Sub comuneInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comuneInsert.Click
        Dim maxId As Integer = getMaxId(databaseName, tableComune, pkComune)
        insertIntoTable(databaseName, tableComune, fieldsComune, New List(Of String) From {maxId + 1, comuneNome.Text, comunePopolazione.Text})
        readTable(databaseName, tableComune, dgvComuni)
    End Sub
End Class

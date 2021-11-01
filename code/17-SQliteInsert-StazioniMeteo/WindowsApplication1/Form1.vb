Imports System.Data.SQLite

Public Class Form1

    Public Const databaseName = "stazioni.db"

    Public Const tableComune = "Comune"
    Public Const pkComune = "Id"
    Public pkIndexComune As Integer
    Public fieldsComune = New List(Of String)

    Public Const tableStazione = "Stazione"
    Public Const pkStazione = "Id"
    Public pkIndexStazione As Integer
    Public fieldsStazione = New List(Of String)

    Public Const tableRilevazione = "Rilevazione"
    Public Const pkRilevazione = "NumeroProgressivo"
    Public pkIndexRilevazione As Integer
    Public fieldsRilevazione = New List(Of String)


    Public Sub readTable(ByVal databasename As String, ByVal tableName As String, ByVal dgv As DataGridView, ByVal fieldNames As List(Of String))

        Dim rowCount As Integer = countRows(databasename, tableName)

        Using connection As New SQLiteConnection("Data Source=" + databasename)

            dgv.Rows.Clear()
            dgv.RowCount = rowCount + 1

            fieldNames.Clear()

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = "Select * from " + tableName

            Using reader As SQLiteDataReader = command.ExecuteReader()

                Dim fieldCount = reader.FieldCount
                dgv.ColumnCount = fieldCount

                'nomi delle colonne
                Dim c As Integer
                For c = 0 To reader.FieldCount - 1
                    Dim fieldName As String
                    fieldName = reader.GetName(c)
                    dgv.Columns(c).HeaderText = fieldName
                    fieldNames.Add(fieldName)
                Next

                Dim r As Integer
                While reader.Read() 'scorro tutte le righe
                    For c = 0 To reader.FieldCount - 1 'scorro tutti i campi della riga
                        dgv.Rows(r).Cells(c).Value = reader(c)
                    Next
                    r = r + 1
                End While
            End Using

        End Using
    End Sub

    Private Function getFieldStringValue(ByVal reader As SQLiteDataReader, ByVal c As Integer) As String
        Dim stringValue As String
        If Not reader.IsDBNull(c) Then
            Dim type As String
            type = reader.GetDataTypeName(c)
            If type.IndexOf("int", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                stringValue = reader.GetInt32(c).ToString()
            ElseIf type.IndexOf("decimal", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                stringValue = reader.GetDecimal(c).ToString()
            Else
                stringValue = reader.GetString(c)
            End If
        Else
            stringValue = String.Empty
        End If
        Return stringValue
    End Function

    Public Function readRowByPrimaryKey(ByVal databasename As String, ByVal tableName As String, ByVal pkName As String, ByVal pkvalue As String) As List(Of String)

        Dim fieldValues As New List(Of String)

        Using connection As New SQLiteConnection("Data Source=" + databasename)
            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Select * from {0} where {1} = @pk", tableName, pkName)
            command.Parameters.AddWithValue("@pk", pkvalue)

            Using reader As SQLiteDataReader = command.ExecuteReader()
                If reader.Read() Then
                    For c = 0 To reader.FieldCount - 1
                        Dim stringValue As String = getFieldStringValue(reader, c)
                        fieldValues.Add(stringValue)
                    Next
                End If
            End Using

        End Using
        Return fieldValues
    End Function

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

                Try
                    command.ExecuteNonQuery()
                Catch e As Exception
                    MsgBox(e.Message)

                End Try
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
        readTable(databaseName, tableComune, dgvComuni, fieldsComune)
        pkIndexComune = getPrimaryKeyColumnIndex(dgvComuni, pkComune)
        readTable(databaseName, tableStazione, dgvStazioni, fieldsStazione)
        pkIndexStazione = getPrimaryKeyColumnIndex(dgvStazioni, pkStazione)
        readTable(databaseName, tableRilevazione, dgvRilevazioni, fieldsRilevazione)
        pkIndexRilevazione = getPrimaryKeyColumnIndex(dgvRilevazioni, pkRilevazione)
    End Sub

    Private Sub InserisciComune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inserisciComune.Click

        Dim nextId As Integer = 1 + getMaxId(databaseName, tableComune, pkComune)

        InsertOrUpdateForm.SetFields(fieldsComune, pkComune, nextId)
        InsertOrUpdateForm.OkAction = Sub(fieldValues As List(Of String))
                                          insertIntoTable(databaseName, tableComune, fieldsComune, fieldValues)
                                          readTable(databaseName, tableComune, dgvComuni, fieldsComune)
                                      End Sub
        InsertOrUpdateForm.Show()
    End Sub

    Private Function getPrimaryKeyColumnIndex(ByVal dgv As DataGridView, ByVal pkName As String) As Integer
        Dim c As Integer
        For c = 0 To dgv.Columns.Count - 1
            If dgv.Columns(c).HeaderText = pkName Then
                Return c
            End If
        Next
    End Function


    Private Sub modificaComune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificaComune.Click
        Dim rows = dgvComuni.SelectedRows
        If rows.Count > 0 Then
            Dim pkValue As String = rows(0).Cells(pkIndexComune).Value
            Dim fieldValues As List(Of String) = readRowByPrimaryKey(databaseName, tableComune, pkComune, pkValue)
            InsertOrUpdateForm.SetFields(fieldsComune, pkComune, Convert.ToInt32(pkValue))
            InsertOrUpdateForm.SetFieldValues(fieldValues)
            InsertOrUpdateForm.OkAction = Sub(modifiedFieldValues As List(Of String))
                                              MsgBox(String.Join(", ", modifiedFieldValues))
                                          End Sub
            InsertOrUpdateForm.Show()
        Else
            MsgBox("Seleziona prima un Comune")
        End If
    End Sub

End Class

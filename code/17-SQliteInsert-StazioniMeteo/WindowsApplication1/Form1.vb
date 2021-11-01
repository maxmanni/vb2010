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


    Public Sub ReadTable(ByVal databasename As String, ByVal tableName As String, ByVal dgv As DataGridView, ByVal fieldNames As List(Of String))

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

    Private Function readRowByPrimaryKey(ByVal databasename As String, ByVal tableName As String, ByVal pkName As String, ByVal pkvalue As String) As List(Of String)

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

    Public Sub InsertIntoTable(ByVal databasename As String,
                               ByVal tableName As String,
                               ByVal fieldNames As List(Of String),
                               ByVal row As List(Of String))
        Dim rows As New List(Of List(Of String))
        rows.Add(row)
        InsertIntoTable(databasename, tableName, fieldNames, rows)
    End Sub

    Public Sub InsertIntoTable(ByVal databasename As String,
                               ByVal tableName As String,
                               ByVal fields As List(Of String),
                               ByVal rows As List(Of List(Of String)))

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
                        fieldValue = Nothing
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

    Private Function getMaxId(ByVal databasename As String, ByVal tableName As String, ByVal idFieldName As String) As Integer
        Using connection As New SQLiteConnection("Data Source=" + databaseName)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Select max({0}) from {1}", idFieldName, tableName)
            Return Convert.ToInt32(command.ExecuteScalar())

        End Using
    End Function

    Private Function countRows(ByVal databasename As String, ByVal tableName As String) As Integer
        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Select count(*) from {0}", tableName)
            Return Convert.ToInt32(command.ExecuteScalar())

        End Using
    End Function


    Public Sub UpdateTable(ByVal databasename As String,
                               ByVal tableName As String,
                               ByVal pkName As String,
                               ByVal pkValue As String,
                               ByVal fields As List(Of String),
                               ByVal fieldValues As List(Of String))

        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim i, paramCount As Integer
            Dim params As New List(Of String)
            Dim kvPairs As New List(Of String)

            paramCount = 0
            For i = 0 To fields.Count - 1
                If fields(i) <> pkName And i < fieldValues.Count Then
                    Dim paramName As String = String.Format("@param{0}", paramCount)
                    params.Add(paramName)
                    paramCount = paramCount + 1
                    kvPairs.Add(String.Format("{0} = {1}", fields(i), paramName))
                End If
            Next

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Update {0} set {1} where {2}=@pkValue", tableName, String.Join(", ", kvPairs), pkName)
            command.Parameters.AddWithValue("@pkValue", pkValue)
            'MsgBox(command.CommandText)

            paramCount = 0
            For i = 0 To fields.Count - 1
                If fields(i) <> pkName And i < fieldValues.Count Then
                    Dim fieldValue As String = Nothing
                    If Not String.IsNullOrEmpty(fieldValues(i)) Then
                        fieldValue = fieldValues(i)
                    End If
                    command.Parameters.AddWithValue(params(paramCount), fieldValue)
                    paramCount = paramCount + 1
                End If
            Next

            Try
                command.ExecuteNonQuery()
            Catch e As Exception
                MsgBox(e.Message)
            End Try

        End Using
    End Sub

    Public Sub DeleteFromTable(ByVal databasename As String,
                               ByVal tableName As String,
                               ByVal pkName As String,
                               ByVal pkValue As String)

        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Delete from {0} where {1}=@pkValue", tableName, pkName)
            command.Parameters.AddWithValue("@pkValue", pkValue)
            'MsgBox(command.CommandText)

            Try
                command.ExecuteNonQuery()
            Catch e As Exception
                MsgBox(e.Message)
            End Try

        End Using
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReadTable(databaseName, tableComune, dgvComuni, fieldsComune)
        pkIndexComune = getPrimaryKeyColumnIndex(dgvComuni, pkComune)
        ReadTable(databaseName, tableStazione, dgvStazioni, fieldsStazione)
        pkIndexStazione = getPrimaryKeyColumnIndex(dgvStazioni, pkStazione)
        ReadTable(databaseName, tableRilevazione, dgvRilevazioni, fieldsRilevazione)
        pkIndexRilevazione = getPrimaryKeyColumnIndex(dgvRilevazioni, pkRilevazione)
    End Sub

    Private Sub InserisciComune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inserisciComune.Click

        Dim nextId As Integer = 1 + getMaxId(databaseName, tableComune, pkComune)

        InsertOrUpdateForm.SetFields(fieldsComune, pkComune, nextId)
        InsertOrUpdateForm.OkAction = Sub(fieldValues As List(Of String))
                                          InsertIntoTable(databaseName, tableComune, fieldsComune, fieldValues)
                                          ReadTable(databaseName, tableComune, dgvComuni, fieldsComune)
                                      End Sub
        InsertOrUpdateForm.Text = "Inserisci Comune"
        InsertOrUpdateForm.Show()
    End Sub

    Private Function getPrimaryKeyColumnIndex(ByVal dgv As DataGridView, ByVal pkName As String) As Integer
        Dim c As Integer
        For c = 0 To dgv.Columns.Count - 1
            If dgv.Columns(c).HeaderText = pkName Then
                Return c
            End If
        Next
        Return -1
    End Function


    Private Sub modificaComune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificaComune.Click
        Dim rows = dgvComuni.SelectedRows
        If rows.Count > 0 Then
            Dim pkValue As String = rows(0).Cells(pkIndexComune).Value
            Dim fieldValues As List(Of String) = readRowByPrimaryKey(databaseName, tableComune, pkComune, pkValue)
            InsertOrUpdateForm.SetFields(fieldsComune, pkComune, Convert.ToInt32(pkValue))
            InsertOrUpdateForm.SetFieldValues(fieldValues)
            InsertOrUpdateForm.OkAction = Sub(modifiedFieldValues As List(Of String))
                                              UpdateTable(databaseName, tableComune, pkComune, pkValue, fieldsComune, modifiedFieldValues)
                                              ReadTable(databaseName, tableComune, dgvComuni, fieldsComune)
                                          End Sub
            InsertOrUpdateForm.Text = String.Format("Modifica Comune {0}={1}", pkComune, pkValue)
            InsertOrUpdateForm.Show()
        Else
            MsgBox("Seleziona prima una riga della tabella Comune")
        End If
    End Sub

    Private Sub eliminaComune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminaComune.Click
        Dim rows = dgvComuni.SelectedRows
        If rows.Count > 0 Then
            Dim pkValue As String = rows(0).Cells(pkIndexComune).Value
            If MsgBox(String.Format("Eliminare il Comune con {0}={1}?", pkComune, pkValue), vbOKCancel, "Elima Comune") = vbOK Then
                DeleteFromTable(databaseName, tableComune, pkComune, pkValue)
                ReadTable(databaseName, tableComune, dgvComuni, fieldsComune)
            End If
        Else
            MsgBox("Seleziona prima una riga della tabella Comune")
        End If
    End Sub
End Class

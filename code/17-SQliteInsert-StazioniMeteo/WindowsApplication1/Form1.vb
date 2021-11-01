Imports System.Data.SQLite
Imports System.Collections.Generic
Imports System.Globalization

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
                               ByVal row As List(Of Object))
        Dim rows As New List(Of List(Of Object))
        rows.Add(row)
        InsertIntoTable(databasename, tableName, fieldNames, rows)
    End Sub

    Public Sub InsertIntoTable(ByVal databasename As String,
                               ByVal tableName As String,
                               ByVal fields As List(Of String),
                               ByVal rows As List(Of List(Of Object)),
                               Optional ByVal progressAction As Action = Nothing)

        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim fieldsCount As Integer = fields.Count
            Dim fieldsString As String = String.Join(", ", fields)
            Dim params As List(Of String) = getParamNames(fieldsCount)
            Dim paramsString As String = String.Join(", ", params)

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Insert into {0}({1}) values ({2})", tableName, fieldsString, paramsString)
            'MsgBox(command.CommandText)

            For Each row As List(Of Object) In rows
                command.Parameters.Clear()

                Dim fieldValuesCount = row.Count

                Dim i As Integer = 0
                While i < fieldsCount
                    Dim fieldValue As Object
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
                    If Not progressAction Is Nothing Then
                        progressAction()
                    End If
                Catch e As Exception
                    MsgBox(e.Message)
                    Exit For
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
                               ByVal fieldValues As List(Of Object))

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

    Public Sub DeleteAllRecords(ByVal databasename As String,
                              ByVal tableName As String)

        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Delete from {0}", tableName)

            Try
                command.ExecuteNonQuery()
            Catch e As Exception
                MsgBox(e.Message)
            End Try

        End Using
    End Sub

    Public Function ReadTableData(ByVal databasename As String, ByVal tableName As String, ByVal fieldNames As List(Of String)) As List(Of Dictionary(Of String, Object))
        Dim rows As New List(Of Dictionary(Of String, Object))

        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = String.Format("Select {0} from {1}", String.Join(", ", fieldNames), tableName)

            Using reader As SQLiteDataReader = command.ExecuteReader()

                While reader.Read() 'scorro tutte le righe
                    Dim row As New Dictionary(Of String, Object)
                    For c = 0 To reader.FieldCount - 1 'scorro tutti i campi della riga
                        row.Add(fieldNames(c), reader(c))
                    Next
                    rows.Add(row)
                End While
            End Using

        End Using

        Return rows
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReadTable(databaseName, tableComune, dgvComuni, fieldsComune)
        pkIndexComune = getPrimaryKeyColumnIndex(dgvComuni, pkComune)
        ReadTable(databaseName, tableStazione, dgvStazioni, fieldsStazione)
        pkIndexStazione = getPrimaryKeyColumnIndex(dgvStazioni, pkStazione)
        ReadTable(databaseName, tableRilevazione, dgvRilevazioni, fieldsRilevazione)
        pkIndexRilevazione = getPrimaryKeyColumnIndex(dgvRilevazioni, pkRilevazione)
        progressStaz.Text = String.Empty
        progressRilevazioni.Text = String.Empty
    End Sub

    Private Sub InserisciComune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inserisciComune.Click

        Dim nextId As Integer = 1 + getMaxId(databaseName, tableComune, pkComune)

        InsertOrUpdateForm.SetFields(fieldsComune, pkComune, nextId)
        InsertOrUpdateForm.OkAction = Sub(fieldValues As List(Of Object))
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
            InsertOrUpdateForm.OkAction = Sub(modifiedFieldValues As List(Of Object))
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

    Private Function randomSingle(ByVal lowerBound As Single, ByVal upperBound As Single) As Single
        Return (upperBound - lowerBound) * Rnd() + lowerBound
    End Function

    Private Sub creaStazioni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles creaStazioni.Click
        Dim rows As List(Of Dictionary(Of String, Object)) = ReadTableData(databaseName, tableComune, fieldsComune)
        Dim stazRows As New List(Of List(Of Object))
        Dim idStaz As Integer = 0

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Dim nStaz As Integer = Convert.ToInt32(stazPerComune.Text)
        Dim dLat As Decimal = Convert.ToDecimal(deltaLat.Text)
        Dim dLong As Decimal = Convert.ToDecimal(deltaLong.Text)

        For Each row In rows
            Dim idComune As Integer = row("Id")
            Dim nomeComune As String = row("Nome")
            Dim latitudine As Decimal = row("Latitudine")
            Dim longitudine As Decimal = row("Longitudine")
            Dim altitudineMin As Decimal = row("AltitudineMin")
            Dim altitudineMax As Decimal = row("AltitudineMax")

            Dim i As Integer
            Randomize()
            For i = 1 To nStaz
                Dim indirizzoStaz As String = String.Empty
                Dim nomeStaz As String = String.Format("{0}-{1}", nomeComune, i)
                Dim latStaz As Decimal = latitudine + randomSingle(-dLat, dLat)
                Dim longStaz As Decimal = longitudine + randomSingle(-dLong, dLong)
                Dim altStaz As Decimal = randomSingle(altitudineMin, altitudineMax)
                stazRows.Add(New List(Of Object) From {idStaz, idComune, indirizzoStaz, nomeStaz, latStaz, longStaz, altStaz})
                idStaz = idStaz + 1
            Next
        Next

        Dim completed = 0
        InsertIntoTable(databaseName, tableStazione, fieldsStazione, stazRows, Sub()
                                                                                   completed = completed + 1
                                                                                   Dim percentuale As Integer = completed / idStaz * 100
                                                                                   progressStaz.Text = String.Format("{0}%", percentuale)
                                                                                   Application.DoEvents()
                                                                               End Sub)
        ReadTable(databaseName, tableStazione, dgvStazioni, fieldsStazione)

        Cursor = Cursors.Default
        Application.DoEvents()

        MsgBox(String.Format("Sono state inserite {0} stazioni", completed), vbOK, "Inserimento stazioni")
        progressStaz.Text = String.Empty
    End Sub

    Private Sub eliminaStazioni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminaStazioni.Click
        If MsgBox("Eliminare tutte le stazioni?", vbOKCancel, "Elima Stazioni") = vbOK Then
            DeleteAllRecords(databaseName, tableStazione)
            ReadTable(databaseName, tableStazione, dgvStazioni, fieldsStazione)
        End If
    End Sub

    Private Sub creaRilevazioni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles creaRilevazioni.Click
        Dim stazioni As List(Of Dictionary(Of String, Object)) = ReadTableData(databaseName, tableStazione, New List(Of String) From {"Id"})
        Dim rilevazRows As New List(Of List(Of Object))
        Dim idRilevaz As Integer = 0

        Dim nRilevaz As Integer = Convert.ToInt32(rilevazPerStaz.Text)
        Dim tmin As Decimal = Convert.ToDecimal(tempMin.Text)
        Dim tmax As Decimal = Convert.ToDecimal(tempMax.Text)
        Dim pmin As Decimal = Convert.ToDecimal(presMin.Text)
        Dim pmax As Decimal = Convert.ToDecimal(presMax.Text)

        Dim da, a As Date
        Dim format As String = "yyyy-MM-dd HH:mm:ss"
        Try
            da = DateTime.ParseExact(tempoIniz.Text, format, CultureInfo.InvariantCulture)
            'MsgBox(da)
        Catch fe As FormatException
            MsgBox("tempoIniz non valido")
            Return
        End Try
        Try
            a = DateTime.ParseExact(tempoFin.Text, format, CultureInfo.InvariantCulture)
            'MsgBox(a)
        Catch fe As FormatException
            MsgBox("tempoFin non valido")
            Return
        End Try

        Dim daTicks As Long = da.Ticks
        Dim interval As Single = Convert.ToSingle(a.Ticks - daTicks) / Convert.ToSingle(nRilevaz)

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        For Each stazione In stazioni
            Dim idStaz As Integer = stazione("Id")

            Dim numeroProgressivo As Integer
            Randomize()
            For numeroProgressivo = 1 To nRilevaz
                Dim ticks As Long = daTicks + Convert.ToInt64(Convert.ToSingle(numeroProgressivo) * interval)
                Dim tempo As String = New Date(ticks).ToString(format)
                Dim temperatura As Decimal = randomSingle(tmin, tmax)
                Dim pressione As Decimal = randomSingle(pmin, pmax)
                rilevazRows.Add(New List(Of Object) From {numeroProgressivo, idStaz, tempo, temperatura, pressione})
                idRilevaz = idRilevaz + 1
            Next
        Next

        Dim completed = 0
        InsertIntoTable(databaseName, tableRilevazione, fieldsRilevazione, rilevazRows, Sub()
                                                                                            completed = completed + 1
                                                                                            Dim percentuale As Integer = completed / idRilevaz * 100
                                                                                            progressRilevazioni.Text = String.Format("{0}%", percentuale)
                                                                                            Application.DoEvents()
                                                                                        End Sub)
        ReadTable(databaseName, tableRilevazione, dgvRilevazioni, fieldsRilevazione)

        Cursor = Cursors.Default
        Application.DoEvents()

        MsgBox(String.Format("Sono state inserite {0} rilevazioni", completed), vbOK, "Inserimento rilevazioni")
        progressRilevazioni.Text = String.Empty
    End Sub

    Private Sub eliminaRilevazioni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminaRilevazioni.Click
        If MsgBox("Eliminare tutte le rilevazioni?", vbOKCancel, "Elima Rilevazioni") = vbOK Then
            DeleteAllRecords(databaseName, tableRilevazione)
            ReadTable(databaseName, tableRilevazione, dgvRilevazioni, fieldsRilevazione)
        End If
    End Sub

End Class

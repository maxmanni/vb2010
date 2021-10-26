Imports System.Data.SQLite


Public Class Form1

    Public Sub readTable(ByVal databasename As String, ByVal tableName As String, ByVal rtb As RichTextBox)
        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = "Select * from " + tableName
            'command.Parameters.AddWithValue("$name", "M%")

            'see https://zetcode.com/csharp/sqlite/

            Using reader As SQLiteDataReader = command.ExecuteReader()

                'nomi delle colonne
                Dim c As Integer
                For c = 0 To reader.FieldCount - 1
                    rtb.AppendText(reader.GetName(c))
                    rtb.AppendText(vbTab)
                Next

                rtb.AppendText(vbCrLf + "-------------------------------------" + vbCrLf)


                While reader.Read() 'scorro tutte le righe
                    For c = 0 To reader.FieldCount - 1
                        Dim tipo As String
                        tipo = reader.GetDataTypeName(c)
                        If tipo.IndexOf("int", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                            rtb.AppendText(reader.GetInt32(c).ToString())
                        ElseIf tipo.IndexOf("decimal", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                            rtb.AppendText(reader.GetDecimal(c).ToString())
                        Else
                            rtb.AppendText(reader.GetString(c))
                        End If
                        rtb.AppendText(vbTab)
                    Next
                    rtb.AppendText(vbCrLf)
                End While
            End Using

        End Using
    End Sub

    Private Function getParams(ByVal i As Integer)
        Dim params As List(Of String)
        params = New List(Of String)
        params.Add(String.Format("@param{0}", i))
        Return params
    End Function


    Public Sub insertIntoTable(ByVal databasename As String,
                               ByVal tableName As String,
                               ByRef fieldNames As List(Of String),
                               ByRef fieldValues As List(Of List(Of String)))
        Using connection As New SQLiteConnection("Data Source=" + databasename)

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()

            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
            Dim nParams As Integer
            nParams = fieldNames.Count
            sb.AppendFormat("Insert into {0}({1}) values ({2})", tableName, String.Join(",", fieldNames), String.Join(",", getParams(nParams)))
            MsgBox(command.CommandText)

            command.CommandText = sb.ToString()
            MsgBox(command.CommandText)
            'command.Parameters.AddWithValue("$name", "M%")

            'see https://zetcode.com/csharp/sqlite/

            Using reader As SQLiteDataReader = command.ExecuteReader()

                'nomi delle colonne
                Dim c As Integer
                For c = 0 To reader.FieldCount - 1
                    rtb.AppendText(reader.GetName(c))
                    rtb.AppendText(vbTab)
                Next

                rtb.AppendText(vbCrLf + "-------------------------------------" + vbCrLf)


                While reader.Read() 'scorro tutte le righe
                    For c = 0 To reader.FieldCount - 1
                        Dim tipo As String
                        tipo = reader.GetDataTypeName(c)
                        If tipo.IndexOf("int", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                            rtb.AppendText(reader.GetInt32(c).ToString())
                        ElseIf tipo.IndexOf("decimal", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then
                            rtb.AppendText(reader.GetDecimal(c).ToString())
                        Else
                            rtb.AppendText(reader.GetString(c))
                        End If
                        rtb.AppendText(vbTab)
                    Next
                    rtb.AppendText(vbCrLf)
                End While
            End Using

        End Using
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        readTable("stazioni.db", "comune", rtbComuni)
        readTable("stazioni.db", "stazione", rtbStazioni)
        readTable("stazioni.db", "rilevazione", rtbRilevazioni)

    End Sub

    Private Sub comuneInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comuneInsert.Click

    End Sub
End Class

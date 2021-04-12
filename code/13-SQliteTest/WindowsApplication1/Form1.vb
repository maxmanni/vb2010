Imports System.Data.SQLite

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Using connection As New SQLiteConnection("Data Source=world.db")

            connection.Open()

            Dim command As SQLiteCommand = connection.CreateCommand()
            command.CommandText = "Select * from city where name like 'M%' limit 5"
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
                        If tipo = "INT" Then
                            rtb.AppendText(reader.GetInt32(c).ToString())
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
End Class

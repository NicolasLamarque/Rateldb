Imports System.Data.SQLite

Public Class ClientManager
    Private connectionString As String = "Data Source=RateDatabase.db;Version=3;"

    ' Fonction pour récupérer un client par son ID
    Public Function GetClient(id As Integer) As Dictionary(Of String, Object)
        Dim client As New Dictionary(Of String, Object)

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Using command As New SQLiteCommand(connection)
                command.CommandText = "SELECT * FROM Clients WHERE ID = @id"
                command.Parameters.AddWithValue("@id", id)

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        For i As Integer = 0 To reader.FieldCount - 1
                            client(reader.GetName(i)) = reader(i)
                        Next
                    End If
                End Using
            End Using
        End Using

        Return client
    End Function

    ' Fonction pour enregistrer un client
    Public Sub SetClient(client As Dictionary(Of String, Object))
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Using command As New SQLiteCommand(connection)
                    Dim fields As New List(Of String)
                    Dim values As New List(Of String)

                    For Each kvp As KeyValuePair(Of String, Object) In client
                        fields.Add(kvp.Key)
                        values.Add("@" + kvp.Key)
                        command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value)
                    Next

                    command.CommandText = $"INSERT INTO Clients ({String.Join(", ", fields)}) VALUES ({String.Join(", ", values)})"
                    command.ExecuteNonQuery()
                    transaction.Commit()
                End Using
            End Using
        End Using
    End Sub
End Class

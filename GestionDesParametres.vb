Imports System.Data.SQLite

Module GestionDesParametres

    ' Initialisation de la base de données et création de la table si elle n'existe pas
    Public Sub InitializeDatabase()
        Using conn As New SQLiteConnection("Data Source=RatelDatabase.db;Version=3;")
            conn.Open()
            Dim createTableQuery As String = "
                CREATE TABLE IF NOT EXISTS Settings (
                    Key TEXT PRIMARY KEY,
                    Value TEXT
                )"
            Using cmd As New SQLiteCommand(createTableQuery, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Permet la lecture dans la table des settings
    Public Function GetSetting(ByVal key As String) As String
        Dim query As String = "SELECT Value FROM Settings WHERE Key = @key"
        Using conn As New SQLiteConnection("Data Source=RatelDatabase.db;Version=3;")
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@key", key)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString()
                Else
                    Return String.Empty
                End If
            End Using
        End Using
    End Function

    ' Permet l'écriture dans la table des settings
    Public Sub SetSetting(ByVal key As String, ByVal value As String)
        Dim query As String = "INSERT OR REPLACE INTO Settings (Key, Value) VALUES (@key, @value)"
        Using conn As New SQLiteConnection("Data Source=RatelDatabase.db;Version=3;")
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@key", key)
                cmd.Parameters.AddWithValue("@value", value)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub



End Module

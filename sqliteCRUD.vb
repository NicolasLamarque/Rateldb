Imports System.Data.SQLite

Public Class sqliteCRUD


    Private connectionString As String

    ' Constructeur pour initialiser la chaîne de connexion
    Public Sub New()
        Dim dbPath As String = "RatelDatabase.db"
        connectionString = $"Data Source={dbPath};Version=3;"
    End Sub

    ' Méthode pour ajouter un enregistrement
    Public Sub AddRecord(tableName As String, parameters As Dictionary(Of String, Object))
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim columns As String = String.Join(", ", parameters.Keys)
                Dim placeholders As String = String.Join(", ", parameters.Keys.Select(Function(k) "@" & k))
                Dim query As String = $"INSERT INTO {tableName} ({columns}) VALUES ({placeholders})"

                Using command As New SQLiteCommand(query, connection)
                    For Each param In parameters
                        command.Parameters.AddWithValue("@" & param.Key, param.Value)
                    Next
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        ' Méthode pour lire tous les enregistrements d'une table
        Public Function GetAllRecords(tableName As String) As DataTable
            Dim dt As New DataTable()
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = $"SELECT * FROM {tableName}"
                Using adapter As New SQLiteDataAdapter(query, connection)
                    adapter.Fill(dt)
                End Using
            End Using
            Return dt
        End Function

        ' Méthode pour mettre à jour un enregistrement
        Public Sub UpdateRecord(tableName As String, id As Integer, parameters As Dictionary(Of String, Object))
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim setClause As String = String.Join(", ", parameters.Keys.Select(Function(k) k & " = @" & k))
                Dim query As String = $"UPDATE {tableName} SET {setClause} WHERE ID = @ID"

                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", id)
                    For Each param In parameters
                        command.Parameters.AddWithValue("@" & param.Key, param.Value)
                    Next
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        ' Méthode pour supprimer un enregistrement
        Public Sub DeleteRecord(tableName As String, id As Integer)
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = $"DELETE FROM {tableName} WHERE ID = @ID"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", id)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        ' Méthode pour rechercher des enregistrements par clé étrangère
        Public Function SearchByForeignKey(tableName As String, foreignKeyColumn As String, foreignKeyValue As Integer) As DataTable
            Dim dt As New DataTable()
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = $"SELECT * FROM {tableName} WHERE {foreignKeyColumn} = @ForeignKeyValue"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@ForeignKeyValue", foreignKeyValue)
                    Using adapter As New SQLiteDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        End Function

        ' Méthode pour rechercher un enregistrement par nom
        Public Function SearchByName(tableName As String, nameColumn As String, name As String) As DataTable
            Dim dt As New DataTable()
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = $"SELECT * FROM {tableName} WHERE {nameColumn} LIKE @Name"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", "%" & name & "%")
                    Using adapter As New SQLiteDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        End Function
    End Class




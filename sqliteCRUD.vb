Imports System.Data.SQLite


Imports System.IO
Imports System.Reflection

Public Class sqliteCRUD
    Private ReadOnly SQLiteConn As New SQLiteConnection
    Private ReadOnly dbFileName As String
    Private ReadOnly connectionString As String

    Public Sub New(Optional dbName As String = "RatelDatabase.db")
        dbFileName = dbName
        connectionString = GetConnectionString()
        SQLiteConn.ConnectionString = connectionString
    End Sub

    Private Function GetConnectionString() As String
        Dim dbPath As String = GetDatabasePath()
        Dim connStr As String = $"Data Source={dbPath};Version=3;"
        Console.WriteLine($"Chaîne de connexion : {connStr}")
        Return connStr
    End Function



    Public Function GetDatabasePath() As String
        Dim baseDirectory As String = AppDomain.CurrentDomain.BaseDirectory
        Return Path.Combine(baseDirectory, "RatelDatabase.db")
    End Function

    Public Function GetConnection() As SQLiteConnection
        Return New SQLiteConnection(connectionString)
    End Function
    ' Méthode pour ajouter un enregistrement
    Public Sub AddRecord(tableName As String, parameters As Dictionary(Of String, Object))
        Try
            SQLiteConn.Open()

            ' Construire la requête SQL
            Dim columns As String = String.Join(", ", parameters.Keys)
            Dim values As String = String.Join(", ", parameters.Keys.Select(Function(k) "@" & k))
            Dim sql As String = $"INSERT INTO {tableName} ({columns}) VALUES ({values})"

            Using cmd As New SQLiteCommand(sql, SQLiteConn)
                ' Ajouter les paramètres à la commande
                For Each kvp In parameters
                    cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
                Next

                ' Exécuter la commande
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Gérer l'exception (par exemple, la logger ou la relancer)
            Throw New Exception($"Erreur lors de l'ajout d'un enregistrement dans {tableName}: {ex.Message}", ex)
        Finally
            If SQLiteConn.State = ConnectionState.Open Then
                SQLiteConn.Close()
            End If
        End Try
    End Sub
    ' Méthode pour lire tous les enregistrements d'une table
    ' Fonction pour récupérer tous les enregistrements d'une table avec des champs spécifiés
    Public Function GetAllRecords(tableName As String, Optional fields As String = "*") As DataTable
        Dim dt As New DataTable()
        Try
            SQLiteConn.Open()
            Dim query As String = $"SELECT {fields} FROM {tableName}"
            Using adapter As New SQLiteDataAdapter(query, SQLiteConn)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            ' Gérer l'exception (par exemple, la logger ou la relancer)
            Throw New Exception($"Erreur lors de l'ajout d'un enregistrement dans {tableName}: {ex.Message}", ex)
        Finally
            If SQLiteConn.State = ConnectionState.Open Then
                SQLiteConn.Close()
            End If
        End Try
        Return dt
    End Function

    Private Function GetTotalRecords(tableName As String) As Integer
        Dim count As Integer = 0
        Try
            SQLiteConn.Open()
            Dim query As String = $"SELECT COUNT(*) FROM {tableName}"
            Using cmd As New SQLiteCommand(query, SQLiteConn)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            Throw New Exception($"Erreur lors du comptage des enregistrements de {tableName}: {ex.Message}", ex)
        Finally
            If SQLiteConn.State = ConnectionState.Open Then
                SQLiteConn.Close()
            End If
        End Try
        Return count
    End Function
    Public Function GetLimitedRecords(tableName As String, limit As String, Optional fields As String = "*") As DataTable
        Dim dt As New DataTable()
        Try
            SQLiteConn.Open()
            Dim query As String
            Dim totalRecords As Integer = GetTotalRecords(tableName)

            If limit.ToLower() = "tout" OrElse Integer.Parse(limit) >= totalRecords Then
                query = $"SELECT {fields} FROM {tableName}"
            Else
                query = $"SELECT {fields} FROM {tableName} LIMIT @limit"
            End If

            Using cmd As New SQLiteCommand(query, SQLiteConn)
                If limit.ToLower() <> "tout" AndAlso Integer.Parse(limit) < totalRecords Then
                    cmd.Parameters.AddWithValue("@limit", Integer.Parse(limit))
                End If
                Using adapter As New SQLiteDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception($"Erreur lors de la récupération des enregistrements de {tableName}: {ex.Message}", ex)
        Finally
            If SQLiteConn.State = ConnectionState.Open Then
                SQLiteConn.Close()
            End If
        End Try
        Return dt
    End Function

    Public Sub UpdateRecord(tableName As String, id As Integer, parameters As Dictionary(Of String, Object))
        Try
            SQLiteConn.Open()
            Dim setClause As String = String.Join(", ", parameters.Keys.Select(Function(k) k & " = @" & k))
            Dim query As String = $"UPDATE {tableName} SET {setClause} WHERE ID = @ID"

            Using cmd As New SQLiteCommand(query, SQLiteConn)
                cmd.Parameters.AddWithValue("@ID", id)
                For Each param In parameters
                    cmd.Parameters.AddWithValue("@" & param.Key, param.Value)
                Next
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected = 0 Then
                    Throw New Exception($"Aucun enregistrement trouvé avec l'ID {id} dans la table {tableName}")
                End If
            End Using
        Catch ex As Exception
            Throw New Exception($"Erreur lors de la mise à jour de l'enregistrement dans {tableName}: {ex.Message}", ex)
        Finally
            If SQLiteConn.State = ConnectionState.Open Then
                SQLiteConn.Close()
            End If
        End Try
    End Sub


    ' Méthode pour supprimer un enregistrement
    Public Sub DeleteRecord(tableName As String, id As Integer)
        Try
            SQLiteConn.Open()
            Dim query As String = $"DELETE FROM {tableName} WHERE ID = @ID"
            Using command As New SQLiteCommand(query, SQLiteConn)
                command.Parameters.AddWithValue("@ID", id)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected = 0 Then
                    Throw New Exception($"Aucun enregistrement trouvé avec l'ID {id} dans la table {tableName}")
                End If
            End Using
        Catch ex As Exception
            Throw New Exception($"Erreur lors de la suppression de l'enregistrement de l'ID : {id} de la table : {tableName}: {ex.Message}", ex)
        Finally
            If SQLiteConn.State = ConnectionState.Open Then
                SQLiteConn.Close()
            End If
        End Try
    End Sub


    ''' <summary>
    ''' Recherche des enregistrements dans une table spécifiée en utilisant une clé étrangère.
    ''' </summary>
    ''' <param name="tableName">Nom de la table à rechercher</param>
    ''' <param name="foreignKeyColumn">Nom de la colonne de clé étrangère</param>
    ''' <param name="foreignKeyValue">Valeur de la clé étrangère à rechercher</param>
    ''' <returns>DataTable contenant les résultats de la recherche</returns>
    ''' <exception cref="Exception">Levée si une erreur se produit pendant la recherche</exception>
    Public Function SearchByForeignKey(tableName As String, foreignKeyColumn As String, foreignKeyValue As Integer) As DataTable
        Dim dt As New DataTable() 'On crée une table vierge pour y mettre des trucs
        Try 'on tente la connection
            SQLiteConn.Open()



            Dim query As String = $"SELECT * FROM {tableName} WHERE {foreignKeyColumn} = @ForeignKeyValue" 'on fait la requete et on laisse une pseudo variable pour passer un ID étranger
            Using command As New SQLiteCommand(query, SQLiteConn) 'on crée une commannde sqlite puis on lui passe la requete
                command.Parameters.AddWithValue("@ForeignKeyValue", foreignKeyValue) 'on implante la valeur recu de l'utilisateur dans le parametre
                Using adapter As New SQLiteDataAdapter(command) 'on implante adapteur pour remplir la table crée plus haut
                    adapter.Fill(dt) 'on rempli
                End Using
            End Using
            If dt.Rows.Count = 0 Then
                Console.WriteLine($"Aucun résultat trouvé pour {foreignKeyColumn} = {foreignKeyValue} dans la table {tableName}")
            End If

        Catch ex As Exception
            Throw New Exception($"Erreur lors de la recherche d'enregistrements dans la table {tableName} avec {foreignKeyColumn} = {foreignKeyValue}: {ex.Message}", ex)
        Finally
            If SQLiteConn.State = ConnectionState.Open Then
                SQLiteConn.Close()
            End If


        End Try
        Return dt ' Retourne la DataTable, qu'elle soit vide ou non
    End Function

    ''' <summary>
    ''' Recherche des enregistrements dans une table spécifiée en utilisant une correspondance partielle sur le nom.
    ''' </summary>
    ''' <param name="tableName">Nom de la table à rechercher</param>
    ''' <param name="nameColumn">Nom de la colonne contenant le nom</param>
    ''' <param name="name">Nom à rechercher (correspondance partielle)</param>
    ''' <returns>DataTable contenant les résultats de la recherche</returns>
    Public Function SearchByName(tableName As String, nameColumn As String, name As String) As DataTable
        Dim dt As New DataTable()
        Try
            If SQLiteConn.State = ConnectionState.Closed Then
                SQLiteConn.Open() ' Ouvrir la connexion si elle est fermée
            End If

            Dim query As String = $"SELECT * FROM {tableName} WHERE {nameColumn} LIKE @Name"
            Using command As New SQLiteCommand(query, SQLiteConn)
                command.Parameters.AddWithValue("@Name", "%" & name & "%")
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using

            If dt.Rows.Count = 0 Then
                Console.WriteLine($"Aucun résultat trouvé pour le nom '{name}' dans la colonne {nameColumn} de la table {tableName}")
            End If

        Catch ex As Exception
            Throw New Exception($"Erreur lors de la recherche d'enregistrements dans la table {tableName} avec le nom '{name}': {ex.Message}", ex)
        Finally
            If SQLiteConn.State = ConnectionState.Open Then
                ' Optionnel : Vous pouvez choisir de ne pas fermer la connexion ici si vous prévoyez d'utiliser la même connexion pour d'autres opérations.
                ' SQLiteConn.Close()
            End If
        End Try

        Return dt
    End Function


    Public Function GetClient(id As Integer) As Dictionary(Of String, Object)
        Dim client As New Dictionary(Of String, Object)

        Try
            If SQLiteConn.State <> ConnectionState.Open Then
                SQLiteConn.Open()
            End If

            Using command As New SQLiteCommand(SQLiteConn)
                command.CommandText = "SELECT * FROM Clients WHERE ID = @id"
                command.Parameters.AddWithValue("@id", id)

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        For i As Integer = 0 To reader.FieldCount - 1
                            client(reader.GetName(i)) = reader(i)
                        Next
                    Else
                        Console.WriteLine($"Aucun client trouvé avec l'ID {id}")
                    End If
                End Using
            End Using
        Catch ex As SQLiteException
            Console.WriteLine($"Erreur SQLite lors de la récupération du client {id}: {ex.Message}")
            Throw
        Catch ex As Exception
            Console.WriteLine($"Erreur inattendue lors de la récupération du client {id}: {ex.Message}")
            Throw
        Finally
            ' Vous pouvez choisir de fermer la connexion ici ou non, selon votre logique d'application
            If SQLiteConn.State = ConnectionState.Open Then
                SQLiteConn.Close()
            End If
        End Try

        Return client
    End Function

    Public Function TableExists(tableName As String) As Boolean
        Dim query As String = "SELECT name FROM sqlite_master WHERE type='table' AND name=@tableName;"
        Using conn As New SQLiteConnection("Data Source=RatelDatabase.db;Version=3;")
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@tableName", tableName)
                Dim result As Object = cmd.ExecuteScalar()
                Return result IsNot Nothing
            End Using
        End Using
    End Function

    Public Sub CreateUsersTable()
        If Not TableExists("Users") Then
            Dim query As String = "CREATE TABLE Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, UserName TEXT NOT NULL, Password TEXT NOT NULL, Salt TEXT NOT NULL);"
            Using conn As New SQLiteConnection("Data Source=RatelDatabase.db;Version=3;")
                conn.Open()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Console.WriteLine("Table Users créée avec succès.")
        Else
            Console.WriteLine("La table Users existe déjà.")
        End If
    End Sub
    Public Function FieldExists(fieldName As String, value As String) As Boolean
        Dim allowedFields As String() = {"Id", "UserName", "Email", "Password"} ' Ajoutez ici tous les champs autorisés

        If Not allowedFields.Contains(fieldName) Then
            Console.WriteLine($"Erreur : Champ non autorisé - {fieldName}")
            Return False
        End If

        Try
            Using conn As SQLiteConnection = GetConnection()
                Dim query As String = $"SELECT COUNT(*) FROM Users WHERE {fieldName} = @Value"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Value", value)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Erreur lors de la vérification du champ {fieldName}: {ex.Message}")
            Return False
        End Try
    End Function
    Public Function ExecuteSelect(query As String, parameters As Dictionary(Of String, Object)) As List(Of Dictionary(Of String, Object))
        Dim results As New List(Of Dictionary(Of String, Object))

        Try
            Using connection As SQLiteConnection = GetConnection()
                connection.Open()
                Using command As New SQLiteCommand(query, connection)
                    ' Ajouter les paramètres à la commande
                    For Each param In parameters
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    ' Exécuter la commande et lire les résultats
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim row As New Dictionary(Of String, Object)
                            For i As Integer = 0 To reader.FieldCount - 1
                                row.Add(reader.GetName(i), reader.GetValue(i))
                            Next
                            results.Add(row)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Erreur lors de l'exécution de la requête SELECT : " & ex.Message)
            Throw
        End Try

        Return results
    End Function
End Class




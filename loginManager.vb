

Imports System.Data.SQLite
    Imports System.Security.Cryptography
    Imports System.Text

    Public Class LoginManager
        Private connectionString As String = "Data Source=RatelDatabase.db;Version=3;"

        ' Fonction pour hasher le mot de passe avec un salt
        Private Function HashPassword(password As String, salt As String) As String
            Using sha256 As SHA256 = sha256.Create()
                Dim combined As String = salt & password
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(combined)
                Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
                Return Convert.ToBase64String(hashBytes)
            End Using
        End Function

        ' Fonction pour générer un salt
        Private Function GenerateSalt() As String
            Using rng As New RNGCryptoServiceProvider()
                Dim saltBytes(31) As Byte ' 32 bytes = 256 bits
                rng.GetBytes(saltBytes)
                Return Convert.ToBase64String(saltBytes)
            End Using
        End Function

        ' Fonction pour créer un utilisateur
        Public Sub CreateUser(userName As String, password As String, email As String, isAdmin As Boolean)
            Dim salt As String = GenerateSalt()
            Dim hashedPassword As String = HashPassword(password, salt)

            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Users (UserName, Password, Salt, Email, Admin) VALUES (@UserName, @Password, @Salt, @Email, @Admin)"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@UserName", userName)
                    command.Parameters.AddWithValue("@Password", hashedPassword)
                    command.Parameters.AddWithValue("@Salt", salt)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Admin", isAdmin)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        ' Fonction pour vérifier le login
        Public Function VerifyLogin(userName As String, password As String) As Boolean
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Password, Salt FROM Users WHERE UserName = @UserName"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@UserName", userName)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim storedPassword As String = reader("Password").ToString()
                            Dim storedSalt As String = reader("Salt").ToString()
                            Dim hashedInputPassword As String = HashPassword(password, storedSalt)
                            Return storedPassword = hashedInputPassword
                        End If
                    End Using
                End Using
            End Using
            Return False
        End Function

        ' Fonction pour mettre à jour un mot de passe
        Public Sub SetPassword(userName As String, newPassword As String)
            Dim newSalt As String = GenerateSalt()
            Dim hashedPassword As String = HashPassword(newPassword, newSalt)

            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE Users SET Password = @Password, Salt = @Salt WHERE UserName = @UserName"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@Password", hashedPassword)
                    command.Parameters.AddWithValue("@Salt", newSalt)
                    command.Parameters.AddWithValue("@UserName", userName)
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        ' Fonction pour vérifier si un utilisateur est admin
        Public Function IsAdmin(userName As String) As Boolean
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Admin FROM Users WHERE UserName = @UserName"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@UserName", userName)
                    Dim result = command.ExecuteScalar()
                    Return If(result IsNot Nothing AndAlso Convert.ToBoolean(result), True, False)
                End Using
            End Using
        End Function
    End Class


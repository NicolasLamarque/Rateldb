

Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginManager
    Private connectionString As String = "Data Source=RatelDatabase.db;Version=3;"



    Public Function GetUserCredentials(userId As String) As (Password As String, Salt As String)
        Dim crud As New sqliteCRUD()
        Dim query As String = "SELECT Password, Salt FROM Users WHERE UserId = @Id"
        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("@Id", userId)

        Dim results = crud.ExecuteSelect(query, parameters)

        If results.Count > 0 Then
            Dim row = results(0)
            Return (row("Password").ToString(), row("Salt").ToString())
        End If

        Return (String.Empty, String.Empty)
    End Function
    Public Function RegisterUser(username As String, password As String, email As String, isAdmin As Boolean) As Boolean
        Dim salt As String = GenerateSalt()
        Dim hashedPassword As String = HashPassword(password, salt)

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO Users (UserName, Password, Salt, Email, IsAdmin) VALUES (@UserName, @Password, @Salt, @Email, @IsAdmin)"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserName", username)

                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                cmd.Parameters.AddWithValue("@Salt", salt)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@IsAdmin", isAdmin)
                Dim result As Integer = cmd.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Public Function GenerateSalt() As String
        ' Implémentez la génération de sel ici
        ' Par exemple :
        Using rng As New RNGCryptoServiceProvider()
            Dim saltBytes As Byte() = New Byte(15) {}
            rng.GetBytes(saltBytes)
            Return Convert.ToBase64String(saltBytes)
        End Using
    End Function

    Public Function HashPassword(password As String, salt As String) As String
        ' Implémentez le hachage du mot de passe ici
        ' Par exemple, en utilisant SHA256 :
        Using sha256 As SHA256 = SHA256.Create()
            Dim passwordWithSaltBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
            Dim hashBytes As Byte() = sha256.ComputeHash(passwordWithSaltBytes)
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    Public Function GetPass(ByVal key As String) As String
        Dim query As String = "SELECT Password FROM Users WHERE Id = @key"
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

    Public Function VerifyLogin(userName As String, password As String) As Boolean
        Dim crud As New sqliteCRUD()

        Try
            Dim query As String = "SELECT Password, Salt FROM Users WHERE UserName = @UserName"
            Dim parameters As New Dictionary(Of String, Object)
            parameters.Add("@UserName", userName)

            Dim results = crud.ExecuteSelect(query, parameters)

            If results.Count > 0 Then
                Dim row = results(0)
                Dim storedPassword As String = row("Password").ToString()
                Dim storedSalt As String = row("Salt").ToString()
                Dim hashedInputPassword As String = HashPassword(password, storedSalt)

                Console.WriteLine("Tentative de connexion pour l'utilisateur : " & userName)
                Console.WriteLine("Mot de passe stocké : " & storedPassword)
                Console.WriteLine("Sel stocké : " & storedSalt)
                Console.WriteLine("Mot de passe haché en entrée : " & hashedInputPassword)

                Return storedPassword = hashedInputPassword
            Else
                Console.WriteLine("Utilisateur non trouvé : " & userName)
            End If
        Catch ex As Exception
            Console.WriteLine("Erreur lors de la vérification du login : " & ex.Message)
        End Try
        Return False
    End Function

End Class

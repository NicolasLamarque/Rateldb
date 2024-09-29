Imports System.Data.SQLite

Public Class UserManager
    Dim crypto As New LoginManager
    Private crud As New sqliteCRUD()
    Private connectionString As String = "Data Source=RatelDatabase.db;Version=3;"

    Private _Identifiant As String
    Public Property Username As String
        Get
            Return _Identifiant
        End Get
        Set(value As String)
            _Identifiant = value?.Trim()

        End Set
    End Property


    Public Function AddUser(username As String, email As String, password As String, Optional IsAdmin As Boolean = False) As Boolean
        Try
            ' Hachage du mot de passe (assurez-vous d'implémenter cette fonction)
            Dim salt As String = crypto.GenerateSalt()
            Dim hashedPassword As String = crypto.HashPassword(password, salt)

            Dim userData As New Dictionary(Of String, Object)
            userData.Add("UserName", username)
            userData.Add("Email", email)
            userData.Add("Password", hashedPassword)
            userData.Add("Salt", salt)
            userData.Add("IsAdmin", IsAdmin)
            userData.Add("CreatedDate", DateTime.Now)

            crud.AddRecord("Users", userData)
            Return True
        Catch ex As Exception
            Console.WriteLine("Erreur lors de l'ajout de l'utilisateur : " & ex.Message)
            Return False
        End Try
    End Function

    ' Autres méthodes pour la gestion des utilisateurs...

End Class

Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Public Class F_Login
    Dim logincheck = New LoginManager
    Dim crud As New sqliteCRUD()



    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        Dim username As String = TextBox_Identifiant.Text  '.Trim()
        Dim password As String = TextBox_Mp.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Veuillez entrer un nom d'utilisateur et un mot de passe.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If logincheck.VerifyLogin(username, password) = True Then
            MessageBox.Show("Connexion réussie !", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Ici, vous pouvez ajouter le code pour ouvrir le formulaire principal de votre application
            ' Par exemple : MainForm.Show()
            Me.Close() ' Ferme le formulaire de login
        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox_Identifiant.Clear() ' Efface le champ 
            TextBox_Mp.Clear()
            TextBox_Mp.Focus() ' Remet le focus sur le champ du mot de passe
        End If
    End Sub


    Private Sub F_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Mp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True ' Empêche le "ding" sonore
            Button_Ok.PerformClick() ' Simule un clic sur le bouton OK
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Lbl_ActionRegister_Click(sender As Object, e As EventArgs) Handles Lbl_ActionRegister.Click
        Dim formRegiter As New RegisterForm()
        formRegiter.Show()

    End Sub
End Class
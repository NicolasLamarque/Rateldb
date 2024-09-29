

Imports System.Data.SQLite

Public Class RegisterForm
    Dim currentLanguage As String = GetSetting("language")
    Dim CurrentTheme As String = GetSetting("theme")
    Dim LoginManager As New LoginManager()

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ApplyLanguageForm(currentLanguage)
        Applytheme(CurrentTheme)
        TextBoxAdminCode.Visible = False

    End Sub


    Private Sub ApplyLanguageForm(language As String)
        If language = "fr" Then

            Lbl_TitreInfo.Text = "Formulaire d'enregistrement"
            Me.Text = "Formulaire d'enregistrement"
            LabelIdentifiant.Text = "Identifiant :"
            LabelMonPasse.Text = "Mot de Passe :"
            LabelMail.Text = "Courriel :"
        ElseIf language = "en" Then
            Lbl_TitreInfo.Text = "Register form"
            Me.Text = "Register form"
            LabelIdentifiant.Text = "Identifiant :"
            LabelMonPasse.Text = "Password :"
            LabelMail.Text = "Mail :"
        End If
    End Sub

    Private Sub Applytheme(theme As String)
        If theme = "clear" Then
            Me.BackColor = Color.White ' Fond blanc
            Lbl_TitreInfo.ForeColor = Color.Teal ' Texte teal
            Btn_Submit.BackColor = Color.Teal ' Bouton teal
            Btn_Submit.ForeColor = Color.White ' Texte blanc sur bouton teal
            ' Autres contrôles à configurer ici...
        ElseIf theme = "dark" Then
            Me.BackColor = Color.DarkGray ' Fond noir
            Lbl_titre.ForeColor = Color.Teal
            Lbl_TitreInfo.ForeColor = Color.Teal ' Texte blanc
            ' Autres contrôles à configurer ici...
        End If
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        F_Login.Show()
        Me.Close()


    End Sub

    Private Sub CheckBoxAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAdmin.CheckedChanged
        If CheckBoxAdmin.Checked Then
            TextBoxAdminCode.Visible = True
            TextBoxAdminCode.Text = GetSetting("IsAdminCode")

        Else
            TextBoxAdminCode.Visible = False
        End If
    End Sub

    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Dim username As String = TextBoxIdentifiant.Text.Trim()
        Dim password As String = TextBoxMotPasse.Text.Trim()
        Dim email As String = TextBoxMail.Text.Trim()
        Dim isAdmin As Boolean = CheckBoxAdmin.Checked
        Dim adminCode As String = TextBoxAdminCode.Text.Trim()
        ' Vérifications de base
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Vérifier si l'utilisateur existe déjà
            If UserExists(username) Then
                MessageBox.Show("Cet identifiant est déjà utilisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Enregistrer le nouvel utilisateur
            If LoginManager.RegisterUser(username, password, email, isAdmin) Then
                MessageBox.Show("Enregistrement réussi !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                F_Login.Show()
                Me.Close()
            Else
                MessageBox.Show("Échec de l'enregistrement. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur est survenue : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function UserExists(username As String) As Boolean
        Dim connectionString As String = "Data Source=RatelDatabase.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserName", username)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0 ' Retourne vrai si l'utilisateur existe
            End Using
        End Using
    End Function

End Class
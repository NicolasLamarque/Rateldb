Public Class RegisterForm
    Dim currentLanguage As String = GetSetting("language")
    Dim CurrentTheme As String = GetSetting("theme")
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyLanguage(currentLanguage)
        Applytheme(CurrentTheme)
    End Sub


    Private Sub ApplyLanguage(language As String)
        If language = "fr" Then
            Lbl_TitreInfo.Text = "Formulaire d'enregistrement"
            Me.Text = "Formulaire d'enregistrement"
        ElseIf language = "en" Then
            Lbl_TitreInfo.Text = "Register form"
            Me.Text = "Register form"
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
End Class
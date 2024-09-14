Public Class FormAccueil
    Dim resizer As New ImageResizer()

    Private themeManager As ThemeManager

    Public Sub New()
        InitializeComponent()
        themeManager = New ThemeManager()
        themeManager.ApplyTheme(Me) ' Appliquez le thème au démarrage

    End Sub

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newTheme As String = If(themeManager.GetCurrentTheme() = "clair", "sombre", "clair")

        If newTheme = "clair" Then
            Me.btnChangeTheme.Image = resizer.ChangeBtnImageTaille15x15("lightbulb_on")
        Else
            Me.btnChangeTheme.Image = resizer.ChangeBtnImageTaille15x15("lightbulb")
        End If

    End Sub
    Private Sub btnChangeTheme_Click(sender As Object, e As EventArgs) Handles btnChangeTheme.Click




        Dim newTheme As String = If(themeManager.GetCurrentTheme() = "clair", "sombre", "clair")
        themeManager.ChangeTheme(newTheme)
        themeManager.ApplyTheme(Me) ' Réappliquez le thème après le changement
        If newTheme = "clair" Then
            Me.btnChangeTheme.Image = resizer.ChangeBtnImageTaille15x15("lightbulb_on")
        Else
            Me.btnChangeTheme.Image = resizer.ChangeBtnImageTaille15x15("lightbulb")
        End If
    End Sub

    ' Méthode pour changer l'image du bouton en fonction du thème



End Class

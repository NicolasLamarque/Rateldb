Imports System.Data.SQLite

Public Class ThemeManager

    Private currentTheme As String

        Public Sub New()
            ' Chargement du thème par défaut ou du thème sauvegardé
            LoadTheme()
        End Sub

    Private Sub LoadTheme()

        Dim currentTheme = GetSetting("theme")

    End Sub

    Public Sub ApplyTheme(form As Form)
        If currentTheme = "sombre" Then
            form.BackColor = Color.DarkGray
            form.ForeColor = Color.LightGray
            ' Changez d'autres contrôles ici
        Else
            form.BackColor = Color.LightGray
            form.ForeColor = Color.DarkGray
            ' Changez d'autres contrôles ici
        End If
    End Sub

        Public Sub ChangeTheme(newTheme As String)
            currentTheme = newTheme
            SaveTheme(newTheme)
        End Sub

        Private Sub SaveTheme(theme As String)
        SetSetting("theme", theme)
    End Sub

        Public Function GetCurrentTheme() As String
            Return currentTheme
        End Function

End Class


Imports System.Data.SQLite

Public Class BaseForm
    Inherits Form
    Protected themeManager As ThemeManager
    ' Constructeur de la classe de base
    Public Sub New()
        themeManager = New ThemeManager()
        themeManager.ApplyTheme(Me) ' Applique le thème lors de l'initialisation
    End Sub


End Class

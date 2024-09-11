Imports System.Configuration
Imports System.IO
Imports System.Windows.Forms.VisualStyles

Public Class F_Param
    Private Sub F_Param_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ini As New IniFile(Path.Combine(Application.StartupPath, "config.ini"))
        Dim currentTheme As String = ini.ReadValue("AppSettings", "theme")
        If currentTheme = "clair" Then
        ElseIf currentTheme Then

        End If

    End Sub

    Private Sub rbThemeClair_CheckedChanged(sender As Object, e As EventArgs) Handles rbThemeClair.CheckedChanged
        If rbThemeClair.Checked Then
            ' Sauvegarder le thème sélectionné
            SaveTheme("clair")
        End If
    End Sub
    Private Sub rbThemeSombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbThemeSombre.CheckedChanged
        If rbThemeSombre.Checked Then
            ' Sauvegarder le thème sélectionné
            saveTheme("sombre")
        End If
    End Sub


    Public Sub saveTheme(theme As String)
        Dim ini As New IniFile(Path.Combine(Application.StartupPath, "config.ini"))
        ini.WriteValue("AppSettings", "theme", theme)

    End Sub


End Class
Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.IO
Imports System.Windows.Forms.VisualStyles

Public Class F_Param
    Private Sub F_Param_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ini As New IniFile(Path.Combine(Application.StartupPath, "config.ini"))
        Dim currentTheme As String = ini.ReadValue("AppSettings", "theme")
        Dim currentLanguage As String = ini.ReadValue("AppSetting", "language")

        If currentTheme = "clair" Then
            rbThemeClair.Checked = True
        ElseIf currentTheme = "sombre" Then
            rbThemeSombre.Checked = True
        End If

        If currentLanguage = "Fr" Then
            Rb_LanguageFr.Checked = True
        ElseIf currentTheme = "En" Then
            Rb_LaguageEN.Checked = True

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




    Private Sub Rb_LanguageFr_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_LanguageFr.CheckedChanged
        If Rb_LanguageFr.Checked Then
            saveLanguage("Fr")

        End If
    End Sub

    Private Sub Rb_LaguageEN_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_LaguageEN.CheckedChanged
        If Rb_LaguageEN.Checked Then
            saveLanguage("En")
        End If
    End Sub



    Public Sub saveTheme(theme As String)
        Dim ini As New IniFile(Path.Combine(Application.StartupPath, "config.ini"))
        ini.WriteValue("AppSettings", "theme", theme)

    End Sub


    Public Sub saveLanguage(Langue As String)
        Dim ini As New IniFile(Path.Combine(Application.StartupPath, "config.ini"))
        ini.WriteValue("AppSettings", "language", Langue)

    End Sub
End Class
Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.Data.Entity.Infrastructure.Pluralization
Imports System.IO
Imports System.Resources
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports System.Windows.Forms.VisualStyles

Public Class F_Param

    Private Sub F_Param_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDatabase()

        Dim currentTheme As String = GetSetting("theme")
        Dim currentLanguage As String = GetSetting("language")




        If currentTheme = "clair" Then
            rbThemeClair.Checked = True
            Me.Lbl_infoTheme.Text = "Theme :" & currentTheme.ToString
        ElseIf currentTheme = "sombre" Then
            rbThemeSombre.Checked = True
            Me.Lbl_infoTheme.Text = "Theme :" & currentTheme.ToString
        End If

        If currentLanguage = "fr" Then
            Rb_LanguageFr.Checked = True
            Me.Lbl_infoLanguage.Text = "Language actuel : Français" & "(" & currentLanguage.ToString & ")"
        ElseIf currentLanguage = "en" Then
            Rb_LaguageEN.Checked = True
            Me.Lbl_infoLanguage.Text = "Actual language : English" & "(" & currentLanguage.ToString & ")"
        End If

    End Sub

    Private Sub rbThemeClair_CheckedChanged(sender As Object, e As EventArgs) Handles rbThemeClair.CheckedChanged
        If rbThemeClair.Checked Then
            ' Sauvegarder le thème sélectionné
            saveTheme("clair")
        End If
    End Sub
    Private Sub rbThemeSombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbThemeSombre.CheckedChanged
        If rbThemeSombre.Checked Then
            ' Sauvegarder le thème sélectionné
            saveTheme("sombre")
        End If



    End Sub




    Private Sub Rb_LanguageFr_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_LanguageFr.CheckedChanged
        Dim currentTheme As String = GetSetting("language")
        If Rb_LanguageFr.Checked Then
            saveLanguage("fr")

        End If

    End Sub

    Private Sub Rb_LaguageEN_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_LaguageEN.CheckedChanged
        Dim currentLanguage As String = GetSetting("language")
        If Rb_LaguageEN.Checked Then
            saveLanguage("en")

        End If

    End Sub



    Public Sub saveTheme(theme As String)
        SetSetting("theme", theme)

    End Sub


    Public Sub saveLanguage(Langue As String)
        SetSetting("language", Langue)

    End Sub






End Class
Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.Data.Entity.Infrastructure.Pluralization
Imports System.IO
Imports System.Resources
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports System.Windows.Forms.VisualStyles

Public Class F_Param
    Dim currentTheme As String = GetSetting("theme")
    Dim currentLanguage As String = GetSetting("language")
    Dim currentDate As DateTime = DateTime.Now
    Dim formattedDate As String = currentDate.ToString("yyyy-MM-dd HH:mm")

    Private Sub F_Param_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDatabase()


        ApplyTheme(currentTheme)

        ApplyLanguage(currentLanguage)

        ToolStripStatusLabel_time.Text = "Date et heure actuelles : " & formattedDate.ToString()
    End Sub

    Private Sub rbThemeClair_CheckedChanged(sender As Object, e As EventArgs) Handles rbThemeClair.CheckedChanged
        If rbThemeClair.Checked Then
            ' Sauvegarder le thème sélectionné
            saveTheme("clear")
            Dim theme As String = "clear"
            ApplyTheme(theme)
        End If

    End Sub
    Private Sub rbThemeSombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbThemeSombre.CheckedChanged
        If rbThemeSombre.Checked Then
            ' Sauvegarder le thème sélectionné
            saveTheme("dark")
            Dim theme As String = "dark"
            ApplyTheme(theme)
        End If



    End Sub

    Private Sub ApplyTheme(theme As String)
        If theme = "dark" Then
            Me.BackColor = Color.DarkGray
            Me.ForeColor = Color.LightGray
            ' Changez d'autres contrôles ici
        Else
            Me.BackColor = Color.LightGray
            Me.ForeColor = Color.DarkGray
            ' Changez d'autres contrôles ici
        End If

        If theme = "clear" Then
            rbThemeClair.Checked = True
            Me.Lbl_infoTheme.Text = "Theme :" & theme.ToString
        ElseIf theme = "dark" Then
            rbThemeSombre.Checked = True
            Me.Lbl_infoTheme.Text = "Theme :" & theme.ToString
        End If
    End Sub

    Private Sub ApplyLanguage(language As String)
        If language = "fr" Then
            Rb_LanguageFr.Checked = True
            Me.Lbl_infoLanguage.Text = "Language actuel : Français" & "(" & language.ToString & ")"
            Me.Lbl_SousTitre.Text = "Paramêtres"
            Me.Lbl_Titre.Text = "Ratel Db"
            ToolStripStatusLabel_time.Text = "Date et heure actuelles : " & formattedDate.ToString()
        ElseIf language = "en" Then
            Rb_LaguageEN.Checked = True
            Me.Lbl_infoLanguage.Text = "Actual language : English" & "(" & language.ToString & ")"
            Me.Lbl_SousTitre.Text = "Settings"
            Me.Lbl_Titre.Text = "Honey Badger"
            ToolStripStatusLabel_time.Text = "Date & Time : " & formattedDate.ToString()
        End If
    End Sub


    Private Sub Rb_LanguageFr_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_LanguageFr.CheckedChanged
        Dim currentLanguage As String = GetSetting("language")
        If Rb_LanguageFr.Checked Then
            saveLanguage("fr")
            ApplyLanguage("fr")
        End If

    End Sub

    Private Sub Rb_LaguageEN_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_LaguageEN.CheckedChanged
        Dim currentLanguage As String = GetSetting("language")
        If Rb_LaguageEN.Checked Then
            saveLanguage("en")
            ApplyLanguage("en")
        End If

    End Sub



    Public Sub saveTheme(theme As String)
        SetSetting("theme", theme)
    End Sub


    Public Sub saveLanguage(Langue As String)
        SetSetting("language", Langue)
    End Sub



End Class
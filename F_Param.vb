Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.IO
Imports System.Windows.Forms.VisualStyles

Public Class F_Param
    Dim ini As New IniFile(Path.Combine(Application.StartupPath, "config.ini"))
    Private Sub F_Param_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim currentTheme As String = ini.ReadValue("AppSettings", "theme")
        Dim currentLanguage As String = ini.ReadValue("AppSettings", "language")
        MessageBox.Show(Path.Combine(Application.StartupPath, "config.ini"))


        If currentTheme = "clair" Then
            rbThemeClair.Checked = True
        ElseIf currentTheme = "sombre" Then
            rbThemeSombre.Checked = True
        End If

        If currentLanguage = "Fr" Then
            Rb_LanguageFr.Checked = True
        ElseIf currentLanguage = "En" Then
            Rb_LaguageEN.Checked = True

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
        Dim themeread As String = ini.ReadValue("AppSettings", "theme")
        MessageBox.Show(themeread)

    End Sub




    Private Sub Rb_LanguageFr_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_LanguageFr.CheckedChanged
        Dim currentTheme As String = ini.ReadValue("AppSettings", "theme")
        If Rb_LanguageFr.Checked Then
            saveLanguage("Fr")

        End If

    End Sub

    Private Sub Rb_LaguageEN_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_LaguageEN.CheckedChanged
        Dim currentTheme As String = ini.ReadValue("AppSettings", "theme")
        If Rb_LaguageEN.Checked Then
            saveLanguage("En")

        End If
        Me.Lbl_infoTheme.Text = "Actual theme:" & GetSettingItem(Path.Combine(Application.StartupPath, "config.ini"), "language")
    End Sub



    Public Sub saveTheme(theme As String)

        ini.WriteValue("AppSettings", "theme", theme)

    End Sub


    Public Sub saveLanguage(Langue As String)

        ini.WriteValue("AppSettings", "language", Langue)
    End Sub

    Public Function ReadValueWithDebug(section As String, key As String) As String
        ' Lire la valeur avec la méthode existante
        Dim value As String = ini.ReadValue(section, key)

        ' Afficher des informations de débogage
        If String.IsNullOrEmpty(value) Then
            MessageBox.Show($"La clé '{key}' dans la section '{section}' est introuvable ou vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show($"Valeur lue pour '{key}' dans la section '{section}': {value}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Retourner la valeur lue
        Return value
    End Function

    Public Function GetSettingItem(ByVal File As String, ByVal Identifier As String) As String
        Dim S As New IO.StreamReader(File) : Dim Result As String = ""
        Do While (S.Peek <> -1)
            Dim Line As String = S.ReadLine
            If Line.ToLower.StartsWith(Identifier.ToLower & "=") Then
                Result = Line.Substring(Identifier.Length + 2)
            End If
        Loop
        Return Result
    End Function

End Class
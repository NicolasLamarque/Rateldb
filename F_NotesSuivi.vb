Imports System.Globalization

Public Class F_NotesSuivi
    Dim currentLanguage As String = GetSetting("language")
    Dim CurrentTheme As String = GetSetting("theme")

    Private fontManager As FontClass
    Private Sub F_NotesSuivi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Appliquer les paramètres de langue et de thème
        ApplyLanguageForm(currentLanguage)
        Applytheme(CurrentTheme)

        ' Définir la culture française pour le format de date
        Dim frCulture As New CultureInfo("fr-FR")
        SetDateTimePickerFormat(DateTimePicker_Intervention)
        SetDateTimePickerFormat(DateTimePicker_Saisie)

        ' Initialiser le gestionnaire de polices et alimenter la ComboBox
        fontManager = New FontClass()
        ComboBoxFont.DataSource = fontManager.Families
        fontManager.SetSelectedFont(ComboBoxFont, "Calibri")
    End Sub

    ' Méthode pour appliquer le format de date à un DateTimePicker
    Private Sub SetDateTimePickerFormat(dateTimePicker As DateTimePicker)
        dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm"
        dateTimePicker.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub ApplyLanguageForm(language As String)
        Dim CurrentTheme As String = GetSetting("theme")
        If language = "fr" Then
            Me.Text = "Formulaire de Notes"
            If CurrentTheme = "clear" Then
                LabelInfosTheme.Text = "Thème : Clair"
            Else
                LabelInfosTheme.Text = "thème : Sombre"
            End If
        ElseIf language = "en" Then
            Me.Text = "Note Form"
            If CurrentTheme = "clear" Then
                LabelInfosTheme.Text = "Theme : Clear"
            Else
                LabelInfosTheme.Text = "Theme : Dark"
            End If
        End If
    End Sub

    Private Sub Applytheme(theme As String)
        If theme = "clear" Then
            Me.BackColor = Color.LightGray ' Fond pale
            ' Autres contrôles à configurer ici...
        ElseIf theme = "dark" Then
            Me.BackColor = Color.DarkGray ' Fond foncé
            ' Autres contrôles à configurer ici...
        End If
    End Sub

    ' Appliquer la police à la sélection du RichTextBox
    Private Sub ApplyFontToSelection(fontName As String)
        Dim rtb As RichTextBox = CType(Me.Controls("richTextBox1"), RichTextBox) ' Assurez-vous que vous avez un RichTextBox nommé 'richTextBox1'
        If rtb.SelectionFont IsNot Nothing Then
            Dim newFont As New Font(fontName, rtb.SelectionFont.Size, rtb.SelectionFont.Style)
            rtb.SelectionFont = newFont
        End If
    End Sub

    Private Sub ComboBoxFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFont.SelectedIndexChanged
        Dim selectedFont As String = ComboBoxFont.SelectedItem.ToString()
        ApplyFontToSelection(selectedFont)
    End Sub

    Private Sub Btn_bold_Click(sender As Object, e As EventArgs) Handles Btn_bold.Click
        ToggleBold(RichTextBox1)
    End Sub

    Private Sub Btn_Italic_Click(sender As Object, e As EventArgs) Handles Btn_Italic.Click
        ToggleItalic(RichTextBox1)
    End Sub

    Private Sub Btn_Underscore_Click(sender As Object, e As EventArgs) Handles Btn_Underscore.Click
        ToggleUnderline(RichTextBox1)
    End Sub

    Private Sub BtnFontColorPicker_Click(sender As Object, e As EventArgs) Handles BtnFontColorPicker.Click
        ChangeSelectionColor(RichTextBox1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddBullets(RichTextBox1)
    End Sub
End Class
Module ModuleGestionTexte
    ' Fonctions de formatage du texte
    Public Sub ToggleBold(rtb As RichTextBox)
        If rtb.SelectionFont IsNot Nothing Then
            Dim currentFont As Font = rtb.SelectionFont
            Dim newFont As FontStyle = If(currentFont.Bold, FontStyle.Regular, FontStyle.Bold)
            rtb.SelectionFont = New Font(currentFont, newFont)
        End If
    End Sub

    Public Sub ToggleItalic(rtb As RichTextBox)
        If rtb.SelectionFont IsNot Nothing Then
            Dim currentFont As Font = rtb.SelectionFont
            Dim newFont As FontStyle = If(currentFont.Italic, FontStyle.Regular, FontStyle.Italic)
            rtb.SelectionFont = New Font(currentFont, newFont)
        End If
    End Sub

    Public Sub ToggleUnderline(rtb As RichTextBox)
        If rtb.SelectionFont IsNot Nothing Then
            Dim currentFont As Font = rtb.SelectionFont
            Dim newFont As FontStyle = If(currentFont.Underline, FontStyle.Regular, FontStyle.Underline)
            rtb.SelectionFont = New Font(currentFont, newFont)
        End If
    End Sub

    ' Fonction pour ajouter des puces


    ' Fonction pour ajouter des puces
    Public Sub AddBullets(rtb As RichTextBox)
        Dim bulletSymbol As String = "• " ' Symbole de puce
        Dim selectionStart As Integer = rtb.SelectionStart
        Dim selectionLength As Integer = rtb.SelectionLength

        ' Diviser le texte sélectionné en lignes
        Dim selectedText As String = rtb.SelectedText
        Dim lines As String() = selectedText.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        ' Ajouter une puce à chaque ligne
        For i As Integer = 0 To lines.Length - 1
            lines(i) = bulletSymbol & lines(i)
        Next

        ' Réinsérer les lignes modifiées
        rtb.SelectedText = String.Join(Environment.NewLine, lines)

        ' Rétablir la sélection
        rtb.SelectionStart = selectionStart
        rtb.SelectionLength = selectionLength + lines.Length * bulletSymbol.Length
    End Sub

    ' Fonction pour changer la police de caractères
    Private Sub ChangeFontFamily(rtb As RichTextBox, fontFamilyName As String)
        If rtb.SelectionFont IsNot Nothing Then
            Dim currentFont As Font = rtb.SelectionFont
            rtb.SelectionFont = New Font(fontFamilyName, currentFont.Size, currentFont.Style)
        End If
    End Sub
    Public Sub ChangeSelectionColor(rtb As RichTextBox)
        ' Créez une instance de ColorDialog
        Dim colorDialog As New ColorDialog()

        ' Définir la couleur initiale du dialogue sur la couleur de sélection actuelle
        colorDialog.Color = rtb.SelectionColor

        ' Affichez le dialogue et vérifiez si l'utilisateur a cliqué sur OK
        If colorDialog.ShowDialog() = DialogResult.OK Then
            ' Changez la couleur de la sélection à celle choisie par l'utilisateur
            rtb.SelectionColor = colorDialog.Color
        End If
    End Sub
End Module

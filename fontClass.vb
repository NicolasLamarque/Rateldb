Imports System.Drawing.Text

Public Class FontClass
    ' Liste des familles de polices
    Private ReadOnly fontFamilies As List(Of String)

    ' Propriété pour accéder à la liste des familles de polices
    Public ReadOnly Property Families As List(Of String)
        Get
            Return fontFamilies
        End Get
    End Property

    Public Sub New()
        ' Initialiser la liste des familles de polices
        fontFamilies = New List(Of String)()
        LoadInstalledFonts()
    End Sub

    ' Méthode pour charger les polices installées
    Private Sub LoadInstalledFonts()
        Using fontCollection As New InstalledFontCollection()
            Dim families As FontFamily() = fontCollection.Families
            For Each family As FontFamily In families
                fontFamilies.Add(family.Name)
            Next
        End Using
    End Sub

    ' Fonction pour positionner le curseur sur une police choisie dans la ComboBox
    Public Sub SetSelectedFont(comboBox As ComboBox, fontName As String)
        Dim index As Integer = fontFamilies.IndexOf(fontName)
        If index <> -1 Then
            comboBox.SelectedIndex = index
        Else
            comboBox.SelectedIndex = -1 ' Réinitialiser si la police n'est pas trouvée
        End If
    End Sub
End Class


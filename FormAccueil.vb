Imports System.Windows.Forms.VisualStyles

Public Class FormAccueil
    Dim clientManager As New ClientManager()
    Dim resizer As New ImageResizer()

    Private themeManager As ThemeManager

    Public Sub New()
        InitializeComponent()
        themeManager = New ThemeManager()
        themeManager.ApplyTheme(Me) ' Appliquez le thème au démarrage

    End Sub

    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button04_Click(sender As Object, e As EventArgs) Handles Button04.Click
        ' Créer un nouveau client
        Dim newClient As New Dictionary(Of String, Object) From {
    {"NumeroAssuranceMaladie", "123456789"},
    {"Nom", "Dupont"},
    {"Prenom", "Jean"},
    {"DateNaissance", #01/01/1980#},
    {"Sexe", "Masculin"}
}

        ' Enregistrer le nouveau client
        clientManager.SetClient(newClient)
        MessageBox.Show(newClient.ToString())
    End Sub

End Class

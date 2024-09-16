Imports System.Data.SQLite

Imports System.Drawing
Public Class Form1
    Private crud As New sqliteCRUD ' Déclaration de la variable
    Private bindingSource As BindingSource
    Private records As DataTable

    Dim Theme As String = GestionDesParametres.GetSetting("theme")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MessageBox.Show(Theme) pour valider theme

        bindingSource = New BindingSource()

        Try
            ' Récupérer tous les enregistrements de la table "Clients"
            Dim fieldsToDisplay As String = "Nom, Prenom, NumeroAssuranceMaladie, NoDossierCLSC_EN, Adresse, CodePostal, Secteur, sexe, Telephone, Cellulaire, Courriel, Statut, Pivot, Note"
            ' Spécifiez les champs que vous souhaitez afficher
            records = crud.GetAllRecords("Clients", fieldsToDisplay)
            bindingSource.DataSource = records

            ' Lier le BindingNavigator au BindingSource
            BindingNavigator1.BindingSource = bindingSource

            ' Lier les TextBox au BindingSource
            txtNom.DataBindings.Add("Text", bindingSource, "Nom")
            txtPrenom.DataBindings.Add("Text", bindingSource, "Prenom")
        Catch ex As Exception
            MessageBox.Show($"Erreur : {ex.Message}")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        ' Charger une image dans le PictureBox
        Try
            ' Remplacez le chemin par le chemin de votre image
            Dim imagePath As String
            PictureBox1.Image = Image.FromFile(imagePath) ' Charger l'image depuis le fichier
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement de l'image : " & ex.Message)
        End Try
    End Sub
End Class
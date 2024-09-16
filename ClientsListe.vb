Imports System.Data.SQLite


Public Class ClientsListe
    Dim crudManager As New sqliteCRUD()
    Private Sub ClientsListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim crudManager As New sqliteCRUD()

        ' Récupérer certains champs de la table Clients
        Dim fieldsToDisplay As String = "ID, Nom, Prenom, DateNaissance" ' Spécifiez les champs que vous souhaitez afficher
        Dim clientsDataTable As DataTable = crudManager.GetAllRecords("Clients", fieldsToDisplay)

        ' Lier le DataTable au DataGridView
        DataGridView_clients.DataSource = clientsDataTable
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
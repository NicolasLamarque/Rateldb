
Public Class MainForm

    Dim currentLanguage As String = GetSetting("language")
    Dim CurrentTheme As String = GetSetting("theme")
    Dim BindingSource1 As New BindingSource

    Dim sqlitecrudOp As New sqliteCRUD()
    Private currentPosition As Integer = 0
    Dim clientTable As DataTable = sqlitecrudOp.GetAllRecords("Clients")


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub ApplyLanguageForm(language As String)
        If language = "fr" Then

            Lbl_TitreInfo.Text = "Formulaire Principal"
            Me.Text = "Formulaire principal"

            LabelGroupIdent.Text = "Identité"

            labelNom.Text = "Nom :"
            labelPrenom.Text = "Prénom :"
            labelMail.Text = "Courriel :"
        ElseIf language = "en" Then


            Lbl_TitreInfo.Text = "Register form"
            Me.Text = "Register form"

            LabelGroupIdent.Text = "Identity"

            labelNom.Text = "Lastname :"
            labelPrenom.Text = "Firstname :"
            labelMail.Text = "Mail :"
        End If
    End Sub

End Class
Public Class ClassNote

    Private _Id As Integer
    Private _Mode As String
    Private _LieuIntervention As String
    Private _Contenu As String
    Private _DateCreation As Date
    Private _DateIntervention As Date

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            If _Id <> value Then
                _Id = value
            End If
        End Set
    End Property

    Public Property ClientId As Integer
    Private _Titre As String

    Public Property Titre As String
        Get
            Return _Titre
        End Get
        Set(value As String)
            If _Titre <> value Then
                _Titre = value
            End If
        End Set
    End Property

    Public Property Mode As String
        Get
            Return _Mode
        End Get
        Set(value As String)
            _Mode = value?.Trim()
        End Set
    End Property


    ' Propriété pour LieuIntervention
    Public Property LieuIntervention As String
        Get
            Return _LieuIntervention
        End Get
        Set(value As String)
            If _LieuIntervention <> value Then
                _LieuIntervention = value
            End If
        End Set
    End Property

    ' Propriété pour Contenu
    Public Property Contenu As String
        Get
            Return _Contenu
        End Get
        Set(value As String)
            If _Contenu <> value Then
                _Contenu = value
            End If
        End Set
    End Property

    ' Propriété pour DateCreation
    Public Property DateCreation As Date
        Get
            Return _DateCreation
        End Get
        Set(value As Date)
            If _DateCreation <> value Then
                _DateCreation = value
            End If
        End Set
    End Property

    ' Propriété pour DateIntervention
    Public Property DateIntervention As Date
        Get
            Return _DateIntervention
        End Get
        Set(value As Date)
            If _DateIntervention <> value Then
                _DateIntervention = value
            End If
        End Set
    End Property


End Class

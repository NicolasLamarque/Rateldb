
Imports System.Net.Security
Imports System.Runtime.InteropServices.WindowsRuntime

Public Class Client
    ' Champ privé pour l'ID
    Private _id As Integer

    ' Propriété ID en lecture seule
    Public ReadOnly Property ID As Integer
        Get
            Return _id
        End Get
    End Property
    ' Méthode interne pour définir l'ID (utilisée lors du chargement depuis la base de données)
    Friend Sub SetID(value As Integer)
        If _id = 0 AndAlso value > 0 Then
            _id = value
        Else
            Throw New InvalidOperationException("L'ID ne peut être défini qu'une seule fois et doit être positif.")
        End If
    End Sub

    Private _NumeroAssuranceMaladie As String
    ' Propriétés publiques avec validation

    Public Property NumeroAssuranceMaladie As String
        Get
            Return _NumeroAssuranceMaladie
        End Get
        Set(value As String)
            ' Permet des valeurs vides ou nulles
            _NumeroAssuranceMaladie = value?.Trim()
        End Set
    End Property

    Private _NoDossierCLSC_EN As String
    ' Propriétés publiques avec validation
    Public Property NoDossierCLSC_EN As String
        Get
            Return _NoDossierCLSC_EN
        End Get
        Set(value As String)
            ' Permet des valeurs vides ou nulles
            _NoDossierCLSC_EN = value?.Trim()
        End Set
    End Property
    Private _NoHCM As String
    Public Property NoHCM As String
        Get
            Return _NoHCM
        End Get
        Set(value As String)
            ' Permet des valeurs vides ou nulles
            _NoDossierCLSC_EN = value?.Trim()
        End Set
    End Property

    Private _NoCHAUR As String
    ' Propriétés publiques avec validation
    Public Property NoCHAUR As String
        Get
            Return _NoCHAUR
        End Get
        Set(value As String)
            _NoCHAUR = value?.Trim()
        End Set
    End Property


    Private _Nom As String
    ' Propriétés publiques avec validation
    Public Property Nom As String
        Get
            Return _Nom
        End Get
        Set(value As String)
            _Nom = value?.Trim()
        End Set
    End Property

    Private _Prenom As String

    Public Property Prenom As String
        Get
            Return _Prenom
        End Get
        Set(value As String)
            _Prenom = value?.Trim()
        End Set
    End Property

    Private _dateNaissanceString As String

    Public Property DateNaissance As Date?
        Get
            If Date.TryParse(_dateNaissanceString, Nothing) Then
                Return Date.Parse(_dateNaissanceString)
            Else
                Return Nothing
            End If
        End Get
        Set(value As Date?)
            If value.HasValue Then
                _dateNaissanceString = value.Value.ToString("yyyy-MM-dd")
            Else
                _dateNaissanceString = Nothing
            End If
        End Set
    End Property

    ' Propriété calculée pour l'âge
    Public ReadOnly Property Age As Integer?
        Get
            If DateNaissance.HasValue Then
                Dim CalcAge As Integer = Now.Year - DateNaissance.Value.Year

                ' Vérifier si l'anniversaire n'est pas encore passé cette année
                If Now < DateNaissance.Value.AddYears(Age) Then
                    CalcAge -= 1
                End If

                Return CalcAge
            Else
                Return Nothing
            End If
        End Get
    End Property
    Private _sexe As String
    Public Property Sexe As String
        Get
            Return _sexe

        End Get
        Set(value As String)
            Dim sexeNormalise = value?.Trim().ToLower()
            If sexeNormalise = "male" OrElse sexeNormalise = "female" OrElse sexeNormalise = "autre" Then
                _sexe = value?.Trim
                ' Stocker la valeur originale (avec la casse d'origine), mais sans les espaces inutiles
            ElseIf String.IsNullOrWhiteSpace(value) Then
                _sexe = Nothing ' Permettre une valeur null/vide si c'est acceptable dans votre cas
            Else
                Throw New ArgumentException("La valeur pour Sexe doit être 'Male', 'Female' ou 'Autre'.")
            End If
        End Set
    End Property
    Private _Adresse As String
    Public Property Adresse As String
        Get
            Return _Adresse

        End Get
        Set(value As String)
            _Adresse = value?.Trim

        End Set
    End Property
    Private _CodePostal As String
    Public Property CodePostal As String
        Get
            Return _CodePostal
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                _CodePostal = Nothing
            Else
                ' Supprimer tous les espaces et mettre en majuscules
                Dim codeNormalise = value.Replace(" ", "").ToUpper()

                ' Vérifier si le code postal a le bon format
                If System.Text.RegularExpressions.Regex.IsMatch(codeNormalise, "^[ABCEGHJ-NPRSTVXY]\d[ABCEGHJ-NPRSTV-Z]\d[ABCEGHJ-NPRSTV-Z]\d$") Then
                    ' Reformater le code postal avec un espace au milieu
                    _CodePostal = codeNormalise.Insert(3, " ")
                Else
                    Throw New ArgumentException("Le code postal doit être au format valide pour le Canada (par exemple, 'H3B 4G7').")
                End If
            End If
        End Set
    End Property

    Private _Secteur As String
    Public Property Secteur As String
        Get
            Return _Secteur
        End Get
        Set(value As String)
            _Secteur = value?.Trim()
        End Set
    End Property
    'privée
    Private _Telephone As String
    'Publique
    Public Property Telephone As String
        Get
            Return _Telephone
        End Get
        Set(value As String)
            _Telephone = value?.Trim()
        End Set
    End Property

    'Privée
    Private _Cellulaire As String
    'publique
    Public Property Cellulaire As String
        Get
            Return _Cellulaire
        End Get
        Set(value As String)
            _Cellulaire = value?.Trim()
        End Set
    End Property

    'Privée
    Private _Courriel As String
    Public Property Courriel As String
        Get
            Return _Courriel
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                _Courriel = Nothing
            Else
                ' Utiliser une expression régulière pour valider le format de l'e-mail
                Dim emailRegex As New System.Text.RegularExpressions.Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
                If emailRegex.IsMatch(value.Trim()) Then
                    _Courriel = value.Trim()
                Else
                    Throw New ArgumentException("L'adresse e-mail fournie n'est pas valide.")
                End If
            End If
        End Set
    End Property

    'Privée
    Private _DateInscription As Date
    'Publique
    Public Property DateInscription As Date?
        Get
            Dim result As Date
            If Date.TryParse(_DateInscription, result) Then
                Return result
            Else
                Return Nothing
            End If
        End Get
        Set(value As Date?)
            If value.HasValue Then
                _DateInscription = value.Value.ToString("yyyy-MM-dd")
            Else
                _DateInscription = Nothing
            End If
        End Set
    End Property


    'Privée
    Private _Statut As String
    'Publique
    Public Property Statut As Boolean
        Get
            Return _Statut
        End Get
        Set(value As Boolean)
            If _Statut <> value Then
                _Statut = value

            End If
        End Set
    End Property


    'Privée
    Private _Pivot As String
    'Publique
    Public Property Pivot As String
        Get
            Return _Pivot
        End Get

        Set(value As String)
            If value = "Oui" OrElse value = "Non" Then
                _Pivot = value
            Else
                Throw New ArgumentException("La valeur doit être 'Oui' ou 'Non'.")
            End If
        End Set
    End Property

    'Private
    Private _Note As String
    'Publique
    Public Property Note As String
        Get
            Return _Note
        End Get
        Set(value As String)
            _Note = value?.Trim()
        End Set
    End Property
    'Privée 
    Private _NomPrestataire As String
    'public
    Public Property NomPrestataire As String
        Get
            Return _NomPrestataire
        End Get
        Set(value As String)
            _NomPrestataire = value?.Trim()
        End Set
    End Property

    'Private
    Private _CodeSante As String
    'Publique
    Public Property CodeSante As String
        Get
            Return _CodeSante
        End Get
        Set(value As String)

        End Set
    End Property
    'Private
    Private _Nationalite As String
    'Publique
    Public Property Nationalite As String
        Get
            Return _Nationalite
        End Get
        Set(value As String)
            _Nationalite = value?.Trim
        End Set
    End Property
    'Privée
    Private _Langue As String
    'Publique
    Public Property Langue As String
        Get
            Return _Langue

        End Get
        Set(value As String)
            If value = "Francais" OrElse value = "Anglais" OrElse value = "Espagnol" OrElse
                value = "Italien" OrElse value = "Allemand" OrElse value = "Portuguais" OrElse
                value = "Chinois" OrElse value = "Arabe" OrElse value = "Russe" OrElse value = "Inuktituk" OrElse
                value = "Cree" OrElse value = "Mohawk" OrElse value = "Autre" Then
                _Langue = value
            Else
                Throw New ArgumentException("La valeur doit être une langue de la liste")
            End If
        End Set
    End Property
    'Privé
    Private _Langue_2eme As String
    'publique
    Public Property Langue_2eme As String
        Get
            Return _Langue_2eme

        End Get
        Set(value As String)
            If value = "Francais" OrElse value = "Anglais" OrElse value = "Espagnol" OrElse
                value = "Italien" OrElse value = "Allemand" OrElse value = "Portuguais" OrElse
                value = "Chinois" OrElse value = "Arabe" OrElse value = "Russe" OrElse value = "Inuktituk" OrElse
                value = "Cree" OrElse value = "Mohawk" OrElse value = "Autre" Then
                _Langue_2eme = value
            Else
                Throw New ArgumentException("La valeur doit être une langue de la liste")
            End If
        End Set
    End Property
    'Privée
    Private _DateDernierSuivi As Date
    'publique
    Public Property DateDernierSuivi As Date?
        Get
            Dim result As Date
            If Date.TryParse(_DateInscription, result) Then
                Return result
            Else
                Return Nothing
            End If
        End Get
        Set(value As Date?)
            If value.HasValue Then
                _DateInscription = value.Value.ToString("yyyy-MM-dd")
            Else
                _DateInscription = Nothing
            End If
        End Set
    End Property
    'Privée
    Private _TypeClient As String
    'Publique
    Public Property TypeClient As String
        Get

        End Get
        Set(value As String)

        End Set
    End Property
    'Privé
    Private _medications As String
    'Publique
    Public Property Medications As String
        Get
            Return _medications
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                _medications = "Aucun"
            Else
                _medications = value.Trim()
            End If
        End Set
    End Property
    'Privée
    Private _allergies As String
    'Publique
    Public Property Allergies As String
        Get
            Return _allergies
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                _allergies = "Aucune"
            Else
                _allergies = value.Trim()
            End If
        End Set
    End Property
    'Privé

    Private _niveauAutonomie As String
    'Publique
    Public Property NiveauAutonomie As String
        Get
            Return _niveauAutonomie
        End Get
        Set(value As String)
            Dim niveauxValides() As String = {"Autonome", "Semi-autonome", "Dépendant"}
            If niveauxValides.Contains(value) Then
                _niveauAutonomie = value
            Else
                Throw New ArgumentException("Niveau d'autonomie non valide")
            End If
        End Set
    End Property
    'Privée

    Private _niveauDeSoins As String
    ' Publique
    Public Property NiveauDeSoins As String
        Get
            Return _niveauDeSoins
        End Get
        Set(value As String)
            Dim niveauxValides() As String = {"A", "B", "C", "D", "Inconnu"}
            If niveauxValides.Contains(value) Then
                _niveauDeSoins = value
            Else
                Throw New ArgumentException("Niveau de soins non valide")
            End If
        End Set
    End Property
    'Privée
    Private _servicesRequis As String
    'Publique
    Public Property ServicesRequis As String
        Get
            Return _servicesRequis
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                _servicesRequis = "Aucun service requis"
            Else
                _servicesRequis = value.Trim()
            End If
        End Set
    End Property
    'Privée 
    Private _dateAdmissionRPA As Date?
    'Publique
    Public Property DateAdmissionRPA As Date?
        Get
            Return _dateAdmissionRPA
        End Get
        Set(value As Date?)
            If value.HasValue AndAlso value.Value > Date.Today Then
                Throw New ArgumentException("La date d'admission ne peut pas être dans le futur.")
            Else
                _dateAdmissionRPA = value
            End If
        End Set
    End Property
    'Privée
    Private _nomRPA As String
    'Publique
    Public Property NomRPA As String
        Get
            Return _nomRPA
        End Get
        Set(value As String)
            _nomRPA = value.Trim()
        End Set
    End Property
    '
    Private _codeRPA As String
    Public Property CodeRPA As String
        Get
            Return _codeRPA
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New ArgumentException("Le code RPA ne peut pas être vide.")
            ElseIf value.Length <> 4 Then
                Throw New ArgumentException("Le code RPA doit avoir 4 caractères.")
            Else
                _codeRPA = value.ToUpper()
            End If
        End Set
    End Property
    'Privée
    Private _ATCDSuicide As Boolean
    'Publique
    Public Property ATCDSuicide As Boolean
        Get
            Return _ATCDSuicide
        End Get
        Set(value As Boolean)
            If _ATCDSuicide <> value Then
                _ATCDSuicide = value

            End If
        End Set
    End Property
    'Privée
    Private _ViolenceConjugale As Boolean
    ' Publique
    Public Property ViolenceConjugale As Boolean
        Get
            Return _ViolenceConjugale
        End Get
        Set(value As Boolean)
            If _ViolenceConjugale <> value Then
                _ViolenceConjugale = value
            End If
        End Set
    End Property
    'Privée
    Private _Itinerance
    'Publique
    Public Property Itinerance As Boolean
        Get
            Return _Itinerance
        End Get
        Set(value As Boolean)
            If _Itinerance <> value Then
                _Itinerance = value
            End If
        End Set
    End Property
    'privé
    Private _marginalite As Boolean
    'Publique
    Public Property Marginalite As Boolean
        Get
            Return _marginalite
        End Get
        Set(value As Boolean)
            If _marginalite <> value Then
                _marginalite = value
            End If
        End Set
    End Property
    'Private
    Private _RisqueDesafiliation As Boolean
    'Publique
    Public Property RisqueDesafiliation As Boolean
        Get
            Return _RisqueDesafiliation
        End Get
        Set(value As Boolean)
            If _RisqueDesafiliation <> value Then
                _RisqueDesafiliation = value
            End If
        End Set
    End Property
    'privée
    Private _Depression As Boolean
    'Publique
    Public Property Depression As Boolean
        Get
            Return _Depression
        End Get
        Set(value As Boolean)
            If _Depression <> value Then
                _Depression = value

            End If
        End Set
    End Property
    'Privée 
    Private _Anxiete As Boolean
    'Publique
    Public Property Anxiete As Boolean
        Get
            Return _Anxiete
        End Get
        Set(value As Boolean)
            If _Anxiete <> value Then
                _Anxiete = value

            End If
        End Set
    End Property
    'Privée
    Private _TroublesAlimentaires As Boolean
    'Publique
    Public Property TroublesAlimentaires As Boolean
        Get
            Return _TroublesAlimentaires
        End Get
        Set(value As Boolean)
            If _TroublesAlimentaires <> value Then
                _TroublesAlimentaires = value
            End If
        End Set
    End Property

    'Privée
    Private _PTSD As Boolean
    'Publique
    Public Property PTSD As Boolean
        Get
            Return _PTSD
        End Get
        Set(value As Boolean)
            If _PTSD <> value Then
                _PTSD = value
            End If

        End Set
    End Property
    'privée
    Private _MaladieChronique As Boolean
    'publique
    Public Property MaladieChronique As Boolean
        Get
            Return _MaladieChronique
        End Get
        Set(value As Boolean)
            If _MaladieChronique <> value Then
                _MaladieChronique = value
            End If
        End Set
    End Property
    'privée
    Private _AbusSubstance As Boolean

    'publique
    Public Property AbusSubstance As Boolean
        Get
            Return _AbusSubstance
        End Get
        Set(value As Boolean)
            If _AbusSubstance <> value Then
                _AbusSubstance = value
            End If
        End Set
    End Property

    'privée
    Private _Tutelle As Boolean
    'publique
    Public Property Tutelle As Boolean
        Get
            Return _Tutelle

        End Get
        Set(value As Boolean)
            If _Tutelle <> value Then
                _Tutelle = value
            End If
        End Set
    End Property
    'Privée
    Private _TutelleNiveau As String

    'Publique
    Public Property TutelleNiveau As String
        Get
            Return _TutelleNiveau
        End Get
        Set(value As String)
            _TutelleNiveau = value?.Trim()
        End Set
    End Property
    'private 
    Private _MandatDeProtection As Boolean
    '
    Public Property MandatDeProtection As Boolean
        Get
            Return _MandatDeProtection
        End Get
        Set(value As Boolean)
            If _MandatDeProtection <> value Then
                _MandatDeProtection = value
            End If
        End Set
    End Property
    'Privée
    Private _HomologationMandat As String
    'Publique
    Public Property HomologuationMandat As String
        Get
            Return _HomologationMandat
        End Get
        Set(value As String)
            _HomologationMandat = value?.Trim()
        End Set
    End Property
    'Privée
    Private _MandataireBien As String
    'Publique
    Public Property MandataireBien As String
        Get
            Return _MandataireBien

        End Get
        Set(value As String)
            _MandataireBien = value?.Trim()
        End Set
    End Property
    'Privée
    Private _MandatairePersonne As String
    'Publique
    Public Property MandatairePersonne As String
        Get
            Return _MandatairePersonne

        End Get
        Set(value As String)
            _MandatairePersonne = value?.Trim()
        End Set
    End Property
    'Privée
    Private _ProcurationBancaireSeule As Boolean
    'Publique
    Public Property ProcurationBancaireSeule As Boolean
        Get
            Return _ProcurationBancaireSeule

        End Get
        Set(value As Boolean)
            If _ProcurationBancaireSeule <> value Then
                _ProcurationBancaireSeule = value
            End If
        End Set
    End Property
    'Privée
    Private _ProcurationNotaire As Boolean
    'Publique
    Public Property ProcurationNotaire As Boolean
        Get
            Return _ProcurationNotaire
        End Get
        Set(value As Boolean)
            If _ProcurationNotaire <> value Then
                _ProcurationNotaire = value
            End If
        End Set
    End Property
    'Privée 
    Private _SoutienFamilial As Boolean
    'Publique
    Public Property SoutienFamilial As Boolean
        Get
            Return _SoutienFamilial
        End Get
        Set(value As Boolean)
            If _SoutienFamilial <> value Then
                _SoutienFamilial = value
            End If
        End Set
    End Property
    'Privée
    Private _SuiviPsycho As Boolean
    'Publique
    Public Property SuiviPsycho As Boolean
        Get
            Return _SuiviPsycho
        End Get
        Set(value As Boolean)
            If _SuiviPsycho <> value Then
                _SuiviPsycho = value
            End If
        End Set
    End Property
    'Privée
    Private _InterventionCrise As Boolean
    'Publique
    Public Property InterventionCrise As Boolean
        Get
            Return _InterventionCrise
        End Get
        Set(value As Boolean)
            If _InterventionCrise <> value Then
                _InterventionCrise = value
            End If
        End Set
    End Property
    'Privée
    Private _ProgrammeFinancierRepit As Boolean
    'Publique
    Public Property ProgrammeFinancierRepit As Boolean
        Get
            Return _ProgrammeFinancierRepit
        End Get
        Set(value As Boolean)
            If _ProgrammeFinancierRepit <> value Then
                _ProgrammeFinancierRepit = value
            End If
        End Set
    End Property
    'Privée
    Private _RepitCHSLD As Boolean
    'Publique
    Public Property RepitCHSLD As Boolean
        Get
            Return _RepitCHSLD
        End Get
        Set(value As Boolean)
            If _RepitCHSLD <> value Then
                _RepitCHSLD = value
            End If
        End Set
    End Property
    'Privée
    Private _RepitGilleCarles As Boolean
    'Publique
    Public Property RepitGilleCarles As Boolean
        Get
            Return _RepitGilleCarles
        End Get
        Set(value As Boolean)
            If _RepitGilleCarles <> value Then
                _RepitGilleCarles = value
            End If
        End Set
    End Property

    'Privée
    Private _RPA As Boolean
    'Publique
    Public Property RPA As Boolean
        Get
            Return _RPA
        End Get
        Set(value As Boolean)
            If _RPA <> value Then
                _RPA = value
            End If
        End Set
    End Property
    'Privée
    Private _ActivitesSociale As Boolean
    'Publique
    Public Property ActivitesSociales As Boolean
        Get
            Return _ActivitesSociale
        End Get
        Set(value As Boolean)
            If _ActivitesSociale <> value Then
                _ActivitesSociale = value
            End If
        End Set
    End Property
    'Privée
    'Publique
    Public Property AideFinanciere As Boolean
    'Privée
    'Publique
    Public Property AideCoop As Boolean
    'Privée
    'Publique
    Public Property AntecedentsSuicide As Boolean
    'Privée
    'Publique
    Public Property ProblemesSanteMentale As Boolean
    'Privée
    'Publique
    Public Property AnxietySM As Boolean
    'Privée
    'Publique
    Public Property DepressionDiagnostiquee As Boolean
    'Privée
    'Publique
    Public Property Dependance As Boolean
    'Privée
    'Publique
    Public Property MobiliteReduite As Boolean
    'Privée
    'Publique
    Public Property Maltraitance As Boolean
    'Privée
    'Publique
    Public Property MaltraitanceType As String
    'Privée
    'Publique
    Public Property UtiliseAppareilsMobiles As Boolean
    'Privée
    'Publique
    Public Property SoutienFamilialDisponible As Boolean
    'Privée
    'Publique
    Public Property VivantSeul As Boolean
    'Privée
    'Publique
    Public Property ChuteRecente As Boolean
    'Privée
    'Publique
    Public Property DateChuteRecente As Date?
    'Privée
    'Publique
    Public Property BesoinSoinsInfirmiers As Boolean
    'Privée
    'Publique
    Public Property TroubleCognitif As Boolean
    'Privée
    'Publique
    Public Property DemenceAlzheimer As Boolean
    'Privée
    'Publique
    Public Property CPAP As Boolean
    'Privée
    'Publique
    Public Property O2 As Boolean
    'Privée
    'Publique
    Public Property AideHabillage As Boolean
    'Privée
    'Publique
    Public Property AideAlimentation As Boolean
    'Privée
    'Publique
    Public Property AideHygienePersonnelle As Boolean
    'Privée
    'Publique
    Public Property AideDomestique As Boolean
    'Privée
    'Publique
    Public Property ViolenceFamilialeHistorique As Boolean
    'Privée
    'Publique
    Public Property AppelsUrgenceFrequents As Boolean
    'Privée
    'Publique
    Public Property InterventionsMultiples As Boolean
    'Privée
    'Publique
    Public Property AccesServicesPrives As Boolean
    'Privée
    'Publique
    Public Property SuiviParTravailleurSocial As Boolean
    'Privée
    'Publique
    Public Property ProblemeFinancier As Boolean
    'Privée
    'Publique
    Public Property ProblemeLogement As Boolean
    'Privée
    'Publique
    Public Property ReorientationVersRessourcesExternes As Boolean
    'Privée
    'Publique
    Public Property PersonneContacterUrgenceDisponible As Boolean
    'Privée
    'Publique
    Public Property AppareilsMedicaux As Boolean
    'Privée
    'Publique
    Public Property SuiviGeriatrique As Boolean

    'METHODES
    '****************************************************
    'Methode d'initiation
    Public Sub New()
        ' Initialisation des valeurs par défaut
        DateInscription = Date.Now
        Statut = "Actif"
        Pivot = "Pivot"
        NiveauAutonomie = "Autonome"
        NiveauDeSoins = "inconnu"
    End Sub
    '*************************************************
    ' Méthode pour obtenir l'âge à une date spécifique
    Public Function CalculerAgeA(dateReference As Date) As Integer?
        If DateNaissance.HasValue Then
            Dim age As Integer = dateReference.Year - DateNaissance.Value.Year

            ' Vérifier si l'anniversaire n'est pas encore passé à la date de référence
            If dateReference < DateNaissance.Value.AddYears(age) Then
                age -= 1
            End If

            Return age
        Else
            Return Nothing
        End If
    End Function
End Class


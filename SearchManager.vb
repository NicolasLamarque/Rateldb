
Option Explicit On

Public Class SearchManager
    ' Classe: SearchManager


    Private Const GOOGLE_SEARCH_URL As String = "https://www.google.ca/search?q="
    Private Const GOOGLE_MAPS_URL As String = "https://www.google.com/maps/dir/?api=1&destination="

    ' Méthode pour effectuer une recherche Google
    Public Sub Search(query As String)
        Dim encodedQuery As String
        encodedQuery = Replace(query, " ", "+") ' Encoder les espaces
        Dim url As String
        url = GOOGLE_SEARCH_URL & encodedQuery
        OpenBrowser(url)
    End Sub

    ' Méthode pour obtenir un itinéraire sur Google Maps
    Public Sub GetDirections(destination As String)
        Dim encodedDestination As String
        encodedDestination = Replace(destination, " ", "+") ' Encoder les espaces
        Dim url As String
        url = GOOGLE_MAPS_URL & encodedDestination
        OpenBrowser(url)
    End Sub

    ' Méthode pour ouvrir le navigateur par défaut avec l'URL spécifiée
    Private Sub OpenBrowser(url As String)
        Shell("cmd.exe /c start " & url, vbHide)
    End Sub
End Class

Imports System.IO
Imports System.Runtime.InteropServices

Public Class IniFile
    Public Path As String

    Public Sub New(ByVal iniPath As String)
        Path = iniPath
    End Sub

    ' Lecture d'une valeur dans une section spécifique
    Public Function ReadValue(ByVal section As String, ByVal key As String) As String
        Dim temp As String = New String(" "c, 255)
        Dim length As Integer = GetPrivateProfileString(section, key, "", temp, 255, Path)
        Return temp.Substring(0, length)
    End Function

    ' Écriture d'une valeur dans une section spécifique
    Public Sub WriteValue(ByVal section As String, ByVal key As String, ByVal value As String)
        WritePrivateProfileString(section, key, value, Path)
    End Sub

    ' Suppression d'une clé
    Public Sub DeleteKey(ByVal section As String, ByVal key As String)
        WritePrivateProfileString(section, key, Nothing, Path)
    End Sub

    ' Suppression d'une section entière
    Public Sub DeleteSection(ByVal section As String)
        WritePrivateProfileString(section, Nothing, Nothing, Path)
    End Sub

    ' Interop pour lire/écrire le fichier .ini
    <DllImport("kernel32")>
    Private Shared Function WritePrivateProfileString(ByVal section As String, ByVal key As String, ByVal val As String, ByVal filePath As String) As Long
    End Function

    <DllImport("kernel32")>
    Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal defaultVal As String, ByVal retVal As String, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function
End Class

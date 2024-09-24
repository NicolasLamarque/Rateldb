Public Class MonRatelClass

    Const TitreFr As String = "Ratel - Db"
    Const TitreEn As String = "Honey Badger App"
    Public Function GetTitleApp()
        If GetSetting("language") = "fr" Then
            Return TitreFr
        Else
            Return TitreEn

        End If

    End Function
End Class

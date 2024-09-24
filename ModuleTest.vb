Module ModuleTest
    Public Sub TesterValidationCourriel()
        Dim client As New Client()

        Try
            ' Test avec un e-mail valide
            client.Courriel = "utilisateur@example.com"
            Console.WriteLine("E-mail valide : " & client.Courriel)

            ' Test avec un e-mail invalide
            client.Courriel = "adresse.invalide"
            Console.WriteLine("Ceci ne devrait pas s'afficher")
        Catch ex As Exception
            Console.WriteLine("Exception attrapée : " & ex.Message)
        End Try

        Try
            ' Test avec une valeur vide
            client.Courriel = ""
            Console.WriteLine("E-mail vide : " & If(client.Courriel Is Nothing, "Null", client.Courriel))
        Catch ex As Exception
            Console.WriteLine("Exception attrapée : " & ex.Message)
        End Try
    End Sub

    Sub testCodePostal()
        Dim client As New Client()

        Try
            ' Test avec un code postal valide
            client.CodePostal = "H3B 4G7"
            Console.WriteLine("Code postal assigné : " & client.CodePostal)

            ' Test avec un code postal sans espace
            client.CodePostal = "H3B4G7"
            Console.WriteLine("Code postal assigné (sans espace) : " & client.CodePostal)

            ' Test avec un code postal en minuscules
            client.CodePostal = "h3b 4g7"
            Console.WriteLine("Code postal assigné (en minuscules) : " & client.CodePostal)

            ' Test avec des espaces supplémentaires
            client.CodePostal = "  H3B  4G7  "
            Console.WriteLine("Code postal assigné (avec espaces supplémentaires) : " & client.CodePostal)

            ' Test avec une valeur vide
            client.CodePostal = ""
            Console.WriteLine("Code postal assigné (vide) : " & If(client.CodePostal Is Nothing, "Null", client.CodePostal))

            ' Test avec un code postal invalide
            client.CodePostal = "ABC 123"
            Console.WriteLine("Ceci ne devrait pas s'afficher car une exception devrait être levée")
        Catch ex As Exception
            Console.WriteLine("Exception attrapée : " & ex.Message)
        End Try
    End Sub

End Module

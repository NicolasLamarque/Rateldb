Imports System.Drawing

Public Class ImageResizer
    Dim MonImageLogo As Image = My.Resources.ratel_honey_badger_database

    ' Fonction pour redimensionner une image à une taille spécifique
    Private Function ResizeImage(img As Image, newWidth As Integer, newHeight As Integer) As Image
        Return img.GetThumbnailImage(newWidth, newHeight, Nothing, IntPtr.Zero)
    End Function

    Public Function ChangeBtnImageTaille100x100(imageName As String) As Image
        Dim img As Image = CType(My.Resources.ResourceManager.GetObject(imageName), Image)
        If img Is Nothing Then
            Console.WriteLine($"Image '{imageName}' non trouvée dans les ressources.")
            Return Nothing
        End If
        Console.WriteLine($"Image '{imageName}' chargée avec succès.")
        Return ResizeImage(img, 100, 100)
    End Function
    Public Function ChangeBtnImageTaille15x15(imageName As String) As Image
        Dim img As Image = CType(My.Resources.ResourceManager.GetObject(imageName), Image)
        Return ResizeImage(img, 15, 15)
    End Function

    ' Fonction pour redimensionner une image à partir des ressources
    Private Function GetImageFromResources(imageName As String) As Image
        Return CType(My.Resources.ResourceManager.GetObject(imageName), Image)
    End Function


    Public Function Logo100x100() As Image
        Dim img As Image = CType(My.Resources.ResourceManager.GetObject("ratel-honey-badger-database"), Image)
        Return ResizeImage(img, 15, 15)
    End Function

End Class

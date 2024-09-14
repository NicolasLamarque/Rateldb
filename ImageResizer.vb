Imports System.Drawing

Public Class ImageResizer

    ' Fonction pour redimensionner une image à une taille spécifique
    Private Function ResizeImage(img As Image, newWidth As Integer, newHeight As Integer) As Image
        Return img.GetThumbnailImage(newWidth, newHeight, Nothing, IntPtr.Zero)
    End Function

    ' Fonction pour obtenir une image à partir des ressources et la redimensionner
    Public Function ChangeBtnImageTaille100x100(imageName As String) As Image
        Dim img As Image = CType(My.Resources.ResourceManager.GetObject(imageName), Image)
        Return ResizeImage(img, 100, 100)
    End Function
    Public Function ChangeBtnImageTaille15x15(imageName As String) As Image
        Dim img As Image = CType(My.Resources.ResourceManager.GetObject(imageName), Image)
        Return ResizeImage(img, 15, 15)
    End Function
End Class

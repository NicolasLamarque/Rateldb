Public Class F_Login
    Dim logincheck = New LoginManager
    Private Sub Button_Ok_Click(sender As Object, e As EventArgs) Handles Button_Ok.Click
        If logincheck.VerifyLogin(TextBox_Identifiant.Text, TextBox_Mp.Text) Then
            MessageBox.Show("Yes")
            Dim mainForm As New MainForm()
            mainForm.Show()
        End If

    End Sub
End Class
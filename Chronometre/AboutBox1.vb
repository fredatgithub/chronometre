Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Définissez le titre du formulaire.
        Dim applicationTitle As String
        If My.Application.Info.Title <> "" Then
            applicationTitle = My.Application.Info.Title
        Else
            applicationTitle = IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Text = String.Format("À propos de {0}", applicationTitle)
        ' Initialisez tout le texte affiché dans la boîte de dialogue À propos de.
        ' TODO: personnalisez les informations d'assembly de l'application dans le volet "Application" de la 
        '    boîte de dialogue Propriétés du projet (sous le menu "Projet").
        LabelProductName.Text = My.Application.Info.ProductName
        LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
        TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Close()
    End Sub

End Class

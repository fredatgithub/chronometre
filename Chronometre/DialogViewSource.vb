Public Class DialogViewSource

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

End Class
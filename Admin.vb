Public Class Admin
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Hide()
        Dashboard.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub
End Class
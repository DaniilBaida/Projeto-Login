Public Class Dashboard
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Hide()

        Login.Show()
        Login.resetInput()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub adminButton_Click(sender As Object, e As EventArgs) Handles adminButton.Click
        Hide()
        Admin.Show()
    End Sub


End Class
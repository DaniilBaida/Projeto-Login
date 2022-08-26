Public Class Login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub textUser_TextChanged(sender As Object, e As EventArgs) Handles textUser.TextChanged

    End Sub

    Private Sub textPassword_TextChanged(sender As Object, e As EventArgs) Handles textPassword.TextChanged

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Made by https://github.com/DaniilBaida", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

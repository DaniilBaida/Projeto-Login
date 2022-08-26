
Imports MySql.Data.MySqlClient

Public Class Login
    Public sqlConnection As MySqlConnection
    Public command As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader

    Private strSQL As String


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sqlConnection = New MySqlConnection("Server=localhost;Database=projLogin;Uid=root;Pwd=91984;")
            sqlConnection.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection = Nothing
            command = Nothing
            Application.Exit()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub textUser_TextChanged(sender As Object, e As EventArgs) Handles textUser.TextChanged
    End Sub

    Private Sub textPassword_TextChanged(sender As Object, e As EventArgs) Handles textPassword.TextChanged
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Made by https://github.com/DaniilBaida", "INFO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If textPassword.Text = 123 & textUser.Text = 123 Then
            Hide()
            Dashboard.Show()
        End If
    End Sub
End Class

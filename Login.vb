
Imports MySql.Data.MySqlClient

Public Class Login
    Public sqlConnection As MySqlConnection
    Public command As MySqlCommand
    Public dr As MySqlDataReader
    Public user As String
    Public password As String
    Public sqlString1 As String
    Public sqlString2 As String


    Public Sub checkUserLogin()
        Try
            sqlConnection = New MySqlConnection("Server=localhost;Database=projlogin;Uid=root;Pwd=91984;")

            sqlString1 = "SELECT * FROM user WHERE username = @username"
            sqlString2 = "SELECT * FROM user WHERE password = @password"


            command = New MySqlCommand(sqlString1, sqlConnection)
            command = New MySqlCommand(sqlString2, sqlConnection)
            command.Parameters.AddWithValue("@username", textUser.Text)
            command.Parameters.AddWithValue("@password", textPassword.Text)
            sqlConnection.Open()

            dr = command.ExecuteReader()

            Do While dr.Read
                user = dr("username")
                password = dr("password")
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
            Application.Exit()
        Finally
            sqlConnection.Close()
            sqlConnection = Nothing
            command = Nothing
        End Try

        If textUser.Text <> "" And textPassword.Text <> "" Then

            Try
                sqlConnection = New MySqlConnection("Server=localhost;Database=projlogin;Uid=root;Pwd=91984;")

                sqlString1 = "INSERT INTO loginlogs(username, password, date) values (@username, @password, now())"

                command = New MySqlCommand(sqlString1, sqlConnection)

                command.Parameters.AddWithValue("@username", textUser.Text)
                command.Parameters.AddWithValue("@password", textPassword.Text)
                sqlConnection.Open()
                command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
                Application.Exit()
            Finally
                sqlConnection.Close()
                sqlConnection = Nothing
                command = Nothing
            End Try

            If textUser.Text = user And textPassword.Text = password Then

                Hide()
                MessageBox.Show("LOGIN SUCCESSFULL", "AUTHENTICATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dashboard.Show()
            Else
                MessageBox.Show("WRONG USER/PASSWORD", "AUTHENTICATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textUser.Text = ""
                textUser.Focus()
                textPassword.Text = ""
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        checkUserLogin()
    End Sub
End Class

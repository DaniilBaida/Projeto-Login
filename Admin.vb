Imports MySql.Data.MySqlClient
Public Class Admin

    Public sqlConnection As MySqlConnection
    Public command As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public sqlString1 As String


    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Hide()
        Dashboard.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabUsers.BackColor = Color.FromArgb(0, 142, 204)
        tabCars.BackColor = Color.FromArgb(0, 142, 204)

        Try

            sqlConnection = Login.connectionString
            sqlString1 = "SELECT *  FROM user"



            command = New MySqlCommand(sqlString1, sqlConnection)
            sqlConnection.Open()


            Dim dt As New DataTable
            da = New MySqlDataAdapter(sqlString1, sqlConnection)
            da.Fill(dt)
            dataUsers.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection = Nothing


        End Try


    End Sub









    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If textUserName.Text <> "" And textUserPassword.Text <> "" And chooseType.SelectedItem <> "" Then
            Try

                sqlConnection = Login.connectionString
                sqlString1 = "Update user set username=@username, password=@password, usertype=@usertype WHERE id=@id"




                command = New MySqlCommand(sqlString1, sqlConnection)
                command.Parameters.AddWithValue("@id", textUserId.Text)
                command.Parameters.AddWithValue("@username", textUserName.Text)
                command.Parameters.AddWithValue("@password", textUserPassword.Text)
                command.Parameters.AddWithValue("@usertype", chooseType.Text)
                sqlConnection.Open()

                command.ExecuteNonQuery()

                Dim dt As New DataTable
                da = New MySqlDataAdapter("Select * from user", sqlConnection)
                da.Fill(dt)
                dataUsers.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                sqlConnection.Close()
                sqlConnection = Nothing
                sqlConnection = Nothing
            End Try
        End If
    End Sub


    Private Sub ADD_Click(sender As Object, e As EventArgs) Handles ADD.Click

        If textUserName.Text <> "" And textUserPassword.Text <> "" And chooseType.SelectedItem <> "" Then
            Login.refreshDB()

            If textUserName.Text <> Login.user Then

                Try

                    sqlConnection = Login.connectionString
                    sqlString1 = "Insert into user (username, password, usertype) values (@username, @password, @usertype)"




                    command = New MySqlCommand(sqlString1, sqlConnection)
                    command.Parameters.AddWithValue("@username", textUserName.Text)
                    command.Parameters.AddWithValue("@password", textUserPassword.Text)
                    command.Parameters.AddWithValue("@usertype", chooseType.Text)
                    sqlConnection.Open()

                    command.ExecuteNonQuery()

                    Dim dt As New DataTable
                    da = New MySqlDataAdapter("Select * from user", sqlConnection)
                    da.Fill(dt)
                    dataUsers.DataSource = dt
                    errorMain.Visible = False
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    sqlConnection.Close()
                    sqlConnection = Nothing
                    sqlConnection = Nothing
                End Try

            Else
                errorMain.Visible = True
            End If
        End If
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        If textUserId.Text <> "" Then
            Try

                sqlConnection = Login.connectionString
                sqlString1 = "Delete from user Where id=@id"




                command = New MySqlCommand(sqlString1, sqlConnection)
                command.Parameters.AddWithValue("@id", textUserId.Text)
                sqlConnection.Open()

                command.ExecuteNonQuery()

                Dim dt As New DataTable
                da = New MySqlDataAdapter("Select * from user", sqlConnection)
                da.Fill(dt)
                dataUsers.DataSource = dt
                errorUserId.Visible = False
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                sqlConnection.Close()
                sqlConnection = Nothing
                sqlConnection = Nothing
            End Try

        Else
            errorUserId.Visible = True


        End If
    End Sub


    Private Sub textUserName_TextChanged(sender As Object, e As EventArgs) Handles textUserName.TextChanged
        If textUserName.Text <> Login.user And textUserName.Text <> "" Then
            textUserId.Enabled = False
        Else
            textUserId.Enabled = True
        End If
    End Sub

    Private Sub textUserId_TextChanged(sender As Object, e As EventArgs) Handles textUserId.TextChanged
        If textUserId.Text <> "" Then
            Try

                sqlConnection = Login.connectionString
                sqlString1 = "Select * from user Where id=@id"




                command = New MySqlCommand(sqlString1, sqlConnection)
                command.Parameters.AddWithValue("@id", textUserId.Text)
                sqlConnection.Open()

                dr = command.ExecuteReader()

                Do While dr.Read
                    textUserName.Text = dr("username")
                    textUserPassword.Text = dr("password")
                    chooseType.SelectedText = dr("usertype")
                Loop

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                sqlConnection.Close()
                sqlConnection = Nothing
                sqlConnection = Nothing
                dr.Close()
            End Try

        Else
            errorUserId.Visible = True


        End If
    End Sub
End Class
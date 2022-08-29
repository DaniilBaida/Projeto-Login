Imports MySql.Data.MySqlClient
Public Class Dashboard
    Public sqlConnection As MySqlConnection
    Public command As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public sqlString1 As String
    Public Sub Model()
        Try

            sqlConnection = New MySqlConnection("Server=localhost;Database=projlogin;Uid=root;Pwd=91984;")
            sqlString1 = "SELECT *  FROM cars WHERE model = @model"



            command = New MySqlCommand(sqlString1, sqlConnection)
            command.Parameters.AddWithValue("@model", textModel.Text)
            sqlConnection.Open()

            Dim dt As New DataTable
            da = New MySqlDataAdapter(sqlString1, sqlConnection)
            da.Fill(dt)
            dataCars.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection = Nothing
            sqlConnection = Nothing
        End Try
    End Sub
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

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataCars.BackgroundColor = Color.FromArgb(0, 142, 204)
    End Sub

    Private Sub showCarsButton_Click(sender As Object, e As EventArgs) Handles showCarsButton.Click
        Model()
    End Sub
End Class
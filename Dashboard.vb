Imports MySql.Data.MySqlClient
Public Class Dashboard
    Public sqlConnection As MySqlConnection
    Public command As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public sqlString1 As String

    Sub resetInput()
        textID.Text = ""
        textModel.Text = ""
        textBrand.Text = ""
        textPrice.Text = ""
        dataCars.DataSource = ""
        textID.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Hide()

        Login.Show()
        Login.resetInput()
        resetInput()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub



    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataCars.BackgroundColor = Color.FromArgb(0, 142, 204)
        userIdentifier.Text = Login.textUser.Text
    End Sub

    Private Sub showCarsButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub adminButton_Click_1(sender As Object, e As EventArgs) Handles adminButton.Click
        Hide()
        Admin.Show()
    End Sub

    Private Sub textModel_TextChanged(sender As Object, e As EventArgs) Handles textModel.TextChanged
        Try

            sqlConnection = Login.connectionString
            sqlString1 = "SELECT *  FROM cars WHERE model = '" + textModel.Text + "'"



            command = New MySqlCommand(sqlString1, sqlConnection)
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

    Private Sub textBrand_TextChanged(sender As Object, e As EventArgs) Handles textBrand.TextChanged
        Try

            sqlConnection = Login.connectionString
            sqlString1 = "SELECT *  FROM cars WHERE brand = '" + textBrand.Text + "'"



            command = New MySqlCommand(sqlString1, sqlConnection)
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


    Private Sub textID_TextChanged(sender As Object, e As EventArgs) Handles textID.TextChanged
        Try

            sqlConnection = Login.connectionString
            sqlString1 = "SELECT *  FROM cars WHERE id = '" + textID.Text + "'"



            command = New MySqlCommand(sqlString1, sqlConnection)
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

    Private Sub textPrice_TextChanged(sender As Object, e As EventArgs) Handles textPrice.TextChanged
        Try

            sqlConnection = Login.connectionString
            sqlString1 = "SELECT *  FROM cars WHERE price = '" + textPrice.Text + "'"



            command = New MySqlCommand(sqlString1, sqlConnection)
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
End Class
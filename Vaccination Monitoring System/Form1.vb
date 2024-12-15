Imports MySql.Data.MySqlClient

Public Class Form1

    Private ReadOnly connectionString As String = "server=localhost;userid=root;password= ;database=vaccine"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If ValidateLogin(username, password) Then
            MessageBox.Show("Login successful!")
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Function ValidateLogin(username As String, password As String) As Boolean
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()

            Dim query As String = "SELECT COUNT(*) FROM admin_login WHERE username = @username AND password = MD5(@password)"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If result > 0 Then
                Return True
            Else 
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            conn.Close()
        End Try
    End Function
End Class

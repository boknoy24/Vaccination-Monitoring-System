Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connectionString As String = "Server=localhost;Database=vaccine;Uid=root;Pwd=;"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadVaccinationRecords()
        LoadChildrenInfo()
    End Sub

    Private Sub ExecuteQueryAndFillDataGrid(query As String, dataGrid As DataGridView)
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                dataGrid.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadVaccinationRecords()
        Dim query As String = "SELECT record_id, age, vaccine_name, height, weight, dosage_per_vaccine, number_of_doses FROM vaccination_records"
        ExecuteQueryAndFillDataGrid(query, DataGridView1)

        DataGridView1.Columns("record_id").Visible = False
    End Sub

    Private Sub LoadChildrenInfo()
        Dim query As String = "SELECT child_id, CONCAT(last_name, ', ', first_name) AS full_name, date_of_birth, place_of_birth, fathers_name, mothers_name, gender, birth_height, birth_weight, age, address FROM children_info"
        ExecuteQueryAndFillDataGrid(query, DataGridView2)

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells("date_of_birth").Value IsNot DBNull.Value Then
                Dim dob As DateTime = Convert.ToDateTime(row.Cells("date_of_birth").Value)
                row.Cells("ages").Value = CalculateAge(dob)
            End If
        Next

        DataGridView2.Columns("address").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView2.Columns("child_id").Visible = False
        DataGridView2.Columns("date_of_birth").Visible = False
        DataGridView2.Columns("place_of_birth").Visible = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lastName As String = txtLastName.Text
        Dim firstName As String = txtFirstName.Text
        Dim dob As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim placeOfBirth As String = txtPlaceOfBirth.Text
        Dim mothersName As String = txtMothersName.Text
        Dim fathersName As String = txtFathersName.Text
        Dim gender As String = If(RadioButton1.Checked, "Male", "Female")
        Dim birthHeight As Decimal = If(String.IsNullOrEmpty(txtBirthHeight.Text), 0, Convert.ToDecimal(txtBirthHeight.Text))
        Dim birthWeight As Decimal = If(String.IsNullOrEmpty(txtBirthWeight.Text), 0, Convert.ToDecimal(txtBirthWeight.Text))
        Dim address As String = txtAddress.Text

        Dim query As String = "INSERT INTO children_info (last_name, first_name, date_of_birth, place_of_birth, mothers_name, fathers_name, gender, birth_height, birth_weight, address) " &
                              "VALUES (@lastName, @firstName, @dob, @placeOfBirth, @mothersName, @fathersName, @gender, @birthHeight, @birthWeight, @address)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@firstName", firstName)
                command.Parameters.AddWithValue("@dob", dob)
                command.Parameters.AddWithValue("@placeOfBirth", placeOfBirth)
                command.Parameters.AddWithValue("@mothersName", mothersName)
                command.Parameters.AddWithValue("@fathersName", fathersName)
                command.Parameters.AddWithValue("@gender", gender)
                command.Parameters.AddWithValue("@birthHeight", birthHeight)
                command.Parameters.AddWithValue("@birthWeight", birthWeight)
                command.Parameters.AddWithValue("@address", address)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Record saved successfully!")
                    LoadChildrenInfo()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub UpdateVaccinationRecord(id As Integer, columnName As String, newValue As String)
        Dim query As String = ""
        Select Case columnName
            Case "age"
                query = "UPDATE vaccination_records SET age = @newValue WHERE record_id = @record_id"
            Case "vaccine_name"
                query = "UPDATE vaccination_records SET vaccine_name = @newValue WHERE record_id = @record_id"
            Case "vheight"
                query = "UPDATE vaccination_records SET height = @newValue WHERE record_id = @record_id"
            Case "weight"
                query = "UPDATE vaccination_records SET weight = @newValue WHERE record_id = @record_id"
            Case "dosage_per_vaccine"
                query = "UPDATE vaccination_records SET dosage_per_vaccine = @newValue WHERE record_id = @record_id"
            Case "number_of_doses"
                query = "UPDATE vaccination_records SET number_of_doses = @newValue WHERE record_id = @record_id"
        End Select

        Dim value As Object = If(columnName = "age" Or columnName = "number_of_doses", Convert.ToInt32(newValue), Convert.ToDecimal(newValue))

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@newValue", value)
                command.Parameters.AddWithValue("@record_id", id)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                Catch ex As Exception
                    MessageBox.Show("Error updating record: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Function CalculateAge(dob As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - dob.Year

        If today.Month < dob.Month OrElse (today.Month = dob.Month AndAlso today.Day < dob.Day) Then
            age -= 1
        End If

        Return age
    End Function

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim id As Integer = Convert.ToInt32(row.Cells("record_id").Value)
            Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name
            Dim newValue As String = row.Cells(e.ColumnIndex).Value.ToString()
            UpdateVaccinationRecord(id, columnName, newValue)
        End If
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        ' Check if the click is on a valid row
        If e.RowIndex >= 0 Then
            ' Clear previous content in RichTextBox1
            RichTextBox1.Clear()

            ' Get the clicked row
            Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

            ' Populate RichTextBox1 with data from the selected row
            Dim childName As String = row.Cells("full_name").Value.ToString()
            Dim dob As String = row.Cells("date_of_birth").Value.ToString()
            Dim address As String = If(row.Cells("address").Value IsNot DBNull.Value, row.Cells("address").Value.ToString(), "No address provided")

            ' Construct the text to display in RichTextBox
            Dim details As String = $"Name: {childName}{Environment.NewLine}" &
                                $"Date of Birth: {dob}{Environment.NewLine}" &
                                $"Address: {address}"

            ' Set the text of RichTextBox1
            RichTextBox1.Text = details

            ' Make RichTextBox1 visible
            RichTextBox1.Visible = True
            Button5.Visible = True
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Clear content of RichTextBox1
        RichTextBox1.Clear()

        ' Hide RichTextBox1
        RichTextBox1.Visible = False
        Button5.Visible = False
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class

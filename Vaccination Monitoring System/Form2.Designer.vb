<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtMothersName = New System.Windows.Forms.TextBox()
        Me.txtBirthWeight = New System.Windows.Forms.TextBox()
        Me.txtBirthHeight = New System.Windows.Forms.TextBox()
        Me.txtFathersName = New System.Windows.Forms.TextBox()
        Me.txtPlaceOfBirth = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vheight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vaccine_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dosage_per_vaccine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.number_of_doses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.full_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fathers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mothers_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birth_height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birth_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1199, 577)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.RadioButton2)
        Me.TabPage1.Controls.Add(Me.RadioButton1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.txtMothersName)
        Me.TabPage1.Controls.Add(Me.txtBirthWeight)
        Me.TabPage1.Controls.Add(Me.txtBirthHeight)
        Me.TabPage1.Controls.Add(Me.txtFathersName)
        Me.TabPage1.Controls.Add(Me.txtPlaceOfBirth)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.txtLastName)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1191, 551)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manage Child Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(148, 158)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(267, 20)
        Me.DateTimePicker1.TabIndex = 63
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(485, 442)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 30)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(579, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 20)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "First Name:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(245, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 30)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(156, 314)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton2.TabIndex = 59
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(89, 314)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 24)
        Me.RadioButton1.TabIndex = 58
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 20)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Sex:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(149, 367)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(727, 26)
        Me.txtAddress.TabIndex = 52
        '
        'txtMothersName
        '
        Me.txtMothersName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMothersName.Location = New System.Drawing.Point(156, 189)
        Me.txtMothersName.Name = "txtMothersName"
        Me.txtMothersName.Size = New System.Drawing.Size(284, 26)
        Me.txtMothersName.TabIndex = 50
        '
        'txtBirthWeight
        '
        Me.txtBirthWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthWeight.Location = New System.Drawing.Point(981, 287)
        Me.txtBirthWeight.Name = "txtBirthWeight"
        Me.txtBirthWeight.Size = New System.Drawing.Size(80, 26)
        Me.txtBirthWeight.TabIndex = 48
        '
        'txtBirthHeight
        '
        Me.txtBirthHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthHeight.Location = New System.Drawing.Point(716, 281)
        Me.txtBirthHeight.Name = "txtBirthHeight"
        Me.txtBirthHeight.Size = New System.Drawing.Size(80, 26)
        Me.txtBirthHeight.TabIndex = 47
        '
        'txtFathersName
        '
        Me.txtFathersName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFathersName.Location = New System.Drawing.Point(716, 209)
        Me.txtFathersName.Name = "txtFathersName"
        Me.txtFathersName.Size = New System.Drawing.Size(284, 26)
        Me.txtFathersName.TabIndex = 46
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(707, 160)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(284, 26)
        Me.txtPlaceOfBirth.TabIndex = 45
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(710, 116)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(284, 26)
        Me.txtFirstName.TabIndex = 44
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(131, 113)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(284, 26)
        Me.txtLastName.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(822, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 20)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Birth Weight (lbs):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(579, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Birth Height (ft):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(579, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Father's Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Mother's Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(579, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Place of Birth:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(830, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Child Immunization Record"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1191, 551)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Vaccination Records"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.age, Me.vheight, Me.weight, Me.vaccine_name, Me.dosage_per_vaccine, Me.number_of_doses})
        Me.DataGridView1.Location = New System.Drawing.Point(101, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1087, 542)
        Me.DataGridView1.TabIndex = 0
        '
        'age
        '
        Me.age.DataPropertyName = "age"
        Me.age.HeaderText = "Age"
        Me.age.Name = "age"
        '
        'vheight
        '
        Me.vheight.DataPropertyName = "height"
        Me.vheight.HeaderText = "Height"
        Me.vheight.Name = "vheight"
        '
        'weight
        '
        Me.weight.DataPropertyName = "weight"
        Me.weight.HeaderText = "Weight"
        Me.weight.Name = "weight"
        '
        'vaccine_name
        '
        Me.vaccine_name.DataPropertyName = "vaccine_name"
        Me.vaccine_name.HeaderText = "Vaccine Name"
        Me.vaccine_name.Name = "vaccine_name"
        '
        'dosage_per_vaccine
        '
        Me.dosage_per_vaccine.DataPropertyName = "dosage_per_vaccine"
        Me.dosage_per_vaccine.HeaderText = "Dosage per Vaccine"
        Me.dosage_per_vaccine.Name = "dosage_per_vaccine"
        '
        'number_of_doses
        '
        Me.number_of_doses.DataPropertyName = "number_of_doses"
        Me.number_of_doses.HeaderText = "Number of Doses"
        Me.number_of_doses.Name = "number_of_doses"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.RichTextBox1)
        Me.TabPage3.Controls.Add(Me.TextBox9)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1191, 551)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Search Records"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(342, 222)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(599, 320)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(8, 12)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(133, 20)
        Me.TextBox9.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(33, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(33, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Find"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.full_name, Me.fathers_name, Me.mothers_name, Me.gender, Me.birth_height, Me.birth_weight, Me.ages, Me.address})
        Me.DataGridView2.Location = New System.Drawing.Point(150, 9)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1016, 539)
        Me.DataGridView2.TabIndex = 0
        '
        'full_name
        '
        Me.full_name.DataPropertyName = "full_name"
        Me.full_name.HeaderText = "Name"
        Me.full_name.Name = "full_name"
        '
        'fathers_name
        '
        Me.fathers_name.DataPropertyName = "fathers_name"
        Me.fathers_name.HeaderText = "Father's Name"
        Me.fathers_name.Name = "fathers_name"
        '
        'mothers_name
        '
        Me.mothers_name.DataPropertyName = "mothers_name"
        Me.mothers_name.HeaderText = "Mother's Name"
        Me.mothers_name.Name = "mothers_name"
        '
        'gender
        '
        Me.gender.DataPropertyName = "gender"
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        '
        'birth_height
        '
        Me.birth_height.DataPropertyName = "birth_height"
        Me.birth_height.HeaderText = "Birth Height"
        Me.birth_height.Name = "birth_height"
        '
        'birth_weight
        '
        Me.birth_weight.DataPropertyName = "birth_weight"
        Me.birth_weight.HeaderText = "Birth Weight"
        Me.birth_weight.Name = "birth_weight"
        '
        'ages
        '
        Me.ages.DataPropertyName = "age"
        Me.ages.HeaderText = "Age"
        Me.ages.Name = "ages"
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Goudy Old Style", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(957, 276)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 177)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 576)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtMothersName As TextBox
    Friend WithEvents txtBirthWeight As TextBox
    Friend WithEvents txtBirthHeight As TextBox
    Friend WithEvents txtFathersName As TextBox
    Friend WithEvents txtPlaceOfBirth As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents vheight As DataGridViewTextBoxColumn
    Friend WithEvents weight As DataGridViewTextBoxColumn
    Friend WithEvents vaccine_name As DataGridViewTextBoxColumn
    Friend WithEvents dosage_per_vaccine As DataGridViewTextBoxColumn
    Friend WithEvents number_of_doses As DataGridViewTextBoxColumn
    Friend WithEvents full_name As DataGridViewTextBoxColumn
    Friend WithEvents fathers_name As DataGridViewTextBoxColumn
    Friend WithEvents mothers_name As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents birth_height As DataGridViewTextBoxColumn
    Friend WithEvents birth_weight As DataGridViewTextBoxColumn
    Friend WithEvents ages As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button5 As Button
End Class

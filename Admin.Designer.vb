<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.exitButton = New System.Windows.Forms.PictureBox()
        Me.mainTab = New System.Windows.Forms.TabControl()
        Me.tabCars = New System.Windows.Forms.TabPage()
        Me.dataCars = New System.Windows.Forms.DataGridView()
        Me.carClear = New System.Windows.Forms.Button()
        Me.carDelete = New System.Windows.Forms.Button()
        Me.carUpdate = New System.Windows.Forms.Button()
        Me.carModelText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.carBrandText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.carIdText = New System.Windows.Forms.TextBox()
        Me.TexdtBox = New System.Windows.Forms.Label()
        Me.carAdd = New System.Windows.Forms.Button()
        Me.tabUsers = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.errorMain = New System.Windows.Forms.Label()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chooseType = New System.Windows.Forms.ComboBox()
        Me.textUserPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dataUsers = New System.Windows.Forms.DataGridView()
        Me.textUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textUserId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADD = New System.Windows.Forms.Button()
        Me.carPriceText = New System.Windows.Forms.TextBox()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainTab.SuspendLayout()
        Me.tabCars.SuspendLayout()
        CType(Me.dataCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUsers.SuspendLayout()
        CType(Me.dataUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Transparent
        Me.backButton.Image = Global.Projeto_Login.My.Resources.Resources.back
        Me.backButton.Location = New System.Drawing.Point(12, 12)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(69, 69)
        Me.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.backButton.TabIndex = 3
        Me.backButton.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.Image = Global.Projeto_Login.My.Resources.Resources.powerButton
        Me.exitButton.Location = New System.Drawing.Point(818, 12)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(70, 69)
        Me.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.exitButton.TabIndex = 4
        Me.exitButton.TabStop = False
        '
        'mainTab
        '
        Me.mainTab.Controls.Add(Me.tabCars)
        Me.mainTab.Controls.Add(Me.tabUsers)
        Me.mainTab.Font = New System.Drawing.Font("MADE TOMMY", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainTab.Location = New System.Drawing.Point(114, 57)
        Me.mainTab.Name = "mainTab"
        Me.mainTab.SelectedIndex = 0
        Me.mainTab.Size = New System.Drawing.Size(673, 392)
        Me.mainTab.TabIndex = 5
        '
        'tabCars
        '
        Me.tabCars.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.tabCars.Controls.Add(Me.carPriceText)
        Me.tabCars.Controls.Add(Me.dataCars)
        Me.tabCars.Controls.Add(Me.carClear)
        Me.tabCars.Controls.Add(Me.carDelete)
        Me.tabCars.Controls.Add(Me.carUpdate)
        Me.tabCars.Controls.Add(Me.carModelText)
        Me.tabCars.Controls.Add(Me.Label5)
        Me.tabCars.Controls.Add(Me.Label6)
        Me.tabCars.Controls.Add(Me.carBrandText)
        Me.tabCars.Controls.Add(Me.Label7)
        Me.tabCars.Controls.Add(Me.carIdText)
        Me.tabCars.Controls.Add(Me.TexdtBox)
        Me.tabCars.Controls.Add(Me.carAdd)
        Me.tabCars.Font = New System.Drawing.Font("MADE TOMMY", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabCars.Location = New System.Drawing.Point(4, 22)
        Me.tabCars.Name = "tabCars"
        Me.tabCars.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCars.Size = New System.Drawing.Size(665, 366)
        Me.tabCars.TabIndex = 1
        Me.tabCars.Text = "ADD CARS"
        '
        'dataCars
        '
        Me.dataCars.AllowUserToAddRows = False
        Me.dataCars.AllowUserToDeleteRows = False
        Me.dataCars.AllowUserToResizeColumns = False
        Me.dataCars.AllowUserToResizeRows = False
        Me.dataCars.BackgroundColor = System.Drawing.Color.White
        Me.dataCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataCars.Location = New System.Drawing.Point(182, 40)
        Me.dataCars.Name = "dataCars"
        Me.dataCars.ReadOnly = True
        Me.dataCars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataCars.Size = New System.Drawing.Size(445, 273)
        Me.dataCars.TabIndex = 28
        '
        'carClear
        '
        Me.carClear.BackColor = System.Drawing.Color.Red
        Me.carClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.carClear.ForeColor = System.Drawing.Color.White
        Me.carClear.Location = New System.Drawing.Point(48, 306)
        Me.carClear.Name = "carClear"
        Me.carClear.Size = New System.Drawing.Size(86, 23)
        Me.carClear.TabIndex = 27
        Me.carClear.Text = "CLEAR TEXT"
        Me.carClear.UseVisualStyleBackColor = False
        '
        'carDelete
        '
        Me.carDelete.BackColor = System.Drawing.Color.Red
        Me.carDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.carDelete.ForeColor = System.Drawing.Color.White
        Me.carDelete.Location = New System.Drawing.Point(47, 273)
        Me.carDelete.Name = "carDelete"
        Me.carDelete.Size = New System.Drawing.Size(86, 23)
        Me.carDelete.TabIndex = 26
        Me.carDelete.Text = "DELETE"
        Me.carDelete.UseVisualStyleBackColor = False
        '
        'carUpdate
        '
        Me.carUpdate.BackColor = System.Drawing.Color.SpringGreen
        Me.carUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.carUpdate.Location = New System.Drawing.Point(47, 240)
        Me.carUpdate.Name = "carUpdate"
        Me.carUpdate.Size = New System.Drawing.Size(86, 23)
        Me.carUpdate.TabIndex = 25
        Me.carUpdate.Text = "UPDATE"
        Me.carUpdate.UseVisualStyleBackColor = False
        '
        'carModelText
        '
        Me.carModelText.Location = New System.Drawing.Point(47, 125)
        Me.carModelText.Name = "carModelText"
        Me.carModelText.Size = New System.Drawing.Size(86, 21)
        Me.carModelText.TabIndex = 23
        Me.carModelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "CAR MODEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(57, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "CAR PRICE"
        '
        'carBrandText
        '
        Me.carBrandText.Location = New System.Drawing.Point(47, 85)
        Me.carBrandText.Name = "carBrandText"
        Me.carBrandText.Size = New System.Drawing.Size(86, 21)
        Me.carBrandText.TabIndex = 20
        Me.carBrandText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(56, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "CAR BRAND"
        '
        'carIdText
        '
        Me.carIdText.Location = New System.Drawing.Point(47, 45)
        Me.carIdText.Name = "carIdText"
        Me.carIdText.Size = New System.Drawing.Size(86, 21)
        Me.carIdText.TabIndex = 18
        Me.carIdText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TexdtBox
        '
        Me.TexdtBox.AutoSize = True
        Me.TexdtBox.ForeColor = System.Drawing.Color.White
        Me.TexdtBox.Location = New System.Drawing.Point(69, 29)
        Me.TexdtBox.Name = "TexdtBox"
        Me.TexdtBox.Size = New System.Drawing.Size(42, 13)
        Me.TexdtBox.TabIndex = 17
        Me.TexdtBox.Text = "CAR ID"
        '
        'carAdd
        '
        Me.carAdd.BackColor = System.Drawing.Color.SpringGreen
        Me.carAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.carAdd.Location = New System.Drawing.Point(47, 205)
        Me.carAdd.Name = "carAdd"
        Me.carAdd.Size = New System.Drawing.Size(86, 23)
        Me.carAdd.TabIndex = 16
        Me.carAdd.Text = "ADD"
        Me.carAdd.UseVisualStyleBackColor = False
        '
        'tabUsers
        '
        Me.tabUsers.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tabUsers.Controls.Add(Me.Button2)
        Me.tabUsers.Controls.Add(Me.errorMain)
        Me.tabUsers.Controls.Add(Me.deleteButton)
        Me.tabUsers.Controls.Add(Me.Button1)
        Me.tabUsers.Controls.Add(Me.chooseType)
        Me.tabUsers.Controls.Add(Me.textUserPassword)
        Me.tabUsers.Controls.Add(Me.Label4)
        Me.tabUsers.Controls.Add(Me.Label3)
        Me.tabUsers.Controls.Add(Me.dataUsers)
        Me.tabUsers.Controls.Add(Me.textUserName)
        Me.tabUsers.Controls.Add(Me.Label2)
        Me.tabUsers.Controls.Add(Me.textUserId)
        Me.tabUsers.Controls.Add(Me.Label1)
        Me.tabUsers.Controls.Add(Me.ADD)
        Me.tabUsers.Font = New System.Drawing.Font("MADE TOMMY", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUsers.Location = New System.Drawing.Point(4, 22)
        Me.tabUsers.Name = "tabUsers"
        Me.tabUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUsers.Size = New System.Drawing.Size(665, 366)
        Me.tabUsers.TabIndex = 0
        Me.tabUsers.Text = "ADD USERS"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(46, 303)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "CLEAR TEXT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'errorMain
        '
        Me.errorMain.AutoSize = True
        Me.errorMain.BackColor = System.Drawing.Color.Red
        Me.errorMain.Font = New System.Drawing.Font("MADE TOMMY", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorMain.ForeColor = System.Drawing.Color.White
        Me.errorMain.Location = New System.Drawing.Point(247, 17)
        Me.errorMain.Name = "errorMain"
        Me.errorMain.Size = New System.Drawing.Size(288, 18)
        Me.errorMain.TabIndex = 14
        Me.errorMain.Text = "USERNAME ALREADY EXIST IN DATABASE"
        Me.errorMain.Visible = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Red
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deleteButton.ForeColor = System.Drawing.Color.White
        Me.deleteButton.Location = New System.Drawing.Point(45, 270)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(86, 23)
        Me.deleteButton.TabIndex = 12
        Me.deleteButton.Text = "DELETE"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SpringGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(45, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "UPDATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chooseType
        '
        Me.chooseType.FormattingEnabled = True
        Me.chooseType.Items.AddRange(New Object() {"GUEST", "ADMIN"})
        Me.chooseType.Location = New System.Drawing.Point(43, 157)
        Me.chooseType.Name = "chooseType"
        Me.chooseType.Size = New System.Drawing.Size(88, 21)
        Me.chooseType.TabIndex = 10
        '
        'textUserPassword
        '
        Me.textUserPassword.Location = New System.Drawing.Point(45, 117)
        Me.textUserPassword.Name = "textUserPassword"
        Me.textUserPassword.Size = New System.Drawing.Size(86, 21)
        Me.textUserPassword.TabIndex = 9
        Me.textUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "USER PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "USER TYPE"
        '
        'dataUsers
        '
        Me.dataUsers.AllowUserToAddRows = False
        Me.dataUsers.AllowUserToDeleteRows = False
        Me.dataUsers.AllowUserToResizeColumns = False
        Me.dataUsers.AllowUserToResizeRows = False
        Me.dataUsers.BackgroundColor = System.Drawing.Color.White
        Me.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataUsers.Location = New System.Drawing.Point(173, 47)
        Me.dataUsers.Name = "dataUsers"
        Me.dataUsers.ReadOnly = True
        Me.dataUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataUsers.Size = New System.Drawing.Size(440, 273)
        Me.dataUsers.TabIndex = 5
        '
        'textUserName
        '
        Me.textUserName.Location = New System.Drawing.Point(45, 77)
        Me.textUserName.Name = "textUserName"
        Me.textUserName.Size = New System.Drawing.Size(86, 21)
        Me.textUserName.TabIndex = 4
        Me.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USER NAME"
        '
        'textUserId
        '
        Me.textUserId.Location = New System.Drawing.Point(45, 37)
        Me.textUserId.Name = "textUserId"
        Me.textUserId.Size = New System.Drawing.Size(86, 21)
        Me.textUserId.TabIndex = 2
        Me.textUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER ID"
        '
        'ADD
        '
        Me.ADD.BackColor = System.Drawing.Color.SpringGreen
        Me.ADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ADD.Location = New System.Drawing.Point(45, 202)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(86, 23)
        Me.ADD.TabIndex = 0
        Me.ADD.Text = "ADD"
        Me.ADD.UseVisualStyleBackColor = False
        '
        'carPriceText
        '
        Me.carPriceText.Location = New System.Drawing.Point(48, 165)
        Me.carPriceText.Name = "carPriceText"
        Me.carPriceText.Size = New System.Drawing.Size(86, 21)
        Me.carPriceText.TabIndex = 29
        Me.carPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projeto_Login.My.Resources.Resources.adminBackground
        Me.ClientSize = New System.Drawing.Size(900, 506)
        Me.Controls.Add(Me.mainTab)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.backButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainTab.ResumeLayout(False)
        Me.tabCars.ResumeLayout(False)
        Me.tabCars.PerformLayout()
        CType(Me.dataCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUsers.ResumeLayout(False)
        Me.tabUsers.PerformLayout()
        CType(Me.dataUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backButton As PictureBox
    Friend WithEvents exitButton As PictureBox
    Friend WithEvents mainTab As TabControl
    Friend WithEvents tabUsers As TabPage
    Friend WithEvents tabCars As TabPage
    Friend WithEvents textUserId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ADD As Button
    Friend WithEvents textUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dataUsers As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents textUserPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chooseType As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents errorMain As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents carClear As Button
    Friend WithEvents carDelete As Button
    Friend WithEvents carUpdate As Button
    Friend WithEvents carModelText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents carBrandText As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents carIdText As TextBox
    Friend WithEvents TexdtBox As Label
    Friend WithEvents carAdd As Button
    Friend WithEvents dataCars As DataGridView
    Friend WithEvents carPriceText As TextBox
End Class

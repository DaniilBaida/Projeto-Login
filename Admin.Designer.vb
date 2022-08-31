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
        Me.tabUsers = New System.Windows.Forms.TabPage()
        Me.errorMain = New System.Windows.Forms.Label()
        Me.errorUserId = New System.Windows.Forms.Label()
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
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainTab.SuspendLayout()
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
        Me.tabCars.Font = New System.Drawing.Font("MADE TOMMY", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabCars.Location = New System.Drawing.Point(4, 22)
        Me.tabCars.Name = "tabCars"
        Me.tabCars.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCars.Size = New System.Drawing.Size(665, 366)
        Me.tabCars.TabIndex = 1
        Me.tabCars.Text = "ADD CARS"
        Me.tabCars.UseVisualStyleBackColor = True
        '
        'tabUsers
        '
        Me.tabUsers.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tabUsers.Controls.Add(Me.errorMain)
        Me.tabUsers.Controls.Add(Me.errorUserId)
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
        'errorUserId
        '
        Me.errorUserId.AutoSize = True
        Me.errorUserId.BackColor = System.Drawing.Color.Red
        Me.errorUserId.ForeColor = System.Drawing.Color.White
        Me.errorUserId.Location = New System.Drawing.Point(6, 32)
        Me.errorUserId.Name = "errorUserId"
        Me.errorUserId.Size = New System.Drawing.Size(159, 13)
        Me.errorUserId.TabIndex = 13
        Me.errorUserId.Text = "INSERT A VALUE INTO USER ID"
        Me.errorUserId.Visible = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Red
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deleteButton.ForeColor = System.Drawing.Color.White
        Me.deleteButton.Location = New System.Drawing.Point(45, 296)
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
        Me.Button1.Location = New System.Drawing.Point(45, 263)
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
        Me.chooseType.Location = New System.Drawing.Point(43, 183)
        Me.chooseType.Name = "chooseType"
        Me.chooseType.Size = New System.Drawing.Size(88, 21)
        Me.chooseType.TabIndex = 10
        '
        'textUserPassword
        '
        Me.textUserPassword.Location = New System.Drawing.Point(45, 143)
        Me.textUserPassword.Name = "textUserPassword"
        Me.textUserPassword.Size = New System.Drawing.Size(86, 21)
        Me.textUserPassword.TabIndex = 9
        Me.textUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "USER PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 167)
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
        Me.dataUsers.Size = New System.Drawing.Size(435, 273)
        Me.dataUsers.TabIndex = 5
        '
        'textUserName
        '
        Me.textUserName.Location = New System.Drawing.Point(45, 103)
        Me.textUserName.Name = "textUserName"
        Me.textUserName.Size = New System.Drawing.Size(86, 21)
        Me.textUserName.TabIndex = 4
        Me.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USER NAME"
        '
        'textUserId
        '
        Me.textUserId.Location = New System.Drawing.Point(45, 63)
        Me.textUserId.Name = "textUserId"
        Me.textUserId.Size = New System.Drawing.Size(86, 21)
        Me.textUserId.TabIndex = 2
        Me.textUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER ID"
        '
        'ADD
        '
        Me.ADD.BackColor = System.Drawing.Color.SpringGreen
        Me.ADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ADD.Location = New System.Drawing.Point(45, 228)
        Me.ADD.Name = "ADD"
        Me.ADD.Size = New System.Drawing.Size(86, 23)
        Me.ADD.TabIndex = 0
        Me.ADD.Text = "ADD"
        Me.ADD.UseVisualStyleBackColor = False
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
    Friend WithEvents errorUserId As Label
    Friend WithEvents errorMain As Label
End Class

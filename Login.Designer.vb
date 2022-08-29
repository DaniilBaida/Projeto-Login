<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.exitButton = New System.Windows.Forms.PictureBox()
        Me.textUser = New System.Windows.Forms.TextBox()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loginButton = New System.Windows.Forms.PictureBox()
        Me.imgEye = New System.Windows.Forms.PictureBox()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.Image = Global.Projeto_Login.My.Resources.Resources.powerButton
        Me.exitButton.Location = New System.Drawing.Point(368, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(69, 69)
        Me.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.exitButton.TabIndex = 0
        Me.exitButton.TabStop = False
        '
        'textUser
        '
        Me.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textUser.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.textUser.Location = New System.Drawing.Point(148, 274)
        Me.textUser.Name = "textUser"
        Me.textUser.Size = New System.Drawing.Size(145, 17)
        Me.textUser.TabIndex = 1
        Me.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textPassword
        '
        Me.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textPassword.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.textPassword.Location = New System.Drawing.Point(148, 337)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textPassword.Size = New System.Drawing.Size(145, 17)
        Me.textPassword.TabIndex = 2
        Me.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Projeto_Login.My.Resources.Resources.info
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.Transparent
        Me.loginButton.Image = Global.Projeto_Login.My.Resources.Resources.login
        Me.loginButton.Location = New System.Drawing.Point(138, 377)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(165, 75)
        Me.loginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.loginButton.TabIndex = 4
        Me.loginButton.TabStop = False
        '
        'imgEye
        '
        Me.imgEye.BackColor = System.Drawing.Color.Transparent
        Me.imgEye.Image = Global.Projeto_Login.My.Resources.Resources.view
        Me.imgEye.Location = New System.Drawing.Point(272, 339)
        Me.imgEye.Name = "imgEye"
        Me.imgEye.Size = New System.Drawing.Size(21, 20)
        Me.imgEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgEye.TabIndex = 5
        Me.imgEye.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projeto_Login.My.Resources.Resources.backgroundMain
        Me.ClientSize = New System.Drawing.Size(440, 470)
        Me.Controls.Add(Me.imgEye)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.textUser)
        Me.Controls.Add(Me.exitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As PictureBox
    Friend WithEvents textUser As TextBox
    Friend WithEvents textPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loginButton As PictureBox
    Friend WithEvents imgEye As PictureBox
End Class

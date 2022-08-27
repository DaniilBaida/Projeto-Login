<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.exitButton = New System.Windows.Forms.PictureBox()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projeto_Login.My.Resources.Resources.dashboard
        Me.ClientSize = New System.Drawing.Size(900, 506)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.backButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backButton As PictureBox
    Friend WithEvents exitButton As PictureBox
End Class

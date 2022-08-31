<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.exitButton = New System.Windows.Forms.PictureBox()
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.dataCars = New System.Windows.Forms.DataGridView()
        Me.modelButton = New System.Windows.Forms.PictureBox()
        Me.brandButton = New System.Windows.Forms.PictureBox()
        Me.priceButton = New System.Windows.Forms.PictureBox()
        Me.idButton = New System.Windows.Forms.PictureBox()
        Me.userLogo = New System.Windows.Forms.PictureBox()
        Me.textModel = New System.Windows.Forms.TextBox()
        Me.textBrand = New System.Windows.Forms.TextBox()
        Me.textID = New System.Windows.Forms.TextBox()
        Me.textPrice = New System.Windows.Forms.TextBox()
        Me.userIdentifier = New System.Windows.Forms.Label()
        Me.adminButton = New System.Windows.Forms.PictureBox()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brandButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adminButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.Image = Global.Projeto_Login.My.Resources.Resources.powerButton
        Me.exitButton.Location = New System.Drawing.Point(829, 1)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(70, 69)
        Me.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.exitButton.TabIndex = 1
        Me.exitButton.TabStop = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Transparent
        Me.backButton.Image = Global.Projeto_Login.My.Resources.Resources.back
        Me.backButton.Location = New System.Drawing.Point(1, 1)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(69, 69)
        Me.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.backButton.TabIndex = 2
        Me.backButton.TabStop = False
        '
        'dataCars
        '
        Me.dataCars.AllowUserToAddRows = False
        Me.dataCars.AllowUserToDeleteRows = False
        Me.dataCars.AllowUserToResizeColumns = False
        Me.dataCars.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MADE TOMMY", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataCars.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataCars.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.dataCars.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Console", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCars.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MADE TOMMY", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataCars.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataCars.GridColor = System.Drawing.Color.Black
        Me.dataCars.Location = New System.Drawing.Point(230, 178)
        Me.dataCars.Name = "dataCars"
        Me.dataCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MADE TOMMY", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataCars.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dataCars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MADE TOMMY", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataCars.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dataCars.Size = New System.Drawing.Size(441, 255)
        Me.dataCars.TabIndex = 3
        '
        'modelButton
        '
        Me.modelButton.BackColor = System.Drawing.Color.Transparent
        Me.modelButton.Image = Global.Projeto_Login.My.Resources.Resources.MODEL
        Me.modelButton.Location = New System.Drawing.Point(441, 99)
        Me.modelButton.Name = "modelButton"
        Me.modelButton.Size = New System.Drawing.Size(137, 77)
        Me.modelButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.modelButton.TabIndex = 4
        Me.modelButton.TabStop = False
        '
        'brandButton
        '
        Me.brandButton.BackColor = System.Drawing.Color.Transparent
        Me.brandButton.Image = Global.Projeto_Login.My.Resources.Resources.BRAND
        Me.brandButton.Location = New System.Drawing.Point(322, 100)
        Me.brandButton.Name = "brandButton"
        Me.brandButton.Size = New System.Drawing.Size(137, 76)
        Me.brandButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.brandButton.TabIndex = 5
        Me.brandButton.TabStop = False
        '
        'priceButton
        '
        Me.priceButton.BackColor = System.Drawing.Color.Transparent
        Me.priceButton.Image = Global.Projeto_Login.My.Resources.Resources.PRICE
        Me.priceButton.Location = New System.Drawing.Point(559, 99)
        Me.priceButton.Name = "priceButton"
        Me.priceButton.Size = New System.Drawing.Size(137, 77)
        Me.priceButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.priceButton.TabIndex = 7
        Me.priceButton.TabStop = False
        '
        'idButton
        '
        Me.idButton.BackColor = System.Drawing.Color.Transparent
        Me.idButton.Image = Global.Projeto_Login.My.Resources.Resources.ID
        Me.idButton.Location = New System.Drawing.Point(204, 100)
        Me.idButton.Name = "idButton"
        Me.idButton.Size = New System.Drawing.Size(137, 76)
        Me.idButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.idButton.TabIndex = 8
        Me.idButton.TabStop = False
        '
        'userLogo
        '
        Me.userLogo.BackColor = System.Drawing.Color.Transparent
        Me.userLogo.Image = Global.Projeto_Login.My.Resources.Resources.user
        Me.userLogo.Location = New System.Drawing.Point(57, 22)
        Me.userLogo.Name = "userLogo"
        Me.userLogo.Size = New System.Drawing.Size(28, 26)
        Me.userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userLogo.TabIndex = 9
        Me.userLogo.TabStop = False
        '
        'textModel
        '
        Me.textModel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textModel.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.textModel.Location = New System.Drawing.Point(465, 128)
        Me.textModel.Name = "textModel"
        Me.textModel.Size = New System.Drawing.Size(88, 17)
        Me.textModel.TabIndex = 10
        Me.textModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textBrand
        '
        Me.textBrand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBrand.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.textBrand.Location = New System.Drawing.Point(347, 128)
        Me.textBrand.Name = "textBrand"
        Me.textBrand.Size = New System.Drawing.Size(88, 17)
        Me.textBrand.TabIndex = 11
        Me.textBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textID
        '
        Me.textID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textID.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.textID.Location = New System.Drawing.Point(228, 128)
        Me.textID.Name = "textID"
        Me.textID.Size = New System.Drawing.Size(88, 17)
        Me.textID.TabIndex = 12
        Me.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textPrice
        '
        Me.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textPrice.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.textPrice.Location = New System.Drawing.Point(583, 128)
        Me.textPrice.Name = "textPrice"
        Me.textPrice.Size = New System.Drawing.Size(88, 17)
        Me.textPrice.TabIndex = 13
        Me.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userIdentifier
        '
        Me.userIdentifier.AutoSize = True
        Me.userIdentifier.BackColor = System.Drawing.Color.Transparent
        Me.userIdentifier.Font = New System.Drawing.Font("Phonk Regular DEMO", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userIdentifier.ForeColor = System.Drawing.Color.White
        Me.userIdentifier.Location = New System.Drawing.Point(79, 28)
        Me.userIdentifier.Name = "userIdentifier"
        Me.userIdentifier.Size = New System.Drawing.Size(103, 14)
        Me.userIdentifier.TabIndex = 15
        Me.userIdentifier.Text = "EXAMPLEEEE"
        '
        'adminButton
        '
        Me.adminButton.BackColor = System.Drawing.Color.Transparent
        Me.adminButton.Image = Global.Projeto_Login.My.Resources.Resources.settings
        Me.adminButton.Location = New System.Drawing.Point(762, 1)
        Me.adminButton.Name = "adminButton"
        Me.adminButton.Size = New System.Drawing.Size(70, 69)
        Me.adminButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.adminButton.TabIndex = 16
        Me.adminButton.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projeto_Login.My.Resources.Resources.dashboard
        Me.ClientSize = New System.Drawing.Size(900, 506)
        Me.Controls.Add(Me.adminButton)
        Me.Controls.Add(Me.userIdentifier)
        Me.Controls.Add(Me.textPrice)
        Me.Controls.Add(Me.textID)
        Me.Controls.Add(Me.textBrand)
        Me.Controls.Add(Me.textModel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.userLogo)
        Me.Controls.Add(Me.dataCars)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.brandButton)
        Me.Controls.Add(Me.idButton)
        Me.Controls.Add(Me.priceButton)
        Me.Controls.Add(Me.modelButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.modelButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brandButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adminButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As PictureBox
    Friend WithEvents backButton As PictureBox
    Friend WithEvents dataCars As DataGridView
    Friend WithEvents modelButton As PictureBox
    Friend WithEvents brandButton As PictureBox
    Friend WithEvents priceButton As PictureBox
    Friend WithEvents idButton As PictureBox
    Friend WithEvents userLogo As PictureBox
    Friend WithEvents textModel As TextBox
    Friend WithEvents textBrand As TextBox
    Friend WithEvents textID As TextBox
    Friend WithEvents textPrice As TextBox
    Friend WithEvents userIdentifier As Label
    Friend WithEvents adminButton As PictureBox
End Class

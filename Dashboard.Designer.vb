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
        Me.showCarsButton = New System.Windows.Forms.PictureBox()
        Me.priceButton = New System.Windows.Forms.PictureBox()
        Me.idButton = New System.Windows.Forms.PictureBox()
        Me.adminButton = New System.Windows.Forms.PictureBox()
        Me.textUser = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brandButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showCarsButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adminButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.Image = Global.Projeto_Login.My.Resources.Resources.powerButton
        Me.exitButton.Location = New System.Drawing.Point(818, 12)
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
        Me.backButton.Location = New System.Drawing.Point(12, 12)
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
        Me.modelButton.Location = New System.Drawing.Point(84, 107)
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
        Me.brandButton.Location = New System.Drawing.Point(201, 96)
        Me.brandButton.Name = "brandButton"
        Me.brandButton.Size = New System.Drawing.Size(137, 76)
        Me.brandButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.brandButton.TabIndex = 5
        Me.brandButton.TabStop = False
        '
        'showCarsButton
        '
        Me.showCarsButton.BackColor = System.Drawing.Color.Transparent
        Me.showCarsButton.Image = Global.Projeto_Login.My.Resources.Resources.SHOW_CARS
        Me.showCarsButton.Location = New System.Drawing.Point(318, 96)
        Me.showCarsButton.Name = "showCarsButton"
        Me.showCarsButton.Size = New System.Drawing.Size(264, 119)
        Me.showCarsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.showCarsButton.TabIndex = 6
        Me.showCarsButton.TabStop = False
        '
        'priceButton
        '
        Me.priceButton.BackColor = System.Drawing.Color.Transparent
        Me.priceButton.Image = Global.Projeto_Login.My.Resources.Resources.PRICE
        Me.priceButton.Location = New System.Drawing.Point(679, 107)
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
        Me.idButton.Location = New System.Drawing.Point(562, 96)
        Me.idButton.Name = "idButton"
        Me.idButton.Size = New System.Drawing.Size(137, 76)
        Me.idButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.idButton.TabIndex = 8
        Me.idButton.TabStop = False
        '
        'adminButton
        '
        Me.adminButton.BackColor = System.Drawing.Color.Transparent
        Me.adminButton.Image = Global.Projeto_Login.My.Resources.Resources.user
        Me.adminButton.Location = New System.Drawing.Point(756, 13)
        Me.adminButton.Name = "adminButton"
        Me.adminButton.Size = New System.Drawing.Size(63, 68)
        Me.adminButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.adminButton.TabIndex = 9
        Me.adminButton.TabStop = False
        Me.adminButton.Visible = False
        '
        'textUser
        '
        Me.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textUser.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.textUser.Location = New System.Drawing.Point(108, 136)
        Me.textUser.Name = "textUser"
        Me.textUser.Size = New System.Drawing.Size(88, 17)
        Me.textUser.TabIndex = 10
        Me.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(226, 124)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 17)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(586, 124)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 17)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("MADE TOMMY", 10.0!)
        Me.TextBox3.Location = New System.Drawing.Point(703, 136)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 17)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projeto_Login.My.Resources.Resources.dashboard
        Me.ClientSize = New System.Drawing.Size(900, 506)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.textUser)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.adminButton)
        Me.Controls.Add(Me.dataCars)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.showCarsButton)
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
        CType(Me.showCarsButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adminButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As PictureBox
    Friend WithEvents backButton As PictureBox
    Friend WithEvents dataCars As DataGridView
    Friend WithEvents modelButton As PictureBox
    Friend WithEvents brandButton As PictureBox
    Friend WithEvents showCarsButton As PictureBox
    Friend WithEvents priceButton As PictureBox
    Friend WithEvents idButton As PictureBox
    Friend WithEvents adminButton As PictureBox
    Friend WithEvents textUser As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtRePassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtHoTen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.btnBack)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtRePassword)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtHoTen)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtUsername)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtPassword)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnLogin)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnClose)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(364, 459)
        Me.BunifuGradientPanel1.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Image = Global.LibraryManagementGUI.My.Resources.Resources.back_icon
        Me.btnBack.ImageActive = Nothing
        Me.btnBack.Location = New System.Drawing.Point(7, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(25, 25)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 18
        Me.btnBack.TabStop = False
        Me.btnBack.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.LibraryManagementGUI.My.Resources.Resources.logo_png
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(104, 28)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(160, 160)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 17
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'txtRePassword
        '
        Me.txtRePassword.BackColor = System.Drawing.Color.DarkCyan
        Me.txtRePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRePassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRePassword.ForeColor = System.Drawing.Color.White
        Me.txtRePassword.HintForeColor = System.Drawing.Color.White
        Me.txtRePassword.HintText = "Nhập lại mật khẩu"
        Me.txtRePassword.isPassword = False
        Me.txtRePassword.LineFocusedColor = System.Drawing.Color.White
        Me.txtRePassword.LineIdleColor = System.Drawing.Color.White
        Me.txtRePassword.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtRePassword.LineThickness = 2
        Me.txtRePassword.Location = New System.Drawing.Point(72, 340)
        Me.txtRePassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtRePassword.Size = New System.Drawing.Size(225, 40)
        Me.txtRePassword.TabIndex = 16
        Me.txtRePassword.Tag = ""
        Me.txtRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtHoTen
        '
        Me.txtHoTen.BackColor = System.Drawing.Color.DarkCyan
        Me.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHoTen.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtHoTen.ForeColor = System.Drawing.Color.White
        Me.txtHoTen.HintForeColor = System.Drawing.Color.White
        Me.txtHoTen.HintText = "Họ tên"
        Me.txtHoTen.isPassword = False
        Me.txtHoTen.LineFocusedColor = System.Drawing.Color.White
        Me.txtHoTen.LineIdleColor = System.Drawing.Color.White
        Me.txtHoTen.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtHoTen.LineThickness = 2
        Me.txtHoTen.Location = New System.Drawing.Point(72, 250)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtHoTen.Size = New System.Drawing.Size(225, 40)
        Me.txtHoTen.TabIndex = 15
        Me.txtHoTen.Tag = ""
        Me.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.DarkCyan
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.HintForeColor = System.Drawing.Color.White
        Me.txtUsername.HintText = "Tên đăng nhập"
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.White
        Me.txtUsername.LineIdleColor = System.Drawing.Color.White
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtUsername.LineThickness = 2
        Me.txtUsername.Location = New System.Drawing.Point(72, 205)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtUsername.Size = New System.Drawing.Size(225, 40)
        Me.txtUsername.TabIndex = 14
        Me.txtUsername.Tag = ""
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.DarkCyan
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.HintForeColor = System.Drawing.Color.White
        Me.txtPassword.HintText = "Mật khẩu"
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.White
        Me.txtPassword.LineIdleColor = System.Drawing.Color.White
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtPassword.LineThickness = 2
        Me.txtPassword.Location = New System.Drawing.Point(72, 295)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtPassword.Size = New System.Drawing.Size(225, 40)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.Tag = ""
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.Teal
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 7
        Me.btnLogin.ButtonText = "Đăng Ký"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = CType(resources.GetObject("btnLogin.Iconimage"), System.Drawing.Image)
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = False
        Me.btnLogin.IconRightZoom = 0R
        Me.btnLogin.IconVisible = False
        Me.btnLogin.IconZoom = 90.0R
        Me.btnLogin.IsTab = False
        Me.btnLogin.Location = New System.Drawing.Point(72, 390)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.Teal
        Me.btnLogin.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(225, 50)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Đăng Ký"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Textcolor = System.Drawing.Color.White
        Me.btnLogin.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Image = Global.LibraryManagementGUI.My.Resources.Resources.cancel_icon
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(333, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 5
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 459)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegister"
        Me.Text = "frmRegister"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtHoTen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtRePassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
End Class

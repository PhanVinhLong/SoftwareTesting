<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSetting = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btnSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.BunifuGradientPanel1
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.txtUsername)
        Me.BunifuGradientPanel1.Controls.Add(Me.txtPassword)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnRegister)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnLogin)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnSetting)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnClose)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(364, 459)
        Me.BunifuGradientPanel1.TabIndex = 0
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
        Me.txtUsername.Location = New System.Drawing.Point(72, 215)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtUsername.Size = New System.Drawing.Size(225, 40)
        Me.txtUsername.TabIndex = 11
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
        Me.txtPassword.isPassword = True
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.White
        Me.txtPassword.LineIdleColor = System.Drawing.Color.White
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.White
        Me.txtPassword.LineThickness = 2
        Me.txtPassword.Location = New System.Drawing.Point(72, 270)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtPassword.Size = New System.Drawing.Size(225, 40)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.Tag = ""
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnRegister
        '
        Me.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnRegister.Activecolor = System.Drawing.Color.Transparent
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.BorderRadius = 7
        Me.btnRegister.ButtonText = "Đăng Ký"
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.DisabledColor = System.Drawing.Color.Gray
        Me.btnRegister.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnRegister.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRegister.Iconimage = CType(resources.GetObject("btnRegister.Iconimage"), System.Drawing.Image)
        Me.btnRegister.Iconimage_right = Nothing
        Me.btnRegister.Iconimage_right_Selected = Nothing
        Me.btnRegister.Iconimage_Selected = Nothing
        Me.btnRegister.IconMarginLeft = 0
        Me.btnRegister.IconMarginRight = 0
        Me.btnRegister.IconRightVisible = False
        Me.btnRegister.IconRightZoom = 0R
        Me.btnRegister.IconVisible = False
        Me.btnRegister.IconZoom = 90.0R
        Me.btnRegister.IsTab = False
        Me.btnRegister.Location = New System.Drawing.Point(72, 398)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Normalcolor = System.Drawing.Color.Transparent
        Me.btnRegister.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnRegister.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRegister.selected = False
        Me.btnRegister.Size = New System.Drawing.Size(225, 50)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "Đăng Ký"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegister.Textcolor = System.Drawing.Color.White
        Me.btnRegister.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.Teal
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 7
        Me.btnLogin.ButtonText = "Đăng Nhập"
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
        Me.btnLogin.Location = New System.Drawing.Point(72, 342)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.Teal
        Me.btnLogin.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(225, 50)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Đăng Nhập"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Textcolor = System.Drawing.Color.White
        Me.btnLogin.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetting.Image = Global.LibraryManagementGUI.My.Resources.Resources.setting_icon
        Me.btnSetting.ImageActive = Nothing
        Me.btnSetting.Location = New System.Drawing.Point(302, 4)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(25, 25)
        Me.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSetting.TabIndex = 6
        Me.btnSetting.TabStop = False
        Me.btnSetting.Zoom = 10
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
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.LibraryManagementGUI.My.Resources.Resources.logo_png
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(104, 28)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(160, 160)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 4
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 459)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.btnSetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnSetting As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class

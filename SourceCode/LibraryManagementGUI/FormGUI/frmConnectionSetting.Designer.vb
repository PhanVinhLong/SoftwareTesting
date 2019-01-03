<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConnectionSetting
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
        Me.ckeDafault = New DevExpress.XtraEditors.CheckEdit()
        Me.ckeStandard = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtDatabase = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPort = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtServer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.ckeViaIP = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btnTest = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ckeMySQL = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.ckeDafault.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeStandard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckeViaIP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ckeMySQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckeDafault
        '
        Me.ckeDafault.Location = New System.Drawing.Point(14, 12)
        Me.ckeDafault.Name = "ckeDafault"
        Me.ckeDafault.Properties.Caption = "MSSS Windows Authentication"
        Me.ckeDafault.Size = New System.Drawing.Size(182, 19)
        Me.ckeDafault.TabIndex = 0
        '
        'ckeStandard
        '
        Me.ckeStandard.Location = New System.Drawing.Point(14, 37)
        Me.ckeStandard.Name = "ckeStandard"
        Me.ckeStandard.Properties.Caption = "MSSS SQL Server Authentication"
        Me.ckeStandard.Size = New System.Drawing.Size(182, 19)
        Me.ckeStandard.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.txtDatabase)
        Me.PanelControl3.Controls.Add(Me.LabelControl11)
        Me.PanelControl3.Controls.Add(Me.txtPassword)
        Me.PanelControl3.Controls.Add(Me.LabelControl7)
        Me.PanelControl3.Controls.Add(Me.txtUsername)
        Me.PanelControl3.Controls.Add(Me.LabelControl8)
        Me.PanelControl3.Controls.Add(Me.txtPort)
        Me.PanelControl3.Controls.Add(Me.LabelControl9)
        Me.PanelControl3.Controls.Add(Me.txtServer)
        Me.PanelControl3.Controls.Add(Me.LabelControl10)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 136)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(243, 144)
        Me.PanelControl3.TabIndex = 9
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(110, 62)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(118, 20)
        Me.txtDatabase.TabIndex = 10
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 65)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl11.TabIndex = 9
        Me.LabelControl11.Text = "Database Name"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(110, 114)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(118, 20)
        Me.txtPassword.TabIndex = 8
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 117)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(110, 88)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(118, 20)
        Me.txtUsername.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 91)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl8.TabIndex = 5
        Me.LabelControl8.Text = "Username"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(110, 36)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(118, 20)
        Me.txtPort.TabIndex = 4
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(16, 39)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl9.TabIndex = 3
        Me.LabelControl9.Text = "Port"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(110, 10)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(118, 20)
        Me.txtServer.TabIndex = 2
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 13)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl10.TabIndex = 1
        Me.LabelControl10.Text = "Server/IP Address"
        '
        'ckeViaIP
        '
        Me.ckeViaIP.Location = New System.Drawing.Point(14, 63)
        Me.ckeViaIP.Name = "ckeViaIP"
        Me.ckeViaIP.Properties.Caption = "MSSS Connect Via IP"
        Me.ckeViaIP.Size = New System.Drawing.Size(123, 19)
        Me.ckeViaIP.TabIndex = 0
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btnTest)
        Me.PanelControl4.Controls.Add(Me.btnDong)
        Me.PanelControl4.Controls.Add(Me.btnLuu)
        Me.PanelControl4.Location = New System.Drawing.Point(263, 12)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(243, 76)
        Me.PanelControl4.TabIndex = 10
        '
        'btnTest
        '
        Me.btnTest.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnTest.ImageOptions.ImageUri.Uri = "Squeeze;Size16x16;Office2013"
        Me.btnTest.Location = New System.Drawing.Point(66, 44)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(118, 23)
        Me.btnTest.TabIndex = 2
        Me.btnTest.Text = "Test Connection"
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(135, 12)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(94, 23)
        Me.btnDong.TabIndex = 1
        Me.btnDong.Text = "Đóng"
        '
        'btnLuu
        '
        Me.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnLuu.ImageOptions.ImageUri.Uri = "Save;Size16x16;Office2013"
        Me.btnLuu.Location = New System.Drawing.Point(17, 12)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(94, 23)
        Me.btnLuu.TabIndex = 0
        Me.btnLuu.Text = "Lưu"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.ckeMySQL)
        Me.PanelControl1.Controls.Add(Me.ckeDafault)
        Me.PanelControl1.Controls.Add(Me.ckeViaIP)
        Me.PanelControl1.Controls.Add(Me.ckeStandard)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(243, 118)
        Me.PanelControl1.TabIndex = 11
        '
        'ckeMySQL
        '
        Me.ckeMySQL.Location = New System.Drawing.Point(14, 88)
        Me.ckeMySQL.Name = "ckeMySQL"
        Me.ckeMySQL.Properties.Caption = "MySQL"
        Me.ckeMySQL.Size = New System.Drawing.Size(123, 19)
        Me.ckeMySQL.TabIndex = 1
        '
        'frmConnectionSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 294)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Name = "frmConnectionSetting"
        Me.Text = "Cài đặt kết nối"
        CType(Me.ckeDafault.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeStandard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckeViaIP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.ckeMySQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ckeDafault As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckeStandard As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPort As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckeViaIP As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDatabase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ckeMySQL As DevExpress.XtraEditors.CheckEdit
End Class

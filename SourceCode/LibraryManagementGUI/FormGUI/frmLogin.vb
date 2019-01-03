Imports System.Configuration
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports LibraryManagementBUS
Imports LibraryManagementDTO

Public Class frmLogin
    Dim nhanVienBUS As NhanVienBUS
    Dim frm As frmRegister

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm = New frmRegister(Me, Me.Location)
        nhanVienBUS = New NhanVienBUS()

        ' Cài đặt giao diện
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2010 Blue"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Dim frm As frmConnectionSetting = New frmConnectionSetting
        frmConnectionSetting.ShowDialog()
    End Sub

    Private Sub Login()
        ' Kiểm tra kết nối
        Dim connectionString = ConfigurationManager.AppSettings("ConnectionString")
        If IsConnected(connectionString) = False Then
            MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        '----
        If nhanVienBUS.IsCorrectLogin(txtUsername.Text, txtPassword.Text) Then
            Dim nhanVien As NhanVienDTO = nhanVienBUS.SelectByUsername(txtUsername.Text)
            If nhanVien.MaLoaiNhanVien <> 1 And nhanVien.MaLoaiNhanVien <> 2 Then
                MessageBox.Show("Tài khoản của bạn chưa được kích hoạt")
                Return
            End If
            Me.Visible = False
            GlobalControl.GetDataNhanVien(nhanVien)
            Dim frm As frmMain = New frmMain
            frmMain.ShowDialog()
        Else
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng - " + txtUsername.Text + " - " + txtPassword.Text)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Public Function EncryptData(ByVal data As String) As Byte()
        Dim md5Hasher As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim hashedBytes As Byte()
        Dim encoder As New System.Text.UTF8Encoding()
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data))
        Return hashedBytes
    End Function

    Public Function ConvertToMd5(ByVal data As String) As String
        Return BitConverter.ToString(EncryptData(data)).Replace("-", "").ToLower()
    End Function

    Private Function IsConnected(connectionString As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Return True
            Catch ex As Exception
                connection.Close()
                Return False
            End Try
        End Using
    End Function

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            txtPassword.SelectNextControl(txtUsername, 0, 0, 0, 0)
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Space Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Visible = False
        frm.ShowDialog()
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Hiện thông báo khi tắt phần mềm
        If (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No) Then
            e.Cancel = True
            Return
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class

Public Class GlobalControl
    Shared loaiNhanVienBUS As LoaiNhanVienBUS
    Shared nhanVienBUS As NhanVienBUS
    Shared txtStatus As BarStaticItem
    Shared txtAccountType As BarStaticItem
    Shared txtStatName As BarStaticItem
    Shared nhanVien As NhanVienDTO = New NhanVienDTO


    Public Shared Sub GetDataNhanVien(dataNhanVien As NhanVienDTO)
        nhanVien = dataNhanVien
    End Sub

    Public Shared Sub SyncAccount()

    End Sub

    Public Shared Sub GetControl(statusControl As BarStaticItem, accountTypeControl As BarStaticItem, statNameControl As BarStaticItem)
        txtStatus = statusControl
        txtAccountType = accountTypeControl
        txtStatName = statNameControl
    End Sub

    Public Shared Sub ChangeStatus(strStatus As String)
        txtStatus.Caption = strStatus
    End Sub

    Public Shared Sub ChangeAccouInfo()
        nhanVienBUS = New NhanVienBUS()
        loaiNhanVienBUS = New LoaiNhanVienBUS()

        txtAccountType.Caption = loaiNhanVienBUS.GetName(nhanVien.MaLoaiNhanVien)
        txtStatName.Caption = nhanVien.HoTen
        txtStatus.Caption = "Xin chào " & nhanVien.HoTen & "(" & nhanVien.TenDangNhap & ")"
    End Sub

    Public Shared Function ReturnNhanVien() As NhanVienDTO
        Return nhanVien
    End Function
End Class
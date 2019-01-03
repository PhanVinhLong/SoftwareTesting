Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class frmRegister
    Dim nhanVienBUS As NhanVienBUS
    Dim formLogin As frmLogin

    Public Sub New(formLogin As frmLogin, pos As Point)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.formLogin = formLogin
    End Sub

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nhanVienBUS = New NhanVienBUS()
        Me.Location = formLogin.Location
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nhanVien As NhanVienDTO = New NhanVienDTO()

        ' Chuyển data từ GUI thành DTO
        nhanVien.TenDangNhap = txtUsername.Text
        nhanVien.HoTen = txtHoTen.Text
        nhanVien.MatKhau = txtPassword.Text
        nhanVien.MaLoaiNhanVien = 3

        ' Kiểm tra tính đúng đắn dữ liệu
        If nhanVienBUS.IsValidTenDangNhap(txtUsername.Text) = False Then
            MessageBox.Show("Tên đăng nhập không đúng. Tên đăng nhập chỉ gồm các ký tự a-z, A-Z, 0-9 và tối thiểu 4 ký tự")
            txtUsername.SelectNextControl(txtUsername, 0, 0, 0, 0)
            Return
        End If

        If nhanVienBUS.IsValidMatKhau(txtPassword.Text) = False Then
            MessageBox.Show("Mật khẩu không đúng. Tên đăng nhập chỉ gồm các ký tự a-z, A-Z, 0-9 và tối thiểu 6 ký tự")
            txtPassword.SelectNextControl(txtPassword, 0, 0, 0, 0)
            Return
        End If

        If nhanVienBUS.IsValidHoTen(txtPassword.Text) = False Then
            MessageBox.Show("Họ tên không đúng. Họ tên tối thiểu 1 ký tự")
            txtHoTen.SelectNextControl(txtHoTen, 0, 0, 0, 0)
            Return
        End If

        If txtPassword.Text <> txtRePassword.Text Then
            MessageBox.Show("Mật khẩu không khớp")
            txtRePassword.SelectNextControl(txtRePassword, 0, 0, 0, 0)
            Return
        End If

        If nhanVienBUS.IsNotExistUserName(txtUsername.Text) = False Then
            MessageBox.Show("Tên đăng nhập đã tồn tại")
            txtUsername.SelectNextControl(txtUsername, 0, 0, 0, 0)
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = nhanVienBUS.Insert(nhanVien)
        If result.FlagResult Then
            MessageBox.Show("Đăng ký thành công. Vui lòng liên hệ Quản trị viên để kích hoạt", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmLogin.Visible = True
            Me.Close()
        Else
            MessageBox.Show("Đăng ký không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        formLogin.Close()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formLogin.Location = Me.Location
        formLogin.Visible = True
        Me.Close()
    End Sub

    Private Sub txtUsername_OnValueChanged(sender As Object, e As EventArgs) Handles txtUsername.OnValueChanged
        txtUsername.ForeColor = Color.White
        If txtUsername.Text <> "" Then
            If nhanVienBUS.IsValidTenDangNhap(txtUsername.Text) = False Then
                txtUsername.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtHoTen_OnValueChanged(sender As Object, e As EventArgs) Handles txtHoTen.OnValueChanged
        txtHoTen.ForeColor = Color.White
        If txtHoTen.Text <> "" Then
            If nhanVienBUS.IsValidHoTen(txtHoTen.Text) = False Then
                txtHoTen.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.ForeColor = Color.White
        If txtPassword.Text <> "" Then
            If nhanVienBUS.IsValidMatKhau(txtPassword.Text) = False Then
                txtPassword.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtRePassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtRePassword.OnValueChanged
        txtRePassword.ForeColor = Color.White
        If txtRePassword.Text <> "" Then
            If nhanVienBUS.IsValidMatKhau(txtRePassword.Text) = False Then
                txtRePassword.ForeColor = Color.Red
            End If
        End If
    End Sub
End Class
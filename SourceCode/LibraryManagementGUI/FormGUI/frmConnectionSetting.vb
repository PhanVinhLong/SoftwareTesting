Imports System.Configuration
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports LibraryManagementDTO

Public Class frmConnectionSetting
    Dim connectionString As String

    Private Sub frmConnectionSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ckeDafault.Checked = True
    End Sub

    Private Sub ckeDafault_CheckedChanged(sender As Object, e As EventArgs) Handles ckeDafault.CheckedChanged
        If ckeDafault.Checked = True Then
            ckeStandard.Checked = False
            ckeViaIP.Checked = False
            ckeMySQL.Checked = False
            EnableText()
            txtPort.Enabled = False
            txtUsername.Enabled = False
            txtPassword.Enabled = False
        End If
    End Sub

    Private Sub ckeStandard_CheckedChanged(sender As Object, e As EventArgs) Handles ckeStandard.CheckedChanged
        If ckeStandard.Checked = True Then
            ckeDafault.Checked = False
            ckeViaIP.Checked = False
            ckeMySQL.Checked = False
            EnableText()
            txtPort.Enabled = False
        End If
    End Sub

    Private Sub ckeViaIP_CheckedChanged(sender As Object, e As EventArgs) Handles ckeViaIP.CheckedChanged
        If ckeViaIP.Checked = True Then
            ckeStandard.Checked = False
            ckeDafault.Checked = False
            ckeMySQL.Checked = False
            EnableText()
        End If
    End Sub

    Private Sub ckeMySQL_CheckedChanged(sender As Object, e As EventArgs) Handles ckeMySQL.CheckedChanged
        ckeStandard.Checked = False
        ckeDafault.Checked = False
        ckeViaIP.Checked = False
        EnableText()
    End Sub

    Public Sub EnableText()
        txtServer.Enabled = True
        txtPort.Enabled = True
        txtDatabase.Enabled = True
        txtUsername.Enabled = True
        txtPassword.Enabled = True
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        CheckAndBindData()

        If IsConnected(connectionString) Then
            MessageBox.Show("Kết nối thành công")
        Else
            MessageBox.Show("Kết nối thất bại")
        End If
    End Sub

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

    Private Function CheckAndBindData() As Boolean
        If ckeDafault.Checked = False And ckeStandard.Checked = False And ckeViaIP.Checked = False And ckeMySQL.Checked = False Then
            Return False
        End If
        ' Default
        If ckeDafault.Checked = True Then
            If (String.IsNullOrWhiteSpace(txtServer.EditValue) Or String.IsNullOrWhiteSpace(txtDatabase.EditValue)) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            connectionString = "Data Source=" & txtServer.EditValue & ";Initial Catalog=" & txtDatabase.EditValue & ";Integrated Security=True"
        End If
        ' Standard
        If ckeStandard.Checked = True Then
            If (String.IsNullOrWhiteSpace(txtServer.EditValue) Or String.IsNullOrWhiteSpace(txtDatabase.EditValue) Or String.IsNullOrWhiteSpace(txtUsername.EditValue) Or String.IsNullOrWhiteSpace(txtPassword.EditValue)) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            connectionString = "Server=" & txtServer.EditValue & ";Database=" & txtDatabase.EditValue & ";User Id=" & txtUsername.EditValue & ";Password=" & txtPassword.EditValue
        End If
        ' Via IP
        If ckeViaIP.Checked = True Then
            If (String.IsNullOrWhiteSpace(txtServer.EditValue) Or String.IsNullOrWhiteSpace(txtPort.EditValue) Or String.IsNullOrWhiteSpace(txtDatabase.EditValue) Or String.IsNullOrWhiteSpace(txtUsername.EditValue) Or String.IsNullOrWhiteSpace(txtPassword.EditValue)) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            connectionString = "Data Source=" & txtServer.EditValue & "," & txtPort.EditValue & ";Network Library=DBMSSOCN;Initial Catalog=" & txtDatabase.EditValue & ";User ID=" & txtUsername.EditValue & ";Password=" & txtPassword.EditValue & ";"
        End If
        ' MySQL
        If ckeMySQL.Checked = True Then
            If (String.IsNullOrWhiteSpace(txtServer.EditValue) Or String.IsNullOrWhiteSpace(txtPort.EditValue) Or String.IsNullOrWhiteSpace(txtDatabase.EditValue) Or String.IsNullOrWhiteSpace(txtUsername.EditValue) Or String.IsNullOrWhiteSpace(txtPassword.EditValue)) Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If String.IsNullOrWhiteSpace(txtPort.EditValue) Then
                connectionString = "Server=" & txtServer.EditValue & ";Database=" & txtDatabase.EditValue & ";Uid=" & txtUsername.EditValue & ";Pwd=" & txtPassword.EditValue
            Else
                connectionString = "Server=" & txtServer.EditValue & ";Port=" & txtPort.EditValue & ";Database=" & txtDatabase.EditValue & ";Uid=" & txtUsername.EditValue & ";Pwd=" & txtPassword.EditValue
            End If
        End If
        '----
        Return True
    End Function

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        CheckAndBindData()

        Try
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            config.AppSettings.Settings("ConnectionString").Value = connectionString
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")
            MessageBox.Show("Đã lưu cài đặt")
        Catch ex As Exception
            MessageBox.Show("Không thể lưu cài đặt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class
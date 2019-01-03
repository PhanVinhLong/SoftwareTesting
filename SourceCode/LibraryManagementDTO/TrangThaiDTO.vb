Public Class TrangThaiDTO
    Private iMaTrangThai As Integer
    Private strTenTrangThai As String

    Public Sub New()
    End Sub

    Public Sub New(iMaTrangThai As Integer, strTenTrangThai As String)
        Me.iMaTrangThai = iMaTrangThai
        Me.strTenTrangThai = strTenTrangThai
    End Sub

    Public Property MaTrangThai As Integer
        Get
            Return iMaTrangThai
        End Get
        Set(value As Integer)
            iMaTrangThai = value
        End Set
    End Property

    Public Property TenTrangThai As String
        Get
            Return strTenTrangThai
        End Get
        Set(value As String)
            strTenTrangThai = value
        End Set
    End Property
End Class

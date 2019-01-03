Public Class TacGiaSachDTO
    Private iMaTacGia As Integer
    Private iMaSach As Integer

    Public Sub New()
    End Sub

    Public Sub New(iMaTacGia As Integer, iMaSach As Integer)
        Me.iMaTacGia = iMaTacGia
        Me.iMaSach = iMaSach
    End Sub

    Public Property MaTacGia As Integer
        Get
            Return iMaTacGia
        End Get
        Set(value As Integer)
            iMaTacGia = value
        End Set
    End Property

    Public Property MaSach As Integer
        Get
            Return iMaSach
        End Get
        Set(value As Integer)
            iMaSach = value
        End Set
    End Property
End Class

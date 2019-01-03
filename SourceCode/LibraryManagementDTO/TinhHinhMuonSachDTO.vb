Public Class TinhHinhMuonSachDTO
    Private strTenTheLoai As String
    Private iSoLuotMuon As Integer
    Private iTiLe As Integer

    Public Sub New()
    End Sub

    Public Sub New(strTenTheLoai As String, iSoLanMuon As Integer, iTiLe As Integer)
        Me.strTenTheLoai = strTenTheLoai
        Me.iSoLuotMuon = iSoLanMuon
        Me.iTiLe = iTiLe
    End Sub

    Public Property TenTheLoai As String
        Get
            Return strTenTheLoai
        End Get
        Set(value As String)
            strTenTheLoai = value
        End Set
    End Property

    Public Property SoLuotMuon As Integer
        Get
            Return iSoLuotMuon
        End Get
        Set(value As Integer)
            iSoLuotMuon = value
        End Set
    End Property

    Public Property TiLe As Integer
        Get
            Return iTiLe
        End Get
        Set(value As Integer)
            iTiLe = value
        End Set
    End Property

    Public Function Clone() As TinhHinhMuonSachDTO
        Return Me.MemberwiseClone()
    End Function
End Class

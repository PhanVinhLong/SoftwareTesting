Public Class DBServerDTO
    Private strServerName As String
    Private strInstanceName As String

    Public Sub New()
    End Sub

    Public Sub New(strServerName As String, strInstanceName As String)
        Me.strServerName = strServerName
        Me.strInstanceName = strInstanceName
    End Sub

    Public Property ServerName As String
        Get
            Return strServerName
        End Get
        Set(value As String)
            strServerName = value
        End Set
    End Property

    Public Property InstanceName As String
        Get
            Return strInstanceName
        End Get
        Set(value As String)
            strInstanceName = value
        End Set
    End Property
End Class

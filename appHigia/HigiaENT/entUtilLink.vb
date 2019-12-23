Public Class entUtilLink

    Private _ENT_USUARIO As entUsuario

    Private _ID_LINK As Integer
    Private _DESCRICAO As String
    Private _LINK As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdLink() As String
        Get
            Return _ID_LINK
        End Get

        Set(ByVal value As String)
            _ID_LINK = value
        End Set

    End Property

    Public Property Descricao() As String
        Get
            Return _DESCRICAO
        End Get

        Set(ByVal value As String)
            _DESCRICAO = value
        End Set

    End Property

    Public Property Link() As String
        Get
            Return _LINK
        End Get

        Set(ByVal value As String)
            _LINK = value
        End Set

    End Property


End Class

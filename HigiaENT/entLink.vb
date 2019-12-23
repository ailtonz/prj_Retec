Public Class entLink

    Private _ENT_USUARIO As entUsuario

    Private _ID As Integer
    Private _LINK As String
    Private _DESCRICAO As String


    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property Id() As String
        Get
            Return _ID
        End Get

        Set(ByVal value As String)
            _ID = value
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

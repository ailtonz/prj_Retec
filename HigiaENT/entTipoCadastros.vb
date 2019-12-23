Public Class entTipoCadastros

    Private _ENT_USUARIO As entUsuario

    Private _ID As Integer
    Private _TIPO As String


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

    Public Property Tipo() As String

        Get
            Return _TIPO
        End Get

        Set(ByVal value As String)
            _TIPO = value
        End Set

    End Property

End Class

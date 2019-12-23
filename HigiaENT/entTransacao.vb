Public Class entTransacao
    Private _ENT_USUARIO As entUsuario

    Private _ID As Integer
    Private _TRANSACAO As String

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

    Public Property Transacao() As String
        Get
            Return _TRANSACAO
        End Get

        Set(ByVal value As String)
            _TRANSACAO = value
        End Set

    End Property

End Class

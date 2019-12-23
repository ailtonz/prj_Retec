Public Class entObservacao

    Private _ENT_USUARIO As entUsuario

    Private _ID_OBSERVACAO As Integer
    Private _ID_RELACAO As Integer
    Private _OBSERVACAO As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdObservacao() As String
        Get
            Return _ID_OBSERVACAO
        End Get

        Set(ByVal value As String)
            _ID_OBSERVACAO = value
        End Set

    End Property

    Public Property IdRelacao() As String

        Get
            Return _ID_RELACAO
        End Get

        Set(ByVal value As String)
            _ID_RELACAO = value
        End Set

    End Property

    Public Property Observacao() As String
        Get
            Return _OBSERVACAO
        End Get

        Set(ByVal value As String)
            _OBSERVACAO = value
        End Set

    End Property

End Class

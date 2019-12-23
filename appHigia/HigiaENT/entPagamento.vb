Public Class entPagamento

    Private _ENT_USUARIO As entUsuario

    Private _ID_PAGAMENTO As Integer
    Private _FORMA_PAGAMENTO As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdPagamento() As String
        Get
            Return _ID_PAGAMENTO
        End Get

        Set(ByVal value As String)
            _ID_PAGAMENTO = value
        End Set

    End Property

    Public Property FormaDePagamento() As String
        Get
            Return _FORMA_PAGAMENTO
        End Get

        Set(ByVal value As String)
            _FORMA_PAGAMENTO = value
        End Set

    End Property
End Class

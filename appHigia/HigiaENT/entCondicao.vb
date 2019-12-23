Public Class entCondicao
    Private _ENT_USUARIO As entUsuario

    Private _ID_CONDICAO As Integer

    Private _CONDICAO As String
    Private _CONDICAO_PAGAMENTO As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdCondicao() As String
        Get
            Return _ID_CONDICAO
        End Get

        Set(ByVal value As String)
            _ID_CONDICAO = value
        End Set

    End Property

    Public Property CondicaoPagamento() As String
        Get
            Return _CONDICAO_PAGAMENTO
        End Get

        Set(ByVal value As String)
            _CONDICAO_PAGAMENTO = value
        End Set

    End Property

    Public Property Condicao() As String
        Get
            Return _CONDICAO
        End Get

        Set(ByVal value As String)
            _CONDICAO = value
        End Set

    End Property

End Class

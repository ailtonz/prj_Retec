Public Class entTitulo

    Private _ENT_USUARIO As entUsuario
    Private _ENT_PLANO_CONTA As entPlanoConta
    Private _ENT_FORMA_PAGAMENTO As entPagamento

    Private _ID_TITULO As Integer
    Private _MOVIMENTO As String
    Private _DATA_EMISSAO As String
    Private _CONTA As String
    Private _DATA_VENCIMENTO As String
    Private _VALOR_ORIGINAL As String
    Private _DATA_PAGAMENTO As String
    Private _VALOR_FINAL As String
    Private _DOCUMENTO As String
    Private _OBSERVACAO As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property ENT_PLANO_CONTA() As entPlanoConta

        Get
            Return _ENT_PLANO_CONTA
        End Get

        Set(ByVal value As entPlanoConta)
            _ENT_PLANO_CONTA = value
        End Set

    End Property

    Public Property ENT_FORMA_PAGAMENTO() As entPagamento

        Get
            Return _ENT_FORMA_PAGAMENTO
        End Get

        Set(ByVal value As entPagamento)
            _ENT_FORMA_PAGAMENTO = value
        End Set

    End Property

    Public Property IdTitulo() As String
        Get
            Return _ID_TITULO
        End Get

        Set(ByVal value As String)
            _ID_TITULO = value
        End Set

    End Property

    Public Property DataDeEmissao() As String
        Get
            Return _DATA_EMISSAO
        End Get

        Set(ByVal value As String)
            _DATA_EMISSAO = value
        End Set

    End Property

    Public Property DataDeVencimento() As String
        Get
            Return _DATA_VENCIMENTO
        End Get

        Set(ByVal value As String)
            _DATA_VENCIMENTO = value
        End Set

    End Property

    Public Property ValorOriginal() As String
        Get
            Return _VALOR_ORIGINAL
        End Get

        Set(ByVal value As String)
            _VALOR_ORIGINAL = value
        End Set

    End Property

    Public Property DataDePagamento() As String
        Get
            Return _DATA_PAGAMENTO
        End Get

        Set(ByVal value As String)
            _DATA_PAGAMENTO = value
        End Set

    End Property

    Public Property ValorFinal() As String
        Get
            Return _VALOR_FINAL
        End Get

        Set(ByVal value As String)
            _VALOR_FINAL = value
        End Set

    End Property

    Public Property Documento() As String
        Get
            Return _DOCUMENTO
        End Get

        Set(ByVal value As String)
            _DOCUMENTO = value
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

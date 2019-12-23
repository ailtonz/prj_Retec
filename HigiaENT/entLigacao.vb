Public Class entLigacao

    Private _ID_LIGACAO As Integer
    Private _ID_CLIENTE As Integer
    Private _ID_SOLICITANTE As String
    Private _ID_OBRA As Integer
    Private _SERVICO_EMISSAO As String
    Private _OBRA_DESCRICAO As String

    Private _ENT_CLIENTE As entCliente
    Private _ENT_SOLICITANTE As entContato
    Private _ENT_OBRA As entEndereco

    Private _ENT_COBRANCA As entCobranca
    Private _ENT_CONTRATO As entContrato

    Private _ENT_SERVICO As entServico
    'Private _ENT_STATUS As entStatusCliente
    Private _ENT_MATERIAL As entMaterial

    Private _ENT_USUARIO As entUsuario

    Public Property ENT_OBRA() As entEndereco

        Get
            Return _ENT_OBRA
        End Get

        Set(ByVal value As entEndereco)
            _ENT_OBRA = value
        End Set

    End Property

    Public Property ENT_SOLICITANTE() As entContato

        Get
            Return _ENT_SOLICITANTE
        End Get

        Set(ByVal value As entContato)
            _ENT_SOLICITANTE = value
        End Set

    End Property

    Public Property ENT_CLIENTE() As entCliente

        Get
            Return _ENT_CLIENTE
        End Get

        Set(ByVal value As entCliente)
            _ENT_CLIENTE = value
        End Set

    End Property

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property ENT_COBRANCA() As entCobranca

        Get
            Return _ENT_COBRANCA
        End Get

        Set(ByVal value As entCobranca)
            _ENT_COBRANCA = value
        End Set

    End Property

    Public Property ENT_CONTRATO() As entContrato

        Get
            Return _ENT_CONTRATO
        End Get

        Set(ByVal value As entContrato)
            _ENT_CONTRATO = value
        End Set

    End Property

    Public Property ServicoEmissao() As String
        Get
            Return _SERVICO_EMISSAO
        End Get

        Set(ByVal value As String)
            _SERVICO_EMISSAO = value
        End Set

    End Property

    Public Property ObraDescricao() As String
        Get
            Return _OBRA_DESCRICAO
        End Get

        Set(ByVal value As String)
            _OBRA_DESCRICAO = value
        End Set

    End Property

    Public Property IdLigacao() As String
        Get
            Return _ID_LIGACAO
        End Get

        Set(ByVal value As String)
            _ID_LIGACAO = value
        End Set

    End Property


    Public Property IdCliente() As String
        Get
            Return _ID_CLIENTE
        End Get

        Set(ByVal value As String)
            _ID_CLIENTE = value
        End Set

    End Property

    Public Property IdSolicitante() As String
        Get
            Return _ID_SOLICITANTE
        End Get

        Set(ByVal value As String)
            _ID_SOLICITANTE = value
        End Set

    End Property

    Public Property IdObra() As Integer
        Get
            Return _ID_OBRA
        End Get

        Set(ByVal value As Integer)
            _ID_OBRA = value
        End Set

    End Property

    Public Property ENT_MATERIAL() As entMaterial

        Get
            Return _ENT_MATERIAL
        End Get

        Set(ByVal value As entMaterial)
            _ENT_MATERIAL = value
        End Set

    End Property

    'Public Property ENT_STATUS() As entStatusCliente

    '    Get
    '        Return _ENT_STATUS
    '    End Get

    '    Set(ByVal value As entStatusCliente)
    '        _ENT_STATUS = value
    '    End Set

    'End Property

    Public Property ENT_SERVICO() As entServico

        Get
            Return _ENT_SERVICO
        End Get

        Set(ByVal value As entServico)
            _ENT_SERVICO = value
        End Set

    End Property

End Class

Public Class entCliente

    Private _ENT_ENDERECO As entEndereco
    Private _ENT_CONTATO As entContato
    Private _ENT_USUARIO As entUsuario
    Private _ENT_DOCUMENTO As entDocumento
    Private _ENT_STATUS As entStatus
    Private _ENT_OBSERVACAO As entObservacao
    Private _ENT_PROPAGANDA As entUtilPropaganda

    Private _ID_CLIENTE As Integer
    Private _NOME As String
    Private _NOME_FANTASIA As String

    Private _CONTATO As String
    Private _TELEFONE As String
    Private _EMAIL As String

    Private _CADASTRO_TIPO As String
    Private _CADASTRO_PROPAGANDA As String

    Public Property ENT_PROPAGANDA() As entUtilPropaganda

        Get
            Return _ENT_PROPAGANDA
        End Get

        Set(ByVal value As entUtilPropaganda)
            _ENT_PROPAGANDA = value
        End Set

    End Property

    Public Property ENT_OBSERVACAO() As entObservacao

        Get
            Return _ENT_OBSERVACAO
        End Get

        Set(ByVal value As entObservacao)
            _ENT_OBSERVACAO = value
        End Set

    End Property


    Public Property ENT_STATUS() As entStatus

        Get
            Return _ENT_STATUS
        End Get

        Set(ByVal value As entStatus)
            _ENT_STATUS = value
        End Set

    End Property

    Public Property ENT_DOCUMENTO() As entDocumento

        Get
            Return _ENT_DOCUMENTO
        End Get

        Set(ByVal value As entDocumento)
            _ENT_DOCUMENTO = value
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

    Public Property ENT_CONTATO() As entContato

        Get
            Return _ENT_CONTATO
        End Get

        Set(ByVal value As entContato)
            _ENT_CONTATO = value
        End Set

    End Property

    Public Property ENT_ENDERECO() As entEndereco

        Get
            Return _ENT_ENDERECO
        End Get

        Set(ByVal value As entEndereco)
            _ENT_ENDERECO = value
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

    Public Property Nome() As String

        Get
            Return _NOME
        End Get

        Set(ByVal value As String)
            _NOME = value
        End Set

    End Property


    Public Property Nome_Fantasia() As String

        Get
            Return _NOME_FANTASIA
        End Get

        Set(ByVal value As String)
            _NOME_FANTASIA = value
        End Set

    End Property

    Public Property CadastroTipo() As String

        Get
            Return _CADASTRO_TIPO
        End Get

        Set(ByVal value As String)
            _CADASTRO_TIPO = value
        End Set

    End Property





End Class

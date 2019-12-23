Public Class entAterro

    Private _ENT_ENDERECO As entEndereco
    Private _ENT_CONTATO As entContato
    Private _ENT_CONTRATO As entContrato
    Private _ENT_DOCUMENTO As entDocumento
    Private _ENT_USUARIO As entUsuario

    Private _ID As Integer
    Private _NOME As String
    Private _NOME_FANTASIA As String

    Private _CNPJ_CPF As String
    Private _IE_RG As String

    Private _CADASTRO_TIPO As String

    Private _CADASTRO_STATUS As String
    Private _CADASTRO_OBSERVACAO As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
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


    Public Property ENT_CONTRATO() As entContrato

        Get
            Return _ENT_CONTRATO
        End Get

        Set(ByVal value As entContrato)
            _ENT_CONTRATO = value
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

    Public Property Id() As String
        Get
            Return _ID
        End Get

        Set(ByVal value As String)
            _ID = value
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


    Public Property NomeFantasia() As String

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

    Public Property Status() As String

        Get
            Return _CADASTRO_STATUS
        End Get

        Set(ByVal value As String)
            _CADASTRO_STATUS = value
        End Set

    End Property

    Public Property Observacao() As String

        Get
            Return _CADASTRO_OBSERVACAO
        End Get

        Set(ByVal value As String)
            _CADASTRO_OBSERVACAO = value
        End Set

    End Property


End Class

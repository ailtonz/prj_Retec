Public Class entFuncionario

    Private _ENT_ENDERECO As entEndereco
    Private _ENT_CONTATO As entContato
    Private _ENT_USUARIO As entUsuario
    Private _ENT_DOCUMENTO As entDocumento
    Private _ENT_OBSERVACAO As entObservacao

    Private _ID_FUNCIONARIO As Integer
    Private _NOME As String
    Private _CARGO As String

    Private _CADASTRO_STATUS As String

    Public Property ENT_OBSERVACAO() As entObservacao

        Get
            Return _ENT_OBSERVACAO
        End Get

        Set(ByVal value As entObservacao)
            _ENT_OBSERVACAO = value
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

    Public Property IdFuncionario() As String
        Get
            Return _ID_FUNCIONARIO
        End Get

        Set(ByVal value As String)
            _ID_FUNCIONARIO = value
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

    Public Property Cargo() As String

        Get
            Return _CARGO
        End Get

        Set(ByVal value As String)
            _CARGO = value
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

End Class

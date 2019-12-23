Public Class entFuncionario


    Private _ENT_DOCUMENTO As entDocumento
    Private _ENT_CARGO As entCargo
    Private _ENT_CONTATO As entContato

    Private _ENT_ENDERECO As entEndereco
    Private _ENT_USUARIO As entUsuario

    Private _ID As Integer
    Private _NOME As String

    Private _CADASTRO_STATUS As String

    Public Property ENT_CARGO() As entCargo

        Get
            Return _ENT_CARGO
        End Get

        Set(ByVal value As entCargo)
            _ENT_CARGO = value
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


    Public Property Status() As String

        Get
            Return _CADASTRO_STATUS
        End Get

        Set(ByVal value As String)
            _CADASTRO_STATUS = value
        End Set

    End Property

End Class

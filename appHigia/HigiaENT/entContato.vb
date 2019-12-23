Public Class entContato

    Private _ENT_USUARIO As entUsuario

    Private _ID_CONTATO As Integer
    Private _ID_RELACAO As Integer

    Private _TIPO_CONTATO As String

    Private _NOME_CONTATO As String
    Private _TELEFONE As String
    Private _EMAIL As String

    Private _OBSERVACAO As String
    Private _SOLICITANTE As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
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

    Public Property IdContato() As String

        Get
            Return _ID_CONTATO
        End Get

        Set(ByVal value As String)
            _ID_CONTATO = value
        End Set

    End Property

    Public Property TipoContato() As String

        Get
            Return _TIPO_CONTATO
        End Get

        Set(ByVal value As String)
            _TIPO_CONTATO = value
        End Set

    End Property

    Public Property NomeContato() As String

        Get
            Return _NOME_CONTATO
        End Get

        Set(ByVal value As String)
            _NOME_CONTATO = value
        End Set

    End Property

    Public Property Telefone() As String

        Get
            Return _TELEFONE
        End Get

        Set(ByVal value As String)
            _TELEFONE = value
        End Set

    End Property

    Public Property Email() As String

        Get
            Return _EMAIL
        End Get

        Set(ByVal value As String)
            _EMAIL = value
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

    Public Property Solicitante() As String

        Get
            Return _SOLICITANTE
        End Get

        Set(ByVal value As String)
            _SOLICITANTE = value
        End Set

    End Property

End Class

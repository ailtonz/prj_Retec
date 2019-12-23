Public Class entCobranca

    Private _ENT_CONTATO As entContato

    Private _TIPO As String

    Private _INSCRICAO As String
    Private _SACADO As String

    Private _CEP As String
    Private _LOGRADOURO As String
    Private _BAIRRO As String

    Private _CIDADE As String
    Private _ESTADO As String

    Public Property ENT_CONTATO() As entContato

        Get
            Return _ENT_CONTATO
        End Get

        Set(ByVal value As entContato)
            _ENT_CONTATO = value
        End Set

    End Property


    Public Property TipoCobranca() As String

        Get
            Return _TIPO
        End Get

        Set(ByVal value As String)
            _TIPO = value
        End Set

    End Property


    Public Property Inscricao() As String

        Get
            Return _INSCRICAO
        End Get

        Set(ByVal value As String)
            _INSCRICAO = value
        End Set

    End Property

    Public Property Sacado() As String

        Get
            Return _SACADO
        End Get

        Set(ByVal value As String)
            _SACADO = value
        End Set

    End Property

    Public Property Cep() As String

        Get
            Return _CEP
        End Get

        Set(ByVal value As String)
            _CEP = value
        End Set

    End Property

    Public Property Logradouro() As String

        Get
            Return _LOGRADOURO
        End Get

        Set(ByVal value As String)
            _LOGRADOURO = value
        End Set

    End Property

    Public Property Bairro() As String

        Get
            Return _BAIRRO
        End Get

        Set(ByVal value As String)
            _BAIRRO = value
        End Set

    End Property

    Public Property Cidade() As String

        Get
            Return _CIDADE
        End Get

        Set(ByVal value As String)
            _CIDADE = value
        End Set

    End Property

    Public Property Estado() As String

        Get
            Return _ESTADO
        End Get

        Set(ByVal value As String)
            _ESTADO = value
        End Set

    End Property
End Class

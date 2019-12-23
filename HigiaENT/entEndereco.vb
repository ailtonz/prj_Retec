Public Class entEndereco

    Private _ENDERECO As String
    Private _NUMERO As String
    Private _COMPLEMENTO As String
    Private _BAIRRO As String
    Private _CEP As String
    Private _CIDADE As String
    Private _ESTADO As String
    Private _OBSERVACAO As String

    Public Property Observacao() As String

        Get
            Return _OBSERVACAO
        End Get

        Set(ByVal value As String)
            _OBSERVACAO = value
        End Set

    End Property

    Public Property Endereco() As String

        Get
            Return _ENDERECO
        End Get

        Set(ByVal value As String)
            _ENDERECO = value
        End Set

    End Property

    Public Property Numero() As String

        Get
            Return _NUMERO
        End Get

        Set(ByVal value As String)
            _NUMERO = value
        End Set

    End Property

    Public Property Complemento() As String

        Get
            Return _COMPLEMENTO
        End Get

        Set(ByVal value As String)
            _COMPLEMENTO = value
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

    Public Property Cep() As String

        Get
            Return _CEP
        End Get

        Set(ByVal value As String)
            _CEP = value
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

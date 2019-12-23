Public Class entUtilCep

    Private _ENT_ENDERECO As entEndereco
    Private _ENT_USUARIO As entUsuario

    Private _ID_CEP As Integer
    Private _CONTRATO_VALOR As String

    Public Property IdCEP() As String
        Get
            Return _ID_CEP
        End Get

        Set(ByVal value As String)
            _ID_CEP = value
        End Set

    End Property

    Public Property ContratoValor() As String
        Get
            Return _CONTRATO_VALOR
        End Get

        Set(ByVal value As String)
            _CONTRATO_VALOR = value
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

    Public Property ENT_ENDERECO() As entEndereco

        Get
            Return _ENT_ENDERECO
        End Get

        Set(ByVal value As entEndereco)
            _ENT_ENDERECO = value
        End Set

    End Property

End Class

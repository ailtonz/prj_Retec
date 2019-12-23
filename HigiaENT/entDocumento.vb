Public Class entDocumento

    Private _TIPO_DOCUMENTO As String
    Private _CNPJ_CPF As String
    Private _IE_RG As String


    Public Property TipoDocumento() As String

        Get
            Return _TIPO_DOCUMENTO
        End Get

        Set(ByVal value As String)
            _TIPO_DOCUMENTO = value
        End Set

    End Property

    Public Property CNPJ_CPF() As String

        Get
            Return _CNPJ_CPF
        End Get

        Set(ByVal value As String)
            _CNPJ_CPF = value
        End Set

    End Property

    Public Property IE_RG() As String

        Get
            Return _IE_RG
        End Get

        Set(ByVal value As String)
            _IE_RG = value
        End Set

    End Property


End Class

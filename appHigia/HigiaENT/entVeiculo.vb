Public Class entVeiculo
    Private _ID_VEICULO As Integer
    Private _ENT_USUARIO As entUsuario

    Private _MODELO As String
    Private _PLACA As String


    Public Property IdVeiculo() As String
        Get
            Return _ID_VEICULO
        End Get

        Set(ByVal value As String)
            _ID_VEICULO = value
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

    Public Property Modelo() As String
        Get
            Return _MODELO
        End Get

        Set(ByVal value As String)
            _MODELO = value
        End Set

    End Property

    Public Property Placa() As String
        Get
            Return _PLACA
        End Get

        Set(ByVal value As String)
            _PLACA = value
        End Set

    End Property


End Class

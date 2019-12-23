Public Class entVeiculo
    Private _ENT_USUARIO As entUsuario

    Private _ID As Integer
    Private _MODELO As String
    Private _PLACA As String


    Public Property Id() As String
        Get
            Return _ID
        End Get

        Set(ByVal value As String)
            _ID = value
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

Public Class entPlanoConta

    Private _ENT_USUARIO As entUsuario

    Private _ID_PLANO As Integer
    Private _MOVIMENTO As String
    Private _CONTA As String
    Private _GRUPO As String
    Private _FREQUENCIA As String
    Private _PLANO As String


    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdPlano() As String
        Get
            Return _ID_PLANO
        End Get

        Set(ByVal value As String)
            _ID_PLANO = value
        End Set

    End Property

    Public Property Movimento() As String
        Get
            Return _MOVIMENTO
        End Get

        Set(ByVal value As String)
            _MOVIMENTO = value
        End Set

    End Property

    Public Property PlanoDeConta() As String
        Get
            Return _CONTA
        End Get

        Set(ByVal value As String)
            _CONTA = value
        End Set

    End Property

    Public Property GrupoDeConta() As String
        Get
            Return _GRUPO
        End Get

        Set(ByVal value As String)
            _GRUPO = value
        End Set

    End Property

    Public Property Frequencia() As String
        Get
            Return _FREQUENCIA
        End Get

        Set(ByVal value As String)
            _FREQUENCIA = value
        End Set

    End Property

    Public Property Plano() As String
        Get
            Return _PLANO
        End Get

        Set(ByVal value As String)
            _PLANO = value
        End Set

    End Property

End Class

Public Class entServico
    Private _COLOCA As Integer
    Private _TROCA As Integer
    Private _RETIRA As Integer

    Private _DT_COLOCA As String
    Private _DT_TROCA As String
    Private _DT_RETIRA As String

    Private _PR_COLOCA As String
    Private _PR_TROCA As String
    Private _PR_RETIRA As String

    Private _OBS_COLOCA As String
    Private _OBS_TROCA As String
    Private _OBS_RETIRA As String
    Private _OBS_GERAL As String


    Public Property Coloca() As Integer
        Get
            Return _COLOCA
        End Get

        Set(ByVal value As Integer)
            _COLOCA = value
        End Set

    End Property

    Public Property Troca() As Integer
        Get
            Return _TROCA
        End Get

        Set(ByVal value As Integer)
            _TROCA = value
        End Set

    End Property

    Public Property Retira() As Integer
        Get
            Return _RETIRA
        End Get

        Set(ByVal value As Integer)
            _RETIRA = value
        End Set

    End Property

    Public Property DTColoca() As String
        Get
            Return _DT_COLOCA
        End Get

        Set(ByVal value As String)
            _DT_COLOCA = value
        End Set

    End Property

    Public Property DTTroca() As String
        Get
            Return _DT_TROCA
        End Get

        Set(ByVal value As String)
            _DT_TROCA = value
        End Set

    End Property

    Public Property DTRetira() As String
        Get
            Return _DT_RETIRA
        End Get

        Set(ByVal value As String)
            _DT_RETIRA = value
        End Set

    End Property


    Public Property PRColoca() As String
        Get
            Return _PR_COLOCA
        End Get

        Set(ByVal value As String)
            _PR_COLOCA = value
        End Set

    End Property

    Public Property PRTroca() As String
        Get
            Return _PR_TROCA
        End Get

        Set(ByVal value As String)
            _PR_TROCA = value
        End Set

    End Property

    Public Property PRRetira() As String
        Get
            Return _PR_RETIRA
        End Get

        Set(ByVal value As String)
            _PR_RETIRA = value
        End Set

    End Property


    Public Property ObsColoca() As String

        Get
            Return _OBS_COLOCA
        End Get

        Set(ByVal value As String)
            _OBS_COLOCA = value
        End Set

    End Property

    Public Property ObsTroca() As String

        Get
            Return _OBS_TROCA
        End Get

        Set(ByVal value As String)
            _OBS_TROCA = value
        End Set

    End Property

    Public Property ObsRetira() As String

        Get
            Return _OBS_RETIRA
        End Get

        Set(ByVal value As String)
            _OBS_RETIRA = value
        End Set

    End Property

    Public Property ObsGeral() As String

        Get
            Return _OBS_GERAL
        End Get

        Set(ByVal value As String)
            _OBS_GERAL = value
        End Set

    End Property

End Class

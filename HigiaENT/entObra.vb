Public Class entObra

    Private _ID_OBRA As Integer
    Private _ID_RELACAO As Integer
    Private _OBS_LIGACAO As String
    Private _OBS_COLOCA As String
    Private _OBS_TROCA As String
    Private _OBS_RETIRA As String
    Private _OBS_OBRA As String

    Private _ENT_ENDERECO As entEndereco
    Private _ENT_CONTATO As entContato
    Private _ENT_USUARIO As entUsuario
    Private _ENT_CONTRATO As entContrato
    Private _ENT_COBRANCA As entCobranca

    Public Property ENT_COBRANCA() As entCobranca

        Get
            Return _ENT_COBRANCA
        End Get

        Set(ByVal value As entCobranca)
            _ENT_COBRANCA = value
        End Set

    End Property

    Public Property ENT_CONTRATO() As entContrato

        Get
            Return _ENT_CONTRATO
        End Get

        Set(ByVal value As entContrato)
            _ENT_CONTRATO = value
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

    Public Property ObsObra() As String

        Get
            Return _OBS_OBRA
        End Get

        Set(ByVal value As String)
            _OBS_OBRA = value
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

    Public Property ObsTroca() As String

        Get
            Return _OBS_TROCA
        End Get

        Set(ByVal value As String)
            _OBS_TROCA = value
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

    Public Property ObsLigacao() As String

        Get
            Return _OBS_LIGACAO
        End Get

        Set(ByVal value As String)
            _OBS_LIGACAO = value
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

    Public Property IdObra() As String
        Get
            Return _ID_OBRA
        End Get

        Set(ByVal value As String)
            _ID_OBRA = value
        End Set

    End Property

End Class

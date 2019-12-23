Public Class entObservacao

    Private _ENT_USUARIO As entUsuario
    Private _ENT_SERVICO As entStatusServicos

    Private _ID As Integer
    Private _OBSERVACAO As String


    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property ENT_SERVICO() As entStatusServicos

        Get
            Return _ENT_SERVICO
        End Get

        Set(ByVal value As entStatusServicos)
            _ENT_SERVICO = value
        End Set

    End Property

    Public Property Id() As String
        Get
            Return _ID
        End Get

        Set(ByVal value As String)
            _ID = value
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
End Class

Public Class entPlanoContaGrupo

    Private _ENT_USUARIO As entUsuario

    Private _ID_GRUPO As Integer
    Private _GRUPO As String


    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdGrupo() As String
        Get
            Return _ID_GRUPO
        End Get

        Set(ByVal value As String)
            _ID_GRUPO = value
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



End Class

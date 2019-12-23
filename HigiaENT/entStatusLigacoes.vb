Public Class entStatusLigacoes

    Private _ENT_USUARIO As entUsuario

    Private _ID_STATUS As Integer
    Private _CADASTRO_STATUS As String
    

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdStatus() As String
        Get
            Return _ID_STATUS
        End Get

        Set(ByVal value As String)
            _ID_STATUS = value
        End Set

    End Property

    Public Property Status() As String

        Get
            Return _CADASTRO_STATUS
        End Get

        Set(ByVal value As String)
            _CADASTRO_STATUS = value
        End Set

    End Property

End Class

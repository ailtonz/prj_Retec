Public Class entStatusServicos

    Private _ENT_USUARIO As entUsuario

    Private _ID As Integer
    Private _STATUS As String


    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
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

    Public Property Status() As String

        Get
            Return _STATUS
        End Get

        Set(ByVal value As String)
            _STATUS = value
        End Set

    End Property

End Class

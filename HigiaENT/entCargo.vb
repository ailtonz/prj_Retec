Public Class entCargo

    Private _ENT_USUARIO As entUsuario

    Private _ID As Integer
    Private _CARGO As String
    Private _SALARIO As String

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

    Public Property Cargo() As String
        Get
            Return _CARGO
        End Get

        Set(ByVal value As String)
            _CARGO = value
        End Set

    End Property

    Public Property Salario() As String
        Get
            Return _SALARIO
        End Get

        Set(ByVal value As String)
            _SALARIO = value
        End Set

    End Property

End Class

Public Class entFuncionarioCargo

    Private _ENT_USUARIO As entUsuario
    Private _ID_CARGO As Integer
    Private _CADASTRO_USUARIO As String

    Private _CARGO As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property

    Public Property IdCargo() As String
        Get
            Return _ID_CARGO
        End Get

        Set(ByVal value As String)
            _ID_CARGO = value
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
End Class

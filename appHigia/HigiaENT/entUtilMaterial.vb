Public Class entUtilMaterial

    Private _ENT_USUARIO As entUsuario
    Private _ID_MATERIAL As Integer
    Private _MATERIAL As String
    Private _CADASTRO_USUARIO As String

    Public Property ENT_USUARIO() As entUsuario

        Get
            Return _ENT_USUARIO
        End Get

        Set(ByVal value As entUsuario)
            _ENT_USUARIO = value
        End Set

    End Property


    Public Property IdMaterial() As String
        Get
            Return _ID_MATERIAL
        End Get

        Set(ByVal value As String)
            _ID_MATERIAL = value
        End Set

    End Property



    Public Property Material() As String
        Get
            Return _MATERIAL
        End Get

        Set(ByVal value As String)
            _MATERIAL = value
        End Set

    End Property
End Class

Public Class entUtilTelefone

    Private _ENT_USUARIO As entUsuario
    Private _ENT_CONTATO As entContato

    Private _ID_TELEFONE As Integer


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

    Public Property IdTelefone() As String
        Get
            Return _ID_TELEFONE
        End Get

        Set(ByVal value As String)
            _ID_TELEFONE = value
        End Set

    End Property

   
End Class

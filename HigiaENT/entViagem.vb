Public Class entViagem
    Private _HISTORICO As String

    Public Property Historico() As String
        Get
            Return _HISTORICO
        End Get

        Set(ByVal value As String)
            _HISTORICO = value
        End Set

    End Property
End Class

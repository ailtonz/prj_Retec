Public Class Estado

    Private _uf As String
    Private _estado As String

    Public Property UF As String

        Get
            Return _uf
        End Get

        Set(value As String)
            If value <> _uf Then
                _uf = value
            End If
        End Set

    End Property

    Public Property Estado As String

        Get
            Return _estado
        End Get

        Set(value As String)
            If value <> _estado Then
                _estado = value
            End If
        End Set

    End Property

    Public Sub New(ByVal uf As String, ByVal estado As String)
        Me._uf = uf
        Me._estado = estado
    End Sub

End Class

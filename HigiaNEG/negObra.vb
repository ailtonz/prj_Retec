Imports HigiaBCO
Imports HigiaENT

Public Class negObra

    Public Function Incluir(ByVal obj As entObra, ByVal myConnection As String) As Boolean
        Dim db As New bcoObra
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entObra, ByVal myConnection As String) As Boolean
        Dim db As New bcoObra
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entObra, ByVal myConnection As String) As Boolean
        Dim db As New bcoObra
        Return db.Excluir(obj, myConnection)
    End Function

    Public Function relacionarObraCobranca(ByVal idObra As String, ByVal idInscricao As String, ByVal myConnection As String) As Boolean
        Dim db As New bcoObra
        Return db.relacionarObraCobranca(idObra, idInscricao, myConnection)
    End Function

End Class

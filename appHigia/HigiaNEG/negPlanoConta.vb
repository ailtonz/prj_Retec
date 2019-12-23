Imports HigiaBCO
Imports HigiaENT

Public Class negPlanoContaGrupo

    Public Function Incluir(ByVal obj As entPlanoContaGrupo, ByVal myConnection As String) As Boolean
        Dim db As New bcoPlanoContaGrupo
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entPlanoContaGrupo, ByVal myConnection As String) As Boolean
        Dim db As New bcoPlanoContaGrupo
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entPlanoContaGrupo, ByVal myConnection As String) As Boolean
        Dim db As New bcoPlanoContaGrupo
        Return db.Excluir(obj, myConnection)
    End Function


End Class

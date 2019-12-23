Imports HigiaBCO
Imports HigiaENT

Public Class negObservacao

    Public Function Incluir(ByVal obj As entObservacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoObservacao
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entObservacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoObservacao
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entObservacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoObservacao
        Return db.Excluir(obj, myConnection)
    End Function


End Class

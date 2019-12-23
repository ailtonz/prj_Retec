Imports HigiaBCO
Imports HigiaENT

Public Class negObservacao

    Public Function Incluir(ByVal obj As entObservacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoObservacao
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entObservacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoObservacao
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entObservacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoObservacao
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

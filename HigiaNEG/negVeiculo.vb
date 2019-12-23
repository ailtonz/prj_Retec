Imports HigiaBCO
Imports HigiaENT

Public Class negVeiculo

    Public Function Incluir(ByVal obj As entVeiculo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoVeiculo
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entVeiculo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoVeiculo
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entVeiculo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoVeiculo
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

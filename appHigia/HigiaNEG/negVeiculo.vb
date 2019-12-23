Imports HigiaBCO
Imports HigiaENT

Public Class negVeiculo

    Public Function Incluir(ByVal obj As entVeiculo, ByVal myConnection As String) As Boolean
        Dim db As New bcoVeiculo
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entVeiculo, ByVal myConnection As String) As Boolean
        Dim db As New bcoVeiculo
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entVeiculo, ByVal myConnection As String) As Boolean
        Dim db As New bcoVeiculo
        Return db.Excluir(obj, myConnection)
    End Function


End Class

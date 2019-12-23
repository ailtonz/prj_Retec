Imports HigiaBCO
Imports HigiaENT

Public Class negFuncionario

    Public Function Incluir(ByVal obj As entFuncionario, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoFuncionario
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entFuncionario, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoFuncionario
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entFuncionario, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoFuncionario
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

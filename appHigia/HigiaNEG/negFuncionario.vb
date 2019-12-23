Imports HigiaBCO
Imports HigiaENT

Public Class negFuncionario

    Public Function Incluir(ByVal obj As entFuncionario, ByVal myConnection As String) As Boolean
        Dim db As New bcoFuncionario
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entFuncionario, ByVal myConnection As String) As Boolean
        Dim db As New bcoFuncionario
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entFuncionario, ByVal myConnection As String) As Boolean
        Dim db As New bcoFuncionario
        Return db.Excluir(obj, myConnection)
    End Function


End Class

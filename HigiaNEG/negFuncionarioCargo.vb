Imports HigiaBCO
Imports HigiaENT

Public Class negFuncionarioCargo

    Public Function Incluir(ByVal obj As entFuncionarioCargo, ByVal myConnection As String) As Boolean
        Dim db As New bcoFuncionarioCargo
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entFuncionarioCargo, ByVal myConnection As String) As Boolean
        Dim db As New bcoFuncionarioCargo
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entFuncionarioCargo, ByVal myConnection As String) As Boolean
        Dim db As New bcoFuncionarioCargo
        Return db.Excluir(obj, myConnection)
    End Function


End Class

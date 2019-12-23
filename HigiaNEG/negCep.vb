Imports HigiaBCO
Imports HigiaENT

Public Class negCep

    Public Function Incluir(ByVal obj As entCep, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCep
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entCep, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCep
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entCep, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCep
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

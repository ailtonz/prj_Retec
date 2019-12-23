Imports HigiaBCO
Imports HigiaENT

Public Class negCondicao

    Public Function Incluir(ByVal obj As entCondicao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCondicao
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entCondicao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCondicao
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entCondicao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoCondicao
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

Imports HigiaBCO
Imports HigiaENT

Public Class negStatusPrecificacao

    Public Function Incluir(ByVal obj As entStatusPrecificacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusPrecificacao
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entStatusPrecificacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusPrecificacao
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entStatusPrecificacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusPrecificacao
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

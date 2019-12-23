Imports HigiaBCO
Imports HigiaENT

Public Class negStatusServicos

    Public Function Incluir(ByVal obj As entStatusServicos, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusServicos
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entStatusServicos, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusServicos
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entStatusServicos, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusServicos
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

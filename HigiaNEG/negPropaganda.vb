Imports HigiaBCO
Imports HigiaENT

Public Class negPropaganda

    Public Function Incluir(ByVal obj As entPropaganda, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoPropaganda
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entPropaganda, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoPropaganda
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entPropaganda, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoPropaganda
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

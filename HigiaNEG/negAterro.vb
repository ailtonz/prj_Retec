Imports HigiaBCO
Imports HigiaENT

Public Class negAterro

    Public Function Incluir(ByVal obj As entAterro, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoAterro
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entAterro, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoAterro
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entAterro, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoAterro
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

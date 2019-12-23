Imports HigiaBCO
Imports HigiaENT

Public Class negLink

    Public Function Incluir(ByVal obj As entLink, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoLink
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entLink, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoLink
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entLink, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoLink
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

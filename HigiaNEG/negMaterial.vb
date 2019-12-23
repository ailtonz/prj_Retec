Imports HigiaBCO
Imports HigiaENT

Public Class negMaterial

    Public Function Incluir(ByVal obj As entMaterial, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoMaterial
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entMaterial, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoMaterial
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entMaterial, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoMaterial
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

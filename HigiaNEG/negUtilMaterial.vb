Imports HigiaBCO
Imports HigiaENT

Public Class negUtilMaterial

    Public Function Incluir(ByVal obj As entUtilMaterial, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilMaterial
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entUtilMaterial, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilMaterial
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entUtilMaterial, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilMaterial
        Return db.Excluir(obj, myConnection)
    End Function


End Class

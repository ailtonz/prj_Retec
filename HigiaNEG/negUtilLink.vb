Imports HigiaBCO
Imports HigiaENT

Public Class negUtilLink

    Public Function Incluir(ByVal obj As entUtilLink, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilLink
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entUtilLink, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilLink
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entUtilLink, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilLink
        Return db.Excluir(obj, myConnection)
    End Function


End Class

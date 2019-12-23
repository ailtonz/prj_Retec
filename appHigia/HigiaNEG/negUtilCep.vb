Imports HigiaBCO
Imports HigiaENT

Public Class negUtilCep

    Public Function Incluir(ByVal obj As entUtilCep, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilCep
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entUtilCep, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilCep
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entUtilCep, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilCep
        Return db.Excluir(obj, myConnection)
    End Function


End Class

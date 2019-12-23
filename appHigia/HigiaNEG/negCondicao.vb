Imports HigiaBCO
Imports HigiaENT

Public Class negCondicao

    Public Function Incluir(ByVal obj As entCondicao, ByVal myConnection As String) As Boolean
        Dim db As New bcoCondicao
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entCondicao, ByVal myConnection As String) As Boolean
        Dim db As New bcoCondicao
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entCondicao, ByVal myConnection As String) As Boolean
        Dim db As New bcoCondicao
        Return db.Excluir(obj, myConnection)
    End Function


End Class

Imports HigiaBCO
Imports HigiaENT

Public Class negViagem

    Public Function Incluir(ByVal obj As entViagem, ByVal myConnection As String) As Boolean
        Dim db As New bcoViagem
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entViagem, ByVal myConnection As String) As Boolean
        Dim db As New bcoViagem
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entViagem, ByVal myConnection As String) As Boolean
        Dim db As New bcoViagem
        Return db.Excluir(obj, myConnection)
    End Function


End Class

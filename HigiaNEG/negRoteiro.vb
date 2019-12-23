Imports HigiaBCO
Imports HigiaENT

Public Class negRoteiro

    Public Function Incluir(ByVal obj As entRoteiro, ByVal myConnection As String) As Boolean
        Dim db As New bcoRoteiro
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entRoteiro, ByVal myConnection As String) As Boolean
        Dim db As New bcoRoteiro
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entRoteiro, ByVal myConnection As String) As Boolean
        Dim db As New bcoRoteiro
        Return db.Excluir(obj, myConnection)
    End Function


End Class

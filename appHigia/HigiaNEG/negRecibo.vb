Imports HigiaBCO
Imports HigiaENT

Public Class negRecibo

    Public Function Incluir(ByVal obj As entRecibo, ByVal myConnection As String) As Boolean
        Dim db As New bcoRecibo
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entRecibo, ByVal myConnection As String) As Boolean
        Dim db As New bcoRecibo
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entRecibo, ByVal myConnection As String) As Boolean
        Dim db As New bcoRecibo
        Return db.Excluir(obj, myConnection)
    End Function


End Class

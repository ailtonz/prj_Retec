Imports HigiaBCO
Imports HigiaENT

Public Class negHistorico

    Public Function Incluir(ByVal obj As entHistorico, ByVal myConnection As String) As Boolean
        Dim db As New bcoHistorico
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entHistorico, ByVal myConnection As String) As Boolean
        Dim db As New bcoHistorico
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entHistorico, ByVal myConnection As String) As Boolean
        Dim db As New bcoHistorico
        Return db.Excluir(obj, myConnection)
    End Function


End Class

Imports HigiaBCO
Imports HigiaENT

Public Class negTarefa

    Public Function Incluir(ByVal obj As entTarefa, ByVal myConnection As String) As Boolean
        Dim db As New bcoTarefa
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entTarefa, ByVal myConnection As String) As Boolean
        Dim db As New bcoTarefa
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entTarefa, ByVal myConnection As String) As Boolean
        Dim db As New bcoTarefa
        Return db.Excluir(obj, myConnection)
    End Function


End Class

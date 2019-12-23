Imports HigiaBCO
Imports HigiaENT

Public Class negTransportador

    Public Function Incluir(ByVal obj As entTransportador, ByVal myConnection As String) As Boolean
        Dim db As New bcoTransportador
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entTransportador, ByVal myConnection As String) As Boolean
        Dim db As New bcoTransportador
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entTransportador, ByVal myConnection As String) As Boolean
        Dim db As New bcoTransportador
        Return db.Excluir(obj, myConnection)
    End Function


End Class

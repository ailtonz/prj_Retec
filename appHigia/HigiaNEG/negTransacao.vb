Imports HigiaBCO
Imports HigiaENT

Public Class negTransacao

    Public Function Incluir(ByVal obj As entTransacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoTransacao
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entTransacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoTransacao
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entTransacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoTransacao
        Return db.Excluir(obj, myConnection)
    End Function


End Class

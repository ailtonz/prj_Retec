Imports HigiaBCO
Imports HigiaENT

Public Class negPagamento

    Public Function Incluir(ByVal obj As entPagamento, ByVal myConnection As String) As Boolean
        Dim db As New bcoPagamento
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entPagamento, ByVal myConnection As String) As Boolean
        Dim db As New bcoPagamento
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entPagamento, ByVal myConnection As String) As Boolean
        Dim db As New bcoPagamento
        Return db.Excluir(obj, myConnection)
    End Function


End Class

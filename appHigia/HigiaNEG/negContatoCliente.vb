Imports HigiaBCO
Imports HigiaENT

Public Class negContatoCliente

    Public Function Incluir(ByVal obj As entContato, ByVal myConnection As String) As Boolean
        Dim db As New bcoContatoCliente
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entContato, ByVal myConnection As String) As Boolean
        Dim db As New bcoContatoCliente
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entContato, ByVal myConnection As String) As Boolean
        Dim db As New bcoContatoCliente
        Return db.Excluir(obj, myConnection)
    End Function


End Class

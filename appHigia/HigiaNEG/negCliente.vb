Imports HigiaBCO
Imports HigiaENT

Public Class negCliente

    Public Function Incluir(ByVal obj As entCliente, ByVal myConnection As String) As Boolean
        Dim db As New bcoCliente
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entCliente, ByVal myConnection As String) As Boolean
        Dim db As New bcoCliente
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entCliente, ByVal myConnection As String) As Boolean
        Dim db As New bcoCliente
        Return db.Excluir(obj, myConnection)
    End Function

    Public Function relacionarContatos(ByVal idCliente As String, ByVal myConnection As String) As Boolean
        Dim db As New bcoCliente
        Return db.relacionarContatos(idCliente, myConnection)
    End Function

    Public Function relacionarHistoricos(ByVal idCliente As String, ByVal myConnection As String) As Boolean
        Dim db As New bcoCliente
        Return db.relacionarHistoricos(idCliente, myConnection)
    End Function

    Public Function relacionarObras(ByVal idCliente As String, ByVal myConnection As String) As Boolean
        Dim db As New bcoCliente
        Return db.relacionarObras(idCliente, myConnection)
    End Function

End Class

Imports HigiaBCO
Imports HigiaENT

Public Class negLigacao

    Public Function Incluir(ByVal obj As entLigacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoLigacao
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entLigacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoLigacao
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entLigacao, ByVal myConnection As String) As Boolean
        Dim db As New bcoLigacao
        Return db.Excluir(obj, myConnection)
    End Function


End Class

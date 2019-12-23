Imports HigiaBCO
Imports HigiaENT

Public Class negAterro

    Public Function Incluir(ByVal obj As entAterro, ByVal myConnection As String) As Boolean
        Dim db As New bcoAterro
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entAterro, ByVal myConnection As String) As Boolean
        Dim db As New bcoAterro
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entAterro, ByVal myConnection As String) As Boolean
        Dim db As New bcoAterro
        Return db.Excluir(obj, myConnection)
    End Function


End Class

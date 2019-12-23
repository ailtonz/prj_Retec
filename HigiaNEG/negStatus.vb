Imports HigiaBCO
Imports HigiaENT

Public Class negStatus

    Public Function Incluir(ByVal obj As entStatus, ByVal myConnection As String) As Boolean
        Dim db As New bcoStatus
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entStatus, ByVal myConnection As String) As Boolean
        Dim db As New bcoStatus
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entStatus, ByVal myConnection As String) As Boolean
        Dim db As New bcoStatus
        Return db.Excluir(obj, myConnection)
    End Function


End Class

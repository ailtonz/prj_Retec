Imports HigiaBCO
Imports HigiaENT

Public Class negUtilPropaganda

    Public Function Incluir(ByVal obj As entUtilPropaganda, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilPropaganda
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entUtilPropaganda, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilPropaganda
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entUtilPropaganda, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilPropaganda
        Return db.Excluir(obj, myConnection)
    End Function


End Class

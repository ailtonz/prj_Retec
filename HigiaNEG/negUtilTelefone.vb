Imports HigiaBCO
Imports HigiaENT

Public Class negUtilTelefone

    Public Function Incluir(ByVal obj As entUtilTelefone, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilTelefone
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entUtilTelefone, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilTelefone
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entUtilTelefone, ByVal myConnection As String) As Boolean
        Dim db As New bcoUtilTelefone
        Return db.Excluir(obj, myConnection)
    End Function


End Class

Imports HigiaBCO
Imports HigiaENT

Public Class negTelefone

    Public Function Incluir(ByVal obj As entTelefone, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoTelefone
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entTelefone, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoTelefone
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entTelefone, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoTelefone
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

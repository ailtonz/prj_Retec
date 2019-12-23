Imports HigiaBCO
Imports HigiaENT

Public Class negTipoCadastros

    Public Function Incluir(ByVal obj As entTipoCadastros, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoTipoCadastros
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entTipoCadastros, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoTipoCadastros
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entTipoCadastros, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoTipoCadastros
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

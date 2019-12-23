Imports HigiaBCO
Imports HigiaENT

Public Class negDespesa

    Public Function Incluir(ByVal obj As entTitulo, ByVal myConnection As String) As Boolean
        Dim db As New bcoDespesa
        Return db.Incluir(obj, myConnection)
    End Function

    Public Function Alterar(ByVal obj As entTitulo, ByVal myConnection As String) As Boolean
        Dim db As New bcoDespesa
        Return db.Alterar(obj, myConnection)
    End Function

    Public Function Excluir(ByVal obj As entTitulo, ByVal myConnection As String) As Boolean
        Dim db As New bcoDespesa
        Return db.Excluir(obj, myConnection)
    End Function


End Class

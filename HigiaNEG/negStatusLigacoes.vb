Imports HigiaBCO
Imports HigiaENT

Public Class negStatusLigacoes

    Public Function Incluir(ByVal obj As entStatusLigacoes, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusLigacoes
        Return db.Incluir(obj, myConnection, myProcedure)
    End Function

    Public Function Alterar(ByVal obj As entStatusLigacoes, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusLigacoes
        Return db.Alterar(obj, myConnection, myProcedure)
    End Function

    Public Function Excluir(ByVal obj As entStatusLigacoes, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim db As New bcoStatusLigacoes
        Return db.Excluir(obj, myConnection, myProcedure)
    End Function


End Class

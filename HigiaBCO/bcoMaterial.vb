Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoMaterial
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _material As entMaterial, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _material.Id.ToString)
            .AdicionaParametro("p_MATERIAL", _material.Material.ToString)
            .AdicionaParametro("p_USUARIO", _material.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _material As entMaterial, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _material.Id.ToString)
            .AdicionaParametro("p_MATERIAL", _material.Material.ToString)
            .AdicionaParametro("p_USUARIO", _material.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _material As entMaterial, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _material.Id.ToString)
            .AdicionaParametro("p_MATERIAL", "")
            .AdicionaParametro("p_USUARIO", _material.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function


    'Public Function GetAlunos() As List(Of Aluno)
    '    'Obtém todos os alunos
    '    Dim objdb As New AcessoDados
    '    Dim strSql As String = ""
    '    strSql = "Select * from Alunos"
    '    Dim dr As SqlDataReader = objdb.ExecuteAndGetReader(strSql)
    '    Dim lista As New List(Of Aluno)
    '    While dr.Read
    '        Dim alu As Aluno = New Aluno
    '        alu.ClasseId = IIf(IsDBNull(dr("classeid")), 0, dr("classeid"))
    '        alu.AlunoId = IIf(IsDBNull(dr("id")), 0, dr("id"))
    '        alu.NomeAluno = IIf(IsDBNull(dr("nome")), "", dr("nome"))
    '        lista.Add(alu)
    '    End While
    '    dr.Close()
    '    Return lista
    'End Function

End Class

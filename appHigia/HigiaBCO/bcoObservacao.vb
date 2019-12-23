Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoObservacao
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _Observacao As entObservacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_HISTORICO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_CLIENTE", _Observacao.IdRelacao.ToString)
            .AdicionaParametro("p_ID_OBSERVACAO", _Observacao.IdObservacao.ToString)
            .AdicionaParametro("p_OBSERVACAO", _Observacao.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _Observacao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _Observacao As entObservacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_HISTORICO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_ID_CLIENTE", _Observacao.IdRelacao.ToString)
            .AdicionaParametro("p_ID_OBSERVACAO", _Observacao.IdObservacao.ToString)
            .AdicionaParametro("p_OBSERVACAO", _Observacao.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _Observacao.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _Observacao As entObservacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_HISTORICO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

            .AdicionaParametro("p_ID_CLIENTE", _Observacao.IdRelacao.ToString)
            .AdicionaParametro("p_ID_OBSERVACAO", _Observacao.IdObservacao.ToString)
            .AdicionaParametro("p_OBSERVACAO", _Observacao.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _Observacao.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function


End Class

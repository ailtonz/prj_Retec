Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoCondicao
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _condicao As entCondicao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_CONDICOES"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_CONDICAO", _condicao.IdCondicao.ToString)
            .AdicionaParametro("p_CONDICAO_PAGAMENTO", _condicao.CondicaoPagamento.ToString)
            .AdicionaParametro("p_CONDICAO", _condicao.Condicao.ToString)
            .AdicionaParametro("p_USUARIO", _condicao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _condicao As entCondicao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_CONDICOES"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_ID_CONDICAO", _condicao.IdCondicao.ToString)
            .AdicionaParametro("p_CONDICAO_PAGAMENTO", _condicao.CondicaoPagamento.ToString)
            .AdicionaParametro("p_CONDICAO", _condicao.Condicao.ToString)
            .AdicionaParametro("p_USUARIO", _condicao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _condicao As entCondicao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_CONDICOES"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

            .AdicionaParametro("p_ID_CONDICAO", _condicao.IdCondicao.ToString)
            .AdicionaParametro("p_CONDICAO_PAGAMENTO", _condicao.CondicaoPagamento.ToString)
            .AdicionaParametro("p_CONDICAO", _condicao.Condicao.ToString)
            .AdicionaParametro("p_USUARIO", _condicao.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

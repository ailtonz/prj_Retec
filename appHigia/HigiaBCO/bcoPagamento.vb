Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoPagamento
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _pagamento As entPagamento, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

           
            .ComandoProcedure = "sp_ADM_FATURAMENTO_CONDICAO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_FORMA", _pagamento.IdPagamento.ToString)
            .AdicionaParametro("p_FORMA_PAGAMENTO", _pagamento.FormaDePagamento.ToString)
            .AdicionaParametro("p_USUARIO", _pagamento.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _pagamento As entPagamento, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_ADM_FATURAMENTO_CONDICAO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_ID_FORMA", _pagamento.IdPagamento.ToString)
            .AdicionaParametro("p_FORMA_PAGAMENTO", _pagamento.FormaDePagamento.ToString)
            .AdicionaParametro("p_USUARIO", _pagamento.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _pagamento As entPagamento, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "setExclusao"
            .CriaProcedure()

            .AdicionaParametro("p_CADASTRO", "PAGAMENTO")
            .AdicionaParametro("p_ID", _pagamento.IdPagamento.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

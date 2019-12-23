Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoReceita
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _receita As entTitulo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_FLUXO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_MOVIMENTO", _receita.IdTitulo.ToString)
            .AdicionaParametro("p_MOVIMENTO", "RECEITA")

            .AdicionaParametro("p_DataDeEmissao", _receita.DataDeEmissao.ToString)
            .AdicionaParametro("p_CONTA", _receita.ENT_PLANO_CONTA.PlanoDeConta.ToString)
            .AdicionaParametro("p_DataDeVencimento", _receita.DataDeVencimento.ToString)
            .AdicionaParametro("p_ValorOriginal", _receita.ValorOriginal.ToString)
            .AdicionaParametro("p_DataDePagamento", _receita.DataDePagamento.ToString)
            .AdicionaParametro("p_ValorFinal", _receita.ValorFinal.ToString)
            .AdicionaParametro("p_FormaDePagamento", _receita.ENT_FORMA_PAGAMENTO.FormaDePagamento.ToString)
            .AdicionaParametro("p_DOCUMENTO", _receita.Documento.ToString)
            .AdicionaParametro("p_OBSERVACAO", _receita.Observacao.ToString)

            .AdicionaParametro("P_USUARIO", _receita.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _receita As entTitulo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_FLUXO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_MOVIMENTO", _receita.IdTitulo.ToString)
            .AdicionaParametro("p_MOVIMENTO", "RECEITA")

            .AdicionaParametro("p_DataDeEmissao", _receita.DataDeEmissao.ToString)
            .AdicionaParametro("p_CONTA", _receita.ENT_PLANO_CONTA.PlanoDeConta.ToString)
            .AdicionaParametro("p_DataDeVencimento", _receita.DataDeVencimento.ToString)
            .AdicionaParametro("p_ValorOriginal", _receita.ValorOriginal.ToString)
            .AdicionaParametro("p_DataDePagamento", _receita.DataDePagamento.ToString)
            .AdicionaParametro("p_ValorFinal", _receita.ValorFinal.ToString)
            .AdicionaParametro("p_FormaDePagamento", _receita.ENT_FORMA_PAGAMENTO.FormaDePagamento.ToString)
            .AdicionaParametro("p_DOCUMENTO", _receita.Documento.ToString)
            .AdicionaParametro("p_OBSERVACAO", _receita.Observacao.ToString)

            .AdicionaParametro("P_USUARIO", _receita.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _receita As entTitulo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_FLUXO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_MOVIMENTO", _receita.IdTitulo.ToString)
            .AdicionaParametro("p_MOVIMENTO", "RECEITA")

            .AdicionaParametro("p_DataDeEmissao", _receita.DataDeEmissao.ToString)
            .AdicionaParametro("p_CONTA", _receita.ENT_PLANO_CONTA.PlanoDeConta.ToString)
            .AdicionaParametro("p_DataDeVencimento", _receita.DataDeVencimento.ToString)
            .AdicionaParametro("p_ValorOriginal", _receita.ValorOriginal.ToString)
            .AdicionaParametro("p_DataDePagamento", _receita.DataDePagamento.ToString)
            .AdicionaParametro("p_ValorFinal", _receita.ValorFinal.ToString)
            .AdicionaParametro("p_FormaDePagamento", _receita.ENT_FORMA_PAGAMENTO.FormaDePagamento.ToString)
            .AdicionaParametro("p_DOCUMENTO", _receita.Documento.ToString)
            .AdicionaParametro("p_OBSERVACAO", _receita.Observacao.ToString)

            .AdicionaParametro("P_USUARIO", _receita.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function


  

End Class

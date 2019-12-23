Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoDespesa
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _despesa As entTitulo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_FLUXO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_MOVIMENTO", _despesa.IdTitulo.ToString)
            .AdicionaParametro("p_MOVIMENTO", "DESPESA")

            .AdicionaParametro("p_DataDeEmissao", _despesa.DataDeEmissao.ToString)
            .AdicionaParametro("p_CONTA", _despesa.ENT_PLANO_CONTA.PlanoDeConta.ToString)
            .AdicionaParametro("p_DataDeVencimento", _despesa.DataDeVencimento.ToString)
            .AdicionaParametro("p_ValorOriginal", _despesa.ValorOriginal.ToString)
            .AdicionaParametro("p_DataDePagamento", _despesa.DataDePagamento.ToString)
            .AdicionaParametro("p_ValorFinal", _despesa.ValorFinal.ToString)
            .AdicionaParametro("p_FormaDePagamento", _despesa.ENT_FORMA_PAGAMENTO.FormaDePagamento.ToString)
            .AdicionaParametro("p_DOCUMENTO", _despesa.Documento.ToString)
            .AdicionaParametro("p_OBSERVACAO", _despesa.Observacao.ToString)

            .AdicionaParametro("P_USUARIO", _despesa.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _despesa As entTitulo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_FLUXO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_MOVIMENTO", _despesa.IdTitulo.ToString)
            .AdicionaParametro("p_MOVIMENTO", "DESPESA")

            .AdicionaParametro("p_DataDeEmissao", _despesa.DataDeEmissao.ToString)
            .AdicionaParametro("p_CONTA", _despesa.ENT_PLANO_CONTA.PlanoDeConta.ToString)
            .AdicionaParametro("p_DataDeVencimento", _despesa.DataDeVencimento.ToString)
            .AdicionaParametro("p_ValorOriginal", _despesa.ValorOriginal.ToString)
            .AdicionaParametro("p_DataDePagamento", _despesa.DataDePagamento.ToString)
            .AdicionaParametro("p_ValorFinal", _despesa.ValorFinal.ToString)
            .AdicionaParametro("p_FormaDePagamento", _despesa.ENT_FORMA_PAGAMENTO.FormaDePagamento.ToString)
            .AdicionaParametro("p_DOCUMENTO", _despesa.Documento.ToString)
            .AdicionaParametro("p_OBSERVACAO", _despesa.Observacao.ToString)

            .AdicionaParametro("P_USUARIO", _despesa.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _despesa As entTitulo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_FLUXO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_MOVIMENTO", _despesa.IdTitulo.ToString)
            .AdicionaParametro("p_MOVIMENTO", "DESPESA")

            .AdicionaParametro("p_DataDeEmissao", _despesa.DataDeEmissao.ToString)
            .AdicionaParametro("p_CONTA", _despesa.ENT_PLANO_CONTA.PlanoDeConta.ToString)
            .AdicionaParametro("p_DataDeVencimento", _despesa.DataDeVencimento.ToString)
            .AdicionaParametro("p_ValorOriginal", _despesa.ValorOriginal.ToString)
            .AdicionaParametro("p_DataDePagamento", _despesa.DataDePagamento.ToString)
            .AdicionaParametro("p_ValorFinal", _despesa.ValorFinal.ToString)
            .AdicionaParametro("p_FormaDePagamento", _despesa.ENT_FORMA_PAGAMENTO.FormaDePagamento.ToString)
            .AdicionaParametro("p_DOCUMENTO", _despesa.Documento.ToString)
            .AdicionaParametro("p_OBSERVACAO", _despesa.Observacao.ToString)

            .AdicionaParametro("P_USUARIO", _despesa.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function



End Class

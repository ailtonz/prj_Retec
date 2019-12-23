Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoLigacao
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _ligacao As entLigacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_SRV_LIGACAO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_LIGACAO", _ligacao.IdLigacao.ToString)
            .AdicionaParametro("p_ID_CLIENTE", _ligacao.IdCliente.ToString)
            .AdicionaParametro("p_ID_SOLICITANTE", _ligacao.IdSolicitante.ToString)
            .AdicionaParametro("p_ID_OBRA", _ligacao.IdObra.ToString)
            .AdicionaParametro("p_ID_MATERIAL", _ligacao.ENT_MATERIAL.IdMaterial.ToString)

            .AdicionaParametro("p_CLIENTE_STATUS", _ligacao.ENT_STATUS.Status.ToString)

            .AdicionaParametro("p_COLOCA", _ligacao.ENT_SERVICO.Coloca.ToString)
            .AdicionaParametro("p_TROCA", _ligacao.ENT_SERVICO.Troca.ToString)
            .AdicionaParametro("p_RETIRA", _ligacao.ENT_SERVICO.Retira.ToString)

            .AdicionaParametro("p_DT_COLOCA", _ligacao.ENT_SERVICO.DTColoca.ToString)
            .AdicionaParametro("p_DT_TROCA", _ligacao.ENT_SERVICO.DTTroca.ToString)
            .AdicionaParametro("p_DT_RETIRA", _ligacao.ENT_SERVICO.DTRetira.ToString)

            .AdicionaParametro("p_PR_COLOCA", _ligacao.ENT_SERVICO.PRColoca.ToString)
            .AdicionaParametro("p_PR_TROCA", _ligacao.ENT_SERVICO.PRTroca.ToString)
            .AdicionaParametro("p_PR_RETIRA", _ligacao.ENT_SERVICO.PRRetira.ToString)

            .AdicionaParametro("p_OBS_COLOCA", _ligacao.ENT_SERVICO.ObsColoca.ToString)
            .AdicionaParametro("p_OBS_TROCA", _ligacao.ENT_SERVICO.ObsTroca.ToString)
            .AdicionaParametro("p_OBS_RETIRA", _ligacao.ENT_SERVICO.ObsRetira.ToString)
            .AdicionaParametro("p_OBS_LIGACAO", _ligacao.ENT_SERVICO.ObsGeral.ToString)

            .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", _ligacao.ENT_CONTRATO.FormaDePagamento.ToString)
            .AdicionaParametro("P_CONTRATO_FATURAMENTO_DIAS", _ligacao.ENT_CONTRATO.FaturamentoDias.ToString)
            .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", _ligacao.ENT_CONTRATO.PeriodoLocacao.ToString)
            .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", _ligacao.ENT_CONTRATO.RetiradaAutomatica.ToString)
            .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", _ligacao.ENT_CONTRATO.VencimentoAposEntrega.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _ligacao.ENT_CONTRATO.ValorUnitario.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_MORA", _ligacao.ENT_CONTRATO.MultaMora.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_DIA", _ligacao.ENT_CONTRATO.MultaDia.ToString)
            .AdicionaParametro("p_CONTRATO_NFE", _ligacao.ENT_CONTRATO.nfe.ToString)
            .AdicionaParametro("p_CONTRATO_ISS", _ligacao.ENT_CONTRATO.iss.ToString)
            .AdicionaParametro("p_CONTRATO_CTR", _ligacao.ENT_CONTRATO.ctr.ToString)

            .AdicionaParametro("p_COBRANCA_TIPO", _ligacao.ENT_COBRANCA.TipoCobranca.ToString)
            .AdicionaParametro("p_COBRANCA_INSCRICAO", _ligacao.ENT_COBRANCA.Inscricao.ToString)
            .AdicionaParametro("p_COBRANCA_SACADO", _ligacao.ENT_COBRANCA.Sacado.ToString)
            .AdicionaParametro("p_COBRANCA_CEP", _ligacao.ENT_COBRANCA.Cep.ToString)
            .AdicionaParametro("p_COBRANCA_LOGRADOURO", _ligacao.ENT_COBRANCA.Logradouro.ToString)
            .AdicionaParametro("p_COBRANCA_BAIRRO", _ligacao.ENT_COBRANCA.Bairro.ToString)
            .AdicionaParametro("p_COBRANCA_CIDADE", _ligacao.ENT_COBRANCA.Cidade.ToString)
            .AdicionaParametro("p_COBRANCA_ESTADO", _ligacao.ENT_COBRANCA.Estado.ToString)
            .AdicionaParametro("p_COBRANCA_CONTATO", _ligacao.ENT_COBRANCA.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_COBRANCA_TELEFONE", _ligacao.ENT_COBRANCA.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_COBRANCA_EMAIL", _ligacao.ENT_COBRANCA.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_Usuario", _ligacao.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _ligacao As entLigacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_SRV_LIGACAO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_ID_LIGACAO", _ligacao.IdLigacao.ToString)
            .AdicionaParametro("p_ID_CLIENTE", _ligacao.IdCliente.ToString)
            .AdicionaParametro("p_ID_SOLICITANTE", _ligacao.IdSolicitante.ToString)
            .AdicionaParametro("p_ID_OBRA", _ligacao.IdObra.ToString)
            .AdicionaParametro("p_ID_MATERIAL", _ligacao.ENT_MATERIAL.IdMaterial.ToString)

            .AdicionaParametro("p_CLIENTE_STATUS", _ligacao.ENT_STATUS.Status.ToString)

            .AdicionaParametro("p_COLOCA", _ligacao.ENT_SERVICO.Coloca.ToString)
            .AdicionaParametro("p_TROCA", _ligacao.ENT_SERVICO.Troca.ToString)
            .AdicionaParametro("p_RETIRA", _ligacao.ENT_SERVICO.Retira.ToString)

            .AdicionaParametro("p_DT_COLOCA", _ligacao.ENT_SERVICO.DTColoca.ToString)
            .AdicionaParametro("p_DT_TROCA", _ligacao.ENT_SERVICO.DTTroca.ToString)
            .AdicionaParametro("p_DT_RETIRA", _ligacao.ENT_SERVICO.DTRetira.ToString)

            .AdicionaParametro("p_PR_COLOCA", _ligacao.ENT_SERVICO.PRColoca.ToString)
            .AdicionaParametro("p_PR_TROCA", _ligacao.ENT_SERVICO.PRTroca.ToString)
            .AdicionaParametro("p_PR_RETIRA", _ligacao.ENT_SERVICO.PRRetira.ToString)

            .AdicionaParametro("p_OBS_COLOCA", _ligacao.ENT_SERVICO.ObsColoca.ToString)
            .AdicionaParametro("p_OBS_TROCA", _ligacao.ENT_SERVICO.ObsTroca.ToString)
            .AdicionaParametro("p_OBS_RETIRA", _ligacao.ENT_SERVICO.ObsRetira.ToString)
            .AdicionaParametro("p_OBS_LIGACAO", _ligacao.ENT_SERVICO.ObsGeral.ToString)

            .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", _ligacao.ENT_CONTRATO.FormaDePagamento.ToString)
            .AdicionaParametro("P_CONTRATO_FATURAMENTO_DIAS", _ligacao.ENT_CONTRATO.FaturamentoDias.ToString)
            .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", _ligacao.ENT_CONTRATO.PeriodoLocacao.ToString)
            .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", _ligacao.ENT_CONTRATO.RetiradaAutomatica.ToString)
            .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", _ligacao.ENT_CONTRATO.VencimentoAposEntrega.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _ligacao.ENT_CONTRATO.ValorUnitario.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_MORA", _ligacao.ENT_CONTRATO.MultaMora.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_DIA", _ligacao.ENT_CONTRATO.MultaDia.ToString)
            .AdicionaParametro("p_CONTRATO_NFE", _ligacao.ENT_CONTRATO.nfe.ToString)
            .AdicionaParametro("p_CONTRATO_ISS", _ligacao.ENT_CONTRATO.iss.ToString)
            .AdicionaParametro("p_CONTRATO_CTR", _ligacao.ENT_CONTRATO.ctr.ToString)

            .AdicionaParametro("p_COBRANCA_TIPO", _ligacao.ENT_COBRANCA.TipoCobranca.ToString)
            .AdicionaParametro("p_COBRANCA_INSCRICAO", _ligacao.ENT_COBRANCA.Inscricao.ToString)
            .AdicionaParametro("p_COBRANCA_SACADO", _ligacao.ENT_COBRANCA.Sacado.ToString)
            .AdicionaParametro("p_COBRANCA_CEP", _ligacao.ENT_COBRANCA.Cep.ToString)
            .AdicionaParametro("p_COBRANCA_LOGRADOURO", _ligacao.ENT_COBRANCA.Logradouro.ToString)
            .AdicionaParametro("p_COBRANCA_BAIRRO", _ligacao.ENT_COBRANCA.Bairro.ToString)
            .AdicionaParametro("p_COBRANCA_CIDADE", _ligacao.ENT_COBRANCA.Cidade.ToString)
            .AdicionaParametro("p_COBRANCA_ESTADO", _ligacao.ENT_COBRANCA.Estado.ToString)
            .AdicionaParametro("p_COBRANCA_CONTATO", _ligacao.ENT_COBRANCA.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_COBRANCA_TELEFONE", _ligacao.ENT_COBRANCA.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_COBRANCA_EMAIL", _ligacao.ENT_COBRANCA.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_Usuario", _ligacao.ENT_USUARIO.Nome.ToString)



            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _ligacao As entLigacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_DELETE_ALL"
            .CriaProcedure()


            '.AdicionaParametro("p_ID_CLIENTE", _ligacao.ID_Cliente.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function


End Class

Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic


Public Class bcoObra

    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _Obra As entObra, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_OBRA"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_CLIENTE", _Obra.IdRelacao.ToString)
            .AdicionaParametro("p_ID_OBRA", _Obra.IdObra.ToString)

            .AdicionaParametro("p_CEP", _Obra.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _Obra.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _Obra.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _Obra.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _Obra.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _Obra.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _Obra.ENT_ENDERECO.Estado.ToString)


            .AdicionaParametro("p_CONTATO", _Obra.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _Obra.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _Obra.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_COBRANCA_TIPO", _Obra.ENT_COBRANCA.TipoCobranca.ToString)
            .AdicionaParametro("p_COBRANCA_INSCRICAO", _Obra.ENT_COBRANCA.Inscricao.ToString)
            .AdicionaParametro("p_COBRANCA_SACADO", _Obra.ENT_COBRANCA.Sacado.ToString)

            .AdicionaParametro("p_COBRANCA_CEP", _Obra.ENT_COBRANCA.Cep.ToString)
            .AdicionaParametro("p_COBRANCA_LOGRADOURO", _Obra.ENT_COBRANCA.Logradouro.ToString)
            .AdicionaParametro("p_COBRANCA_BAIRRO", _Obra.ENT_COBRANCA.Bairro.ToString)
            .AdicionaParametro("p_COBRANCA_CIDADE", _Obra.ENT_COBRANCA.Cidade.ToString)
            .AdicionaParametro("p_COBRANCA_ESTADO", _Obra.ENT_COBRANCA.Estado.ToString)

            .AdicionaParametro("p_COBRANCA_CONTATO", _Obra.ENT_COBRANCA.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_COBRANCA_TELEFONE", _Obra.ENT_COBRANCA.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_COBRANCA_EMAIL", _Obra.ENT_COBRANCA.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CONTRATO_INICIO", _Obra.ENT_CONTRATO.DataInicio.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _Obra.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_CONTRATO_NF", _Obra.ENT_CONTRATO.nfe.ToString)
            .AdicionaParametro("p_CONTRATO_ISS", _Obra.ENT_CONTRATO.iss.ToString)
            .AdicionaParametro("p_CONTRATO_CTR", _Obra.ENT_CONTRATO.ctr.ToString)

            .AdicionaParametro("p_USUARIO", _Obra.ENT_USUARIO.Nome.ToString)

            .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", _Obra.ENT_CONTRATO.FormaDePagamento.ToString)
            .AdicionaParametro("P_CONTRATO_FATURAMENTO_DIAS", _Obra.ENT_CONTRATO.FaturamentoDias.ToString)
            .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", _Obra.ENT_CONTRATO.PeriodoLocacao.ToString)
            .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", _Obra.ENT_CONTRATO.RetiradaAutomatica.ToString)
            .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", _Obra.ENT_CONTRATO.VencimentoAposEntrega.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_MORA", _Obra.ENT_CONTRATO.MultaMora.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_DIA", _Obra.ENT_CONTRATO.MultaDia.ToString)

            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _Obra.ObsObra.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_LIGACAO", _Obra.ObsLigacao.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_COLOCA", _Obra.ObsColoca.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_TROCA", _Obra.ObsTroca.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_RETIRA", _Obra.ObsRetira.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _Obra As entObra, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_OBRA"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

           .AdicionaParametro("p_ID_CLIENTE", _Obra.IdRelacao.ToString)
            .AdicionaParametro("p_ID_OBRA", _Obra.IdObra.ToString)

            .AdicionaParametro("p_CEP", _Obra.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _Obra.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _Obra.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _Obra.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _Obra.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _Obra.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _Obra.ENT_ENDERECO.Estado.ToString)


            .AdicionaParametro("p_CONTATO", _Obra.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _Obra.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _Obra.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_COBRANCA_TIPO", _Obra.ENT_COBRANCA.TipoCobranca.ToString)
            .AdicionaParametro("p_COBRANCA_INSCRICAO", _Obra.ENT_COBRANCA.Inscricao.ToString)
            .AdicionaParametro("p_COBRANCA_SACADO", _Obra.ENT_COBRANCA.Sacado.ToString)

            .AdicionaParametro("p_COBRANCA_CEP", _Obra.ENT_COBRANCA.Cep.ToString)
            .AdicionaParametro("p_COBRANCA_LOGRADOURO", _Obra.ENT_COBRANCA.Logradouro.ToString)
            .AdicionaParametro("p_COBRANCA_BAIRRO", _Obra.ENT_COBRANCA.Bairro.ToString)
            .AdicionaParametro("p_COBRANCA_CIDADE", _Obra.ENT_COBRANCA.Cidade.ToString)
            .AdicionaParametro("p_COBRANCA_ESTADO", _Obra.ENT_COBRANCA.Estado.ToString)

            .AdicionaParametro("p_COBRANCA_CONTATO", _Obra.ENT_COBRANCA.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_COBRANCA_TELEFONE", _Obra.ENT_COBRANCA.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_COBRANCA_EMAIL", _Obra.ENT_COBRANCA.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CONTRATO_INICIO", _Obra.ENT_CONTRATO.DataInicio.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _Obra.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_CONTRATO_NF", _Obra.ENT_CONTRATO.nfe.ToString)
            .AdicionaParametro("p_CONTRATO_ISS", _Obra.ENT_CONTRATO.iss.ToString)
            .AdicionaParametro("p_CONTRATO_CTR", _Obra.ENT_CONTRATO.ctr.ToString)

            .AdicionaParametro("p_USUARIO", _Obra.ENT_USUARIO.Nome.ToString)

            .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", _Obra.ENT_CONTRATO.FormaDePagamento.ToString)
            .AdicionaParametro("P_CONTRATO_FATURAMENTO_DIAS", _Obra.ENT_CONTRATO.FaturamentoDias.ToString)
            .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", _Obra.ENT_CONTRATO.PeriodoLocacao.ToString)
            .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", _Obra.ENT_CONTRATO.RetiradaAutomatica.ToString)
            .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", _Obra.ENT_CONTRATO.VencimentoAposEntrega.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_MORA", _Obra.ENT_CONTRATO.MultaMora.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_DIA", _Obra.ENT_CONTRATO.MultaDia.ToString)

            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _Obra.ObsObra.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_LIGACAO", _Obra.ObsLigacao.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_COLOCA", _Obra.ObsColoca.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_TROCA", _Obra.ObsTroca.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_RETIRA", _Obra.ObsRetira.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _Obra As entObra, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_OBRA"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

           .AdicionaParametro("p_ID_CLIENTE", _Obra.IdRelacao.ToString)
            .AdicionaParametro("p_ID_OBRA", _Obra.IdObra.ToString)

            .AdicionaParametro("p_CEP", _Obra.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _Obra.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _Obra.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _Obra.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _Obra.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _Obra.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _Obra.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_CONTATO", _Obra.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _Obra.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _Obra.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_COBRANCA_TIPO", _Obra.ENT_COBRANCA.TipoCobranca.ToString)
            .AdicionaParametro("p_COBRANCA_INSCRICAO", _Obra.ENT_COBRANCA.Inscricao.ToString)
            .AdicionaParametro("p_COBRANCA_SACADO", _Obra.ENT_COBRANCA.Sacado.ToString)

            .AdicionaParametro("p_COBRANCA_CEP", _Obra.ENT_COBRANCA.Cep.ToString)
            .AdicionaParametro("p_COBRANCA_LOGRADOURO", _Obra.ENT_COBRANCA.Logradouro.ToString)
            .AdicionaParametro("p_COBRANCA_BAIRRO", _Obra.ENT_COBRANCA.Bairro.ToString)
            .AdicionaParametro("p_COBRANCA_CIDADE", _Obra.ENT_COBRANCA.Cidade.ToString)
            .AdicionaParametro("p_COBRANCA_ESTADO", _Obra.ENT_COBRANCA.Estado.ToString)

            .AdicionaParametro("p_COBRANCA_CONTATO", _Obra.ENT_COBRANCA.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_COBRANCA_TELEFONE", _Obra.ENT_COBRANCA.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_COBRANCA_EMAIL", _Obra.ENT_COBRANCA.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CONTRATO_INICIO", _Obra.ENT_CONTRATO.DataInicio.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _Obra.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_CONTRATO_NF", _Obra.ENT_CONTRATO.nfe.ToString)
            .AdicionaParametro("p_CONTRATO_ISS", _Obra.ENT_CONTRATO.iss.ToString)
            .AdicionaParametro("p_CONTRATO_CTR", _Obra.ENT_CONTRATO.ctr.ToString)

            .AdicionaParametro("p_USUARIO", _Obra.ENT_USUARIO.Nome.ToString)

            .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", _Obra.ENT_CONTRATO.FormaDePagamento.ToString)
            .AdicionaParametro("P_CONTRATO_FATURAMENTO_DIAS", _Obra.ENT_CONTRATO.FaturamentoDias.ToString)
            .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", _Obra.ENT_CONTRATO.PeriodoLocacao.ToString)
            .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", _Obra.ENT_CONTRATO.RetiradaAutomatica.ToString)
            .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", _Obra.ENT_CONTRATO.VencimentoAposEntrega.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_MORA", _Obra.ENT_CONTRATO.MultaMora.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_DIA", _Obra.ENT_CONTRATO.MultaDia.ToString)

            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _Obra.ObsObra.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_LIGACAO", _Obra.ObsLigacao.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_COLOCA", _Obra.ObsColoca.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_TROCA", _Obra.ObsTroca.ToString)
            .AdicionaParametro("p_CONTRATO_OBS_RETIRA", _Obra.ObsRetira.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function



    Public Function relacionarObraCobranca(ByVal idObra As String, ByVal idInscricao As String, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "ADM_setIdClienteObraCobranca"
            .CriaProcedure()

            .AdicionaParametro("p_ID_OBRA", idObra)
            .AdicionaParametro("p_INSCRICAO", idInscricao)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

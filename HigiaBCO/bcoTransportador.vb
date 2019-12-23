Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoTransportador
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _transportador As entTransportador, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_ADM_TRANSPORTADOR"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_TRANSPORTADOR", _transportador.IdTransportador.ToString)

            .AdicionaParametro("p_CADASTRO_TIPO", _transportador.ENT_DOCUMENTO.TipoDocumento.ToString)
            .AdicionaParametro("p_CPF_CCM", _transportador.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_LIMPURB", _transportador.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_NOME", _transportador.Nome.ToString)

            .AdicionaParametro("p_CEP", _transportador.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_ENDERECO", _transportador.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_NUMERO", _transportador.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _transportador.ENT_ENDERECO.Complemento.ToString)
            .AdicionaParametro("p_BAIRRO", _transportador.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _transportador.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _transportador.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_TELEFONE", _transportador.ENT_CONTATO.Telefone.ToString)

            .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", _transportador.ENT_CONTRATO.FormaDePagamento.ToString)

            .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", _transportador.ENT_CONTRATO.PeriodoLocacao.ToString)
            .AdicionaParametro("p_CONTRATO_FATURAMENTO_DIAS", _transportador.ENT_CONTRATO.FaturamentoDias.ToString)
            .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", _transportador.ENT_CONTRATO.RetiradaAutomatica.ToString)
            .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", _transportador.ENT_CONTRATO.VencimentoAposEntrega.ToString)

            .AdicionaParametro("p_CONTRATO_MULTA_MORA", _transportador.ENT_CONTRATO.MultaMora.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_DIA", _transportador.ENT_CONTRATO.MultaDia.ToString)

            .AdicionaParametro("p_FATURAMENTO_COLOCA", _transportador.ENT_CONTRATO.Coloca.ToString)
            .AdicionaParametro("p_FATURAMENTO_TROCA", _transportador.ENT_CONTRATO.Troca.ToString)
            .AdicionaParametro("p_FATURAMENTO_RETIRA", _transportador.ENT_CONTRATO.Retira.ToString)

            .AdicionaParametro("p_PRECO_TIPO", _transportador.ENT_CONTRATO.PrecoTipo.ToString)
            .AdicionaParametro("p_PRECO_VALOR", _transportador.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_USUARIO", _transportador.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _transportador As entTransportador, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_ADM_TRANSPORTADOR"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_ID_TRANSPORTADOR", _transportador.IdTransportador.ToString)

            .AdicionaParametro("p_CADASTRO_TIPO", _transportador.ENT_DOCUMENTO.TipoDocumento.ToString)
            .AdicionaParametro("p_CPF_CCM", _transportador.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_LIMPURB", _transportador.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_NOME", _transportador.Nome.ToString)

            .AdicionaParametro("p_CEP", _transportador.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_ENDERECO", _transportador.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_NUMERO", _transportador.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _transportador.ENT_ENDERECO.Complemento.ToString)
            .AdicionaParametro("p_BAIRRO", _transportador.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _transportador.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _transportador.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_TELEFONE", _transportador.ENT_CONTATO.Telefone.ToString)

            .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", _transportador.ENT_CONTRATO.FormaDePagamento.ToString)

            .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", _transportador.ENT_CONTRATO.PeriodoLocacao.ToString)
            .AdicionaParametro("p_CONTRATO_FATURAMENTO_DIAS", _transportador.ENT_CONTRATO.FaturamentoDias.ToString)
            .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", _transportador.ENT_CONTRATO.RetiradaAutomatica.ToString)
            .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", _transportador.ENT_CONTRATO.VencimentoAposEntrega.ToString)

            .AdicionaParametro("p_CONTRATO_MULTA_MORA", _transportador.ENT_CONTRATO.MultaMora.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_DIA", _transportador.ENT_CONTRATO.MultaDia.ToString)

            .AdicionaParametro("p_FATURAMENTO_COLOCA", _transportador.ENT_CONTRATO.Coloca.ToString)
            .AdicionaParametro("p_FATURAMENTO_TROCA", _transportador.ENT_CONTRATO.Troca.ToString)
            .AdicionaParametro("p_FATURAMENTO_RETIRA", _transportador.ENT_CONTRATO.Retira.ToString)

            .AdicionaParametro("p_PRECO_TIPO", _transportador.ENT_CONTRATO.PrecoTipo.ToString)
            .AdicionaParametro("p_PRECO_VALOR", _transportador.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_USUARIO", _transportador.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _transportador As entTransportador, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_ADM_TRANSPORTADOR"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

            .AdicionaParametro("p_ID_TRANSPORTADOR", _transportador.IdTransportador.ToString)

            .AdicionaParametro("p_CADASTRO_TIPO", _transportador.ENT_DOCUMENTO.TipoDocumento.ToString)
            .AdicionaParametro("p_CPF_CCM", _transportador.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_LIMPURB", _transportador.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_NOME", _transportador.Nome.ToString)

            .AdicionaParametro("p_CEP", _transportador.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_ENDERECO", _transportador.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_NUMERO", _transportador.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _transportador.ENT_ENDERECO.Complemento.ToString)
            .AdicionaParametro("p_BAIRRO", _transportador.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _transportador.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _transportador.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_TELEFONE", _transportador.ENT_CONTATO.Telefone.ToString)

            .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", _transportador.ENT_CONTRATO.FormaDePagamento.ToString)

            .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", _transportador.ENT_CONTRATO.PeriodoLocacao.ToString)
            .AdicionaParametro("p_CONTRATO_FATURAMENTO_DIAS", _transportador.ENT_CONTRATO.FaturamentoDias.ToString)
            .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", _transportador.ENT_CONTRATO.RetiradaAutomatica.ToString)
            .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", _transportador.ENT_CONTRATO.VencimentoAposEntrega.ToString)

            .AdicionaParametro("p_CONTRATO_MULTA_MORA", _transportador.ENT_CONTRATO.MultaMora.ToString)
            .AdicionaParametro("p_CONTRATO_MULTA_DIA", _transportador.ENT_CONTRATO.MultaDia.ToString)

            .AdicionaParametro("p_FATURAMENTO_COLOCA", _transportador.ENT_CONTRATO.Coloca.ToString)
            .AdicionaParametro("p_FATURAMENTO_TROCA", _transportador.ENT_CONTRATO.Troca.ToString)
            .AdicionaParametro("p_FATURAMENTO_RETIRA", _transportador.ENT_CONTRATO.Retira.ToString)

            .AdicionaParametro("p_PRECO_TIPO", _transportador.ENT_CONTRATO.PrecoTipo.ToString)
            .AdicionaParametro("p_PRECO_VALOR", _transportador.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_USUARIO", _transportador.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

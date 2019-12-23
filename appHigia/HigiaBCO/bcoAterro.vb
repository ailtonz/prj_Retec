Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoAterro
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _aterro As entAterro, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_ATERRO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_Cadastro_Tipo", _aterro.CadastroTipo.ToString)
            .AdicionaParametro("p_Nome_Fantasia", _aterro.Nome_Fantasia.ToString)
            .AdicionaParametro("p_Nome", _aterro.Nome.ToString)

            .AdicionaParametro("p_Cep", _aterro.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_Numero", _aterro.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_Complemento", _aterro.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_Endereco", _aterro.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_Bairro", _aterro.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_Cidade", _aterro.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_Estado", _aterro.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_Contato", _aterro.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_Telefone", _aterro.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_Email", _aterro.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _aterro.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _aterro.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_CADASTRO_STATUS", _aterro.Status.ToString)
            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _aterro.Observacao.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _aterro.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("P_USUARIO", _aterro.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _aterro As entAterro, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_ATERRO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_Cadastro_Tipo", _aterro.CadastroTipo.ToString)
            .AdicionaParametro("p_Nome_Fantasia", _aterro.Nome_Fantasia.ToString)
            .AdicionaParametro("p_Nome", _aterro.Nome.ToString)

            .AdicionaParametro("p_Cep", _aterro.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_Numero", _aterro.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_Complemento", _aterro.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_Endereco", _aterro.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_Bairro", _aterro.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_Cidade", _aterro.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_Estado", _aterro.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_Contato", _aterro.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_Telefone", _aterro.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_Email", _aterro.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _aterro.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _aterro.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_CADASTRO_STATUS", _aterro.Status.ToString)
            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _aterro.Observacao.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _aterro.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("P_USUARIO", _aterro.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _aterro As entAterro, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_ATERRO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

            .AdicionaParametro("p_Cadastro_Tipo", _aterro.CadastroTipo.ToString)
            .AdicionaParametro("p_Nome_Fantasia", _aterro.Nome_Fantasia.ToString)
            .AdicionaParametro("p_Nome", _aterro.Nome.ToString)

            .AdicionaParametro("p_Cep", _aterro.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_Numero", _aterro.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_Complemento", _aterro.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_Endereco", _aterro.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_Bairro", _aterro.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_Cidade", _aterro.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_Estado", _aterro.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_Contato", _aterro.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_Telefone", _aterro.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_Email", _aterro.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _aterro.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _aterro.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_CADASTRO_STATUS", _aterro.Status.ToString)
            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _aterro.Observacao.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _aterro.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("P_USUARIO", _aterro.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoAterro
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _aterro As entAterro, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _aterro.Id.ToString)
            .AdicionaParametro("p_TIPO", _aterro.ENT_DOCUMENTO.TipoDocumento.ToString)
            .AdicionaParametro("p_APELIDO", _aterro.NomeFantasia.ToString)
            .AdicionaParametro("p_NOME", _aterro.Nome.ToString)

            .AdicionaParametro("p_CEP", _aterro.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _aterro.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _aterro.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _aterro.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _aterro.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _aterro.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _aterro.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_CONTATO", _aterro.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _aterro.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _aterro.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _aterro.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _aterro.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_OBSERVACAO", _aterro.Observacao.ToString)
            .AdicionaParametro("p_VALOR", _aterro.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_USUARIO", _aterro.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _aterro As entAterro, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _aterro.Id.ToString)
            .AdicionaParametro("p_TIPO", _aterro.ENT_DOCUMENTO.TipoDocumento.ToString)
            .AdicionaParametro("p_APELIDO", _aterro.NomeFantasia.ToString)
            .AdicionaParametro("p_NOME", _aterro.Nome.ToString)

            .AdicionaParametro("p_CEP", _aterro.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _aterro.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _aterro.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _aterro.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _aterro.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _aterro.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _aterro.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_CONTATO", _aterro.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _aterro.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _aterro.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _aterro.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _aterro.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_OBSERVACAO", _aterro.Observacao.ToString)
            .AdicionaParametro("p_VALOR", _aterro.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_USUARIO", _aterro.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _aterro As entAterro, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _aterro.Id.ToString)
            .AdicionaParametro("p_TIPO", _aterro.ENT_DOCUMENTO.TipoDocumento.ToString)
            .AdicionaParametro("p_APELIDO", _aterro.NomeFantasia.ToString)
            .AdicionaParametro("p_NOME", "")

            .AdicionaParametro("p_CEP", _aterro.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _aterro.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _aterro.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _aterro.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _aterro.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _aterro.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _aterro.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_CONTATO", _aterro.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _aterro.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _aterro.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _aterro.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _aterro.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_OBSERVACAO", _aterro.Observacao.ToString)
            .AdicionaParametro("p_VALOR", _aterro.ENT_CONTRATO.ValorUnitario.ToString)

            .AdicionaParametro("p_USUARIO", _aterro.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

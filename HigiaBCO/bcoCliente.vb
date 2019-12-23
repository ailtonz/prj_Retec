Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic


Public Class bcoCliente

    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _cliente As entCliente, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_CLIENTE", _cliente.IdCliente.ToString)

            .AdicionaParametro("p_CADASTRO_TIPO", _cliente.ENT_DOCUMENTO.TipoDocumento.ToString)
            .AdicionaParametro("p_CNPJ_CPF", _cliente.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _cliente.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_NOME", _cliente.Nome.ToString)
            .AdicionaParametro("p_NOME_FANTASIA", _cliente.Nome_Fantasia.ToString)

            .AdicionaParametro("p_CEP", _cliente.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _cliente.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _cliente.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _cliente.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _cliente.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _cliente.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _cliente.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_CONTATO", _cliente.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _cliente.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _cliente.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _cliente.ENT_OBSERVACAO.Observacao.ToString)
            '.AdicionaParametro("p_CADASTRO_STATUS", _cliente.ENT_OBSERVACAO.Status.ToString)
            .AdicionaParametro("p_CADASTRO_STATUS_OBSERVACAO", _cliente.ENT_STATUS.Observacao.ToString)

            .AdicionaParametro("p_CADASTRO_PROPAGANDA", _cliente.ENT_PROPAGANDA.Propaganda.ToString)

            .AdicionaParametro("p_USUARIO", _cliente.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _cliente As entCliente, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_CADASTRO_TIPO", _cliente.ENT_DOCUMENTO.TipoDocumento.ToString)

            .AdicionaParametro("p_ID_CLIENTE", _cliente.IdCliente.ToString)
            .AdicionaParametro("p_CNPJ_CPF", _cliente.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _cliente.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_NOME", _cliente.Nome.ToString)
            .AdicionaParametro("p_NOME_FANTASIA", _cliente.Nome_Fantasia.ToString)

            .AdicionaParametro("p_CEP", _cliente.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _cliente.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _cliente.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _cliente.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _cliente.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _cliente.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _cliente.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_CONTATO", _cliente.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _cliente.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _cliente.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _cliente.ENT_OBSERVACAO.Observacao.ToString)
            '.AdicionaParametro("p_CADASTRO_STATUS", _cliente.ENT_STATUS.Status.ToString)
            .AdicionaParametro("p_CADASTRO_STATUS_OBSERVACAO", _cliente.ENT_STATUS.Observacao.ToString)

            .AdicionaParametro("p_CADASTRO_PROPAGANDA", _cliente.ENT_PROPAGANDA.Propaganda.ToString)

            .AdicionaParametro("p_USUARIO", _cliente.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _cliente As entCliente, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

            .AdicionaParametro("p_CADASTRO_TIPO", _cliente.ENT_DOCUMENTO.TipoDocumento.ToString)

            .AdicionaParametro("p_ID_CLIENTE", _cliente.IdCliente.ToString)
            .AdicionaParametro("p_CNPJ_CPF", _cliente.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _cliente.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_NOME", _cliente.Nome.ToString)
            .AdicionaParametro("p_NOME_FANTASIA", _cliente.Nome_Fantasia.ToString)

            .AdicionaParametro("p_CEP", _cliente.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_NUMERO", _cliente.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _cliente.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_ENDERECO", _cliente.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_BAIRRO", _cliente.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _cliente.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _cliente.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_CONTATO", _cliente.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _cliente.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _cliente.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_CADASTRO_OBSERVACAO", _cliente.ENT_OBSERVACAO.Observacao.ToString)
            '.AdicionaParametro("p_CADASTRO_STATUS", _cliente.ENT_STATUS.Status.ToString)
            .AdicionaParametro("p_CADASTRO_STATUS_OBSERVACAO", _cliente.ENT_STATUS.Observacao.ToString)

            .AdicionaParametro("p_CADASTRO_PROPAGANDA", _cliente.ENT_PROPAGANDA.Propaganda.ToString)

            .AdicionaParametro("p_USUARIO", _cliente.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function relacionarContatos(ByVal idCliente As String, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "ADM_setIdClienteContatos"
            .CriaProcedure()

            .AdicionaParametro("p_ID_CLIENTE", idCliente)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function relacionarHistoricos(ByVal idCliente As String, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "ADM_setIdClienteHistorico"
            .CriaProcedure()

            .AdicionaParametro("p_ID_CLIENTE", idCliente)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function relacionarObras(ByVal idCliente As String, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "ADM_setIdClienteObra"
            .CriaProcedure()

            .AdicionaParametro("p_ID_CLIENTE", idCliente)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

   



End Class

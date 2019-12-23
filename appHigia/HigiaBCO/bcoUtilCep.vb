Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoUtilCep
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _utilCep As entUtilCep, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_CEP"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_CEP", _utilCep.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_ENDERECO", _utilCep.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _utilCep.ENT_ENDERECO.Complemento.ToString)
            .AdicionaParametro("p_BAIRRO", _utilCep.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _utilCep.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _utilCep.ENT_ENDERECO.Estado.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _utilCep.ContratoValor.ToString)
            .AdicionaParametro("p_USUARIO", _utilCep.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _utilCep As entUtilCep, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_CEP"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_CEP", _utilCep.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_ENDERECO", _utilCep.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _utilCep.ENT_ENDERECO.Complemento.ToString)
            .AdicionaParametro("p_BAIRRO", _utilCep.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _utilCep.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _utilCep.ENT_ENDERECO.Estado.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _utilCep.ContratoValor.ToString)
            .AdicionaParametro("p_USUARIO", _utilCep.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _utilCep As entUtilCep, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_CEP"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_CEP", _utilCep.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_ENDERECO", _utilCep.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_COMPLEMENTO", _utilCep.ENT_ENDERECO.Complemento.ToString)
            .AdicionaParametro("p_BAIRRO", _utilCep.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_CIDADE", _utilCep.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_ESTADO", _utilCep.ENT_ENDERECO.Estado.ToString)
            .AdicionaParametro("p_CONTRATO_VALOR", _utilCep.ContratoValor.ToString)
            .AdicionaParametro("p_USUARIO", _utilCep.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

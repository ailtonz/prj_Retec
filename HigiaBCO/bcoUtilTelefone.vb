Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoUtilTelefone
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _utilTelefone As entUtilTelefone, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_TELEFONE"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_TELEFONE", _utilTelefone.IdTelefone.ToString)
            .AdicionaParametro("p_NOME", _utilTelefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _utilTelefone.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _utilTelefone.ENT_CONTATO.Email.ToString)
            .AdicionaParametro("p_CONTATO", _utilTelefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_OBSERVACAO", _utilTelefone.ENT_CONTATO.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _utilTelefone.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _utilTelefone As entUtilTelefone, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_TELEFONE"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_TELEFONE", _utilTelefone.IdTelefone.ToString)
            .AdicionaParametro("p_NOME", _utilTelefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _utilTelefone.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _utilTelefone.ENT_CONTATO.Email.ToString)
            .AdicionaParametro("p_CONTATO", _utilTelefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_OBSERVACAO", _utilTelefone.ENT_CONTATO.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _utilTelefone.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _utilTelefone As entUtilTelefone, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_TELEFONE"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_TELEFONE", _utilTelefone.IdTelefone.ToString)
            .AdicionaParametro("p_NOME", _utilTelefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_TELEFONE", _utilTelefone.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _utilTelefone.ENT_CONTATO.Email.ToString)
            .AdicionaParametro("p_CONTATO", _utilTelefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_OBSERVACAO", _utilTelefone.ENT_CONTATO.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _utilTelefone.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

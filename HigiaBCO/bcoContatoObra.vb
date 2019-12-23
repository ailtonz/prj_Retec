Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoContatoObra

    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _contato As entContato, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CONTATO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_CONTATO", _contato.Id.ToString)
            .AdicionaParametro("p_ID_RELACAO", _contato.IdRelacao.ToString)
            .AdicionaParametro("p_CONTATO_NOME", _contato.NomeContato.ToString)
            .AdicionaParametro("p_CONTATO_TELEFONE", _contato.Telefone.ToString)
            .AdicionaParametro("p_CONTATO_EMAIL", _contato.Email.ToString)
            .AdicionaParametro("p_CONTATO_OBSERVACAO", _contato.Observacao.ToString)

            .AdicionaParametro("p_USUARIO", _contato.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _contato As entContato, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CONTATO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_ID_CONTATO", _contato.Id.ToString)
            .AdicionaParametro("p_ID_RELACAO", _contato.IdRelacao.ToString)
            .AdicionaParametro("p_CONTATO_NOME", _contato.NomeContato.ToString)
            .AdicionaParametro("p_CONTATO_TELEFONE", _contato.Telefone.ToString)
            .AdicionaParametro("p_CONTATO_EMAIL", _contato.Email.ToString)
            .AdicionaParametro("p_CONTATO_OBSERVACAO", _contato.Observacao.ToString)

            .AdicionaParametro("p_USUARIO", _contato.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _contato As entContato, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CONTATO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

            .AdicionaParametro("p_ID_CONTATO", _contato.Id.ToString)
            .AdicionaParametro("p_ID_RELACAO", _contato.IdRelacao.ToString)
            .AdicionaParametro("p_CONTATO_NOME", _contato.NomeContato.ToString)
            .AdicionaParametro("p_CONTATO_TELEFONE", _contato.Telefone.ToString)
            .AdicionaParametro("p_CONTATO_EMAIL", _contato.Email.ToString)
            .AdicionaParametro("p_CONTATO_OBSERVACAO", _contato.Observacao.ToString)

            .AdicionaParametro("p_USUARIO", _contato.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function


End Class

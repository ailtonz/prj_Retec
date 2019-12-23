Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoTransacao
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _transacao As entTransacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_CONDICOES"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_TRANSACAO", _transacao.IdTransacao.ToString)
            .AdicionaParametro("p_TRANSACAO", _transacao.Transacao.ToString)
            .AdicionaParametro("p_USUARIO", _transacao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _transacao As entTransacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_CONDICOES"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_ID_TRANSACAO", _transacao.IdTransacao.ToString)
            .AdicionaParametro("p_TRANSACAO", _transacao.Transacao.ToString)
            .AdicionaParametro("p_USUARIO", _transacao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _transacao As entTransacao, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_CONDICOES"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

            .AdicionaParametro("p_ID_TRANSACAO", _transacao.IdTransacao.ToString)
            .AdicionaParametro("p_TRANSACAO", _transacao.Transacao.ToString)
            .AdicionaParametro("p_USUARIO", _transacao.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoTransacao
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _transacao As entTransacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _transacao.Id.ToString)
            .AdicionaParametro("p_TRANSACAO", _transacao.Transacao.ToString)
            .AdicionaParametro("p_USUARIO", _transacao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _transacao As entTransacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _transacao.Id.ToString)
            .AdicionaParametro("p_TRANSACAO", _transacao.Transacao.ToString)
            .AdicionaParametro("p_USUARIO", _transacao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _transacao As entTransacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _transacao.Id.ToString)
            .AdicionaParametro("p_TRANSACAO", "")
            .AdicionaParametro("p_USUARIO", _transacao.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

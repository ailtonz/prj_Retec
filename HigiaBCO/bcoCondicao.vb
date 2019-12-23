Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoCondicao
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _condicao As entCondicao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _condicao.IdCondicao.ToString)
            .AdicionaParametro("p_DESCRICAO", _condicao.CondicaoPagamento.ToString)
            .AdicionaParametro("p_CONDICAO", _condicao.Condicao.ToString)
            .AdicionaParametro("p_USUARIO", _condicao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _condicao As entCondicao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _condicao.IdCondicao.ToString)
            .AdicionaParametro("p_DESCRICAO", _condicao.CondicaoPagamento.ToString)
            .AdicionaParametro("p_CONDICAO", _condicao.Condicao.ToString)
            .AdicionaParametro("p_USUARIO", _condicao.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _condicao As entCondicao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _condicao.IdCondicao.ToString)
            .AdicionaParametro("p_DESCRICAO", "")
            .AdicionaParametro("p_CONDICAO", _condicao.Condicao.ToString)
            .AdicionaParametro("p_USUARIO", _condicao.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

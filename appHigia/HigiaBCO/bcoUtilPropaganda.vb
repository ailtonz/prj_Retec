Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoUtilPropaganda
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _propaganda As entUtilPropaganda, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_ADM_PROPAGANDA"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_PROPAGANDA", _propaganda.IdPropaganda.ToString)
            .AdicionaParametro("p_PROPAGANDA", _propaganda.Propaganda.ToString)
            .AdicionaParametro("p_USUARIO", _propaganda.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _propaganda As entUtilPropaganda, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_ADM_PROPAGANDA"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_PROPAGANDA", _propaganda.IdPropaganda.ToString)
            .AdicionaParametro("p_PROPAGANDA", _propaganda.Propaganda.ToString)
            .AdicionaParametro("p_USUARIO", _propaganda.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _propaganda As entUtilPropaganda, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_ADM_PROPAGANDA"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_PROPAGANDA", _propaganda.IdPropaganda.ToString)
            .AdicionaParametro("p_PROPAGANDA", _propaganda.Propaganda.ToString)
            .AdicionaParametro("p_USUARIO", _propaganda.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

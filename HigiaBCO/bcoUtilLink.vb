Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoUtilLink
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _utilLink As entUtilLink, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_LINK"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_LINK", _utilLink.IdLink.ToString)
            .AdicionaParametro("p_DESCRICAO", _utilLink.Descricao.ToString)
            .AdicionaParametro("p_LINK", _utilLink.Link.ToString)
            .AdicionaParametro("p_USUARIO", _utilLink.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _utilLink As entUtilLink, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_LINK"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_LINK", _utilLink.IdLink.ToString)
            .AdicionaParametro("p_DESCRICAO", _utilLink.Descricao.ToString)
            .AdicionaParametro("p_LINK", _utilLink.Link.ToString)
            .AdicionaParametro("p_USUARIO", _utilLink.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _utilLink As entUtilLink, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_UTEIS_LINK"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_LINK", _utilLink.IdLink.ToString)
            .AdicionaParametro("p_DESCRICAO", _utilLink.Descricao.ToString)
            .AdicionaParametro("p_LINK", _utilLink.Link.ToString)
            .AdicionaParametro("p_USUARIO", _utilLink.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

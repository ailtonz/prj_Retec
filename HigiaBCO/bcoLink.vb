Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoLink
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _utilLink As entLink, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _utilLink.Id.ToString)
            .AdicionaParametro("p_DESCRICAO", _utilLink.Descricao.ToString)
            .AdicionaParametro("p_LINK", _utilLink.Link.ToString)
            .AdicionaParametro("p_USUARIO", _utilLink.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _utilLink As entLink, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _utilLink.Id.ToString)
            .AdicionaParametro("p_DESCRICAO", _utilLink.Descricao.ToString)
            .AdicionaParametro("p_LINK", _utilLink.Link.ToString)
            .AdicionaParametro("p_USUARIO", _utilLink.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _utilLink As entLink, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _utilLink.Id.ToString)
            .AdicionaParametro("p_DESCRICAO", "")
            .AdicionaParametro("p_LINK", _utilLink.Link.ToString)
            .AdicionaParametro("p_USUARIO", _utilLink.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoPlanoContaGrupo
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _planoContaGrupo As entPlanoContaGrupo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_PCONTAS_GRUPOS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_PLANO", _planoContaGrupo.IdGrupo.ToString)
            .AdicionaParametro("p_GRUPO", _planoContaGrupo.GrupoDeConta.ToString)
            .AdicionaParametro("p_USUARIO", _planoContaGrupo.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _planoContaGrupo As entPlanoContaGrupo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_PCONTAS_GRUPOS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_PLANO", _planoContaGrupo.IdGrupo.ToString)
            .AdicionaParametro("p_GRUPO", _planoContaGrupo.GrupoDeConta.ToString)
            .AdicionaParametro("p_USUARIO", _planoContaGrupo.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _planoContaGrupo As entPlanoContaGrupo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_PCONTAS_GRUPOS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_PLANO", _planoContaGrupo.IdGrupo.ToString)
            .AdicionaParametro("p_GRUPO", _planoContaGrupo.GrupoDeConta.ToString)
            .AdicionaParametro("p_USUARIO", _planoContaGrupo.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

﻿Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoStatusLigacoes
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _status As entStatusLigacoes, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _status.IdStatus.ToString)
            .AdicionaParametro("p_STATUS", _status.Status.ToString)
            .AdicionaParametro("p_USUARIO", _status.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _status As entStatusLigacoes, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _status.IdStatus.ToString)
            .AdicionaParametro("p_STATUS", _status.Status.ToString)
            .AdicionaParametro("p_USUARIO", _status.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _status As entStatusLigacoes, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _status.IdStatus.ToString)
            .AdicionaParametro("p_STATUS", _status.Status.ToString)
            .AdicionaParametro("p_USUARIO", _status.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class
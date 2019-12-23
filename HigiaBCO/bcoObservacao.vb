Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoObservacao
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _obs As entObservacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _obs.Id.ToString)
            .AdicionaParametro("p_OBSERVACAO", _obs.Observacao.ToString)
            .AdicionaParametro("p_STATUS", _obs.ENT_SERVICO.Status.ToString)


            .AdicionaParametro("p_USUARIO", _obs.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _obs As entObservacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _obs.Id.ToString)
            .AdicionaParametro("p_OBSERVACAO", _obs.Observacao.ToString)
            .AdicionaParametro("p_STATUS", _obs.ENT_SERVICO.Status.ToString)


            .AdicionaParametro("p_USUARIO", _obs.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _obs As entObservacao, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _obs.Id.ToString)
            .AdicionaParametro("p_OBSERVACAO", "")
            .AdicionaParametro("p_STATUS", _obs.ENT_SERVICO.Status.ToString)


            .AdicionaParametro("p_USUARIO", _obs.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

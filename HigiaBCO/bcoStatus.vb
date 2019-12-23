Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoStatus
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _status As entStatus, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_STATUS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_STATUS", _status.IdStatus.ToString)
            .AdicionaParametro("p_OBSERVACAO", _status.Observacao.ToString)
            .AdicionaParametro("p_STATUS", _status.Status.ToString)

            .AdicionaParametro("p_USUARIO", _status.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _status As entStatus, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_STATUS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_STATUS", _status.IdStatus.ToString)
            .AdicionaParametro("p_OBSERVACAO", _status.Observacao.ToString)
            .AdicionaParametro("p_STATUS", _status.Status.ToString)

            .AdicionaParametro("p_USUARIO", _status.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _status As entStatus, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_STATUS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_STATUS", _status.IdStatus.ToString)
            .AdicionaParametro("p_OBSERVACAO", _status.Observacao.ToString)
            .AdicionaParametro("p_STATUS", _status.Status.ToString)

            .AdicionaParametro("p_USUARIO", _status.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

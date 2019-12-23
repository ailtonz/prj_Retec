Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoPlanoConta
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _planoConta As entPlanoConta, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_PCONTAS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_PLANO", _planoConta.IdPlano.ToString)
            .AdicionaParametro("p_CONTA", _planoConta.PlanoDeConta.ToString)
            .AdicionaParametro("p_GRUPO", _planoConta.GrupoDeConta.ToString)
            .AdicionaParametro("p_FREQUENCIA", _planoConta.Frequencia.ToString)
            .AdicionaParametro("p_PLANO", _planoConta.Plano.ToString)
            .AdicionaParametro("p_USUARIO", _planoConta.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _planoConta As entPlanoConta, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_PCONTAS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_PLANO", _planoConta.IdPlano.ToString)
            .AdicionaParametro("p_CONTA", _planoConta.PlanoDeConta.ToString)
            .AdicionaParametro("p_GRUPO", _planoConta.GrupoDeConta.ToString)
            .AdicionaParametro("p_FREQUENCIA", _planoConta.Frequencia.ToString)
            .AdicionaParametro("p_PLANO", _planoConta.Plano.ToString)
            .AdicionaParametro("p_USUARIO", _planoConta.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _planoConta As entPlanoConta, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_MOV_PCONTAS"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_PLANO", _planoConta.IdPlano.ToString)
            .AdicionaParametro("p_CONTA", _planoConta.PlanoDeConta.ToString)
            .AdicionaParametro("p_GRUPO", _planoConta.GrupoDeConta.ToString)
            .AdicionaParametro("p_FREQUENCIA", _planoConta.Frequencia.ToString)
            .AdicionaParametro("p_PLANO", _planoConta.Plano.ToString)
            .AdicionaParametro("p_USUARIO", _planoConta.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

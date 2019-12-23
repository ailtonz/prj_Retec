Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoFuncionarioCargo
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _cargo As entFuncionarioCargo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_FUNCIONARIO_CARGO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")
            .AdicionaParametro("p_ID_CARGO", _cargo.IdCargo.ToString)
            .AdicionaParametro("p_CARGO", _cargo.Cargo.ToString)
            .AdicionaParametro("P_USUARIO", _cargo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _cargo As entFuncionarioCargo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_FUNCIONARIO_CARGO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")
            .AdicionaParametro("p_ID_CARGO", _cargo.IdCargo.ToString)
            .AdicionaParametro("p_CARGO", _cargo.Cargo.ToString)
            .AdicionaParametro("P_USUARIO", _cargo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _cargo As entFuncionarioCargo, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_FUNCIONARIO_CARGO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")
            .AdicionaParametro("p_ID_CARGO", _cargo.IdCargo.ToString)
            .AdicionaParametro("p_CARGO", _cargo.Cargo.ToString)
            .AdicionaParametro("P_USUARIO", _cargo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

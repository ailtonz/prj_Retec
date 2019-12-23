Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoCargo
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _cargo As entCargo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _cargo.Id.ToString)
            .AdicionaParametro("p_CARGO", _cargo.Cargo.ToString)
            .AdicionaParametro("P_USUARIO", _cargo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _cargo As entCargo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _cargo.Id.ToString)
            .AdicionaParametro("p_CARGO", _cargo.Cargo.ToString)
            .AdicionaParametro("P_USUARIO", _cargo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _cargo As entCargo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _cargo.Id.ToString)
            .AdicionaParametro("p_CARGO", "")
            .AdicionaParametro("P_USUARIO", _cargo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

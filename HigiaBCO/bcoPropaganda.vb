Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoPropaganda
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _propaganda As entPropaganda, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _propaganda.Id.ToString)
            .AdicionaParametro("p_PROPAGANDA", _propaganda.Propaganda.ToString)
            .AdicionaParametro("p_USUARIO", _propaganda.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _propaganda As entPropaganda, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _propaganda.Id.ToString)
            .AdicionaParametro("p_PROPAGANDA", _propaganda.Propaganda.ToString)
            .AdicionaParametro("p_USUARIO", _propaganda.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function


    Public Function Excluir(ByVal _propaganda As entPropaganda, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _propaganda.Id.ToString)
            .AdicionaParametro("p_PROPAGANDA", "")
            .AdicionaParametro("p_USUARIO", "")

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function


End Class

Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoVeiculo
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _veiculo As entVeiculo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _veiculo.Id.ToString)
            .AdicionaParametro("p_PLACA", _veiculo.Placa.ToString)
            .AdicionaParametro("p_MODELO", _veiculo.Modelo.ToString)

            .AdicionaParametro("p_Usuario", _veiculo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _veiculo As entVeiculo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _veiculo.Id.ToString)
            .AdicionaParametro("p_PLACA", _veiculo.Placa.ToString)
            .AdicionaParametro("p_MODELO", _veiculo.Modelo.ToString)

            .AdicionaParametro("p_Usuario", _veiculo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _veiculo As entVeiculo, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _veiculo.Id.ToString)
            .AdicionaParametro("p_PLACA", "")
            .AdicionaParametro("p_MODELO", _veiculo.Modelo.ToString)

            .AdicionaParametro("p_Usuario", _veiculo.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoTelefone
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _Telefone As entTelefone, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _Telefone.Id.ToString)
            .AdicionaParametro("p_NOME", _Telefone.Descricao.ToString)
            .AdicionaParametro("p_TELEFONE", _Telefone.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _Telefone.ENT_CONTATO.Email.ToString)
            .AdicionaParametro("p_CONTATO", _Telefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_OBSERVACAO", _Telefone.ENT_CONTATO.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _Telefone.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _Telefone As entTelefone, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _Telefone.Id.ToString)
            .AdicionaParametro("p_NOME", _Telefone.Descricao.ToString)
            .AdicionaParametro("p_TELEFONE", _Telefone.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _Telefone.ENT_CONTATO.Email.ToString)
            .AdicionaParametro("p_CONTATO", _Telefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_OBSERVACAO", _Telefone.ENT_CONTATO.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _Telefone.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _Telefone As entTelefone, ByVal myConnection As String, ByVal myProcedure As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = myProcedure
            .CriaProcedure()

            .AdicionaParametro("p_ID", _Telefone.Id.ToString)
            .AdicionaParametro("p_NOME", "")
            .AdicionaParametro("p_TELEFONE", _Telefone.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_EMAIL", _Telefone.ENT_CONTATO.Email.ToString)
            .AdicionaParametro("p_CONTATO", _Telefone.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_OBSERVACAO", _Telefone.ENT_CONTATO.Observacao.ToString)
            .AdicionaParametro("p_USUARIO", _Telefone.ENT_USUARIO.Nome.ToString)

            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

End Class

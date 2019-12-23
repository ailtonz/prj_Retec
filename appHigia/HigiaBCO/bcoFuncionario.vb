Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoFuncionario
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _funcionario As entFuncionario, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_FUNCIONARIO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "INSERT")

            .AdicionaParametro("p_ID_FUNCIONARIO", _funcionario.IdFuncionario.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _funcionario.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _funcionario.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_CARGO", _funcionario.Cargo.ToString)
            .AdicionaParametro("P_NOME", _funcionario.Nome.ToString)

            .AdicionaParametro("p_Cep", _funcionario.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_Numero", _funcionario.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_Complemento", _funcionario.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_Endereco", _funcionario.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_Bairro", _funcionario.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_Cidade", _funcionario.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_Estado", _funcionario.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_Contato", _funcionario.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_Telefone", _funcionario.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_Email", _funcionario.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_Usuario", _funcionario.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _funcionario As entFuncionario, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_FUNCIONARIO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "UPDATE")

            .AdicionaParametro("p_ID_FUNCIONARIO", _funcionario.IdFuncionario.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _funcionario.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _funcionario.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_CARGO", _funcionario.Cargo.ToString)
            .AdicionaParametro("P_NOME", _funcionario.Nome.ToString)

            .AdicionaParametro("p_Cep", _funcionario.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_Numero", _funcionario.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_Complemento", _funcionario.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_Endereco", _funcionario.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_Bairro", _funcionario.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_Cidade", _funcionario.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_Estado", _funcionario.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_Contato", _funcionario.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_Telefone", _funcionario.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_Email", _funcionario.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_Usuario", _funcionario.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _funcionario As entFuncionario, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_FUNCIONARIO"
            .CriaProcedure()

            .AdicionaParametro("p_ACAO", "DELETE_ALL")

            .AdicionaParametro("p_ID_FUNCIONARIO", _funcionario.IdFuncionario.ToString)

            .AdicionaParametro("p_CNPJ_CPF", _funcionario.ENT_DOCUMENTO.CNPJ_CPF.ToString)
            .AdicionaParametro("p_IE_RG", _funcionario.ENT_DOCUMENTO.IE_RG.ToString)

            .AdicionaParametro("p_CARGO", _funcionario.Cargo.ToString)
            .AdicionaParametro("P_NOME", _funcionario.Nome.ToString)

            .AdicionaParametro("p_Cep", _funcionario.ENT_ENDERECO.Cep.ToString)
            .AdicionaParametro("p_Numero", _funcionario.ENT_ENDERECO.Numero.ToString)
            .AdicionaParametro("p_Complemento", _funcionario.ENT_ENDERECO.Complemento.ToString)

            .AdicionaParametro("p_Endereco", _funcionario.ENT_ENDERECO.Endereco.ToString)
            .AdicionaParametro("p_Bairro", _funcionario.ENT_ENDERECO.Bairro.ToString)
            .AdicionaParametro("p_Cidade", _funcionario.ENT_ENDERECO.Cidade.ToString)
            .AdicionaParametro("p_Estado", _funcionario.ENT_ENDERECO.Estado.ToString)

            .AdicionaParametro("p_Contato", _funcionario.ENT_CONTATO.NomeContato.ToString)
            .AdicionaParametro("p_Telefone", _funcionario.ENT_CONTATO.Telefone.ToString)
            .AdicionaParametro("p_Email", _funcionario.ENT_CONTATO.Email.ToString)

            .AdicionaParametro("p_Usuario", _funcionario.ENT_USUARIO.Nome.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function


    'Public Function GetAlunos() As List(Of Aluno)
    '    'Obtém todos os alunos
    '    Dim objdb As New AcessoDados
    '    Dim strSql As String = ""
    '    strSql = "Select * from Alunos"
    '    Dim dr As SqlDataReader = objdb.ExecuteAndGetReader(strSql)
    '    Dim lista As New List(Of Aluno)
    '    While dr.Read
    '        Dim alu As Aluno = New Aluno
    '        alu.ClasseId = IIf(IsDBNull(dr("classeid")), 0, dr("classeid"))
    '        alu.AlunoId = IIf(IsDBNull(dr("id")), 0, dr("id"))
    '        alu.NomeAluno = IIf(IsDBNull(dr("nome")), "", dr("nome"))
    '        lista.Add(alu)
    '    End While
    '    dr.Close()
    '    Return lista
    'End Function

End Class

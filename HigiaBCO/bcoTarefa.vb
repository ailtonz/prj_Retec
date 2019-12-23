Imports MySql.Data.MySqlClient
Imports HigiaENT
Imports HigiaBCO
Imports System.Collections.Generic

Public Class bcoTarefa
    Protected BancoDados As AcessoDados

    Public Function Incluir(ByVal _tarefa As entTarefa, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_INSERT"
            .CriaProcedure()


            '.AdicionaParametro("p_Cadastro_Tipo", _tarefa.TipoCliente.ToString)
            '.AdicionaParametro("p_Nome_Fantasia", _tarefa.Nome_Fantasia.ToString)
            '.AdicionaParametro("p_Nome", _tarefa.Nome.ToString)

            '.AdicionaParametro("p_Endereco", _tarefa.ENT_ENDERECO.Endereco.ToString)
            '.AdicionaParametro("p_Numero", _tarefa.ENT_ENDERECO.Numero.ToString)
            '.AdicionaParametro("p_Complemento", _tarefa.ENT_ENDERECO.Complemento.ToString)
            '.AdicionaParametro("p_Bairro", _tarefa.ENT_ENDERECO.Bairro.ToString)
            '.AdicionaParametro("p_Cep", _tarefa.ENT_ENDERECO.Cep.ToString)
            '.AdicionaParametro("p_Cidade", _tarefa.ENT_ENDERECO.Cidade.ToString)
            '.AdicionaParametro("p_Estado", _tarefa.ENT_ENDERECO.Estado.ToString)

            '.AdicionaParametro("p_Contato", _tarefa.ENT_CONTATO.Contato.ToString)
            '.AdicionaParametro("p_Telefone", _tarefa.ENT_CONTATO.Telefone.ToString)
            '.AdicionaParametro("p_Email", _tarefa.ENT_CONTATO.Email.ToString)

            '.AdicionaParametro("p_CNPJ_CPF", _tarefa.CNPJ_CPF.ToString)
            '.AdicionaParametro("p_IE_RG", _tarefa.IE_RG.ToString)
            '.AdicionaParametro("p_Cadastro_Propaganda", _tarefa.Propaganda.ToString)

            '.AdicionaParametro("p_Usuario", _tarefa.CadastroUsuario.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Alterar(ByVal _tarefa As entTarefa, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_UPDATE"
            .CriaProcedure()


            '.AdicionaParametro("p_Cadastro_Tipo", _tarefa.TipoCliente.ToString)
            '.AdicionaParametro("p_Nome_Fantasia", _tarefa.Nome_Fantasia.ToString)
            '.AdicionaParametro("p_Nome", _tarefa.Nome.ToString)

            '.AdicionaParametro("p_Endereco", _tarefa.ENT_ENDERECO.Endereco.ToString)
            '.AdicionaParametro("p_Numero", _tarefa.ENT_ENDERECO.Numero.ToString)
            '.AdicionaParametro("p_Complemento", _tarefa.ENT_ENDERECO.Complemento.ToString)
            '.AdicionaParametro("p_Bairro", _tarefa.ENT_ENDERECO.Bairro.ToString)
            '.AdicionaParametro("p_Cep", _tarefa.ENT_ENDERECO.Cep.ToString)
            '.AdicionaParametro("p_Cidade", _tarefa.ENT_ENDERECO.Cidade.ToString)
            '.AdicionaParametro("p_Estado", _tarefa.ENT_ENDERECO.Estado.ToString)

            '.AdicionaParametro("p_Contato", _tarefa.ENT_CONTATO.Contato.ToString)
            '.AdicionaParametro("p_Telefone", _tarefa.ENT_CONTATO.Telefone.ToString)
            '.AdicionaParametro("p_Email", _tarefa.ENT_CONTATO.Email.ToString)

            '.AdicionaParametro("p_CNPJ_CPF", _tarefa.CNPJ_CPF.ToString)
            '.AdicionaParametro("p_IE_RG", _tarefa.IE_RG.ToString)
            '.AdicionaParametro("p_Cadastro_Propaganda", _tarefa.Propaganda.ToString)

            '.AdicionaParametro("p_Usuario", _tarefa.CadastroUsuario.ToString)


            .ExecutaProcedure()
            .Fechar()

        End With

        Return True

    End Function

    Public Function Excluir(ByVal _tarefa As entTarefa, ByVal myConnection As String) As Boolean
        Dim oBanco As New AcessoDados(myConnection)

        With oBanco
            .Abrir()

            .ComandoProcedure = "sp_CAD_CLIENTE_DELETE_ALL"
            .CriaProcedure()


            '.AdicionaParametro("p_ID_CLIENTE", _tarefa.ID_Cliente.ToString)


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

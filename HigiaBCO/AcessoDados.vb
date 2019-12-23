Imports System
Imports System.Configuration

Imports MySql.Data.MySqlClient

Public Class AcessoDados
    Private ConexaoBD As MySqlConnection
    Private Comandos As MySqlCommand
    Private DataAdapter As MySqlDataAdapter
    Private strComandoSQL, strOperacao, strChavePesquisa, strComandoProcedure As String
    Private _mySqlConnection As MySqlConnection

    ' Construtor
    Public Sub New(ByVal strConexao As String)
        ConexaoBD = New MySqlConnection(strConexao)
        strOperacao = ""
    End Sub

    Sub New(mySqlConnection As MySqlConnection)
        ' TODO: Complete member initialization 
        _mySqlConnection = mySqlConnection
    End Sub

    ' Abertura do Banco de Dados
    Public Sub Abrir() 'As Boolean
        'Dim blnRetorno As Boolean
        'blnRetorno = True

        Try
            ConexaoBD.Open()
        Catch excecao As MySqlException
            MsgBox("Erro ao tentar conectar com o banco de dados: " + excecao.Message)
            'blnRetorno = False
            'Finally
            '    ConexaoBD.Dispose()
        End Try

        'Return blnRetorno
    End Sub

    ' Fechamento do Banco de Dados
    Public Sub Fechar()
        ConexaoBD.Close()
    End Sub

    ' Ajusta o membro "strOperacao"
    Public Property Operacao As String
        Get
            Return strOperacao
        End Get

        Set(ByVal value As String)
            strOperacao = value
        End Set
    End Property

    ' Ajusta o membro "strComandoSQL"
    Public Property ComandoSQL As String
        Get
            Return strComandoSQL
        End Get

        Set(ByVal value As String)
            strComandoSQL = value
        End Set
    End Property

    ' Ajusta o membro "ComandoProcedure"
    Public Property ComandoProcedure As String
        Get
            Return strComandoProcedure
        End Get

        Set(ByVal value As String)
            strComandoProcedure = value
        End Set
    End Property

    ' Cria o objeto CriaProcedure
    Public Sub CriaProcedure()
        Comandos = New MySqlCommand(strComandoProcedure, ConexaoBD)
        Comandos.CommandType = CommandType.StoredProcedure
    End Sub

    ' Cria o objeto cmbComandoSQL
    Public Sub CriaComandoSQL()
        Comandos = New MySqlCommand(strComandoSQL, ConexaoBD)
    End Sub

    ' Apaga todos os parêmtros que existirem no objeto Comandos
    Public Sub LimparParametros()
        Comandos.Parameters.Clear()
    End Sub

    ' Adiciona o parâmetro ao objeto Comandos
    Public Sub AdicionaParametro(ByVal strNomeParametro As String, ByVal strValor As String)
        Try
            Comandos.Parameters.AddWithValue(strNomeParametro, strValor)
        Catch excecao As MySqlException
            MsgBox("Erro em tempo de execução: " + excecao.Message)
        End Try
    End Sub

    ' Executa o comando do banco de dados
    Public Sub ExecutaProcedure() 'As Boolean
        'Dim blnRetorno As Boolean
        'blnRetorno = True

        Try
            Comandos.ExecuteNonQuery()
            'Try
            '    Comandos.ExecuteNonQuery()
            'Catch excecao As Exception
            '    MsgBox("Erro ao executar procedure: " + strComandoProcedure + excecao.Message)
            'End Try

        Catch excecao As MySqlException
            MsgBox("Erro ao executar procedure: " + strComandoProcedure + excecao.Message)
            'blnRetorno = False
        End Try

        Comandos.Dispose()

        'Return blnRetorno
    End Sub

    ' Executa o comando do banco de dados
    Public Function ExecutaSQL() As Boolean
        Dim blnRetorno As Boolean
        blnRetorno = True

        Try
            Comandos.ExecuteNonQuery()
        Catch excecao As MySqlException
            MsgBox("Erro ao executar SQL: " + excecao.Message)
            blnRetorno = False
        End Try

        Comandos.Dispose()

        Return blnRetorno
    End Function

    ' Retorna a conexão criada com o banco de dados
    Public Function ConexaoAtiva()
        Return ConexaoBD
    End Function

    ' Cria o objeto DataAdapter
    Public Sub CriaDataAdapter()
        DataAdapter = New MySqlDataAdapter
    End Sub

    ' Atribui à propriedade SelectCommand de DataAdapter o conteúdo de Comandos
    Public Sub DataAdapterComando()
        DataAdapter.SelectCommand = Comandos
    End Sub

    ' Preenche uma tabela com os dados retornados
    Public Sub PreencherDataSet(ByVal MeuDataSet As System.Data.DataTable)
        DataAdapter.Fill(MeuDataSet)
    End Sub


End Class

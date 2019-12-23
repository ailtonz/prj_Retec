Imports System
Imports System.Configuration

Imports MySql.Data.MySqlClient

Public Class F_tmp_PSQ_CLIENTES
    Protected rotinas As ClasseRotinasDiversas
    Property strValorRetorno As String
    Property strSQL As String
    Property strTable As String

    Dim BancoDados As ClasseBancoDados

    Private Shared Function GetConnectionStringByName(ByVal name As String) As String
        ' Retrieves a connection string by name.
        ' Returns Nothing if the name is not found.

        ' Assume failure
        Dim returnValue As String = Nothing

        ' Look for the name in the connectionStrings section.
        Dim settings As ConnectionStringSettings = _
           ConfigurationManager.ConnectionStrings(name)

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            returnValue = settings.ConnectionString
        End If

        Return returnValue
    End Function

    Private Sub F_CLIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'CONEXAO - ABRIR
        BancoDados = New ClasseBancoDados(GetConnectionStringByName("servidor"))
        BancoDados.Abrir()

        'VARIAVEIS
        Dim cmd As New MySqlCommand(strSQL, BancoDados.ConexaoAtiva)
        Dim adaptador As New MySqlDataAdapter(cmd)
        Dim ds As New DataSet()

        'CONFIGURAÇÃO DA GRIDE
        adaptador.Fill(ds, strTable)
        dgvDADOS.DataSource = ds.Tables(strTable)

        'Dim strColunas As String

        'For Each c As DataColumn In ds.Tables(0).Columns
        '    strColunas = strColunas + c.ColumnName
        'Next

        'MsgBox(strColunas)



        With dgvDADOS
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
        End With


        'CONFIGURAÇÃO DA TELA
        Me.WindowState = FormWindowState.Maximized

        'CONEXAO - FECHAR
        BancoDados.Fechar()

        Me.txtPESQUISA.Focus()

    End Sub

    Private Sub carregarGride(ByVal mySelectQuery As String, ByVal strTable As String, ByVal strConnection As String, ByVal dgvDADOS As DataGridView)


        Dim myConnection As New MySqlConnection(GetConnectionStringByName(strConnection))
        Dim cmd As New MySqlCommand(mySelectQuery, myConnection)

        myConnection.Open()

        'Cria o objeto DataAdapter
        Dim adaptador As New MySqlDataAdapter(cmd)

        'Cria o objeto DataSet
        Dim ds As New DataSet()

        'Preenche o dataset
        adaptador.Fill(ds, strTable)

        'Exibe os dados em um datagrid
        dgvDADOS.DataSource = ds.Tables(strTable)

        'Always call Close when done with connection.
        myConnection.Close()


    End Sub

    Private Sub btnPESQUISAR_Click_1(sender As System.Object, e As System.EventArgs) Handles btnPESQUISAR.Click
        '' OBRAS
        carregarGride("Select * from vw_cad_clientes where NOME like '%" + Me.txtPESQUISA.Text.ToString + "%' ", "vw_cad_clientes", "servidor", Me.dgvDADOS)

    End Sub

    Private Sub dgvDADOS_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDADOS.CellDoubleClick
        strValorRetorno = Me.dgvDADOS.CurrentRow.Cells(0).Value.ToString
        Me.Close()
    End Sub
End Class
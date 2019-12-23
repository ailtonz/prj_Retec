Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration

Public Class pesquisaClientes

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub F_PSQ_CLIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Rotinas = New ClasseRotinasDiversas

        '' TIPO DE PARAMETROS
        CARREGAR_COMBO("Select * from vw_adm_parametros_clientes", "vw_adm_parametros_clientes", Rotinas.GetConnectionStringByName("servidor"), cboCampos, "Descricao", "Parametro")

        CARREGAR_DADOS("", "")


    End Sub

    Private Sub CARREGAR_DADOS(ByVal strProcurar As String, ByVal strParametro As String)
        Dim con As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strSQL As String


        If strProcurar = "" Then
            strSQL = "SELECT * from vw_dgv_clientes"
        Else
            strSQL = "SELECT * from vw_dgv_clientes where  (" & strParametro & " LIKE '%" & Trim(strProcurar) & "%')"
        End If


        Try
            con.Open()
            Dim cmd As New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            With dgvClientes
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .DataSource = Nothing
                .DataSource = dt
                .Columns(0).Visible = False
                .ReadOnly = True
            End With


        Catch ex As Exception
            con.Close()
        End Try

    End Sub

    Private Sub cmdNovo_Click(sender As System.Object, e As System.EventArgs)

        SELECIONAR_CLIENTE(0)

    End Sub

    'Private Sub cmdProcurar_Click(sender As System.Object, e As System.EventArgs)
    '    CARREGAR_DADOS(Me.txtProcurar.Text, cboCampos.SelectedValue.ToString)
    'End Sub

    Private Sub dgvDados_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim idCliente As Object = dgvClientes.Rows(e.RowIndex).Cells(0).Value

            If IsDBNull(idCliente) Then
                MsgBox("")
            Else
                'F_CAD_CLIENTE.txtID_CLIENTE.Text = (CType(idCliente, String))
                'F_CAD_CLIENTE.ShowDialog()

                SELECIONAR_CLIENTE(idCliente)

            End If
        End If

    End Sub

    Private Sub SELECIONAR_CLIENTE(ByVal idCliente As String)

        Dim frm As New cadastroCliente

        With frm
            .MdiParent = FPrincipal
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .txtID_CLIENTE.Text = idCliente
            .Show()
        End With


    End Sub

    Private Sub F_PSQ_CLIENTES_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub F_PSQ_CLIENTES_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        CARREGAR_DADOS("", "")
    End Sub

    Private Sub dgvDados_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown

        Select Case e.KeyCode
            Case Keys.Insert
                SELECIONAR_CLIENTE(0)
            Case Keys.F2
                Me.txtProcurar.Focus()
        End Select

    End Sub

    Private Sub cmdFiltrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFiltrar.Click
        CARREGAR_DADOS(Me.txtProcurar.Text, cboCampos.SelectedValue.ToString)
    End Sub

    Private Sub CARREGAR_COMBO(ByVal myQuery As String, ByVal strTable As String, ByVal strConnection As String, ByVal cbo As ComboBox, ByVal strDisplayMember As String, ByVal strValueMember As String)
        Dim myConnection As New MySqlConnection(strConnection)
        myConnection.Open()

        Dim cmdSQL As New MySqlCommand(myQuery, myConnection)
        Dim adapter As New MySqlDataAdapter(cmdSQL)

        'define o dataset
        Dim ds As New DataSet
        Try
            adapter.Fill(ds, strTable) 'preenche o dataset
        Catch ex As Exception
            MessageBox.Show("Erro ao acessar os dados.")
            Exit Sub
        End Try

        With cbo
            'atribui o datasource a coluna combobox do datagridivew
            .DataSource = ds.Tables(strTable)
            'atribui o valor que será exibido na coluna 
            .DisplayMember = strDisplayMember
            'atribui o valor que será lido quando um item for selecionado
            .ValueMember = strValueMember
        End With

    End Sub


End Class
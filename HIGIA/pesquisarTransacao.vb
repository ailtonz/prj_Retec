Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration
Imports HigiaENT
Imports HigiaNEG


Public Class pesquisarTransacao
    Private _transacao As entTransacao
    Protected Rotinas As ClasseRotinasDiversas

    Const Registro As String = "Transacao"
    Const strParameters As String = "vw_adm_cadastros_parametros"

    Private Sub form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas

        Dim strConexao As String : strConexao = Rotinas.GetConnectionStringByName("servidor")
        Dim strConsulta As String : strConsulta = retornarOperacao(Registro, "view")
        Dim strSQL As String : strSQL = "Select * from " + strParameters + " where cadastro ='" + Registro + "' and Parametro='filter'"

        Me.txtUser.Text = Rotinas.GetConnectionStringByName("user").ToString
        Me.Text = UCase(Me.Text & " - " & "TRANSAÇÕES FINANCEIRAS")

        REGISTRO_PARAMETROS(strSQL, strParameters, strConexao, cboCampos, "Descricao", "Filtro")
        REGISTRO_FILTRAR("", "")

        LIMPAR_CAMPOS()

    End Sub

    Private Sub form_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub form_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        REGISTRO_FILTRAR("", "")
    End Sub

    Private Sub cmdFiltrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFiltrar.Click
        REGISTRO_FILTRAR(Me.txtProcurar.Text, cboCampos.SelectedValue.ToString)
    End Sub

    Private Sub dgvDados_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim idRegistro As Object = dgvDados.Rows(e.RowIndex).Cells(0).Value

            If IsDBNull(idRegistro) Then
                MsgBox("")
            Else
                REGISTRO_SELECIONAR(idRegistro)
            End If
        End If

    End Sub

    Private Sub dgvDados_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvDados.KeyDown
        Select Case e.KeyCode
            Case Keys.Insert
                REGISTRO_SELECIONAR(0)
            Case Keys.F2
                Me.txtProcurar.Focus()
        End Select
    End Sub

    ''' <summary>
    ''' FILTRAR REGISTROS 
    ''' </summary>
    ''' <param name="strProcurar"></param>
    ''' <param name="strParametro"></param>
    ''' <remarks></remarks>

    Private Sub REGISTRO_FILTRAR(ByVal strProcurar As String, ByVal strParametro As String)
        Dim con As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strConsulta As String : strConsulta = retornarOperacao(Registro, "view")
        Dim strSQL As String

        If strProcurar = "" Then
            strSQL = "SELECT * from " & strConsulta
        Else
            strSQL = "SELECT * from " & strConsulta & " where  (" & strParametro & " LIKE '%" & Trim(strProcurar) & "%')"
        End If

        Try
            con.Open()
            Dim cmd As New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            With dgvDados
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .DataSource = Nothing
                .DataSource = dt
                .Columns(0).Visible = False
                .ReadOnly = True
                .Refresh()
            End With

        Catch ex As Exception
            con.Close()
        End Try

    End Sub

    ''' <summary>
    ''' LISTAR PARAMETROS PARA FILTRAR REGISTROS
    ''' </summary>
    ''' <param name="myQuery"></param>
    ''' <param name="strTable"></param>
    ''' <param name="strConnection"></param>
    ''' <param name="cbo"></param>
    ''' <param name="strDisplayMember"></param>
    ''' <param name="strValueMember"></param>
    ''' <remarks></remarks>

    Private Sub REGISTRO_PARAMETROS(ByVal myQuery As String, ByVal strTable As String, ByVal strConnection As String, ByVal cbo As ComboBox, ByVal strDisplayMember As String, ByVal strValueMember As String)
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

    ''' <summary>
    ''' CARREGAR REGISTRO
    ''' </summary>
    ''' <param name="idRegistro"></param>
    ''' <remarks></remarks>

    Private Sub REGISTRO_SELECIONAR(ByVal idRegistro As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strConsulta As String : strConsulta = retornarOperacao(Registro, "view")

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("SELECT * from " & strConsulta & " where ID = '" + idRegistro + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        While rdrRegistro.Read

            Me.txtID.Text = rdrRegistro("id").ToString
            Me.txtDescricao.Text = rdrRegistro("Transacao").ToString

        End While

        rdrRegistro.Close()
        cmdSQL.Dispose()
        myConnection.Close()


    End Sub

    Function retornarOperacao(ByVal strCadastro As String, strParametro As String) As String
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("SELECT * from vw_adm_cadastros_parametros where cadastro = '" + strCadastro + "' and parametro = '" + strParametro + "'", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        rdrRegistro.Read()

        retornarOperacao = rdrRegistro("Filtro").ToString

        rdrRegistro.Close()
        cmdSQL.Dispose()
        myConnection.Close()


    End Function

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        REGISTRO_SALVAR()
    End Sub

    Private Sub REGISTRO_SALVAR()
        Dim myConnection As String = Rotinas.GetConnectionStringByName("servidor")
        Dim myProcedure As String = retornarOperacao(Registro, "procedure")

        Dim oNeTransacao As New negTransacao
        Dim oEtTransacao As New entTransacao
        Dim oEtUsuario As New entUsuario

        Try

            With oEtTransacao
                .Id = txtID.Text
                .Transacao = txtDescricao.Text

                ''USUARIO
                With oEtUsuario
                    .Nome = Me.txtUser.Text
                End With
                .ENT_USUARIO = oEtUsuario

            End With


            If txtID.Text = 0 And txtDescricao.Text <> "" Then
                If oNeTransacao.Incluir(oEtTransacao, myConnection, myProcedure) Then
                    MsgBox("Registro Incluido.", MsgBoxStyle.Information, "Inclusão de registro")

                Else
                    MsgBox("Erro ao Incluir Registro.", MsgBoxStyle.Exclamation, "Inclusão de registro")

                End If
            ElseIf txtID.Text <> 0 And txtDescricao.Text <> "" Then
                If oNeTransacao.Alterar(oEtTransacao, myConnection, myProcedure) Then
                    MsgBox("Registro Alterado.", MsgBoxStyle.Information, "Alteração de registro")

                Else
                    MsgBox("Erro ao Alterar Registro.", MsgBoxStyle.Exclamation, "Alteração de registro")

                End If
            ElseIf txtID.Text <> 0 And txtDescricao.Text = "" Then

                If MsgBox("Confirma exclusão do registro?", MsgBoxStyle.Question + vbYesNo, "Exclusão de registro.") = MsgBoxResult.Yes Then
                    If oNeTransacao.Excluir(oEtTransacao, myConnection, myProcedure) Then
                        MsgBox("Registro Excluido.", MsgBoxStyle.Information, "Exclusão de registro")

                    Else
                        MsgBox("Erro ao Excluir Registro.", MsgBoxStyle.Exclamation, "Exclusão de registro")

                    End If
                End If

            End If

            'End If

            REGISTRO_FILTRAR("", "")

            LIMPAR_CAMPOS()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LIMPAR_CAMPOS()

        Me.txtID.Text = "0"
        Me.txtDescricao.Text = String.Empty

        Me.txtProcurar.Text = String.Empty
        Me.stsDescricao.Text = String.Empty

        REGISTRO_FILTRAR("", "")

    End Sub


    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        LIMPAR_CAMPOS()

    End Sub

    Private Sub txtDescricao_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescricao.TextChanged
        Dim contas As Integer = Me.txtDescricao.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtDescricao.Text)
        End If

        Me.stsDescricao.Text = "TRANSAÇÃO" & " [" & contas & "/" & Me.txtDescricao.MaxLength & "]"
    End Sub

    Private Sub txtDescricao_Enter(sender As System.Object, e As System.EventArgs) Handles txtDescricao.Enter
        Me.stsDescricao.Text = "TRANSAÇÃO"
    End Sub

    Private Sub txtProcurar_Enter(sender As System.Object, e As System.EventArgs) Handles txtProcurar.Enter
        Me.stsDescricao.Text = "FILTRAR REGISTROS"
    End Sub

End Class
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration
Imports HigiaENT
Imports HigiaNEG


Public Class pesquisarCep
    Private _cep As entCep
    Protected Rotinas As ClasseRotinasDiversas

    Const Registro As String = "CEP"
    Const strParameters As String = "vw_adm_cadastros_parametros"

    Private Sub form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas

        Dim strConexao As String : strConexao = Rotinas.GetConnectionStringByName("servidor")
        Dim strConsulta As String : strConsulta = retornarOperacao(Registro, "view")
        Dim strSQL As String : strSQL = "Select * from " + strParameters + " where cadastro ='" + Registro + "' and Parametro='filter'"

        Me.txtUser.Text = Rotinas.GetConnectionStringByName("user").ToString
        Me.Text = UCase(Me.Text & " - " & "CEP")
        Me.txtLimite.Text = "100"

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
            strSQL = "SELECT * from " & strConsulta & " LIMIT " & Me.txtLimite.Text
        Else
            strSQL = "SELECT * from " & strConsulta & " where  (" & strParametro & " LIKE '%" & Trim(strProcurar) & "%')" & " LIMIT " & Me.txtLimite.Text
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
            Me.mskPRINCIPAL_CEP.Text = rdrRegistro("CEP").ToString
            Me.txtEndereco.Text = rdrRegistro("ENDERECO").ToString
            Me.txtComplemento.Text = rdrRegistro("COMPLEMENTO").ToString
            Me.txtBairro.Text = rdrRegistro("BAIRRO").ToString
            Me.txtCidade.Text = rdrRegistro("CIDADE").ToString
            Me.txtEstado.Text = rdrRegistro("ESTADO").ToString
            Me.txtContratoValor.Text = rdrRegistro("VALOR").ToString

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

        Dim oNeCep As New negCep
        Dim oEtCep As New entCep
        Dim oEtEndereco As New entEndereco
        Dim oEtUsuario As New entUsuario

        Dim strCEP As String = Trim(Replace(Me.mskPRINCIPAL_CEP.Text, "-", ""))

        Try

            With oEtCep
                .Id = txtID.Text
                .ContratoValor = Me.txtContratoValor.Text

                ''USUARIO
                With oEtEndereco
                    .Cep = strCEP
                    .Endereco = Me.txtEndereco.Text
                    .Complemento = Me.txtComplemento.Text
                    .Bairro = Me.txtBairro.Text
                    .Cidade = Me.txtCidade.Text
                    .Estado = Me.txtEstado.Text
                End With
                .ENT_ENDERECO = oEtEndereco

                ''USUARIO
                With oEtUsuario
                    .Nome = Me.txtUser.Text
                End With
                .ENT_USUARIO = oEtUsuario

            End With


            If txtID.Text = 0 And strCEP <> "" Then
                If oNeCep.Incluir(oEtCep, myConnection, myProcedure) Then
                    MsgBox("Registro Incluido.", MsgBoxStyle.Information, "Inclusão de registro")

                Else
                    MsgBox("Erro ao Incluir Registro.", MsgBoxStyle.Exclamation, "Inclusão de registro")

                End If
            ElseIf txtID.Text <> 0 And strCEP <> "" Then
                If oNeCep.Alterar(oEtCep, myConnection, myProcedure) Then
                    MsgBox("Registro Alterado.", MsgBoxStyle.Information, "Alteração de registro")

                Else
                    MsgBox("Erro ao Alterar Registro.", MsgBoxStyle.Exclamation, "Alteração de registro")

                End If
            ElseIf txtID.Text <> 0 And strCEP = "" Then

                If MsgBox("Confirma exclusão do registro?", MsgBoxStyle.Question + vbYesNo, "Exclusão de registro.") = MsgBoxResult.Yes Then
                    If oNeCep.Excluir(oEtCep, myConnection, myProcedure) Then
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
        Me.mskPRINCIPAL_CEP.Text = String.Empty
        Me.txtEndereco.Text = String.Empty
        Me.txtComplemento.Text = String.Empty
        Me.txtBairro.Text = String.Empty
        Me.txtCidade.Text = String.Empty
        Me.txtEstado.Text = String.Empty
        Me.txtContratoValor.Text = String.Empty

        Me.txtProcurar.Text = String.Empty
        Me.stsDescricao.Text = String.Empty

        REGISTRO_FILTRAR("", "")

    End Sub


    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        LIMPAR_CAMPOS()

    End Sub

    Private Sub mskPRINCIPAL_CEP_TextChanged(sender As System.Object, e As System.EventArgs) Handles mskPRINCIPAL_CEP.TextChanged
        'Dim contas As Integer = Me.mskPRINCIPAL_CEP.MaxLength

        'If contas <> 0 Then
        '    contas = contas - Len(mskPRINCIPAL_CEP.Text)
        'End If

        'Me.stsDescricao.Text = "CEP" & " [" & contas & "/" & Me.mskPRINCIPAL_CEP.MaxLength & "]"
    End Sub

    Private Sub mskPRINCIPAL_CEP_Enter(sender As System.Object, e As System.EventArgs) Handles mskPRINCIPAL_CEP.Enter
        Me.stsDescricao.Text = "CEP"
    End Sub

    Private Sub txtProcurar_Enter(sender As System.Object, e As System.EventArgs) Handles txtProcurar.Enter
        Me.stsDescricao.Text = "FILTRAR REGISTROS"
    End Sub

    Private Sub txtEndereco_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEndereco.TextChanged
        Dim contas As Integer = Me.txtEndereco.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtEndereco.Text)
        End If

        Me.stsDescricao.Text = "ENDEREÇO" & " [" & contas & "/" & Me.txtEndereco.MaxLength & "]"
    End Sub

    Private Sub txtEndereco_Enter(sender As System.Object, e As System.EventArgs) Handles txtEndereco.Enter
        Me.stsDescricao.Text = "ENDEREÇO"
    End Sub

    Private Sub txtComplemento_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtComplemento.TextChanged
        Dim contas As Integer = Me.txtComplemento.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtComplemento.Text)
        End If

        Me.stsDescricao.Text = "COMPLEMENTO" & " [" & contas & "/" & Me.txtComplemento.MaxLength & "]"
    End Sub

    Private Sub txtComplemento_Enter(sender As System.Object, e As System.EventArgs) Handles txtComplemento.Enter
        Me.stsDescricao.Text = "COMPLEMENTO"
    End Sub

    Private Sub txtBairro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBairro.TextChanged
        Dim contas As Integer = Me.txtBairro.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtBairro.Text)
        End If

        Me.stsDescricao.Text = "BAIRRO" & " [" & contas & "/" & Me.txtBairro.MaxLength & "]"
    End Sub

    Private Sub txtBairro_Enter(sender As System.Object, e As System.EventArgs) Handles txtBairro.Enter
        Me.stsDescricao.Text = "BAIRRO"
    End Sub

    Private Sub txtCidade_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCidade.TextChanged
        Dim contas As Integer = Me.txtCidade.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtCidade.Text)
        End If

        Me.stsDescricao.Text = "CIDADE" & " [" & contas & "/" & Me.txtCidade.MaxLength & "]"
    End Sub

    Private Sub txtCidade_Enter(sender As System.Object, e As System.EventArgs) Handles txtCidade.Enter
        Me.stsDescricao.Text = "CIDADE"
    End Sub

    Private Sub txtEstado_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEstado.TextChanged
        Dim contas As Integer = Me.txtEstado.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtEstado.Text)
        End If

        Me.stsDescricao.Text = "ESTADO" & " [" & contas & "/" & Me.txtEstado.MaxLength & "]"
    End Sub

    Private Sub txtEstado_Enter(sender As System.Object, e As System.EventArgs) Handles txtEstado.Enter
        Me.stsDescricao.Text = "ESTADO"
    End Sub

End Class
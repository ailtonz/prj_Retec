Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration
Imports HigiaENT
Imports HigiaNEG


Public Class pesquisarTransportador
    Private _transportador As entTransportador
    Protected Rotinas As ClasseRotinasDiversas

    Const Registro As String = "Transportador"
    Const strParameters As String = "vw_adm_cadastros_parametros"

    Private Sub form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas

        Dim strConexao As String : strConexao = Rotinas.GetConnectionStringByName("servidor")
        Dim strConsulta As String : strConsulta = retornarOperacao(Registro, "view")
        Dim strSQL As String : strSQL = "Select * from " + strParameters + " where cadastro ='" + Registro + "' and Parametro='filter'"

        Me.txtUser.Text = Rotinas.GetConnectionStringByName("user").ToString
        Me.Text = UCase(Me.Text & " - " & "TRANSPORTADOR")
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

        'LIMPAR_CAMPOS()

        While rdrRegistro.Read

            '' IDENTIFICAÇÃO
            Me.txtID.Text = rdrRegistro("id").ToString
            Me.txtNome.Text = rdrRegistro("NOME").ToString
            'Me.txtNomeFantasia.Text = rdrRegistro("FANTASIA").ToString

            '' DOCUMENTOS
            'Me.cboTipo.Text = rdrRegistro("TIPO").ToString
            Me.txtCPF_CCM.Text = rdrRegistro("CPF_CCM").ToString
            Me.txtLIMPURB.Text = rdrRegistro("LIMPURB").ToString

            '' CONTATO
            'Me.txtContato.Text = rdrRegistro("CONTATO").ToString
            Me.txtTelefone.Text = rdrRegistro("TELEFONE").ToString
            'Me.txtEmail.Text = rdrRegistro("EMAIL").ToString

            '' OUTROS
            'Me.txtContratoValor.Text = rdrRegistro("VALOR").ToString
            'Me.txtObservacao.Text = rdrRegistro("OBSERVACAO").ToString

            '' ENDEREÇO
            Me.mskPRINCIPAL_CEP.Text = rdrRegistro("CEP").ToString
            Me.txtEndereco.Text = rdrRegistro("ENDERECO").ToString
            Me.txtNumero.Text = rdrRegistro("NUMERO").ToString
            Me.txtComplemento.Text = rdrRegistro("COMPLEMENTO").ToString
            Me.txtBairro.Text = rdrRegistro("BAIRRO").ToString
            Me.txtCidade.Text = rdrRegistro("CIDADE").ToString
            Me.txtEstado.Text = rdrRegistro("ESTADO").ToString

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

        Dim oNeAterro As New negAterro
        Dim oEtAterro As New entAterro
        Dim oEtEndereco As New entEndereco
        Dim oEtDocumento As New entDocumento
        Dim oEtContato As New entContato
        Dim oEtContrato As New entContrato
        Dim oEtUsuario As New entUsuario

        Dim strCEP As String = Trim(Replace(Me.mskPRINCIPAL_CEP.Text, "-", ""))

        Try

            With oEtAterro
                .Id = txtID.Text
                .Nome = Me.txtNome.Text
                '.NomeFantasia = Me.txtNomeFantasia.Text
                '.Observacao = Me.txtObservacao.Text

                ''DOCUMENTO
                With oEtDocumento
                    '.TipoDocumento = Me.cboTipo.Text
                    .CNPJ_CPF = Me.txtCPF_CCM.Text
                    .IE_RG = Me.txtLIMPURB.Text
                End With
                .ENT_DOCUMENTO = oEtDocumento

                ''CONTATO
                With oEtContato
                    '.NomeContato = Me.txtContato.Text
                    .Telefone = Me.txtTelefone.Text
                    '.Email = Me.txtEmail.Text
                End With
                .ENT_CONTATO = oEtContato

                ''CONTRATO
                With oEtContrato
                    '.ValorUnitario = Me.txtContratoValor.Text
                End With
                .ENT_CONTRATO = oEtContrato

                ''ENDERECO
                With oEtEndereco
                    .Cep = strCEP
                    .Endereco = Me.txtEndereco.Text
                    .Numero = Me.txtNumero.Text
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


            If txtID.Text = 0 And txtNome.Text <> "" Then
                If oNeAterro.Incluir(oEtAterro, myConnection, myProcedure) Then
                    MsgBox("Registro Incluido.", MsgBoxStyle.Information, "Inclusão de registro")

                Else
                    MsgBox("Erro ao Incluir Registro.", MsgBoxStyle.Exclamation, "Inclusão de registro")

                End If
            ElseIf txtID.Text <> 0 And txtNome.Text <> "" Then
                If oNeAterro.Alterar(oEtAterro, myConnection, myProcedure) Then
                    MsgBox("Registro Alterado.", MsgBoxStyle.Information, "Alteração de registro")

                Else
                    MsgBox("Erro ao Alterar Registro.", MsgBoxStyle.Exclamation, "Alteração de registro")

                End If
            ElseIf txtID.Text <> 0 And txtNome.Text = "" Then

                If MsgBox("Confirma exclusão do registro?", MsgBoxStyle.Question + vbYesNo, "Exclusão de registro.") = MsgBoxResult.Yes Then
                    If oNeAterro.Excluir(oEtAterro, myConnection, myProcedure) Then
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

        '' IDENTIFICAÇÃO
        Me.txtID.Text = "0"
        Me.txtNome.Text = String.Empty

        '' DOCUMENTOS
        'Me.cboTipo.Text = String.Empty
        Me.txtCPF_CCM.Text = String.Empty
        Me.txtLIMPURB.Text = String.Empty

        '' CONTATO
        Me.txtTelefone.Text = String.Empty


        '' ENDEREÇO
        Me.mskPRINCIPAL_CEP.Text = String.Empty
        Me.txtEndereco.Text = String.Empty
        Me.txtNumero.Text = String.Empty
        Me.txtComplemento.Text = String.Empty
        Me.txtBairro.Text = String.Empty
        Me.txtCidade.Text = String.Empty
        Me.txtEstado.Text = String.Empty

        Me.txtProcurar.Text = String.Empty
        Me.stsDescricao.Text = String.Empty

        REGISTRO_FILTRAR("", "")

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        LIMPAR_CAMPOS()
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

    Private Sub txtNumero_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumero.TextChanged
        Dim contas As Integer = Me.txtNumero.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtNumero.Text)
        End If

        Me.stsDescricao.Text = "COMPLEMENTO" & " [" & contas & "/" & Me.txtNumero.MaxLength & "]"
    End Sub

    Private Sub txtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles txtNumero.Enter
        Me.stsDescricao.Text = "NUMERO"
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

    Private Sub txtNome_Enter(sender As System.Object, e As System.EventArgs) Handles txtNome.Enter
        Me.stsDescricao.Text = "NOME"
    End Sub

    Private Sub txtNome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNome.TextChanged
        Dim contas As Integer = Me.txtNome.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtNome.Text)
        End If

        Me.stsDescricao.Text = "NOME" & " [" & contas & "/" & Me.txtNome.MaxLength & "]"
    End Sub

    Private Sub txtNomeFantasia_Enter(sender As System.Object, e As System.EventArgs)
        Me.stsDescricao.Text = "NOME FANTASIA"
    End Sub

    'Private Sub txtNomeFantasia_TextChanged(sender As System.Object, e As System.EventArgs)
    '    Dim contas As Integer = Me.txtNomeFantasia.MaxLength

    '    If contas <> 0 Then
    '        contas = contas - Len(txtNomeFantasia.Text)
    '    End If

    '    Me.stsDescricao.Text = "NOME FANTASIA" & " [" & contas & "/" & Me.txtNomeFantasia.MaxLength & "]"
    'End Sub

    Private Sub txtContato_Enter(sender As System.Object, e As System.EventArgs)
        Me.stsDescricao.Text = "CONTATO"
    End Sub

    'Private Sub txtContato_TextChanged(sender As System.Object, e As System.EventArgs)
    '    Dim contas As Integer = Me.txtContato.MaxLength

    '    If contas <> 0 Then
    '        contas = contas - Len(txtContato.Text)
    '    End If

    '    Me.stsDescricao.Text = "CONTATO" & " [" & contas & "/" & Me.txtContato.MaxLength & "]"
    'End Sub

    Private Sub txtTelefone_Enter(sender As System.Object, e As System.EventArgs)
        Me.stsDescricao.Text = "TELEFONE"
    End Sub

    Private Sub txtTelefone_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim contas As Integer = Me.txtTelefone.MaxLength

        If contas <> 0 Then
            contas = contas - Len(txtTelefone.Text)
        End If

        Me.stsDescricao.Text = "TELEFONE" & " [" & contas & "/" & Me.txtTelefone.MaxLength & "]"
    End Sub

    Private Sub txtEmail_Enter(sender As System.Object, e As System.EventArgs)
        Me.stsDescricao.Text = "E-MAIL"
    End Sub

    'Private Sub txtEmail_TextChanged(sender As System.Object, e As System.EventArgs)
    '    Dim contas As Integer = Me.txtEmail.MaxLength

    '    If contas <> 0 Then
    '        contas = contas - Len(txtEmail.Text)
    '    End If

    '    Me.stsDescricao.Text = "E-MAIL" & " [" & contas & "/" & Me.txtEmail.MaxLength & "]"
    'End Sub

    Private Sub txtContratoValor_Enter(sender As System.Object, e As System.EventArgs)
        Me.stsDescricao.Text = "VALOR"
    End Sub

    Private Sub txtObservacao_Enter(sender As System.Object, e As System.EventArgs)
        Me.stsDescricao.Text = "OBSERVAÇÃO"
    End Sub

    'Private Sub txtObservacao_TextChanged(sender As System.Object, e As System.EventArgs)
    '    Dim contas As Integer = Me.txtObservacao.MaxLength

    '    If contas <> 0 Then
    '        contas = contas - Len(txtObservacao.Text)
    '    End If

    '    Me.stsDescricao.Text = "OBSERVAÇÃO" & " [" & contas & "/" & Me.txtObservacao.MaxLength & "]"
    'End Sub


End Class
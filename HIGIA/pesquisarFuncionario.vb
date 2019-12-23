Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration
Imports HigiaENT
Imports HigiaNEG


Public Class pesquisarFuncionario
    Private _funcionario As entFuncionario
    Protected Rotinas As ClasseRotinasDiversas

    Const Registro As String = "FUNCIONARIO"
    Const strParameters As String = "vw_adm_cadastros_parametros"

    Private Sub form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas

        Dim strConexao As String : strConexao = Rotinas.GetConnectionStringByName("servidor")
        Dim strConsulta As String : strConsulta = retornarOperacao(Registro, "view")
        Dim strSQL As String : strSQL = "Select * from " + strParameters + " where cadastro ='" + Registro + "' and Parametro='filter'"

        Me.txtUser.Text = Rotinas.GetConnectionStringByName("user").ToString
        Me.Text = UCase(Me.Text & " - " & "FUNCIONARIO")
        Me.txtLimite.Text = "100"

        REGISTRO_PARAMETROS(strSQL, strParameters, strConexao, cboCampos, "Descricao", "Filtro")
        REGISTRO_PARAMETROS("SELECT ID, CARGO FROM vw_cargos", "vw_cargos", strConexao, cboCargos, "CARGO", "CARGO")
        REGISTRO_PARAMETROS("select distinct cidade from vw_cep order by cidade", "vw_cep", strConexao, cboCidade, "cidade", "cidade")
        REGISTRO_PARAMETROS("select distinct estado from vw_cep order by estado", "vw_cep", strConexao, cboEstado, "estado", "estado")
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
                LIMPAR_CAMPOS()
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
                .Columns(1).Visible = False
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False
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

            Me.mskCNPJ_CPF.Text = rdrRegistro("CNPJ_CPF").ToString
            Me.mskIE_RG.Text = rdrRegistro("IE_RG").ToString
            Me.cboCargos.Text = rdrRegistro("CARGO").ToString
            Me.txtNome.Text = rdrRegistro("Nome").ToString
            Me.txtSalario.Text = rdrRegistro("SALARIO").ToString
            Me.txtTelefone.Text = rdrRegistro("TELEFONE").ToString
            Me.txtEmail.Text = rdrRegistro("EMAIL").ToString
            Me.txtContato.Text = rdrRegistro("CONTATO").ToString

            Me.mskCEP.Text = rdrRegistro("CEP").ToString
            Me.txtNumero.Text = rdrRegistro("NUMERO").ToString
            Me.txtComplemento.Text = rdrRegistro("COMPLEMENTO").ToString
            Me.txtEndereco.Text = rdrRegistro("ENDERECO").ToString
            Me.txtBairro.Text = rdrRegistro("BAIRRO").ToString
            Me.cboCidade.Text = rdrRegistro("CIDADE").ToString
            Me.cboEstado.Text = rdrRegistro("ESTADO").ToString

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

        Dim oNeFuncionario As New negFuncionario
        Dim oEtFuncionario As New entFuncionario
        Dim oEtDocumento As New entDocumento
        Dim oEtContato As New entContato
        Dim oEtEndereco As New entEndereco
        Dim oEtCargo As New entCargo
        Dim oEtUsuario As New entUsuario

        Dim strCEP As String = Trim(Replace(Me.mskCEP.Text, "-", ""))

        Try

            With oEtFuncionario
                '' DADOS
                .Id = txtID.Text
                .Nome = txtNome.Text

                '' DOCUMENTOS
                With oEtDocumento
                    .TipoDocumento = "PF"
                    .CNPJ_CPF = Trim(Replace(Replace(Me.mskCNPJ_CPF.Text, ",", ""), "-", ""))
                    .IE_RG = Trim(Replace(Replace(Replace(Me.mskIE_RG.Text, ".", ""), "-", ""), ",", ""))
                End With
                .ENT_DOCUMENTO = oEtDocumento

                '' CONTATOS
                With oEtContato
                    .NomeContato = Me.txtContato.Text
                    .Telefone = Me.txtTelefone.Text
                    .Email = Me.txtEmail.Text
                End With
                .ENT_CONTATO = oEtContato

                '' ENDERECO
                With oEtEndereco
                    .Cep = strCEP
                    .Numero = Me.txtNumero.Text
                    .Complemento = Me.txtComplemento.Text
                    .Endereco = Me.txtEndereco.Text
                    .Bairro = Me.txtBairro.Text
                    .Cidade = Me.cboCidade.Text
                    .Estado = Me.cboEstado.Text
                End With
                .ENT_ENDERECO = oEtEndereco

                '' CARGO
                With oEtCargo
                    .Cargo = Me.cboCargos.Text
                    .Salario = Me.txtSalario.Text
                End With
                .ENT_CARGO = oEtCargo

                '' USUARIO
                With oEtUsuario
                    .Nome = Me.txtUser.Text
                End With
                .ENT_USUARIO = oEtUsuario

            End With


            If txtID.Text = 0 And Me.txtNome.Text <> "" Then
                If oNeFuncionario.Incluir(oEtFuncionario, myConnection, myProcedure) Then
                    MsgBox("Registro Incluido.", MsgBoxStyle.Information, "Inclusão de registro")

                Else
                    MsgBox("Erro ao Incluir Registro.", MsgBoxStyle.Exclamation, "Inclusão de registro")

                End If
            ElseIf txtID.Text <> 0 And Me.txtNome.Text <> "" Then
                If oNeFuncionario.Alterar(oEtFuncionario, myConnection, myProcedure) Then
                    MsgBox("Registro Alterado.", MsgBoxStyle.Information, "Alteração de registro")

                Else
                    MsgBox("Erro ao Alterar Registro.", MsgBoxStyle.Exclamation, "Alteração de registro")

                End If
            ElseIf txtID.Text <> 0 And Me.txtNome.Text = "" Then

                If MsgBox("Confirma exclusão do registro?", MsgBoxStyle.Question + vbYesNo, "Exclusão de registro.") = MsgBoxResult.Yes Then
                    If oNeFuncionario.Excluir(oEtFuncionario, myConnection, myProcedure) Then
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

        '' DADOS
        Me.mskCNPJ_CPF.Text = String.Empty
        Me.mskIE_RG.Text = String.Empty
        Me.cboCargos.SelectedIndex = -1
        Me.txtNome.Text = String.Empty
        Me.txtSalario.Text = String.Empty
        Me.txtTelefone.Text = String.Empty
        Me.txtEmail.Text = String.Empty
        Me.txtContato.Text = String.Empty

        '' ENDEREÇO
        Me.mskCEP.Text = String.Empty
        Me.txtNumero.Text = String.Empty
        Me.txtComplemento.Text = String.Empty
        Me.txtEndereco.Text = String.Empty
        Me.txtBairro.Text = String.Empty
        Me.cboCidade.SelectedIndex = -1
        Me.cboEstado.SelectedIndex = -1

        Me.txtProcurar.Text = String.Empty
        Me.stsDescricao.Text = String.Empty

        REGISTRO_FILTRAR("", "")

    End Sub


    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

        LIMPAR_CAMPOS()

    End Sub

    Private Sub mskPRINCIPAL_CEP_Enter(sender As System.Object, e As System.EventArgs)
        Me.stsDescricao.Text = "CEP"
    End Sub

    Private Sub txtProcurar_Enter(sender As System.Object, e As System.EventArgs) Handles txtProcurar.Enter
        Me.stsDescricao.Text = "FILTRAR REGISTROS"
    End Sub

    Private Sub txtEndereco_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim i As Integer = Me.txtEndereco.MaxLength

        If i <> 0 Then
            i = i - Len(txtEndereco.Text)
        End If

        Me.stsDescricao.Text = "ENDEREÇO" & " [" & i & "/" & Me.txtEndereco.MaxLength & "]"
    End Sub

    Private Sub txtEndereco_Enter(sender As System.Object, e As System.EventArgs) Handles txtEndereco.Enter
        Me.stsDescricao.Text = "ENDEREÇO"
    End Sub

    Private Sub txtComplemento_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim i As Integer = Me.txtComplemento.MaxLength

        If i <> 0 Then
            i = i - Len(txtComplemento.Text)
        End If

        Me.stsDescricao.Text = "COMPLEMENTO" & " [" & i & "/" & Me.txtComplemento.MaxLength & "]"
    End Sub

    Private Sub txtComplemento_Enter(sender As System.Object, e As System.EventArgs) Handles txtComplemento.Enter
        Me.stsDescricao.Text = "COMPLEMENTO"
    End Sub

    Private Sub txtBairro_TextChanged(sender As System.Object, e As System.EventArgs)
        Dim i As Integer = Me.txtBairro.MaxLength

        If i <> 0 Then
            i = i - Len(txtBairro.Text)
        End If

        Me.stsDescricao.Text = "BAIRRO" & " [" & i & "/" & Me.txtBairro.MaxLength & "]"
    End Sub

    Private Sub txtBairro_Enter(sender As System.Object, e As System.EventArgs) Handles txtBairro.Enter
        Me.stsDescricao.Text = "BAIRRO"
    End Sub

    'Private Sub txtCidade_TextChanged(sender As System.Object, e As System.EventArgs)
    '    Dim i As Integer = Me.txtCidade.MaxLength

    '    If i <> 0 Then
    '        i = i - Len(txtCidade.Text)
    '    End If

    '    Me.stsDescricao.Text = "CIDADE" & " [" & i & "/" & Me.txtCidade.MaxLength & "]"
    'End Sub

    Private Sub cboCidade_Enter(sender As System.Object, e As System.EventArgs) Handles cboCidade.Enter
        Me.stsDescricao.Text = "CIDADE"
    End Sub

    'Private Sub txtEstado_TextChanged(sender As System.Object, e As System.EventArgs)
    '    Dim i As Integer = Me.txtEstado.MaxLength

    '    If i <> 0 Then
    '        i = i - Len(txtEstado.Text)
    '    End If

    '    Me.stsDescricao.Text = "ESTADO" & " [" & i & "/" & Me.txtEstado.MaxLength & "]"
    'End Sub

    Private Sub cboEstado_Enter(sender As System.Object, e As System.EventArgs) Handles cboEstado.Enter
        Me.stsDescricao.Text = "ESTADO"
    End Sub

    Private Sub mskCNPJ_CPF_Enter(sender As System.Object, e As System.EventArgs) Handles mskCNPJ_CPF.Enter
        Me.stsDescricao.Text = "C.P.F"
    End Sub

    Private Sub mskIE_RG_Enter(sender As System.Object, e As System.EventArgs) Handles mskIE_RG.Enter
        Me.stsDescricao.Text = "R.G"
    End Sub

    Private Sub cboCargos_Enter(sender As System.Object, e As System.EventArgs) Handles cboCargos.Enter
        Me.stsDescricao.Text = "CARGO"
    End Sub

    Private Sub txtNome_Enter(sender As System.Object, e As System.EventArgs) Handles txtNome.Enter
        Me.stsDescricao.Text = "NOME"
    End Sub

    Private Sub txtSalario_Enter(sender As System.Object, e As System.EventArgs) Handles txtSalario.Enter
        Me.stsDescricao.Text = "SALARIO"
    End Sub

    Private Sub txtTelefone_Enter(sender As System.Object, e As System.EventArgs) Handles txtTelefone.Enter
        Me.stsDescricao.Text = "TELEFONE"
    End Sub

    Private Sub txtEmail_Enter(sender As System.Object, e As System.EventArgs) Handles txtEmail.Enter
        Me.stsDescricao.Text = "E-MAIL"
    End Sub

    Private Sub txtContato_Enter(sender As System.Object, e As System.EventArgs) Handles txtContato.Enter
        Me.stsDescricao.Text = "CONTATO"
    End Sub

    Private Sub mskCEP_Enter(sender As System.Object, e As System.EventArgs) Handles mskCEP.Enter
        Me.stsDescricao.Text = "CEP"
    End Sub

    Private Sub txtNumero_Enter(sender As System.Object, e As System.EventArgs) Handles txtNumero.Enter
        Me.stsDescricao.Text = "NUMERO"
    End Sub

    Private Sub txtNome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNome.TextChanged
        Dim i As Integer = Me.txtNome.MaxLength

        If i <> 0 Then
            i = i - Len(txtNome.Text)
        End If

        Me.stsDescricao.Text = "NOME " & " [" & i & "/" & Me.txtNome.MaxLength & "]"
    End Sub

    Private Sub txtTelefone_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTelefone.TextChanged
        Dim i As Integer = Me.txtTelefone.MaxLength

        If i <> 0 Then
            i = i - Len(txtTelefone.Text)
        End If

        Me.stsDescricao.Text = "TELEFONE " & " [" & i & "/" & Me.txtTelefone.MaxLength & "]"
    End Sub

    Private Sub txtEmail_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmail.TextChanged
        Dim i As Integer = Me.txtEmail.MaxLength

        If i <> 0 Then
            i = i - Len(txtEmail.Text)
        End If

        Me.stsDescricao.Text = "E-MAIL " & " [" & i & "/" & Me.txtEmail.MaxLength & "]"
    End Sub

    Private Sub txtContato_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtContato.TextChanged
        Dim i As Integer = Me.txtContato.MaxLength

        If i <> 0 Then
            i = i - Len(txtContato.Text)
        End If

        Me.stsDescricao.Text = "CONTATO " & " [" & i & "/" & Me.txtContato.MaxLength & "]"
    End Sub

    Private Sub txtNumero_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumero.TextChanged
        Dim i As Integer = Me.txtNumero.MaxLength

        If i <> 0 Then
            i = i - Len(txtNumero.Text)
        End If

        Me.stsDescricao.Text = "NUMERO " & " [" & i & "/" & Me.txtNumero.MaxLength & "]"
    End Sub

    Private Sub txtComplemento_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtComplemento.TextChanged
        Dim i As Integer = Me.txtComplemento.MaxLength

        If i <> 0 Then
            i = i - Len(txtComplemento.Text)
        End If

        Me.stsDescricao.Text = "COMPLEMENTO " & " [" & i & "/" & Me.txtComplemento.MaxLength & "]"
    End Sub

End Class
Imports System
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports HigiaENT
Imports HigiaNEG

Public Class cadastroCliente

    Private _cliente As entCliente

    Protected Rotinas As ClasseRotinasDiversas

    '' STATUS DO CLIENTE
    Dim Observacoes() As String = {"CONSTA PROTESTOS", "DEVEDOR - BOLETOS EM ABERTO", "HISTORICO", "NAO LIBERAR - MAL PAGADOR", "PROTESTADO - BANCO", "PROTESTADO - RETEC", "SO AVISTA", "VER SITE DE PROTESTOS"}
    Dim Status() As String = {"LIBERADO", "BLOQUEADO"}

    '' MEIOS DE PROPAGANDA
    Dim Propagandas() As String = {"CAÇAMBA NA RUA", "GOOGLE", "INDICAÇÃO", "LISTA TELEFÔNICA"}

    '' TRANSAÇÕES
    Dim Transacoes() As String = {"BOLETO", "DEBITO", "DEPOSITO", "TRANSFERENCIA"}

    '' CONDIÇÕES
    Dim Condicoes() As String = {"DIARIO", "SEMANAL", "QUINZENAL", "MENSAL"}
    Dim CondicoesID() As String = {"1", "7", "15", "30"}

    '' TIPO DE CADASTRO
    Dim TiposCadastros() As String = {"FISICO", "JURIDICO"}


    Private Sub F_CAD_CLIENTE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Rotinas = New ClasseRotinasDiversas

        '' CONTROLE DE ACESSO
        Me.txtUser.Text = Rotinas.GetConnectionStringByName("user").ToString

        '' CARREGAR COMBOS
        CARREGAR_COMBOS()

        '' BLOQUEIO DE CADASTRO
        formLock()

        '' CONTROLE DE FORMULARIO
        If Me.txtID_CLIENTE.Text = 0 Then
            '' MUDAR OPERAÇÃO
            Me.btnCLIENTE_SALVAR.Text = "NOVO"
        Else

            '' MUDAR OPERAÇÃO
            Me.btnCLIENTE_SALVAR.Text = "ALTERAR"

            '' CARREGAR REGISTRO
            CARREGAR_CADASTRO_CLIENTE(Me.txtID_CLIENTE.Text)

        End If

    End Sub

    Private Sub CONTROLE_REGISTRO()

        '' DESTRAVAR
        formUnLock()

        If Me.btnCLIENTE_SALVAR.Text = "NOVO" Then

            '' MUDAR OPERAÇÃO
            Me.btnCLIENTE_SALVAR.Text = "SALVAR"
        Else
            '' VALIDAR CAMPOS PARA GRAVAÇÃO
            If VALIDAR_CAMPOS("PRINCIPAL") Then
                '' SALVAR REGISTRO
                SALVAR_CLIENTE()

                '' MUDAR OPERAÇÃO
                Me.btnCLIENTE_SALVAR.Text = "ALTERAR"
            End If

        End If

    End Sub

    Private Sub btnCLIENTE_SALVAR_Click(sender As System.Object, e As System.EventArgs) Handles btnCLIENTE_SALVAR.Click

        CONTROLE_REGISTRO()

    End Sub


    Private Sub SALVAR_CLIENTE()
        Dim myConnection As String = Rotinas.GetConnectionStringByName("servidor")


        Dim oNeCliente As New negCliente
        Dim oEtCliente As New entCliente
        Dim oEtEndereco As New entEndereco
        Dim oEtContato As New entContato
        Dim oEtUsuario As New entUsuario
        Dim oEtDocumento As New entDocumento
        Dim oEtStatus As New entStatus
        Dim oEtObservacao As New entObservacao
        Dim oEtPropaganda As New entUtilPropaganda

        Try

            With oEtCliente

                ' TIPO DE CADASTRO / DOCUMENTOS
                If Me.cboCADASTRO_TIPO.Text = "FISICO" Then

                    With oEtDocumento
                        .TipoDocumento = "pf"
                        .CNPJ_CPF = Trim(Replace(Replace(Me.mskCNPJ_CPF.Text, ",", ""), "-", ""))
                        .IE_RG = Trim(Replace(Replace(Replace(Me.mskIE_RG.Text, ".", ""), "-", ""), ",", ""))
                    End With
                    .ENT_DOCUMENTO = oEtDocumento

                ElseIf Me.cboCADASTRO_TIPO.Text = "JURIDICO" Then

                    With oEtDocumento
                        .TipoDocumento = "pj"
                        .CNPJ_CPF = Trim(Replace(Replace(Replace(Me.mskCNPJ_CPF.Text, ",", ""), "-", ""), "/", ""))
                        .IE_RG = Trim(Replace(Replace(Me.mskIE_RG.Text, ".", ""), ",", ""))
                    End With
                    .ENT_DOCUMENTO = oEtDocumento

                End If

                '' DADOS DO CLIENTE
                .IdCliente = Me.txtID_CLIENTE.Text
                .Nome = Me.txtPRINCIPAL_NOME.Text
                .Nome_Fantasia = Me.txtPRINCIPAL_NOME_FANTASIA.Text
                .CadastroTipo = .ENT_DOCUMENTO.TipoDocumento.ToString


                '' ENDERECO
                With oEtEndereco
                    .Cep = Trim(Replace(Me.mskPRINCIPAL_CEP.Text, "-", ""))
                    .Numero = Me.txtPRINCIPAL_NUMERO.Text
                    .Complemento = Me.txtPRINCIPAL_COMPLEMENTO.Text
                    .Endereco = Me.txtPRINCIPAL_ENDERECO.Text
                    .Bairro = Me.txtPRINCIPAL_BAIRRO.Text
                    .Cidade = Me.txtPRINCIPAL_CIDADE.Text
                    .Estado = Me.txtPRINCIPAL_ESTADO.Text

                End With
                .ENT_ENDERECO = oEtEndereco

                '' CONTATO
                With oEtContato
                    .NomeContato = Me.txtPRINCIPAL_CONTATO.Text
                    .Telefone = Me.txtPRINCIPAL_TELEFONE.Text
                    .Email = Me.txtPRINCIPAL_EMAIL.Text
                End With
                .ENT_CONTATO = oEtContato

                '' OBSERVAÇÃO
                With oEtObservacao
                    .Observacao = Me.txtCADASTRO_OBSERVACAO.Text
                End With
                .ENT_OBSERVACAO = oEtObservacao

                '' STATUS
                With oEtStatus
                    .Status = Me.cboSTATUS.Text
                    .Observacao = Me.cboSTATUS_OBSERVACAO.Text
                End With
                .ENT_STATUS = oEtStatus

                '' PROPAGANDA
                With oEtPropaganda
                    .Propaganda = Me.cboCADASTRO_PROPAGANDA.Text
                End With
                .ENT_PROPAGANDA = oEtPropaganda


                ''USUARIO
                With oEtUsuario
                    .Nome = Me.txtUser.Text
                End With
                .ENT_USUARIO = oEtUsuario

                If txtID_CLIENTE.Text = 0 Then
                    If oNeCliente.Incluir(oEtCliente, myConnection) Then
                        getID_Cliente(.ENT_DOCUMENTO.CNPJ_CPF.ToString)
                        MessageBox.Show("salvo")
                    Else
                        MessageBox.Show("salvo, erro!")
                    End If
                Else
                    If oNeCliente.Alterar(oEtCliente, myConnection) Then

                        If Not Me.chkRelacao.Checked Then
                            oNeCliente.relacionarContatos(oEtCliente.IdCliente, myConnection)
                            oNeCliente.relacionarObras(oEtCliente.IdCliente, myConnection)
                            oNeCliente.relacionarHistoricos(oEtCliente.IdCliente, myConnection)

                        End If

                        CARREGAR_CADASTRO_CLIENTE(txtID_CLIENTE.Text)
                        MessageBox.Show("alterado")
                    Else
                        MessageBox.Show("alterado, erro!")
                    End If
                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub getID_Cliente(ByVal CNPJ_CPF As String)

        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("SELECT id_cliente,cad_usuario,cad_emissao,alt_usuario,alt_emissao FROM vw_cad_clientes WHERE cnpj_cpf = '" + CNPJ_CPF + "' LIMIT 1", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read
                .txtID_CLIENTE.Text = rdrRegistro("ID_CLIENTE").ToString()
                .txtCAD_USUARIO.Text = rdrRegistro("CAD_USUARIO").ToString()
                .txtCAD_EMISSAO.Text = rdrRegistro("CAD_EMISSAO").ToString()
                .txtALT_USUARIO.Text = rdrRegistro("ALT_USUARIO").ToString()
                .txtALT_EMISSAO.Text = rdrRegistro("ALT_EMISSAO").ToString()
            End While

        End With

        rdrRegistro.Close()
        cmdSQL.Dispose()

    End Sub

    Private Sub CARREGAR_CADASTRO_CLIENTE(ByVal idCliente As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_cad_clientes where ID_CLIENTE = '" + idCliente + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                If rdrRegistro("CADASTRO_TIPO").ToString = "PF" Then
                    Me.mskCNPJ_CPF.UseSystemPasswordChar = False
                    Me.mskCNPJ_CPF.Mask = "000.000.000-00"
                    Me.mskIE_RG.Mask = "99.999.999-9"
                    Me.cboCADASTRO_TIPO.SelectedIndex = CInt(Me.cboCADASTRO_TIPO.FindString("FISICO"))
                ElseIf rdrRegistro("CADASTRO_TIPO").ToString = "PJ" Then
                    Me.mskCNPJ_CPF.UseSystemPasswordChar = False
                    Me.mskCNPJ_CPF.Mask = "00.000.000/0000-00"
                    Me.mskIE_RG.Mask = "999.999.999.999"
                    Me.cboCADASTRO_TIPO.SelectedIndex = CInt(Me.cboCADASTRO_TIPO.FindString("JURIDICO"))
                End If

                .txtID_CLIENTE.Text = rdrRegistro("ID_CLIENTE").ToString
                .mskCNPJ_CPF.Text = rdrRegistro("CNPJ_CPF").ToString
                .mskIE_RG.Text = rdrRegistro("IE_RG").ToString

                .txtPRINCIPAL_NOME_FANTASIA.Text = rdrRegistro("NOME_FANTASIA").ToString
                .txtPRINCIPAL_NOME.Text = rdrRegistro("NOME").ToString

                .cboSTATUS.SelectedIndex = CInt(.cboSTATUS.FindString(rdrRegistro("CADASTRO_STATUS").ToString))
                .cboSTATUS_OBSERVACAO.SelectedIndex = CInt(.cboSTATUS_OBSERVACAO.FindString(rdrRegistro("CADASTRO_STATUS_OBSERVACAO").ToString))

                .txtCADASTRO_OBSERVACAO.Text = rdrRegistro("CADASTRO_OBSERVACAO").ToString

                .mskPRINCIPAL_CEP.Text = rdrRegistro("CEP").ToString
                .txtPRINCIPAL_NUMERO.Text = rdrRegistro("NUMERO").ToString
                .txtPRINCIPAL_COMPLEMENTO.Text = rdrRegistro("COMPLEMENTO").ToString

                .txtPRINCIPAL_ENDERECO.Text = rdrRegistro("ENDERECO").ToString

                .txtPRINCIPAL_BAIRRO.Text = rdrRegistro("BAIRRO").ToString
                .txtPRINCIPAL_CIDADE.Text = rdrRegistro("CIDADE").ToString
                .txtPRINCIPAL_ESTADO.Text = rdrRegistro("ESTADO").ToString

                .txtPRINCIPAL_CONTATO.Text = rdrRegistro("CONTATO").ToString
                .txtPRINCIPAL_TELEFONE.Text = rdrRegistro("TELEFONE").ToString
                .txtPRINCIPAL_EMAIL.Text = rdrRegistro("EMAIL").ToString

                .cboCADASTRO_PROPAGANDA.SelectedIndex = CInt(.cboCADASTRO_PROPAGANDA.FindString(rdrRegistro("CADASTRO_PROPAGANDA").ToString))

                .txtCAD_EMISSAO.Text = rdrRegistro("CAD_EMISSAO").ToString
                .txtCAD_USUARIO.Text = rdrRegistro("CAD_USUARIO").ToString
                .txtALT_EMISSAO.Text = rdrRegistro("ALT_EMISSAO").ToString
                .txtALT_USUARIO.Text = rdrRegistro("ALT_USUARIO").ToString
                .chkRelacao.Checked = IIf(rdrRegistro("REGISTRO_RELACIONAMENTO").ToString, "1", "0")


            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub CARREGAR_ENDERECO_PRINCIPAL(ByVal idCep As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("select * from vw_uteis_cep where cep = '" + idCep + "'limit 1", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                .txtPRINCIPAL_ENDERECO.Text = Rotinas.RemoveAcentos(rdrRegistro("ENDERECO").ToString)
                .txtPRINCIPAL_BAIRRO.Text = Rotinas.RemoveAcentos(rdrRegistro("BAIRRO").ToString)
                .txtPRINCIPAL_CIDADE.Text = Rotinas.RemoveAcentos(rdrRegistro("CIDADE").ToString)
                .txtPRINCIPAL_ESTADO.Text = Rotinas.RemoveAcentos(rdrRegistro("ESTADO").ToString)

            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub CARREGAR_CADASTRO_CONTATO(ByVal idContatoCliente As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_cad_clientes_contatos where ID = '" + idContatoCliente + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                .txtCONTATO_NOME.Text = rdrRegistro("CONTATO").ToString
                .txtCONTATO_EMAIL.Text = rdrRegistro("EMAIL").ToString
                .txtCONTATO_TELEFONE.Text = rdrRegistro("TELEFONE").ToString
                .txtCONTATO_OBSERVACAO.Text = rdrRegistro("OBSERVACAO").ToString

                .txtCONTATO_CLIENTE_CAD_USUARIO.Text = rdrRegistro("CAD_USUARIO").ToString
                .txtCONTATO_CLIENTE_CAD_EMISSAO.Text = rdrRegistro("CAD_EMISSAO").ToString

                .txtCONTATO_CLIENTE_ALT_USUARIO.Text = rdrRegistro("ALT_USUARIO").ToString
                .txtCONTATO_CLIENTE_ALT_EMISSAO.Text = rdrRegistro("ALT_EMISSAO").ToString

            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub CARREGAR_CADASTRO_HISTORICO(ByVal idHistorico As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_cad_clientes_historicos where ID = '" + idHistorico + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                .txtHISTORICO_DADOS.Text = rdrRegistro("HISTORICO").ToString

                .txtHISTORICO_CAD_USUARIO.Text = rdrRegistro("CAD_USUARIO").ToString
                .txtHISTORICO_CAD_EMISSAO.Text = rdrRegistro("CAD_EMISSAO").ToString

                .txtHISTORICO_ALT_USUARIO.Text = rdrRegistro("ALT_USUARIO").ToString
                .txtHISTORICO_ALT_EMISSAO.Text = rdrRegistro("ALT_EMISSAO").ToString

            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub CARREGAR_GRIDE_OBRAS(ByVal idCliente As String, ByVal strProcurar As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        myConnection.Open()
        Dim ds As New DataSet()
        Dim strSQL As String

        If strProcurar = "" Then
            strSQL = "SELECT * from vw_dgv_obras where (ID_CLIENTE = '" & idCliente & "')"
        Else
            strSQL = "SELECT * from vw_dgv_obras where (ENDERECO LIKE '%" & Trim(strProcurar) & "%' AND ID_CLIENTE = '" & idCliente & "')"
        End If

        Dim da As New MySqlDataAdapter(New MySqlCommand(strSQL, myConnection))

        ds.Clear()
        da.Fill(ds, "vw_dgv_obras")

        With dgvOBRAS
            .DataSource = ds.Tables("vw_dgv_obras")
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With

        myConnection.Close()

    End Sub

    Private Sub CARREGAR_COMBOS()
        Dim Observacao As String
        Dim Propaganda As String
        Dim Sts As String
        Dim TipoCadastro As String


        With Me.cboCADASTRO_TIPO
            .Items.Clear()
            For Each TipoCadastro In TiposCadastros
                .Items.Add(TipoCadastro)
            Next
            .SelectedIndex = CInt(.FindString("FISICO"))
        End With

        With Me.cboSTATUS_OBSERVACAO
            .Items.Clear()
            For Each Observacao In Observacoes
                .Items.Add(Observacao)
            Next
            .SelectedIndex = CInt(.FindString("VER SITE DE PROTESTOS"))
        End With

        With Me.cboSTATUS
            .Items.Clear()
            For Each Sts In Status
                .Items.Add(Sts)
            Next
            .SelectedIndex = CInt(.FindString("LIBERADO"))
        End With

        With Me.cboCADASTRO_PROPAGANDA
            .Items.Clear()
            For Each Propaganda In Propagandas
                .Items.Add(Propaganda)
            Next
            .SelectedIndex = CInt(.FindString("GOOGLE"))
        End With


    End Sub

    Private Sub F_CAD_CLIENTE_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Rotinas = Nothing
    End Sub

    Private Sub txtPRINCIPAL_EMAIL_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtPRINCIPAL_EMAIL.Validating
        Dim strRegex As String = _
 "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"

        Dim re As New Regex(strRegex)

        If (re.IsMatch(txtPRINCIPAL_EMAIL.Text)) Then
            Rotinas.CorSaida(sender)
            'Me.txtPRINCIPAL_EMAIL.BackColor = Color.WhiteSmoke
        Else
            Rotinas.CorEntrada(sender)
            'Me.txtPRINCIPAL_EMAIL.BackColor = Color.Yellow
            e.Cancel = True
        End If

    End Sub

    Private Sub mskCNPJ_CPF_Enter(sender As System.Object, e As System.EventArgs) Handles mskCNPJ_CPF.Enter

        Rotinas.CorEntrada(sender)

        If Me.cboCADASTRO_TIPO.Text = "FISICO" Then
            Me.mskCNPJ_CPF.UseSystemPasswordChar = False
            Me.mskCNPJ_CPF.Mask = "000.000.000-00"
            Me.mskIE_RG.Mask = "99.999.999-9"
        ElseIf Me.cboCADASTRO_TIPO.Text = "JURIDICO" Then
            Me.mskCNPJ_CPF.UseSystemPasswordChar = False
            Me.mskCNPJ_CPF.Mask = "00.000.000/0000-00"
            Me.mskIE_RG.Mask = "999.999.999.999"
        End If

    End Sub

    Private Sub mskCNPJ_CPF_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles mskCNPJ_CPF.Validating

        Dim strCNPJ_CPF As String = ""

        If Me.cboCADASTRO_TIPO.Text = "FISICO" Then
            strCNPJ_CPF = Trim(Replace(Replace(Me.mskCNPJ_CPF.Text, ",", ""), "-", ""))
        ElseIf Me.cboCADASTRO_TIPO.Text = "JURIDICO" Then
            strCNPJ_CPF = Trim(Replace(Replace(Replace(Me.mskCNPJ_CPF.Text, ",", ""), "-", ""), "/", ""))
        End If

        If strCNPJ_CPF <> "" Then
            If Me.cboCADASTRO_TIPO.Text = "FISICO" Then
                If (Rotinas.VerificaCPF(strCNPJ_CPF)) Then
                    Rotinas.CorSaida(sender)
                Else
                    Rotinas.CorEntrada(sender)
                    e.Cancel = True
                End If
            ElseIf Me.cboCADASTRO_TIPO.Text = "JURIDICO" Then
                If (Rotinas.VerificaCNPJ(strCNPJ_CPF)) Then
                    Rotinas.CorSaida(sender)
                Else
                    Rotinas.CorEntrada(sender)
                    e.Cancel = True
                End If
            End If
        End If

    End Sub

    Private Sub mskCNPJ_CPF_Leave(sender As System.Object, e As System.EventArgs)
        Rotinas.CorSaida(sender)
    End Sub

    Private Sub btnCONTATO_SALVAR_Click(sender As System.Object, e As System.EventArgs) Handles btnCONTATO_SALVAR.Click
        If VALIDAR_CAMPOS("CONTATOS") Then
            SALVAR_CONTATO()
        End If

    End Sub

    Private Sub btnHISTORICO_SALVAR_Click(sender As System.Object, e As System.EventArgs) Handles btnHISTORICO_SALVAR.Click
        If VALIDAR_CAMPOS("HISTORICO") Then
            SALVAR_HISTORICO()
        End If
    End Sub

    Private Sub SALVAR_HISTORICO()
        Dim myConnection As String = Rotinas.GetConnectionStringByName("servidor")
        Dim oNeObservacao As New negObservacao
        Dim oEtObservacao As New entObservacao
        Dim oEtUsuario As New entUsuario

        Try
            '' OBSERVAÇÃO
            With oEtObservacao
                .IdObservacao = Me.txtID_HISTORICO.Text
                .IdRelacao = Me.txtID_CLIENTE.Text
                .Observacao = Me.txtHISTORICO_DADOS.Text

                ''USUARIO
                With oEtUsuario
                    .Nome = Me.txtUser.Text
                End With
                .ENT_USUARIO = oEtUsuario

            End With


            '' OPERAÇÃO
            If oEtObservacao.IdObservacao.ToString = 0 Then
                If oNeObservacao.Incluir(oEtObservacao, myConnection) Then
                    getID_Historico(oEtObservacao.IdRelacao)
                    CARREGAR_GRIDE_HISTORICOS(oEtObservacao.IdRelacao, "")
                    MessageBox.Show("salvo")
                Else
                    MessageBox.Show("salvo, erro!")
                End If
            Else
                If oNeObservacao.Alterar(oEtObservacao, myConnection) Then
                    CARREGAR_GRIDE_HISTORICOS(oEtObservacao.IdRelacao, "")
                    MessageBox.Show("alterado")
                Else
                    MessageBox.Show("alterado, erro!")
                End If
            End If

            LIMPAR_HISTORICO()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub tabDADOS_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tabDADOS.SelectedIndexChanged

        If Not Me.txtID_CLIENTE.Text <> 0 Then
            dgvOBRAS.Enabled = False
            grbCLIENTE_PRINCIPAL_CONTATOS.Enabled = False
            grbCLIENTE_PRINCIPAL_HISTORICO.Enabled = False

        Else
            dgvOBRAS.Enabled = True
            grbCLIENTE_PRINCIPAL_CONTATOS.Enabled = True
            grbCLIENTE_PRINCIPAL_HISTORICO.Enabled = True

            '' LIMPAR ID'S DE CONTROLE
            LIMPAR_ID()

            If tabDADOS.SelectedIndex <> -1 Then

                Select Case tabDADOS.SelectedIndex

                    Case 1
                        Me.txtProcurarObra.Text = String.Empty
                        CARREGAR_GRIDE_OBRAS(Me.txtID_CLIENTE.Text, "")

                    Case 2
                        Me.txtProcurarContato.Text = String.Empty
                        CARREGAR_GRIDE_CONTATOS(Me.txtID_CLIENTE.Text, "")

                    Case 3
                        Me.txtProcurarHistorico.Text = String.Empty
                        CARREGAR_GRIDE_HISTORICOS(Me.txtID_CLIENTE.Text, "")

                End Select

            End If
        End If

    End Sub

    Private Sub cmdNovoObra_Click(sender As System.Object, e As System.EventArgs) Handles cmdNovoObra.Click

        If Me.txtID_CLIENTE.Text <> 0 Then
            SELECIONAR_OBRA(Me.txtID_CLIENTE.Text, 0)
        End If

    End Sub

    Private Sub dgvOBRAS_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOBRAS.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim idObra As Object = dgvOBRAS.Rows(e.RowIndex).Cells(0).Value
            Dim idCliente As Object = dgvOBRAS.Rows(e.RowIndex).Cells(1).Value

            Me.txtID_OBRA.Text = idObra
            If IsDBNull(idObra) Then
                MsgBox("")
            Else
                SELECIONAR_OBRA(idCliente, idObra)
            End If
        End If
    End Sub

    Private Sub SELECIONAR_OBRA(ByVal idCliente As String, ByVal idObra As String)

        Dim frm As New cadastroObra

        With frm
            .MdiParent = FPrincipal
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .txtID_CLIENTE.Text = idCliente
            .txtID_OBRA.Text = idObra
            .Show()
        End With


    End Sub

    Private Function faturamento(ByVal tipo As String) As Integer

        Select Case tipo

            Case "DIARIO"
                Return 1
            Case "SEMANAL"
                Return 7
            Case "QUINSENAL"
                Return 15
            Case "MENSAL"
                Return 30
            Case Else
                Return 0

        End Select

    End Function

    Private Sub formLock()
        Dim Ctrl As Control

        For Each Ctrl In Me.Controls
            If TypeOf Ctrl Is Button Then
                If Ctrl.Name = "btnCLIENTE_SALVAR" Then
                    Ctrl.Enabled = True
                Else
                    Ctrl.Enabled = False
                End If
            Else
                Ctrl.Enabled = False
            End If

        Next

    End Sub

    Private Sub formUnLock()
        Dim Ctrl As Control

        For Each Ctrl In Me.Controls
            Ctrl.Enabled = True
        Next

    End Sub

    Private Function VALIDAR_CAMPOS(ByVal sessao As String) As Boolean

        Dim blnRet As Boolean = False  'inicializar o valor como false

        With Me

            Select Case sessao

                Case "PRINCIPAL"

                    '' VALIDAR CNPJ_CPF
                    If Me.cboCADASTRO_TIPO.Text = "FISICO" Then

                        If Trim(Replace(Replace(.mskCNPJ_CPF.Text, ",", ""), "-", "")) = "" Then
                            ErrorProvider1.SetError(.mskCNPJ_CPF, "CNPJ_CPF. Campo de preenchimento obrigatório")
                        ElseIf Trim(Replace(Replace(Replace(Me.mskCNPJ_CPF.Text, ",", ""), "-", ""), "/", "")) = "" Then
                            ErrorProvider1.SetError(.mskCNPJ_CPF, "CNPJ_CPF. Campo de preenchimento obrigatório")
                        End If

                    End If

                    If Trim(.txtPRINCIPAL_NOME.Text) = "" Then

                        ErrorProvider1.SetError(.txtPRINCIPAL_NOME, "NOME. Campo de preenchimento obrigatório")
                        .txtPRINCIPAL_NOME.Focus()

                    ElseIf Trim(.txtPRINCIPAL_NOME_FANTASIA.Text) = "" Then

                        ErrorProvider1.SetError(.txtPRINCIPAL_NOME_FANTASIA, "NOME FANTASIA. Campo de preenchimento obrigatório")

                    ElseIf Trim(Replace(.mskPRINCIPAL_CEP.Text, "-", "")) = "" Then

                        ErrorProvider1.SetError(.mskPRINCIPAL_CEP, "CEP. Campo de preenchimento obrigatório")

                    ElseIf Trim(.txtPRINCIPAL_NUMERO.Text) = "" Then

                        ErrorProvider1.SetError(.txtPRINCIPAL_NUMERO, "NUMERO. Campo de preenchimento obrigatório")

                    ElseIf Trim(.txtPRINCIPAL_CONTATO.Text) = "" Then

                        ErrorProvider1.SetError(.txtPRINCIPAL_CONTATO, "CONTATO. Campo de preenchimento obrigatório")

                    ElseIf Trim(.txtPRINCIPAL_TELEFONE.Text) = "" Then

                        ErrorProvider1.SetError(.txtPRINCIPAL_TELEFONE, "TELEFONE. Campo de preenchimento obrigatório")

                    Else ''ocorreu um erro ao validar os dados do form

                        blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)

                    End If

                Case "CONTATOS"

                    If Trim(.txtCONTATO_NOME.Text) = "" Then

                        ErrorProvider1.SetError(.txtCONTATO_NOME, "NOME DO CONTATO. Campo de preenchimento obrigatório")

                    Else ''ocorreu um erro ao validar os dados do form

                        blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)

                    End If

                Case "HISTORICO"

                    If Trim(.txtHISTORICO_DADOS.Text) = "" Then

                        ErrorProvider1.SetError(.txtHISTORICO_DADOS, "HISTORICO. Campo de preenchimento obrigatório")


                    Else ''ocorreu um erro ao validar os dados do form

                        blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)

                    End If

            End Select


        End With


        Return blnRet

    End Function


    Private Sub btnEnderecoPrincipal_Click(sender As System.Object, e As System.EventArgs) Handles btnEnderecoPrincipal.Click
        CARREGAR_ENDERECO_PRINCIPAL(Trim(Replace(Me.mskPRINCIPAL_CEP.Text, "-", "")))
    End Sub

    Private Sub txtPRINCIPAL_NOME_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtPRINCIPAL_NOME.Validating
        Me.txtPRINCIPAL_NOME.Text = Rotinas.RemoveAcentos(Me.txtPRINCIPAL_NOME.Text)
    End Sub

    Private Sub txtPRINCIPAL_NOME_FANTASIA_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtPRINCIPAL_NOME_FANTASIA.Validating
        Me.txtPRINCIPAL_NOME_FANTASIA.Text = Rotinas.RemoveAcentos(Me.txtPRINCIPAL_NOME_FANTASIA.Text)
    End Sub

    Private Sub txtPRINCIPAL_CONTATO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtPRINCIPAL_CONTATO.Validating
        Me.txtPRINCIPAL_CONTATO.Text = Rotinas.RemoveAcentos(Me.txtPRINCIPAL_CONTATO.Text)
    End Sub

    Private Sub txtCADASTRO_OBSERVACAO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCADASTRO_OBSERVACAO.Validating
        Me.txtCADASTRO_OBSERVACAO.Text = Rotinas.RemoveAcentos(Me.txtCADASTRO_OBSERVACAO.Text)
    End Sub

    Private Sub txtCONTATO_NOME_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCONTATO_NOME.Validating
        Me.txtCONTATO_NOME.Text = Rotinas.RemoveAcentos(Me.txtCONTATO_NOME.Text)
    End Sub

    Private Sub cmdAtualizarObras_Click(sender As System.Object, e As System.EventArgs) Handles cmdAtualizarObras.Click
        If Me.txtID_CLIENTE.Text <> 0 Then
            CARREGAR_GRIDE_OBRAS(Me.txtID_CLIENTE.Text, "")
        End If
    End Sub

    Private Sub LIMPAR_ID()

        Me.txtID_OBRA.Text = 0
        Me.txtID_CONTATO.Text = 0

    End Sub

    Private Sub cmdNovoContato_Click(sender As System.Object, e As System.EventArgs) Handles cmdNovoContato.Click
        If Me.txtID_CLIENTE.Text <> 0 Then
            LIMPAR_CONTATO()
        End If

    End Sub

    Private Sub LIMPAR_CONTATO()

        With Me

            .txtID_CONTATO.Text = "0"
            .txtCONTATO_NOME.Text = String.Empty
            .txtCONTATO_EMAIL.Text = String.Empty
            .txtCONTATO_TELEFONE.Text = String.Empty
            .txtCONTATO_OBSERVACAO.Text = String.Empty

            .txtCONTATO_CLIENTE_CAD_USUARIO.Text = .txtUser.Text
            .txtCONTATO_CLIENTE_CAD_EMISSAO.Text = "00/00/0000"

            .txtCONTATO_CLIENTE_ALT_USUARIO.Text = .txtUser.Text
            .txtCONTATO_CLIENTE_ALT_EMISSAO.Text = "00/00/0000"

            .txtCONTATO_NOME.Focus()

        End With

    End Sub

    Private Sub SALVAR_CONTATO()
        Dim myConnection As String = Rotinas.GetConnectionStringByName("servidor")
        Dim oNeContato As New negContatoCliente
        Dim oEtContato As New entContato
        Dim oEtUsuario As New entUsuario

        Try
            '' CONTATO
            With oEtContato
                .IdContato = Me.txtID_CONTATO.Text
                .IdRelacao = Me.txtID_CLIENTE.Text
                .NomeContato = Me.txtCONTATO_NOME.Text
                .Telefone = Me.txtCONTATO_TELEFONE.Text
                .Email = Me.txtCONTATO_EMAIL.Text
                .Observacao = Me.txtCONTATO_OBSERVACAO.Text()
                .Solicitante = "0"

                ''USUARIO
                With oEtUsuario
                    .Nome = Me.txtUser.Text
                End With
                .ENT_USUARIO = oEtUsuario

            End With

            '' OPERAÇÃO
            If oEtContato.IdContato.ToString = 0 Then
                If oNeContato.Incluir(oEtContato, myConnection) Then
                    getID_Contato(oEtContato.IdRelacao)
                    CARREGAR_GRIDE_CONTATOS(oEtContato.IdRelacao, "")
                    MessageBox.Show("salvo")
                Else
                    MessageBox.Show("salvo, erro!")
                End If
            Else
                If oNeContato.Alterar(oEtContato, myConnection) Then
                    CARREGAR_GRIDE_CONTATOS(oEtContato.IdRelacao, "")
                    MessageBox.Show("alterado")
                Else
                    MessageBox.Show("alterado, erro!")
                End If
            End If

            LIMPAR_CONTATO()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub getID_Contato(ByVal idCliente As String)

        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("SELECT id,cad_usuario,cad_emissao,alt_usuario,alt_emissao FROM vw_cad_clientes_contatos WHERE id_cliente = '" + idCliente + "' LIMIT 1", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()
        With Me
            While rdrRegistro.Read
                .txtID_CONTATO.Text = rdrRegistro("ID").ToString()
                .txtCONTATO_CLIENTE_CAD_USUARIO.Text = rdrRegistro("CAD_USUARIO").ToString()
                .txtCONTATO_CLIENTE_CAD_EMISSAO.Text = rdrRegistro("CAD_EMISSAO").ToString()
                .txtCONTATO_CLIENTE_ALT_USUARIO.Text = rdrRegistro("ALT_USUARIO").ToString()
                .txtCONTATO_CLIENTE_ALT_EMISSAO.Text = rdrRegistro("ALT_EMISSAO").ToString()
            End While
        End With

        rdrRegistro.Close()
        cmdSQL.Dispose()

    End Sub

    Private Sub getID_Historico(ByVal idCliente As String)

        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("SELECT id,cad_usuario,cad_emissao,alt_usuario,alt_emissao FROM vw_cad_clientes_historicos WHERE id_cliente = '" + idCliente + "' LIMIT 1", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()
        With Me
            While rdrRegistro.Read
                .txtID_CONTATO.Text = rdrRegistro("ID").ToString()
                .txtCONTATO_CLIENTE_CAD_USUARIO.Text = rdrRegistro("CAD_USUARIO").ToString()
                .txtCONTATO_CLIENTE_CAD_EMISSAO.Text = rdrRegistro("CAD_EMISSAO").ToString()
                .txtCONTATO_CLIENTE_ALT_USUARIO.Text = rdrRegistro("ALT_USUARIO").ToString()
                .txtCONTATO_CLIENTE_ALT_EMISSAO.Text = rdrRegistro("ALT_EMISSAO").ToString()
            End While
        End With

        rdrRegistro.Close()
        cmdSQL.Dispose()

    End Sub

    Private Sub CARREGAR_GRIDE_CONTATOS(ByVal idCliente As String, ByVal strProcurar As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        myConnection.Open()
        Dim ds As New DataSet()
        Dim strSQL As String

        If strProcurar = "" Then
            strSQL = "Select * from vw_dgv_clientes_contatos where ID_CLIENTE ='" + idCliente + "'"
        Else
            strSQL = "Select * from vw_dgv_clientes_contatos where ID_CLIENTE ='" + idCliente + "' AND CONTATO LIKE '%" & Trim(strProcurar) & "%'"
        End If

        Dim da As New MySqlDataAdapter(New MySqlCommand(strSQL, myConnection))


        ds.Clear()
        da.Fill(ds, "vw_dgv_clientes_contatos")

        With dgvCONTATOS
            .DataSource = ds.Tables("vw_dgv_clientes_contatos")
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With

        myConnection.Close()

    End Sub

    Private Sub CARREGAR_GRIDE_HISTORICOS(ByVal idCliente As String, ByVal strProcurar As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        myConnection.Open()
        Dim ds As New DataSet()
        Dim strSQL As String

        If strProcurar = "" Then
            strSQL = "Select * from vw_dgv_clientes_historicos where ID_CLIENTE ='" + idCliente + "'"
        Else
            strSQL = "Select * from vw_dgv_clientes_historicos where ID_CLIENTE ='" + idCliente + "' AND HISTORICO LIKE '%" & Trim(strProcurar) & "%'"
        End If

        Dim da As New MySqlDataAdapter(New MySqlCommand(strSQL, myConnection))

        ds.Clear()
        da.Fill(ds, "vw_dgv_clientes_historicos")

        With dgvHISTORICOS
            .DataSource = ds.Tables("vw_dgv_clientes_historicos")
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With

        myConnection.Close()

    End Sub

    Private Sub dgvCONTATOS_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCONTATOS.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim value As Object = dgvCONTATOS.Rows(e.RowIndex).Cells(0).Value
            Me.txtID_CONTATO.Text = value
            If IsDBNull(value) Then
                MsgBox("")
            Else
                CARREGAR_CADASTRO_CONTATO(CType(value, String))
            End If
        End If
    End Sub

    Private Sub cmdNovoHistorico_Click(sender As System.Object, e As System.EventArgs) Handles cmdNovoHistorico.Click
        If Me.txtID_CLIENTE.Text <> 0 Then
            LIMPAR_HISTORICO()
        End If

    End Sub

    Private Sub LIMPAR_HISTORICO()

        With Me

            .txtID_HISTORICO.Text = "0"
            .txtHISTORICO_DADOS.Text = String.Empty


            .txtHISTORICO_CAD_USUARIO.Text = .txtUser.Text
            .txtHISTORICO_CAD_EMISSAO.Text = "00/00/0000"

            .txtHISTORICO_ALT_USUARIO.Text = .txtUser.Text
            .txtHISTORICO_ALT_EMISSAO.Text = "00/00/0000"

            .txtCONTATO_NOME.Focus()

        End With

    End Sub

    Private Sub dgvHISTORICOS_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHISTORICOS.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim value As Object = dgvHISTORICOS.Rows(e.RowIndex).Cells(0).Value
            Me.txtID_HISTORICO.Text = value
            If IsDBNull(value) Then
                MsgBox("")
            Else
                CARREGAR_CADASTRO_HISTORICO(CType(value, String))
            End If
        End If
    End Sub

    Private Sub F_CAD_CLIENTE_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cmdProcurarObra_Click(sender As System.Object, e As System.EventArgs) Handles cmdProcurarObra.Click
        CARREGAR_GRIDE_OBRAS(Me.txtID_CLIENTE.Text, Me.txtProcurarObra.Text)
    End Sub

    Private Sub cmdProcurarContato_Click(sender As System.Object, e As System.EventArgs) Handles cmdProcurarContato.Click
        CARREGAR_GRIDE_CONTATOS(Me.txtID_CLIENTE.Text, Me.txtProcurarContato.Text)
    End Sub


    Private Sub cmdProcurarHistorico_Click(sender As System.Object, e As System.EventArgs) Handles cmdProcurarHistorico.Click
        CARREGAR_GRIDE_HISTORICOS(Me.txtID_CLIENTE.Text, Me.txtProcurarHistorico.Text)
    End Sub
End Class
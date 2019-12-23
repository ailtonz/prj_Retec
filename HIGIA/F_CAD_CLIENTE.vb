Imports System
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports HigiaENT
Imports HigiaNEG

Public Class F_CAD_CLIENTE

    Private _cliente As entCliente

    Protected Rotinas As ClasseRotinasDiversas

    Dim Observacoes() As String = {"CONSTA PROTESTOS", "DEVEDOR - BOLETOS EM ABERTO", "HISTORICO", "NAO LIBERAR - MAL PAGADOR", "PROTESTADO - BANCO", "PROTESTADO - RETEC", "SO AVISTA", "VER SITE DE PROTESTOS"}
    Dim Propagandas() As String = {"CAÇAMBA NA RUA", "GOOGLE", "INDICAÇÃO", "LISTA TELEFÔNICA"}
    Dim Transacoes() As String = {"BOLETO", "DEBITO", "DEPOSITO", "TRANSFERENCIA"}
    Dim Condicoes() As String = {"DIARIO", "SEMANAL", "QUINZENAL", "MENSAL"}
    Dim CondicoesID() As String = {"1", "7", "15", "30"}
    Dim Status() As String = {"LIBERADO", "BLOQUEADO"}
    Dim TiposCadastros() As String = {"FISICO", "JURIDICO"}


    Private Sub F_CAD_CLIENTE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Rotinas = New ClasseRotinasDiversas

        Me.txtUser.Text = GetConnectionStringByName("user").ToString

        '' CARREGAR CAMPOS
        CARREGAR_CAMPOS()

        formLock()

        '' AO SELECIONAR UM CLIENTE CARREGA OS DADOS E MUDA A FUNÇÃO DO REGISTRO
        If Me.txtID_CLIENTE.Text <> 0 Then
            CARREGAR_CLIENTE(Me.txtID_CLIENTE.Text)
            MUDAR_FUNCAO_CLIENTE()
        End If


    End Sub


    Private Sub btnCLIENTE_SALVAR_Click(sender As System.Object, e As System.EventArgs) Handles btnCLIENTE_SALVAR.Click

        '' DESTRAVAR
        formUnLock()

        If Me.btnCLIENTE_SALVAR.Text <> "NOVO" Then

            If ValidarCampos("PRINCIPAL") Then
                SalvarCliente()
            End If

        Else
            '' MUDAR FUNÇÃO DO BOTÃO
            MUDAR_FUNCAO_CLIENTE()
        End If

    End Sub

    Private Sub MUDAR_FUNCAO_CLIENTE()
        If Me.txtID_CLIENTE.Text = 0 Then
            Me.btnCLIENTE_SALVAR.Text = "SALVAR"
        Else
            Me.btnCLIENTE_SALVAR.Text = "ALTERAR"
        End If
    End Sub

    Private Sub SalvarCliente()
        Dim myConnection As String = GetConnectionStringByName("servidor")


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

                        CARREGAR_CLIENTE(txtID_CLIENTE.Text)
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

        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

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

    Private Sub CARREGAR_CLIENTE(ByVal idCliente As String)
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

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
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

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

    Private Sub CARREGAR_CONTATO_CLIENTE(ByVal idContatoCliente As String)
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

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

    Private Sub CARREGAR_HISTORICO(ByVal idHistorico As String)
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

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

    Private Sub CARREGAR_GRIDE_OBRAS(ByVal idCliente As String)
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))
        myConnection.Open()
        Dim ds As New DataSet()
        Dim da As New MySqlDataAdapter(New MySqlCommand("Select * from vw_psq_obras where ID_CLIENTE ='" + idCliente + "'", myConnection))

        ds.Clear()
        da.Fill(ds, "vw_psq_obras")

        With dgvOBRAS
            .DataSource = ds.Tables("vw_psq_obras")
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With

        myConnection.Close()

    End Sub

    Private Sub CARREGAR_CAMPOS()
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

        'With Me.cboCONTRATO_FORMA_PAGAMENTO
        '    .Items.Clear()
        '    For Each Transacao In Transacoes
        '        .Items.Add(Transacao)
        '    Next
        '    .SelectedIndex = CInt(.FindString("BOLETO"))
        'End With


        'With Me.cboCONTRATO_FATURAMENTO_DIAS
        '    .Items.Clear()

        '    .Items.Add(New Mylist("DIARIO", 1))
        '    .Items.Add(New Mylist("SEMANAL", 7))
        '    .Items.Add(New Mylist("QUINZENAL", 15))
        '    .Items.Add(New Mylist("MENSAL", 30))

        '    'For Each Condicao In Condicoes
        '    '    .Items.Add(Condicao)
        '    'Next
        '    .SelectedIndex = CInt(.FindString("DIARIO"))
        'End With

        'Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

        'Dim ds As New DataSet()
        'Dim dsCONDICOES As New DataSet()

        'myConnection.Open()

        'Dim daOBSERVACOES As New MySqlDataAdapter(New MySqlCommand("Select * from vw_cad_clientes_status ", myConnection))
        'Dim daPROPAGANDAS As New MySqlDataAdapter(New MySqlCommand("Select * from vw_uteis_propagandas ", myConnection))
        'Dim daTRANSACAO As New MySqlDataAdapter(New MySqlCommand("Select * from vw_mov_transacao order by transacao", myConnection))
        'Dim daCONDICOES As New MySqlDataAdapter(New MySqlCommand("Select condicao, condicao_pagamento from vw_mov_condicoes ", myConnection))



        ' ''''''''''''''''''''''''''''''
        ' '' CARREGAR - OBSERVAÇÕES
        ' ''''''''''''''''''''''''''''''

        'daOBSERVACOES.Fill(ds, "vw_cad_clientes_status")

        ' '' SELEÇÃO DE ITEM - OBSERVAÇÃO
        'Me.cboSTATUS_OBSERVACAO.DataSource = ds.Tables("vw_cad_clientes_status")
        'Me.cboSTATUS_OBSERVACAO.DisplayMember = "CADASTRO_OBSERVACAO"
        'Me.cboSTATUS_OBSERVACAO.SelectedIndex = CInt(Me.cboSTATUS_OBSERVACAO.FindString("VER SITE DE PROTESTOS"))


        ' ''''''''''''''''''''''''''''''
        ' '' CARREGAR - PROPAGANDAS
        ' ''''''''''''''''''''''''''''''
        'daPROPAGANDAS.Fill(ds, "vw_uteis_propagandas")

        ' '' SELEÇÃO DE ITEM - PROPAGANDA
        'Me.cboCADASTRO_PROPAGANDA.DataSource = ds.Tables("vw_uteis_propagandas")
        'Me.cboCADASTRO_PROPAGANDA.DisplayMember = "PROPAGANDA"
        'Me.cboCADASTRO_PROPAGANDA.SelectedIndex = CInt(Me.cboCADASTRO_PROPAGANDA.FindString("GOOGLE"))

        ' '''''''''''''''''''''''''''''''''''''''''''''''
        ' '' CARREGAR - TRANSACAO ( FORMA DE PAGAMENTO )
        ' '''''''''''''''''''''''''''''''''''''''''''''''
        'daTRANSACAO.Fill(ds, "vw_mov_transacao")

        ' '' SELEÇÃO DE ITEM - PAGAMENTO
        'Me.cboCONTRATO_FORMA_PAGAMENTO.DataSource = ds.Tables("vw_mov_transacao")
        'Me.cboCONTRATO_FORMA_PAGAMENTO.DisplayMember = "TRANSACAO"
        'Me.cboCONTRATO_FORMA_PAGAMENTO.SelectedIndex = CInt(Me.cboCONTRATO_FORMA_PAGAMENTO.FindString("BOLETO"))

        ' '''''''''''''''''''''''''''''''''''''''''''''''
        ' '' CARREGAR - CONDICOES ( FATURAMENTO EM X DIAS )
        ' '''''''''''''''''''''''''''''''''''''''''''''''
        'daCONDICOES.Fill(dsCONDICOES, "vw_mov_condicoes")

        ' '' SELEÇÃO DE ITEM - FATURAMENTO
        'With cboCONTRATO_FATURAMENTO_DIAS
        '    .DataSource = dsCONDICOES.Tables("vw_mov_condicoes")
        '    .DisplayMember = "CONDICAO_PAGAMENTO"
        '    .ValueMember = "CONDICAO"
        '    .SelectedIndex = CInt(Me.cboCONTRATO_FATURAMENTO_DIAS.FindString("DIARIO"))
        'End With

        ' ''''''''''''''''''''''''''''''
        ' '' SELEÇÃO DE ITEM - STATUS
        ' ''''''''''''''''''''''''''''''
        'Me.cboSTATUS.SelectedIndex = CInt(Me.cboSTATUS.FindString("LIBERADO"))

        ' ''''''''''''''''''''''''''''''
        ' '' SELEÇÃO DE ITEM - TIPO
        ' ''''''''''''''''''''''''''''''
        'Me.cboCADASTRO_TIPO.SelectedIndex = CInt(Me.cboCADASTRO_TIPO.FindString("FISICO"))

        'myConnection.Close()

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

    Private Sub btnCLIENTE_PESQUISAR_Click(sender As System.Object, e As System.EventArgs) Handles btnCLIENTE_PESQUISAR.Click

        'Me.Dispose()
        'F_PSQ_CLIENTES.ShowDialog()

        pesquisar()


        ' '' LIMPAR CAMPOS
        'Rotinas.Limpar_Campos(Me)

        ' '' SELEÇÃO DE CLIENTE
        'With F_PSQ_CLIENTES

        '    .Text = "PESQUISA DE CLIENTES"
        '    .strSQL = "Select * from vw_psq_clientes"
        '    .strTable = "vw_psq_clientes"

        '    .WindowState = FormWindowState.Normal
        '    '.WindowState = FormWindowState.Maximized

        '    .ShowDialog()
        '    strCodigoCliente = .strValorRetorno
        '    .Dispose()

        '    .FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        'End With

        'If strCodigoCliente <> "" Then

        '    CLIENTE_OPERACAO("CARREGAR", strCodigoCliente)

        'End If

    End Sub

    Private Sub PESQUISAR()

        Dim frmPesquisar As New F_PSQ_CLIENTES

        With frmPesquisar
            .MdiParent = FPrincipal
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With


    End Sub

    Private Sub CARREGAR_DADOS_CLIENTE(ByVal strID_Cliente As String)


        'Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

        ''Cria o objeto DataSet
        'Dim ds As New DataSet()

        ' '' OBRAS
        'Dim daOBRAS As New MySqlDataAdapter(New MySqlCommand("Select * from vw_cad_clientes_obras where ID_CLIENTE = " + strID_Cliente + "", myConnection))
        'daOBRAS.Fill(ds, "vw_cad_clientes_obras")

        'With dgvOBRAS
        '    .DataSource = ds.Tables("vw_cad_clientes_obras")
        '    .Refresh()

        '    .ReadOnly = True
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    .AllowDrop = False
        '    .AllowUserToAddRows = False
        '    .AllowUserToDeleteRows = False
        'End With


        ' '' CONTATOS
        'Dim daCONTATOS As New MySqlDataAdapter(New MySqlCommand("Select * from vw_cad_clientes_contatos where ID_CLIENTE = " + strID_Cliente + "", myConnection))
        'daCONTATOS.Fill(ds, "vw_cad_clientes_contatos")

        'With dgvCONTATOS
        '    .DataSource = ds.Tables("vw_cad_clientes_contatos")
        '    .Refresh()

        '    .ReadOnly = True
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    .AllowDrop = False
        '    .AllowUserToAddRows = False
        '    .AllowUserToDeleteRows = False
        'End With


        ' '' COBRANCAS
        'Dim daCOBRANCAS As New MySqlDataAdapter(New MySqlCommand("Select * from vw_cad_clientes_cobranca where ID_CLIENTE = " + strID_Cliente + "", myConnection))
        'daCOBRANCAS.Fill(ds, "vw_cad_clientes_cobranca")

        'With dgvCOBRANCAS
        '    .DataSource = ds.Tables("vw_cad_clientes_cobranca")
        '    .Refresh()

        '    .ReadOnly = True
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    .AllowDrop = False
        '    .AllowUserToAddRows = False
        '    .AllowUserToDeleteRows = False
        'End With


        ' '' HISTORICO
        'Dim daHISTORICOS As New MySqlDataAdapter(New MySqlCommand("Select * from vw_cad_clientes_historicos where ID_CLIENTE = " + strID_Cliente + "", myConnection))
        'daHISTORICOS.Fill(ds, "vw_cad_clientes_historicos")

        'With dgvHISTORICOS
        '    .DataSource = ds.Tables("vw_cad_clientes_historicos")
        '    .Refresh()

        '    .ReadOnly = True
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    .AllowDrop = False
        '    .AllowUserToAddRows = False
        '    .AllowUserToDeleteRows = False
        'End With


        ' '' HISTORICO
        'Dim daSOLICITACOES As New MySqlDataAdapter(New MySqlCommand("Select * from vw_srv_ligacoes where ID_CLIENTE = " + strID_Cliente + "", myConnection))
        'daSOLICITACOES.Fill(ds, "vw_srv_ligacoes")

        'With dgvSOLICITACOES
        '    .DataSource = ds.Tables("vw_srv_ligacoes")
        '    .Refresh()

        '    .ReadOnly = True
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    .AllowDrop = False
        '    .AllowUserToAddRows = False
        '    .AllowUserToDeleteRows = False
        'End With

        'myConnection.Close()

    End Sub

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

    Private Sub carregarGride(ByVal mySelectQuery As String, ByVal strTable As String, ByVal strConnection As String, ByVal dgvDADOS As DataGridView)


        'Dim myConnection As New MySqlConnection(GetConnectionStringByName(strConnection))
        'Dim cmd As New MySqlCommand(mySelectQuery, myConnection)

        'myConnection.Open()

        ''Cria o objeto DataAdapter
        'Dim adaptador As New MySqlDataAdapter(cmd)

        ''Cria o objeto DataSet
        'Dim ds As New DataSet()

        ''Preenche o dataset
        'adaptador.Fill(ds, strTable)

        ''Exibe os dados em um datagrid
        'dgvDADOS.DataSource = ds.Tables(strTable)

        ''Always call Close when done with connection.
        'myConnection.Close()


    End Sub

    Private Sub LIMPAR_DATAGRIDVIEW()

        'Me.dgvOBRAS.DataSource = Nothing
        'Me.dgvCONTATOS.DataSource = Nothing
        'Me.dgvCOBRANCAS.DataSource = Nothing
        'Me.dgvHISTORICOS.DataSource = Nothing
        'Me.dgvSOLICITACOES.DataSource = Nothing

    End Sub

    Private Sub BLOQUEIO_CLIENTE()

        Me.grbCLIENTE_DADOS.Enabled = False
        Me.tabDADOS.Enabled = False

    End Sub

    Private Sub DESBLOQUEIO_CLIENTE()

        Me.grbCLIENTE_DADOS.Enabled = True
        Me.tabDADOS.Enabled = True

    End Sub



    Private Sub btnCONTATO_SALVAR_Click(sender As System.Object, e As System.EventArgs) Handles btnCONTATO_SALVAR.Click
        If ValidarCampos("CONTATOS") Then
            SalvarContato()
        End If

    End Sub

    Private Sub btnHISTORICO_SALVAR_Click(sender As System.Object, e As System.EventArgs) Handles btnHISTORICO_SALVAR.Click
        If ValidarCampos("HISTORICO") Then
            SalvarHistorico()
        End If
    End Sub

    Private Sub SalvarHistorico()
        Dim myConnection As String = GetConnectionStringByName("servidor")
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
                    CARREGAR_GRIDE_HISTORICOS(oEtObservacao.IdRelacao)
                    MessageBox.Show("salvo")
                Else
                    MessageBox.Show("salvo, erro!")
                End If
            Else
                If oNeObservacao.Alterar(oEtObservacao, myConnection) Then
                    CARREGAR_GRIDE_HISTORICOS(oEtObservacao.IdRelacao)
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

    'Private Sub btnOBRA_SALVAR_Click(sender As System.Object, e As System.EventArgs)
    '    Dim myConnection As String = GetConnectionStringByName("servidor")
    '    Dim oNeObra As New negObra

    '    Dim oEtObra As New entObra
    '    Dim oEtObraUsuario As New entUsuario

    '    Dim oEtObraEndereco As New entEndereco
    '    Dim oEtObraContato As New entContato
    '    Dim oEtObraContatoUsuario As New entUsuario

    '    Dim oEtCobrancaEndereco As New entCobranca
    '    Dim oEtCobrancaContato As New entContato
    '    Dim oEtCobrancaContatoUsuario As New entUsuario

    '    Dim oEtContrato As New entContrato

    '    Try
    '        '' DADOS DA OBRA
    '        With oEtObra
    '            .IdRelacao = Me.txtID_CLIENTE.Text
    '            .IdObra = Me.txtID_OBRA.Text

    '            '' ENDERECO DA OBRA
    '            With oEtObraEndereco
    '                .Cep = Trim(Replace(Me.mskOBRA_CEP.Text, "-", ""))
    '                .Numero = Me.txtOBRA_NUMERO.Text
    '                .Complemento = Me.txtOBRA_COMPLEMENTO.Text
    '            End With
    '            .ENT_ENDERECO = oEtObraEndereco

    '            '' CONTATO DA OBRA
    '            With oEtObraContato
    '                .NomeContato = Me.txtOBRA_CONTATO.Text
    '                .Telefone = Me.txtOBRA_TELEFONE.Text
    '                .Email = Me.txtOBRA_EMAIL.Text

    '                'With oEtObraContatoUsuario
    '                '    .Nome = Me.txtUser.Text
    '                'End With
    '                '.ENT_USUARIO = oEtObraContatoUsuario

    '            End With
    '            .ENT_CONTATO = oEtObraContato

    '            '' ENDERECO DE COBRANÇA
    '            With oEtCobrancaEndereco

    '                .Sacado = Me.txtCOBRANCA_SACADO.Text

    '                If Me.cboCOBRANCA_TIPO.Text = "FISICO" Then
    '                    .TipoCobranca = "pf"
    '                    .Inscricao = Trim(Replace(Replace(Me.mskCOBRANCA_INSCRICAO.Text, ",", ""), "-", ""))
    '                ElseIf Me.cboCOBRANCA_TIPO.Text = "JURIDICO" Then
    '                    .TipoCobranca = "pj"
    '                    .Inscricao = Trim(Replace(Replace(Me.mskCOBRANCA_INSCRICAO.Text, ",", ""), "-", ""))
    '                End If

    '                .Cep = Trim(Replace(Me.mskCOBRANCA_CEP.Text, "-", ""))
    '                .Logradouro = Me.txtCOBRANCA_LOGRADOURO.Text
    '                .Bairro = Me.txtCOBRANCA_BAIRRO.Text
    '                .Cidade = Me.txtCOBRANCA_CIDADE.Text
    '                .Estado = Me.txtCOBRANCA_ESTADO.Text

    '                '' CONTATO DE COBRANÇA
    '                With oEtCobrancaContato
    '                    .NomeContato = Me.txtCOBRANCA_NOME.Text
    '                    .Telefone = Me.txtCOBRANCA_TELEFONE.Text
    '                    .Email = Me.txtCOBRANCA_EMAIL.Text

    '                    'With oEtCobrancaContatoUsuario
    '                    '    .Nome = Me.txtUser.Text
    '                    'End With
    '                    '.ENT_USUARIO = oEtCobrancaContatoUsuario

    '                End With
    '                .ENT_CONTATO = oEtCobrancaContato

    '            End With
    '            .ENT_COBRANCA = oEtCobrancaEndereco

    '            '' CONTRATO DA OBRA
    '            With oEtContrato
    '                .DataInicio = Me.dtpCONTRATO_INICIO.Text
    '                .ValorUnitario = Me.txtCONTRATO_VALOR.Text
    '                .nfe = IIf(Me.chkCONTRATO_NF.Checked, "1", "0")
    '                .iss = IIf(Me.chkCONTRATO_ISS.Checked, "1", "0")
    '                .ctr = IIf(Me.chkCONTRATO_CTR.Checked, "1", "0")
    '                .FormaDePagamento = Me.cboCONTRATO_FORMA_PAGAMENTO.Text
    '                .FaturamentoDias = faturamento(Me.cboCONTRATO_FATURAMENTO_DIAS.SelectedItem.ToString)
    '                .PeriodoLocacao = Me.txtCONTRATO_PERIDO_LOCACAO.Text
    '                .RetiradaAutomatica = Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text
    '                .VencimentoAposEntrega = Me.txtCONTRATO_VCTO_APOS_ENTREGA.Text
    '                .MultaMora = Me.txtCONTRATO_MULTA_MORA.Text
    '                .MultaDia = Me.txtCONTRATO_MULTA_DIA.Text
    '            End With
    '            .ENT_CONTRATO = oEtContrato

    '            ''USUARIO
    '            With oEtObraUsuario
    '                .Nome = Me.txtUser.Text
    '            End With
    '            .ENT_USUARIO = oEtObraUsuario

    '            .ObsLigacao = Me.txtCONTRATO_OBS_LIGACAO.Text
    '            .ObsColoca = Me.txtCONTRATO_OBS_COLOCA.Text
    '            .ObsTroca = Me.txtCONTRATO_OBS_TROCA.Text
    '            .ObsRetira = Me.txtCONTRATO_OBS_RETIRA.Text
    '            .ObsObra = Me.txtOBS_OBRA.Text

    '        End With

    '        oNeObra.Incluir(oEtObra, myConnection)

    '        MessageBox.Show("salvo")

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub btnOBRA_CONTATO_SALVAR_Click(sender As System.Object, e As System.EventArgs) Handles btnOBRA_CONTATO_SALVAR.Click
    '    Dim myConnection As String = GetConnectionStringByName("servidor")
    '    Dim oNeContatoObra As New negContatoObra
    '    Dim oEtContato As New entContato
    '    Dim oEtUsuario As New entUsuario

    '    Try
    '        '' CONTATO
    '        With oEtContato
    '            .IdContato = "0"
    '            .IdRelacao = Me.txtID_OBRA.Text
    '            .NomeContato = Me.txtCONTATO_OBRA_NOME.Text
    '            .Telefone = Me.txtCONTATO_OBRA_TELEFONE.Text
    '            .Email = Me.txtCONTATO_OBRA_EMAIL.Text
    '            .Observacao = Me.txtCONTATO_OBRA_OBSERVACAO.Text()
    '            .Solicitante = IIf(Me.chkCONTATO_OBRA_SOLICITANTE.Checked, "1", "0")

    '            ''USUARIO
    '            With oEtUsuario
    '                .Nome = Me.txtUser.Text
    '            End With
    '            .ENT_USUARIO = oEtUsuario

    '        End With

    '        oNeContatoObra.Incluir(oEtContato, myConnection)

    '        CARREGAR_GRIDE_OBRAS_CONTATOS(Me.txtID_OBRA.Text)

    '        MessageBox.Show("salvo")

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub



    Private Sub cboSTATUS_OBSERVACAO_Enter(sender As System.Object, e As System.EventArgs) Handles cboSTATUS_OBSERVACAO.Enter
        'Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

        'Dim ds As New DataSet()

        'Dim daOBSERVACOES As New MySqlDataAdapter(New MySqlCommand("Select * from vw_cad_clientes_status order by CADASTRO_OBSERVACAO", myConnection))

        'daOBSERVACOES.Fill(ds, "vw_cad_clientes_status")

        ' '' SELEÇÃO DE ITEM - OBSERVAÇÃO

        'With Me.cboSTATUS_OBSERVACAO
        '    .DataSource = ds.Tables("vw_cad_clientes_status").DefaultView
        '    .DisplayMember = "CADASTRO_OBSERVACAO"
        '    .SelectedIndex = CInt(Me.cboSTATUS_OBSERVACAO.FindString("VER SITE DE PROTESTOS"))

        '    '.DropDownStyle = ComboBoxStyle.DropDown
        '    '.AutoCompleteMode = AutoCompleteMode.Suggest
        '    '.AutoCompleteSource = AutoCompleteSource.ListItems
        'End With


        'Dim conn As New MySqlConnection(GetConnectionStringByName("servidor"))
        'Dim da As New MySqlDataAdapter("Select * from vw_cad_clientes_status order by CADASTRO_OBSERVACAO", conn)
        'Dim ds As New DataSet

        'Me.lblCADASTRO_OBSERVACAO.Text = Now()

        'da.Fill(ds, "vw_cad_clientes_status")

        'With Me.cboSTATUS_OBSERVACAO
        '    .DataSource = ds.Tables("vw_cad_clientes_status")
        '    .DisplayMember = "CADASTRO_OBSERVACAO"
        '    .SelectedIndex = CInt(Me.cboSTATUS_OBSERVACAO.FindString("VER SITE DE PROTESTOS"))
        'End With


        'conn.Open()


        'Dim i = -1
        'Dim dr As MySqlDataReader

        'Dim cmd As New MySqlCommand("Select * from vw_cad_clientes_status order by CADASTRO_OBSERVACAO", conn)

        'dr = cmd.ExecuteReader

        'With Me.cboSTATUS_OBSERVACAO
        '    .Items.Clear()
        '    While dr.Read
        '        i += 1
        '        cboSTATUS_OBSERVACAO.Items.Insert(i, dr.GetString(1) & " - " & dr.GetString(2))
        '    End While
        '    dr.Close()
        '    conn.Close()
        'End With

        'Dim Observacao As String

        'Me.cboSTATUS_OBSERVACAO.Items.Clear()
        'For Each Observacao In Observacoes
        '    Me.cboSTATUS_OBSERVACAO.Items.Add(Observacao)
        'Next

        'Me.lblCADASTRO_OBSERVACAO.Text = Me.lblCADASTRO_OBSERVACAO.Text & " - " & Now()

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
            LimparIds()

            If tabDADOS.SelectedIndex <> -1 Then

                Select Case tabDADOS.SelectedIndex

                    Case 1

                        CARREGAR_GRIDE_OBRAS(Me.txtID_CLIENTE.Text)

                    Case 2

                        CARREGAR_GRIDE_CONTATOS(Me.txtID_CLIENTE.Text)

                    Case 3

                        CARREGAR_GRIDE_HISTORICOS(Me.txtID_CLIENTE.Text)

                End Select

            End If
        End If

    End Sub

    Private Sub cmdNovoObra_Click(sender As System.Object, e As System.EventArgs) Handles cmdNovoObra.Click

        If Me.txtID_CLIENTE.Text <> 0 Then
            MOSTRAR_OBRA(Me.txtID_CLIENTE.Text, 0)
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

                'F_CAD_OBRA.txtID_CLIENTE.Text = idCliente
                'F_CAD_OBRA.txtID_OBRA.Text = idObra
                'F_CAD_OBRA.Show()

                MOSTRAR_OBRA(idCliente, idObra)

                'CARREGAR_OBRA(CType(value, String))
                'Me.tabObra.SelectTab("pgDadosObra")
            End If
        End If
    End Sub

    Private Sub MOSTRAR_OBRA(ByVal idCliente As String, ByVal idObra As String)

        Dim frm As New F_CAD_OBRA

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


    'Private Sub MsgBoxTransacoes()
    '    Dim Condicao As String
    '    Dim CondicaoID As String

    '    For Each Condicao In Condicoes
    '        MsgBox(Condicao)
    '        For Each CondicaoID In CondicoesID
    '            MsgBox(CondicaoID)
    '        Next
    '    Next

    'End Sub

    'Private Sub tabObraDados_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tabObraDados.SelectedIndexChanged



    '    If tabObraDados.SelectedIndex <> -1 Then

    '        Select Case tabObraDados.SelectedIndex

    '            Case 2
    '                If dgvOBRAS_CONTATOS.RowCount > 0 Then
    '                    CARREGAR_GRIDE_OBRAS_CONTATOS(Me.txtID_OBRA.Text)
    '                End If



    '        End Select



    '    End If
    'End Sub

    'Private Sub dgvOBRAS_CONTATOS_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOBRAS_CONTATOS.CellDoubleClick
    '    If e.RowIndex <> -1 Then
    '        Dim value As Object = dgvOBRAS_CONTATOS.Rows(e.RowIndex).Cells(0).Value
    '        Me.txtID_CONTATO.Text = value
    '        If IsDBNull(value) Then
    '            MsgBox("")
    '        Else
    '            CARREGAR_CONTATO_OBRA(CType(value, String))
    '        End If
    '    End If
    'End Sub

    'Private Sub cmdNovoObraContato_Click(sender As System.Object, e As System.EventArgs)
    '    LIMPAR_CONTATO_OBRA()

    'End Sub


    'Private Sub cmdAlterarObra_Click(sender As System.Object, e As System.EventArgs)
    '    If Me.txtID_OBRA.Text < 0 Then
    '        MsgBox("Favor selecionar uma obra.")
    '    Else
    '        CARREGAR_CONTATO_OBRA(CType(Me.txtID_OBRA.Text, String))
    '    End If

    'End Sub

    Private Sub dgvOBRAS_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If e.RowIndex <> -1 Then
        '    Dim value As Object = dgvOBRAS_CONTATOS.Rows(e.RowIndex).Cells(0).Value
        '    Me.txtID_CONTATO.Text = value
        'End If

    End Sub

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

    Private Function ValidarCampos(ByVal sessao As String) As Boolean

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
            CARREGAR_GRIDE_OBRAS(Me.txtID_CLIENTE.Text)
        End If
    End Sub

    Private Sub LimparIds()

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

    Private Sub SalvarContato()
        Dim myConnection As String = GetConnectionStringByName("servidor")
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
                    CARREGAR_GRIDE_CONTATOS(oEtContato.IdRelacao)
                    MessageBox.Show("salvo")
                Else
                    MessageBox.Show("salvo, erro!")
                End If
            Else
                If oNeContato.Alterar(oEtContato, myConnection) Then
                    CARREGAR_GRIDE_CONTATOS(oEtContato.IdRelacao)
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

        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

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

        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

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

    Private Sub CARREGAR_GRIDE_CONTATOS(ByVal idCliente As String)
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))
        myConnection.Open()
        Dim ds As New DataSet()
        Dim da As New MySqlDataAdapter(New MySqlCommand("Select * from vw_psq_clientes_contatos where ID_CLIENTE ='" + idCliente + "'", myConnection))

        ds.Clear()
        da.Fill(ds, "vw_psq_clientes_contatos")

        With dgvCONTATOS
            .DataSource = ds.Tables("vw_psq_clientes_contatos")
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .AllowUserToAddRows = False
        End With

        myConnection.Close()

    End Sub

    Private Sub CARREGAR_GRIDE_HISTORICOS(ByVal idCliente As String)
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))
        myConnection.Open()
        Dim ds As New DataSet()
        Dim da As New MySqlDataAdapter(New MySqlCommand("Select * from vw_psq_clientes_historicos where ID_CLIENTE ='" + idCliente + "'", myConnection))

        ds.Clear()
        da.Fill(ds, "vw_psq_clientes_historicos")

        With dgvHISTORICOS
            .DataSource = ds.Tables("vw_psq_clientes_historicos")
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
                CARREGAR_CONTATO_CLIENTE(CType(value, String))
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
                CARREGAR_HISTORICO(CType(value, String))
            End If
        End If
    End Sub

End Class
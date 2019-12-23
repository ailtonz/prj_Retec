Imports System
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports HigiaENT
Imports HigiaNEG


Public Class cadastroObra
    Private _cliente As entCliente
    Protected Rotinas As ClasseRotinasDiversas

    'Dim Transacoes() As String = {"BOLETO", "DEBITO", "DEPOSITO", "TRANSFERENCIA"}
    'Dim Condicoes() As String = {"DIARIO", "SEMANAL", "QUINZENAL", "MENSAL"}
    'Dim TiposCadastros() As String = {"FISICO", "JURIDICO"}


    Private Sub F_CAD_OBRA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Rotinas = New ClasseRotinasDiversas

        '' TIPO DE CADASTRO
        CARREGAR_COMBO("Select * from vw_dgv_status_tipo ORDER BY cadastro_tipo", "vw_dgv_status_tipo", Rotinas.GetConnectionStringByName("servidor"), cboCOBRANCA_TIPO, "cadastro_tipo", "cadastro_tipo")

        '' CONDIÇÕES DE PAGAMENTO
        CARREGAR_COMBO("Select * from vw_dgv_mov_condicoes", "vw_dgv_mov_condicoes", Rotinas.GetConnectionStringByName("servidor"), cboCONTRATO_FATURAMENTO_DIAS, "CONDICAO_PAGAMENTO", "CONDICAO")

        '' TRANSAÇÃO FINANCEIRA
        CARREGAR_COMBO("Select * from vw_dgv_mov_transacao", "vw_dgv_mov_transacao", Rotinas.GetConnectionStringByName("servidor"), cboCONTRATO_FORMA_PAGAMENTO, "TRANSACAO", "ID")

        '' TRAVAR FORMULARIO
        formLock()

        '' AO SELECIONAR UM REGISTRO CARREGA OS DADOS E MUDA A FUNÇÃO DO REGISTRO
        If Me.txtID_OBRA.Text <> 0 Then
            CARREGAR_OBRA(Me.txtID_OBRA.Text)
            MUDAR_FUNCAO_OBRA()
        Else

            getCriterios()

        End If

        ' ''VERIFICAR SE O FORMULARIO ESTÁ ABERTO!
        'If Application.OpenForms.OfType(Of F_PSQ_CLIENTES)().Count() > 0 Then
        '    F_PSQ_CLIENTES.Dispose()
        'End If


    End Sub


    Private Sub btnSalvarObra_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvarObra.Click
        '' DESTRAVAR
        formUnLock()

        If Me.btnSalvarObra.Text <> "NOVO" Then

            If ValidarCampos("OBRA") Then
                SalvarObra()
            End If

        Else
            '' MUDAR FUNÇÃO DO BOTÃO
            MUDAR_FUNCAO_OBRA()
        End If

        Me.mskOBRA_CEP.Focus()

    End Sub

    Private Sub SalvarObra()
        Dim myConnection As String = GetConnectionStringByName("servidor")
        Dim oNeObra As New negObra

        Dim oEtObra As New entObra
        Dim oEtObraUsuario As New entUsuario

        Dim oEtObraEndereco As New entEndereco
        Dim oEtObraContato As New entContato
        Dim oEtObraContatoUsuario As New entUsuario

        Dim oEtCobrancaEndereco As New entCobranca
        Dim oEtCobrancaContato As New entContato
        Dim oEtCobrancaContatoUsuario As New entUsuario

        Dim oEtContrato As New entContrato

        Try
            '' DADOS DA OBRA
            With oEtObra
                .IdRelacao = Me.txtID_CLIENTE.Text
                .IdObra = Me.txtID_OBRA.Text

                '' ENDERECO DA OBRA
                With oEtObraEndereco
                    .Cep = Trim(Replace(Me.mskOBRA_CEP.Text, "-", ""))
                    .Numero = Me.txtOBRA_NUMERO.Text
                    .Complemento = Me.txtOBRA_COMPLEMENTO.Text
                    .Endereco = Me.txtOBRA_ENDERECO.Text
                    .Bairro = Me.txtOBRA_BAIRRO.Text
                    .Cidade = Me.txtOBRA_CIDADE.Text
                    .Estado = Me.txtOBRA_ESTADO.Text
                End With
                .ENT_ENDERECO = oEtObraEndereco

                '' CONTATO DA OBRA
                With oEtObraContato
                    .NomeContato = Me.txtOBRA_CONTATO.Text
                    .Telefone = Me.txtOBRA_TELEFONE.Text
                    .Email = Me.txtOBRA_EMAIL.Text

                End With
                .ENT_CONTATO = oEtObraContato

                '' ENDERECO DE COBRANÇA
                With oEtCobrancaEndereco

                    .Sacado = Me.txtCOBRANCA_SACADO.Text

                    If Me.cboCOBRANCA_TIPO.Text = "PF" Then
                        .TipoCobranca = "pf"
                        .Inscricao = Trim(Replace(Replace(Me.mskCOBRANCA_INSCRICAO.Text, ",", ""), "-", ""))
                    ElseIf Me.cboCOBRANCA_TIPO.Text = "PJ" Then
                        .TipoCobranca = "pj"
                        .Inscricao = Trim(Replace(Replace(Me.mskCOBRANCA_INSCRICAO.Text, ",", ""), "-", ""))
                    End If

                    .Cep = Trim(Replace(Me.mskCOBRANCA_CEP.Text, "-", ""))
                    .Logradouro = Me.txtCOBRANCA_LOGRADOURO.Text
                    .Bairro = Me.txtCOBRANCA_BAIRRO.Text
                    .Cidade = Me.txtCOBRANCA_CIDADE.Text
                    .Estado = Me.txtCOBRANCA_ESTADO.Text

                    '' CONTATO DE COBRANÇA
                    With oEtCobrancaContato
                        .NomeContato = Me.txtCOBRANCA_NOME.Text
                        .Telefone = Me.txtCOBRANCA_TELEFONE.Text
                        .Email = Me.txtCOBRANCA_EMAIL.Text

                    End With
                    .ENT_CONTATO = oEtCobrancaContato

                End With
                .ENT_COBRANCA = oEtCobrancaEndereco

                '' CONTRATO DA OBRA
                With oEtContrato
                    .DataInicio = Me.dtpCONTRATO_INICIO.Text
                    .ValorUnitario = Me.txtCONTRATO_VALOR.Text
                    .nfe = IIf(Me.chkCONTRATO_NF.Checked, "1", "0")
                    .iss = IIf(Me.chkCONTRATO_ISS.Checked, "1", "0")
                    .ctr = IIf(Me.chkCONTRATO_CTR.Checked, "1", "0")
                    .FormaDePagamento = Me.cboCONTRATO_FORMA_PAGAMENTO.Text
                    .FaturamentoDias = Me.cboCONTRATO_FATURAMENTO_DIAS.SelectedValue
                    .PeriodoLocacao = Me.txtCONTRATO_PERIODO_LOCACAO.Text
                    .RetiradaAutomatica = Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text
                    .VencimentoAposEntrega = Me.txtCONTRATO_VCTO_APOS_ENTREGA.Text
                    .MultaMora = Me.txtCONTRATO_MULTA_MORA.Text
                    .MultaDia = Me.txtCONTRATO_MULTA_DIA.Text
                End With
                .ENT_CONTRATO = oEtContrato

                ''USUARIO
                With oEtObraUsuario
                    .Nome = cadastroCliente.txtUser.Text
                End With
                .ENT_USUARIO = oEtObraUsuario

                '' OBSERVAÇÕES
                .ObsObra = String.Empty
                .ObsLigacao = Me.txtCONTRATO_OBS_LIGACAO.Text
                .ObsColoca = Me.txtCONTRATO_OBS_COLOCA.Text
                .ObsTroca = Me.txtCONTRATO_OBS_TROCA.Text
                .ObsRetira = Me.txtCONTRATO_OBS_RETIRA.Text

            End With

            '' OPERAÇÃO
            If oEtObra.IdObra.ToString = 0 Then
                If oNeObra.Incluir(oEtObra, myConnection) Then
                    getID_Obra(oEtObra.ENT_ENDERECO.Cep, oEtObra.IdRelacao)
                    MessageBox.Show("salvo")
                Else
                    MessageBox.Show("salvo, erro!")
                End If
            Else
                If oNeObra.Alterar(oEtObra, myConnection) Then
                    If Not Me.chkRelacao.Checked Then
                        oNeObra.relacionarObraCobranca(oEtObra.IdObra, oEtObra.ENT_COBRANCA.Inscricao, myConnection)
                        CARREGAR_OBRA(Me.txtID_OBRA.Text)
                    End If


                    MessageBox.Show("alterado")
                Else
                    MessageBox.Show("alterado, erro!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub SalvarContato()
    '    Dim myConnection As String = GetConnectionStringByName("servidor")
    '    Dim oNeContatoObra As New negContatoObra
    '    Dim oEtContato As New entContato
    '    Dim oEtUsuario As New entUsuario

    '    Try
    '        '' CONTATO
    '        With oEtContato
    '            .IdContato = Me.txtID_CONTATO.Text
    '            .IdRelacao = Me.txtID_OBRA.Text
    '            .NomeContato = Me.txtCONTATO_OBRA_NOME.Text
    '            .Telefone = Me.txtCONTATO_OBRA_TELEFONE.Text
    '            .Email = Me.txtCONTATO_OBRA_EMAIL.Text
    '            .Observacao = Me.txtCONTATO_OBRA_OBSERVACAO.Text()
    '            .Solicitante = IIf(Me.chkCONTATO_OBRA_SOLICITANTE.Checked, "1", "0")

    '            ''USUARIO
    '            With oEtUsuario
    '                .Nome = cadastroCliente.txtUser.Text
    '            End With
    '            .ENT_USUARIO = oEtUsuario

    '        End With

    '        '' OPERAÇÃO
    '        If oEtContato.IdContato.ToString = 0 Then
    '            If oNeContatoObra.Incluir(oEtContato, myConnection) Then
    '                getID_Contato(oEtContato.IdRelacao)
    '                CARREGAR_GRIDE_OBRAS_CONTATOS(Me.txtID_OBRA.Text)
    '                MessageBox.Show("salvo")
    '            Else
    '                MessageBox.Show("salvo, erro!")
    '            End If
    '        Else
    '            If oNeContatoObra.Alterar(oEtContato, myConnection) Then
    '                'getID_Contato(oEtContato.IdRelacao)
    '                CARREGAR_GRIDE_OBRAS_CONTATOS(Me.txtID_OBRA.Text)
    '                MessageBox.Show("alterado")
    '            Else
    '                MessageBox.Show("alterado, erro!")
    '            End If
    '        End If

    '        LIMPAR_CONTATO_OBRA()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Function faturamento(ByVal tipo As String) As Integer

        Select Case tipo

            Case "DIARIO"
                Return 1
            Case "SEMANAL"
                Return 7
            Case "QUINZENAL"
                Return 15
            Case "MENSAL"
                Return 30
            Case Else
                Return 0

        End Select

    End Function

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


    'Private Sub CARREGAR_COMBOS()
    '    Dim Transacao As String
    '    Dim TipoCadastro As String

    '    '' TIPO DE COBRANÇA
    '    With Me.cboCOBRANCA_TIPO
    '        .Items.Clear()
    '        For Each TipoCadastro In TiposCadastros
    '            .Items.Add(TipoCadastro)
    '        Next
    '        .SelectedIndex = CInt(.FindString("FISICO"))
    '    End With

    '    '' FORMAS DE PAGAMENTO
    '    With Me.cboCONTRATO_FORMA_PAGAMENTO
    '        .Items.Clear()
    '        For Each Transacao In Transacoes
    '            .Items.Add(Transacao)
    '        Next
    '        .SelectedIndex = CInt(.FindString("BOLETO"))
    '    End With

    '    '' FORMA DE FATURAMENTO
    '    With Me.cboCONTRATO_FATURAMENTO_DIAS
    '        .Items.Clear()

    '        .Items.Add(New Mylist("DIARIO", 1))
    '        .Items.Add(New Mylist("SEMANAL", 7))
    '        .Items.Add(New Mylist("QUINZENAL", 15))
    '        .Items.Add(New Mylist("MENSAL", 30))

    '        'For Each Condicao In Condicoes
    '        '    .Items.Add(Condicao)
    '        'Next
    '        .SelectedIndex = CInt(.FindString("DIARIO"))
    '    End With
    'End Sub

    'Private Sub btnSalvarContatoObra_Click(sender As System.Object, e As System.EventArgs)

    '    If ValidarCampos("CONTATO") Then
    '        SalvarContato()
    '    End If


    'End Sub

    'Private Sub CARREGAR_GRIDE_OBRAS_CONTATOS(ByVal idObra As String)
    '    Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))
    '    myConnection.Open()
    '    Dim ds As New DataSet()
    '    Dim da As New MySqlDataAdapter(New MySqlCommand("Select * from vw_dgv_clientes_obras_contatos where ID_RELACAO ='" + idObra + "'", myConnection))

    '    ds.Clear()
    '    da.Fill(ds, "vw_dgv_clientes_obras_contatos")

    '    'If dgvOBRAS_CONTATOS.RowCount > 0 Then

    '    With dgvOBRAS_CONTATOS
    '        .DataSource = ds.Tables("vw_dgv_clientes_obras_contatos")
    '        .Columns(0).Visible = False
    '        .Columns(1).Visible = False
    '        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '        .ReadOnly = True
    '        .AllowUserToAddRows = False
    '    End With

    '    'End If

    '    myConnection.Close()

    'End Sub

    'Private Function getID_Obra(ByVal idCliente As String) As String

    '    Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

    '    myConnection.Open()

    '    Dim cmdSQL As New MySqlCommand("SELECT id FROM vw_cad_clientes_obras WHERE id_cliente = '" + idCliente + "' LIMIT 1", myConnection)
    '    Dim rdrRegistro As MySqlDataReader

    '    rdrRegistro = cmdSQL.ExecuteReader()

    '    While rdrRegistro.Read
    '        Return rdrRegistro("id").ToString()
    '    End While

    '    rdrRegistro.Close()
    '    cmdSQL.Dispose()

    'End Function

    Private Sub getID_Obra(ByVal cepObra As String, ByVal idCliente As String)

        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("SELECT * FROM vw_dgv_clientes_obras WHERE CEP = '" + cepObra + "' AND ID_CLIENTE = '" + idCliente + "'  LIMIT 1", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()
        With Me
            While rdrRegistro.Read
                .txtID_OBRA.Text = rdrRegistro("ID").ToString()

                .stsREGISTRO_INSERT_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString
                .stsREGISTRO_INSERT_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString
                .stsREGISTRO_UPDATE_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString
                .stsREGISTRO_UPDATE_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString


                '.txtOBRA_CAD_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString()
                '.txtOBRA_CAD_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString()
                '.txtOBRA_ALT_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString()
                '.txtOBRA_ALT_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString()
            End While
        End With

        rdrRegistro.Close()
        cmdSQL.Dispose()

    End Sub

    'Private Sub getID_Contato(ByVal idObra As String)

    '    Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

    '    myConnection.Open()

    '    Dim cmdSQL As New MySqlCommand("SELECT * FROM vw_dgv_clientes_obras_contatos WHERE id_relacao = '" + idObra + "' LIMIT 1", myConnection)
    '    Dim rdrRegistro As MySqlDataReader

    '    rdrRegistro = cmdSQL.ExecuteReader()
    '    With Me
    '        While rdrRegistro.Read
    '            .txtID_CONTATO.Text = rdrRegistro("ID").ToString()
    '            .txtOBRA_CAD_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString()
    '            .txtOBRA_CAD_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString()
    '            .txtOBRA_ALT_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString()
    '            .txtOBRA_ALT_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString()
    '        End While
    '    End With

    '    rdrRegistro.Close()
    '    cmdSQL.Dispose()

    'End Sub

    Private Sub getCriterios()
        '' CRITERIOS PARA FATURAMENTO DA EMPRESA

        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("select * from vw_adm_transportador limit 1", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()
        With Me
            While rdrRegistro.Read

                .cboCONTRATO_FORMA_PAGAMENTO.SelectedIndex = CInt(.cboCONTRATO_FORMA_PAGAMENTO.FindString(rdrRegistro("CONTRATO_FORMA_PAGAMENTO").ToString))
                .cboCONTRATO_FATURAMENTO_DIAS.SelectedValue = CInt(.cboCONTRATO_FATURAMENTO_DIAS.FindString(rdrRegistro("CONTRATO_FATURAMENTO_DIAS").ToString))

                .txtCONTRATO_PERIODO_LOCACAO.Text = rdrRegistro("CONTRATO_PERIODO_LOCACAO").ToString
                .txtCONTRATO_RETIRADA_AUTOMATICA.Text = rdrRegistro("CONTRATO_RETIRADA_AUTOMATICA").ToString
                .txtCONTRATO_VCTO_APOS_ENTREGA.Text = rdrRegistro("CONTRATO_VCTO_APOS_ENTREGA").ToString
                .txtCONTRATO_MULTA_MORA.Text = rdrRegistro("CONTRATO_MULTA_MORA").ToString
                .txtCONTRATO_MULTA_DIA.Text = rdrRegistro("CONTRATO_MULTA_DIA").ToString


            End While
        End With

        rdrRegistro.Close()
        cmdSQL.Dispose()

    End Sub

    Private Sub F_CAD_OBRA_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Function ValidarCampos(ByVal sessao As String) As Boolean

        Dim blnRet As Boolean = False  'inicializar o valor como false

        With Me

            Select Case sessao

                Case "OBRA"

                    If Trim(Replace(.mskOBRA_CEP.Text, "-", "")) = "" Then

                        ErrorProvider1.SetError(.mskOBRA_CEP, "CEP. Campo de preenchimento obrigatório")

                    ElseIf Trim(.txtOBRA_NUMERO.Text) = "" Then

                        ErrorProvider1.SetError(.txtOBRA_NUMERO, "NUMERO. Campo de preenchimento obrigatório")

                    ElseIf Trim(.txtOBRA_CONTATO.Text) = "" Then

                        ErrorProvider1.SetError(.txtOBRA_CONTATO, "CONTATO. Campo de preenchimento obrigatório")

                    ElseIf Trim(.txtOBRA_TELEFONE.Text) = "" Then

                        ErrorProvider1.SetError(.txtOBRA_TELEFONE, "TELEFONE. Campo de preenchimento obrigatório")

                    Else ''ocorreu um erro ao validar os dados do form

                        blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)

                    End If

                    'Case "CONTATO"

                    '    If Trim(.txtCONTATO_OBRA_NOME.Text) = "" Then

                    '        ErrorProvider1.SetError(.txtCONTATO_OBRA_NOME, "NOME DO CONTATO. Campo de preenchimento obrigatório")


                    '    Else ''ocorreu um erro ao validar os dados do form

                    '        blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)

                    '    End If

            End Select



        End With


        Return blnRet

    End Function

    Private Sub MUDAR_FUNCAO_OBRA()
        If Me.txtID_OBRA.Text = 0 Then
            Me.btnSalvarObra.Text = "SALVAR"
        Else
            Me.btnSalvarObra.Text = "ALTERAR"
        End If
    End Sub


    Private Sub formLock()
        Dim Ctrl As Control

        For Each Ctrl In Me.Controls
            If TypeOf Ctrl Is Button Then
                If Ctrl.Name = "btnSalvarObra" Then
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

    Private Sub CARREGAR_OBRA(ByVal idObra As String)
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_dgv_clientes_obras where ID = '" + idObra + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                If rdrRegistro("COBRANCA_TIPO").ToString = "PF" Then
                    Me.mskCOBRANCA_INSCRICAO.UseSystemPasswordChar = False

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("PF"))
                ElseIf rdrRegistro("COBRANCA_TIPO").ToString = "PJ" Then
                    Me.mskCOBRANCA_INSCRICAO.UseSystemPasswordChar = False

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("PF"))
                End If

                .mskCOBRANCA_INSCRICAO.Text = rdrRegistro("COBRANCA_INSCRICAO").ToString

                .txtID_OBRA.Text = rdrRegistro("ID").ToString
                .mskOBRA_CEP.Text = rdrRegistro("CEP").ToString
                .txtOBRA_NUMERO.Text = rdrRegistro("NUMERO").ToString
                .txtOBRA_COMPLEMENTO.Text = rdrRegistro("COMPLEMENTO").ToString
                .txtOBRA_ENDERECO.Text = rdrRegistro("ENDERECO").ToString
                .txtOBRA_BAIRRO.Text = rdrRegistro("BAIRRO").ToString
                .txtOBRA_CIDADE.Text = rdrRegistro("CIDADE").ToString
                .txtOBRA_ESTADO.Text = rdrRegistro("ESTADO").ToString

                .txtOBRA_CONTATO.Text = rdrRegistro("CONTATO").ToString
                .txtOBRA_TELEFONE.Text = rdrRegistro("TELEFONE").ToString
                .txtOBRA_EMAIL.Text = rdrRegistro("EMAIL").ToString

                .txtCOBRANCA_SACADO.Text = rdrRegistro("COBRANCA_SACADO").ToString

                .mskCOBRANCA_CEP.Text = rdrRegistro("COBRANCA_CEP").ToString
                .txtCOBRANCA_LOGRADOURO.Text = rdrRegistro("COBRANCA_LOGRADOURO").ToString
                .txtCOBRANCA_BAIRRO.Text = rdrRegistro("COBRANCA_BAIRRO").ToString
                .txtCOBRANCA_CIDADE.Text = rdrRegistro("COBRANCA_CIDADE").ToString
                .txtCOBRANCA_ESTADO.Text = rdrRegistro("COBRANCA_ESTADO").ToString

                .txtCOBRANCA_NOME.Text = rdrRegistro("COBRANCA_CONTATO").ToString
                .txtCOBRANCA_TELEFONE.Text = rdrRegistro("COBRANCA_TELEFONE").ToString
                .txtCOBRANCA_EMAIL.Text = rdrRegistro("COBRANCA_EMAIL").ToString

                .txtCONTRATO_OBS_LIGACAO.Text = rdrRegistro("CONTRATO_OBS_LIGACAO").ToString
                .txtCONTRATO_OBS_COLOCA.Text = rdrRegistro("CONTRATO_OBS_COLOCA").ToString
                .txtCONTRATO_OBS_TROCA.Text = rdrRegistro("CONTRATO_OBS_TROCA").ToString
                .txtCONTRATO_OBS_RETIRA.Text = rdrRegistro("CONTRATO_OBS_RETIRA").ToString
                .txtCADASTRO_OBSERVACAO.Text = rdrRegistro("CADASTRO_OBSERVACAO").ToString

                .cboCONTRATO_FORMA_PAGAMENTO.SelectedIndex = CInt(.cboCONTRATO_FORMA_PAGAMENTO.FindString(rdrRegistro("CONTRATO_FORMA_PAGAMENTO").ToString))
                '.cboCONTRATO_FATURAMENTO_DIAS.SelectedIndex = CInt(.cboCONTRATO_FATURAMENTO_DIAS.FindString(rdrRegistro("CONTRATO_FATURAMENTO_DIAS").ToString))

                .cboCONTRATO_FATURAMENTO_DIAS.SelectedValue = rdrRegistro("CONTRATO_FATURAMENTO_DIAS").ToString

                .txtCONTRATO_VALOR.Text = rdrRegistro("CONTRATO_VALOR").ToString
                .txtCONTRATO_PERIODO_LOCACAO.Text = rdrRegistro("CONTRATO_PERIODO_LOCACAO").ToString
                .txtCONTRATO_RETIRADA_AUTOMATICA.Text = rdrRegistro("CONTRATO_RETIRADA_AUTOMATICA").ToString
                .txtCONTRATO_VCTO_APOS_ENTREGA.Text = rdrRegistro("CONTRATO_VCTO_APOS_ENTREGA").ToString
                .txtCONTRATO_MULTA_MORA.Text = rdrRegistro("CONTRATO_MULTA_MORA").ToString
                .txtCONTRATO_MULTA_DIA.Text = rdrRegistro("CONTRATO_MULTA_DIA").ToString
                .dtpCONTRATO_INICIO.Text = rdrRegistro("CONTRATO_INICIO").ToString

                .chkCONTRATO_NF.Checked = IIf(rdrRegistro("CONTRATO_NF").ToString, "1", "0")
                .chkCONTRATO_ISS.Checked = IIf(rdrRegistro("CONTRATO_ISS").ToString, "1", "0")
                .chkCONTRATO_CTR.Checked = IIf(rdrRegistro("CONTRATO_CTR").ToString, "1", "0")


                .stsREGISTRO_INSERT_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString
                .stsREGISTRO_INSERT_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString
                .stsREGISTRO_UPDATE_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString
                .stsREGISTRO_UPDATE_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString


                '.txtOBRA_CAD_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString
                '.txtOBRA_CAD_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString

                '.txtOBRA_ALT_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString
                '.txtOBRA_ALT_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString

                .chkRelacao.Checked = IIf(rdrRegistro("REGISTRO_RELACIONAMENTO").ToString, "1", "0")


            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub btnEnderecoObra_Click(sender As System.Object, e As System.EventArgs) Handles btnEnderecoObra.Click
        CARREGAR_ENDERECO_OBRA(Trim(Replace(Me.mskOBRA_CEP.Text, "-", "")))
    End Sub

    Private Sub CARREGAR_ENDERECO_OBRA(ByVal idCep As String)
        Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("select * from vw_dgv_cad_cep where cep = '" + idCep + "'limit 1", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                .txtOBRA_ENDERECO.Text = Rotinas.RemoveAcentos(rdrRegistro("ENDERECO").ToString)
                .txtOBRA_BAIRRO.Text = Rotinas.RemoveAcentos(rdrRegistro("BAIRRO").ToString)
                .txtOBRA_CIDADE.Text = Rotinas.RemoveAcentos(rdrRegistro("CIDADE").ToString)
                .txtOBRA_ESTADO.Text = Rotinas.RemoveAcentos(rdrRegistro("ESTADO").ToString)

            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub txtOBRA_ENDERECO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtOBRA_ENDERECO.Validating
        Me.txtOBRA_ENDERECO.Text = Rotinas.RemoveAcentos(Me.txtOBRA_ENDERECO.Text)
    End Sub

    Private Sub txtOBRA_COMPLEMENTO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtOBRA_COMPLEMENTO.Validating
        Me.txtOBRA_COMPLEMENTO.Text = Rotinas.RemoveAcentos(Me.txtOBRA_COMPLEMENTO.Text)
    End Sub

    Private Sub txtOBRA_BAIRRO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtOBRA_BAIRRO.Validating
        Me.txtOBRA_BAIRRO.Text = Rotinas.RemoveAcentos(Me.txtOBRA_BAIRRO.Text)
    End Sub

    Private Sub txtOBRA_CIDADE_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtOBRA_CIDADE.Validating
        Me.txtOBRA_CIDADE.Text = Rotinas.RemoveAcentos(Me.txtOBRA_CIDADE.Text)
    End Sub

    Private Sub txtOBRA_CONTATO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtOBRA_CONTATO.Validating
        Me.txtOBRA_CONTATO.Text = Rotinas.RemoveAcentos(Me.txtOBRA_CONTATO.Text)
    End Sub

    Private Sub txtCOBRANCA_SACADO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCOBRANCA_SACADO.Validating
        Me.txtCOBRANCA_SACADO.Text = Rotinas.RemoveAcentos(Me.txtCOBRANCA_SACADO.Text)
    End Sub

    Private Sub txtCOBRANCA_LOGRADOURO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCOBRANCA_LOGRADOURO.Validating
        Me.txtCOBRANCA_LOGRADOURO.Text = Rotinas.RemoveAcentos(Me.txtCOBRANCA_LOGRADOURO.Text)
    End Sub

    Private Sub txtCOBRANCA_BAIRRO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCOBRANCA_BAIRRO.Validating
        Me.txtCOBRANCA_BAIRRO.Text = Rotinas.RemoveAcentos(Me.txtCOBRANCA_BAIRRO.Text)
    End Sub

    Private Sub txtCOBRANCA_CIDADE_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCOBRANCA_CIDADE.Validating
        Me.txtCOBRANCA_CIDADE.Text = Rotinas.RemoveAcentos(Me.txtCOBRANCA_CIDADE.Text)
    End Sub

    Private Sub txtCOBRANCA_ESTADO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCOBRANCA_ESTADO.Validating
        Me.txtCOBRANCA_ESTADO.Text = Rotinas.RemoveAcentos(Me.txtCOBRANCA_ESTADO.Text)
    End Sub

    Private Sub txtCOBRANCA_NOME_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCOBRANCA_NOME.Validating
        Me.txtCOBRANCA_NOME.Text = Rotinas.RemoveAcentos(Me.txtCOBRANCA_NOME.Text)
    End Sub

    Private Sub txtCONTRATO_OBS_LIGACAO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCONTRATO_OBS_LIGACAO.Validating
        Me.txtCONTRATO_OBS_LIGACAO.Text = Rotinas.RemoveAcentos(Me.txtCONTRATO_OBS_LIGACAO.Text)
    End Sub

    Private Sub txtCONTRATO_OBS_COLOCA_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCONTRATO_OBS_COLOCA.Validating
        Me.txtCONTRATO_OBS_COLOCA.Text = Rotinas.RemoveAcentos(Me.txtCONTRATO_OBS_COLOCA.Text)
    End Sub

    Private Sub txtCONTRATO_OBS_TROCA_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCONTRATO_OBS_TROCA.Validating
        Me.txtCONTRATO_OBS_TROCA.Text = Rotinas.RemoveAcentos(Me.txtCONTRATO_OBS_TROCA.Text)
    End Sub

    Private Sub txtCONTRATO_OBS_RETIRA_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCONTRATO_OBS_RETIRA.Validating
        Me.txtCONTRATO_OBS_RETIRA.Text = Rotinas.RemoveAcentos(Me.txtCONTRATO_OBS_RETIRA.Text)
    End Sub


    'Private Sub tabObras_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tabObras.SelectedIndexChanged
    '    If tabObras.SelectedIndex <> -1 Then

    '        Select Case tabObras.SelectedIndex

    '            Case 1

    '                CARREGAR_GRIDE_OBRAS_CONTATOS(Me.txtID_OBRA.Text)
    '            Case 2
    '                Me.txtPesquisarContato.Text = String.Empty
    '                CARREGAR_GRIDE_CONTATOS(Me.txtID_OBRA.Text, "")

    '        End Select

    '    End If

    'End Sub


    'Private Sub cmdNovoObraContato_Click(sender As System.Object, e As System.EventArgs)
    '    LIMPAR_CONTATO_OBRA()
    'End Sub

    'Private Sub LIMPAR_CONTATO_OBRA()

    '    With Me

    '        .txtID_CONTATO.Text = "0"
    '        .txtCONTATO_OBRA_NOME.Text = String.Empty
    '        .txtCONTATO_OBRA_EMAIL.Text = String.Empty
    '        .txtCONTATO_OBRA_TELEFONE.Text = String.Empty
    '        .txtCONTATO_OBRA_OBSERVACAO.Text = String.Empty

    '        .chkCONTATO_OBRA_SOLICITANTE.Checked = False

    '        .txtCONTATO_OBRA_CAD_USUARIO.Text = cadastroCliente.txtUser.Text
    '        .txtCONTATO_OBRA_CAD_EMISSAO.Text = "00/00/0000"

    '        .txtCONTATO_OBRA_ALT_USUARIO.Text = cadastroCliente.txtUser.Text
    '        .txtCONTATO_OBRA_ALT_EMISSAO.Text = "00/00/0000"

    '        .txtCONTATO_OBRA_NOME.Focus()

    '    End With

    'End Sub

    'Private Sub dgvOBRAS_CONTATOS_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
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

    'Private Sub CARREGAR_CONTATO_OBRA(ByVal idContatoObra As String)
    '    Dim myConnection As New MySqlConnection(GetConnectionStringByName("servidor"))

    '    myConnection.Open()

    '    Dim cmdSQL As New MySqlCommand("Select * from vw_dgv_clientes_obras_contatos where ID = '" + idContatoObra + "' ", myConnection)
    '    Dim rdrRegistro As MySqlDataReader

    '    rdrRegistro = cmdSQL.ExecuteReader()

    '    With Me

    '        While rdrRegistro.Read

    '            .txtCONTATO_OBRA_NOME.Text = rdrRegistro("CONTATO").ToString
    '            .txtCONTATO_OBRA_EMAIL.Text = rdrRegistro("EMAIL").ToString
    '            .txtCONTATO_OBRA_TELEFONE.Text = rdrRegistro("TELEFONE").ToString
    '            .txtCONTATO_OBRA_OBSERVACAO.Text = rdrRegistro("OBSERVACAO").ToString

    '            .chkCONTATO_OBRA_SOLICITANTE.Checked = IIf(rdrRegistro("SOLICITANTE").ToString, "1", "0")

    '            .txtCONTATO_OBRA_CAD_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString
    '            .txtCONTATO_OBRA_CAD_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString

    '            .txtCONTATO_OBRA_ALT_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString
    '            .txtCONTATO_OBRA_ALT_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString

    '        End While

    '        rdrRegistro.Close()
    '        cmdSQL.Dispose()
    '    End With

    'End Sub

    '   Private Sub txtCONTATO_OBRA_EMAIL_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
    '       Dim strRegex As String = _
    '"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"

    '       Dim re As New Regex(strRegex)

    '       If (re.IsMatch(Me.txtCONTATO_OBRA_EMAIL.Text)) Then
    '           Rotinas.CorSaida(sender)
    '           'Me.txtPRINCIPAL_EMAIL.BackColor = Color.WhiteSmoke
    '       Else
    '           Rotinas.CorEntrada(sender)
    '           'Me.txtPRINCIPAL_EMAIL.BackColor = Color.Yellow
    '           e.Cancel = True
    '       End If
    '   End Sub

    Private Sub txtCOBRANCA_EMAIL_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtCOBRANCA_EMAIL.Validating
        Dim strRegex As String = _
"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"

        Dim re As New Regex(strRegex)

        If (re.IsMatch(Me.txtCOBRANCA_EMAIL.Text)) Then
            Rotinas.CorSaida(sender)
            'Me.txtPRINCIPAL_EMAIL.BackColor = Color.WhiteSmoke
        Else
            Rotinas.CorEntrada(sender)
            'Me.txtPRINCIPAL_EMAIL.BackColor = Color.Yellow
            e.Cancel = True
        End If
    End Sub

    Private Sub txtOBRA_EMAIL_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtOBRA_EMAIL.Validating
        Dim strRegex As String = _
"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"

        Dim re As New Regex(strRegex)

        If (re.IsMatch(Me.txtOBRA_EMAIL.Text)) Then
            Rotinas.CorSaida(sender)
            'Me.txtPRINCIPAL_EMAIL.BackColor = Color.WhiteSmoke
        Else
            Rotinas.CorEntrada(sender)
            'Me.txtPRINCIPAL_EMAIL.BackColor = Color.Yellow
            e.Cancel = True
        End If
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

    'Private Sub txtCONTATO_OBRA_NOME_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
    '    Me.txtCONTATO_OBRA_NOME.Text = Rotinas.RemoveAcentos(Me.txtCONTATO_OBRA_NOME.Text)
    'End Sub

    'Private Sub txtCONTATO_OBRA_OBSERVACAO_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs)
    '    Me.txtCONTATO_OBRA_OBSERVACAO.Text = Rotinas.RemoveAcentos(Me.txtCONTATO_OBRA_OBSERVACAO.Text)
    'End Sub

    'Private Sub cmdPesquisarContatos_Click(sender As System.Object, e As System.EventArgs)
    '    CARREGAR_GRIDE_CONTATOS(Me.txtID_OBRA.Text, Me.txtPesquisarContato.Text)
    'End Sub

    'Private Sub CARREGAR_GRIDE_CONTATOS(ByVal idObra As String, ByVal strProcurar As String)
    '    Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
    '    myConnection.Open()
    '    Dim ds As New DataSet()
    '    Dim strSQL As String

    '    If strProcurar = "" Then
    '        strSQL = "Select * from vw_dgv_clientes_obras_contatos where ID_RELACAO ='" + idObra + "'"
    '    Else
    '        strSQL = "Select * from vw_dgv_clientes_obras_contatos where ID_RELACAO ='" + idObra + "' AND CONTATO LIKE '%" & Trim(strProcurar) & "%'"
    '    End If

    '    Dim da As New MySqlDataAdapter(New MySqlCommand(strSQL, myConnection))

    '    ds.Clear()
    '    da.Fill(ds, "vw_dgv_clientes_obras_contatos")

    '    If dgvOBRAS_CONTATOS.RowCount > 0 Then

    '        With dgvOBRAS_CONTATOS
    '            .DataSource = ds.Tables("vw_dgv_clientes_obras_contatos")
    '            .Columns(0).Visible = False
    '            .Columns(1).Visible = False
    '            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '            .ReadOnly = True
    '            .AllowUserToAddRows = False
    '        End With

    '    End If

    '    myConnection.Close()

    'End Sub
End Class

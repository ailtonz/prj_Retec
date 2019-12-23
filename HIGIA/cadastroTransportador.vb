Imports System
Imports System.Configuration


Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Imports HigiaENT
Imports HigiaNEG

Public Class cadastroTransportador

    Private _Transportador As entTransportador

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub cadastroTransportador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas

        '' CONTROLE DE ACESSO
        Me.txtUser.Text = Rotinas.GetConnectionStringByName("user").ToString

        '' TIPO DE CADASTRO
        CARREGAR_COMBO("Select * from vw_dgv_status_tipo ORDER BY cadastro_tipo", "vw_dgv_status_tipo", Rotinas.GetConnectionStringByName("servidor"), cboCADASTRO_TIPO, "cadastro_tipo", "ID")

        '' TRANSAÇÃO FINANCEIRA
        CARREGAR_COMBO("Select * from vw_dgv_mov_transacao", "vw_dgv_mov_transacao", Rotinas.GetConnectionStringByName("servidor"), cboCONTRATO_FORMA_PAGAMENTO, "TRANSACAO", "ID")

        '' CONDIÇÕES DE PAGAMENTO
        CARREGAR_COMBO("Select * from vw_dgv_mov_condicoes", "vw_dgv_mov_condicoes", Rotinas.GetConnectionStringByName("servidor"), cboCONTRATO_FATURAMENTO_DIAS, "CONDICAO_PAGAMENTO", "CONDICAO")

        '' PRECIFICAÇÃO
        CARREGAR_COMBO("Select * from vw_dgv_status_precificacao", "vw_dgv_status_precificacao", Rotinas.GetConnectionStringByName("servidor"), cboPRECO_TIPO, "DESCRICAO", "CONTRATO_PRECO")


        '' CONTROLE DE FORMULARIO
        If Me.txtID.Text = 0 Then
            '' MUDAR OPERAÇÃO
            Me.btnSalvar.Text = "NOVO"
        Else

            '' MUDAR OPERAÇÃO
            Me.btnSalvar.Text = "ALTERAR"

            '' CARREGAR REGISTRO
            CARREGAR_REGISTRO(Me.txtID.Text)

        End If


    End Sub


    Private Sub CARREGAR_REGISTRO(ByVal idRegistro As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_adm_transportador where ID = '" + idRegistro + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                .txtID.Text = rdrRegistro("ID").ToString
                .txtNome.Text = rdrRegistro("NOME").ToString
                .txtTelefone.Text = rdrRegistro("TELEFONE").ToString

                .cboCADASTRO_TIPO.SelectedIndex = CInt(.cboCADASTRO_TIPO.FindString(rdrRegistro("CADASTRO_TIPO").ToString))

                .mskCNPJ_CPF.Text = rdrRegistro("CPF_CCM").ToString
                .txtLIMPURB.Text = rdrRegistro("LIMPURB").ToString

                .mskCEP.Text = rdrRegistro("CEP").ToString
                .txtENDERECO.Text = rdrRegistro("ENDERECO").ToString
                .txtNUMERO.Text = rdrRegistro("NUMERO").ToString
                .txtCOMPLEMENTO.Text = rdrRegistro("COMPLEMENTO").ToString
                .txtBAIRRO.Text = rdrRegistro("BAIRRO").ToString
                .txtCIDADE.Text = rdrRegistro("CIDADE").ToString
                .txtESTADO.Text = rdrRegistro("ESTADO").ToString

                .cboCONTRATO_FORMA_PAGAMENTO.SelectedIndex = CInt(.cboCONTRATO_FORMA_PAGAMENTO.FindString(rdrRegistro("CONTRATO_FORMA_PAGAMENTO").ToString))
                .cboCONTRATO_FATURAMENTO_DIAS.SelectedValue = rdrRegistro("CONTRATO_FATURAMENTO_DIAS").ToString

                .txtCONTRATO_PERIODO_LOCACAO.Text = rdrRegistro("CONTRATO_PERIODO_LOCACAO").ToString
                .txtCONTRATO_RETIRADA_AUTOMATICA.Text = rdrRegistro("CONTRATO_RETIRADA_AUTOMATICA").ToString
                .txtCONTRATO_VCTO_APOS_ENTREGA.Text = rdrRegistro("CONTRATO_VCTO_APOS_ENTREGA").ToString

                .txtCONTRATO_MULTA_MORA.Text = rdrRegistro("CONTRATO_MULTA_MORA").ToString
                .txtCONTRATO_MULTA_DIA.Text = rdrRegistro("CONTRATO_MULTA_DIA").ToString

                .chkColoca.Checked = IIf(rdrRegistro("FATURAMENTO_COLOCA").ToString, "1", "0")
                .chkTroca.Checked = IIf(rdrRegistro("FATURAMENTO_TROCA").ToString, "1", "0")
                .chkRetira.Checked = IIf(rdrRegistro("FATURAMENTO_RETIRA").ToString, "1", "0")

                .cboPRECO_TIPO.SelectedValue = rdrRegistro("PRECO_TIPO").ToString
                .txtPRECO_VALOR.Text = rdrRegistro("PRECO_VALOR").ToString

                .stsREGISTRO_INSERT_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString
                .stsREGISTRO_INSERT_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString
                .stsREGISTRO_UPDATE_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString
                .stsREGISTRO_UPDATE_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString


            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub



    'Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
    '    'Dim myConnection As String = GetConnectionStringByName("servidor")

    '    Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

    '    Dim oNeTransportador As New negTransportador
    '    Dim oEtTransportador As New entTransportador


    '    Me.txtNome.Text = "ailton zacarias"
    '    Me.txtCNPJ_CPF.Text = "24797483830"
    '    Me.txtTelefone.Text = "11 2373-7635"
    '    Me.txtLIMPURB.Text = "263787667"

    '    Try

    '        With oEtTransportador
    '            .Nome = txtNome.Text
    '            '.ENT_ENDERECO.Endereco = txtEndereco.Text
    '            '.ENT_ENDERECO.Bairro = txtBairro.Text
    '            '.ENT_ENDERECO.Cidade = txtCidade.Text
    '            .ENT_DOCUMENTO.CNPJ_CPF = txtCNPJ_CPF.Text
    '            .ENT_DOCUMENTO.IE_RG = txtLIMPURB.Text
    '            .ENT_CONTATO.Telefone = txtTelefone.Text


    '            '.ENT_CONTRATO.PeriodoLocacao = txtCONTRATO_PERIDO_LOCACAO.Text
    '            '.ENT_CONTRATO.RetiradaAutomatica = txtCONTRATO_RETIRADA_AUTOMATICA.Text
    '            '.ENT_CONTRATO.VencimentoAposEntrega = txtCONTRATO_VCTO_APOS_ENTREGA.Text
    '            '.ENT_CONTRATO.MultaMora = txtCONTRATO_MULTA_MORA.Text
    '            '.ENT_CONTRATO.MultaDia = txtCONTRATO_MULTA_DIA.Text

    '            ' '' ENDERECO
    '            'With oEtEndereco
    '            '    .Endereco = Me.txtPRINCIPAL_ENDERECO.Text
    '            '    .Numero = Me.txtPRINCIPAL_NUMERO.Text
    '            '    .Complemento = Me.txtPRINCIPAL_COMPLEMENTO.Text
    '            '    .Bairro = Me.txtPRINCIPAL_BAIRRO.Text
    '            '    .Cep = Replace(Me.mskPRINCIPAL_CEP.Text, "-", "")
    '            '    .Cidade = Me.txtPRINCIPAL_CIDADE.Text
    '            '    .Estado = Me.txtPRINCIPAL_ESTADO.Text
    '            'End With

    '            '.ENT_ENDERECO = oEtEndereco

    '            ' '' CONTATO
    '            'With oEtContato

    '            '    .Contato = Me.txtPRINCIPAL_CONTATO.Text
    '            '    .Telefone = Me.txtPRINCIPAL_TELEFONE.Text
    '            '    .Email = Me.txtPRINCIPAL_EMAIL.Text
    '            'End With

    '            '.ENT_CONTATO = oEtContato

    '            ' '' REGISTRO
    '            '.CadastroUsuario = "AZS" 'Me.txtCAD_USUARIO.Text

    '            oNeTransportador.Incluir(oEtTransportador, myConnection)

    '            MessageBox.Show("salvo")
    '        End With

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try


    'End Sub

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

    Private Sub SALVAR_REGISTRO()
        Dim myConnection As String = Rotinas.GetConnectionStringByName("servidor")

        Dim oNeTransportador As New negTransportador
        Dim oEtTransportador As New entTransportador
        Dim oEtEndereco As New entEndereco
        Dim oEtContrato As New entContrato
        Dim oEtContato As New entContato
        Dim oEtDocumento As New entDocumento
        Dim oEtUsuario As New entUsuario

        Try

            With oEtTransportador
                .IdTransportador = Me.txtID.Text
                .Nome = Me.txtNome.Text

                '' DOCUMENTO
                With oEtDocumento
                    .TipoDocumento = Me.cboCADASTRO_TIPO.Text
                    .CNPJ_CPF = Trim(Replace(Replace(Me.mskCNPJ_CPF.Text, ",", ""), "-", ""))
                    .IE_RG = Trim(Replace(Replace(Replace(Me.txtLIMPURB.Text, ".", ""), "-", ""), ",", ""))
                End With
                .ENT_DOCUMENTO = oEtDocumento


                '' CONTATO
                With oEtContato
                    '.NomeContato = Me.txtPRINCIPAL_CONTATO.Text
                    .Telefone = Me.txtTelefone.Text
                    '.Email = Me.txtPRINCIPAL_EMAIL.Text
                End With
                .ENT_CONTATO = oEtContato

                '' ENDERECO
                With oEtEndereco
                    .Cep = Trim(Replace(Me.mskCEP.Text, "-", ""))
                    .Numero = Me.txtNUMERO.Text
                    .Complemento = Me.txtCOMPLEMENTO.Text
                    .Endereco = Me.txtENDERECO.Text
                    .Bairro = Me.txtBAIRRO.Text
                    .Cidade = Me.txtCIDADE.Text
                    .Estado = Me.txtESTADO.Text
                End With
                .ENT_ENDERECO = oEtEndereco

                '' CONTRATO DA OBRA
                With oEtContrato

                    .Coloca = IIf(Me.chkColoca.Checked, "1", "0")
                    .Troca = IIf(Me.chkTroca.Checked, "1", "0")
                    .Retira = IIf(Me.chkRetira.Checked, "1", "0")

                    .FormaDePagamento = Me.cboCONTRATO_FORMA_PAGAMENTO.Text
                    .FaturamentoDias = Me.cboCONTRATO_FATURAMENTO_DIAS.SelectedValue
                    .PeriodoLocacao = Me.txtCONTRATO_PERIODO_LOCACAO.Text
                    .RetiradaAutomatica = Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text
                    .VencimentoAposEntrega = Me.txtCONTRATO_VCTO_APOS_ENTREGA.Text

                    .MultaMora = Me.txtCONTRATO_MULTA_MORA.Text
                    .MultaDia = Me.txtCONTRATO_MULTA_DIA.Text

                    .PrecoTipo = Me.cboPRECO_TIPO.SelectedValue
                    .ValorUnitario = Me.txtPRECO_VALOR.Text

                End With
                .ENT_CONTRATO = oEtContrato

                ''USUARIO
                With oEtUsuario
                    .Nome = Me.txtUser.Text
                End With
                .ENT_USUARIO = oEtUsuario


                If txtID.Text = 0 Then
                    If oNeTransportador.Incluir(oEtTransportador, myConnection) Then
                        getID(.ENT_DOCUMENTO.CNPJ_CPF.ToString)
                        MessageBox.Show("salvo")
                    Else
                        MessageBox.Show("salvo, erro!")
                    End If
                Else
                    If oNeTransportador.Alterar(oEtTransportador, myConnection) Then

                        CARREGAR_REGISTRO(txtID.Text)
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

    Private Sub getID(ByVal CNPJ_CPF As String)

        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("SELECT * FROM vw_adm_transportador WHERE CPF_CCM = '" + CNPJ_CPF + "' LIMIT 1", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read
                .txtID.Text = rdrRegistro("ID").ToString()
                .stsREGISTRO_INSERT_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString()
                .stsREGISTRO_INSERT_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString()
                .stsREGISTRO_UPDATE_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString()
                .stsREGISTRO_UPDATE_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString()
            End While

        End With

        rdrRegistro.Close()
        cmdSQL.Dispose()

    End Sub


    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        SALVAR_REGISTRO()
    End Sub


End Class
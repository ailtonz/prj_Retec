Imports System
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports HigiaENT
Imports HigiaNEG


Public Class cadastroLigacao

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub cadastroLigacao_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Rotinas = New ClasseRotinasDiversas

        '' MATERIAIS
        'cboMateriais.Items.Insert(0, "selecione")
        CARREGAR_COMBO("Select * from vw_dgv_cad_materiais ORDER BY material", "vw_dgv_cad_materiais", Rotinas.GetConnectionStringByName("servidor"), cboMateriais, "MATERIAL", "ID")
        Me.cboMateriais.SelectedIndex = -1

        '' TIPO DE CADASTRO
        CARREGAR_COMBO("Select * from vw_dgv_status_tipo ORDER BY cadastro_tipo", "vw_dgv_status_tipo", Rotinas.GetConnectionStringByName("servidor"), cboCOBRANCA_TIPO, "cadastro_tipo", "cadastro_tipo")

        '' TRANSAÇÕES
        CARREGAR_COMBO("Select * from vw_dgv_mov_transacao ORDER BY transacao", "vw_dgv_transacao", Rotinas.GetConnectionStringByName("servidor"), cboTransacoes, "TRANSACAO", "ID")

        '' CONDIÇÕES
        CARREGAR_COMBO("Select * from vw_dgv_mov_condicoes", "vw_dgv_mov_condicoes", Rotinas.GetConnectionStringByName("servidor"), cboCondicoes, "CONDICAO_PAGAMENTO", "CONDICAO")


        '' SOLICITANTE
        CARREGAR_COMBO("Select * from vw_dgv_clientes_contatos WHERE telefone IS NOT NULL ORDER BY solicitante", "vw_dgv_clientes_contatos", Rotinas.GetConnectionStringByName("servidor"), cboSolicitante, "solicitante", "ID")
        Me.cboSolicitante.SelectedIndex = -1

        '' LIGAÇÃO
        If Me.txtID_LIGACAO.Text <> 0 Then
            CARREGAR_LIGACAO(Me.txtID_LIGACAO.Text)
        Else

            'Me.CAD_USUARIO.Text = Rotinas.GetConnectionStringByName("user").ToString
            Me.txtPedidoEmissao.Text = DateTime.Now.ToString("dd/MM/yyyy")

            '' DATAS PARA SERVIÇO
            Me.dtpColoca.Text = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")
            Me.dtpTroca.Text = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")
            Me.dtpRetira.Text = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")

        End If


    End Sub

    Private Sub CARREGAR_LIGACAO(ByVal idLigacao As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_dgv_serv_ligacoes where ID = '" + idLigacao + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                '' PEDIDO
                .txtPedidoEmissao.Text = rdrRegistro("SERVICO_EMISSAO").ToString
                .txtPedidoStatus.Text = rdrRegistro("SERVICO_STATUS").ToString

                '' ID LIGAÇÃO
                .txtID_LIGACAO.Text = rdrRegistro("ID").ToString

                '' ID CLIENTE
                .txtID_CLIENTE.Text = rdrRegistro("ID_CADASTRO").ToString
                .txtCliente.Text = rdrRegistro("SERVICO_NOME").ToString
                .txtClienteContato.Text = rdrRegistro("SERVICO_CONTATO").ToString
                .txtClienteTelefone.Text = rdrRegistro("SERVICO_TELEFONE").ToString
                .txtClienteEmail.Text = rdrRegistro("SERVICO_EMAIL").ToString
                '.txtClienteStatus.Text = rdrRegistro("PEDIDO_STATUS").ToString
                .txtPedidoObservacoes.Text = rdrRegistro("PEDIDO_STATUS_OBSERVACAO").ToString


                '' ID OBRA
                .txtID_OBRA.Text = rdrRegistro("ID_OBRA").ToString

                '.cboObra.SelectedValue = rdrRegistro("OBRA_ENDERECO").ToString  ''' <<<<<<< OBRA

                .mskOBRA_CEP.Text = rdrRegistro("OBRA_CEP").ToString
                .txtOBRA_ENDERECO.Text = rdrRegistro("OBRA_ENDERECO").ToString
                .txtOBRA_NUMERO.Text = rdrRegistro("OBRA_NUMERO").ToString
                .txtOBRA_COMPLEMENTO.Text = rdrRegistro("OBRA_COMPLEMENTO").ToString
                .txtOBRA_BAIRRO.Text = rdrRegistro("OBRA_BAIRRO").ToString
                .txtOBRA_CIDADE.Text = rdrRegistro("OBRA_CIDADE").ToString
                .txtOBRA_ESTADO.Text = rdrRegistro("OBRA_ESTADO").ToString

                '.txtOBRA_CONTATO.Text = rdrRegistro("OBRA_CONTATO").ToString
                '.txtOBRA_TELEFONE.Text = rdrRegistro("OBRA_TELEFONE").ToString
                '.txtOBRA_EMAIL.Text = rdrRegistro("OBRA_EMAIL").ToString

                ' ID SOLICITANTE
                .txtID_SOLICITANTE.Text = rdrRegistro("ID_SOLICITANTE").ToString

                ' <<<<<<< SOLICITANTE
                .cboSolicitante.SelectedIndex = CInt(.cboSolicitante.FindString(rdrRegistro("ID_SOLICITANTE").ToString))

                '.txtSolicitanteContato.Text = rdrRegistro("OBRA_SOLICITANTE").ToString
                '.txtSolicitanteTelefone.Text = rdrRegistro("OBRA_SOLICITANTE_TELEFONE").ToString
                .txtSolicitanteEmail.Text = rdrRegistro("OBRA_SOLICITANTE_EMAIL").ToString



                '' ID MATERIAL
                '.cboMateriais.SelectedValue = rdrRegistro("PEDIDO_MATERIAL").ToString

                .cboMateriais.SelectedIndex = CInt(.cboMateriais.FindString(rdrRegistro("PEDIDO_MATERIAL").ToString))

                .txtID_MATERIAL.Text = rdrRegistro("ID_MATERIAL").ToString



                '' PEDIDO
                .txtColoca.Text = rdrRegistro("PEDIDO_COLOCA").ToString
                .txtTroca.Text = rdrRegistro("PEDIDO_TROCA").ToString
                .txtRetira.Text = rdrRegistro("PEDIDO_RETIRA").ToString

                '' DATAS
                .dtpColoca.Text = rdrRegistro("PEDIDO_DT_COLOCA").ToString
                .dtpTroca.Text = rdrRegistro("PEDIDO_DT_TROCA").ToString
                .dtpRetira.Text = rdrRegistro("PEDIDO_DT_RETIRA").ToString

                '' PRIORIDADE
                .chkColocaPrioridade.Checked = IIf(rdrRegistro("PEDIDO_PR_COLOCA").ToString, "1", "0")
                .chkTrocaPrioridade.Checked = IIf(rdrRegistro("PEDIDO_PR_TROCA").ToString, "1", "0")
                .chkRetiraPrioridade.Checked = IIf(rdrRegistro("PEDIDO_PR_RETIRA").ToString, "1", "0")

                '' PEDIDO x OBSERVAÇÃO
                .txtColocaObs.Text = rdrRegistro("PEDIDO_OBS_COLOCA").ToString
                .txtTrocaObs.Text = rdrRegistro("PEDIDO_OBS_TROCA").ToString
                .txtRetiraObs.Text = rdrRegistro("PEDIDO_OBS_RETIRA").ToString
                .txtObservacoes.Text = rdrRegistro("PEDIDO_OBS_LIGACAO").ToString

                '' CONTRATO
                .cboTransacoes.SelectedIndex = CInt(.cboTransacoes.FindString(rdrRegistro("CONTRATO_FORMA_PAGAMENTO").ToString))
                .cboCondicoes.SelectedValue = CInt(.cboCondicoes.FindString(rdrRegistro("CONTRATO_FATURAMENTO_DIAS").ToString))

                .txtCONTRATO_PERIODO_LOCACAO.Text = rdrRegistro("CONTRATO_PERIODO_LOCACAO").ToString
                .txtCONTRATO_RETIRADA_AUTOMATICA.Text = rdrRegistro("CONTRATO_RETIRADA_AUTOMATICA").ToString
                .txtCONTRATO_VCTO_APOS_ENTREGA.Text = rdrRegistro("CONTRATO_VCTO_APOS_ENTREGA").ToString
                .txtCONTRATO_VALOR.Text = rdrRegistro("CONTRATO_VALOR").ToString
                .txtCONTRATO_MULTA_MORA.Text = rdrRegistro("CONTRATO_MULTA_MORA").ToString
                .txtCONTRATO_MULTA_DIA.Text = rdrRegistro("CONTRATO_MULTA_DIA").ToString
                .chkCONTRATO_NF.Checked = IIf(rdrRegistro("CONTRATO_NFE").ToString, "1", "0")
                .chkCONTRATO_ISS.Checked = IIf(rdrRegistro("CONTRATO_ISS").ToString, "1", "0")
                .chkCONTRATO_CTR.Checked = IIf(rdrRegistro("CONTRATO_CTR").ToString, "1", "0")

                '' COBRANÇA
                If rdrRegistro("COBRANCA_TIPO").ToString = "PF" Then
                    Me.mskCOBRANCA_INSCRICAO.UseSystemPasswordChar = False

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("PF"))
                ElseIf rdrRegistro("COBRANCA_TIPO").ToString = "PJ" Then
                    Me.mskCOBRANCA_INSCRICAO.UseSystemPasswordChar = False

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("PJ"))
                End If

                .mskCOBRANCA_INSCRICAO.Text = rdrRegistro("COBRANCA_INSCRICAO").ToString
                .txtCOBRANCA_SACADO.Text = rdrRegistro("COBRANCA_SACADO").ToString
                .mskCOBRANCA_CEP.Text = rdrRegistro("COBRANCA_CEP").ToString
                .txtCOBRANCA_LOGRADOURO.Text = rdrRegistro("COBRANCA_LOGRADOURO").ToString
                .txtCOBRANCA_BAIRRO.Text = rdrRegistro("COBRANCA_BAIRRO").ToString
                .txtCOBRANCA_CIDADE.Text = rdrRegistro("COBRANCA_CIDADE").ToString
                .txtCOBRANCA_ESTADO.Text = rdrRegistro("COBRANCA_ESTADO").ToString
                .txtCOBRANCA_NOME.Text = rdrRegistro("COBRANCA_CONTATO").ToString
                .txtCOBRANCA_TELEFONE.Text = rdrRegistro("COBRANCA_TELEFONE").ToString
                .txtCOBRANCA_EMAIL.Text = rdrRegistro("COBRANCA_EMAIL").ToString


            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub CARREGAR_OBRA(ByVal idObra As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_dgv_clientes_obras where ID = '" + idObra + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                '' OBRA
                .mskOBRA_CEP.Text = rdrRegistro("CEP").ToString
                .txtOBRA_NUMERO.Text = rdrRegistro("NUMERO").ToString
                .txtOBRA_COMPLEMENTO.Text = rdrRegistro("COMPLEMENTO").ToString
                .txtOBRA_ENDERECO.Text = rdrRegistro("ENDERECO").ToString
                .txtOBRA_BAIRRO.Text = rdrRegistro("BAIRRO").ToString
                .txtOBRA_CIDADE.Text = rdrRegistro("CIDADE").ToString
                .txtOBRA_ESTADO.Text = rdrRegistro("ESTADO").ToString
                .txtOBRA_DESCRICAO.Text = rdrRegistro("OBRA").ToString

                '' CONTRATO
                .txtColocaObs.Text = rdrRegistro("CONTRATO_OBS_COLOCA").ToString
                .txtTrocaObs.Text = rdrRegistro("CONTRATO_OBS_TROCA").ToString
                .txtRetiraObs.Text = rdrRegistro("CONTRATO_OBS_RETIRA").ToString
                .txtObservacoes.Text = rdrRegistro("CONTRATO_OBS_LIGACAO").ToString

                .cboTransacoes.SelectedIndex = CInt(.cboTransacoes.FindString(rdrRegistro("CONTRATO_FORMA_PAGAMENTO").ToString))
                .cboCondicoes.SelectedValue = CInt(.cboCondicoes.FindString(rdrRegistro("CONTRATO_FATURAMENTO_DIAS").ToString))

                .txtCONTRATO_PERIODO_LOCACAO.Text = rdrRegistro("CONTRATO_PERIODO_LOCACAO").ToString
                .txtCONTRATO_RETIRADA_AUTOMATICA.Text = rdrRegistro("CONTRATO_RETIRADA_AUTOMATICA").ToString
                .txtCONTRATO_VCTO_APOS_ENTREGA.Text = rdrRegistro("CONTRATO_VCTO_APOS_ENTREGA").ToString
                .txtCONTRATO_VALOR.Text = rdrRegistro("CONTRATO_VALOR").ToString
                .txtCONTRATO_MULTA_MORA.Text = rdrRegistro("CONTRATO_MULTA_MORA").ToString
                .txtCONTRATO_MULTA_DIA.Text = rdrRegistro("CONTRATO_MULTA_DIA").ToString
                .chkCONTRATO_NF.Checked = IIf(rdrRegistro("CONTRATO_NF").ToString, "1", "0")
                .chkCONTRATO_ISS.Checked = IIf(rdrRegistro("CONTRATO_ISS").ToString, "1", "0")
                .chkCONTRATO_CTR.Checked = IIf(rdrRegistro("CONTRATO_CTR").ToString, "1", "0")

                '' COBRANÇA
                If rdrRegistro("COBRANCA_TIPO").ToString = "PF" Then
                    Me.mskCOBRANCA_INSCRICAO.UseSystemPasswordChar = False

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("PF"))
                ElseIf rdrRegistro("COBRANCA_TIPO").ToString = "PJ" Then
                    Me.mskCOBRANCA_INSCRICAO.UseSystemPasswordChar = False

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("PJ"))
                End If

                .mskCOBRANCA_INSCRICAO.Text = rdrRegistro("COBRANCA_INSCRICAO").ToString
                .txtCOBRANCA_SACADO.Text = rdrRegistro("COBRANCA_SACADO").ToString
                .mskCOBRANCA_CEP.Text = rdrRegistro("COBRANCA_CEP").ToString
                .txtCOBRANCA_LOGRADOURO.Text = rdrRegistro("COBRANCA_LOGRADOURO").ToString
                .txtCOBRANCA_BAIRRO.Text = rdrRegistro("COBRANCA_BAIRRO").ToString
                .txtCOBRANCA_CIDADE.Text = rdrRegistro("COBRANCA_CIDADE").ToString
                .txtCOBRANCA_ESTADO.Text = rdrRegistro("COBRANCA_ESTADO").ToString
                .txtCOBRANCA_NOME.Text = rdrRegistro("COBRANCA_CONTATO").ToString
                .txtCOBRANCA_TELEFONE.Text = rdrRegistro("COBRANCA_TELEFONE").ToString
                .txtCOBRANCA_EMAIL.Text = rdrRegistro("COBRANCA_EMAIL").ToString

                .txtID_CLIENTE.Text = rdrRegistro("ID_CLIENTE").ToString

            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub CARREGAR_SOLICITANTE(ByVal idSolicitante As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_dgv_clientes_contatos where ID = '" + idSolicitante + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                '' SOLICITANTE
                .txtSolicitanteContato.Text = rdrRegistro("CONTATO").ToString & " - " & rdrRegistro("TELEFONE").ToString
                .txtSolicitanteEmail.Text = rdrRegistro("EMAIL").ToString

            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub CARREGAR_CLIENTE(ByVal idCliente As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_dgv_clientes where ID = '" + idCliente + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                '' SOLICITANTE
                .txtCliente.Text = rdrRegistro("CLIENTE").ToString
                .txtClienteContato.Text = rdrRegistro("CONTATO").ToString
                .txtClienteTelefone.Text = rdrRegistro("TELEFONE").ToString
                .txtClienteEmail.Text = rdrRegistro("EMAIL").ToString

                If rdrRegistro("CADASTRO_STATUS").ToString = "LIBERADO" Then
                    .txtPedidoStatus.Text = "OK"
                Else
                    .txtPedidoStatus.Text = "N.OK"
                End If

                '.txtClienteStatus.Text = rdrRegistro("CADASTRO_STATUS").ToString
                .txtPedidoObservacoes.Text = rdrRegistro("CADASTRO_STATUS_OBSERVACAO").ToString


            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub btnCLIENTE_SALVAR_Click(sender As System.Object, e As System.EventArgs) Handles btnCLIENTE_SALVAR.Click
        If VALIDAR_CAMPOS("PRINCIPAL") Then
            SalvarLigacao()
        End If

    End Sub

    Private Sub SalvarLigacao()
        'Dim myConnection As String = Rotinas.GetConnectionStringByName("servidor")

        'Dim oNeLigacao As New negLigacao

        'Dim oEtLigacao As New entLigacao
        'Dim oEtSolicitante As New entContato

        'Dim oEtObra As New entEndereco
        'Dim oEtObraCliente As New entCliente
        'Dim oEtObraClienteContato As New entContato
        'Dim oEtObraCobranca As New entCobranca
        'Dim oEtObraCobrancaContato As New entContato
        'Dim oEtObraContrato As New entContrato
        'Dim oEtObraServico As New entServico
        'Dim oEtObraStatus As New entStatusCliente

        'Dim oEtObraMaterial As New entMaterial

        'Dim oEtObraUsuario As New entUsuario

        'Try
        '    '' DADOS DA OBRA
        '    With oEtLigacao

        '        '' *** [ PEDIDO ]
        '        .IdLigacao = Me.txtID_LIGACAO.Text
        '        .IdCliente = Me.txtID_CLIENTE.Text
        '        .IdObra = Me.txtID_OBRA.Text
        '        .IdSolicitante = Me.txtID_SOLICITANTE.Text

        '        With oEtObraMaterial
        '            .Id = Me.cboMateriais.SelectedValue
        '            .Material = Me.cboMateriais.Text
        '        End With
        '        .ENT_MATERIAL = oEtObraMaterial

        '        .ServicoEmissao = Me.txtPedidoEmissao.Text

        '        With oEtObraStatus
        '            .Status = Me.txtPedidoStatus.Text
        '            .Observacao = Me.txtPedidoObservacoes.Text
        '        End With
        '        .ENT_STATUS = oEtObraStatus

        '        '' *** [ CLIENTE ]
        '        With oEtObraCliente
        '            .Nome = Me.txtCliente.Text

        '            With oEtObraClienteContato
        '                .NomeContato = Me.txtClienteContato.Text
        '                .Telefone = Me.txtClienteTelefone.Text
        '                .Email = Me.txtClienteEmail.Text
        '            End With
        '            .ENT_CONTATO = oEtObraClienteContato


        '        End With
        '        .ENT_CLIENTE = oEtObraCliente

        '        '' *** [ SERVIÇO ]
        '        With oEtObraServico

        '            .Coloca = Me.txtColoca.Text
        '            .DTColoca = dtpColoca.Text
        '            .PRColoca = IIf(Me.chkColocaPrioridade.Checked, "1", "0")
        '            .ObsColoca = Me.txtColocaObs.Text

        '            .Troca = Me.txtTroca.Text
        '            .DTTroca = dtpTroca.Text
        '            .PRTroca = IIf(Me.chkTrocaPrioridade.Checked, "1", "0")
        '            .ObsTroca = Me.txtTrocaObs.Text

        '            .Retira = Me.txtRetira.Text
        '            .DTRetira = dtpRetira.Text
        '            .PRRetira = IIf(Me.chkRetiraPrioridade.Checked, "1", "0")
        '            .ObsRetira = Me.txtRetiraObs.Text

        '            .ObsGeral = Me.txtObservacoes.Text

        '        End With
        '        .ENT_SERVICO = oEtObraServico

        '        '' *** [ SOLICITANTE ]
        '        With oEtSolicitante
        '            .NomeContato = Me.txtSolicitanteContato.Text
        '            .Email = Me.txtSolicitanteEmail.Text

        '        End With
        '        .ENT_SOLICITANTE = oEtSolicitante

        '        '' *** [ OBRA ]
        '        With oEtObra
        '            .Cep = Me.mskOBRA_CEP.Text
        '            .Endereco = Me.txtOBRA_ENDERECO.Text
        '            .Numero = Me.txtOBRA_NUMERO.Text
        '            .Complemento = Me.txtOBRA_COMPLEMENTO.Text
        '            .Bairro = Me.txtOBRA_BAIRRO.Text
        '            .Cidade = Me.txtOBRA_CIDADE.Text
        '            .Estado = Me.txtOBRA_ESTADO.Text
        '            .Observacao = Me.cboObra.Text

        '        End With
        '        .ENT_OBRA = oEtObra

        '        '' *** [ CONTRATO ]
        '        With oEtObraContrato

        '            .nfe = IIf(Me.chkCONTRATO_NF.Checked, "1", "0")
        '            .iss = IIf(Me.chkCONTRATO_ISS.Checked, "1", "0")
        '            .ctr = IIf(Me.chkCONTRATO_CTR.Checked, "1", "0")
        '            .FormaDePagamento = Me.cboTransacoes.Text
        '            .FaturamentoDias = Me.cboCondicoes.SelectedValue
        '            .PeriodoLocacao = Me.txtCONTRATO_PERIODO_LOCACAO.Text
        '            .RetiradaAutomatica = Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text
        '            .VencimentoAposEntrega = Me.txtCONTRATO_VCTO_APOS_ENTREGA.Text

        '            .MultaMora = Me.txtCONTRATO_MULTA_MORA.Text
        '            .MultaDia = Me.txtCONTRATO_MULTA_DIA.Text
        '            .ValorUnitario = Me.txtCONTRATO_VALOR.Text

        '        End With
        '        .ENT_CONTRATO = oEtObraContrato


        '        '' *** [ COBRANÇA ]
        '        With oEtObraCobranca

        '            .TipoCobranca = Me.cboCOBRANCA_TIPO.Text

        '            .Inscricao = Me.mskCOBRANCA_INSCRICAO.Text
        '            .Sacado = Me.txtCOBRANCA_SACADO.Text
        '            .Logradouro = Me.txtCOBRANCA_LOGRADOURO.Text
        '            .Bairro = Me.txtCOBRANCA_BAIRRO.Text
        '            .Cep = Trim(Replace(Me.mskCOBRANCA_CEP.Text, "-", ""))
        '            .Cidade = Me.txtCOBRANCA_CIDADE.Text
        '            .Estado = Me.txtCOBRANCA_ESTADO.Text

        '            With oEtObraCobrancaContato
        '                .NomeContato = Me.txtCOBRANCA_NOME.Text
        '                .Telefone = Me.txtCOBRANCA_TELEFONE.Text
        '                .Email = Me.txtCOBRANCA_EMAIL.Text
        '            End With
        '            .ENT_CONTATO = oEtObraCobrancaContato


        '        End With
        '        .ENT_COBRANCA = oEtObraCobranca



        '        ''USUARIO
        '        With oEtObraUsuario
        '            .Nome = cadastroCliente.txtUser.Text
        '        End With
        '        .ENT_USUARIO = oEtObraUsuario

        '    End With

        '    '' OPERAÇÃO
        '    If oEtLigacao.IdLigacao.ToString = 0 Then
        '        If oNeLigacao.Incluir(oEtLigacao, myConnection) Then
        '            getID_Ligacao(oEtLigacao.IdCliente, oEtLigacao.IdObra, oEtLigacao.IdSolicitante)
        '            MessageBox.Show("salvo")
        '        Else
        '            MessageBox.Show("salvo, erro!")
        '        End If

        '    Else

        '        If oNeLigacao.Alterar(oEtLigacao, myConnection) Then
        '            MessageBox.Show("alterado")
        '        Else
        '            MessageBox.Show("alterado, erro!")
        '        End If

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    ''-------------
    '' FUNÇÕES
    ''-------------

    Private Sub getID_Ligacao(ByVal idCliente As String, ByVal idObra As String, ByVal idSolicitante As String)

        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strSQL As String

        strSQL = "SELECT * FROM vw_dgv_ligacoes WHERE id_cadastro = " + idCliente + " AND ID_OBRA = " + idObra + " AND ID_SOLICITANTE = " + idSolicitante + " LIMIT 1"

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand(strSQL, myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()
        With Me
            While rdrRegistro.Read
                .txtID_OBRA.Text = rdrRegistro("ID").ToString()

                .stsREGISTRO_INSERT_EMISSAO.Text = rdrRegistro("REGISTRO_INSERT_EMISSAO").ToString
                .stsREGISTRO_INSERT_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString
                .stsREGISTRO_UPDATE_EMISSAO.Text = rdrRegistro("REGISTRO_UPDATE_EMISSAO").ToString
                .stsREGISTRO_UPDATE_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString

            End While
        End With

        rdrRegistro.Close()
        cmdSQL.Dispose()

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

    'Private Sub CARREGAR_TIPOS_CADASTROS(ByVal cbo As ComboBox)
    '    Dim TiposCadastros() As String = {"FISICO", "JURIDICO"}
    '    Dim TipoCadastro As String

    '    '' TIPO DE CADASTROS
    '    With cbo
    '        .Items.Clear()
    '        For Each TipoCadastro In TiposCadastros
    '            .Items.Add(TipoCadastro)
    '        Next
    '        .SelectedIndex = CInt(.FindString("FISICO"))
    '    End With

    'End Sub

    Private Function VALIDAR_CAMPOS(ByVal sessao As String) As Boolean
        Dim blnRet As Boolean = False  'inicializar o valor como false

        With Me
            Select Case sessao
                Case "PRINCIPAL"
                    If .cboSolicitante.Text = "" Then
                        ErrorProvider1.SetError(.cboSolicitante, "SOLICITANTE. Campo de preenchimento obrigatório")
                    Else ''ocorreu um erro ao validar os dados do form
                        blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)
                    End If
            End Select
        End With
        Return blnRet

    End Function

    Private Function cboSolicitantes() As Object
        Throw New NotImplementedException
    End Function

    Private Sub cboSolicitante_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSolicitante.SelectedIndexChanged

        If Me.cboSolicitante.SelectedIndex.ToString > -1 Then
            If Me.cboSolicitante.SelectedValue.ToString <> "" Then
                Me.txtID_SOLICITANTE.Text = Me.cboSolicitante.SelectedValue.ToString
                CARREGAR_SOLICITANTE(Me.txtID_SOLICITANTE.Text)
                '' OBRAS
                CARREGAR_COMBO("Select * from vw_dgv_serv_obras WHERE ID_SOLICITANTE = '" & Me.txtID_SOLICITANTE.Text & "' ORDER BY obra", "vw_dgv_serv_obras", Rotinas.GetConnectionStringByName("servidor"), cboObra, "OBRA", "ID_OBRA")
                Me.cboObra.SelectedIndex = -1

            End If
        End If

    End Sub

    Private Sub cboObra_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboObra.SelectedIndexChanged

        If Me.cboObra.SelectedIndex.ToString > -1 Then
            If Me.cboObra.SelectedValue.ToString <> "" Then
                Me.txtID_OBRA.Text = Me.cboObra.SelectedValue.ToString
                CARREGAR_OBRA(Me.txtID_OBRA.Text)
                CARREGAR_CLIENTE(Me.txtID_CLIENTE.Text)
            End If
        End If

    End Sub

    Private Sub cboMateriais_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMateriais.SelectedIndexChanged

        If Me.cboMateriais.SelectedIndex.ToString > -1 Then
            If Me.cboMateriais.SelectedValue.ToString <> "" Then
                Me.txtID_MATERIAL.Text = Me.cboMateriais.SelectedValue.ToString
                Me.txtMateriais.Text = Me.cboMateriais.Text
            End If
        End If

    End Sub




End Class
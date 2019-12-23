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
        CARREGAR_COMBO("Select * from vw_dgv_materiais ORDER BY material", "vw_dgv_materiais", Rotinas.GetConnectionStringByName("servidor"), cboMateriais, "MATERIAL", "ID")

        '' TRANSAÇÕES
        CARREGAR_COMBO("Select * from vw_dgv_transacao ORDER BY transacao", "vw_dgv_transacao", Rotinas.GetConnectionStringByName("servidor"), cboTransacoes, "TRANSACAO", "ID")

        '' CONDIÇÕES
        CARREGAR_COMBO("Select * from vw_dgv_condicoes ORDER BY condicao_pagamento", "vw_dgv_condicoes", Rotinas.GetConnectionStringByName("servidor"), cboCondicoes, "condicao_pagamento", "CONDICAO")

        '' TIPOS DE CADASTROS
        CARREGAR_TIPOS_CADASTROS(Me.cboCOBRANCA_TIPO)


        If Me.txtID_LIGACAO.Text <> 0 Then
            CARREGAR_LIGACAO(Me.txtID_LIGACAO.Text)
        ElseIf Me.txtID_OBRA.Text <> 0 Then
            CARREGAR_OBRA(Me.txtID_OBRA.Text)
        End If



        Me.CAD_USUARIO.Text = Rotinas.GetConnectionStringByName("user").ToString
        Me.CAD_EMISSAO.Text = DateTime.Now.ToString("dd/MM/yyyy")

    End Sub

    Private Sub CARREGAR_LIGACAO(ByVal idLigacao As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_dgv_ligacoes where ID = '" + idLigacao + "' ", myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()

        With Me

            While rdrRegistro.Read

                '' ID LIGAÇÃO
                .txtID_LIGACAO.Text = rdrRegistro("ID").ToString

                '' ID CLIENTE
                .txtID_CLIENTE.Text = rdrRegistro("ID_CADASTRO").ToString

                '' ID SOLICITANTE
                .cboSolicitantes.SelectedValue = rdrRegistro("ID_SOLICITANTE").ToString

                '' ID OBRA
                .txtID_OBRA.Text = rdrRegistro("ID_OBRA").ToString

                '' ID MATERIAL
                .cboMateriais.SelectedValue = rdrRegistro("ID_MATERIAL").ToString

                '' PEDIDO
                .txtColoca.Text = rdrRegistro("COLOCA").ToString
                .txtTroca.Text = rdrRegistro("TROCA").ToString
                .txtRetira.Text = rdrRegistro("RETIRA").ToString

                '' PEDIDO X PRIORIDADE
                .chkPrioridadeColoca.Checked = IIf(rdrRegistro("PR_COLOCA").ToString, "1", "0")
                .chkPrioridadeTroca.Checked = IIf(rdrRegistro("PR_TROCA").ToString, "1", "0")
                .chkPrioridadeRetira.Checked = IIf(rdrRegistro("PR_RETIRA").ToString, "1", "0")

                '' PEDIDO x OBSERVAÇÃO
                .txtCONTRATO_OBS_COLOCA.Text = rdrRegistro("SERVICO_OBS_COLOCA").ToString
                .txtCONTRATO_OBS_TROCA.Text = rdrRegistro("SERVICO_OBS_TROCA").ToString
                .txtCONTRATO_OBS_RETIRA.Text = rdrRegistro("SERVICO_OBS_RETIRA").ToString
                .txtCONTRATO_OBS_LIGACAO.Text = rdrRegistro("SERVICO_OBS_LIGACAO").ToString

                '' CONTRATO
                .cboTransacoes.SelectedIndex = CInt(.cboTransacoes.FindString(rdrRegistro("CONTRATO_FORMA_PAGAMENTO").ToString))
                .cboCondicoes.SelectedValue = rdrRegistro("CONTRATO_FATURAMENTO_DIAS").ToString
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

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("FISICO"))
                ElseIf rdrRegistro("COBRANCA_TIPO").ToString = "PJ" Then
                    Me.mskCOBRANCA_INSCRICAO.UseSystemPasswordChar = False

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("JURIDICO"))
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



                '' CONTROLE
                .CAD_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString()
                .CAD_EMISSAO.Text = rdrRegistro("CADASTRO").ToString()
                .ALT_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString()
                .ALT_EMISSAO.Text = rdrRegistro("ATUALIZACAO").ToString()


            End While

            rdrRegistro.Close()
            cmdSQL.Dispose()
        End With

    End Sub

    Private Sub CARREGAR_OBRA(ByVal idObra As String)
        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand("Select * from vw_cad_clientes_obras where ID = '" + idObra + "' ", myConnection)
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

                '' OBRA X RESPONSÁVEL
                .txtOBRA_CONTATO.Text = rdrRegistro("CONTATO").ToString
                .txtOBRA_TELEFONE.Text = rdrRegistro("TELEFONE").ToString
                .txtOBRA_EMAIL.Text = rdrRegistro("EMAIL").ToString

                '' CONTRATO
                .txtCONTRATO_OBS_COLOCA.Text = rdrRegistro("CONTRATO_OBS_COLOCA").ToString
                .txtCONTRATO_OBS_TROCA.Text = rdrRegistro("CONTRATO_OBS_TROCA").ToString
                .txtCONTRATO_OBS_RETIRA.Text = rdrRegistro("CONTRATO_OBS_RETIRA").ToString
                .txtCONTRATO_OBS_LIGACAO.Text = rdrRegistro("CONTRATO_OBS_LIGACAO").ToString
                .cboTransacoes.SelectedIndex = CInt(.cboTransacoes.FindString(rdrRegistro("CONTRATO_FORMA_PAGAMENTO").ToString))
                .cboCondicoes.SelectedValue = rdrRegistro("CONTRATO_FATURAMENTO_DIAS").ToString
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

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("FISICO"))
                ElseIf rdrRegistro("COBRANCA_TIPO").ToString = "PJ" Then
                    Me.mskCOBRANCA_INSCRICAO.UseSystemPasswordChar = False

                    Me.cboCOBRANCA_TIPO.SelectedIndex = CInt(Me.cboCOBRANCA_TIPO.FindString("JURIDICO"))
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

                '' SOLICITANTES
                CARREGAR_COMBO("SELECT * FROM vw_dgv_obras_contatos WHERE ID_OBRA = '" + .txtID_OBRA.Text + "' AND SOLICITANTE= '1' ORDER BY contato", "vw_dgv_obras_contatos", Rotinas.GetConnectionStringByName("servidor"), Me.cboSolicitantes, "CONTATO", "ID")


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
        Dim myConnection As String = Rotinas.GetConnectionStringByName("servidor")
        Dim oNeLigacao As New negLigacao

        Dim oEtLigacao As New entLigacao
        Dim oEtObraUsuario As New entUsuario
        Dim oEtObraContato As New entContato
        Dim oEtObraCobranca As New entCobranca
        Dim oEtObraContrato As New entContrato
        Dim oEtObraServico As New entServico
        Dim oEtObraStatus As New entStatus
        Dim oEtObraMaterial As New entUtilMaterial

        Try
            '' DADOS DA OBRA
            With oEtLigacao

                .IdLigacao = Me.txtID_LIGACAO.Text
                .IdCliente = Me.txtID_CLIENTE.Text
                .IdSolicitante = Me.cboSolicitantes.SelectedValue
                .IdObra = Me.txtID_OBRA.Text

                With oEtObraMaterial
                    .IdMaterial = Me.cboMateriais.SelectedValue
                End With
                .ENT_MATERIAL = oEtObraMaterial

                '' EMISSÃO
                '.ServicoEmissao = DateTime.Now.ToString("dd/MM/yyyy")

                '' STATUS
                With oEtObraStatus
                    .Status = Me.txtStatus.Text
                End With
                .ENT_STATUS = oEtObraStatus

                With oEtObraServico
                    .Coloca = Me.txtColoca.Text
                    .Troca = Me.txtTroca.Text
                    .Retira = Me.txtRetira.Text
                    .DTColoca = dtpColoca.Text
                    .DTTroca = dtpTroca.Text
                    .DTRetira = dtpRetira.Text
                    .PRColoca = IIf(Me.chkPrioridadeColoca.Checked, "1", "0")
                    .PRTroca = IIf(Me.chkPrioridadeTroca.Checked, "1", "0")
                    .PRRetira = IIf(Me.chkPrioridadeRetira.Checked, "1", "0")
                    .ObsColoca = Me.txtCONTRATO_OBS_COLOCA.Text
                    .ObsTroca = Me.txtCONTRATO_OBS_TROCA.Text
                    .ObsRetira = Me.txtCONTRATO_OBS_RETIRA.Text
                    .ObsGeral = Me.txtCONTRATO_OBS_LIGACAO.Text
                End With
                .ENT_SERVICO = oEtObraServico

                With oEtObraCobranca

                    If Me.cboCOBRANCA_TIPO.Text = "FISICO" Then
                        .TipoCobranca = "pf"
                    ElseIf Me.cboCOBRANCA_TIPO.Text = "JURIDICO" Then
                        .TipoCobranca = "pj"
                    End If

                    .Inscricao = Me.mskCOBRANCA_INSCRICAO.Text
                    .Sacado = Me.txtCOBRANCA_SACADO.Text
                    .Logradouro = Me.txtCOBRANCA_LOGRADOURO.Text
                    .Bairro = Me.txtCOBRANCA_BAIRRO.Text
                    .Cep = Trim(Replace(Me.mskCOBRANCA_CEP.Text, "-", ""))
                    .Cidade = Me.txtCOBRANCA_CIDADE.Text
                    .Estado = Me.txtCOBRANCA_ESTADO.Text

                    With oEtObraContato
                        .NomeContato = Me.txtCOBRANCA_NOME.Text
                        .Telefone = Me.txtCOBRANCA_TELEFONE.Text
                        .Email = Me.txtCOBRANCA_EMAIL.Text
                    End With
                    .ENT_CONTATO = oEtObraContato


                End With
                .ENT_COBRANCA = oEtObraCobranca

                '' CONTRATO DA OBRA
                With oEtObraContrato
                    .ValorUnitario = Me.txtCONTRATO_VALOR.Text
                    .nfe = IIf(Me.chkCONTRATO_NF.Checked, "1", "0")
                    .iss = IIf(Me.chkCONTRATO_ISS.Checked, "1", "0")
                    .ctr = IIf(Me.chkCONTRATO_CTR.Checked, "1", "0")
                    .FormaDePagamento = Me.cboTransacoes.Text
                    '.FaturamentoDias = faturamento(Me.cboCondicoes.SelectedItem.ToString)
                    .PeriodoLocacao = Me.txtCONTRATO_PERIODO_LOCACAO.Text
                    .RetiradaAutomatica = Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text
                    .VencimentoAposEntrega = Me.txtCONTRATO_VCTO_APOS_ENTREGA.Text
                    .MultaMora = Me.txtCONTRATO_MULTA_MORA.Text
                    .MultaDia = Me.txtCONTRATO_MULTA_DIA.Text
                End With
                .ENT_CONTRATO = oEtObraContrato


                ''USUARIO
                With oEtObraUsuario
                    .Nome = cadastroCliente.txtUser.Text
                End With
                .ENT_USUARIO = oEtObraUsuario

            End With

            '' OPERAÇÃO
            If oEtLigacao.IdLigacao.ToString = 0 Then
                If oNeLigacao.Incluir(oEtLigacao, myConnection) Then
                    getID_Ligacao(oEtLigacao.IdCliente, oEtLigacao.IdObra, oEtLigacao.IdSolicitante)
                    MessageBox.Show("salvo")
                Else
                    MessageBox.Show("salvo, erro!")
                End If

            Else

                If oNeLigacao.Alterar(oEtLigacao, myConnection) Then
                    MessageBox.Show("alterado")
                Else
                    MessageBox.Show("alterado, erro!")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub






    ''-------------
    '' FUNÇÕES
    ''-------------

    Private Sub getID_Ligacao(ByVal idCliente As String, ByVal idObra As String, ByVal idSolicitante As String)

        Dim myConnection As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strSQL As String

        strSQL = "SELECT id,REGISTRO_INSERT_USUARIO,CADASTRO,REGISTRO_UPDATE_USUARIO,ATUALIZACAO FROM vw_dgv_ligacoes WHERE id_cadastro = " + idCliente + " AND ID_OBRA = " + idObra + " AND ID_SOLICITANTE = " + idSolicitante + " LIMIT 1"

        myConnection.Open()

        Dim cmdSQL As New MySqlCommand(strSQL, myConnection)
        Dim rdrRegistro As MySqlDataReader

        rdrRegistro = cmdSQL.ExecuteReader()
        With Me
            While rdrRegistro.Read
                .txtID_OBRA.Text = rdrRegistro("ID").ToString()
                .CAD_USUARIO.Text = rdrRegistro("REGISTRO_INSERT_USUARIO").ToString()
                .CAD_EMISSAO.Text = rdrRegistro("CADASTRO").ToString()
                .ALT_USUARIO.Text = rdrRegistro("REGISTRO_UPDATE_USUARIO").ToString()
                .ALT_EMISSAO.Text = rdrRegistro("ATUALIZACAO").ToString()
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

    Private Sub CARREGAR_TIPOS_CADASTROS(ByVal cbo As ComboBox)
        Dim TiposCadastros() As String = {"FISICO", "JURIDICO"}
        Dim TipoCadastro As String

        '' TIPO DE CADASTROS
        With cbo
            .Items.Clear()
            For Each TipoCadastro In TiposCadastros
                .Items.Add(TipoCadastro)
            Next
            .SelectedIndex = CInt(.FindString("FISICO"))
        End With

    End Sub

    Private Function VALIDAR_CAMPOS(ByVal sessao As String) As Boolean
        Dim blnRet As Boolean = False  'inicializar o valor como false

        With Me
            Select Case sessao
                Case "PRINCIPAL"
                    If .cboSolicitantes.Text = "" Then
                        ErrorProvider1.SetError(.cboSolicitantes, "SOLICITANTE. Campo de preenchimento obrigatório")
                    Else ''ocorreu um erro ao validar os dados do form
                        blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)
                    End If
            End Select
        End With
        Return blnRet

    End Function

End Class
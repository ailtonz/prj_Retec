<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastroLigacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtID_LIGACAO = New System.Windows.Forms.TextBox()
        Me.txtID_CLIENTE = New System.Windows.Forms.TextBox()
        Me.txtID_OBRA = New System.Windows.Forms.TextBox()
        Me.txtID_SOLICITANTE = New System.Windows.Forms.TextBox()
        Me.btnCLIENTE_SALVAR = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsREGISTRO_INSERT_USUARIO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_INSERT_EMISSAO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_UPDATE_USUARIO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_UPDATE_EMISSAO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSolicitanteContato = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtClienteContato = New System.Windows.Forms.TextBox()
        Me.txtClienteTelefone = New System.Windows.Forms.TextBox()
        Me.txtClienteEmail = New System.Windows.Forms.TextBox()
        Me.lblPRINCIPAL_CONTATO = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSolicitanteEmail = New System.Windows.Forms.TextBox()
        Me.grpPEDIDO = New System.Windows.Forms.GroupBox()
        Me.txtOBRA_DESCRICAO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPedidoStatus = New System.Windows.Forms.TextBox()
        Me.txtPedidoObservacoes = New System.Windows.Forms.TextBox()
        Me.txtPedidoEmissao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMateriais = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRetiraObs = New System.Windows.Forms.TextBox()
        Me.txtTrocaObs = New System.Windows.Forms.TextBox()
        Me.txtColocaObs = New System.Windows.Forms.TextBox()
        Me.txtObservacoes = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkRetiraPrioridade = New System.Windows.Forms.CheckBox()
        Me.chkTrocaPrioridade = New System.Windows.Forms.CheckBox()
        Me.chkColocaPrioridade = New System.Windows.Forms.CheckBox()
        Me.dtpColoca = New System.Windows.Forms.DateTimePicker()
        Me.dtpTroca = New System.Windows.Forms.DateTimePicker()
        Me.dtpRetira = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtRetira = New System.Windows.Forms.TextBox()
        Me.txtTroca = New System.Windows.Forms.TextBox()
        Me.txtColoca = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpOBRA = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOBRA_ESTADO = New System.Windows.Forms.TextBox()
        Me.txtOBRA_CIDADE = New System.Windows.Forms.TextBox()
        Me.mskOBRA_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblOBRA_BAIRRO = New System.Windows.Forms.Label()
        Me.lblOBRA_NUMERO = New System.Windows.Forms.Label()
        Me.txtOBRA_BAIRRO = New System.Windows.Forms.TextBox()
        Me.txtOBRA_COMPLEMENTO = New System.Windows.Forms.TextBox()
        Me.txtOBRA_NUMERO = New System.Windows.Forms.TextBox()
        Me.txtOBRA_ENDERECO = New System.Windows.Forms.TextBox()
        Me.grpOBRA_COBRANCA = New System.Windows.Forms.GroupBox()
        Me.cboCOBRANCA_TIPO = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCOBRANCA_SACADO = New System.Windows.Forms.TextBox()
        Me.mskCOBRANCA_INSCRICAO = New System.Windows.Forms.MaskedTextBox()
        Me.txtCOBRANCA_ESTADO = New System.Windows.Forms.TextBox()
        Me.txtCOBRANCA_CIDADE = New System.Windows.Forms.TextBox()
        Me.mskCOBRANCA_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCOBRANCA_EMAIL = New System.Windows.Forms.TextBox()
        Me.txtCOBRANCA_TELEFONE = New System.Windows.Forms.TextBox()
        Me.txtCOBRANCA_NOME = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCOBRANCA_BAIRRO = New System.Windows.Forms.TextBox()
        Me.txtCOBRANCA_LOGRADOURO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpOBRA_CRITERIOS = New System.Windows.Forms.GroupBox()
        Me.chkCONTRATO_CTR = New System.Windows.Forms.CheckBox()
        Me.chkCONTRATO_ISS = New System.Windows.Forms.CheckBox()
        Me.chkCONTRATO_NF = New System.Windows.Forms.CheckBox()
        Me.lblCONTRATO_VALOR = New System.Windows.Forms.Label()
        Me.txtCONTRATO_VALOR = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_MULTA_DIA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_MULTA_DIA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_MULTA_MORA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_MULTA_MORA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_VCTO_APOS_ENTREGA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_VCTO_APOS_ENTREGA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_RETIRADA_AUTOMATICA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_RETIRADA_AUTOMATICA = New System.Windows.Forms.TextBox()
        Me.cboTransacoes = New System.Windows.Forms.ComboBox()
        Me.lblCONTRATO_FORMA_PAGAMENTO = New System.Windows.Forms.Label()
        Me.lblCONTRATO_PERIDO_LOCACAO = New System.Windows.Forms.Label()
        Me.txtCONTRATO_PERIODO_LOCACAO = New System.Windows.Forms.TextBox()
        Me.cboCondicoes = New System.Windows.Forms.ComboBox()
        Me.lblCONTRATO_FATURAMENTO_DIAS = New System.Windows.Forms.Label()
        Me.txtID_MATERIAL = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboMateriais = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboObra = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboSolicitante = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpPEDIDO.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpOBRA.SuspendLayout()
        Me.grpOBRA_COBRANCA.SuspendLayout()
        Me.grpOBRA_CRITERIOS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID_LIGACAO
        '
        Me.txtID_LIGACAO.Enabled = False
        Me.txtID_LIGACAO.Location = New System.Drawing.Point(853, 170)
        Me.txtID_LIGACAO.MaxLength = 10
        Me.txtID_LIGACAO.Name = "txtID_LIGACAO"
        Me.txtID_LIGACAO.Size = New System.Drawing.Size(104, 20)
        Me.txtID_LIGACAO.TabIndex = 103
        Me.txtID_LIGACAO.Tag = "1"
        Me.txtID_LIGACAO.Text = "0"
        '
        'txtID_CLIENTE
        '
        Me.txtID_CLIENTE.Enabled = False
        Me.txtID_CLIENTE.Location = New System.Drawing.Point(853, 224)
        Me.txtID_CLIENTE.MaxLength = 10
        Me.txtID_CLIENTE.Name = "txtID_CLIENTE"
        Me.txtID_CLIENTE.Size = New System.Drawing.Size(104, 20)
        Me.txtID_CLIENTE.TabIndex = 104
        Me.txtID_CLIENTE.Tag = "1"
        Me.txtID_CLIENTE.Text = "0"
        '
        'txtID_OBRA
        '
        Me.txtID_OBRA.Enabled = False
        Me.txtID_OBRA.Location = New System.Drawing.Point(853, 53)
        Me.txtID_OBRA.MaxLength = 10
        Me.txtID_OBRA.Name = "txtID_OBRA"
        Me.txtID_OBRA.Size = New System.Drawing.Size(104, 20)
        Me.txtID_OBRA.TabIndex = 106
        Me.txtID_OBRA.Tag = "1"
        Me.txtID_OBRA.Text = "0"
        '
        'txtID_SOLICITANTE
        '
        Me.txtID_SOLICITANTE.Enabled = False
        Me.txtID_SOLICITANTE.Location = New System.Drawing.Point(853, 26)
        Me.txtID_SOLICITANTE.MaxLength = 10
        Me.txtID_SOLICITANTE.Name = "txtID_SOLICITANTE"
        Me.txtID_SOLICITANTE.Size = New System.Drawing.Size(104, 20)
        Me.txtID_SOLICITANTE.TabIndex = 105
        Me.txtID_SOLICITANTE.Tag = "1"
        Me.txtID_SOLICITANTE.Text = "0"
        '
        'btnCLIENTE_SALVAR
        '
        Me.btnCLIENTE_SALVAR.Location = New System.Drawing.Point(853, 276)
        Me.btnCLIENTE_SALVAR.Name = "btnCLIENTE_SALVAR"
        Me.btnCLIENTE_SALVAR.Size = New System.Drawing.Size(104, 46)
        Me.btnCLIENTE_SALVAR.TabIndex = 0
        Me.btnCLIENTE_SALVAR.Text = "NOVO"
        Me.btnCLIENTE_SALVAR.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsREGISTRO_INSERT_USUARIO, Me.stsREGISTRO_INSERT_EMISSAO, Me.stsREGISTRO_UPDATE_USUARIO, Me.stsREGISTRO_UPDATE_EMISSAO})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 547)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(965, 22)
        Me.StatusStrip1.TabIndex = 111
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsREGISTRO_INSERT_USUARIO
        '
        Me.stsREGISTRO_INSERT_USUARIO.Name = "stsREGISTRO_INSERT_USUARIO"
        Me.stsREGISTRO_INSERT_USUARIO.Size = New System.Drawing.Size(68, 17)
        Me.stsREGISTRO_INSERT_USUARIO.Text = "CADASTRO"
        '
        'stsREGISTRO_INSERT_EMISSAO
        '
        Me.stsREGISTRO_INSERT_EMISSAO.Name = "stsREGISTRO_INSERT_EMISSAO"
        Me.stsREGISTRO_INSERT_EMISSAO.Size = New System.Drawing.Size(98, 17)
        Me.stsREGISTRO_INSERT_EMISSAO.Text = "00/00/00 00:00:00"
        '
        'stsREGISTRO_UPDATE_USUARIO
        '
        Me.stsREGISTRO_UPDATE_USUARIO.Name = "stsREGISTRO_UPDATE_USUARIO"
        Me.stsREGISTRO_UPDATE_USUARIO.Size = New System.Drawing.Size(74, 17)
        Me.stsREGISTRO_UPDATE_USUARIO.Text = "ALTERAÇÃO"
        '
        'stsREGISTRO_UPDATE_EMISSAO
        '
        Me.stsREGISTRO_UPDATE_EMISSAO.Name = "stsREGISTRO_UPDATE_EMISSAO"
        Me.stsREGISTRO_UPDATE_EMISSAO.Size = New System.Drawing.Size(98, 17)
        Me.stsREGISTRO_UPDATE_EMISSAO.Text = "00/00/00 00:00:00"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 113)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(824, 418)
        Me.TabControl1.TabIndex = 112
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.grpPEDIDO)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(816, 392)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IDENTIFICAÇÃO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSolicitanteContato)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtClienteContato)
        Me.GroupBox2.Controls.Add(Me.txtClienteTelefone)
        Me.GroupBox2.Controls.Add(Me.txtClienteEmail)
        Me.GroupBox2.Controls.Add(Me.lblPRINCIPAL_CONTATO)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSolicitanteEmail)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 229)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(783, 157)
        Me.GroupBox2.TabIndex = 103
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DADOS"
        '
        'txtSolicitanteContato
        '
        Me.txtSolicitanteContato.Enabled = False
        Me.txtSolicitanteContato.Location = New System.Drawing.Point(106, 97)
        Me.txtSolicitanteContato.Name = "txtSolicitanteContato"
        Me.txtSolicitanteContato.Size = New System.Drawing.Size(295, 20)
        Me.txtSolicitanteContato.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "SOLICITANTE :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(24, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "TELEFONE :"
        '
        'txtClienteContato
        '
        Me.txtClienteContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteContato.Enabled = False
        Me.txtClienteContato.Location = New System.Drawing.Point(106, 45)
        Me.txtClienteContato.MaxLength = 100
        Me.txtClienteContato.Name = "txtClienteContato"
        Me.txtClienteContato.Size = New System.Drawing.Size(650, 20)
        Me.txtClienteContato.TabIndex = 4
        Me.txtClienteContato.Tag = "1"
        '
        'txtClienteTelefone
        '
        Me.txtClienteTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteTelefone.Enabled = False
        Me.txtClienteTelefone.Location = New System.Drawing.Point(106, 71)
        Me.txtClienteTelefone.MaxLength = 100
        Me.txtClienteTelefone.Name = "txtClienteTelefone"
        Me.txtClienteTelefone.Size = New System.Drawing.Size(295, 20)
        Me.txtClienteTelefone.TabIndex = 5
        Me.txtClienteTelefone.Tag = "1"
        '
        'txtClienteEmail
        '
        Me.txtClienteEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtClienteEmail.Enabled = False
        Me.txtClienteEmail.Location = New System.Drawing.Point(422, 71)
        Me.txtClienteEmail.MaxLength = 120
        Me.txtClienteEmail.Name = "txtClienteEmail"
        Me.txtClienteEmail.Size = New System.Drawing.Size(334, 20)
        Me.txtClienteEmail.TabIndex = 6
        Me.txtClienteEmail.Tag = "1"
        '
        'lblPRINCIPAL_CONTATO
        '
        Me.lblPRINCIPAL_CONTATO.AutoSize = True
        Me.lblPRINCIPAL_CONTATO.ForeColor = System.Drawing.Color.Black
        Me.lblPRINCIPAL_CONTATO.Location = New System.Drawing.Point(28, 45)
        Me.lblPRINCIPAL_CONTATO.Name = "lblPRINCIPAL_CONTATO"
        Me.lblPRINCIPAL_CONTATO.Size = New System.Drawing.Size(65, 13)
        Me.lblPRINCIPAL_CONTATO.TabIndex = 109
        Me.lblPRINCIPAL_CONTATO.Text = "CONTATO :"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(106, 19)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(650, 20)
        Me.txtCliente.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "CLIENTE :"
        '
        'txtSolicitanteEmail
        '
        Me.txtSolicitanteEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtSolicitanteEmail.Enabled = False
        Me.txtSolicitanteEmail.Location = New System.Drawing.Point(422, 97)
        Me.txtSolicitanteEmail.MaxLength = 120
        Me.txtSolicitanteEmail.Name = "txtSolicitanteEmail"
        Me.txtSolicitanteEmail.Size = New System.Drawing.Size(334, 20)
        Me.txtSolicitanteEmail.TabIndex = 8
        Me.txtSolicitanteEmail.Tag = "1"
        '
        'grpPEDIDO
        '
        Me.grpPEDIDO.Controls.Add(Me.txtOBRA_DESCRICAO)
        Me.grpPEDIDO.Controls.Add(Me.Label2)
        Me.grpPEDIDO.Controls.Add(Me.txtPedidoStatus)
        Me.grpPEDIDO.Controls.Add(Me.txtPedidoObservacoes)
        Me.grpPEDIDO.Controls.Add(Me.txtPedidoEmissao)
        Me.grpPEDIDO.Controls.Add(Me.Label4)
        Me.grpPEDIDO.Controls.Add(Me.Label5)
        Me.grpPEDIDO.Controls.Add(Me.txtMateriais)
        Me.grpPEDIDO.Controls.Add(Me.Label9)
        Me.grpPEDIDO.Controls.Add(Me.txtRetiraObs)
        Me.grpPEDIDO.Controls.Add(Me.txtTrocaObs)
        Me.grpPEDIDO.Controls.Add(Me.txtColocaObs)
        Me.grpPEDIDO.Controls.Add(Me.txtObservacoes)
        Me.grpPEDIDO.Controls.Add(Me.Label14)
        Me.grpPEDIDO.Controls.Add(Me.chkRetiraPrioridade)
        Me.grpPEDIDO.Controls.Add(Me.chkTrocaPrioridade)
        Me.grpPEDIDO.Controls.Add(Me.chkColocaPrioridade)
        Me.grpPEDIDO.Controls.Add(Me.dtpColoca)
        Me.grpPEDIDO.Controls.Add(Me.dtpTroca)
        Me.grpPEDIDO.Controls.Add(Me.dtpRetira)
        Me.grpPEDIDO.Controls.Add(Me.Label15)
        Me.grpPEDIDO.Controls.Add(Me.Label16)
        Me.grpPEDIDO.Controls.Add(Me.Label17)
        Me.grpPEDIDO.Controls.Add(Me.txtRetira)
        Me.grpPEDIDO.Controls.Add(Me.txtTroca)
        Me.grpPEDIDO.Controls.Add(Me.txtColoca)
        Me.grpPEDIDO.Location = New System.Drawing.Point(16, 9)
        Me.grpPEDIDO.Name = "grpPEDIDO"
        Me.grpPEDIDO.Size = New System.Drawing.Size(783, 214)
        Me.grpPEDIDO.TabIndex = 102
        Me.grpPEDIDO.TabStop = False
        Me.grpPEDIDO.Text = "PEDIDO"
        '
        'txtOBRA_DESCRICAO
        '
        Me.txtOBRA_DESCRICAO.Enabled = False
        Me.txtOBRA_DESCRICAO.Location = New System.Drawing.Point(106, 44)
        Me.txtOBRA_DESCRICAO.Name = "txtOBRA_DESCRICAO"
        Me.txtOBRA_DESCRICAO.Size = New System.Drawing.Size(650, 20)
        Me.txtOBRA_DESCRICAO.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "OBRA :"
        '
        'txtPedidoStatus
        '
        Me.txtPedidoStatus.Enabled = False
        Me.txtPedidoStatus.Location = New System.Drawing.Point(656, 19)
        Me.txtPedidoStatus.Name = "txtPedidoStatus"
        Me.txtPedidoStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtPedidoStatus.TabIndex = 1
        Me.txtPedidoStatus.Text = "N.OK"
        Me.txtPedidoStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPedidoObservacoes
        '
        Me.txtPedidoObservacoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPedidoObservacoes.Enabled = False
        Me.txtPedidoObservacoes.Location = New System.Drawing.Point(255, 18)
        Me.txtPedidoObservacoes.MaxLength = 120
        Me.txtPedidoObservacoes.Name = "txtPedidoObservacoes"
        Me.txtPedidoObservacoes.Size = New System.Drawing.Size(295, 20)
        Me.txtPedidoObservacoes.TabIndex = 0
        Me.txtPedidoObservacoes.Tag = "1"
        '
        'txtPedidoEmissao
        '
        Me.txtPedidoEmissao.Enabled = False
        Me.txtPedidoEmissao.Location = New System.Drawing.Point(106, 16)
        Me.txtPedidoEmissao.Name = "txtPedidoEmissao"
        Me.txtPedidoEmissao.Size = New System.Drawing.Size(100, 20)
        Me.txtPedidoEmissao.TabIndex = 0
        Me.txtPedidoEmissao.Text = "00/00/0000"
        Me.txtPedidoEmissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "EMISSÃO :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(591, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "STATUS :"
        '
        'txtMateriais
        '
        Me.txtMateriais.Enabled = False
        Me.txtMateriais.Location = New System.Drawing.Point(106, 175)
        Me.txtMateriais.Name = "txtMateriais"
        Me.txtMateriais.Size = New System.Drawing.Size(650, 20)
        Me.txtMateriais.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "MATERIAIS :"
        '
        'txtRetiraObs
        '
        Me.txtRetiraObs.Location = New System.Drawing.Point(422, 122)
        Me.txtRetiraObs.Name = "txtRetiraObs"
        Me.txtRetiraObs.Size = New System.Drawing.Size(334, 20)
        Me.txtRetiraObs.TabIndex = 13
        '
        'txtTrocaObs
        '
        Me.txtTrocaObs.Location = New System.Drawing.Point(422, 96)
        Me.txtTrocaObs.Name = "txtTrocaObs"
        Me.txtTrocaObs.Size = New System.Drawing.Size(334, 20)
        Me.txtTrocaObs.TabIndex = 9
        '
        'txtColocaObs
        '
        Me.txtColocaObs.Location = New System.Drawing.Point(422, 70)
        Me.txtColocaObs.Name = "txtColocaObs"
        Me.txtColocaObs.Size = New System.Drawing.Size(334, 20)
        Me.txtColocaObs.TabIndex = 5
        '
        'txtObservacoes
        '
        Me.txtObservacoes.Location = New System.Drawing.Point(106, 149)
        Me.txtObservacoes.Name = "txtObservacoes"
        Me.txtObservacoes.Size = New System.Drawing.Size(650, 20)
        Me.txtObservacoes.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "OBSERVAÇÃO :"
        '
        'chkRetiraPrioridade
        '
        Me.chkRetiraPrioridade.AutoSize = True
        Me.chkRetiraPrioridade.Location = New System.Drawing.Point(323, 122)
        Me.chkRetiraPrioridade.Name = "chkRetiraPrioridade"
        Me.chkRetiraPrioridade.Size = New System.Drawing.Size(93, 17)
        Me.chkRetiraPrioridade.TabIndex = 12
        Me.chkRetiraPrioridade.Text = "PRIORIDADE"
        Me.chkRetiraPrioridade.UseVisualStyleBackColor = True
        '
        'chkTrocaPrioridade
        '
        Me.chkTrocaPrioridade.AutoSize = True
        Me.chkTrocaPrioridade.Location = New System.Drawing.Point(323, 99)
        Me.chkTrocaPrioridade.Name = "chkTrocaPrioridade"
        Me.chkTrocaPrioridade.Size = New System.Drawing.Size(93, 17)
        Me.chkTrocaPrioridade.TabIndex = 8
        Me.chkTrocaPrioridade.Text = "PRIORIDADE"
        Me.chkTrocaPrioridade.UseVisualStyleBackColor = True
        '
        'chkColocaPrioridade
        '
        Me.chkColocaPrioridade.AutoSize = True
        Me.chkColocaPrioridade.Location = New System.Drawing.Point(323, 73)
        Me.chkColocaPrioridade.Name = "chkColocaPrioridade"
        Me.chkColocaPrioridade.Size = New System.Drawing.Size(93, 17)
        Me.chkColocaPrioridade.TabIndex = 4
        Me.chkColocaPrioridade.Text = "PRIORIDADE"
        Me.chkColocaPrioridade.UseVisualStyleBackColor = True
        '
        'dtpColoca
        '
        Me.dtpColoca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpColoca.Location = New System.Drawing.Point(212, 70)
        Me.dtpColoca.Name = "dtpColoca"
        Me.dtpColoca.Size = New System.Drawing.Size(100, 20)
        Me.dtpColoca.TabIndex = 3
        '
        'dtpTroca
        '
        Me.dtpTroca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTroca.Location = New System.Drawing.Point(212, 96)
        Me.dtpTroca.Name = "dtpTroca"
        Me.dtpTroca.Size = New System.Drawing.Size(100, 20)
        Me.dtpTroca.TabIndex = 7
        '
        'dtpRetira
        '
        Me.dtpRetira.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRetira.Location = New System.Drawing.Point(212, 122)
        Me.dtpRetira.Name = "dtpRetira"
        Me.dtpRetira.Size = New System.Drawing.Size(100, 20)
        Me.dtpRetira.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(40, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "RETIRA :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(43, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "TROCA :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(34, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "COLOCA :"
        '
        'txtRetira
        '
        Me.txtRetira.Location = New System.Drawing.Point(106, 122)
        Me.txtRetira.Name = "txtRetira"
        Me.txtRetira.Size = New System.Drawing.Size(100, 20)
        Me.txtRetira.TabIndex = 10
        Me.txtRetira.Text = "0"
        Me.txtRetira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTroca
        '
        Me.txtTroca.Location = New System.Drawing.Point(106, 96)
        Me.txtTroca.Name = "txtTroca"
        Me.txtTroca.Size = New System.Drawing.Size(100, 20)
        Me.txtTroca.TabIndex = 6
        Me.txtTroca.Text = "0"
        Me.txtTroca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtColoca
        '
        Me.txtColoca.Location = New System.Drawing.Point(106, 70)
        Me.txtColoca.Name = "txtColoca"
        Me.txtColoca.Size = New System.Drawing.Size(100, 20)
        Me.txtColoca.TabIndex = 2
        Me.txtColoca.Text = "0"
        Me.txtColoca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpOBRA)
        Me.TabPage2.Controls.Add(Me.grpOBRA_COBRANCA)
        Me.TabPage2.Controls.Add(Me.grpOBRA_CRITERIOS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(816, 392)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SOBRE A OBRA"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpOBRA
        '
        Me.grpOBRA.Controls.Add(Me.Label1)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_ESTADO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_CIDADE)
        Me.grpOBRA.Controls.Add(Me.mskOBRA_CEP)
        Me.grpOBRA.Controls.Add(Me.lblOBRA_BAIRRO)
        Me.grpOBRA.Controls.Add(Me.lblOBRA_NUMERO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_BAIRRO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_COMPLEMENTO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_NUMERO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_ENDERECO)
        Me.grpOBRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOBRA.Location = New System.Drawing.Point(6, 16)
        Me.grpOBRA.Name = "grpOBRA"
        Me.grpOBRA.Size = New System.Drawing.Size(788, 87)
        Me.grpOBRA.TabIndex = 102
        Me.grpOBRA.TabStop = False
        Me.grpOBRA.Text = "OBRA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(51, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "CEP / ENDEREÇO:"
        '
        'txtOBRA_ESTADO
        '
        Me.txtOBRA_ESTADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_ESTADO.Enabled = False
        Me.txtOBRA_ESTADO.Location = New System.Drawing.Point(731, 60)
        Me.txtOBRA_ESTADO.MaxLength = 2
        Me.txtOBRA_ESTADO.Name = "txtOBRA_ESTADO"
        Me.txtOBRA_ESTADO.Size = New System.Drawing.Size(49, 20)
        Me.txtOBRA_ESTADO.TabIndex = 7
        Me.txtOBRA_ESTADO.Tag = "1"
        '
        'txtOBRA_CIDADE
        '
        Me.txtOBRA_CIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_CIDADE.Enabled = False
        Me.txtOBRA_CIDADE.Location = New System.Drawing.Point(445, 60)
        Me.txtOBRA_CIDADE.MaxLength = 100
        Me.txtOBRA_CIDADE.Name = "txtOBRA_CIDADE"
        Me.txtOBRA_CIDADE.Size = New System.Drawing.Size(280, 20)
        Me.txtOBRA_CIDADE.TabIndex = 6
        Me.txtOBRA_CIDADE.Tag = "1"
        '
        'mskOBRA_CEP
        '
        Me.mskOBRA_CEP.Enabled = False
        Me.mskOBRA_CEP.Location = New System.Drawing.Point(169, 13)
        Me.mskOBRA_CEP.Mask = "00000-000"
        Me.mskOBRA_CEP.Name = "mskOBRA_CEP"
        Me.mskOBRA_CEP.Size = New System.Drawing.Size(104, 20)
        Me.mskOBRA_CEP.TabIndex = 1
        Me.mskOBRA_CEP.Tag = "1"
        '
        'lblOBRA_BAIRRO
        '
        Me.lblOBRA_BAIRRO.AutoSize = True
        Me.lblOBRA_BAIRRO.Location = New System.Drawing.Point(26, 67)
        Me.lblOBRA_BAIRRO.Name = "lblOBRA_BAIRRO"
        Me.lblOBRA_BAIRRO.Size = New System.Drawing.Size(127, 13)
        Me.lblOBRA_BAIRRO.TabIndex = 12
        Me.lblOBRA_BAIRRO.Text = "BAIRRO / CIDADE / UF:"
        '
        'lblOBRA_NUMERO
        '
        Me.lblOBRA_NUMERO.AutoSize = True
        Me.lblOBRA_NUMERO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOBRA_NUMERO.Location = New System.Drawing.Point(1, 43)
        Me.lblOBRA_NUMERO.Name = "lblOBRA_NUMERO"
        Me.lblOBRA_NUMERO.Size = New System.Drawing.Size(152, 13)
        Me.lblOBRA_NUMERO.TabIndex = 9
        Me.lblOBRA_NUMERO.Text = "NUMERO / COMPLEMENTO:"
        '
        'txtOBRA_BAIRRO
        '
        Me.txtOBRA_BAIRRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_BAIRRO.Enabled = False
        Me.txtOBRA_BAIRRO.Location = New System.Drawing.Point(169, 60)
        Me.txtOBRA_BAIRRO.MaxLength = 50
        Me.txtOBRA_BAIRRO.Name = "txtOBRA_BAIRRO"
        Me.txtOBRA_BAIRRO.Size = New System.Drawing.Size(270, 20)
        Me.txtOBRA_BAIRRO.TabIndex = 5
        Me.txtOBRA_BAIRRO.Tag = "1"
        '
        'txtOBRA_COMPLEMENTO
        '
        Me.txtOBRA_COMPLEMENTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_COMPLEMENTO.Enabled = False
        Me.txtOBRA_COMPLEMENTO.Location = New System.Drawing.Point(278, 36)
        Me.txtOBRA_COMPLEMENTO.MaxLength = 50
        Me.txtOBRA_COMPLEMENTO.Name = "txtOBRA_COMPLEMENTO"
        Me.txtOBRA_COMPLEMENTO.Size = New System.Drawing.Size(502, 20)
        Me.txtOBRA_COMPLEMENTO.TabIndex = 4
        Me.txtOBRA_COMPLEMENTO.Tag = "1"
        '
        'txtOBRA_NUMERO
        '
        Me.txtOBRA_NUMERO.Enabled = False
        Me.txtOBRA_NUMERO.Location = New System.Drawing.Point(169, 36)
        Me.txtOBRA_NUMERO.MaxLength = 10
        Me.txtOBRA_NUMERO.Name = "txtOBRA_NUMERO"
        Me.txtOBRA_NUMERO.Size = New System.Drawing.Size(104, 20)
        Me.txtOBRA_NUMERO.TabIndex = 3
        Me.txtOBRA_NUMERO.Tag = "1"
        '
        'txtOBRA_ENDERECO
        '
        Me.txtOBRA_ENDERECO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_ENDERECO.Enabled = False
        Me.txtOBRA_ENDERECO.Location = New System.Drawing.Point(278, 13)
        Me.txtOBRA_ENDERECO.MaxLength = 200
        Me.txtOBRA_ENDERECO.Name = "txtOBRA_ENDERECO"
        Me.txtOBRA_ENDERECO.Size = New System.Drawing.Size(502, 20)
        Me.txtOBRA_ENDERECO.TabIndex = 2
        Me.txtOBRA_ENDERECO.Tag = "1"
        '
        'grpOBRA_COBRANCA
        '
        Me.grpOBRA_COBRANCA.Controls.Add(Me.cboCOBRANCA_TIPO)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.Label11)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.txtCOBRANCA_SACADO)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.mskCOBRANCA_INSCRICAO)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.txtCOBRANCA_ESTADO)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.txtCOBRANCA_CIDADE)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.mskCOBRANCA_CEP)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.Label7)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.txtCOBRANCA_EMAIL)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.txtCOBRANCA_TELEFONE)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.txtCOBRANCA_NOME)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.Label8)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.txtCOBRANCA_BAIRRO)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.txtCOBRANCA_LOGRADOURO)
        Me.grpOBRA_COBRANCA.Controls.Add(Me.Label10)
        Me.grpOBRA_COBRANCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOBRA_COBRANCA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpOBRA_COBRANCA.Location = New System.Drawing.Point(6, 217)
        Me.grpOBRA_COBRANCA.Name = "grpOBRA_COBRANCA"
        Me.grpOBRA_COBRANCA.Size = New System.Drawing.Size(788, 116)
        Me.grpOBRA_COBRANCA.TabIndex = 103
        Me.grpOBRA_COBRANCA.TabStop = False
        Me.grpOBRA_COBRANCA.Text = "COBRANÇA"
        '
        'cboCOBRANCA_TIPO
        '
        Me.cboCOBRANCA_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCOBRANCA_TIPO.Enabled = False
        Me.cboCOBRANCA_TIPO.FormattingEnabled = True
        Me.cboCOBRANCA_TIPO.Items.AddRange(New Object() {"FISICO", "JURIDICO"})
        Me.cboCOBRANCA_TIPO.Location = New System.Drawing.Point(72, 14)
        Me.cboCOBRANCA_TIPO.Name = "cboCOBRANCA_TIPO"
        Me.cboCOBRANCA_TIPO.Size = New System.Drawing.Size(91, 21)
        Me.cboCOBRANCA_TIPO.TabIndex = 0
        Me.cboCOBRANCA_TIPO.Tag = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(10, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "SACADO:"
        '
        'txtCOBRANCA_SACADO
        '
        Me.txtCOBRANCA_SACADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_SACADO.Enabled = False
        Me.txtCOBRANCA_SACADO.Location = New System.Drawing.Point(278, 16)
        Me.txtCOBRANCA_SACADO.MaxLength = 40
        Me.txtCOBRANCA_SACADO.Name = "txtCOBRANCA_SACADO"
        Me.txtCOBRANCA_SACADO.Size = New System.Drawing.Size(502, 20)
        Me.txtCOBRANCA_SACADO.TabIndex = 2
        Me.txtCOBRANCA_SACADO.Tag = "1"
        '
        'mskCOBRANCA_INSCRICAO
        '
        Me.mskCOBRANCA_INSCRICAO.Enabled = False
        Me.mskCOBRANCA_INSCRICAO.Location = New System.Drawing.Point(169, 15)
        Me.mskCOBRANCA_INSCRICAO.Name = "mskCOBRANCA_INSCRICAO"
        Me.mskCOBRANCA_INSCRICAO.Size = New System.Drawing.Size(103, 20)
        Me.mskCOBRANCA_INSCRICAO.TabIndex = 1
        Me.mskCOBRANCA_INSCRICAO.Tag = "1"
        '
        'txtCOBRANCA_ESTADO
        '
        Me.txtCOBRANCA_ESTADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_ESTADO.Enabled = False
        Me.txtCOBRANCA_ESTADO.Location = New System.Drawing.Point(731, 65)
        Me.txtCOBRANCA_ESTADO.MaxLength = 2
        Me.txtCOBRANCA_ESTADO.Name = "txtCOBRANCA_ESTADO"
        Me.txtCOBRANCA_ESTADO.Size = New System.Drawing.Size(49, 20)
        Me.txtCOBRANCA_ESTADO.TabIndex = 7
        Me.txtCOBRANCA_ESTADO.Tag = "1"
        '
        'txtCOBRANCA_CIDADE
        '
        Me.txtCOBRANCA_CIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_CIDADE.Enabled = False
        Me.txtCOBRANCA_CIDADE.Location = New System.Drawing.Point(445, 65)
        Me.txtCOBRANCA_CIDADE.MaxLength = 15
        Me.txtCOBRANCA_CIDADE.Name = "txtCOBRANCA_CIDADE"
        Me.txtCOBRANCA_CIDADE.Size = New System.Drawing.Size(280, 20)
        Me.txtCOBRANCA_CIDADE.TabIndex = 6
        Me.txtCOBRANCA_CIDADE.Tag = "1"
        '
        'mskCOBRANCA_CEP
        '
        Me.mskCOBRANCA_CEP.Enabled = False
        Me.mskCOBRANCA_CEP.Location = New System.Drawing.Point(169, 40)
        Me.mskCOBRANCA_CEP.Mask = "00000-000"
        Me.mskCOBRANCA_CEP.Name = "mskCOBRANCA_CEP"
        Me.mskCOBRANCA_CEP.Size = New System.Drawing.Size(103, 20)
        Me.mskCOBRANCA_CEP.TabIndex = 3
        Me.mskCOBRANCA_CEP.Tag = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(-2, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "NOME / TELEFONE / E-MAIL:"
        '
        'txtCOBRANCA_EMAIL
        '
        Me.txtCOBRANCA_EMAIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCOBRANCA_EMAIL.Enabled = False
        Me.txtCOBRANCA_EMAIL.Location = New System.Drawing.Point(559, 89)
        Me.txtCOBRANCA_EMAIL.MaxLength = 120
        Me.txtCOBRANCA_EMAIL.Name = "txtCOBRANCA_EMAIL"
        Me.txtCOBRANCA_EMAIL.Size = New System.Drawing.Size(221, 20)
        Me.txtCOBRANCA_EMAIL.TabIndex = 10
        Me.txtCOBRANCA_EMAIL.Tag = "1"
        '
        'txtCOBRANCA_TELEFONE
        '
        Me.txtCOBRANCA_TELEFONE.Enabled = False
        Me.txtCOBRANCA_TELEFONE.Location = New System.Drawing.Point(366, 89)
        Me.txtCOBRANCA_TELEFONE.MaxLength = 50
        Me.txtCOBRANCA_TELEFONE.Name = "txtCOBRANCA_TELEFONE"
        Me.txtCOBRANCA_TELEFONE.Size = New System.Drawing.Size(187, 20)
        Me.txtCOBRANCA_TELEFONE.TabIndex = 9
        Me.txtCOBRANCA_TELEFONE.Tag = "1"
        '
        'txtCOBRANCA_NOME
        '
        Me.txtCOBRANCA_NOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_NOME.Enabled = False
        Me.txtCOBRANCA_NOME.Location = New System.Drawing.Point(169, 89)
        Me.txtCOBRANCA_NOME.MaxLength = 15
        Me.txtCOBRANCA_NOME.Name = "txtCOBRANCA_NOME"
        Me.txtCOBRANCA_NOME.Size = New System.Drawing.Size(187, 20)
        Me.txtCOBRANCA_NOME.TabIndex = 8
        Me.txtCOBRANCA_NOME.Tag = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(26, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "BAIRRO / CIDADE / UF:"
        '
        'txtCOBRANCA_BAIRRO
        '
        Me.txtCOBRANCA_BAIRRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_BAIRRO.Enabled = False
        Me.txtCOBRANCA_BAIRRO.Location = New System.Drawing.Point(169, 64)
        Me.txtCOBRANCA_BAIRRO.MaxLength = 12
        Me.txtCOBRANCA_BAIRRO.Name = "txtCOBRANCA_BAIRRO"
        Me.txtCOBRANCA_BAIRRO.Size = New System.Drawing.Size(270, 20)
        Me.txtCOBRANCA_BAIRRO.TabIndex = 5
        Me.txtCOBRANCA_BAIRRO.Tag = "1"
        '
        'txtCOBRANCA_LOGRADOURO
        '
        Me.txtCOBRANCA_LOGRADOURO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_LOGRADOURO.Enabled = False
        Me.txtCOBRANCA_LOGRADOURO.Location = New System.Drawing.Point(278, 40)
        Me.txtCOBRANCA_LOGRADOURO.MaxLength = 40
        Me.txtCOBRANCA_LOGRADOURO.Name = "txtCOBRANCA_LOGRADOURO"
        Me.txtCOBRANCA_LOGRADOURO.Size = New System.Drawing.Size(502, 20)
        Me.txtCOBRANCA_LOGRADOURO.TabIndex = 4
        Me.txtCOBRANCA_LOGRADOURO.Tag = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(10, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "CEP / RUA / NUM / COMP:"
        '
        'grpOBRA_CRITERIOS
        '
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.chkCONTRATO_CTR)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.chkCONTRATO_ISS)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.chkCONTRATO_NF)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_VALOR)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.txtCONTRATO_VALOR)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_MULTA_DIA)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.txtCONTRATO_MULTA_DIA)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_MULTA_MORA)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.txtCONTRATO_MULTA_MORA)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_VCTO_APOS_ENTREGA)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.txtCONTRATO_VCTO_APOS_ENTREGA)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_RETIRADA_AUTOMATICA)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.txtCONTRATO_RETIRADA_AUTOMATICA)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.cboTransacoes)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_FORMA_PAGAMENTO)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_PERIDO_LOCACAO)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.txtCONTRATO_PERIODO_LOCACAO)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.cboCondicoes)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_FATURAMENTO_DIAS)
        Me.grpOBRA_CRITERIOS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpOBRA_CRITERIOS.Location = New System.Drawing.Point(6, 109)
        Me.grpOBRA_CRITERIOS.Name = "grpOBRA_CRITERIOS"
        Me.grpOBRA_CRITERIOS.Size = New System.Drawing.Size(788, 102)
        Me.grpOBRA_CRITERIOS.TabIndex = 101
        Me.grpOBRA_CRITERIOS.TabStop = False
        Me.grpOBRA_CRITERIOS.Text = "CRITERIOS"
        '
        'chkCONTRATO_CTR
        '
        Me.chkCONTRATO_CTR.AutoSize = True
        Me.chkCONTRATO_CTR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCONTRATO_CTR.Enabled = False
        Me.chkCONTRATO_CTR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkCONTRATO_CTR.Location = New System.Drawing.Point(315, 72)
        Me.chkCONTRATO_CTR.Name = "chkCONTRATO_CTR"
        Me.chkCONTRATO_CTR.Size = New System.Drawing.Size(51, 17)
        Me.chkCONTRATO_CTR.TabIndex = 11
        Me.chkCONTRATO_CTR.Text = "CTR:"
        Me.chkCONTRATO_CTR.UseVisualStyleBackColor = True
        '
        'chkCONTRATO_ISS
        '
        Me.chkCONTRATO_ISS.AutoSize = True
        Me.chkCONTRATO_ISS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCONTRATO_ISS.Enabled = False
        Me.chkCONTRATO_ISS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkCONTRATO_ISS.Location = New System.Drawing.Point(232, 72)
        Me.chkCONTRATO_ISS.Name = "chkCONTRATO_ISS"
        Me.chkCONTRATO_ISS.Size = New System.Drawing.Size(46, 17)
        Me.chkCONTRATO_ISS.TabIndex = 10
        Me.chkCONTRATO_ISS.Text = "ISS:"
        Me.chkCONTRATO_ISS.UseVisualStyleBackColor = True
        '
        'chkCONTRATO_NF
        '
        Me.chkCONTRATO_NF.AutoSize = True
        Me.chkCONTRATO_NF.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCONTRATO_NF.Enabled = False
        Me.chkCONTRATO_NF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkCONTRATO_NF.Location = New System.Drawing.Point(109, 72)
        Me.chkCONTRATO_NF.Name = "chkCONTRATO_NF"
        Me.chkCONTRATO_NF.Size = New System.Drawing.Size(98, 17)
        Me.chkCONTRATO_NF.TabIndex = 9
        Me.chkCONTRATO_NF.Text = "NOTA FISCAL:"
        Me.chkCONTRATO_NF.UseVisualStyleBackColor = True
        '
        'lblCONTRATO_VALOR
        '
        Me.lblCONTRATO_VALOR.AutoSize = True
        Me.lblCONTRATO_VALOR.Enabled = False
        Me.lblCONTRATO_VALOR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCONTRATO_VALOR.Location = New System.Drawing.Point(625, 18)
        Me.lblCONTRATO_VALOR.Name = "lblCONTRATO_VALOR"
        Me.lblCONTRATO_VALOR.Size = New System.Drawing.Size(46, 13)
        Me.lblCONTRATO_VALOR.TabIndex = 89
        Me.lblCONTRATO_VALOR.Text = "VALOR:"
        Me.lblCONTRATO_VALOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_VALOR
        '
        Me.txtCONTRATO_VALOR.Enabled = False
        Me.txtCONTRATO_VALOR.Location = New System.Drawing.Point(672, 15)
        Me.txtCONTRATO_VALOR.Name = "txtCONTRATO_VALOR"
        Me.txtCONTRATO_VALOR.Size = New System.Drawing.Size(89, 20)
        Me.txtCONTRATO_VALOR.TabIndex = 6
        Me.txtCONTRATO_VALOR.Tag = "1"
        Me.txtCONTRATO_VALOR.Text = "0,00"
        Me.txtCONTRATO_VALOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCONTRATO_MULTA_DIA
        '
        Me.lblCONTRATO_MULTA_DIA.AutoSize = True
        Me.lblCONTRATO_MULTA_DIA.Enabled = False
        Me.lblCONTRATO_MULTA_DIA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCONTRATO_MULTA_DIA.Location = New System.Drawing.Point(603, 71)
        Me.lblCONTRATO_MULTA_DIA.Name = "lblCONTRATO_MULTA_DIA"
        Me.lblCONTRATO_MULTA_DIA.Size = New System.Drawing.Size(68, 13)
        Me.lblCONTRATO_MULTA_DIA.TabIndex = 88
        Me.lblCONTRATO_MULTA_DIA.Text = "MULTA DIA:"
        Me.lblCONTRATO_MULTA_DIA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_MULTA_DIA
        '
        Me.txtCONTRATO_MULTA_DIA.Enabled = False
        Me.txtCONTRATO_MULTA_DIA.Location = New System.Drawing.Point(672, 68)
        Me.txtCONTRATO_MULTA_DIA.Name = "txtCONTRATO_MULTA_DIA"
        Me.txtCONTRATO_MULTA_DIA.Size = New System.Drawing.Size(89, 20)
        Me.txtCONTRATO_MULTA_DIA.TabIndex = 8
        Me.txtCONTRATO_MULTA_DIA.Tag = "1"
        Me.txtCONTRATO_MULTA_DIA.Text = "0,00"
        Me.txtCONTRATO_MULTA_DIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCONTRATO_MULTA_MORA
        '
        Me.lblCONTRATO_MULTA_MORA.AutoSize = True
        Me.lblCONTRATO_MULTA_MORA.Enabled = False
        Me.lblCONTRATO_MULTA_MORA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCONTRATO_MULTA_MORA.Location = New System.Drawing.Point(589, 44)
        Me.lblCONTRATO_MULTA_MORA.Name = "lblCONTRATO_MULTA_MORA"
        Me.lblCONTRATO_MULTA_MORA.Size = New System.Drawing.Size(82, 13)
        Me.lblCONTRATO_MULTA_MORA.TabIndex = 87
        Me.lblCONTRATO_MULTA_MORA.Text = "MULTA MORA:"
        Me.lblCONTRATO_MULTA_MORA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_MULTA_MORA
        '
        Me.txtCONTRATO_MULTA_MORA.Enabled = False
        Me.txtCONTRATO_MULTA_MORA.Location = New System.Drawing.Point(672, 41)
        Me.txtCONTRATO_MULTA_MORA.Name = "txtCONTRATO_MULTA_MORA"
        Me.txtCONTRATO_MULTA_MORA.Size = New System.Drawing.Size(89, 20)
        Me.txtCONTRATO_MULTA_MORA.TabIndex = 7
        Me.txtCONTRATO_MULTA_MORA.Tag = "1"
        Me.txtCONTRATO_MULTA_MORA.Text = "0,00"
        Me.txtCONTRATO_MULTA_MORA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCONTRATO_VCTO_APOS_ENTREGA
        '
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.AutoSize = True
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Enabled = False
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Location = New System.Drawing.Point(397, 71)
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Name = "lblCONTRATO_VCTO_APOS_ENTREGA"
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Size = New System.Drawing.Size(81, 13)
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.TabIndex = 86
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Text = "VENCIMENTO:"
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_VCTO_APOS_ENTREGA
        '
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Enabled = False
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Location = New System.Drawing.Point(480, 68)
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Name = "txtCONTRATO_VCTO_APOS_ENTREGA"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Size = New System.Drawing.Size(89, 20)
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.TabIndex = 5
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Tag = "1"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Text = "0"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCONTRATO_RETIRADA_AUTOMATICA
        '
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.AutoSize = True
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Enabled = False
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Location = New System.Drawing.Point(414, 44)
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Name = "lblCONTRATO_RETIRADA_AUTOMATICA"
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Size = New System.Drawing.Size(65, 13)
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.TabIndex = 85
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Text = "RETIRADA:"
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_RETIRADA_AUTOMATICA
        '
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Enabled = False
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Location = New System.Drawing.Point(480, 41)
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Name = "txtCONTRATO_RETIRADA_AUTOMATICA"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Size = New System.Drawing.Size(89, 20)
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.TabIndex = 4
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Tag = "1"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text = "0"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboTransacoes
        '
        Me.cboTransacoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransacoes.Enabled = False
        Me.cboTransacoes.FormattingEnabled = True
        Me.cboTransacoes.Location = New System.Drawing.Point(169, 14)
        Me.cboTransacoes.Name = "cboTransacoes"
        Me.cboTransacoes.Size = New System.Drawing.Size(201, 21)
        Me.cboTransacoes.TabIndex = 1
        Me.cboTransacoes.Tag = "1"
        '
        'lblCONTRATO_FORMA_PAGAMENTO
        '
        Me.lblCONTRATO_FORMA_PAGAMENTO.AutoSize = True
        Me.lblCONTRATO_FORMA_PAGAMENTO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCONTRATO_FORMA_PAGAMENTO.Location = New System.Drawing.Point(72, 17)
        Me.lblCONTRATO_FORMA_PAGAMENTO.Name = "lblCONTRATO_FORMA_PAGAMENTO"
        Me.lblCONTRATO_FORMA_PAGAMENTO.Size = New System.Drawing.Size(81, 13)
        Me.lblCONTRATO_FORMA_PAGAMENTO.TabIndex = 84
        Me.lblCONTRATO_FORMA_PAGAMENTO.Text = "PAGAMENTO :"
        Me.lblCONTRATO_FORMA_PAGAMENTO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCONTRATO_PERIDO_LOCACAO
        '
        Me.lblCONTRATO_PERIDO_LOCACAO.AutoSize = True
        Me.lblCONTRATO_PERIDO_LOCACAO.Enabled = False
        Me.lblCONTRATO_PERIDO_LOCACAO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCONTRATO_PERIDO_LOCACAO.Location = New System.Drawing.Point(419, 18)
        Me.lblCONTRATO_PERIDO_LOCACAO.Name = "lblCONTRATO_PERIDO_LOCACAO"
        Me.lblCONTRATO_PERIDO_LOCACAO.Size = New System.Drawing.Size(60, 13)
        Me.lblCONTRATO_PERIDO_LOCACAO.TabIndex = 83
        Me.lblCONTRATO_PERIDO_LOCACAO.Text = "LOCAÇÃO:"
        Me.lblCONTRATO_PERIDO_LOCACAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_PERIODO_LOCACAO
        '
        Me.txtCONTRATO_PERIODO_LOCACAO.Enabled = False
        Me.txtCONTRATO_PERIODO_LOCACAO.Location = New System.Drawing.Point(480, 15)
        Me.txtCONTRATO_PERIODO_LOCACAO.Name = "txtCONTRATO_PERIODO_LOCACAO"
        Me.txtCONTRATO_PERIODO_LOCACAO.Size = New System.Drawing.Size(89, 20)
        Me.txtCONTRATO_PERIODO_LOCACAO.TabIndex = 3
        Me.txtCONTRATO_PERIODO_LOCACAO.Tag = "1"
        Me.txtCONTRATO_PERIODO_LOCACAO.Text = "0"
        Me.txtCONTRATO_PERIODO_LOCACAO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboCondicoes
        '
        Me.cboCondicoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondicoes.FormattingEnabled = True
        Me.cboCondicoes.Location = New System.Drawing.Point(169, 41)
        Me.cboCondicoes.Name = "cboCondicoes"
        Me.cboCondicoes.Size = New System.Drawing.Size(201, 21)
        Me.cboCondicoes.TabIndex = 2
        Me.cboCondicoes.Tag = "1"
        '
        'lblCONTRATO_FATURAMENTO_DIAS
        '
        Me.lblCONTRATO_FATURAMENTO_DIAS.AutoSize = True
        Me.lblCONTRATO_FATURAMENTO_DIAS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCONTRATO_FATURAMENTO_DIAS.Location = New System.Drawing.Point(58, 44)
        Me.lblCONTRATO_FATURAMENTO_DIAS.Name = "lblCONTRATO_FATURAMENTO_DIAS"
        Me.lblCONTRATO_FATURAMENTO_DIAS.Size = New System.Drawing.Size(95, 13)
        Me.lblCONTRATO_FATURAMENTO_DIAS.TabIndex = 82
        Me.lblCONTRATO_FATURAMENTO_DIAS.Text = "FATURAMENTO :"
        Me.lblCONTRATO_FATURAMENTO_DIAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID_MATERIAL
        '
        Me.txtID_MATERIAL.Enabled = False
        Me.txtID_MATERIAL.Location = New System.Drawing.Point(853, 80)
        Me.txtID_MATERIAL.MaxLength = 10
        Me.txtID_MATERIAL.Name = "txtID_MATERIAL"
        Me.txtID_MATERIAL.Size = New System.Drawing.Size(104, 20)
        Me.txtID_MATERIAL.TabIndex = 113
        Me.txtID_MATERIAL.Tag = "1"
        Me.txtID_MATERIAL.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboMateriais)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cboObra)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cboSolicitante)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 98)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELEÇÃO"
        '
        'cboMateriais
        '
        Me.cboMateriais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMateriais.FormattingEnabled = True
        Me.cboMateriais.Location = New System.Drawing.Point(113, 69)
        Me.cboMateriais.Name = "cboMateriais"
        Me.cboMateriais.Size = New System.Drawing.Size(650, 21)
        Me.cboMateriais.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(36, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 124
        Me.Label18.Text = "MATERIAIS :"
        '
        'cboObra
        '
        Me.cboObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboObra.FormattingEnabled = True
        Me.cboObra.Location = New System.Drawing.Point(113, 42)
        Me.cboObra.Name = "cboObra"
        Me.cboObra.Size = New System.Drawing.Size(650, 21)
        Me.cboObra.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(17, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 13)
        Me.Label23.TabIndex = 118
        Me.Label23.Text = "SOLICITANTES :"
        '
        'cboSolicitante
        '
        Me.cboSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSolicitante.FormattingEnabled = True
        Me.cboSolicitante.Location = New System.Drawing.Point(113, 15)
        Me.cboSolicitante.Name = "cboSolicitante"
        Me.cboSolicitante.Size = New System.Drawing.Size(650, 21)
        Me.cboSolicitante.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(57, 45)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 120
        Me.Label24.Text = "OBRAS :"
        '
        'cadastroLigacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 569)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtID_MATERIAL)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCLIENTE_SALVAR)
        Me.Controls.Add(Me.txtID_OBRA)
        Me.Controls.Add(Me.txtID_SOLICITANTE)
        Me.Controls.Add(Me.txtID_CLIENTE)
        Me.Controls.Add(Me.txtID_LIGACAO)
        Me.Name = "cadastroLigacao"
        Me.Text = "SOLICITAÇÃO DE CAÇAMBA"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpPEDIDO.ResumeLayout(False)
        Me.grpPEDIDO.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpOBRA.ResumeLayout(False)
        Me.grpOBRA.PerformLayout()
        Me.grpOBRA_COBRANCA.ResumeLayout(False)
        Me.grpOBRA_COBRANCA.PerformLayout()
        Me.grpOBRA_CRITERIOS.ResumeLayout(False)
        Me.grpOBRA_CRITERIOS.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID_LIGACAO As System.Windows.Forms.TextBox
    Friend WithEvents txtID_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents txtID_OBRA As System.Windows.Forms.TextBox
    Friend WithEvents txtID_SOLICITANTE As System.Windows.Forms.TextBox
    Friend WithEvents btnCLIENTE_SALVAR As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsREGISTRO_INSERT_USUARIO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_INSERT_EMISSAO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_UPDATE_USUARIO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_UPDATE_EMISSAO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grpPEDIDO As System.Windows.Forms.GroupBox
    Friend WithEvents txtRetiraObs As System.Windows.Forms.TextBox
    Friend WithEvents txtTrocaObs As System.Windows.Forms.TextBox
    Friend WithEvents txtColocaObs As System.Windows.Forms.TextBox
    Friend WithEvents txtObservacoes As System.Windows.Forms.TextBox
    Friend WithEvents chkRetiraPrioridade As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrocaPrioridade As System.Windows.Forms.CheckBox
    Friend WithEvents chkColocaPrioridade As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpColoca As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTroca As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRetira As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRetira As System.Windows.Forms.TextBox
    Friend WithEvents txtTroca As System.Windows.Forms.TextBox
    Friend WithEvents txtColoca As System.Windows.Forms.TextBox
    Friend WithEvents grpOBRA As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOBRA_ESTADO As System.Windows.Forms.TextBox
    Friend WithEvents txtOBRA_CIDADE As System.Windows.Forms.TextBox
    Friend WithEvents mskOBRA_CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblOBRA_BAIRRO As System.Windows.Forms.Label
    Friend WithEvents lblOBRA_NUMERO As System.Windows.Forms.Label
    Friend WithEvents txtOBRA_BAIRRO As System.Windows.Forms.TextBox
    Friend WithEvents txtOBRA_COMPLEMENTO As System.Windows.Forms.TextBox
    Friend WithEvents txtOBRA_NUMERO As System.Windows.Forms.TextBox
    Friend WithEvents txtOBRA_ENDERECO As System.Windows.Forms.TextBox
    Friend WithEvents grpOBRA_COBRANCA As System.Windows.Forms.GroupBox
    Friend WithEvents cboCOBRANCA_TIPO As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCOBRANCA_SACADO As System.Windows.Forms.TextBox
    Friend WithEvents mskCOBRANCA_INSCRICAO As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCOBRANCA_ESTADO As System.Windows.Forms.TextBox
    Friend WithEvents txtCOBRANCA_CIDADE As System.Windows.Forms.TextBox
    Friend WithEvents mskCOBRANCA_CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCOBRANCA_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents txtCOBRANCA_TELEFONE As System.Windows.Forms.TextBox
    Friend WithEvents txtCOBRANCA_NOME As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCOBRANCA_BAIRRO As System.Windows.Forms.TextBox
    Friend WithEvents txtCOBRANCA_LOGRADOURO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grpOBRA_CRITERIOS As System.Windows.Forms.GroupBox
    Friend WithEvents chkCONTRATO_CTR As System.Windows.Forms.CheckBox
    Friend WithEvents chkCONTRATO_ISS As System.Windows.Forms.CheckBox
    Friend WithEvents chkCONTRATO_NF As System.Windows.Forms.CheckBox
    Friend WithEvents lblCONTRATO_VALOR As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_VALOR As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_MULTA_DIA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_MULTA_DIA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_MULTA_MORA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_MULTA_MORA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_VCTO_APOS_ENTREGA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_VCTO_APOS_ENTREGA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_RETIRADA_AUTOMATICA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_RETIRADA_AUTOMATICA As System.Windows.Forms.TextBox
    Friend WithEvents cboTransacoes As System.Windows.Forms.ComboBox
    Friend WithEvents lblCONTRATO_FORMA_PAGAMENTO As System.Windows.Forms.Label
    Friend WithEvents lblCONTRATO_PERIDO_LOCACAO As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_PERIODO_LOCACAO As System.Windows.Forms.TextBox
    Friend WithEvents cboCondicoes As System.Windows.Forms.ComboBox
    Friend WithEvents lblCONTRATO_FATURAMENTO_DIAS As System.Windows.Forms.Label
    Friend WithEvents txtID_MATERIAL As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboObra As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboSolicitante As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboMateriais As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSolicitanteContato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPedidoObservacoes As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtClienteContato As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPRINCIPAL_CONTATO As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSolicitanteEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMateriais As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPedidoEmissao As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOBRA_DESCRICAO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPedidoStatus As System.Windows.Forms.TextBox
End Class

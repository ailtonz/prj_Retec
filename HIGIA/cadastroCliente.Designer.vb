<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastroCliente
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
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.btnCONTATO_SALVAR = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCONTATO_OBSERVACAO = New System.Windows.Forms.TextBox()
        Me.grbCLIENTE_PRINCIPAL_CONTATOS = New System.Windows.Forms.GroupBox()
        Me.lblCONTATO_EMAIL = New System.Windows.Forms.Label()
        Me.lblCONTATO_TELEFONE = New System.Windows.Forms.Label()
        Me.lblCONTATO_NOME = New System.Windows.Forms.Label()
        Me.txtCONTATO_EMAIL = New System.Windows.Forms.TextBox()
        Me.txtCONTATO_TELEFONE = New System.Windows.Forms.TextBox()
        Me.txtCONTATO_NOME = New System.Windows.Forms.TextBox()
        Me.pgContatos = New System.Windows.Forms.TabPage()
        Me.tsContatos = New System.Windows.Forms.ToolStrip()
        Me.txtProcurarContato = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdProcurarContato = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNovoContato = New System.Windows.Forms.ToolStripButton()
        Me.dgvCONTATOS = New System.Windows.Forms.DataGridView()
        Me.pgHistorico = New System.Windows.Forms.TabPage()
        Me.tsHistorico = New System.Windows.Forms.ToolStrip()
        Me.txtProcurarHistorico = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdProcurarHistorico = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNovoHistorico = New System.Windows.Forms.ToolStripButton()
        Me.dgvHISTORICOS = New System.Windows.Forms.DataGridView()
        Me.grbCLIENTE_PRINCIPAL_HISTORICO = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnHISTORICO_SALVAR = New System.Windows.Forms.Button()
        Me.txtHISTORICO_DADOS = New System.Windows.Forms.TextBox()
        Me.lblPRINCIPAL_BAIRRO = New System.Windows.Forms.Label()
        Me.pgObras = New System.Windows.Forms.TabPage()
        Me.tsObras = New System.Windows.Forms.ToolStrip()
        Me.txtProcurarObra = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdProcurarObra = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNovoObra = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAtualizarObras = New System.Windows.Forms.ToolStripButton()
        Me.dgvOBRAS = New System.Windows.Forms.DataGridView()
        Me.lblPRINCIPAL_NUMERO = New System.Windows.Forms.Label()
        Me.txtPRINCIPAL_BAIRRO = New System.Windows.Forms.TextBox()
        Me.txtPRINCIPAL_COMPLEMENTO = New System.Windows.Forms.TextBox()
        Me.grbCLIENTE_PRINCIPAL_CONTATO = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPRINCIPAL_CONTATO = New System.Windows.Forms.TextBox()
        Me.txtPRINCIPAL_TELEFONE = New System.Windows.Forms.TextBox()
        Me.txtPRINCIPAL_EMAIL = New System.Windows.Forms.TextBox()
        Me.lblPRINCIPAL_CONTATO = New System.Windows.Forms.Label()
        Me.txtPRINCIPAL_NUMERO = New System.Windows.Forms.TextBox()
        Me.txtPRINCIPAL_ENDERECO = New System.Windows.Forms.TextBox()
        Me.mskPRINCIPAL_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCADASTRO_PROPAGANDA = New System.Windows.Forms.ComboBox()
        Me.txtPRINCIPAL_CIDADE = New System.Windows.Forms.TextBox()
        Me.txtPRINCIPAL_ESTADO = New System.Windows.Forms.TextBox()
        Me.btnCLIENTE_PESQUISAR = New System.Windows.Forms.Button()
        Me.btnCLIENTE_SALVAR = New System.Windows.Forms.Button()
        Me.pgPrincipal = New System.Windows.Forms.TabPage()
        Me.grbObs = New System.Windows.Forms.GroupBox()
        Me.txtCADASTRO_OBSERVACAO = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCADASTRO_OBSERVACAO = New System.Windows.Forms.Label()
        Me.lblCADASTRO_STATUS = New System.Windows.Forms.Label()
        Me.cboSTATUS_OBSERVACAO = New System.Windows.Forms.ComboBox()
        Me.cboSTATUS = New System.Windows.Forms.ComboBox()
        Me.grbCLIENTE_ENDERECO = New System.Windows.Forms.GroupBox()
        Me.btnEnderecoPrincipal = New System.Windows.Forms.Button()
        Me.tabDADOS = New System.Windows.Forms.TabControl()
        Me.lblPRINCIPAL_NOME = New System.Windows.Forms.Label()
        Me.txtPRINCIPAL_NOME = New System.Windows.Forms.TextBox()
        Me.cboCADASTRO_TIPO = New System.Windows.Forms.ComboBox()
        Me.lblCADASTRO_TIPO = New System.Windows.Forms.Label()
        Me.lblCNPJ_CPF = New System.Windows.Forms.Label()
        Me.lblNOME_FANTASIA = New System.Windows.Forms.Label()
        Me.txtPRINCIPAL_NOME_FANTASIA = New System.Windows.Forms.TextBox()
        Me.mskCNPJ_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskIE_RG = New System.Windows.Forms.MaskedTextBox()
        Me.grbCLIENTE_DADOS = New System.Windows.Forms.GroupBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtID_CLIENTE = New System.Windows.Forms.TextBox()
        Me.txtID_OBRA = New System.Windows.Forms.TextBox()
        Me.txtID_CONTATO = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtID_HISTORICO = New System.Windows.Forms.TextBox()
        Me.chkRelacao = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsREGISTRO_INSERT_USUARIO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_INSERT_EMISSAO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_UPDATE_USUARIO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_UPDATE_EMISSAO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.SuspendLayout()
        Me.pgContatos.SuspendLayout()
        Me.tsContatos.SuspendLayout()
        CType(Me.dgvCONTATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgHistorico.SuspendLayout()
        Me.tsHistorico.SuspendLayout()
        CType(Me.dgvHISTORICOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.SuspendLayout()
        Me.pgObras.SuspendLayout()
        Me.tsObras.SuspendLayout()
        CType(Me.dgvOBRAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCLIENTE_PRINCIPAL_CONTATO.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pgPrincipal.SuspendLayout()
        Me.grbObs.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grbCLIENTE_ENDERECO.SuspendLayout()
        Me.tabDADOS.SuspendLayout()
        Me.grbCLIENTE_DADOS.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(801, 265)
        '
        'btnCONTATO_SALVAR
        '
        Me.btnCONTATO_SALVAR.Location = New System.Drawing.Point(670, 67)
        Me.btnCONTATO_SALVAR.Name = "btnCONTATO_SALVAR"
        Me.btnCONTATO_SALVAR.Size = New System.Drawing.Size(125, 23)
        Me.btnCONTATO_SALVAR.TabIndex = 80
        Me.btnCONTATO_SALVAR.Text = "SALVAR"
        Me.btnCONTATO_SALVAR.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(434, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "OBSERVAÇÕES :"
        '
        'txtCONTATO_OBSERVACAO
        '
        Me.txtCONTATO_OBSERVACAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCONTATO_OBSERVACAO.Location = New System.Drawing.Point(533, 41)
        Me.txtCONTATO_OBSERVACAO.MaxLength = 120
        Me.txtCONTATO_OBSERVACAO.Name = "txtCONTATO_OBSERVACAO"
        Me.txtCONTATO_OBSERVACAO.Size = New System.Drawing.Size(262, 20)
        Me.txtCONTATO_OBSERVACAO.TabIndex = 31
        Me.txtCONTATO_OBSERVACAO.Tag = "1"
        '
        'grbCLIENTE_PRINCIPAL_CONTATOS
        '
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.btnCONTATO_SALVAR)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.Label12)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.txtCONTATO_OBSERVACAO)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.lblCONTATO_EMAIL)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.lblCONTATO_TELEFONE)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.lblCONTATO_NOME)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.txtCONTATO_EMAIL)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.txtCONTATO_TELEFONE)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Controls.Add(Me.txtCONTATO_NOME)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Location = New System.Drawing.Point(6, 259)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Name = "grbCLIENTE_PRINCIPAL_CONTATOS"
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Size = New System.Drawing.Size(801, 97)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.TabIndex = 75
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.TabStop = False
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.Text = "CONTATO"
        '
        'lblCONTATO_EMAIL
        '
        Me.lblCONTATO_EMAIL.AutoSize = True
        Me.lblCONTATO_EMAIL.Location = New System.Drawing.Point(62, 44)
        Me.lblCONTATO_EMAIL.Name = "lblCONTATO_EMAIL"
        Me.lblCONTATO_EMAIL.Size = New System.Drawing.Size(48, 13)
        Me.lblCONTATO_EMAIL.TabIndex = 29
        Me.lblCONTATO_EMAIL.Text = "E-MAIL :"
        '
        'lblCONTATO_TELEFONE
        '
        Me.lblCONTATO_TELEFONE.AutoSize = True
        Me.lblCONTATO_TELEFONE.Location = New System.Drawing.Point(458, 18)
        Me.lblCONTATO_TELEFONE.Name = "lblCONTATO_TELEFONE"
        Me.lblCONTATO_TELEFONE.Size = New System.Drawing.Size(69, 13)
        Me.lblCONTATO_TELEFONE.TabIndex = 28
        Me.lblCONTATO_TELEFONE.Text = "TELEFONE :"
        '
        'lblCONTATO_NOME
        '
        Me.lblCONTATO_NOME.AutoSize = True
        Me.lblCONTATO_NOME.Location = New System.Drawing.Point(65, 18)
        Me.lblCONTATO_NOME.Name = "lblCONTATO_NOME"
        Me.lblCONTATO_NOME.Size = New System.Drawing.Size(45, 13)
        Me.lblCONTATO_NOME.TabIndex = 21
        Me.lblCONTATO_NOME.Text = "NOME :"
        '
        'txtCONTATO_EMAIL
        '
        Me.txtCONTATO_EMAIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCONTATO_EMAIL.Location = New System.Drawing.Point(116, 41)
        Me.txtCONTATO_EMAIL.MaxLength = 120
        Me.txtCONTATO_EMAIL.Name = "txtCONTATO_EMAIL"
        Me.txtCONTATO_EMAIL.Size = New System.Drawing.Size(262, 20)
        Me.txtCONTATO_EMAIL.TabIndex = 27
        Me.txtCONTATO_EMAIL.Tag = "1"
        '
        'txtCONTATO_TELEFONE
        '
        Me.txtCONTATO_TELEFONE.Location = New System.Drawing.Point(533, 15)
        Me.txtCONTATO_TELEFONE.MaxLength = 100
        Me.txtCONTATO_TELEFONE.Name = "txtCONTATO_TELEFONE"
        Me.txtCONTATO_TELEFONE.Size = New System.Drawing.Size(262, 20)
        Me.txtCONTATO_TELEFONE.TabIndex = 26
        Me.txtCONTATO_TELEFONE.Tag = "1"
        '
        'txtCONTATO_NOME
        '
        Me.txtCONTATO_NOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCONTATO_NOME.Location = New System.Drawing.Point(116, 15)
        Me.txtCONTATO_NOME.MaxLength = 20
        Me.txtCONTATO_NOME.Name = "txtCONTATO_NOME"
        Me.txtCONTATO_NOME.Size = New System.Drawing.Size(262, 20)
        Me.txtCONTATO_NOME.TabIndex = 25
        Me.txtCONTATO_NOME.Tag = "1"
        '
        'pgContatos
        '
        Me.pgContatos.Controls.Add(Me.tsContatos)
        Me.pgContatos.Controls.Add(Me.dgvCONTATOS)
        Me.pgContatos.Controls.Add(Me.grbCLIENTE_PRINCIPAL_CONTATOS)
        Me.pgContatos.Location = New System.Drawing.Point(4, 22)
        Me.pgContatos.Name = "pgContatos"
        Me.pgContatos.Size = New System.Drawing.Size(946, 368)
        Me.pgContatos.TabIndex = 3
        Me.pgContatos.Text = "CONTATOS"
        Me.pgContatos.UseVisualStyleBackColor = True
        '
        'tsContatos
        '
        Me.tsContatos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtProcurarContato, Me.cmdProcurarContato, Me.ToolStripSeparator4, Me.cmdNovoContato})
        Me.tsContatos.Location = New System.Drawing.Point(0, 0)
        Me.tsContatos.Name = "tsContatos"
        Me.tsContatos.Size = New System.Drawing.Size(946, 25)
        Me.tsContatos.TabIndex = 81
        Me.tsContatos.Text = "ToolStrip1"
        '
        'txtProcurarContato
        '
        Me.txtProcurarContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcurarContato.MaxLength = 200
        Me.txtProcurarContato.Name = "txtProcurarContato"
        Me.txtProcurarContato.Size = New System.Drawing.Size(600, 25)
        '
        'cmdProcurarContato
        '
        Me.cmdProcurarContato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdProcurarContato.Image = Global.RETEC.My.Resources.Resources.search
        Me.cmdProcurarContato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcurarContato.Name = "cmdProcurarContato"
        Me.cmdProcurarContato.Size = New System.Drawing.Size(23, 22)
        Me.cmdProcurarContato.Text = "ToolStripButton1"
        Me.cmdProcurarContato.ToolTipText = "Procurar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'cmdNovoContato
        '
        Me.cmdNovoContato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNovoContato.Image = Global.RETEC.My.Resources.Resources.add_file
        Me.cmdNovoContato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNovoContato.Name = "cmdNovoContato"
        Me.cmdNovoContato.Size = New System.Drawing.Size(23, 22)
        Me.cmdNovoContato.Text = "ToolStripButton2"
        Me.cmdNovoContato.ToolTipText = "Novo Contato"
        '
        'dgvCONTATOS
        '
        Me.dgvCONTATOS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCONTATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCONTATOS.Location = New System.Drawing.Point(3, 28)
        Me.dgvCONTATOS.Name = "dgvCONTATOS"
        Me.dgvCONTATOS.Size = New System.Drawing.Size(940, 221)
        Me.dgvCONTATOS.TabIndex = 76
        '
        'pgHistorico
        '
        Me.pgHistorico.Controls.Add(Me.tsHistorico)
        Me.pgHistorico.Controls.Add(Me.dgvHISTORICOS)
        Me.pgHistorico.Controls.Add(Me.grbCLIENTE_PRINCIPAL_HISTORICO)
        Me.pgHistorico.Location = New System.Drawing.Point(4, 22)
        Me.pgHistorico.Name = "pgHistorico"
        Me.pgHistorico.Size = New System.Drawing.Size(946, 368)
        Me.pgHistorico.TabIndex = 2
        Me.pgHistorico.Text = "HISTORICO"
        Me.pgHistorico.UseVisualStyleBackColor = True
        '
        'tsHistorico
        '
        Me.tsHistorico.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtProcurarHistorico, Me.cmdProcurarHistorico, Me.ToolStripSeparator5, Me.cmdNovoHistorico})
        Me.tsHistorico.Location = New System.Drawing.Point(0, 0)
        Me.tsHistorico.Name = "tsHistorico"
        Me.tsHistorico.Size = New System.Drawing.Size(946, 25)
        Me.tsHistorico.TabIndex = 83
        Me.tsHistorico.Text = "ToolStrip1"
        '
        'txtProcurarHistorico
        '
        Me.txtProcurarHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcurarHistorico.MaxLength = 200
        Me.txtProcurarHistorico.Name = "txtProcurarHistorico"
        Me.txtProcurarHistorico.Size = New System.Drawing.Size(600, 25)
        '
        'cmdProcurarHistorico
        '
        Me.cmdProcurarHistorico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdProcurarHistorico.Image = Global.RETEC.My.Resources.Resources.search
        Me.cmdProcurarHistorico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcurarHistorico.Name = "cmdProcurarHistorico"
        Me.cmdProcurarHistorico.Size = New System.Drawing.Size(23, 22)
        Me.cmdProcurarHistorico.Text = "ToolStripButton1"
        Me.cmdProcurarHistorico.ToolTipText = "Procurar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'cmdNovoHistorico
        '
        Me.cmdNovoHistorico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNovoHistorico.Image = Global.RETEC.My.Resources.Resources.add_file
        Me.cmdNovoHistorico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNovoHistorico.Name = "cmdNovoHistorico"
        Me.cmdNovoHistorico.Size = New System.Drawing.Size(23, 22)
        Me.cmdNovoHistorico.Text = "ToolStripButton2"
        Me.cmdNovoHistorico.ToolTipText = "Novo Contato"
        '
        'dgvHISTORICOS
        '
        Me.dgvHISTORICOS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHISTORICOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHISTORICOS.Location = New System.Drawing.Point(3, 28)
        Me.dgvHISTORICOS.Name = "dgvHISTORICOS"
        Me.dgvHISTORICOS.Size = New System.Drawing.Size(940, 221)
        Me.dgvHISTORICOS.TabIndex = 78
        '
        'grbCLIENTE_PRINCIPAL_HISTORICO
        '
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.Controls.Add(Me.Label13)
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.Controls.Add(Me.btnHISTORICO_SALVAR)
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.Controls.Add(Me.txtHISTORICO_DADOS)
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.Location = New System.Drawing.Point(3, 255)
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.Name = "grbCLIENTE_PRINCIPAL_HISTORICO"
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.Size = New System.Drawing.Size(940, 101)
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.TabIndex = 77
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.TabStop = False
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.Text = "DADOS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "HISTORICO :"
        '
        'btnHISTORICO_SALVAR
        '
        Me.btnHISTORICO_SALVAR.Location = New System.Drawing.Point(825, 68)
        Me.btnHISTORICO_SALVAR.Name = "btnHISTORICO_SALVAR"
        Me.btnHISTORICO_SALVAR.Size = New System.Drawing.Size(109, 23)
        Me.btnHISTORICO_SALVAR.TabIndex = 82
        Me.btnHISTORICO_SALVAR.Text = "SALVAR"
        Me.btnHISTORICO_SALVAR.UseVisualStyleBackColor = True
        '
        'txtHISTORICO_DADOS
        '
        Me.txtHISTORICO_DADOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHISTORICO_DADOS.Location = New System.Drawing.Point(93, 19)
        Me.txtHISTORICO_DADOS.MaxLength = 1000
        Me.txtHISTORICO_DADOS.Multiline = True
        Me.txtHISTORICO_DADOS.Name = "txtHISTORICO_DADOS"
        Me.txtHISTORICO_DADOS.Size = New System.Drawing.Size(255, 46)
        Me.txtHISTORICO_DADOS.TabIndex = 25
        Me.txtHISTORICO_DADOS.Tag = "1"
        '
        'lblPRINCIPAL_BAIRRO
        '
        Me.lblPRINCIPAL_BAIRRO.AutoSize = True
        Me.lblPRINCIPAL_BAIRRO.ForeColor = System.Drawing.Color.Maroon
        Me.lblPRINCIPAL_BAIRRO.Location = New System.Drawing.Point(10, 61)
        Me.lblPRINCIPAL_BAIRRO.Name = "lblPRINCIPAL_BAIRRO"
        Me.lblPRINCIPAL_BAIRRO.Size = New System.Drawing.Size(127, 13)
        Me.lblPRINCIPAL_BAIRRO.TabIndex = 12
        Me.lblPRINCIPAL_BAIRRO.Text = "BAIRRO / CIDADE / UF:"
        '
        'pgObras
        '
        Me.pgObras.Controls.Add(Me.tsObras)
        Me.pgObras.Controls.Add(Me.dgvOBRAS)
        Me.pgObras.Location = New System.Drawing.Point(4, 22)
        Me.pgObras.Name = "pgObras"
        Me.pgObras.Padding = New System.Windows.Forms.Padding(3)
        Me.pgObras.Size = New System.Drawing.Size(946, 368)
        Me.pgObras.TabIndex = 1
        Me.pgObras.Text = "OBRAS"
        Me.pgObras.UseVisualStyleBackColor = True
        '
        'tsObras
        '
        Me.tsObras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtProcurarObra, Me.cmdProcurarObra, Me.ToolStripSeparator1, Me.cmdNovoObra, Me.ToolStripSeparator3, Me.cmdAtualizarObras})
        Me.tsObras.Location = New System.Drawing.Point(3, 3)
        Me.tsObras.Name = "tsObras"
        Me.tsObras.Size = New System.Drawing.Size(940, 25)
        Me.tsObras.TabIndex = 11
        Me.tsObras.Text = "ToolStrip1"
        '
        'txtProcurarObra
        '
        Me.txtProcurarObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcurarObra.MaxLength = 200
        Me.txtProcurarObra.Name = "txtProcurarObra"
        Me.txtProcurarObra.Size = New System.Drawing.Size(700, 25)
        '
        'cmdProcurarObra
        '
        Me.cmdProcurarObra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdProcurarObra.Image = Global.RETEC.My.Resources.Resources.search
        Me.cmdProcurarObra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcurarObra.Name = "cmdProcurarObra"
        Me.cmdProcurarObra.Size = New System.Drawing.Size(23, 22)
        Me.cmdProcurarObra.Text = "ToolStripButton1"
        Me.cmdProcurarObra.ToolTipText = "Procurar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdNovoObra
        '
        Me.cmdNovoObra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNovoObra.Image = Global.RETEC.My.Resources.Resources.add_file
        Me.cmdNovoObra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNovoObra.Name = "cmdNovoObra"
        Me.cmdNovoObra.Size = New System.Drawing.Size(23, 22)
        Me.cmdNovoObra.Text = "ToolStripButton2"
        Me.cmdNovoObra.ToolTipText = "Novo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'cmdAtualizarObras
        '
        Me.cmdAtualizarObras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAtualizarObras.Image = Global.RETEC.My.Resources.Resources.available_updates
        Me.cmdAtualizarObras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAtualizarObras.Name = "cmdAtualizarObras"
        Me.cmdAtualizarObras.Size = New System.Drawing.Size(23, 22)
        Me.cmdAtualizarObras.Text = "ToolStripButton2"
        Me.cmdAtualizarObras.ToolTipText = "Atualizar"
        '
        'dgvOBRAS
        '
        Me.dgvOBRAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOBRAS.Location = New System.Drawing.Point(3, 28)
        Me.dgvOBRAS.Name = "dgvOBRAS"
        Me.dgvOBRAS.Size = New System.Drawing.Size(937, 334)
        Me.dgvOBRAS.TabIndex = 9
        '
        'lblPRINCIPAL_NUMERO
        '
        Me.lblPRINCIPAL_NUMERO.AutoSize = True
        Me.lblPRINCIPAL_NUMERO.ForeColor = System.Drawing.Color.Maroon
        Me.lblPRINCIPAL_NUMERO.Location = New System.Drawing.Point(10, 39)
        Me.lblPRINCIPAL_NUMERO.Name = "lblPRINCIPAL_NUMERO"
        Me.lblPRINCIPAL_NUMERO.Size = New System.Drawing.Size(152, 13)
        Me.lblPRINCIPAL_NUMERO.TabIndex = 9
        Me.lblPRINCIPAL_NUMERO.Text = "NUMERO / COMPLEMENTO:"
        '
        'txtPRINCIPAL_BAIRRO
        '
        Me.txtPRINCIPAL_BAIRRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_BAIRRO.Location = New System.Drawing.Point(168, 59)
        Me.txtPRINCIPAL_BAIRRO.MaxLength = 50
        Me.txtPRINCIPAL_BAIRRO.Name = "txtPRINCIPAL_BAIRRO"
        Me.txtPRINCIPAL_BAIRRO.Size = New System.Drawing.Size(141, 20)
        Me.txtPRINCIPAL_BAIRRO.TabIndex = 5
        Me.txtPRINCIPAL_BAIRRO.Tag = "1"
        '
        'txtPRINCIPAL_COMPLEMENTO
        '
        Me.txtPRINCIPAL_COMPLEMENTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_COMPLEMENTO.Location = New System.Drawing.Point(315, 36)
        Me.txtPRINCIPAL_COMPLEMENTO.MaxLength = 50
        Me.txtPRINCIPAL_COMPLEMENTO.Name = "txtPRINCIPAL_COMPLEMENTO"
        Me.txtPRINCIPAL_COMPLEMENTO.Size = New System.Drawing.Size(354, 20)
        Me.txtPRINCIPAL_COMPLEMENTO.TabIndex = 4
        Me.txtPRINCIPAL_COMPLEMENTO.Tag = "1"
        '
        'grbCLIENTE_PRINCIPAL_CONTATO
        '
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Controls.Add(Me.Label2)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Controls.Add(Me.Label1)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Controls.Add(Me.txtPRINCIPAL_CONTATO)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Controls.Add(Me.txtPRINCIPAL_TELEFONE)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Controls.Add(Me.txtPRINCIPAL_EMAIL)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Controls.Add(Me.lblPRINCIPAL_CONTATO)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Location = New System.Drawing.Point(13, 112)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Name = "grbCLIENTE_PRINCIPAL_CONTATO"
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Size = New System.Drawing.Size(695, 105)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.TabIndex = 69
        Me.grbCLIENTE_PRINCIPAL_CONTATO.TabStop = False
        Me.grbCLIENTE_PRINCIPAL_CONTATO.Text = "CONTATO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(10, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "E-MAIL :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "TELEFONE :"
        '
        'txtPRINCIPAL_CONTATO
        '
        Me.txtPRINCIPAL_CONTATO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_CONTATO.Location = New System.Drawing.Point(168, 19)
        Me.txtPRINCIPAL_CONTATO.MaxLength = 100
        Me.txtPRINCIPAL_CONTATO.Name = "txtPRINCIPAL_CONTATO"
        Me.txtPRINCIPAL_CONTATO.Size = New System.Drawing.Size(213, 20)
        Me.txtPRINCIPAL_CONTATO.TabIndex = 0
        Me.txtPRINCIPAL_CONTATO.Tag = "1"
        '
        'txtPRINCIPAL_TELEFONE
        '
        Me.txtPRINCIPAL_TELEFONE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_TELEFONE.Location = New System.Drawing.Point(168, 45)
        Me.txtPRINCIPAL_TELEFONE.MaxLength = 100
        Me.txtPRINCIPAL_TELEFONE.Name = "txtPRINCIPAL_TELEFONE"
        Me.txtPRINCIPAL_TELEFONE.Size = New System.Drawing.Size(213, 20)
        Me.txtPRINCIPAL_TELEFONE.TabIndex = 1
        Me.txtPRINCIPAL_TELEFONE.Tag = "1"
        '
        'txtPRINCIPAL_EMAIL
        '
        Me.txtPRINCIPAL_EMAIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtPRINCIPAL_EMAIL.Location = New System.Drawing.Point(168, 71)
        Me.txtPRINCIPAL_EMAIL.MaxLength = 120
        Me.txtPRINCIPAL_EMAIL.Name = "txtPRINCIPAL_EMAIL"
        Me.txtPRINCIPAL_EMAIL.Size = New System.Drawing.Size(213, 20)
        Me.txtPRINCIPAL_EMAIL.TabIndex = 2
        Me.txtPRINCIPAL_EMAIL.Tag = "1"
        '
        'lblPRINCIPAL_CONTATO
        '
        Me.lblPRINCIPAL_CONTATO.AutoSize = True
        Me.lblPRINCIPAL_CONTATO.ForeColor = System.Drawing.Color.Maroon
        Me.lblPRINCIPAL_CONTATO.Location = New System.Drawing.Point(10, 22)
        Me.lblPRINCIPAL_CONTATO.Name = "lblPRINCIPAL_CONTATO"
        Me.lblPRINCIPAL_CONTATO.Size = New System.Drawing.Size(45, 13)
        Me.lblPRINCIPAL_CONTATO.TabIndex = 17
        Me.lblPRINCIPAL_CONTATO.Text = "NOME :"
        '
        'txtPRINCIPAL_NUMERO
        '
        Me.txtPRINCIPAL_NUMERO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_NUMERO.Location = New System.Drawing.Point(168, 36)
        Me.txtPRINCIPAL_NUMERO.MaxLength = 10
        Me.txtPRINCIPAL_NUMERO.Name = "txtPRINCIPAL_NUMERO"
        Me.txtPRINCIPAL_NUMERO.Size = New System.Drawing.Size(141, 20)
        Me.txtPRINCIPAL_NUMERO.TabIndex = 3
        Me.txtPRINCIPAL_NUMERO.Tag = "1"
        '
        'txtPRINCIPAL_ENDERECO
        '
        Me.txtPRINCIPAL_ENDERECO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_ENDERECO.Location = New System.Drawing.Point(251, 13)
        Me.txtPRINCIPAL_ENDERECO.MaxLength = 200
        Me.txtPRINCIPAL_ENDERECO.Name = "txtPRINCIPAL_ENDERECO"
        Me.txtPRINCIPAL_ENDERECO.Size = New System.Drawing.Size(418, 20)
        Me.txtPRINCIPAL_ENDERECO.TabIndex = 2
        Me.txtPRINCIPAL_ENDERECO.Tag = "1"
        '
        'mskPRINCIPAL_CEP
        '
        Me.mskPRINCIPAL_CEP.Location = New System.Drawing.Point(168, 13)
        Me.mskPRINCIPAL_CEP.Mask = "00000-000"
        Me.mskPRINCIPAL_CEP.Name = "mskPRINCIPAL_CEP"
        Me.mskPRINCIPAL_CEP.Size = New System.Drawing.Size(77, 20)
        Me.mskPRINCIPAL_CEP.TabIndex = 1
        Me.mskPRINCIPAL_CEP.Tag = "1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCADASTRO_PROPAGANDA)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(13, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 53)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROPAGANDA"
        '
        'cboCADASTRO_PROPAGANDA
        '
        Me.cboCADASTRO_PROPAGANDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCADASTRO_PROPAGANDA.FormattingEnabled = True
        Me.cboCADASTRO_PROPAGANDA.Location = New System.Drawing.Point(168, 16)
        Me.cboCADASTRO_PROPAGANDA.Name = "cboCADASTRO_PROPAGANDA"
        Me.cboCADASTRO_PROPAGANDA.Size = New System.Drawing.Size(213, 21)
        Me.cboCADASTRO_PROPAGANDA.TabIndex = 0
        Me.cboCADASTRO_PROPAGANDA.Tag = "0"
        '
        'txtPRINCIPAL_CIDADE
        '
        Me.txtPRINCIPAL_CIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_CIDADE.Location = New System.Drawing.Point(315, 59)
        Me.txtPRINCIPAL_CIDADE.MaxLength = 100
        Me.txtPRINCIPAL_CIDADE.Name = "txtPRINCIPAL_CIDADE"
        Me.txtPRINCIPAL_CIDADE.Size = New System.Drawing.Size(282, 20)
        Me.txtPRINCIPAL_CIDADE.TabIndex = 6
        '
        'txtPRINCIPAL_ESTADO
        '
        Me.txtPRINCIPAL_ESTADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_ESTADO.Location = New System.Drawing.Point(603, 59)
        Me.txtPRINCIPAL_ESTADO.MaxLength = 2
        Me.txtPRINCIPAL_ESTADO.Name = "txtPRINCIPAL_ESTADO"
        Me.txtPRINCIPAL_ESTADO.Size = New System.Drawing.Size(66, 20)
        Me.txtPRINCIPAL_ESTADO.TabIndex = 7
        '
        'btnCLIENTE_PESQUISAR
        '
        Me.btnCLIENTE_PESQUISAR.Location = New System.Drawing.Point(736, 40)
        Me.btnCLIENTE_PESQUISAR.Name = "btnCLIENTE_PESQUISAR"
        Me.btnCLIENTE_PESQUISAR.Size = New System.Drawing.Size(115, 23)
        Me.btnCLIENTE_PESQUISAR.TabIndex = 98
        Me.btnCLIENTE_PESQUISAR.Text = "PESQUISAR"
        Me.btnCLIENTE_PESQUISAR.UseVisualStyleBackColor = True
        Me.btnCLIENTE_PESQUISAR.Visible = False
        '
        'btnCLIENTE_SALVAR
        '
        Me.btnCLIENTE_SALVAR.Location = New System.Drawing.Point(736, 9)
        Me.btnCLIENTE_SALVAR.Name = "btnCLIENTE_SALVAR"
        Me.btnCLIENTE_SALVAR.Size = New System.Drawing.Size(115, 23)
        Me.btnCLIENTE_SALVAR.TabIndex = 0
        Me.btnCLIENTE_SALVAR.Text = "NOVO"
        Me.btnCLIENTE_SALVAR.UseVisualStyleBackColor = True
        '
        'pgPrincipal
        '
        Me.pgPrincipal.Controls.Add(Me.grbObs)
        Me.pgPrincipal.Controls.Add(Me.GroupBox2)
        Me.pgPrincipal.Controls.Add(Me.GroupBox1)
        Me.pgPrincipal.Controls.Add(Me.grbCLIENTE_PRINCIPAL_CONTATO)
        Me.pgPrincipal.Controls.Add(Me.grbCLIENTE_ENDERECO)
        Me.pgPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.pgPrincipal.Name = "pgPrincipal"
        Me.pgPrincipal.Padding = New System.Windows.Forms.Padding(3)
        Me.pgPrincipal.Size = New System.Drawing.Size(946, 368)
        Me.pgPrincipal.TabIndex = 0
        Me.pgPrincipal.Text = "PRINCIPAL"
        Me.pgPrincipal.UseVisualStyleBackColor = True
        '
        'grbObs
        '
        Me.grbObs.Controls.Add(Me.txtCADASTRO_OBSERVACAO)
        Me.grbObs.Location = New System.Drawing.Point(714, 15)
        Me.grbObs.Name = "grbObs"
        Me.grbObs.Size = New System.Drawing.Size(226, 338)
        Me.grbObs.TabIndex = 78
        Me.grbObs.TabStop = False
        Me.grbObs.Text = "OBSERVAÇÕES"
        '
        'txtCADASTRO_OBSERVACAO
        '
        Me.txtCADASTRO_OBSERVACAO.Location = New System.Drawing.Point(6, 19)
        Me.txtCADASTRO_OBSERVACAO.MaxLength = 1000
        Me.txtCADASTRO_OBSERVACAO.Multiline = True
        Me.txtCADASTRO_OBSERVACAO.Name = "txtCADASTRO_OBSERVACAO"
        Me.txtCADASTRO_OBSERVACAO.Size = New System.Drawing.Size(214, 303)
        Me.txtCADASTRO_OBSERVACAO.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCADASTRO_OBSERVACAO)
        Me.GroupBox2.Controls.Add(Me.lblCADASTRO_STATUS)
        Me.GroupBox2.Controls.Add(Me.cboSTATUS_OBSERVACAO)
        Me.GroupBox2.Controls.Add(Me.cboSTATUS)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(695, 71)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SOBRE"
        '
        'lblCADASTRO_OBSERVACAO
        '
        Me.lblCADASTRO_OBSERVACAO.AutoSize = True
        Me.lblCADASTRO_OBSERVACAO.Location = New System.Drawing.Point(14, 34)
        Me.lblCADASTRO_OBSERVACAO.Name = "lblCADASTRO_OBSERVACAO"
        Me.lblCADASTRO_OBSERVACAO.Size = New System.Drawing.Size(83, 13)
        Me.lblCADASTRO_OBSERVACAO.TabIndex = 26
        Me.lblCADASTRO_OBSERVACAO.Text = "OBSERVAÇÃO:"
        '
        'lblCADASTRO_STATUS
        '
        Me.lblCADASTRO_STATUS.AutoSize = True
        Me.lblCADASTRO_STATUS.Location = New System.Drawing.Point(506, 34)
        Me.lblCADASTRO_STATUS.Name = "lblCADASTRO_STATUS"
        Me.lblCADASTRO_STATUS.Size = New System.Drawing.Size(53, 13)
        Me.lblCADASTRO_STATUS.TabIndex = 25
        Me.lblCADASTRO_STATUS.Text = "STATUS:"
        '
        'cboSTATUS_OBSERVACAO
        '
        Me.cboSTATUS_OBSERVACAO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSTATUS_OBSERVACAO.FormattingEnabled = True
        Me.cboSTATUS_OBSERVACAO.Location = New System.Drawing.Point(168, 31)
        Me.cboSTATUS_OBSERVACAO.Name = "cboSTATUS_OBSERVACAO"
        Me.cboSTATUS_OBSERVACAO.Size = New System.Drawing.Size(311, 21)
        Me.cboSTATUS_OBSERVACAO.TabIndex = 0
        Me.cboSTATUS_OBSERVACAO.Tag = "0"
        '
        'cboSTATUS
        '
        Me.cboSTATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSTATUS.FormattingEnabled = True
        Me.cboSTATUS.Items.AddRange(New Object() {"LIBERADO", "BLOQUEADO"})
        Me.cboSTATUS.Location = New System.Drawing.Point(565, 31)
        Me.cboSTATUS.Name = "cboSTATUS"
        Me.cboSTATUS.Size = New System.Drawing.Size(121, 21)
        Me.cboSTATUS.TabIndex = 1
        Me.cboSTATUS.Tag = "0"
        '
        'grbCLIENTE_ENDERECO
        '
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.btnEnderecoPrincipal)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.txtPRINCIPAL_ESTADO)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.txtPRINCIPAL_CIDADE)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.mskPRINCIPAL_CEP)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.lblPRINCIPAL_BAIRRO)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.lblPRINCIPAL_NUMERO)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.txtPRINCIPAL_BAIRRO)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.txtPRINCIPAL_COMPLEMENTO)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.txtPRINCIPAL_NUMERO)
        Me.grbCLIENTE_ENDERECO.Controls.Add(Me.txtPRINCIPAL_ENDERECO)
        Me.grbCLIENTE_ENDERECO.Location = New System.Drawing.Point(13, 15)
        Me.grbCLIENTE_ENDERECO.Name = "grbCLIENTE_ENDERECO"
        Me.grbCLIENTE_ENDERECO.Size = New System.Drawing.Size(695, 91)
        Me.grbCLIENTE_ENDERECO.TabIndex = 68
        Me.grbCLIENTE_ENDERECO.TabStop = False
        Me.grbCLIENTE_ENDERECO.Text = "PRINCIPAL"
        '
        'btnEnderecoPrincipal
        '
        Me.btnEnderecoPrincipal.Location = New System.Drawing.Point(6, 14)
        Me.btnEnderecoPrincipal.Name = "btnEnderecoPrincipal"
        Me.btnEnderecoPrincipal.Size = New System.Drawing.Size(157, 22)
        Me.btnEnderecoPrincipal.TabIndex = 0
        Me.btnEnderecoPrincipal.Text = "ENDERECO"
        Me.btnEnderecoPrincipal.UseVisualStyleBackColor = True
        '
        'tabDADOS
        '
        Me.tabDADOS.Controls.Add(Me.pgPrincipal)
        Me.tabDADOS.Controls.Add(Me.pgObras)
        Me.tabDADOS.Controls.Add(Me.pgContatos)
        Me.tabDADOS.Controls.Add(Me.pgHistorico)
        Me.tabDADOS.Location = New System.Drawing.Point(12, 105)
        Me.tabDADOS.Name = "tabDADOS"
        Me.tabDADOS.SelectedIndex = 0
        Me.tabDADOS.Size = New System.Drawing.Size(954, 394)
        Me.tabDADOS.TabIndex = 94
        '
        'lblPRINCIPAL_NOME
        '
        Me.lblPRINCIPAL_NOME.AutoSize = True
        Me.lblPRINCIPAL_NOME.ForeColor = System.Drawing.Color.Maroon
        Me.lblPRINCIPAL_NOME.Location = New System.Drawing.Point(14, 41)
        Me.lblPRINCIPAL_NOME.Name = "lblPRINCIPAL_NOME"
        Me.lblPRINCIPAL_NOME.Size = New System.Drawing.Size(42, 13)
        Me.lblPRINCIPAL_NOME.TabIndex = 1
        Me.lblPRINCIPAL_NOME.Text = "NOME:"
        '
        'txtPRINCIPAL_NOME
        '
        Me.txtPRINCIPAL_NOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_NOME.Location = New System.Drawing.Point(168, 38)
        Me.txtPRINCIPAL_NOME.MaxLength = 100
        Me.txtPRINCIPAL_NOME.Name = "txtPRINCIPAL_NOME"
        Me.txtPRINCIPAL_NOME.Size = New System.Drawing.Size(518, 20)
        Me.txtPRINCIPAL_NOME.TabIndex = 3
        Me.txtPRINCIPAL_NOME.Tag = "1"
        '
        'cboCADASTRO_TIPO
        '
        Me.cboCADASTRO_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCADASTRO_TIPO.FormattingEnabled = True
        Me.cboCADASTRO_TIPO.Items.AddRange(New Object() {"FISICO", "JURIDICO"})
        Me.cboCADASTRO_TIPO.Location = New System.Drawing.Point(168, 13)
        Me.cboCADASTRO_TIPO.Name = "cboCADASTRO_TIPO"
        Me.cboCADASTRO_TIPO.Size = New System.Drawing.Size(113, 21)
        Me.cboCADASTRO_TIPO.TabIndex = 0
        Me.cboCADASTRO_TIPO.Tag = "1"
        '
        'lblCADASTRO_TIPO
        '
        Me.lblCADASTRO_TIPO.AutoSize = True
        Me.lblCADASTRO_TIPO.ForeColor = System.Drawing.Color.Maroon
        Me.lblCADASTRO_TIPO.Location = New System.Drawing.Point(14, 18)
        Me.lblCADASTRO_TIPO.Name = "lblCADASTRO_TIPO"
        Me.lblCADASTRO_TIPO.Size = New System.Drawing.Size(105, 13)
        Me.lblCADASTRO_TIPO.TabIndex = 13
        Me.lblCADASTRO_TIPO.Text = "FISICO / JURIDICO:"
        '
        'lblCNPJ_CPF
        '
        Me.lblCNPJ_CPF.AutoSize = True
        Me.lblCNPJ_CPF.ForeColor = System.Drawing.Color.Maroon
        Me.lblCNPJ_CPF.Location = New System.Drawing.Point(287, 18)
        Me.lblCNPJ_CPF.Name = "lblCNPJ_CPF"
        Me.lblCNPJ_CPF.Size = New System.Drawing.Size(68, 13)
        Me.lblCNPJ_CPF.TabIndex = 14
        Me.lblCNPJ_CPF.Text = "CNPJ / CPF:"
        '
        'lblNOME_FANTASIA
        '
        Me.lblNOME_FANTASIA.AutoSize = True
        Me.lblNOME_FANTASIA.ForeColor = System.Drawing.Color.Maroon
        Me.lblNOME_FANTASIA.Location = New System.Drawing.Point(13, 65)
        Me.lblNOME_FANTASIA.Name = "lblNOME_FANTASIA"
        Me.lblNOME_FANTASIA.Size = New System.Drawing.Size(97, 13)
        Me.lblNOME_FANTASIA.TabIndex = 20
        Me.lblNOME_FANTASIA.Text = "NOME FANTASIA:"
        '
        'txtPRINCIPAL_NOME_FANTASIA
        '
        Me.txtPRINCIPAL_NOME_FANTASIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPRINCIPAL_NOME_FANTASIA.Location = New System.Drawing.Point(168, 62)
        Me.txtPRINCIPAL_NOME_FANTASIA.MaxLength = 50
        Me.txtPRINCIPAL_NOME_FANTASIA.Name = "txtPRINCIPAL_NOME_FANTASIA"
        Me.txtPRINCIPAL_NOME_FANTASIA.Size = New System.Drawing.Size(518, 20)
        Me.txtPRINCIPAL_NOME_FANTASIA.TabIndex = 4
        Me.txtPRINCIPAL_NOME_FANTASIA.Tag = "1"
        '
        'mskCNPJ_CPF
        '
        Me.mskCNPJ_CPF.Location = New System.Drawing.Point(359, 13)
        Me.mskCNPJ_CPF.Mask = "000.000.000-00"
        Me.mskCNPJ_CPF.Name = "mskCNPJ_CPF"
        Me.mskCNPJ_CPF.Size = New System.Drawing.Size(120, 20)
        Me.mskCNPJ_CPF.TabIndex = 1
        Me.mskCNPJ_CPF.Tag = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(511, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "IE / RG:"
        '
        'mskIE_RG
        '
        Me.mskIE_RG.Location = New System.Drawing.Point(565, 15)
        Me.mskIE_RG.Name = "mskIE_RG"
        Me.mskIE_RG.Size = New System.Drawing.Size(120, 20)
        Me.mskIE_RG.TabIndex = 2
        '
        'grbCLIENTE_DADOS
        '
        Me.grbCLIENTE_DADOS.Controls.Add(Me.mskIE_RG)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.Label3)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.mskCNPJ_CPF)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.txtPRINCIPAL_NOME_FANTASIA)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.lblNOME_FANTASIA)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.lblCNPJ_CPF)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.lblCADASTRO_TIPO)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.cboCADASTRO_TIPO)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.txtPRINCIPAL_NOME)
        Me.grbCLIENTE_DADOS.Controls.Add(Me.lblPRINCIPAL_NOME)
        Me.grbCLIENTE_DADOS.Location = New System.Drawing.Point(12, 12)
        Me.grbCLIENTE_DADOS.Name = "grbCLIENTE_DADOS"
        Me.grbCLIENTE_DADOS.Size = New System.Drawing.Size(712, 87)
        Me.grbCLIENTE_DADOS.TabIndex = 91
        Me.grbCLIENTE_DADOS.TabStop = False
        Me.grbCLIENTE_DADOS.Text = "CLIENTE"
        '
        'txtUser
        '
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Location = New System.Drawing.Point(774, 70)
        Me.txtUser.MaxLength = 10
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(77, 20)
        Me.txtUser.TabIndex = 99
        Me.txtUser.Tag = "1"
        Me.txtUser.Text = "AILTON"
        Me.txtUser.Visible = False
        '
        'txtID_CLIENTE
        '
        Me.txtID_CLIENTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID_CLIENTE.Location = New System.Drawing.Point(885, 12)
        Me.txtID_CLIENTE.MaxLength = 10
        Me.txtID_CLIENTE.Name = "txtID_CLIENTE"
        Me.txtID_CLIENTE.Size = New System.Drawing.Size(77, 20)
        Me.txtID_CLIENTE.TabIndex = 100
        Me.txtID_CLIENTE.Tag = "1"
        Me.txtID_CLIENTE.Text = "0"
        Me.txtID_CLIENTE.Visible = False
        '
        'txtID_OBRA
        '
        Me.txtID_OBRA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID_OBRA.Location = New System.Drawing.Point(885, 38)
        Me.txtID_OBRA.MaxLength = 10
        Me.txtID_OBRA.Name = "txtID_OBRA"
        Me.txtID_OBRA.Size = New System.Drawing.Size(77, 20)
        Me.txtID_OBRA.TabIndex = 101
        Me.txtID_OBRA.Tag = "1"
        Me.txtID_OBRA.Text = "0"
        Me.txtID_OBRA.Visible = False
        '
        'txtID_CONTATO
        '
        Me.txtID_CONTATO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID_CONTATO.Location = New System.Drawing.Point(885, 64)
        Me.txtID_CONTATO.MaxLength = 10
        Me.txtID_CONTATO.Name = "txtID_CONTATO"
        Me.txtID_CONTATO.Size = New System.Drawing.Size(77, 20)
        Me.txtID_CONTATO.TabIndex = 102
        Me.txtID_CONTATO.Tag = "1"
        Me.txtID_CONTATO.Text = "0"
        Me.txtID_CONTATO.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtID_HISTORICO
        '
        Me.txtID_HISTORICO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID_HISTORICO.Location = New System.Drawing.Point(885, 90)
        Me.txtID_HISTORICO.MaxLength = 10
        Me.txtID_HISTORICO.Name = "txtID_HISTORICO"
        Me.txtID_HISTORICO.Size = New System.Drawing.Size(77, 20)
        Me.txtID_HISTORICO.TabIndex = 103
        Me.txtID_HISTORICO.Tag = "1"
        Me.txtID_HISTORICO.Text = "0"
        Me.txtID_HISTORICO.Visible = False
        '
        'chkRelacao
        '
        Me.chkRelacao.AutoSize = True
        Me.chkRelacao.Location = New System.Drawing.Point(751, 97)
        Me.chkRelacao.Name = "chkRelacao"
        Me.chkRelacao.Size = New System.Drawing.Size(103, 17)
        Me.chkRelacao.TabIndex = 104
        Me.chkRelacao.Text = "Relacionamento"
        Me.chkRelacao.UseVisualStyleBackColor = True
        Me.chkRelacao.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsREGISTRO_INSERT_USUARIO, Me.stsREGISTRO_INSERT_EMISSAO, Me.stsREGISTRO_UPDATE_USUARIO, Me.stsREGISTRO_UPDATE_EMISSAO})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(978, 22)
        Me.StatusStrip1.TabIndex = 113
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
        'cadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 532)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkRelacao)
        Me.Controls.Add(Me.txtID_HISTORICO)
        Me.Controls.Add(Me.txtID_CONTATO)
        Me.Controls.Add(Me.txtID_OBRA)
        Me.Controls.Add(Me.txtID_CLIENTE)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.grbCLIENTE_DADOS)
        Me.Controls.Add(Me.btnCLIENTE_PESQUISAR)
        Me.Controls.Add(Me.btnCLIENTE_SALVAR)
        Me.Controls.Add(Me.tabDADOS)
        Me.Name = "cadastroCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CLIENTE"
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.ResumeLayout(False)
        Me.grbCLIENTE_PRINCIPAL_CONTATOS.PerformLayout()
        Me.pgContatos.ResumeLayout(False)
        Me.pgContatos.PerformLayout()
        Me.tsContatos.ResumeLayout(False)
        Me.tsContatos.PerformLayout()
        CType(Me.dgvCONTATOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgHistorico.ResumeLayout(False)
        Me.pgHistorico.PerformLayout()
        Me.tsHistorico.ResumeLayout(False)
        Me.tsHistorico.PerformLayout()
        CType(Me.dgvHISTORICOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.ResumeLayout(False)
        Me.grbCLIENTE_PRINCIPAL_HISTORICO.PerformLayout()
        Me.pgObras.ResumeLayout(False)
        Me.pgObras.PerformLayout()
        Me.tsObras.ResumeLayout(False)
        Me.tsObras.PerformLayout()
        CType(Me.dgvOBRAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCLIENTE_PRINCIPAL_CONTATO.ResumeLayout(False)
        Me.grbCLIENTE_PRINCIPAL_CONTATO.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.pgPrincipal.ResumeLayout(False)
        Me.grbObs.ResumeLayout(False)
        Me.grbObs.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grbCLIENTE_ENDERECO.ResumeLayout(False)
        Me.grbCLIENTE_ENDERECO.PerformLayout()
        Me.tabDADOS.ResumeLayout(False)
        Me.grbCLIENTE_DADOS.ResumeLayout(False)
        Me.grbCLIENTE_DADOS.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCONTATO_SALVAR As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCONTATO_OBSERVACAO As System.Windows.Forms.TextBox
    Friend WithEvents grbCLIENTE_PRINCIPAL_CONTATOS As System.Windows.Forms.GroupBox
    Friend WithEvents lblCONTATO_EMAIL As System.Windows.Forms.Label
    Friend WithEvents lblCONTATO_TELEFONE As System.Windows.Forms.Label
    Friend WithEvents lblCONTATO_NOME As System.Windows.Forms.Label
    Friend WithEvents txtCONTATO_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents txtCONTATO_TELEFONE As System.Windows.Forms.TextBox
    Friend WithEvents txtCONTATO_NOME As System.Windows.Forms.TextBox
    Friend WithEvents pgContatos As System.Windows.Forms.TabPage
    Friend WithEvents pgHistorico As System.Windows.Forms.TabPage
    Friend WithEvents grbCLIENTE_PRINCIPAL_HISTORICO As System.Windows.Forms.GroupBox
    Friend WithEvents btnHISTORICO_SALVAR As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtHISTORICO_DADOS As System.Windows.Forms.TextBox
    Friend WithEvents lblPRINCIPAL_BAIRRO As System.Windows.Forms.Label
    Friend WithEvents pgObras As System.Windows.Forms.TabPage
    Friend WithEvents lblPRINCIPAL_NUMERO As System.Windows.Forms.Label
    Friend WithEvents txtPRINCIPAL_BAIRRO As System.Windows.Forms.TextBox
    Friend WithEvents txtPRINCIPAL_COMPLEMENTO As System.Windows.Forms.TextBox
    Friend WithEvents grbCLIENTE_PRINCIPAL_CONTATO As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPRINCIPAL_CONTATO As System.Windows.Forms.TextBox
    Friend WithEvents txtPRINCIPAL_TELEFONE As System.Windows.Forms.TextBox
    Friend WithEvents txtPRINCIPAL_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents lblPRINCIPAL_CONTATO As System.Windows.Forms.Label
    Friend WithEvents txtPRINCIPAL_NUMERO As System.Windows.Forms.TextBox
    Friend WithEvents txtPRINCIPAL_ENDERECO As System.Windows.Forms.TextBox
    Friend WithEvents mskPRINCIPAL_CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCADASTRO_PROPAGANDA As System.Windows.Forms.ComboBox
    Friend WithEvents txtPRINCIPAL_CIDADE As System.Windows.Forms.TextBox
    Friend WithEvents txtPRINCIPAL_ESTADO As System.Windows.Forms.TextBox
    Friend WithEvents btnCLIENTE_PESQUISAR As System.Windows.Forms.Button
    Friend WithEvents btnCLIENTE_SALVAR As System.Windows.Forms.Button
    Friend WithEvents pgPrincipal As System.Windows.Forms.TabPage
    Friend WithEvents grbCLIENTE_ENDERECO As System.Windows.Forms.GroupBox
    Friend WithEvents tabDADOS As System.Windows.Forms.TabControl
    Friend WithEvents dgvCONTATOS As System.Windows.Forms.DataGridView
    Friend WithEvents dgvHISTORICOS As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCADASTRO_OBSERVACAO As System.Windows.Forms.Label
    Friend WithEvents lblCADASTRO_STATUS As System.Windows.Forms.Label
    Friend WithEvents cboSTATUS_OBSERVACAO As System.Windows.Forms.ComboBox
    Friend WithEvents cboSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents lblPRINCIPAL_NOME As System.Windows.Forms.Label
    Friend WithEvents txtPRINCIPAL_NOME As System.Windows.Forms.TextBox
    Friend WithEvents cboCADASTRO_TIPO As System.Windows.Forms.ComboBox
    Friend WithEvents lblCADASTRO_TIPO As System.Windows.Forms.Label
    Friend WithEvents lblCNPJ_CPF As System.Windows.Forms.Label
    Friend WithEvents lblNOME_FANTASIA As System.Windows.Forms.Label
    Friend WithEvents txtPRINCIPAL_NOME_FANTASIA As System.Windows.Forms.TextBox
    Friend WithEvents mskCNPJ_CPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskIE_RG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grbCLIENTE_DADOS As System.Windows.Forms.GroupBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtID_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents grbObs As System.Windows.Forms.GroupBox
    Friend WithEvents txtCADASTRO_OBSERVACAO As System.Windows.Forms.TextBox
    Friend WithEvents txtID_OBRA As System.Windows.Forms.TextBox
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents txtID_CONTATO As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnEnderecoPrincipal As System.Windows.Forms.Button
    Friend WithEvents tsContatos As System.Windows.Forms.ToolStrip
    Friend WithEvents txtProcurarContato As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdProcurarContato As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNovoContato As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsHistorico As System.Windows.Forms.ToolStrip
    Friend WithEvents txtProcurarHistorico As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdProcurarHistorico As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNovoHistorico As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvOBRAS As System.Windows.Forms.DataGridView
    Friend WithEvents tsObras As System.Windows.Forms.ToolStrip
    Friend WithEvents txtProcurarObra As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdProcurarObra As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNovoObra As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAtualizarObras As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtID_HISTORICO As System.Windows.Forms.TextBox
    Friend WithEvents chkRelacao As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsREGISTRO_INSERT_USUARIO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_INSERT_EMISSAO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_UPDATE_USUARIO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_UPDATE_EMISSAO As System.Windows.Forms.ToolStripStatusLabel
End Class

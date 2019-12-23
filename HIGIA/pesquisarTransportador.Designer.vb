<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisarTransportador
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
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.cmdFiltrar = New System.Windows.Forms.Button()
        Me.txtProcurar = New System.Windows.Forms.TextBox()
        Me.cboCampos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.mskPRINCIPAL_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsDescricao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCONTRATO_MULTA_DIA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_MULTA_DIA = New System.Windows.Forms.TextBox()
        Me.cboCONTRATO_FATURAMENTO_DIAS = New System.Windows.Forms.ComboBox()
        Me.lblCONTRATO_MULTA_MORA = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCONTRATO_MULTA_MORA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_VCTO_APOS_ENTREGA = New System.Windows.Forms.Label()
        Me.cboCONTRATO_FORMA_PAGAMENTO = New System.Windows.Forms.ComboBox()
        Me.txtCONTRATO_VCTO_APOS_ENTREGA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_RETIRADA_AUTOMATICA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_RETIRADA_AUTOMATICA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_PERIDO_LOCACAO = New System.Windows.Forms.Label()
        Me.txtCONTRATO_PERIODO_LOCACAO = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkRetira = New System.Windows.Forms.CheckBox()
        Me.chkTroca = New System.Windows.Forms.CheckBox()
        Me.chkColoca = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPRECO_VALOR = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboPRECO_TIPO = New System.Windows.Forms.ComboBox()
        Me.txtCPF_CCM = New System.Windows.Forms.TextBox()
        Me.txtLIMPURB = New System.Windows.Forms.TextBox()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(12, 384)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(762, 172)
        Me.dgvDados.TabIndex = 9
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltrar.Location = New System.Drawing.Point(688, 349)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdFiltrar.TabIndex = 8
        Me.cmdFiltrar.Text = "FILTRAR"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'txtProcurar
        '
        Me.txtProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcurar.Location = New System.Drawing.Point(152, 19)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(431, 20)
        Me.txtProcurar.TabIndex = 1
        '
        'cboCampos
        '
        Me.cboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampos.FormattingEnabled = True
        Me.cboCampos.Location = New System.Drawing.Point(13, 18)
        Me.cboCampos.Name = "cboCampos"
        Me.cboCampos.Size = New System.Drawing.Size(133, 21)
        Me.cboCampos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.mskPRINCIPAL_CEP)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.txtComplemento)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.lblDescricao)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENDEREÇO"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Location = New System.Drawing.Point(152, 45)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(59, 20)
        Me.txtNumero.TabIndex = 2
        '
        'mskPRINCIPAL_CEP
        '
        Me.mskPRINCIPAL_CEP.Location = New System.Drawing.Point(69, 19)
        Me.mskPRINCIPAL_CEP.Mask = "00000-000"
        Me.mskPRINCIPAL_CEP.Name = "mskPRINCIPAL_CEP"
        Me.mskPRINCIPAL_CEP.Size = New System.Drawing.Size(77, 20)
        Me.mskPRINCIPAL_CEP.TabIndex = 0
        Me.mskPRINCIPAL_CEP.Tag = "1"
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Location = New System.Drawing.Point(589, 71)
        Me.txtEstado.MaxLength = 2
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(59, 20)
        Me.txtEstado.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CIDADE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "COMPLEMENTO:"
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(152, 71)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(431, 20)
        Me.txtCidade.TabIndex = 5
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(396, 45)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(252, 20)
        Me.txtBairro.TabIndex = 4
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(217, 45)
        Me.txtComplemento.MaxLength = 50
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(173, 20)
        Me.txtComplemento.TabIndex = 3
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(152, 19)
        Me.txtEndereco.MaxLength = 50
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(496, 20)
        Me.txtEndereco.TabIndex = 1
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(10, 19)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(31, 13)
        Me.lblDescricao.TabIndex = 1
        Me.lblDescricao.Text = "CEP:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(688, 122)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(59, 20)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLimite)
        Me.GroupBox2.Controls.Add(Me.cboCampos)
        Me.GroupBox2.Controls.Add(Me.txtProcurar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 333)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 45)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTRO"
        '
        'txtLimite
        '
        Me.txtLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLimite.Location = New System.Drawing.Point(589, 19)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(59, 20)
        Me.txtLimite.TabIndex = 2
        Me.txtLimite.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(688, 23)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.Text = "SALVAR"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(688, 52)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Location = New System.Drawing.Point(687, 96)
        Me.txtUser.MaxLength = 10
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(60, 20)
        Me.txtUser.TabIndex = 100
        Me.txtUser.TabStop = False
        Me.txtUser.Tag = "1"
        Me.txtUser.Text = "AILTON"
        Me.txtUser.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsDescricao})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 566)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 111
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsDescricao
        '
        Me.stsDescricao.Name = "stsDescricao"
        Me.stsDescricao.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtLIMPURB)
        Me.GroupBox3.Controls.Add(Me.txtCPF_CCM)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtTelefone)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtNome)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 104)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "IDENTIFICAÇÃO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TELEFONE:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(152, 45)
        Me.txtTelefone.MaxLength = 100
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(238, 20)
        Me.txtTelefone.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOME:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(152, 19)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(238, 20)
        Me.txtNome.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_MULTA_DIA)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_MULTA_DIA)
        Me.GroupBox4.Controls.Add(Me.cboCONTRATO_FATURAMENTO_DIAS)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_MULTA_MORA)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_MULTA_MORA)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_VCTO_APOS_ENTREGA)
        Me.GroupBox4.Controls.Add(Me.cboCONTRATO_FORMA_PAGAMENTO)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_VCTO_APOS_ENTREGA)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_RETIRADA_AUTOMATICA)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_RETIRADA_AUTOMATICA)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_PERIDO_LOCACAO)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_PERIODO_LOCACAO)
        Me.GroupBox4.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 209)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS DE COBRANÇA :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "CONDIÇÃO:"
        '
        'lblCONTRATO_MULTA_DIA
        '
        Me.lblCONTRATO_MULTA_DIA.AutoSize = True
        Me.lblCONTRATO_MULTA_DIA.Location = New System.Drawing.Point(81, 120)
        Me.lblCONTRATO_MULTA_DIA.Name = "lblCONTRATO_MULTA_DIA"
        Me.lblCONTRATO_MULTA_DIA.Size = New System.Drawing.Size(68, 13)
        Me.lblCONTRATO_MULTA_DIA.TabIndex = 72
        Me.lblCONTRATO_MULTA_DIA.Text = "MULTA DIA:"
        '
        'txtCONTRATO_MULTA_DIA
        '
        Me.txtCONTRATO_MULTA_DIA.Location = New System.Drawing.Point(155, 117)
        Me.txtCONTRATO_MULTA_DIA.Name = "txtCONTRATO_MULTA_DIA"
        Me.txtCONTRATO_MULTA_DIA.Size = New System.Drawing.Size(87, 20)
        Me.txtCONTRATO_MULTA_DIA.TabIndex = 4
        Me.txtCONTRATO_MULTA_DIA.Tag = "1"
        Me.txtCONTRATO_MULTA_DIA.Text = "0,00"
        Me.txtCONTRATO_MULTA_DIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboCONTRATO_FATURAMENTO_DIAS
        '
        Me.cboCONTRATO_FATURAMENTO_DIAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCONTRATO_FATURAMENTO_DIAS.FormattingEnabled = True
        Me.cboCONTRATO_FATURAMENTO_DIAS.Location = New System.Drawing.Point(155, 170)
        Me.cboCONTRATO_FATURAMENTO_DIAS.Name = "cboCONTRATO_FATURAMENTO_DIAS"
        Me.cboCONTRATO_FATURAMENTO_DIAS.Size = New System.Drawing.Size(87, 21)
        Me.cboCONTRATO_FATURAMENTO_DIAS.TabIndex = 6
        Me.cboCONTRATO_FATURAMENTO_DIAS.Tag = "1"
        '
        'lblCONTRATO_MULTA_MORA
        '
        Me.lblCONTRATO_MULTA_MORA.AutoSize = True
        Me.lblCONTRATO_MULTA_MORA.Location = New System.Drawing.Point(67, 94)
        Me.lblCONTRATO_MULTA_MORA.Name = "lblCONTRATO_MULTA_MORA"
        Me.lblCONTRATO_MULTA_MORA.Size = New System.Drawing.Size(82, 13)
        Me.lblCONTRATO_MULTA_MORA.TabIndex = 71
        Me.lblCONTRATO_MULTA_MORA.Text = "MULTA MORA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "TRANSAÇÃO:"
        '
        'txtCONTRATO_MULTA_MORA
        '
        Me.txtCONTRATO_MULTA_MORA.Location = New System.Drawing.Point(155, 91)
        Me.txtCONTRATO_MULTA_MORA.Name = "txtCONTRATO_MULTA_MORA"
        Me.txtCONTRATO_MULTA_MORA.Size = New System.Drawing.Size(87, 20)
        Me.txtCONTRATO_MULTA_MORA.TabIndex = 3
        Me.txtCONTRATO_MULTA_MORA.Tag = "1"
        Me.txtCONTRATO_MULTA_MORA.Text = "0,00"
        Me.txtCONTRATO_MULTA_MORA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCONTRATO_VCTO_APOS_ENTREGA
        '
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.AutoSize = True
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Location = New System.Drawing.Point(7, 68)
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Name = "lblCONTRATO_VCTO_APOS_ENTREGA"
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Size = New System.Drawing.Size(142, 13)
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.TabIndex = 70
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Text = "VENCIMENTO - ENTREGA:"
        '
        'cboCONTRATO_FORMA_PAGAMENTO
        '
        Me.cboCONTRATO_FORMA_PAGAMENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCONTRATO_FORMA_PAGAMENTO.FormattingEnabled = True
        Me.cboCONTRATO_FORMA_PAGAMENTO.Location = New System.Drawing.Point(155, 143)
        Me.cboCONTRATO_FORMA_PAGAMENTO.Name = "cboCONTRATO_FORMA_PAGAMENTO"
        Me.cboCONTRATO_FORMA_PAGAMENTO.Size = New System.Drawing.Size(87, 21)
        Me.cboCONTRATO_FORMA_PAGAMENTO.TabIndex = 5
        Me.cboCONTRATO_FORMA_PAGAMENTO.Tag = "1"
        '
        'txtCONTRATO_VCTO_APOS_ENTREGA
        '
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Location = New System.Drawing.Point(155, 65)
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Name = "txtCONTRATO_VCTO_APOS_ENTREGA"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Size = New System.Drawing.Size(87, 20)
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.TabIndex = 2
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Tag = "1"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Text = "0"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCONTRATO_RETIRADA_AUTOMATICA
        '
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.AutoSize = True
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Location = New System.Drawing.Point(11, 45)
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Name = "lblCONTRATO_RETIRADA_AUTOMATICA"
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Size = New System.Drawing.Size(138, 13)
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.TabIndex = 69
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Text = "RETIRADA AUTOMATICA:"
        '
        'txtCONTRATO_RETIRADA_AUTOMATICA
        '
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Location = New System.Drawing.Point(155, 42)
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Name = "txtCONTRATO_RETIRADA_AUTOMATICA"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Size = New System.Drawing.Size(87, 20)
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.TabIndex = 1
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Tag = "1"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text = "0"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCONTRATO_PERIDO_LOCACAO
        '
        Me.lblCONTRATO_PERIDO_LOCACAO.AutoSize = True
        Me.lblCONTRATO_PERIDO_LOCACAO.Location = New System.Drawing.Point(19, 22)
        Me.lblCONTRATO_PERIDO_LOCACAO.Name = "lblCONTRATO_PERIDO_LOCACAO"
        Me.lblCONTRATO_PERIDO_LOCACAO.Size = New System.Drawing.Size(130, 13)
        Me.lblCONTRATO_PERIDO_LOCACAO.TabIndex = 68
        Me.lblCONTRATO_PERIDO_LOCACAO.Text = "PERIODO DE LOCAÇÃO:"
        '
        'txtCONTRATO_PERIODO_LOCACAO
        '
        Me.txtCONTRATO_PERIODO_LOCACAO.Location = New System.Drawing.Point(155, 19)
        Me.txtCONTRATO_PERIODO_LOCACAO.Name = "txtCONTRATO_PERIODO_LOCACAO"
        Me.txtCONTRATO_PERIODO_LOCACAO.Size = New System.Drawing.Size(87, 20)
        Me.txtCONTRATO_PERIODO_LOCACAO.TabIndex = 0
        Me.txtCONTRATO_PERIODO_LOCACAO.Tag = "1"
        Me.txtCONTRATO_PERIODO_LOCACAO.Text = "0"
        Me.txtCONTRATO_PERIODO_LOCACAO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkRetira)
        Me.GroupBox5.Controls.Add(Me.chkTroca)
        Me.GroupBox5.Controls.Add(Me.chkColoca)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(184, 99)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "FATURAMENTO"
        '
        'chkRetira
        '
        Me.chkRetira.AutoSize = True
        Me.chkRetira.Location = New System.Drawing.Point(49, 76)
        Me.chkRetira.Name = "chkRetira"
        Me.chkRetira.Size = New System.Drawing.Size(66, 17)
        Me.chkRetira.TabIndex = 2
        Me.chkRetira.Text = "RETIRA"
        Me.chkRetira.UseVisualStyleBackColor = True
        '
        'chkTroca
        '
        Me.chkTroca.AutoSize = True
        Me.chkTroca.Location = New System.Drawing.Point(49, 46)
        Me.chkTroca.Name = "chkTroca"
        Me.chkTroca.Size = New System.Drawing.Size(63, 17)
        Me.chkTroca.TabIndex = 1
        Me.chkTroca.Text = "TROCA"
        Me.chkTroca.UseVisualStyleBackColor = True
        '
        'chkColoca
        '
        Me.chkColoca.AutoSize = True
        Me.chkColoca.Location = New System.Drawing.Point(49, 17)
        Me.chkColoca.Name = "chkColoca"
        Me.chkColoca.Size = New System.Drawing.Size(69, 17)
        Me.chkColoca.TabIndex = 0
        Me.chkColoca.Text = "COLOCA"
        Me.chkColoca.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtPRECO_VALOR)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.cboPRECO_TIPO)
        Me.GroupBox6.Location = New System.Drawing.Point(202, 122)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(210, 99)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PRECIFICAÇÃO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "PREÇO :"
        '
        'txtPRECO_VALOR
        '
        Me.txtPRECO_VALOR.Location = New System.Drawing.Point(69, 63)
        Me.txtPRECO_VALOR.Name = "txtPRECO_VALOR"
        Me.txtPRECO_VALOR.Size = New System.Drawing.Size(131, 20)
        Me.txtPRECO_VALOR.TabIndex = 1
        Me.txtPRECO_VALOR.Tag = "1"
        Me.txtPRECO_VALOR.Text = "270,00"
        Me.txtPRECO_VALOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "TIPO:"
        '
        'cboPRECO_TIPO
        '
        Me.cboPRECO_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPRECO_TIPO.FormattingEnabled = True
        Me.cboPRECO_TIPO.Location = New System.Drawing.Point(69, 33)
        Me.cboPRECO_TIPO.Name = "cboPRECO_TIPO"
        Me.cboPRECO_TIPO.Size = New System.Drawing.Size(131, 21)
        Me.cboPRECO_TIPO.TabIndex = 0
        Me.cboPRECO_TIPO.Tag = "1"
        '
        'txtCPF_CCM
        '
        Me.txtCPF_CCM.Location = New System.Drawing.Point(152, 71)
        Me.txtCPF_CCM.MaxLength = 100
        Me.txtCPF_CCM.Name = "txtCPF_CCM"
        Me.txtCPF_CCM.Size = New System.Drawing.Size(116, 20)
        Me.txtCPF_CCM.TabIndex = 2
        '
        'txtLIMPURB
        '
        Me.txtLIMPURB.Location = New System.Drawing.Point(274, 71)
        Me.txtLIMPURB.MaxLength = 100
        Me.txtLIMPURB.Name = "txtLIMPURB"
        Me.txtLIMPURB.Size = New System.Drawing.Size(116, 20)
        Me.txtLIMPURB.TabIndex = 3
        '
        'pesquisarTransportador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 588)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.cmdFiltrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.txtID)
        Me.KeyPreview = True
        Me.Name = "pesquisarTransportador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO / PESQUISA"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents cmdFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtProcurar As System.Windows.Forms.TextBox
    Friend WithEvents cboCampos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsDescricao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mskPRINCIPAL_CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCONTRATO_FATURAMENTO_DIAS As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCONTRATO_FORMA_PAGAMENTO As System.Windows.Forms.ComboBox
    Friend WithEvents lblCONTRATO_MULTA_DIA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_MULTA_DIA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_MULTA_MORA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_MULTA_MORA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_VCTO_APOS_ENTREGA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_VCTO_APOS_ENTREGA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_RETIRADA_AUTOMATICA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_RETIRADA_AUTOMATICA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_PERIDO_LOCACAO As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_PERIODO_LOCACAO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRetira As System.Windows.Forms.CheckBox
    Friend WithEvents chkTroca As System.Windows.Forms.CheckBox
    Friend WithEvents chkColoca As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPRECO_VALOR As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboPRECO_TIPO As System.Windows.Forms.ComboBox
    Friend WithEvents txtLIMPURB As System.Windows.Forms.TextBox
    Friend WithEvents txtCPF_CCM As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastroObra
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
        Me.tabObras = New System.Windows.Forms.TabControl()
        Me.pgObraDados = New System.Windows.Forms.TabPage()
        Me.chkRelacao = New System.Windows.Forms.CheckBox()
        Me.txtID_OBRA = New System.Windows.Forms.TextBox()
        Me.txtID_CLIENTE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCONTRATO_OBS_COLOCA = New System.Windows.Forms.TextBox()
        Me.txtCONTRATO_OBS_RETIRA = New System.Windows.Forms.TextBox()
        Me.txtCONTRATO_OBS_LIGACAO = New System.Windows.Forms.TextBox()
        Me.txtCONTRATO_OBS_TROCA = New System.Windows.Forms.TextBox()
        Me.grpOBRA = New System.Windows.Forms.GroupBox()
        Me.txtOBRA_ESTADO = New System.Windows.Forms.TextBox()
        Me.btnEnderecoObra = New System.Windows.Forms.Button()
        Me.txtOBRA_CIDADE = New System.Windows.Forms.TextBox()
        Me.mskOBRA_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblOBRA_CONTATO = New System.Windows.Forms.Label()
        Me.txtOBRA_EMAIL = New System.Windows.Forms.TextBox()
        Me.txtOBRA_TELEFONE = New System.Windows.Forms.TextBox()
        Me.txtOBRA_CONTATO = New System.Windows.Forms.TextBox()
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
        Me.dtpCONTRATO_INICIO = New System.Windows.Forms.DateTimePicker()
        Me.chkCONTRATO_NF = New System.Windows.Forms.CheckBox()
        Me.lblINICIO = New System.Windows.Forms.Label()
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
        Me.cboCONTRATO_FORMA_PAGAMENTO = New System.Windows.Forms.ComboBox()
        Me.lblCONTRATO_FORMA_PAGAMENTO = New System.Windows.Forms.Label()
        Me.lblCONTRATO_PERIDO_LOCACAO = New System.Windows.Forms.Label()
        Me.txtCONTRATO_PERIODO_LOCACAO = New System.Windows.Forms.TextBox()
        Me.cboCONTRATO_FATURAMENTO_DIAS = New System.Windows.Forms.ComboBox()
        Me.lblCONTRATO_FATURAMENTO_DIAS = New System.Windows.Forms.Label()
        Me.pgOBS = New System.Windows.Forms.TabPage()
        Me.txtCADASTRO_OBSERVACAO = New System.Windows.Forms.TextBox()
        Me.btnSalvarObra = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsREGISTRO_INSERT_USUARIO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_INSERT_EMISSAO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_UPDATE_USUARIO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_UPDATE_EMISSAO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tabObras.SuspendLayout()
        Me.pgObraDados.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpOBRA.SuspendLayout()
        Me.grpOBRA_COBRANCA.SuspendLayout()
        Me.grpOBRA_CRITERIOS.SuspendLayout()
        Me.pgOBS.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabObras
        '
        Me.tabObras.Controls.Add(Me.pgObraDados)
        Me.tabObras.Controls.Add(Me.pgOBS)
        Me.tabObras.Location = New System.Drawing.Point(12, 12)
        Me.tabObras.Name = "tabObras"
        Me.tabObras.SelectedIndex = 0
        Me.tabObras.Size = New System.Drawing.Size(813, 544)
        Me.tabObras.TabIndex = 0
        '
        'pgObraDados
        '
        Me.pgObraDados.Controls.Add(Me.GroupBox1)
        Me.pgObraDados.Controls.Add(Me.grpOBRA)
        Me.pgObraDados.Controls.Add(Me.grpOBRA_COBRANCA)
        Me.pgObraDados.Controls.Add(Me.grpOBRA_CRITERIOS)
        Me.pgObraDados.Location = New System.Drawing.Point(4, 22)
        Me.pgObraDados.Name = "pgObraDados"
        Me.pgObraDados.Padding = New System.Windows.Forms.Padding(3)
        Me.pgObraDados.Size = New System.Drawing.Size(805, 518)
        Me.pgObraDados.TabIndex = 0
        Me.pgObraDados.Text = "DADOS DA OBRA"
        Me.pgObraDados.UseVisualStyleBackColor = True
        '
        'chkRelacao
        '
        Me.chkRelacao.AutoSize = True
        Me.chkRelacao.Location = New System.Drawing.Point(108, 19)
        Me.chkRelacao.Name = "chkRelacao"
        Me.chkRelacao.Size = New System.Drawing.Size(103, 17)
        Me.chkRelacao.TabIndex = 112
        Me.chkRelacao.Text = "Relacionamento"
        Me.chkRelacao.UseVisualStyleBackColor = True
        Me.chkRelacao.Visible = False
        '
        'txtID_OBRA
        '
        Me.txtID_OBRA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID_OBRA.Location = New System.Drawing.Point(303, 16)
        Me.txtID_OBRA.MaxLength = 10
        Me.txtID_OBRA.Name = "txtID_OBRA"
        Me.txtID_OBRA.Size = New System.Drawing.Size(77, 20)
        Me.txtID_OBRA.TabIndex = 111
        Me.txtID_OBRA.Tag = "1"
        Me.txtID_OBRA.Text = "0"
        Me.txtID_OBRA.Visible = False
        '
        'txtID_CLIENTE
        '
        Me.txtID_CLIENTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID_CLIENTE.Location = New System.Drawing.Point(220, 16)
        Me.txtID_CLIENTE.MaxLength = 10
        Me.txtID_CLIENTE.Name = "txtID_CLIENTE"
        Me.txtID_CLIENTE.Size = New System.Drawing.Size(77, 20)
        Me.txtID_CLIENTE.TabIndex = 101
        Me.txtID_CLIENTE.Tag = "1"
        Me.txtID_CLIENTE.Text = "0"
        Me.txtID_CLIENTE.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkRelacao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtID_OBRA)
        Me.GroupBox1.Controls.Add(Me.txtID_CLIENTE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCONTRATO_OBS_COLOCA)
        Me.GroupBox1.Controls.Add(Me.txtCONTRATO_OBS_RETIRA)
        Me.GroupBox1.Controls.Add(Me.txtCONTRATO_OBS_LIGACAO)
        Me.GroupBox1.Controls.Add(Me.txtCONTRATO_OBS_TROCA)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 234)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OBSERVAÇÕES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(19, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "RETIRA:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(19, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "TROCA:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "COLOCA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "LIGAÇÃO:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_OBS_COLOCA
        '
        Me.txtCONTRATO_OBS_COLOCA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCONTRATO_OBS_COLOCA.Location = New System.Drawing.Point(17, 93)
        Me.txtCONTRATO_OBS_COLOCA.MaxLength = 200
        Me.txtCONTRATO_OBS_COLOCA.Name = "txtCONTRATO_OBS_COLOCA"
        Me.txtCONTRATO_OBS_COLOCA.Size = New System.Drawing.Size(363, 20)
        Me.txtCONTRATO_OBS_COLOCA.TabIndex = 1
        '
        'txtCONTRATO_OBS_RETIRA
        '
        Me.txtCONTRATO_OBS_RETIRA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCONTRATO_OBS_RETIRA.Location = New System.Drawing.Point(17, 195)
        Me.txtCONTRATO_OBS_RETIRA.MaxLength = 200
        Me.txtCONTRATO_OBS_RETIRA.Name = "txtCONTRATO_OBS_RETIRA"
        Me.txtCONTRATO_OBS_RETIRA.Size = New System.Drawing.Size(363, 20)
        Me.txtCONTRATO_OBS_RETIRA.TabIndex = 3
        '
        'txtCONTRATO_OBS_LIGACAO
        '
        Me.txtCONTRATO_OBS_LIGACAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCONTRATO_OBS_LIGACAO.Location = New System.Drawing.Point(17, 42)
        Me.txtCONTRATO_OBS_LIGACAO.MaxLength = 200
        Me.txtCONTRATO_OBS_LIGACAO.Name = "txtCONTRATO_OBS_LIGACAO"
        Me.txtCONTRATO_OBS_LIGACAO.Size = New System.Drawing.Size(363, 20)
        Me.txtCONTRATO_OBS_LIGACAO.TabIndex = 0
        '
        'txtCONTRATO_OBS_TROCA
        '
        Me.txtCONTRATO_OBS_TROCA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCONTRATO_OBS_TROCA.Location = New System.Drawing.Point(17, 140)
        Me.txtCONTRATO_OBS_TROCA.MaxLength = 200
        Me.txtCONTRATO_OBS_TROCA.Name = "txtCONTRATO_OBS_TROCA"
        Me.txtCONTRATO_OBS_TROCA.Size = New System.Drawing.Size(363, 20)
        Me.txtCONTRATO_OBS_TROCA.TabIndex = 2
        '
        'grpOBRA
        '
        Me.grpOBRA.Controls.Add(Me.txtOBRA_ESTADO)
        Me.grpOBRA.Controls.Add(Me.btnEnderecoObra)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_CIDADE)
        Me.grpOBRA.Controls.Add(Me.mskOBRA_CEP)
        Me.grpOBRA.Controls.Add(Me.lblOBRA_CONTATO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_EMAIL)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_TELEFONE)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_CONTATO)
        Me.grpOBRA.Controls.Add(Me.lblOBRA_BAIRRO)
        Me.grpOBRA.Controls.Add(Me.lblOBRA_NUMERO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_BAIRRO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_COMPLEMENTO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_NUMERO)
        Me.grpOBRA.Controls.Add(Me.txtOBRA_ENDERECO)
        Me.grpOBRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOBRA.Location = New System.Drawing.Point(9, 6)
        Me.grpOBRA.Name = "grpOBRA"
        Me.grpOBRA.Size = New System.Drawing.Size(788, 125)
        Me.grpOBRA.TabIndex = 96
        Me.grpOBRA.TabStop = False
        Me.grpOBRA.Text = "OBRA"
        '
        'txtOBRA_ESTADO
        '
        Me.txtOBRA_ESTADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_ESTADO.Location = New System.Drawing.Point(731, 66)
        Me.txtOBRA_ESTADO.MaxLength = 2
        Me.txtOBRA_ESTADO.Name = "txtOBRA_ESTADO"
        Me.txtOBRA_ESTADO.Size = New System.Drawing.Size(49, 20)
        Me.txtOBRA_ESTADO.TabIndex = 7
        Me.txtOBRA_ESTADO.Tag = "1"
        '
        'btnEnderecoObra
        '
        Me.btnEnderecoObra.ForeColor = System.Drawing.Color.Maroon
        Me.btnEnderecoObra.Location = New System.Drawing.Point(6, 16)
        Me.btnEnderecoObra.Name = "btnEnderecoObra"
        Me.btnEnderecoObra.Size = New System.Drawing.Size(157, 22)
        Me.btnEnderecoObra.TabIndex = 0
        Me.btnEnderecoObra.Text = "ENDERECO OBRA"
        Me.btnEnderecoObra.UseVisualStyleBackColor = True
        '
        'txtOBRA_CIDADE
        '
        Me.txtOBRA_CIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_CIDADE.Location = New System.Drawing.Point(445, 66)
        Me.txtOBRA_CIDADE.MaxLength = 100
        Me.txtOBRA_CIDADE.Name = "txtOBRA_CIDADE"
        Me.txtOBRA_CIDADE.Size = New System.Drawing.Size(280, 20)
        Me.txtOBRA_CIDADE.TabIndex = 6
        Me.txtOBRA_CIDADE.Tag = "1"
        '
        'mskOBRA_CEP
        '
        Me.mskOBRA_CEP.Location = New System.Drawing.Point(169, 13)
        Me.mskOBRA_CEP.Mask = "00000-000"
        Me.mskOBRA_CEP.Name = "mskOBRA_CEP"
        Me.mskOBRA_CEP.Size = New System.Drawing.Size(104, 20)
        Me.mskOBRA_CEP.TabIndex = 1
        Me.mskOBRA_CEP.Tag = "1"
        '
        'lblOBRA_CONTATO
        '
        Me.lblOBRA_CONTATO.AutoSize = True
        Me.lblOBRA_CONTATO.ForeColor = System.Drawing.Color.Maroon
        Me.lblOBRA_CONTATO.Location = New System.Drawing.Point(12, 97)
        Me.lblOBRA_CONTATO.Name = "lblOBRA_CONTATO"
        Me.lblOBRA_CONTATO.Size = New System.Drawing.Size(155, 13)
        Me.lblOBRA_CONTATO.TabIndex = 21
        Me.lblOBRA_CONTATO.Text = "NOME / TELEFONE / E-MAIL:"
        '
        'txtOBRA_EMAIL
        '
        Me.txtOBRA_EMAIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtOBRA_EMAIL.Location = New System.Drawing.Point(559, 90)
        Me.txtOBRA_EMAIL.MaxLength = 120
        Me.txtOBRA_EMAIL.Name = "txtOBRA_EMAIL"
        Me.txtOBRA_EMAIL.Size = New System.Drawing.Size(221, 20)
        Me.txtOBRA_EMAIL.TabIndex = 10
        Me.txtOBRA_EMAIL.Tag = "1"
        '
        'txtOBRA_TELEFONE
        '
        Me.txtOBRA_TELEFONE.Location = New System.Drawing.Point(366, 90)
        Me.txtOBRA_TELEFONE.MaxLength = 50
        Me.txtOBRA_TELEFONE.Name = "txtOBRA_TELEFONE"
        Me.txtOBRA_TELEFONE.Size = New System.Drawing.Size(187, 20)
        Me.txtOBRA_TELEFONE.TabIndex = 9
        Me.txtOBRA_TELEFONE.Tag = "1"
        '
        'txtOBRA_CONTATO
        '
        Me.txtOBRA_CONTATO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_CONTATO.Location = New System.Drawing.Point(169, 90)
        Me.txtOBRA_CONTATO.MaxLength = 50
        Me.txtOBRA_CONTATO.Name = "txtOBRA_CONTATO"
        Me.txtOBRA_CONTATO.Size = New System.Drawing.Size(187, 20)
        Me.txtOBRA_CONTATO.TabIndex = 8
        Me.txtOBRA_CONTATO.Tag = "1"
        '
        'lblOBRA_BAIRRO
        '
        Me.lblOBRA_BAIRRO.AutoSize = True
        Me.lblOBRA_BAIRRO.Location = New System.Drawing.Point(11, 73)
        Me.lblOBRA_BAIRRO.Name = "lblOBRA_BAIRRO"
        Me.lblOBRA_BAIRRO.Size = New System.Drawing.Size(127, 13)
        Me.lblOBRA_BAIRRO.TabIndex = 12
        Me.lblOBRA_BAIRRO.Text = "BAIRRO / CIDADE / UF:"
        '
        'lblOBRA_NUMERO
        '
        Me.lblOBRA_NUMERO.AutoSize = True
        Me.lblOBRA_NUMERO.ForeColor = System.Drawing.Color.Maroon
        Me.lblOBRA_NUMERO.Location = New System.Drawing.Point(11, 45)
        Me.lblOBRA_NUMERO.Name = "lblOBRA_NUMERO"
        Me.lblOBRA_NUMERO.Size = New System.Drawing.Size(152, 13)
        Me.lblOBRA_NUMERO.TabIndex = 9
        Me.lblOBRA_NUMERO.Text = "NUMERO / COMPLEMENTO:"
        '
        'txtOBRA_BAIRRO
        '
        Me.txtOBRA_BAIRRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_BAIRRO.Location = New System.Drawing.Point(169, 66)
        Me.txtOBRA_BAIRRO.MaxLength = 50
        Me.txtOBRA_BAIRRO.Name = "txtOBRA_BAIRRO"
        Me.txtOBRA_BAIRRO.Size = New System.Drawing.Size(270, 20)
        Me.txtOBRA_BAIRRO.TabIndex = 5
        Me.txtOBRA_BAIRRO.Tag = "1"
        '
        'txtOBRA_COMPLEMENTO
        '
        Me.txtOBRA_COMPLEMENTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOBRA_COMPLEMENTO.Location = New System.Drawing.Point(278, 38)
        Me.txtOBRA_COMPLEMENTO.MaxLength = 50
        Me.txtOBRA_COMPLEMENTO.Name = "txtOBRA_COMPLEMENTO"
        Me.txtOBRA_COMPLEMENTO.Size = New System.Drawing.Size(502, 20)
        Me.txtOBRA_COMPLEMENTO.TabIndex = 4
        Me.txtOBRA_COMPLEMENTO.Tag = "1"
        '
        'txtOBRA_NUMERO
        '
        Me.txtOBRA_NUMERO.Location = New System.Drawing.Point(169, 38)
        Me.txtOBRA_NUMERO.MaxLength = 10
        Me.txtOBRA_NUMERO.Name = "txtOBRA_NUMERO"
        Me.txtOBRA_NUMERO.Size = New System.Drawing.Size(103, 20)
        Me.txtOBRA_NUMERO.TabIndex = 3
        Me.txtOBRA_NUMERO.Tag = "1"
        '
        'txtOBRA_ENDERECO
        '
        Me.txtOBRA_ENDERECO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.grpOBRA_COBRANCA.Location = New System.Drawing.Point(9, 133)
        Me.grpOBRA_COBRANCA.Name = "grpOBRA_COBRANCA"
        Me.grpOBRA_COBRANCA.Size = New System.Drawing.Size(788, 133)
        Me.grpOBRA_COBRANCA.TabIndex = 97
        Me.grpOBRA_COBRANCA.TabStop = False
        Me.grpOBRA_COBRANCA.Text = "COBRANÇA"
        '
        'cboCOBRANCA_TIPO
        '
        Me.cboCOBRANCA_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCOBRANCA_TIPO.FormattingEnabled = True
        Me.cboCOBRANCA_TIPO.Items.AddRange(New Object() {"FISICO", "JURIDICO"})
        Me.cboCOBRANCA_TIPO.Location = New System.Drawing.Point(72, 17)
        Me.cboCOBRANCA_TIPO.Name = "cboCOBRANCA_TIPO"
        Me.cboCOBRANCA_TIPO.Size = New System.Drawing.Size(91, 21)
        Me.cboCOBRANCA_TIPO.TabIndex = 0
        Me.cboCOBRANCA_TIPO.Tag = "1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(10, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "SACADO:"
        '
        'txtCOBRANCA_SACADO
        '
        Me.txtCOBRANCA_SACADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_SACADO.Location = New System.Drawing.Point(278, 19)
        Me.txtCOBRANCA_SACADO.MaxLength = 40
        Me.txtCOBRANCA_SACADO.Name = "txtCOBRANCA_SACADO"
        Me.txtCOBRANCA_SACADO.Size = New System.Drawing.Size(502, 20)
        Me.txtCOBRANCA_SACADO.TabIndex = 2
        Me.txtCOBRANCA_SACADO.Tag = "1"
        '
        'mskCOBRANCA_INSCRICAO
        '
        Me.mskCOBRANCA_INSCRICAO.Location = New System.Drawing.Point(169, 18)
        Me.mskCOBRANCA_INSCRICAO.Name = "mskCOBRANCA_INSCRICAO"
        Me.mskCOBRANCA_INSCRICAO.Size = New System.Drawing.Size(103, 20)
        Me.mskCOBRANCA_INSCRICAO.TabIndex = 1
        Me.mskCOBRANCA_INSCRICAO.Tag = "1"
        '
        'txtCOBRANCA_ESTADO
        '
        Me.txtCOBRANCA_ESTADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_ESTADO.Location = New System.Drawing.Point(731, 81)
        Me.txtCOBRANCA_ESTADO.MaxLength = 2
        Me.txtCOBRANCA_ESTADO.Name = "txtCOBRANCA_ESTADO"
        Me.txtCOBRANCA_ESTADO.Size = New System.Drawing.Size(49, 20)
        Me.txtCOBRANCA_ESTADO.TabIndex = 7
        Me.txtCOBRANCA_ESTADO.Tag = "1"
        '
        'txtCOBRANCA_CIDADE
        '
        Me.txtCOBRANCA_CIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_CIDADE.Location = New System.Drawing.Point(445, 81)
        Me.txtCOBRANCA_CIDADE.MaxLength = 15
        Me.txtCOBRANCA_CIDADE.Name = "txtCOBRANCA_CIDADE"
        Me.txtCOBRANCA_CIDADE.Size = New System.Drawing.Size(280, 20)
        Me.txtCOBRANCA_CIDADE.TabIndex = 6
        Me.txtCOBRANCA_CIDADE.Tag = "1"
        '
        'mskCOBRANCA_CEP
        '
        Me.mskCOBRANCA_CEP.Location = New System.Drawing.Point(169, 54)
        Me.mskCOBRANCA_CEP.Mask = "00000-000"
        Me.mskCOBRANCA_CEP.Name = "mskCOBRANCA_CEP"
        Me.mskCOBRANCA_CEP.Size = New System.Drawing.Size(103, 20)
        Me.mskCOBRANCA_CEP.TabIndex = 3
        Me.mskCOBRANCA_CEP.Tag = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(11, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "NOME / TELEFONE / E-MAIL:"
        '
        'txtCOBRANCA_EMAIL
        '
        Me.txtCOBRANCA_EMAIL.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCOBRANCA_EMAIL.Location = New System.Drawing.Point(559, 108)
        Me.txtCOBRANCA_EMAIL.MaxLength = 120
        Me.txtCOBRANCA_EMAIL.Name = "txtCOBRANCA_EMAIL"
        Me.txtCOBRANCA_EMAIL.Size = New System.Drawing.Size(221, 20)
        Me.txtCOBRANCA_EMAIL.TabIndex = 10
        Me.txtCOBRANCA_EMAIL.Tag = "1"
        '
        'txtCOBRANCA_TELEFONE
        '
        Me.txtCOBRANCA_TELEFONE.Location = New System.Drawing.Point(366, 107)
        Me.txtCOBRANCA_TELEFONE.MaxLength = 50
        Me.txtCOBRANCA_TELEFONE.Name = "txtCOBRANCA_TELEFONE"
        Me.txtCOBRANCA_TELEFONE.Size = New System.Drawing.Size(187, 20)
        Me.txtCOBRANCA_TELEFONE.TabIndex = 9
        Me.txtCOBRANCA_TELEFONE.Tag = "1"
        '
        'txtCOBRANCA_NOME
        '
        Me.txtCOBRANCA_NOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_NOME.Location = New System.Drawing.Point(169, 107)
        Me.txtCOBRANCA_NOME.MaxLength = 15
        Me.txtCOBRANCA_NOME.Name = "txtCOBRANCA_NOME"
        Me.txtCOBRANCA_NOME.Size = New System.Drawing.Size(187, 20)
        Me.txtCOBRANCA_NOME.TabIndex = 8
        Me.txtCOBRANCA_NOME.Tag = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(10, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "BAIRRO / CIDADE / UF:"
        '
        'txtCOBRANCA_BAIRRO
        '
        Me.txtCOBRANCA_BAIRRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_BAIRRO.Location = New System.Drawing.Point(169, 80)
        Me.txtCOBRANCA_BAIRRO.MaxLength = 12
        Me.txtCOBRANCA_BAIRRO.Name = "txtCOBRANCA_BAIRRO"
        Me.txtCOBRANCA_BAIRRO.Size = New System.Drawing.Size(270, 20)
        Me.txtCOBRANCA_BAIRRO.TabIndex = 5
        Me.txtCOBRANCA_BAIRRO.Tag = "1"
        '
        'txtCOBRANCA_LOGRADOURO
        '
        Me.txtCOBRANCA_LOGRADOURO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCOBRANCA_LOGRADOURO.Location = New System.Drawing.Point(278, 54)
        Me.txtCOBRANCA_LOGRADOURO.MaxLength = 40
        Me.txtCOBRANCA_LOGRADOURO.Name = "txtCOBRANCA_LOGRADOURO"
        Me.txtCOBRANCA_LOGRADOURO.Size = New System.Drawing.Size(502, 20)
        Me.txtCOBRANCA_LOGRADOURO.TabIndex = 4
        Me.txtCOBRANCA_LOGRADOURO.Tag = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(10, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "CEP / RUA / NUM / COMP:"
        '
        'grpOBRA_CRITERIOS
        '
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.chkCONTRATO_CTR)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.chkCONTRATO_ISS)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.dtpCONTRATO_INICIO)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.chkCONTRATO_NF)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblINICIO)
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
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.cboCONTRATO_FORMA_PAGAMENTO)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_FORMA_PAGAMENTO)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_PERIDO_LOCACAO)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.txtCONTRATO_PERIODO_LOCACAO)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.cboCONTRATO_FATURAMENTO_DIAS)
        Me.grpOBRA_CRITERIOS.Controls.Add(Me.lblCONTRATO_FATURAMENTO_DIAS)
        Me.grpOBRA_CRITERIOS.Location = New System.Drawing.Point(414, 272)
        Me.grpOBRA_CRITERIOS.Name = "grpOBRA_CRITERIOS"
        Me.grpOBRA_CRITERIOS.Size = New System.Drawing.Size(383, 234)
        Me.grpOBRA_CRITERIOS.TabIndex = 0
        Me.grpOBRA_CRITERIOS.TabStop = False
        Me.grpOBRA_CRITERIOS.Text = "CRITERIOS"
        '
        'chkCONTRATO_CTR
        '
        Me.chkCONTRATO_CTR.AutoSize = True
        Me.chkCONTRATO_CTR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCONTRATO_CTR.ForeColor = System.Drawing.Color.Maroon
        Me.chkCONTRATO_CTR.Location = New System.Drawing.Point(291, 203)
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
        Me.chkCONTRATO_ISS.ForeColor = System.Drawing.Color.Maroon
        Me.chkCONTRATO_ISS.Location = New System.Drawing.Point(208, 203)
        Me.chkCONTRATO_ISS.Name = "chkCONTRATO_ISS"
        Me.chkCONTRATO_ISS.Size = New System.Drawing.Size(46, 17)
        Me.chkCONTRATO_ISS.TabIndex = 10
        Me.chkCONTRATO_ISS.Text = "ISS:"
        Me.chkCONTRATO_ISS.UseVisualStyleBackColor = True
        '
        'dtpCONTRATO_INICIO
        '
        Me.dtpCONTRATO_INICIO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCONTRATO_INICIO.Location = New System.Drawing.Point(174, 19)
        Me.dtpCONTRATO_INICIO.Name = "dtpCONTRATO_INICIO"
        Me.dtpCONTRATO_INICIO.Size = New System.Drawing.Size(201, 20)
        Me.dtpCONTRATO_INICIO.TabIndex = 0
        '
        'chkCONTRATO_NF
        '
        Me.chkCONTRATO_NF.AutoSize = True
        Me.chkCONTRATO_NF.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCONTRATO_NF.ForeColor = System.Drawing.Color.Maroon
        Me.chkCONTRATO_NF.Location = New System.Drawing.Point(85, 203)
        Me.chkCONTRATO_NF.Name = "chkCONTRATO_NF"
        Me.chkCONTRATO_NF.Size = New System.Drawing.Size(98, 17)
        Me.chkCONTRATO_NF.TabIndex = 9
        Me.chkCONTRATO_NF.Text = "NOTA FISCAL:"
        Me.chkCONTRATO_NF.UseVisualStyleBackColor = True
        '
        'lblINICIO
        '
        Me.lblINICIO.AutoSize = True
        Me.lblINICIO.ForeColor = System.Drawing.Color.Maroon
        Me.lblINICIO.Location = New System.Drawing.Point(45, 25)
        Me.lblINICIO.Name = "lblINICIO"
        Me.lblINICIO.Size = New System.Drawing.Size(124, 13)
        Me.lblINICIO.TabIndex = 90
        Me.lblINICIO.Text = "INICIO DO CONTRATO:"
        Me.lblINICIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCONTRATO_VALOR
        '
        Me.lblCONTRATO_VALOR.AutoSize = True
        Me.lblCONTRATO_VALOR.ForeColor = System.Drawing.Color.Maroon
        Me.lblCONTRATO_VALOR.Location = New System.Drawing.Point(241, 114)
        Me.lblCONTRATO_VALOR.Name = "lblCONTRATO_VALOR"
        Me.lblCONTRATO_VALOR.Size = New System.Drawing.Size(46, 13)
        Me.lblCONTRATO_VALOR.TabIndex = 89
        Me.lblCONTRATO_VALOR.Text = "VALOR:"
        Me.lblCONTRATO_VALOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_VALOR
        '
        Me.txtCONTRATO_VALOR.Location = New System.Drawing.Point(288, 111)
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
        Me.lblCONTRATO_MULTA_DIA.ForeColor = System.Drawing.Color.Maroon
        Me.lblCONTRATO_MULTA_DIA.Location = New System.Drawing.Point(219, 167)
        Me.lblCONTRATO_MULTA_DIA.Name = "lblCONTRATO_MULTA_DIA"
        Me.lblCONTRATO_MULTA_DIA.Size = New System.Drawing.Size(68, 13)
        Me.lblCONTRATO_MULTA_DIA.TabIndex = 88
        Me.lblCONTRATO_MULTA_DIA.Text = "MULTA DIA:"
        Me.lblCONTRATO_MULTA_DIA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_MULTA_DIA
        '
        Me.txtCONTRATO_MULTA_DIA.Location = New System.Drawing.Point(288, 164)
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
        Me.lblCONTRATO_MULTA_MORA.ForeColor = System.Drawing.Color.Maroon
        Me.lblCONTRATO_MULTA_MORA.Location = New System.Drawing.Point(205, 140)
        Me.lblCONTRATO_MULTA_MORA.Name = "lblCONTRATO_MULTA_MORA"
        Me.lblCONTRATO_MULTA_MORA.Size = New System.Drawing.Size(82, 13)
        Me.lblCONTRATO_MULTA_MORA.TabIndex = 87
        Me.lblCONTRATO_MULTA_MORA.Text = "MULTA MORA:"
        Me.lblCONTRATO_MULTA_MORA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_MULTA_MORA
        '
        Me.txtCONTRATO_MULTA_MORA.Location = New System.Drawing.Point(288, 137)
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
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.ForeColor = System.Drawing.Color.Maroon
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Location = New System.Drawing.Point(13, 167)
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Name = "lblCONTRATO_VCTO_APOS_ENTREGA"
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Size = New System.Drawing.Size(81, 13)
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.TabIndex = 86
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Text = "VENCIMENTO:"
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_VCTO_APOS_ENTREGA
        '
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Location = New System.Drawing.Point(96, 164)
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
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.ForeColor = System.Drawing.Color.Maroon
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Location = New System.Drawing.Point(30, 140)
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Name = "lblCONTRATO_RETIRADA_AUTOMATICA"
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Size = New System.Drawing.Size(65, 13)
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.TabIndex = 85
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Text = "RETIRADA:"
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_RETIRADA_AUTOMATICA
        '
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Location = New System.Drawing.Point(96, 137)
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Name = "txtCONTRATO_RETIRADA_AUTOMATICA"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Size = New System.Drawing.Size(89, 20)
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.TabIndex = 4
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Tag = "1"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text = "0"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboCONTRATO_FORMA_PAGAMENTO
        '
        Me.cboCONTRATO_FORMA_PAGAMENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCONTRATO_FORMA_PAGAMENTO.FormattingEnabled = True
        Me.cboCONTRATO_FORMA_PAGAMENTO.Location = New System.Drawing.Point(176, 48)
        Me.cboCONTRATO_FORMA_PAGAMENTO.Name = "cboCONTRATO_FORMA_PAGAMENTO"
        Me.cboCONTRATO_FORMA_PAGAMENTO.Size = New System.Drawing.Size(201, 21)
        Me.cboCONTRATO_FORMA_PAGAMENTO.TabIndex = 1
        Me.cboCONTRATO_FORMA_PAGAMENTO.Tag = "1"
        '
        'lblCONTRATO_FORMA_PAGAMENTO
        '
        Me.lblCONTRATO_FORMA_PAGAMENTO.AutoSize = True
        Me.lblCONTRATO_FORMA_PAGAMENTO.ForeColor = System.Drawing.Color.Maroon
        Me.lblCONTRATO_FORMA_PAGAMENTO.Location = New System.Drawing.Point(32, 51)
        Me.lblCONTRATO_FORMA_PAGAMENTO.Name = "lblCONTRATO_FORMA_PAGAMENTO"
        Me.lblCONTRATO_FORMA_PAGAMENTO.Size = New System.Drawing.Size(137, 13)
        Me.lblCONTRATO_FORMA_PAGAMENTO.TabIndex = 84
        Me.lblCONTRATO_FORMA_PAGAMENTO.Text = "FORMA DE PAGAMENTO:"
        Me.lblCONTRATO_FORMA_PAGAMENTO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCONTRATO_PERIDO_LOCACAO
        '
        Me.lblCONTRATO_PERIDO_LOCACAO.AutoSize = True
        Me.lblCONTRATO_PERIDO_LOCACAO.ForeColor = System.Drawing.Color.Maroon
        Me.lblCONTRATO_PERIDO_LOCACAO.Location = New System.Drawing.Point(35, 114)
        Me.lblCONTRATO_PERIDO_LOCACAO.Name = "lblCONTRATO_PERIDO_LOCACAO"
        Me.lblCONTRATO_PERIDO_LOCACAO.Size = New System.Drawing.Size(60, 13)
        Me.lblCONTRATO_PERIDO_LOCACAO.TabIndex = 83
        Me.lblCONTRATO_PERIDO_LOCACAO.Text = "LOCAÇÃO:"
        Me.lblCONTRATO_PERIDO_LOCACAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCONTRATO_PERIODO_LOCACAO
        '
        Me.txtCONTRATO_PERIODO_LOCACAO.Location = New System.Drawing.Point(96, 111)
        Me.txtCONTRATO_PERIODO_LOCACAO.Name = "txtCONTRATO_PERIODO_LOCACAO"
        Me.txtCONTRATO_PERIODO_LOCACAO.Size = New System.Drawing.Size(89, 20)
        Me.txtCONTRATO_PERIODO_LOCACAO.TabIndex = 3
        Me.txtCONTRATO_PERIODO_LOCACAO.Tag = "1"
        Me.txtCONTRATO_PERIODO_LOCACAO.Text = "0"
        Me.txtCONTRATO_PERIODO_LOCACAO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboCONTRATO_FATURAMENTO_DIAS
        '
        Me.cboCONTRATO_FATURAMENTO_DIAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCONTRATO_FATURAMENTO_DIAS.FormattingEnabled = True
        Me.cboCONTRATO_FATURAMENTO_DIAS.Location = New System.Drawing.Point(176, 75)
        Me.cboCONTRATO_FATURAMENTO_DIAS.Name = "cboCONTRATO_FATURAMENTO_DIAS"
        Me.cboCONTRATO_FATURAMENTO_DIAS.Size = New System.Drawing.Size(201, 21)
        Me.cboCONTRATO_FATURAMENTO_DIAS.TabIndex = 2
        Me.cboCONTRATO_FATURAMENTO_DIAS.Tag = "1"
        '
        'lblCONTRATO_FATURAMENTO_DIAS
        '
        Me.lblCONTRATO_FATURAMENTO_DIAS.AutoSize = True
        Me.lblCONTRATO_FATURAMENTO_DIAS.ForeColor = System.Drawing.Color.Maroon
        Me.lblCONTRATO_FATURAMENTO_DIAS.Location = New System.Drawing.Point(19, 78)
        Me.lblCONTRATO_FATURAMENTO_DIAS.Name = "lblCONTRATO_FATURAMENTO_DIAS"
        Me.lblCONTRATO_FATURAMENTO_DIAS.Size = New System.Drawing.Size(151, 13)
        Me.lblCONTRATO_FATURAMENTO_DIAS.TabIndex = 82
        Me.lblCONTRATO_FATURAMENTO_DIAS.Text = "FORMA DE FATURAMENTO:"
        Me.lblCONTRATO_FATURAMENTO_DIAS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pgOBS
        '
        Me.pgOBS.Controls.Add(Me.txtCADASTRO_OBSERVACAO)
        Me.pgOBS.Location = New System.Drawing.Point(4, 22)
        Me.pgOBS.Name = "pgOBS"
        Me.pgOBS.Padding = New System.Windows.Forms.Padding(3)
        Me.pgOBS.Size = New System.Drawing.Size(805, 518)
        Me.pgOBS.TabIndex = 2
        Me.pgOBS.Text = "OBSERVAÇÃO SOBRE O CADASTRO"
        Me.pgOBS.UseVisualStyleBackColor = True
        '
        'txtCADASTRO_OBSERVACAO
        '
        Me.txtCADASTRO_OBSERVACAO.Location = New System.Drawing.Point(35, 27)
        Me.txtCADASTRO_OBSERVACAO.Multiline = True
        Me.txtCADASTRO_OBSERVACAO.Name = "txtCADASTRO_OBSERVACAO"
        Me.txtCADASTRO_OBSERVACAO.Size = New System.Drawing.Size(727, 468)
        Me.txtCADASTRO_OBSERVACAO.TabIndex = 0
        '
        'btnSalvarObra
        '
        Me.btnSalvarObra.Location = New System.Drawing.Point(831, 34)
        Me.btnSalvarObra.Name = "btnSalvarObra"
        Me.btnSalvarObra.Size = New System.Drawing.Size(109, 32)
        Me.btnSalvarObra.TabIndex = 109
        Me.btnSalvarObra.Text = "NOVO"
        Me.btnSalvarObra.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsREGISTRO_INSERT_USUARIO, Me.stsREGISTRO_INSERT_EMISSAO, Me.stsREGISTRO_UPDATE_USUARIO, Me.stsREGISTRO_UPDATE_EMISSAO})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 562)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(959, 22)
        Me.StatusStrip1.TabIndex = 112
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
        'cadastroObra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 584)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tabObras)
        Me.Controls.Add(Me.btnSalvarObra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "cadastroObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE OBRA"
        Me.tabObras.ResumeLayout(False)
        Me.pgObraDados.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpOBRA.ResumeLayout(False)
        Me.grpOBRA.PerformLayout()
        Me.grpOBRA_COBRANCA.ResumeLayout(False)
        Me.grpOBRA_COBRANCA.PerformLayout()
        Me.grpOBRA_CRITERIOS.ResumeLayout(False)
        Me.grpOBRA_CRITERIOS.PerformLayout()
        Me.pgOBS.ResumeLayout(False)
        Me.pgOBS.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabObras As System.Windows.Forms.TabControl
    Friend WithEvents pgObraDados As System.Windows.Forms.TabPage
    Friend WithEvents grpOBRA As System.Windows.Forms.GroupBox
    Friend WithEvents txtOBRA_ESTADO As System.Windows.Forms.TextBox
    Friend WithEvents txtOBRA_CIDADE As System.Windows.Forms.TextBox
    Friend WithEvents mskOBRA_CEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblOBRA_CONTATO As System.Windows.Forms.Label
    Friend WithEvents txtOBRA_EMAIL As System.Windows.Forms.TextBox
    Friend WithEvents txtOBRA_TELEFONE As System.Windows.Forms.TextBox
    Friend WithEvents txtOBRA_CONTATO As System.Windows.Forms.TextBox
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
    Friend WithEvents btnEnderecoObra As System.Windows.Forms.Button
    Friend WithEvents btnSalvarObra As System.Windows.Forms.Button
    Friend WithEvents grpOBRA_CRITERIOS As System.Windows.Forms.GroupBox
    Friend WithEvents chkCONTRATO_CTR As System.Windows.Forms.CheckBox
    Friend WithEvents chkCONTRATO_ISS As System.Windows.Forms.CheckBox
    Friend WithEvents dtpCONTRATO_INICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkCONTRATO_NF As System.Windows.Forms.CheckBox
    Friend WithEvents lblINICIO As System.Windows.Forms.Label
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
    Friend WithEvents cboCONTRATO_FORMA_PAGAMENTO As System.Windows.Forms.ComboBox
    Friend WithEvents lblCONTRATO_FORMA_PAGAMENTO As System.Windows.Forms.Label
    Friend WithEvents lblCONTRATO_PERIDO_LOCACAO As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_PERIODO_LOCACAO As System.Windows.Forms.TextBox
    Friend WithEvents cboCONTRATO_FATURAMENTO_DIAS As System.Windows.Forms.ComboBox
    Friend WithEvents lblCONTRATO_FATURAMENTO_DIAS As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_OBS_COLOCA As System.Windows.Forms.TextBox
    Friend WithEvents txtCONTRATO_OBS_RETIRA As System.Windows.Forms.TextBox
    Friend WithEvents txtCONTRATO_OBS_LIGACAO As System.Windows.Forms.TextBox
    Friend WithEvents txtCONTRATO_OBS_TROCA As System.Windows.Forms.TextBox
    Friend WithEvents txtID_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents txtID_OBRA As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents pgOBS As System.Windows.Forms.TabPage
    Friend WithEvents txtCADASTRO_OBSERVACAO As System.Windows.Forms.TextBox
    Friend WithEvents chkRelacao As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsREGISTRO_INSERT_USUARIO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_INSERT_EMISSAO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_UPDATE_USUARIO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_UPDATE_EMISSAO As System.Windows.Forms.ToolStripStatusLabel
End Class

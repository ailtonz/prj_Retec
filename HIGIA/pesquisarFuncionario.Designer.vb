<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisarFuncionario
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsDescricao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgeDados = New System.Windows.Forms.TabPage()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCargos = New System.Windows.Forms.ComboBox()
        Me.txtContato = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.mskIE_RG = New System.Windows.Forms.MaskedTextBox()
        Me.mskCNPJ_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.pgeEndereco = New System.Windows.Forms.TabPage()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.cboCidade = New System.Windows.Forms.ComboBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.mskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.pgeDados.SuspendLayout()
        Me.pgeEndereco.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(12, 272)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(762, 284)
        Me.dgvDados.TabIndex = 4
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltrar.Location = New System.Drawing.Point(699, 229)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdFiltrar.TabIndex = 3
        Me.cmdFiltrar.Text = "FILTRAR"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'txtProcurar
        '
        Me.txtProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcurar.Location = New System.Drawing.Point(152, 22)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(431, 20)
        Me.txtProcurar.TabIndex = 1
        '
        'cboCampos
        '
        Me.cboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampos.FormattingEnabled = True
        Me.cboCampos.Location = New System.Drawing.Point(13, 21)
        Me.cboCampos.Name = "cboCampos"
        Me.cboCampos.Size = New System.Drawing.Size(133, 21)
        Me.cboCampos.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(699, 144)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTRO"
        '
        'txtLimite
        '
        Me.txtLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLimite.Location = New System.Drawing.Point(589, 22)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(59, 20)
        Me.txtLimite.TabIndex = 2
        Me.txtLimite.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(699, 24)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "SALVAR"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(699, 53)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Location = New System.Drawing.Point(699, 114)
        Me.txtUser.MaxLength = 10
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(59, 20)
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
        Me.StatusStrip1.Size = New System.Drawing.Size(791, 22)
        Me.StatusStrip1.TabIndex = 111
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsDescricao
        '
        Me.stsDescricao.Name = "stsDescricao"
        Me.stsDescricao.Size = New System.Drawing.Size(0, 17)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pgeDados)
        Me.TabControl1.Controls.Add(Me.pgeEndereco)
        Me.TabControl1.Location = New System.Drawing.Point(12, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(648, 194)
        Me.TabControl1.TabIndex = 0
        '
        'pgeDados
        '
        Me.pgeDados.Controls.Add(Me.txtSalario)
        Me.pgeDados.Controls.Add(Me.Label9)
        Me.pgeDados.Controls.Add(Me.Label8)
        Me.pgeDados.Controls.Add(Me.Label7)
        Me.pgeDados.Controls.Add(Me.Label1)
        Me.pgeDados.Controls.Add(Me.Label6)
        Me.pgeDados.Controls.Add(Me.cboCargos)
        Me.pgeDados.Controls.Add(Me.txtContato)
        Me.pgeDados.Controls.Add(Me.txtEmail)
        Me.pgeDados.Controls.Add(Me.txtTelefone)
        Me.pgeDados.Controls.Add(Me.txtNome)
        Me.pgeDados.Controls.Add(Me.mskIE_RG)
        Me.pgeDados.Controls.Add(Me.mskCNPJ_CPF)
        Me.pgeDados.Location = New System.Drawing.Point(4, 22)
        Me.pgeDados.Name = "pgeDados"
        Me.pgeDados.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeDados.Size = New System.Drawing.Size(640, 168)
        Me.pgeDados.TabIndex = 0
        Me.pgeDados.Text = "DADOS"
        Me.pgeDados.UseVisualStyleBackColor = True
        '
        'txtSalario
        '
        Me.txtSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalario.Location = New System.Drawing.Point(464, 50)
        Me.txtSalario.MaxLength = 100
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(170, 20)
        Me.txtSalario.TabIndex = 4
        Me.txtSalario.Tag = "1"
        Me.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "CONTATO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "E-MAIL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "TELEFONE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "NOME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "IDENTIFICAÇÃO:"
        '
        'cboCargos
        '
        Me.cboCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCargos.FormattingEnabled = True
        Me.cboCargos.Location = New System.Drawing.Point(464, 24)
        Me.cboCargos.Name = "cboCargos"
        Me.cboCargos.Size = New System.Drawing.Size(170, 21)
        Me.cboCargos.TabIndex = 2
        Me.cboCargos.Tag = "0"
        '
        'txtContato
        '
        Me.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContato.Location = New System.Drawing.Point(148, 129)
        Me.txtContato.MaxLength = 50
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(486, 20)
        Me.txtContato.TabIndex = 7
        Me.txtContato.Tag = "1"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(148, 103)
        Me.txtEmail.MaxLength = 120
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(486, 20)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.Tag = "1"
        '
        'txtTelefone
        '
        Me.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefone.Location = New System.Drawing.Point(148, 76)
        Me.txtTelefone.MaxLength = 50
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(486, 20)
        Me.txtTelefone.TabIndex = 5
        Me.txtTelefone.Tag = "1"
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(148, 50)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(310, 20)
        Me.txtNome.TabIndex = 3
        Me.txtNome.Tag = "1"
        '
        'mskIE_RG
        '
        Me.mskIE_RG.Location = New System.Drawing.Point(274, 24)
        Me.mskIE_RG.Name = "mskIE_RG"
        Me.mskIE_RG.Size = New System.Drawing.Size(184, 20)
        Me.mskIE_RG.TabIndex = 1
        '
        'mskCNPJ_CPF
        '
        Me.mskCNPJ_CPF.Location = New System.Drawing.Point(148, 24)
        Me.mskCNPJ_CPF.Mask = "000.000.000-00"
        Me.mskCNPJ_CPF.Name = "mskCNPJ_CPF"
        Me.mskCNPJ_CPF.Size = New System.Drawing.Size(120, 20)
        Me.mskCNPJ_CPF.TabIndex = 0
        Me.mskCNPJ_CPF.Tag = "1"
        '
        'pgeEndereco
        '
        Me.pgeEndereco.Controls.Add(Me.cboEstado)
        Me.pgeEndereco.Controls.Add(Me.cboCidade)
        Me.pgeEndereco.Controls.Add(Me.txtNumero)
        Me.pgeEndereco.Controls.Add(Me.mskCEP)
        Me.pgeEndereco.Controls.Add(Me.Label5)
        Me.pgeEndereco.Controls.Add(Me.Label4)
        Me.pgeEndereco.Controls.Add(Me.Label3)
        Me.pgeEndereco.Controls.Add(Me.Label2)
        Me.pgeEndereco.Controls.Add(Me.txtBairro)
        Me.pgeEndereco.Controls.Add(Me.txtComplemento)
        Me.pgeEndereco.Controls.Add(Me.txtEndereco)
        Me.pgeEndereco.Controls.Add(Me.lblDescricao)
        Me.pgeEndereco.Location = New System.Drawing.Point(4, 22)
        Me.pgeEndereco.Name = "pgeEndereco"
        Me.pgeEndereco.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeEndereco.Size = New System.Drawing.Size(640, 168)
        Me.pgeEndereco.TabIndex = 1
        Me.pgeEndereco.Text = "ENDEREÇO"
        Me.pgeEndereco.UseVisualStyleBackColor = True
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(497, 105)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(123, 21)
        Me.cboEstado.TabIndex = 6
        Me.cboEstado.Tag = "0"
        '
        'cboCidade
        '
        Me.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCidade.FormattingEnabled = True
        Me.cboCidade.Location = New System.Drawing.Point(148, 105)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Size = New System.Drawing.Size(224, 21)
        Me.cboCidade.TabIndex = 5
        Me.cboCidade.Tag = "0"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Location = New System.Drawing.Point(231, 24)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(141, 20)
        Me.txtNumero.TabIndex = 1
        '
        'mskCEP
        '
        Me.mskCEP.Location = New System.Drawing.Point(148, 24)
        Me.mskCEP.Mask = "00000-000"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.Size = New System.Drawing.Size(77, 20)
        Me.mskCEP.TabIndex = 0
        Me.mskCEP.Tag = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "ESTADO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "CIDADE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "BAIRRO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ENDERECO:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(148, 79)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(472, 20)
        Me.txtBairro.TabIndex = 4
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(378, 24)
        Me.txtComplemento.MaxLength = 50
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(242, 20)
        Me.txtComplemento.TabIndex = 2
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(148, 50)
        Me.txtEndereco.MaxLength = 200
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(472, 20)
        Me.txtEndereco.TabIndex = 3
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(19, 27)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(31, 13)
        Me.lblDescricao.TabIndex = 14
        Me.lblDescricao.Text = "CEP:"
        '
        'pesquisarFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 588)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.cmdFiltrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.txtID)
        Me.KeyPreview = True
        Me.Name = "pesquisarFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO / PESQUISA"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.pgeDados.ResumeLayout(False)
        Me.pgeDados.PerformLayout()
        Me.pgeEndereco.ResumeLayout(False)
        Me.pgeEndereco.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
    Friend WithEvents cmdFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtProcurar As System.Windows.Forms.TextBox
    Friend WithEvents cboCampos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsDescricao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents pgeDados As System.Windows.Forms.TabPage
    Friend WithEvents pgeEndereco As System.Windows.Forms.TabPage
    Friend WithEvents mskIE_RG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCNPJ_CPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtContato As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents cboCargos As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cboCidade As System.Windows.Forms.ComboBox
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
End Class

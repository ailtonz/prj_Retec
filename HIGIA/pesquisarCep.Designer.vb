<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisarCep
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
        Me.mskPRINCIPAL_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContratoValor = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskPRINCIPAL_CEP)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtContratoValor)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.txtComplemento)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.lblDescricao)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DADOS"
        '
        'mskPRINCIPAL_CEP
        '
        Me.mskPRINCIPAL_CEP.Location = New System.Drawing.Point(69, 24)
        Me.mskPRINCIPAL_CEP.Mask = "00000-000"
        Me.mskPRINCIPAL_CEP.Name = "mskPRINCIPAL_CEP"
        Me.mskPRINCIPAL_CEP.Size = New System.Drawing.Size(77, 20)
        Me.mskPRINCIPAL_CEP.TabIndex = 0
        Me.mskPRINCIPAL_CEP.Tag = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CONTRATO VALOR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ESTADO:"
        '
        'txtContratoValor
        '
        Me.txtContratoValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContratoValor.Location = New System.Drawing.Point(152, 154)
        Me.txtContratoValor.MaxLength = 50
        Me.txtContratoValor.Name = "txtContratoValor"
        Me.txtContratoValor.Size = New System.Drawing.Size(496, 20)
        Me.txtContratoValor.TabIndex = 6
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Location = New System.Drawing.Point(152, 128)
        Me.txtEstado.MaxLength = 2
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(496, 20)
        Me.txtEstado.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CIDADE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "BAIRRO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "COMPLEMENTO:"
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(152, 102)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(496, 20)
        Me.txtCidade.TabIndex = 4
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(152, 76)
        Me.txtBairro.MaxLength = 50
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(496, 20)
        Me.txtBairro.TabIndex = 3
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(152, 50)
        Me.txtComplemento.MaxLength = 50
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(496, 20)
        Me.txtComplemento.TabIndex = 2
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(152, 24)
        Me.txtEndereco.MaxLength = 50
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(496, 20)
        Me.txtEndereco.TabIndex = 1
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(10, 24)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(31, 13)
        Me.lblDescricao.TabIndex = 1
        Me.lblDescricao.Text = "CEP:"
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
        Me.txtUser.Location = New System.Drawing.Point(583, 1)
        Me.txtUser.MaxLength = 10
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(77, 20)
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
        Me.StatusStrip1.Size = New System.Drawing.Size(786, 22)
        Me.StatusStrip1.TabIndex = 111
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsDescricao
        '
        Me.stsDescricao.Name = "stsDescricao"
        Me.stsDescricao.Size = New System.Drawing.Size(0, 17)
        '
        'pesquisarCep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 588)
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
        Me.Name = "pesquisarCep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO / PESQUISA"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtContratoValor As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsDescricao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mskPRINCIPAL_CEP As System.Windows.Forms.MaskedTextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_SRV_ROTEIROS
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgwSOLICITACOES = New System.Windows.Forms.DataGridView()
        Me.SOLICITACAO_BAIRRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOLICITACAO_ENDERECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOLICITACAO_QUANTIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOLICITACAO_PRIORIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwVIAGENS = New System.Windows.Forms.DataGridView()
        Me.ORDEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAIRRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENDERECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLOCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TROCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETIRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpbVIAGEM = New System.Windows.Forms.GroupBox()
        Me.cboVIAGEM = New System.Windows.Forms.ComboBox()
        Me.cboSOLICITACOES = New System.Windows.Forms.ComboBox()
        Me.gpbFUNCOES = New System.Windows.Forms.GroupBox()
        Me.btnFECHAR = New System.Windows.Forms.Button()
        Me.btnSALVAR = New System.Windows.Forms.Button()
        Me.gpbIMPRESSAO = New System.Windows.Forms.GroupBox()
        Me.btnCTR = New System.Windows.Forms.Button()
        Me.btnORDEM_SERVICO = New System.Windows.Forms.Button()
        Me.btnROTEIRO = New System.Windows.Forms.Button()
        Me.gpbROTEIRO = New System.Windows.Forms.GroupBox()
        Me.cboMOTORISTA = New System.Windows.Forms.ComboBox()
        Me.cboPLACA = New System.Windows.Forms.ComboBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.dtpTERMINIO = New System.Windows.Forms.DateTimePicker()
        Me.dtpINICIO = New System.Windows.Forms.DateTimePicker()
        Me.cboSTATUS = New System.Windows.Forms.ComboBox()
        Me.dtpROTEIRO = New System.Windows.Forms.DateTimePicker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgwSOLICITACOES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwVIAGENS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpbVIAGEM.SuspendLayout()
        Me.gpbFUNCOES.SuspendLayout()
        Me.gpbIMPRESSAO.SuspendLayout()
        Me.gpbROTEIRO.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 73)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgwSOLICITACOES)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgwVIAGENS)
        Me.SplitContainer1.Size = New System.Drawing.Size(1154, 508)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.TabIndex = 9
        '
        'dgwSOLICITACOES
        '
        Me.dgwSOLICITACOES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSOLICITACOES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SOLICITACAO_BAIRRO, Me.SOLICITACAO_ENDERECO, Me.SOLICITACAO_QUANTIDADE, Me.SOLICITACAO_PRIORIDADE})
        Me.dgwSOLICITACOES.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwSOLICITACOES.Location = New System.Drawing.Point(0, 0)
        Me.dgwSOLICITACOES.Name = "dgwSOLICITACOES"
        Me.dgwSOLICITACOES.Size = New System.Drawing.Size(1154, 247)
        Me.dgwSOLICITACOES.TabIndex = 9
        '
        'SOLICITACAO_BAIRRO
        '
        Me.SOLICITACAO_BAIRRO.HeaderText = "BAIRRO_SOLICITACAO"
        Me.SOLICITACAO_BAIRRO.Name = "SOLICITACAO_BAIRRO"
        '
        'SOLICITACAO_ENDERECO
        '
        Me.SOLICITACAO_ENDERECO.HeaderText = "SOLICITACAO_ENDERECO"
        Me.SOLICITACAO_ENDERECO.Name = "SOLICITACAO_ENDERECO"
        '
        'SOLICITACAO_QUANTIDADE
        '
        Me.SOLICITACAO_QUANTIDADE.HeaderText = "SOLICITACAO_QUANTIDADE"
        Me.SOLICITACAO_QUANTIDADE.Name = "SOLICITACAO_QUANTIDADE"
        '
        'SOLICITACAO_PRIORIDADE
        '
        Me.SOLICITACAO_PRIORIDADE.HeaderText = "SOLICITACAO_PRIORIDADE"
        Me.SOLICITACAO_PRIORIDADE.Name = "SOLICITACAO_PRIORIDADE"
        '
        'dgwVIAGENS
        '
        Me.dgwVIAGENS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwVIAGENS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDEM, Me.BAIRRO, Me.ENDERECO, Me.COLOCA, Me.TROCA, Me.RETIRA, Me.OBSERVACAO})
        Me.dgwVIAGENS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwVIAGENS.Location = New System.Drawing.Point(0, 0)
        Me.dgwVIAGENS.Name = "dgwVIAGENS"
        Me.dgwVIAGENS.Size = New System.Drawing.Size(1154, 257)
        Me.dgwVIAGENS.TabIndex = 9
        '
        'ORDEM
        '
        Me.ORDEM.HeaderText = "ORDEM"
        Me.ORDEM.Name = "ORDEM"
        '
        'BAIRRO
        '
        Me.BAIRRO.HeaderText = "BAIRRO"
        Me.BAIRRO.Name = "BAIRRO"
        '
        'ENDERECO
        '
        Me.ENDERECO.HeaderText = "ENDERECO"
        Me.ENDERECO.Name = "ENDERECO"
        '
        'COLOCA
        '
        Me.COLOCA.HeaderText = "COLOCA"
        Me.COLOCA.Name = "COLOCA"
        '
        'TROCA
        '
        Me.TROCA.HeaderText = "TROCA"
        Me.TROCA.Name = "TROCA"
        '
        'RETIRA
        '
        Me.RETIRA.HeaderText = "RETIRA"
        Me.RETIRA.Name = "RETIRA"
        '
        'OBSERVACAO
        '
        Me.OBSERVACAO.HeaderText = "OBSERVACAO"
        Me.OBSERVACAO.Name = "OBSERVACAO"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gpbVIAGEM)
        Me.Panel1.Controls.Add(Me.gpbFUNCOES)
        Me.Panel1.Controls.Add(Me.gpbIMPRESSAO)
        Me.Panel1.Controls.Add(Me.gpbROTEIRO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 73)
        Me.Panel1.TabIndex = 10
        '
        'gpbVIAGEM
        '
        Me.gpbVIAGEM.Controls.Add(Me.cboVIAGEM)
        Me.gpbVIAGEM.Controls.Add(Me.cboSOLICITACOES)
        Me.gpbVIAGEM.Location = New System.Drawing.Point(518, 3)
        Me.gpbVIAGEM.Name = "gpbVIAGEM"
        Me.gpbVIAGEM.Size = New System.Drawing.Size(162, 64)
        Me.gpbVIAGEM.TabIndex = 6
        Me.gpbVIAGEM.TabStop = False
        Me.gpbVIAGEM.Text = "SOLICITAÇÕES X VIAGENS"
        '
        'cboVIAGEM
        '
        Me.cboVIAGEM.FormattingEnabled = True
        Me.cboVIAGEM.Location = New System.Drawing.Point(13, 36)
        Me.cboVIAGEM.Name = "cboVIAGEM"
        Me.cboVIAGEM.Size = New System.Drawing.Size(138, 21)
        Me.cboVIAGEM.TabIndex = 1
        Me.cboVIAGEM.Text = "VIAGEM 01"
        '
        'cboSOLICITACOES
        '
        Me.cboSOLICITACOES.FormattingEnabled = True
        Me.cboSOLICITACOES.Location = New System.Drawing.Point(13, 14)
        Me.cboSOLICITACOES.Name = "cboSOLICITACOES"
        Me.cboSOLICITACOES.Size = New System.Drawing.Size(138, 21)
        Me.cboSOLICITACOES.TabIndex = 0
        Me.cboSOLICITACOES.Text = "COLOCA"
        '
        'gpbFUNCOES
        '
        Me.gpbFUNCOES.Controls.Add(Me.btnFECHAR)
        Me.gpbFUNCOES.Controls.Add(Me.btnSALVAR)
        Me.gpbFUNCOES.Location = New System.Drawing.Point(922, 3)
        Me.gpbFUNCOES.Name = "gpbFUNCOES"
        Me.gpbFUNCOES.Size = New System.Drawing.Size(220, 64)
        Me.gpbFUNCOES.TabIndex = 5
        Me.gpbFUNCOES.TabStop = False
        Me.gpbFUNCOES.Text = "FUNÇÕES"
        '
        'btnFECHAR
        '
        Me.btnFECHAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFECHAR.Location = New System.Drawing.Point(41, 37)
        Me.btnFECHAR.Name = "btnFECHAR"
        Me.btnFECHAR.Size = New System.Drawing.Size(137, 23)
        Me.btnFECHAR.TabIndex = 14
        Me.btnFECHAR.Text = "FECHAR"
        Me.btnFECHAR.UseVisualStyleBackColor = True
        '
        'btnSALVAR
        '
        Me.btnSALVAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSALVAR.Location = New System.Drawing.Point(41, 14)
        Me.btnSALVAR.Name = "btnSALVAR"
        Me.btnSALVAR.Size = New System.Drawing.Size(137, 22)
        Me.btnSALVAR.TabIndex = 13
        Me.btnSALVAR.Text = "SALVAR"
        Me.btnSALVAR.UseVisualStyleBackColor = True
        '
        'gpbIMPRESSAO
        '
        Me.gpbIMPRESSAO.Controls.Add(Me.btnCTR)
        Me.gpbIMPRESSAO.Controls.Add(Me.btnORDEM_SERVICO)
        Me.gpbIMPRESSAO.Controls.Add(Me.btnROTEIRO)
        Me.gpbIMPRESSAO.Location = New System.Drawing.Point(686, 3)
        Me.gpbIMPRESSAO.Name = "gpbIMPRESSAO"
        Me.gpbIMPRESSAO.Size = New System.Drawing.Size(230, 64)
        Me.gpbIMPRESSAO.TabIndex = 2
        Me.gpbIMPRESSAO.TabStop = False
        Me.gpbIMPRESSAO.Text = "IMPRESSÃO"
        '
        'btnCTR
        '
        Me.btnCTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCTR.Location = New System.Drawing.Point(6, 37)
        Me.btnCTR.Name = "btnCTR"
        Me.btnCTR.Size = New System.Drawing.Size(218, 23)
        Me.btnCTR.TabIndex = 13
        Me.btnCTR.Text = "TRANSPORTE DE RESIDUOS"
        Me.btnCTR.UseVisualStyleBackColor = True
        '
        'btnORDEM_SERVICO
        '
        Me.btnORDEM_SERVICO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnORDEM_SERVICO.Location = New System.Drawing.Point(87, 13)
        Me.btnORDEM_SERVICO.Name = "btnORDEM_SERVICO"
        Me.btnORDEM_SERVICO.Size = New System.Drawing.Size(137, 23)
        Me.btnORDEM_SERVICO.TabIndex = 12
        Me.btnORDEM_SERVICO.Text = "ORDEM DE SERVIÇO"
        Me.btnORDEM_SERVICO.UseVisualStyleBackColor = True
        '
        'btnROTEIRO
        '
        Me.btnROTEIRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnROTEIRO.Location = New System.Drawing.Point(6, 13)
        Me.btnROTEIRO.Name = "btnROTEIRO"
        Me.btnROTEIRO.Size = New System.Drawing.Size(75, 23)
        Me.btnROTEIRO.TabIndex = 11
        Me.btnROTEIRO.Text = "ROTEIRO"
        Me.btnROTEIRO.UseVisualStyleBackColor = True
        '
        'gpbROTEIRO
        '
        Me.gpbROTEIRO.Controls.Add(Me.cboMOTORISTA)
        Me.gpbROTEIRO.Controls.Add(Me.cboPLACA)
        Me.gpbROTEIRO.Controls.Add(Me.HScrollBar1)
        Me.gpbROTEIRO.Controls.Add(Me.dtpTERMINIO)
        Me.gpbROTEIRO.Controls.Add(Me.dtpINICIO)
        Me.gpbROTEIRO.Controls.Add(Me.cboSTATUS)
        Me.gpbROTEIRO.Controls.Add(Me.dtpROTEIRO)
        Me.gpbROTEIRO.Location = New System.Drawing.Point(3, 3)
        Me.gpbROTEIRO.Name = "gpbROTEIRO"
        Me.gpbROTEIRO.Size = New System.Drawing.Size(509, 64)
        Me.gpbROTEIRO.TabIndex = 0
        Me.gpbROTEIRO.TabStop = False
        Me.gpbROTEIRO.Text = "ROTEIRO"
        '
        'cboMOTORISTA
        '
        Me.cboMOTORISTA.FormattingEnabled = True
        Me.cboMOTORISTA.Location = New System.Drawing.Point(9, 36)
        Me.cboMOTORISTA.Name = "cboMOTORISTA"
        Me.cboMOTORISTA.Size = New System.Drawing.Size(364, 21)
        Me.cboMOTORISTA.TabIndex = 15
        Me.cboMOTORISTA.Text = "MOTORISTA"
        '
        'cboPLACA
        '
        Me.cboPLACA.FormattingEnabled = True
        Me.cboPLACA.Location = New System.Drawing.Point(379, 36)
        Me.cboPLACA.Name = "cboPLACA"
        Me.cboPLACA.Size = New System.Drawing.Size(79, 21)
        Me.cboPLACA.TabIndex = 14
        Me.cboPLACA.Text = "000-ABCD"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(466, 13)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(33, 44)
        Me.HScrollBar1.TabIndex = 13
        '
        'dtpTERMINIO
        '
        Me.dtpTERMINIO.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTERMINIO.Location = New System.Drawing.Point(305, 14)
        Me.dtpTERMINIO.Name = "dtpTERMINIO"
        Me.dtpTERMINIO.ShowUpDown = True
        Me.dtpTERMINIO.Size = New System.Drawing.Size(68, 20)
        Me.dtpTERMINIO.TabIndex = 12
        '
        'dtpINICIO
        '
        Me.dtpINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpINICIO.Location = New System.Drawing.Point(231, 14)
        Me.dtpINICIO.Name = "dtpINICIO"
        Me.dtpINICIO.ShowUpDown = True
        Me.dtpINICIO.Size = New System.Drawing.Size(68, 20)
        Me.dtpINICIO.TabIndex = 10
        '
        'cboSTATUS
        '
        Me.cboSTATUS.FormattingEnabled = True
        Me.cboSTATUS.Location = New System.Drawing.Point(379, 13)
        Me.cboSTATUS.Name = "cboSTATUS"
        Me.cboSTATUS.Size = New System.Drawing.Size(79, 21)
        Me.cboSTATUS.TabIndex = 11
        Me.cboSTATUS.Text = "STATUS"
        '
        'dtpROTEIRO
        '
        Me.dtpROTEIRO.Location = New System.Drawing.Point(9, 14)
        Me.dtpROTEIRO.Name = "dtpROTEIRO"
        Me.dtpROTEIRO.Size = New System.Drawing.Size(216, 20)
        Me.dtpROTEIRO.TabIndex = 1
        '
        'F_CAD_ROTEIROS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 581)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "F_CAD_ROTEIROS"
        Me.Text = "CADASTRO DE ROTEIROS"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgwSOLICITACOES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwVIAGENS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpbVIAGEM.ResumeLayout(False)
        Me.gpbFUNCOES.ResumeLayout(False)
        Me.gpbIMPRESSAO.ResumeLayout(False)
        Me.gpbROTEIRO.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgwSOLICITACOES As System.Windows.Forms.DataGridView
    Friend WithEvents dgwVIAGENS As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gpbVIAGEM As System.Windows.Forms.GroupBox
    Friend WithEvents cboVIAGEM As System.Windows.Forms.ComboBox
    Friend WithEvents cboSOLICITACOES As System.Windows.Forms.ComboBox
    Friend WithEvents gpbFUNCOES As System.Windows.Forms.GroupBox
    Friend WithEvents gpbIMPRESSAO As System.Windows.Forms.GroupBox
    Friend WithEvents gpbROTEIRO As System.Windows.Forms.GroupBox
    Friend WithEvents dtpROTEIRO As System.Windows.Forms.DateTimePicker
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents dtpTERMINIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents cboMOTORISTA As System.Windows.Forms.ComboBox
    Friend WithEvents cboPLACA As System.Windows.Forms.ComboBox
    Friend WithEvents btnFECHAR As System.Windows.Forms.Button
    Friend WithEvents btnSALVAR As System.Windows.Forms.Button
    Friend WithEvents btnCTR As System.Windows.Forms.Button
    Friend WithEvents btnORDEM_SERVICO As System.Windows.Forms.Button
    Friend WithEvents btnROTEIRO As System.Windows.Forms.Button
    Friend WithEvents SOLICITACAO_BAIRRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLICITACAO_ENDERECO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLICITACAO_QUANTIDADE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOLICITACAO_PRIORIDADE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORDEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BAIRRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENDERECO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLOCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TROCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RETIRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACAO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

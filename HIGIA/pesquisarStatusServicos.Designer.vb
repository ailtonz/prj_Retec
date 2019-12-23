<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisarStatusServicos
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.dgvDados.Location = New System.Drawing.Point(0, 147)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(786, 416)
        Me.dgvDados.TabIndex = 2
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltrar.Location = New System.Drawing.Point(699, 101)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdFiltrar.TabIndex = 4
        Me.cmdFiltrar.Text = "FILTRAR"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'txtProcurar
        '
        Me.txtProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcurar.Location = New System.Drawing.Point(152, 22)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(496, 20)
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
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblDescricao)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DADOS"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(88, 28)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(59, 20)
        Me.txtID.TabIndex = 2
        Me.txtID.TabStop = False
        Me.txtID.Visible = False
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(10, 31)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(72, 13)
        Me.lblDescricao.TabIndex = 1
        Me.lblDescricao.Text = "DESCRIÇÃO:"
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(152, 28)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(496, 20)
        Me.txtDescricao.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCampos)
        Me.GroupBox2.Controls.Add(Me.txtProcurar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 59)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTRO"
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
        Me.StatusStrip1.TabIndex = 106
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsDescricao
        '
        Me.stsDescricao.Name = "stsDescricao"
        Me.stsDescricao.Size = New System.Drawing.Size(0, 17)
        '
        'pesquisarStatusServicos
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
        Me.KeyPreview = True
        Me.Name = "pesquisarStatusServicos"
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
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsDescricao As System.Windows.Forms.ToolStripStatusLabel
End Class

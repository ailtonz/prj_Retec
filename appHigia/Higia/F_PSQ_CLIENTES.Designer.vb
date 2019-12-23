<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PSQ_CLIENTES
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
        Me.tsControle = New System.Windows.Forms.ToolStrip()
        Me.txtProcurar = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdProcurar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdNovo = New System.Windows.Forms.ToolStripButton()
        Me.cmdAlterar = New System.Windows.Forms.ToolStripButton()
        Me.Separador = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdExcluir = New System.Windows.Forms.ToolStripButton()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.tsControle.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsControle
        '
        Me.tsControle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtProcurar, Me.cmdProcurar, Me.ToolStripSeparator1, Me.cmdNovo, Me.cmdAlterar, Me.Separador, Me.cmdExcluir})
        Me.tsControle.Location = New System.Drawing.Point(0, 0)
        Me.tsControle.Name = "tsControle"
        Me.tsControle.Size = New System.Drawing.Size(926, 25)
        Me.tsControle.TabIndex = 0
        Me.tsControle.Text = "ToolStrip1"
        '
        'txtProcurar
        '
        Me.txtProcurar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProcurar.MaxLength = 200
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(800, 25)
        '
        'cmdProcurar
        '
        Me.cmdProcurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdProcurar.Image = Global.HIGIA.My.Resources.Resources.search
        Me.cmdProcurar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcurar.Name = "cmdProcurar"
        Me.cmdProcurar.Size = New System.Drawing.Size(23, 22)
        Me.cmdProcurar.Text = "ToolStripButton1"
        Me.cmdProcurar.ToolTipText = "Procurar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdNovo
        '
        Me.cmdNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNovo.Image = Global.HIGIA.My.Resources.Resources.add_file
        Me.cmdNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(23, 22)
        Me.cmdNovo.Text = "ToolStripButton2"
        Me.cmdNovo.ToolTipText = "Novo"
        '
        'cmdAlterar
        '
        Me.cmdAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAlterar.Image = Global.HIGIA.My.Resources.Resources.available_updates
        Me.cmdAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(23, 22)
        Me.cmdAlterar.Text = "ToolStripButton3"
        Me.cmdAlterar.ToolTipText = "Alterar"
        '
        'Separador
        '
        Me.Separador.Name = "Separador"
        Me.Separador.Size = New System.Drawing.Size(6, 25)
        '
        'cmdExcluir
        '
        Me.cmdExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdExcluir.Image = Global.HIGIA.My.Resources.Resources.delete
        Me.cmdExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(23, 22)
        Me.cmdExcluir.Text = "ToolStripButton1"
        Me.cmdExcluir.ToolTipText = "Excluir"
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDados.Location = New System.Drawing.Point(0, 25)
        Me.dgvDados.MultiSelect = False
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDados.Size = New System.Drawing.Size(926, 501)
        Me.dgvDados.TabIndex = 2
        '
        'F_PSQ_CLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 526)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.tsControle)
        Me.Name = "F_PSQ_CLIENTES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PESQUISA DE CLIENTES"
        Me.tsControle.ResumeLayout(False)
        Me.tsControle.PerformLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsControle As System.Windows.Forms.ToolStrip
    Friend WithEvents txtProcurar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmdProcurar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dgvDados As System.Windows.Forms.DataGridView
End Class

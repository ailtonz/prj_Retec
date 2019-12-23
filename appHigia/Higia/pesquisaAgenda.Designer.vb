<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisaAgenda
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
        Me.mcCalendario = New System.Windows.Forms.MonthCalendar()
        Me.dgvAgenda = New System.Windows.Forms.DataGridView()
        Me.tsLigacoes = New System.Windows.Forms.ToolStrip()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtProcurar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdProcurar = New System.Windows.Forms.ToolStripButton()
        Me.cmdNovo = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsLigacoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'mcCalendario
        '
        Me.mcCalendario.Location = New System.Drawing.Point(945, 34)
        Me.mcCalendario.Name = "mcCalendario"
        Me.mcCalendario.TabIndex = 0
        '
        'dgvAgenda
        '
        Me.dgvAgenda.AllowUserToAddRows = False
        Me.dgvAgenda.AllowUserToDeleteRows = False
        Me.dgvAgenda.AllowUserToOrderColumns = True
        Me.dgvAgenda.AllowUserToResizeRows = False
        Me.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgenda.Location = New System.Drawing.Point(12, 34)
        Me.dgvAgenda.MultiSelect = False
        Me.dgvAgenda.Name = "dgvAgenda"
        Me.dgvAgenda.Size = New System.Drawing.Size(921, 531)
        Me.dgvAgenda.TabIndex = 2
        '
        'tsLigacoes
        '
        Me.tsLigacoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1, Me.ToolStripSeparator1, Me.txtProcurar, Me.ToolStripSeparator2, Me.cmdProcurar, Me.cmdNovo})
        Me.tsLigacoes.Location = New System.Drawing.Point(0, 0)
        Me.tsLigacoes.Name = "tsLigacoes"
        Me.tsLigacoes.Size = New System.Drawing.Size(1190, 25)
        Me.tsLigacoes.TabIndex = 4
        Me.tsLigacoes.Text = "ToolStrip1"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"CLIENTE", "OBRA", "CONTATO"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'txtProcurar
        '
        Me.txtProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(700, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cmdProcurar
        '
        Me.cmdProcurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdProcurar.Image = Global.RETEC.My.Resources.Resources.search
        Me.cmdProcurar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProcurar.Name = "cmdProcurar"
        Me.cmdProcurar.Size = New System.Drawing.Size(23, 22)
        Me.cmdProcurar.Text = "Procurar"
        '
        'cmdNovo
        '
        Me.cmdNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNovo.Image = Global.RETEC.My.Resources.Resources.add_file
        Me.cmdNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(23, 22)
        Me.cmdNovo.Text = "Novo"
        '
        'pesquisaAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 577)
        Me.Controls.Add(Me.tsLigacoes)
        Me.Controls.Add(Me.dgvAgenda)
        Me.Controls.Add(Me.mcCalendario)
        Me.Name = "pesquisaAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGENDA"
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsLigacoes.ResumeLayout(False)
        Me.tsLigacoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mcCalendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgvAgenda As System.Windows.Forms.DataGridView
    Friend WithEvents tsLigacoes As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtProcurar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdProcurar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdNovo As System.Windows.Forms.ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pesquisaClientes
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.cmdFiltrar = New System.Windows.Forms.Button()
        Me.txtProcurar = New System.Windows.Forms.TextBox()
        Me.cboCampos = New System.Windows.Forms.ComboBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvClientes.Location = New System.Drawing.Point(0, 39)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(1190, 538)
        Me.dgvClientes.TabIndex = 2
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltrar.Location = New System.Drawing.Point(1103, 10)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdFiltrar.TabIndex = 14
        Me.cmdFiltrar.Text = "FILTRAR"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'txtProcurar
        '
        Me.txtProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcurar.Location = New System.Drawing.Point(192, 11)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(905, 20)
        Me.txtProcurar.TabIndex = 13
        '
        'cboCampos
        '
        Me.cboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampos.FormattingEnabled = True
        Me.cboCampos.Location = New System.Drawing.Point(12, 10)
        Me.cboCampos.Name = "cboCampos"
        Me.cboCampos.Size = New System.Drawing.Size(174, 21)
        Me.cboCampos.TabIndex = 12
        '
        'pesquisaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 577)
        Me.Controls.Add(Me.cmdFiltrar)
        Me.Controls.Add(Me.txtProcurar)
        Me.Controls.Add(Me.cboCampos)
        Me.Controls.Add(Me.dgvClientes)
        Me.KeyPreview = True
        Me.Name = "pesquisaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PESQUISAR CLIENTES"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents cmdFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtProcurar As System.Windows.Forms.TextBox
    Friend WithEvents cboCampos As System.Windows.Forms.ComboBox
End Class

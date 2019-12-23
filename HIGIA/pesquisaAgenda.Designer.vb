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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCampos = New System.Windows.Forms.ComboBox()
        Me.txtProcurar = New System.Windows.Forms.TextBox()
        Me.cmdFiltrar = New System.Windows.Forms.Button()
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mcCalendario
        '
        Me.mcCalendario.Location = New System.Drawing.Point(945, 9)
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
        Me.dgvAgenda.Location = New System.Drawing.Point(12, 38)
        Me.dgvAgenda.MultiSelect = False
        Me.dgvAgenda.Name = "dgvAgenda"
        Me.dgvAgenda.Size = New System.Drawing.Size(921, 527)
        Me.dgvAgenda.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(941, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(941, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(941, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(941, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        '
        'cboCampos
        '
        Me.cboCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCampos.FormattingEnabled = True
        Me.cboCampos.Location = New System.Drawing.Point(12, 11)
        Me.cboCampos.Name = "cboCampos"
        Me.cboCampos.Size = New System.Drawing.Size(174, 21)
        Me.cboCampos.TabIndex = 9
        '
        'txtProcurar
        '
        Me.txtProcurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcurar.Location = New System.Drawing.Point(192, 12)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(660, 20)
        Me.txtProcurar.TabIndex = 10
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFiltrar.Location = New System.Drawing.Point(858, 9)
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.cmdFiltrar.TabIndex = 11
        Me.cmdFiltrar.Text = "FILTRAR"
        Me.cmdFiltrar.UseVisualStyleBackColor = True
        '
        'pesquisaAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 577)
        Me.Controls.Add(Me.cmdFiltrar)
        Me.Controls.Add(Me.txtProcurar)
        Me.Controls.Add(Me.cboCampos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAgenda)
        Me.Controls.Add(Me.mcCalendario)
        Me.Name = "pesquisaAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGENDA"
        CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mcCalendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents dgvAgenda As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCampos As System.Windows.Forms.ComboBox
    Friend WithEvents txtProcurar As System.Windows.Forms.TextBox
    Friend WithEvents cmdFiltrar As System.Windows.Forms.Button
End Class

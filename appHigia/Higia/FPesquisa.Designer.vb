<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPesquisa
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
        Me.lblInformacao = New System.Windows.Forms.Label()
        Me.txtInformacao = New System.Windows.Forms.TextBox()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInformacao
        '
        Me.lblInformacao.AutoSize = True
        Me.lblInformacao.Location = New System.Drawing.Point(7, 15)
        Me.lblInformacao.Name = "lblInformacao"
        Me.lblInformacao.Size = New System.Drawing.Size(101, 13)
        Me.lblInformacao.TabIndex = 0
        Me.lblInformacao.Text = "Digite a informação:"
        '
        'txtInformacao
        '
        Me.txtInformacao.Location = New System.Drawing.Point(114, 12)
        Me.txtInformacao.Name = "txtInformacao"
        Me.txtInformacao.Size = New System.Drawing.Size(689, 20)
        Me.txtInformacao.TabIndex = 1
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Location = New System.Drawing.Point(809, 10)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(96, 23)
        Me.btnLocalizar.TabIndex = 2
        Me.btnLocalizar.Text = "Localizar"
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(893, 412)
        Me.DataGridView1.TabIndex = 3
        '
        'FPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 462)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLocalizar)
        Me.Controls.Add(Me.txtInformacao)
        Me.Controls.Add(Me.lblInformacao)
        Me.Name = "FPesquisa"
        Me.Text = "TELA DE PESQUISA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents lblInformacao As System.Windows.Forms.Label
    Protected WithEvents txtInformacao As System.Windows.Forms.TextBox
    Protected WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class

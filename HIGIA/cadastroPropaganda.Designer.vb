<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastroPropaganda
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
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.btnCLIENTE_SALVAR = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtID_REGISTRO = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsREGISTRO_INSERT_USUARIO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_INSERT_EMISSAO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_UPDATE_USUARIO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsREGISTRO_UPDATE_EMISSAO = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(801, 265)
        '
        'btnCLIENTE_SALVAR
        '
        Me.btnCLIENTE_SALVAR.Location = New System.Drawing.Point(736, 9)
        Me.btnCLIENTE_SALVAR.Name = "btnCLIENTE_SALVAR"
        Me.btnCLIENTE_SALVAR.Size = New System.Drawing.Size(115, 23)
        Me.btnCLIENTE_SALVAR.TabIndex = 0
        Me.btnCLIENTE_SALVAR.Text = "NOVO"
        Me.btnCLIENTE_SALVAR.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Location = New System.Drawing.Point(885, 38)
        Me.txtUser.MaxLength = 10
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(77, 20)
        Me.txtUser.TabIndex = 99
        Me.txtUser.Tag = "1"
        Me.txtUser.Text = "AILTON"
        Me.txtUser.Visible = False
        '
        'txtID_REGISTRO
        '
        Me.txtID_REGISTRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID_REGISTRO.Location = New System.Drawing.Point(885, 12)
        Me.txtID_REGISTRO.MaxLength = 10
        Me.txtID_REGISTRO.Name = "txtID_REGISTRO"
        Me.txtID_REGISTRO.Size = New System.Drawing.Size(77, 20)
        Me.txtID_REGISTRO.TabIndex = 100
        Me.txtID_REGISTRO.Tag = "1"
        Me.txtID_REGISTRO.Text = "0"
        Me.txtID_REGISTRO.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsREGISTRO_INSERT_USUARIO, Me.stsREGISTRO_INSERT_EMISSAO, Me.stsREGISTRO_UPDATE_USUARIO, Me.stsREGISTRO_UPDATE_EMISSAO})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(978, 22)
        Me.StatusStrip1.TabIndex = 113
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
        'cadastroPropaganda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 532)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtID_REGISTRO)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnCLIENTE_SALVAR)
        Me.Name = "cadastroPropaganda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCLIENTE_SALVAR As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtID_REGISTRO As System.Windows.Forms.TextBox
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsREGISTRO_INSERT_USUARIO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_INSERT_EMISSAO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_UPDATE_USUARIO As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsREGISTRO_UPDATE_EMISSAO As System.Windows.Forms.ToolStripStatusLabel
End Class

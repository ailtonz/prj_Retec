<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSAIR = New System.Windows.Forms.Button()
        Me.btnIMPRIMIR = New System.Windows.Forms.Button()
        Me.btnEXCLUIR = New System.Windows.Forms.Button()
        Me.btnGRAVAR = New System.Windows.Forms.Button()
        Me.btnEDITAR = New System.Windows.Forms.Button()
        Me.btnLOCALIZAR = New System.Windows.Forms.Button()
        Me.btnADICIONAR = New System.Windows.Forms.Button()
        Me.pnlMensagens = New System.Windows.Forms.Panel()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlMensagens.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.RETEC.My.Resources.Resources.FundoBarra
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnSAIR)
        Me.Panel1.Controls.Add(Me.btnIMPRIMIR)
        Me.Panel1.Controls.Add(Me.btnEXCLUIR)
        Me.Panel1.Controls.Add(Me.btnGRAVAR)
        Me.Panel1.Controls.Add(Me.btnEDITAR)
        Me.Panel1.Controls.Add(Me.btnLOCALIZAR)
        Me.Panel1.Controls.Add(Me.btnADICIONAR)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(922, 73)
        Me.Panel1.TabIndex = 0
        '
        'btnSAIR
        '
        Me.btnSAIR.Image = Global.RETEC.My.Resources.Resources.home
        Me.btnSAIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSAIR.Location = New System.Drawing.Point(657, 4)
        Me.btnSAIR.Name = "btnSAIR"
        Me.btnSAIR.Size = New System.Drawing.Size(103, 62)
        Me.btnSAIR.TabIndex = 7
        Me.btnSAIR.Text = "SAIR"
        Me.btnSAIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSAIR.UseVisualStyleBackColor = True
        '
        'btnIMPRIMIR
        '
        Me.btnIMPRIMIR.Image = Global.RETEC.My.Resources.Resources.print
        Me.btnIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIMPRIMIR.Location = New System.Drawing.Point(548, 4)
        Me.btnIMPRIMIR.Name = "btnIMPRIMIR"
        Me.btnIMPRIMIR.Size = New System.Drawing.Size(103, 62)
        Me.btnIMPRIMIR.TabIndex = 6
        Me.btnIMPRIMIR.Text = "IMPRIMIR"
        Me.btnIMPRIMIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIMPRIMIR.UseVisualStyleBackColor = True
        '
        'btnEXCLUIR
        '
        Me.btnEXCLUIR.Image = Global.RETEC.My.Resources.Resources.delete
        Me.btnEXCLUIR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEXCLUIR.Location = New System.Drawing.Point(439, 4)
        Me.btnEXCLUIR.Name = "btnEXCLUIR"
        Me.btnEXCLUIR.Size = New System.Drawing.Size(103, 62)
        Me.btnEXCLUIR.TabIndex = 5
        Me.btnEXCLUIR.Text = "EXCLUIR"
        Me.btnEXCLUIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEXCLUIR.UseVisualStyleBackColor = True
        '
        'btnGRAVAR
        '
        Me.btnGRAVAR.Image = Global.RETEC.My.Resources.Resources.save
        Me.btnGRAVAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGRAVAR.Location = New System.Drawing.Point(330, 4)
        Me.btnGRAVAR.Name = "btnGRAVAR"
        Me.btnGRAVAR.Size = New System.Drawing.Size(103, 62)
        Me.btnGRAVAR.TabIndex = 4
        Me.btnGRAVAR.Text = "GRAVAR"
        Me.btnGRAVAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGRAVAR.UseVisualStyleBackColor = True
        '
        'btnEDITAR
        '
        Me.btnEDITAR.Image = Global.RETEC.My.Resources.Resources.edit
        Me.btnEDITAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEDITAR.Location = New System.Drawing.Point(221, 4)
        Me.btnEDITAR.Name = "btnEDITAR"
        Me.btnEDITAR.Size = New System.Drawing.Size(103, 62)
        Me.btnEDITAR.TabIndex = 3
        Me.btnEDITAR.Text = "EDITAR"
        Me.btnEDITAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEDITAR.UseVisualStyleBackColor = True
        '
        'btnLOCALIZAR
        '
        Me.btnLOCALIZAR.Image = Global.RETEC.My.Resources.Resources.search
        Me.btnLOCALIZAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLOCALIZAR.Location = New System.Drawing.Point(112, 3)
        Me.btnLOCALIZAR.Name = "btnLOCALIZAR"
        Me.btnLOCALIZAR.Size = New System.Drawing.Size(103, 62)
        Me.btnLOCALIZAR.TabIndex = 2
        Me.btnLOCALIZAR.Text = "LOCALIZAR"
        Me.btnLOCALIZAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLOCALIZAR.UseVisualStyleBackColor = True
        '
        'btnADICIONAR
        '
        Me.btnADICIONAR.Image = Global.RETEC.My.Resources.Resources.add_file
        Me.btnADICIONAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnADICIONAR.Location = New System.Drawing.Point(3, 3)
        Me.btnADICIONAR.Name = "btnADICIONAR"
        Me.btnADICIONAR.Size = New System.Drawing.Size(103, 62)
        Me.btnADICIONAR.TabIndex = 1
        Me.btnADICIONAR.Text = "ADICIONAR"
        Me.btnADICIONAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnADICIONAR.UseVisualStyleBackColor = True
        '
        'pnlMensagens
        '
        Me.pnlMensagens.BackColor = System.Drawing.SystemColors.Info
        Me.pnlMensagens.Controls.Add(Me.lblMensagem)
        Me.pnlMensagens.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlMensagens.Location = New System.Drawing.Point(0, 433)
        Me.pnlMensagens.Name = "pnlMensagens"
        Me.pnlMensagens.Size = New System.Drawing.Size(922, 29)
        Me.pnlMensagens.TabIndex = 1
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.Location = New System.Drawing.Point(12, 7)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(67, 13)
        Me.lblMensagem.TabIndex = 0
        Me.lblMensagem.Text = "Mensagem"
        '
        'FCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 462)
        Me.Controls.Add(Me.pnlMensagens)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "FCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO"
        Me.Panel1.ResumeLayout(False)
        Me.pnlMensagens.ResumeLayout(False)
        Me.pnlMensagens.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlMensagens As System.Windows.Forms.Panel
    Protected WithEvents btnSAIR As System.Windows.Forms.Button
    Protected WithEvents btnIMPRIMIR As System.Windows.Forms.Button
    Protected WithEvents btnEXCLUIR As System.Windows.Forms.Button
    Protected WithEvents btnGRAVAR As System.Windows.Forms.Button
    Protected WithEvents btnEDITAR As System.Windows.Forms.Button
    Protected WithEvents btnLOCALIZAR As System.Windows.Forms.Button
    Protected WithEvents btnADICIONAR As System.Windows.Forms.Button
    Protected WithEvents lblMensagem As System.Windows.Forms.Label
End Class

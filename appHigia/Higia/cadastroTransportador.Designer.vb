<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastroTransportador
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkRetira = New System.Windows.Forms.CheckBox()
        Me.chkTroca = New System.Windows.Forms.CheckBox()
        Me.chkColoca = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblCONTRATO_MULTA_DIA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_MULTA_DIA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_MULTA_MORA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_MULTA_MORA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_VCTO_APOS_ENTREGA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_VCTO_APOS_ENTREGA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_RETIRADA_AUTOMATICA = New System.Windows.Forms.Label()
        Me.txtCONTRATO_RETIRADA_AUTOMATICA = New System.Windows.Forms.TextBox()
        Me.lblCONTRATO_PERIDO_LOCACAO = New System.Windows.Forms.Label()
        Me.txtCONTRATO_PERIDO_LOCACAO = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIE_RG = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCNPJ_CPF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkRetira)
        Me.GroupBox5.Controls.Add(Me.chkTroca)
        Me.GroupBox5.Controls.Add(Me.chkColoca)
        Me.GroupBox5.Location = New System.Drawing.Point(287, 228)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(181, 151)
        Me.GroupBox5.TabIndex = 79
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "CÁLCULAR FATURAMENTO"
        '
        'chkRetira
        '
        Me.chkRetira.AutoSize = True
        Me.chkRetira.Location = New System.Drawing.Point(47, 116)
        Me.chkRetira.Name = "chkRetira"
        Me.chkRetira.Size = New System.Drawing.Size(66, 17)
        Me.chkRetira.TabIndex = 80
        Me.chkRetira.Text = "RETIRA"
        Me.chkRetira.UseVisualStyleBackColor = True
        '
        'chkTroca
        '
        Me.chkTroca.AutoSize = True
        Me.chkTroca.Location = New System.Drawing.Point(47, 77)
        Me.chkTroca.Name = "chkTroca"
        Me.chkTroca.Size = New System.Drawing.Size(63, 17)
        Me.chkTroca.TabIndex = 79
        Me.chkTroca.Text = "TROCA"
        Me.chkTroca.UseVisualStyleBackColor = True
        '
        'chkColoca
        '
        Me.chkColoca.AutoSize = True
        Me.chkColoca.Location = New System.Drawing.Point(47, 41)
        Me.chkColoca.Name = "chkColoca"
        Me.chkColoca.Size = New System.Drawing.Size(69, 17)
        Me.chkColoca.TabIndex = 78
        Me.chkColoca.Text = "COLOCA"
        Me.chkColoca.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_MULTA_DIA)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_MULTA_DIA)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_MULTA_MORA)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_MULTA_MORA)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_VCTO_APOS_ENTREGA)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_VCTO_APOS_ENTREGA)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_RETIRADA_AUTOMATICA)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_RETIRADA_AUTOMATICA)
        Me.GroupBox4.Controls.Add(Me.lblCONTRATO_PERIDO_LOCACAO)
        Me.GroupBox4.Controls.Add(Me.txtCONTRATO_PERIDO_LOCACAO)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(269, 151)
        Me.GroupBox4.TabIndex = 78
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CRITERIOS"
        '
        'lblCONTRATO_MULTA_DIA
        '
        Me.lblCONTRATO_MULTA_DIA.AutoSize = True
        Me.lblCONTRATO_MULTA_DIA.Location = New System.Drawing.Point(19, 120)
        Me.lblCONTRATO_MULTA_DIA.Name = "lblCONTRATO_MULTA_DIA"
        Me.lblCONTRATO_MULTA_DIA.Size = New System.Drawing.Size(68, 13)
        Me.lblCONTRATO_MULTA_DIA.TabIndex = 72
        Me.lblCONTRATO_MULTA_DIA.Text = "MULTA DIA:"
        '
        'txtCONTRATO_MULTA_DIA
        '
        Me.txtCONTRATO_MULTA_DIA.Location = New System.Drawing.Point(177, 117)
        Me.txtCONTRATO_MULTA_DIA.Name = "txtCONTRATO_MULTA_DIA"
        Me.txtCONTRATO_MULTA_DIA.Size = New System.Drawing.Size(77, 20)
        Me.txtCONTRATO_MULTA_DIA.TabIndex = 67
        Me.txtCONTRATO_MULTA_DIA.Tag = "1"
        Me.txtCONTRATO_MULTA_DIA.Text = "1,00"
        Me.txtCONTRATO_MULTA_DIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCONTRATO_MULTA_MORA
        '
        Me.lblCONTRATO_MULTA_MORA.AutoSize = True
        Me.lblCONTRATO_MULTA_MORA.Location = New System.Drawing.Point(19, 94)
        Me.lblCONTRATO_MULTA_MORA.Name = "lblCONTRATO_MULTA_MORA"
        Me.lblCONTRATO_MULTA_MORA.Size = New System.Drawing.Size(82, 13)
        Me.lblCONTRATO_MULTA_MORA.TabIndex = 71
        Me.lblCONTRATO_MULTA_MORA.Text = "MULTA MORA:"
        '
        'txtCONTRATO_MULTA_MORA
        '
        Me.txtCONTRATO_MULTA_MORA.Location = New System.Drawing.Point(177, 91)
        Me.txtCONTRATO_MULTA_MORA.Name = "txtCONTRATO_MULTA_MORA"
        Me.txtCONTRATO_MULTA_MORA.Size = New System.Drawing.Size(77, 20)
        Me.txtCONTRATO_MULTA_MORA.TabIndex = 66
        Me.txtCONTRATO_MULTA_MORA.Tag = "1"
        Me.txtCONTRATO_MULTA_MORA.Text = "15,00"
        Me.txtCONTRATO_MULTA_MORA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCONTRATO_VCTO_APOS_ENTREGA
        '
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.AutoSize = True
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Location = New System.Drawing.Point(19, 68)
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Name = "lblCONTRATO_VCTO_APOS_ENTREGA"
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Size = New System.Drawing.Size(142, 13)
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.TabIndex = 70
        Me.lblCONTRATO_VCTO_APOS_ENTREGA.Text = "VENCIMENTO - ENTREGA:"
        '
        'txtCONTRATO_VCTO_APOS_ENTREGA
        '
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Location = New System.Drawing.Point(177, 65)
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Name = "txtCONTRATO_VCTO_APOS_ENTREGA"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Size = New System.Drawing.Size(77, 20)
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.TabIndex = 65
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Tag = "1"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.Text = "10"
        Me.txtCONTRATO_VCTO_APOS_ENTREGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCONTRATO_RETIRADA_AUTOMATICA
        '
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.AutoSize = True
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Location = New System.Drawing.Point(19, 45)
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Name = "lblCONTRATO_RETIRADA_AUTOMATICA"
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Size = New System.Drawing.Size(138, 13)
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.TabIndex = 69
        Me.lblCONTRATO_RETIRADA_AUTOMATICA.Text = "RETIRADA AUTOMATICA:"
        '
        'txtCONTRATO_RETIRADA_AUTOMATICA
        '
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Location = New System.Drawing.Point(177, 42)
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Name = "txtCONTRATO_RETIRADA_AUTOMATICA"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Size = New System.Drawing.Size(77, 20)
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.TabIndex = 64
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Tag = "1"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.Text = "6"
        Me.txtCONTRATO_RETIRADA_AUTOMATICA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCONTRATO_PERIDO_LOCACAO
        '
        Me.lblCONTRATO_PERIDO_LOCACAO.AutoSize = True
        Me.lblCONTRATO_PERIDO_LOCACAO.Location = New System.Drawing.Point(19, 22)
        Me.lblCONTRATO_PERIDO_LOCACAO.Name = "lblCONTRATO_PERIDO_LOCACAO"
        Me.lblCONTRATO_PERIDO_LOCACAO.Size = New System.Drawing.Size(130, 13)
        Me.lblCONTRATO_PERIDO_LOCACAO.TabIndex = 68
        Me.lblCONTRATO_PERIDO_LOCACAO.Text = "PERIODO DE LOCAÇÃO:"
        '
        'txtCONTRATO_PERIDO_LOCACAO
        '
        Me.txtCONTRATO_PERIDO_LOCACAO.Location = New System.Drawing.Point(177, 19)
        Me.txtCONTRATO_PERIDO_LOCACAO.Name = "txtCONTRATO_PERIDO_LOCACAO"
        Me.txtCONTRATO_PERIDO_LOCACAO.Size = New System.Drawing.Size(77, 20)
        Me.txtCONTRATO_PERIDO_LOCACAO.TabIndex = 63
        Me.txtCONTRATO_PERIDO_LOCACAO.Tag = "1"
        Me.txtCONTRATO_PERIDO_LOCACAO.Text = "5"
        Me.txtCONTRATO_PERIDO_LOCACAO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtIE_RG)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTelefone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCNPJ_CPF)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 210)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSPORTADOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Nº LIMPURB:"
        '
        'txtIE_RG
        '
        Me.txtIE_RG.Location = New System.Drawing.Point(127, 175)
        Me.txtIE_RG.Name = "txtIE_RG"
        Me.txtIE_RG.Size = New System.Drawing.Size(306, 20)
        Me.txtIE_RG.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "TELEFONE:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(127, 149)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(306, 20)
        Me.txtTelefone.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "CPF/CCM:"
        '
        'txtCNPJ_CPF
        '
        Me.txtCNPJ_CPF.Location = New System.Drawing.Point(127, 123)
        Me.txtCNPJ_CPF.Name = "txtCNPJ_CPF"
        Me.txtCNPJ_CPF.Size = New System.Drawing.Size(306, 20)
        Me.txtCNPJ_CPF.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "MUNICIPIO:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(127, 97)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(306, 20)
        Me.txtCidade.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "BAIRRO:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(127, 71)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(306, 20)
        Me.txtBairro.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ENDERECO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "NOME:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(127, 45)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(306, 20)
        Me.txtEndereco.TabIndex = 15
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(127, 19)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(306, 20)
        Me.txtNome.TabIndex = 14
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(471, 12)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(115, 23)
        Me.btnSalvar.TabIndex = 97
        Me.btnSalvar.Text = "SALVAR"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(471, 41)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 23)
        Me.btnCancelar.TabIndex = 98
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cadastroTransportador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 390)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "cadastroTransportador"
        Me.Text = "DADOS DO TRANSPORTADOR"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRetira As System.Windows.Forms.CheckBox
    Friend WithEvents chkTroca As System.Windows.Forms.CheckBox
    Friend WithEvents chkColoca As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCONTRATO_MULTA_DIA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_MULTA_DIA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_MULTA_MORA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_MULTA_MORA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_VCTO_APOS_ENTREGA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_VCTO_APOS_ENTREGA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_RETIRADA_AUTOMATICA As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_RETIRADA_AUTOMATICA As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTRATO_PERIDO_LOCACAO As System.Windows.Forms.Label
    Friend WithEvents txtCONTRATO_PERIDO_LOCACAO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIE_RG As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCNPJ_CPF As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class

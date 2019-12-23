<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPrincipal
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
        Me.TabMenu = New System.Windows.Forms.TabControl()
        Me.pgATENDIMENTO = New System.Windows.Forms.TabPage()
        Me.btnNovosClientes = New System.Windows.Forms.Button()
        Me.btnLINKs = New System.Windows.Forms.Button()
        Me.btnCEPs = New System.Windows.Forms.Button()
        Me.btnTELEFONES = New System.Windows.Forms.Button()
        Me.btnPesquisarClientes = New System.Windows.Forms.Button()
        Me.btnSOLICITACAO = New System.Windows.Forms.Button()
        Me.btnAGENDA = New System.Windows.Forms.Button()
        Me.pgLOGISTICA = New System.Windows.Forms.TabPage()
        Me.btnCACAMBAS = New System.Windows.Forms.Button()
        Me.btnVIAGENS = New System.Windows.Forms.Button()
        Me.btnROTEIROS = New System.Windows.Forms.Button()
        Me.pgFATURAMENTO = New System.Windows.Forms.TabPage()
        Me.btnRECIBOS = New System.Windows.Forms.Button()
        Me.btnREMESSA = New System.Windows.Forms.Button()
        Me.btnBOLETOS = New System.Windows.Forms.Button()
        Me.btnFATURAMENTO = New System.Windows.Forms.Button()
        Me.pgFINANCEIRO = New System.Windows.Forms.TabPage()
        Me.btnIMPRESSOS_FINANCEIRO = New System.Windows.Forms.Button()
        Me.btnMOVIMENTO = New System.Windows.Forms.Button()
        Me.pgGERENCIA = New System.Windows.Forms.TabPage()
        Me.btnADM_TELEFONES_UTEIS = New System.Windows.Forms.Button()
        Me.btnADM_FUNCIONARIOS = New System.Windows.Forms.Button()
        Me.btnADM_GERENCIAL = New System.Windows.Forms.Button()
        Me.btnADM_CLIENTES = New System.Windows.Forms.Button()
        Me.btnADM_USUARIOS = New System.Windows.Forms.Button()
        Me.pgSISTEMA = New System.Windows.Forms.TabPage()
        Me.btnCONTROLE_OPERACIONAL = New System.Windows.Forms.Button()
        Me.btnUSUARIOS = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabMenu.SuspendLayout()
        Me.pgATENDIMENTO.SuspendLayout()
        Me.pgLOGISTICA.SuspendLayout()
        Me.pgFATURAMENTO.SuspendLayout()
        Me.pgFINANCEIRO.SuspendLayout()
        Me.pgGERENCIA.SuspendLayout()
        Me.pgSISTEMA.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.TabMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1220, 100)
        Me.Panel1.TabIndex = 0
        '
        'TabMenu
        '
        Me.TabMenu.Controls.Add(Me.pgATENDIMENTO)
        Me.TabMenu.Controls.Add(Me.pgLOGISTICA)
        Me.TabMenu.Controls.Add(Me.pgFATURAMENTO)
        Me.TabMenu.Controls.Add(Me.pgFINANCEIRO)
        Me.TabMenu.Controls.Add(Me.pgGERENCIA)
        Me.TabMenu.Controls.Add(Me.pgSISTEMA)
        Me.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMenu.Location = New System.Drawing.Point(0, 0)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.SelectedIndex = 0
        Me.TabMenu.Size = New System.Drawing.Size(1220, 100)
        Me.TabMenu.TabIndex = 0
        '
        'pgATENDIMENTO
        '
        Me.pgATENDIMENTO.Controls.Add(Me.btnNovosClientes)
        Me.pgATENDIMENTO.Controls.Add(Me.btnLINKs)
        Me.pgATENDIMENTO.Controls.Add(Me.btnCEPs)
        Me.pgATENDIMENTO.Controls.Add(Me.btnTELEFONES)
        Me.pgATENDIMENTO.Controls.Add(Me.btnPesquisarClientes)
        Me.pgATENDIMENTO.Controls.Add(Me.btnSOLICITACAO)
        Me.pgATENDIMENTO.Controls.Add(Me.btnAGENDA)
        Me.pgATENDIMENTO.Location = New System.Drawing.Point(4, 22)
        Me.pgATENDIMENTO.Name = "pgATENDIMENTO"
        Me.pgATENDIMENTO.Padding = New System.Windows.Forms.Padding(3)
        Me.pgATENDIMENTO.Size = New System.Drawing.Size(1212, 74)
        Me.pgATENDIMENTO.TabIndex = 0
        Me.pgATENDIMENTO.Text = "ATENDIMENTO"
        Me.pgATENDIMENTO.UseVisualStyleBackColor = True
        '
        'btnNovosClientes
        '
        Me.btnNovosClientes.Image = Global.RETEC.My.Resources.Resources.business_contact
        Me.btnNovosClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNovosClientes.Location = New System.Drawing.Point(330, 6)
        Me.btnNovosClientes.Name = "btnNovosClientes"
        Me.btnNovosClientes.Size = New System.Drawing.Size(103, 62)
        Me.btnNovosClientes.TabIndex = 26
        Me.btnNovosClientes.Text = "CADASTRO DE CLIENTE"
        Me.btnNovosClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovosClientes.UseVisualStyleBackColor = True
        '
        'btnLINKs
        '
        Me.btnLINKs.Enabled = False
        Me.btnLINKs.Image = Global.RETEC.My.Resources.Resources.add_link
        Me.btnLINKs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLINKs.Location = New System.Drawing.Point(997, 6)
        Me.btnLINKs.Name = "btnLINKs"
        Me.btnLINKs.Size = New System.Drawing.Size(101, 62)
        Me.btnLINKs.TabIndex = 25
        Me.btnLINKs.Text = "LINK'S"
        Me.btnLINKs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLINKs.UseVisualStyleBackColor = True
        '
        'btnCEPs
        '
        Me.btnCEPs.Enabled = False
        Me.btnCEPs.Image = Global.RETEC.My.Resources.Resources.map_marker
        Me.btnCEPs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCEPs.Location = New System.Drawing.Point(890, 6)
        Me.btnCEPs.Name = "btnCEPs"
        Me.btnCEPs.Size = New System.Drawing.Size(101, 62)
        Me.btnCEPs.TabIndex = 23
        Me.btnCEPs.Text = "CEP'S"
        Me.btnCEPs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCEPs.UseVisualStyleBackColor = True
        '
        'btnTELEFONES
        '
        Me.btnTELEFONES.Enabled = False
        Me.btnTELEFONES.Image = Global.RETEC.My.Resources.Resources.address_book
        Me.btnTELEFONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTELEFONES.Location = New System.Drawing.Point(1104, 6)
        Me.btnTELEFONES.Name = "btnTELEFONES"
        Me.btnTELEFONES.Size = New System.Drawing.Size(101, 62)
        Me.btnTELEFONES.TabIndex = 22
        Me.btnTELEFONES.Text = "TELEFONES"
        Me.btnTELEFONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTELEFONES.UseVisualStyleBackColor = True
        '
        'btnPesquisarClientes
        '
        Me.btnPesquisarClientes.Image = Global.RETEC.My.Resources.Resources.search
        Me.btnPesquisarClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPesquisarClientes.Location = New System.Drawing.Point(221, 6)
        Me.btnPesquisarClientes.Name = "btnPesquisarClientes"
        Me.btnPesquisarClientes.Size = New System.Drawing.Size(103, 62)
        Me.btnPesquisarClientes.TabIndex = 2
        Me.btnPesquisarClientes.Text = "PESQUISAR CLIENTES"
        Me.btnPesquisarClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPesquisarClientes.UseVisualStyleBackColor = True
        '
        'btnSOLICITACAO
        '
        Me.btnSOLICITACAO.Image = Global.RETEC.My.Resources.Resources.assistant
        Me.btnSOLICITACAO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSOLICITACAO.Location = New System.Drawing.Point(112, 6)
        Me.btnSOLICITACAO.Name = "btnSOLICITACAO"
        Me.btnSOLICITACAO.Size = New System.Drawing.Size(103, 62)
        Me.btnSOLICITACAO.TabIndex = 1
        Me.btnSOLICITACAO.Text = "LIGAÇÃO"
        Me.btnSOLICITACAO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSOLICITACAO.UseVisualStyleBackColor = True
        '
        'btnAGENDA
        '
        Me.btnAGENDA.Image = Global.RETEC.My.Resources.Resources._date
        Me.btnAGENDA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAGENDA.Location = New System.Drawing.Point(3, 6)
        Me.btnAGENDA.Name = "btnAGENDA"
        Me.btnAGENDA.Size = New System.Drawing.Size(103, 62)
        Me.btnAGENDA.TabIndex = 0
        Me.btnAGENDA.Text = "AGENDA"
        Me.btnAGENDA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAGENDA.UseVisualStyleBackColor = True
        '
        'pgLOGISTICA
        '
        Me.pgLOGISTICA.Controls.Add(Me.btnCACAMBAS)
        Me.pgLOGISTICA.Controls.Add(Me.btnVIAGENS)
        Me.pgLOGISTICA.Controls.Add(Me.btnROTEIROS)
        Me.pgLOGISTICA.Location = New System.Drawing.Point(4, 22)
        Me.pgLOGISTICA.Name = "pgLOGISTICA"
        Me.pgLOGISTICA.Padding = New System.Windows.Forms.Padding(3)
        Me.pgLOGISTICA.Size = New System.Drawing.Size(1212, 74)
        Me.pgLOGISTICA.TabIndex = 1
        Me.pgLOGISTICA.Text = "LOGISTICA"
        Me.pgLOGISTICA.UseVisualStyleBackColor = True
        '
        'btnCACAMBAS
        '
        Me.btnCACAMBAS.Enabled = False
        Me.btnCACAMBAS.Image = Global.RETEC.My.Resources.Resources.compass
        Me.btnCACAMBAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCACAMBAS.Location = New System.Drawing.Point(221, 6)
        Me.btnCACAMBAS.Name = "btnCACAMBAS"
        Me.btnCACAMBAS.Size = New System.Drawing.Size(103, 62)
        Me.btnCACAMBAS.TabIndex = 4
        Me.btnCACAMBAS.Text = "ONDE ESTÃO AS CAÇAMBAS?"
        Me.btnCACAMBAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCACAMBAS.UseVisualStyleBackColor = True
        '
        'btnVIAGENS
        '
        Me.btnVIAGENS.Enabled = False
        Me.btnVIAGENS.Image = Global.RETEC.My.Resources.Resources.Data_Grid_26x26
        Me.btnVIAGENS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVIAGENS.Location = New System.Drawing.Point(112, 6)
        Me.btnVIAGENS.Name = "btnVIAGENS"
        Me.btnVIAGENS.Size = New System.Drawing.Size(103, 62)
        Me.btnVIAGENS.TabIndex = 3
        Me.btnVIAGENS.Text = "CONTROLE DE VIAGENS"
        Me.btnVIAGENS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVIAGENS.UseVisualStyleBackColor = True
        '
        'btnROTEIROS
        '
        Me.btnROTEIROS.Enabled = False
        Me.btnROTEIROS.Image = Global.RETEC.My.Resources.Resources.delivery
        Me.btnROTEIROS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnROTEIROS.Location = New System.Drawing.Point(3, 6)
        Me.btnROTEIROS.Name = "btnROTEIROS"
        Me.btnROTEIROS.Size = New System.Drawing.Size(103, 62)
        Me.btnROTEIROS.TabIndex = 2
        Me.btnROTEIROS.Text = "CONTROLE DE ROTEIROS"
        Me.btnROTEIROS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnROTEIROS.UseVisualStyleBackColor = True
        '
        'pgFATURAMENTO
        '
        Me.pgFATURAMENTO.Controls.Add(Me.btnRECIBOS)
        Me.pgFATURAMENTO.Controls.Add(Me.btnREMESSA)
        Me.pgFATURAMENTO.Controls.Add(Me.btnBOLETOS)
        Me.pgFATURAMENTO.Controls.Add(Me.btnFATURAMENTO)
        Me.pgFATURAMENTO.Location = New System.Drawing.Point(4, 22)
        Me.pgFATURAMENTO.Name = "pgFATURAMENTO"
        Me.pgFATURAMENTO.Size = New System.Drawing.Size(1212, 74)
        Me.pgFATURAMENTO.TabIndex = 2
        Me.pgFATURAMENTO.Text = "FATURAMENTO"
        Me.pgFATURAMENTO.UseVisualStyleBackColor = True
        '
        'btnRECIBOS
        '
        Me.btnRECIBOS.Enabled = False
        Me.btnRECIBOS.Image = Global.RETEC.My.Resources.Resources.check_book
        Me.btnRECIBOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRECIBOS.Location = New System.Drawing.Point(330, 6)
        Me.btnRECIBOS.Name = "btnRECIBOS"
        Me.btnRECIBOS.Size = New System.Drawing.Size(103, 62)
        Me.btnRECIBOS.TabIndex = 8
        Me.btnRECIBOS.Text = "EMISSÃO DE RECIBOS"
        Me.btnRECIBOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRECIBOS.UseVisualStyleBackColor = True
        '
        'btnREMESSA
        '
        Me.btnREMESSA.Enabled = False
        Me.btnREMESSA.Image = Global.RETEC.My.Resources.Resources.paper_plane
        Me.btnREMESSA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnREMESSA.Location = New System.Drawing.Point(221, 6)
        Me.btnREMESSA.Name = "btnREMESSA"
        Me.btnREMESSA.Size = New System.Drawing.Size(103, 62)
        Me.btnREMESSA.TabIndex = 7
        Me.btnREMESSA.Text = "ARQUIVO DE REMESSA"
        Me.btnREMESSA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnREMESSA.UseVisualStyleBackColor = True
        '
        'btnBOLETOS
        '
        Me.btnBOLETOS.Enabled = False
        Me.btnBOLETOS.Image = Global.RETEC.My.Resources.Resources.barcode
        Me.btnBOLETOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBOLETOS.Location = New System.Drawing.Point(112, 6)
        Me.btnBOLETOS.Name = "btnBOLETOS"
        Me.btnBOLETOS.Size = New System.Drawing.Size(103, 62)
        Me.btnBOLETOS.TabIndex = 6
        Me.btnBOLETOS.Text = "CONTROLE DE BOLETOS"
        Me.btnBOLETOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBOLETOS.UseVisualStyleBackColor = True
        '
        'btnFATURAMENTO
        '
        Me.btnFATURAMENTO.Enabled = False
        Me.btnFATURAMENTO.Image = Global.RETEC.My.Resources.Resources.money_bag
        Me.btnFATURAMENTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFATURAMENTO.Location = New System.Drawing.Point(3, 6)
        Me.btnFATURAMENTO.Name = "btnFATURAMENTO"
        Me.btnFATURAMENTO.Size = New System.Drawing.Size(103, 62)
        Me.btnFATURAMENTO.TabIndex = 5
        Me.btnFATURAMENTO.Text = "FATURAMENTO"
        Me.btnFATURAMENTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFATURAMENTO.UseVisualStyleBackColor = True
        '
        'pgFINANCEIRO
        '
        Me.pgFINANCEIRO.Controls.Add(Me.btnIMPRESSOS_FINANCEIRO)
        Me.pgFINANCEIRO.Controls.Add(Me.btnMOVIMENTO)
        Me.pgFINANCEIRO.Location = New System.Drawing.Point(4, 22)
        Me.pgFINANCEIRO.Name = "pgFINANCEIRO"
        Me.pgFINANCEIRO.Size = New System.Drawing.Size(1212, 74)
        Me.pgFINANCEIRO.TabIndex = 3
        Me.pgFINANCEIRO.Text = "FINANCEIRO"
        Me.pgFINANCEIRO.UseVisualStyleBackColor = True
        '
        'btnIMPRESSOS_FINANCEIRO
        '
        Me.btnIMPRESSOS_FINANCEIRO.Enabled = False
        Me.btnIMPRESSOS_FINANCEIRO.Image = Global.RETEC.My.Resources.Resources.printer
        Me.btnIMPRESSOS_FINANCEIRO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIMPRESSOS_FINANCEIRO.Location = New System.Drawing.Point(112, 6)
        Me.btnIMPRESSOS_FINANCEIRO.Name = "btnIMPRESSOS_FINANCEIRO"
        Me.btnIMPRESSOS_FINANCEIRO.Size = New System.Drawing.Size(103, 62)
        Me.btnIMPRESSOS_FINANCEIRO.TabIndex = 10
        Me.btnIMPRESSOS_FINANCEIRO.Text = "RELATÓRIOS FINANCEIROS"
        Me.btnIMPRESSOS_FINANCEIRO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIMPRESSOS_FINANCEIRO.UseVisualStyleBackColor = True
        '
        'btnMOVIMENTO
        '
        Me.btnMOVIMENTO.Enabled = False
        Me.btnMOVIMENTO.Image = Global.RETEC.My.Resources.Resources.combo
        Me.btnMOVIMENTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMOVIMENTO.Location = New System.Drawing.Point(3, 6)
        Me.btnMOVIMENTO.Name = "btnMOVIMENTO"
        Me.btnMOVIMENTO.Size = New System.Drawing.Size(103, 62)
        Me.btnMOVIMENTO.TabIndex = 9
        Me.btnMOVIMENTO.Text = "MOVIMENTO FINANCEIRO"
        Me.btnMOVIMENTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMOVIMENTO.UseVisualStyleBackColor = True
        '
        'pgGERENCIA
        '
        Me.pgGERENCIA.Controls.Add(Me.btnADM_TELEFONES_UTEIS)
        Me.pgGERENCIA.Controls.Add(Me.btnADM_FUNCIONARIOS)
        Me.pgGERENCIA.Controls.Add(Me.btnADM_GERENCIAL)
        Me.pgGERENCIA.Controls.Add(Me.btnADM_CLIENTES)
        Me.pgGERENCIA.Controls.Add(Me.btnADM_USUARIOS)
        Me.pgGERENCIA.Location = New System.Drawing.Point(4, 22)
        Me.pgGERENCIA.Name = "pgGERENCIA"
        Me.pgGERENCIA.Size = New System.Drawing.Size(1212, 74)
        Me.pgGERENCIA.TabIndex = 4
        Me.pgGERENCIA.Text = "GERENCIA"
        Me.pgGERENCIA.UseVisualStyleBackColor = True
        '
        'btnADM_TELEFONES_UTEIS
        '
        Me.btnADM_TELEFONES_UTEIS.Enabled = False
        Me.btnADM_TELEFONES_UTEIS.Image = Global.RETEC.My.Resources.Resources.address_book
        Me.btnADM_TELEFONES_UTEIS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnADM_TELEFONES_UTEIS.Location = New System.Drawing.Point(333, 6)
        Me.btnADM_TELEFONES_UTEIS.Name = "btnADM_TELEFONES_UTEIS"
        Me.btnADM_TELEFONES_UTEIS.Size = New System.Drawing.Size(101, 62)
        Me.btnADM_TELEFONES_UTEIS.TabIndex = 21
        Me.btnADM_TELEFONES_UTEIS.Text = "TELEFONES UTEIS"
        Me.btnADM_TELEFONES_UTEIS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnADM_TELEFONES_UTEIS.UseVisualStyleBackColor = True
        '
        'btnADM_FUNCIONARIOS
        '
        Me.btnADM_FUNCIONARIOS.Enabled = False
        Me.btnADM_FUNCIONARIOS.Image = Global.RETEC.My.Resources.Resources.collaborator
        Me.btnADM_FUNCIONARIOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnADM_FUNCIONARIOS.Location = New System.Drawing.Point(226, 6)
        Me.btnADM_FUNCIONARIOS.Name = "btnADM_FUNCIONARIOS"
        Me.btnADM_FUNCIONARIOS.Size = New System.Drawing.Size(101, 62)
        Me.btnADM_FUNCIONARIOS.TabIndex = 14
        Me.btnADM_FUNCIONARIOS.Text = "FUNCIONÁRIOS"
        Me.btnADM_FUNCIONARIOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnADM_FUNCIONARIOS.UseVisualStyleBackColor = True
        '
        'btnADM_GERENCIAL
        '
        Me.btnADM_GERENCIAL.Enabled = False
        Me.btnADM_GERENCIAL.Image = Global.RETEC.My.Resources.Resources.administrator
        Me.btnADM_GERENCIAL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnADM_GERENCIAL.Location = New System.Drawing.Point(8, 6)
        Me.btnADM_GERENCIAL.Name = "btnADM_GERENCIAL"
        Me.btnADM_GERENCIAL.Size = New System.Drawing.Size(103, 62)
        Me.btnADM_GERENCIAL.TabIndex = 13
        Me.btnADM_GERENCIAL.Text = "ADM GERENCIAL"
        Me.btnADM_GERENCIAL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnADM_GERENCIAL.UseVisualStyleBackColor = True
        '
        'btnADM_CLIENTES
        '
        Me.btnADM_CLIENTES.Enabled = False
        Me.btnADM_CLIENTES.Image = Global.RETEC.My.Resources.Resources.business_contact
        Me.btnADM_CLIENTES.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnADM_CLIENTES.Location = New System.Drawing.Point(117, 6)
        Me.btnADM_CLIENTES.Name = "btnADM_CLIENTES"
        Me.btnADM_CLIENTES.Size = New System.Drawing.Size(103, 62)
        Me.btnADM_CLIENTES.TabIndex = 12
        Me.btnADM_CLIENTES.Text = "CLIENTES"
        Me.btnADM_CLIENTES.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnADM_CLIENTES.UseVisualStyleBackColor = True
        '
        'btnADM_USUARIOS
        '
        Me.btnADM_USUARIOS.Enabled = False
        Me.btnADM_USUARIOS.Image = Global.RETEC.My.Resources.Resources.group
        Me.btnADM_USUARIOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnADM_USUARIOS.Location = New System.Drawing.Point(440, 6)
        Me.btnADM_USUARIOS.Name = "btnADM_USUARIOS"
        Me.btnADM_USUARIOS.Size = New System.Drawing.Size(103, 62)
        Me.btnADM_USUARIOS.TabIndex = 11
        Me.btnADM_USUARIOS.Text = "USUÁRIOS"
        Me.btnADM_USUARIOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnADM_USUARIOS.UseVisualStyleBackColor = True
        '
        'pgSISTEMA
        '
        Me.pgSISTEMA.Controls.Add(Me.btnCONTROLE_OPERACIONAL)
        Me.pgSISTEMA.Controls.Add(Me.btnUSUARIOS)
        Me.pgSISTEMA.Location = New System.Drawing.Point(4, 22)
        Me.pgSISTEMA.Name = "pgSISTEMA"
        Me.pgSISTEMA.Size = New System.Drawing.Size(1212, 74)
        Me.pgSISTEMA.TabIndex = 5
        Me.pgSISTEMA.Text = "SISTEMA"
        Me.pgSISTEMA.UseVisualStyleBackColor = True
        '
        'btnCONTROLE_OPERACIONAL
        '
        Me.btnCONTROLE_OPERACIONAL.Enabled = False
        Me.btnCONTROLE_OPERACIONAL.Image = Global.RETEC.My.Resources.Resources.tree_structure
        Me.btnCONTROLE_OPERACIONAL.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCONTROLE_OPERACIONAL.Location = New System.Drawing.Point(112, 6)
        Me.btnCONTROLE_OPERACIONAL.Name = "btnCONTROLE_OPERACIONAL"
        Me.btnCONTROLE_OPERACIONAL.Size = New System.Drawing.Size(103, 62)
        Me.btnCONTROLE_OPERACIONAL.TabIndex = 15
        Me.btnCONTROLE_OPERACIONAL.Text = "CONTROLE OPERACIONAL"
        Me.btnCONTROLE_OPERACIONAL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCONTROLE_OPERACIONAL.UseVisualStyleBackColor = True
        '
        'btnUSUARIOS
        '
        Me.btnUSUARIOS.Enabled = False
        Me.btnUSUARIOS.Image = Global.RETEC.My.Resources.Resources.group
        Me.btnUSUARIOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUSUARIOS.Location = New System.Drawing.Point(3, 6)
        Me.btnUSUARIOS.Name = "btnUSUARIOS"
        Me.btnUSUARIOS.Size = New System.Drawing.Size(103, 62)
        Me.btnUSUARIOS.TabIndex = 14
        Me.btnUSUARIOS.Text = "USUÁRIOS"
        Me.btnUSUARIOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUSUARIOS.UseVisualStyleBackColor = True
        '
        'FPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 657)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "FPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA DE CONTROLE DE CAÇAMBAS ESTACIONÁRIAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.TabMenu.ResumeLayout(False)
        Me.pgATENDIMENTO.ResumeLayout(False)
        Me.pgLOGISTICA.ResumeLayout(False)
        Me.pgFATURAMENTO.ResumeLayout(False)
        Me.pgFINANCEIRO.ResumeLayout(False)
        Me.pgGERENCIA.ResumeLayout(False)
        Me.pgSISTEMA.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabMenu As System.Windows.Forms.TabControl
    Friend WithEvents pgATENDIMENTO As System.Windows.Forms.TabPage
    Friend WithEvents pgLOGISTICA As System.Windows.Forms.TabPage
    Friend WithEvents pgFATURAMENTO As System.Windows.Forms.TabPage
    Friend WithEvents pgFINANCEIRO As System.Windows.Forms.TabPage
    Friend WithEvents pgGERENCIA As System.Windows.Forms.TabPage
    Friend WithEvents pgSISTEMA As System.Windows.Forms.TabPage
    Friend WithEvents btnAGENDA As System.Windows.Forms.Button
    Friend WithEvents btnSOLICITACAO As System.Windows.Forms.Button
    Friend WithEvents btnROTEIROS As System.Windows.Forms.Button
    Friend WithEvents btnVIAGENS As System.Windows.Forms.Button
    Friend WithEvents btnCACAMBAS As System.Windows.Forms.Button
    Friend WithEvents btnFATURAMENTO As System.Windows.Forms.Button
    Friend WithEvents btnBOLETOS As System.Windows.Forms.Button
    Friend WithEvents btnREMESSA As System.Windows.Forms.Button
    Friend WithEvents btnRECIBOS As System.Windows.Forms.Button
    Friend WithEvents btnMOVIMENTO As System.Windows.Forms.Button
    Friend WithEvents btnIMPRESSOS_FINANCEIRO As System.Windows.Forms.Button
    Friend WithEvents btnADM_USUARIOS As System.Windows.Forms.Button
    Friend WithEvents btnADM_GERENCIAL As System.Windows.Forms.Button
    Friend WithEvents btnADM_CLIENTES As System.Windows.Forms.Button
    Friend WithEvents btnUSUARIOS As System.Windows.Forms.Button
    Friend WithEvents btnCONTROLE_OPERACIONAL As System.Windows.Forms.Button
    Friend WithEvents btnPesquisarClientes As System.Windows.Forms.Button
    Friend WithEvents btnADM_FUNCIONARIOS As System.Windows.Forms.Button
    Friend WithEvents btnADM_TELEFONES_UTEIS As System.Windows.Forms.Button
    Friend WithEvents btnTELEFONES As System.Windows.Forms.Button
    Friend WithEvents btnCEPs As System.Windows.Forms.Button
    Friend WithEvents btnLINKs As System.Windows.Forms.Button
    Friend WithEvents btnNovosClientes As System.Windows.Forms.Button

End Class

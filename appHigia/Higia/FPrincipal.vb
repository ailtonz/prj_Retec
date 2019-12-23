Public Class FPrincipal

    Private Sub btnSOLICITACAO_Click(sender As System.Object, e As System.EventArgs) Handles btnSOLICITACAO.Click

        Dim frmSolicitacao As New cadastroLigacao

        'Dim frmSolicitacao As New F_CAD_LIGACAO


        With frmSolicitacao
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With

    End Sub

    Private Sub btnAGENDA_Click(sender As System.Object, e As System.EventArgs) Handles btnAGENDA.Click

        Dim frmAgenda As New pesquisaAgenda

        With frmAgenda
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With


        'For Each ChildForm As Form In Me.MdiChildren
        '    ChildForm.Close()
        'Next

    End Sub

    Private Sub btnROTEIROS_Click(sender As System.Object, e As System.EventArgs) Handles btnROTEIROS.Click
        Dim frmRoteiro As New F_SRV_ROTEIROS

        With frmRoteiro
            '.MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With

    End Sub

    Private Sub FPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''REMOÇÃO DE GUIA VIA PROGRAMAÇÃO
        'Me.TabMenu.Controls.Remove(Me.TabMenu.TabPages(6))

        ''ADIÇÃO DE GUIA VIA PROGRAMAÇÃO
        'TabControl1.Controls.Add(New TabPage("TabPage2"))


    End Sub



    Private Sub btnCONTROLE_OPERACIONAL_Click(sender As System.Object, e As System.EventArgs) Handles btnCONTROLE_OPERACIONAL.Click
        'Dim frmControles As New F_ADM_CONTROLES

        'With frmControles
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With
    End Sub

    Private Sub btnUSUARIOS_Click(sender As System.Object, e As System.EventArgs) Handles btnUSUARIOS.Click
        'Dim frmUsuarios As New F_ADM_USUARIOS

        'With frmUsuarios
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

    End Sub

    Private Sub btnADM_USUARIOS_Click(sender As System.Object, e As System.EventArgs) Handles btnADM_USUARIOS.Click
        'Dim frmUsuarios As New F_ADM_USUARIOS

        'With frmUsuarios
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With
    End Sub

    Private Sub btnADM_CLIENTES_Click(sender As System.Object, e As System.EventArgs) Handles btnADM_CLIENTES.Click
        'Dim frmCliente As New F_CAD_CLIENTE

        'With frmCliente
        '    .MdiParent = Me
        '    .ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

    End Sub

    Private Sub btnADM_FATURAMENTO_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnADM_TRANSPORTADOR_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnADM_FUNCIONARIOS_Click(sender As System.Object, e As System.EventArgs) Handles btnADM_FUNCIONARIOS.Click
        'Dim frmFuncionario As New F_CAD_FUNCIONARIOS

        'With frmFuncionario
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With
    End Sub

    Private Sub btnADM_PROPAGANDAS_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnADM_MATERIAIS_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnADM_LINKS_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnADM_TELEFONES_UTEIS_Click(sender As System.Object, e As System.EventArgs) Handles btnADM_TELEFONES_UTEIS.Click
        'Dim frmUtel As New F_CAD_UTEIS

        'With frmUtel
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With
    End Sub

    Private Sub btnMOVIMENTO_Click(sender As System.Object, e As System.EventArgs) Handles btnMOVIMENTO.Click
        'Dim frmReceita As New F_MOV_RECEITAS
        'Dim frmDespesa As New F_MOV_DESPESAS

        'With frmReceita
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

        'With frmDespesa
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

    End Sub

    Private Sub btnFATURAMENTO_Click(sender As System.Object, e As System.EventArgs) Handles btnFATURAMENTO.Click
        'Dim frmFaturamento As New F_FAT_FATURAMENTO

        'With frmFaturamento
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

    End Sub

    Private Sub btnBOLETOS_Click(sender As System.Object, e As System.EventArgs) Handles btnBOLETOS.Click
        'Dim frmBoleto As New F_FAT_BOLETOS

        'With frmBoleto
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

    End Sub

    Private Sub btnVIAGENS_Click(sender As System.Object, e As System.EventArgs) Handles btnVIAGENS.Click
        'Dim frmViagens As New F_SRV_VIAGENS

        'With frmViagens
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

    End Sub

    Private Sub btnCACAMBAS_Click(sender As System.Object, e As System.EventArgs) Handles btnCACAMBAS.Click
        'Dim frmLocalizar As New F_SRV_LOCALIZAR_CACAMBAS

        'With frmLocalizar
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

    End Sub

    Private Sub btnCATEGORIAS_Click(sender As System.Object, e As System.EventArgs)
        'Dim frmCategoria As New F_MOV_CATEGORIAS

        'With frmCategoria
        '    .MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With
    End Sub

    Private Sub btnADM_GERENCIAL_Click(sender As System.Object, e As System.EventArgs) Handles btnADM_GERENCIAL.Click
        Dim frm As New cadastroTransportador

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With

    End Sub





    Private Sub btnNovosClientes_Click(sender As System.Object, e As System.EventArgs) Handles btnNovosClientes.Click
        Dim frm As New cadastroCliente

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnPesquisarClientes_Click(sender As System.Object, e As System.EventArgs) Handles btnPesquisarClientes.Click
        Dim frm As New pesquisaClientes

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub


End Class

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
        Dim frmRoteiro As New cadastroRoteiros

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

    Private Sub btnADM_TELEFONES_UTEIS_Click(sender As System.Object, e As System.EventArgs)
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

    Private Sub btnADM_GERENCIAL_Click(sender As System.Object, e As System.EventArgs) Handles btnTransportador.Click
        Dim frm As New pesquisarTransportador

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


    Private Sub btnPropagandas_Click(sender As System.Object, e As System.EventArgs) Handles btnPropagandas.Click
        Dim frm As New pesquisarPropagandas

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnCEPs_Click(sender As System.Object, e As System.EventArgs) Handles btnCEPs.Click
        Dim frm As New pesquisarCep

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnStatusServicos_Click(sender As System.Object, e As System.EventArgs) Handles btnStatusServicos.Click
        Dim frm As New pesquisarStatusServicos

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With

    End Sub

    Private Sub btnTipoCadastro_Click(sender As System.Object, e As System.EventArgs) Handles btnTipoCadastro.Click
        Dim frm As New pesquisarTipoCadastros

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub





    Private Sub btnTELEFONES_Click(sender As System.Object, e As System.EventArgs) Handles btnTELEFONES.Click
        Dim frm As New pesquisarTelefones

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnLINKs_Click(sender As System.Object, e As System.EventArgs) Handles btnLINKs.Click
        Dim frm As New pesquisarLinks

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub


    Private Sub btnMateriais_Click(sender As System.Object, e As System.EventArgs) Handles btnMateriais.Click
        Dim frm As New pesquisarMateriais

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnVeiculos_Click(sender As System.Object, e As System.EventArgs) Handles btnVeiculos.Click
        Dim frm As New pesquisarVeiculos

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnCARGO_Click(sender As System.Object, e As System.EventArgs) Handles btnCARGO.Click
        Dim frm As New pesquisarCargos

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnStatusClientes_Click(sender As System.Object, e As System.EventArgs) Handles btnStatusClientes.Click
        Dim frm As New pesquisarObservacao

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnCondicoes_Click(sender As System.Object, e As System.EventArgs) Handles btnCondicoes.Click
        Dim frm As New pesquisarCondicoes

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnTransacoes_Click(sender As System.Object, e As System.EventArgs) Handles btnTransacoes.Click
        Dim frm As New pesquisarTransacao

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnPrecificacao_Click(sender As System.Object, e As System.EventArgs) Handles btnPrecificacao.Click
        Dim frm As New pesquisarStatusPrecificacao

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnStatusLigacoes_Click(sender As System.Object, e As System.EventArgs) Handles btnStatusLigacoes.Click
        Dim frm As New pesquisarStatusLigacoes

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnAterros_Click(sender As System.Object, e As System.EventArgs) Handles btnAterros.Click
        Dim frm As New pesquisarAterro

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub btnFuncionarios_Click(sender As System.Object, e As System.EventArgs) Handles btnFuncionarios.Click
        Dim frm As New pesquisarFuncionario

        With frm
            .MdiParent = Me
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub
End Class

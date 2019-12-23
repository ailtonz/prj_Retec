Public Class F_tmp_SRV_ASSISTENTE
    Dim INDEX As Long = 0
    Dim LIMITE As Long = 0
    Dim strTabelas() As String = {"CLIENTES", "OBRAS"}
    Dim Etapas() As String = {"PESQUISA", "PEDIDO", "CONCLUSÃO"}
    Dim Cadastros() As String = {"CLIENTE", "OBRAS", "CONTATOS", "SELEÇÃO"}

    Private Sub F_SRV_ASSISTENTE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Etapa As String

        Me.lstEtapas.Items.Clear()
        For Each Etapa In Etapas
            Me.lstEtapas.Items.Add(Etapa)
        Next

        Me.lstEtapas.SelectedIndex = INDEX
        LIMITE = UBound(Etapas)

        Me.pnl_01_PESQUISA.Visible = True

        CarregarCombo(Me.cmbTABELA)


        'Dim f As New FCadastro
        'f.TopLevel = False
        'Me.Controls.Add(f)
        'f.Show()
    End Sub

    Private Sub btnNOVO_Click(sender As System.Object, e As System.EventArgs) Handles btnNOVO.Click
        'Dim Cadastro As String

        'Me.lstEtapas.Items.Clear()
        'For Each Cadastro In Cadastros
        '    Me.lstEtapas.Items.Add(Cadastro)
        'Next

        'Me.lstEtapas.SelectedIndex = INDEX
        'LIMITE = UBound(Cadastros)


        'Dim frmCliente As New F_CAD_CLIENTE_NOVO

        'With frmCliente
        '    '.MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

    End Sub


    Private Sub btnAVANCAR_Click(sender As System.Object, e As System.EventArgs) Handles btnAVANCAR.Click
        If INDEX >= LIMITE Then
            INDEX = 0
            Me.lstEtapas.SelectedIndex = INDEX
        Else
            INDEX = INDEX + 1
            Me.lstEtapas.SelectedIndex = INDEX
        End If

        'If Me.lstEtapas.Text = "PESQUISA" Then
        '    Me.pnl_01_PESQUISA.Hide()
        '    Me.pnl_02_PEDIDO.Show()
        'ElseIf Me.lstEtapas.Text = "PEDIDO" Then
        '    Me.pnl_02_PEDIDO.Hide()
        '    Me.pnl_03_CONCLUSAO.Hide()
        'ElseIf Me.lstEtapas.Text = "CONCLUSÃO" Then
        '    Me.pnl_01_PESQUISA.Show()
        'ElseIf Me.lstEtapas.Text = "CLIENTE" Then
        '    Me.pnl_04_CLIENTE.Hide()
        '    Me.pnl_05_OBRA.Show()
        'ElseIf Me.lstEtapas.Text = "OBRAS" Then
        '    Me.pnl_05_OBRA.Hide()
        '    Me.pnl_06_CONTATO.Show()
        'ElseIf Me.lstEtapas.Text = "SELEÇÃO" Then
        '    Me.pnl_01_PESQUISA.Show()

        'End If


        'Me.pnl_03_OBRA.Hide()

        'Me.pnl_02_CLIENTE.Show()

    End Sub

    Private Sub btnVOLTAR_Click(sender As System.Object, e As System.EventArgs) Handles btnVOLTAR.Click
        If INDEX <= 0 Then
            INDEX = 0
            Me.lstEtapas.SelectedIndex = INDEX
        Else
            INDEX = INDEX - 1
            Me.lstEtapas.SelectedIndex = INDEX
        End If

        'Me.pnl_02_CLIENTE.Hide()

        'Me.pnl_03_OBRA.Show()

    End Sub

    Private Sub CarregarCombo(cbmControle As ComboBox)

        cbmControle.Items.Clear()
        For x = 0 To strTabelas.Count - 1
            cbmControle.Items.Add(strTabelas(x).ToString)
        Next

        'Me.ComboBox1.Text = "CLIENTES"
        ''Me.ComboBox2.Items.Add("NOME")
        'Me.ComboBox2.Text = "NOME"

    End Sub

    Private Sub SelecaoDePainel(ByVal strPainel As String)

        If Me.lstEtapas.SelectedValue = "PESQUISA" Then
            Me.pnl_01_PESQUISA.Visible = True

        End If



    End Sub






    Private Sub btnIMPRIMIR_Click(sender As System.Object, e As System.EventArgs) Handles btnIMPRIMIR.Click

    End Sub
End Class


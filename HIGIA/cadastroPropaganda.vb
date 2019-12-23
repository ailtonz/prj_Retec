Imports System
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports HigiaENT
Imports HigiaNEG

Public Class cadastroPropaganda

    Private _cliente As entCliente

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub F_CAD_CLIENTE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Rotinas = New ClasseRotinasDiversas

    End Sub



    Private Sub F_CAD_CLIENTE_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Rotinas = Nothing
    End Sub

    Private Sub formLock()
        'Dim Ctrl As Control

        'For Each Ctrl In Me.Controls
        '    If TypeOf Ctrl Is Button Then
        '        If Ctrl.Name = "btnCLIENTE_SALVAR" Then
        '            Ctrl.Enabled = True
        '        Else
        '            Ctrl.Enabled = False
        '        End If
        '    Else
        '        Ctrl.Enabled = False
        '    End If

        'Next

    End Sub

    Private Sub formUnLock()
        'Dim Ctrl As Control

        'For Each Ctrl In Me.Controls
        '    Ctrl.Enabled = True
        'Next

    End Sub

    Private Function VALIDAR_CAMPOS(ByVal sessao As String) As Boolean

        Dim blnRet As Boolean = False  'inicializar o valor como false

        'With Me

        '    Select Case sessao

        '        Case "PRINCIPAL"

        '            '' VALIDAR CNPJ_CPF
        '            If Me.cboCADASTRO_TIPO.Text = "FISICO" Then

        '                If Trim(Replace(Replace(.mskCNPJ_CPF.Text, ",", ""), "-", "")) = "" Then
        '                    ErrorProvider1.SetError(.mskCNPJ_CPF, "CNPJ_CPF. Campo de preenchimento obrigatório")
        '                ElseIf Trim(Replace(Replace(Replace(Me.mskCNPJ_CPF.Text, ",", ""), "-", ""), "/", "")) = "" Then
        '                    ErrorProvider1.SetError(.mskCNPJ_CPF, "CNPJ_CPF. Campo de preenchimento obrigatório")
        '                End If

        '            End If

        '            If Trim(.txtPRINCIPAL_NOME.Text) = "" Then

        '                ErrorProvider1.SetError(.txtPRINCIPAL_NOME, "NOME. Campo de preenchimento obrigatório")
        '                .txtPRINCIPAL_NOME.Focus()

        '            ElseIf Trim(.txtPRINCIPAL_NOME_FANTASIA.Text) = "" Then

        '                ErrorProvider1.SetError(.txtPRINCIPAL_NOME_FANTASIA, "NOME FANTASIA. Campo de preenchimento obrigatório")

        '            ElseIf Trim(Replace(.mskPRINCIPAL_CEP.Text, "-", "")) = "" Then

        '                ErrorProvider1.SetError(.mskPRINCIPAL_CEP, "CEP. Campo de preenchimento obrigatório")

        '            ElseIf Trim(.txtPRINCIPAL_NUMERO.Text) = "" Then

        '                ErrorProvider1.SetError(.txtPRINCIPAL_NUMERO, "NUMERO. Campo de preenchimento obrigatório")

        '            ElseIf Trim(.txtPRINCIPAL_CONTATO.Text) = "" Then

        '                ErrorProvider1.SetError(.txtPRINCIPAL_CONTATO, "CONTATO. Campo de preenchimento obrigatório")

        '            ElseIf Trim(.txtPRINCIPAL_TELEFONE.Text) = "" Then

        '                ErrorProvider1.SetError(.txtPRINCIPAL_TELEFONE, "TELEFONE. Campo de preenchimento obrigatório")

        '            Else ''ocorreu um erro ao validar os dados do form

        '                blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)

        '            End If

        '        Case "CONTATOS"

        '            If Trim(.txtCONTATO_NOME.Text) = "" Then

        '                ErrorProvider1.SetError(.txtCONTATO_NOME, "NOME DO CONTATO. Campo de preenchimento obrigatório")

        '            Else ''ocorreu um erro ao validar os dados do form

        '                blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)

        '            End If

        '        Case "HISTORICO"

        '            If Trim(.txtHISTORICO_DADOS.Text) = "" Then

        '                ErrorProvider1.SetError(.txtHISTORICO_DADOS, "HISTORICO. Campo de preenchimento obrigatório")


        '            Else ''ocorreu um erro ao validar os dados do form

        '                blnRet = True 'retornar True, ou seja, TODOS os campos "regras" do form foram validadas com sucesso (não existe nenhum erro no form)

        '            End If

        '    End Select


        'End With


        Return blnRet

    End Function


   




End Class
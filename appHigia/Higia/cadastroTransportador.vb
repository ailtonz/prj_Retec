Imports System
Imports System.Configuration


Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Imports HigiaENT
Imports HigiaNEG

Public Class cadastroTransportador

    Private _Transportador As entTransportador

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub cadastroTransportador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Dim myConnection As String = GetConnectionStringByName("servidor")

        Dim oNeTransportador As New negTransportador
        Dim oEtTransportador As New entTransportador


        Me.txtNome.Text = "ailton zacarias"
        Me.txtCNPJ_CPF.Text = "24797483830"
        Me.txtTelefone.Text = "11 2373-7635"
        Me.txtIE_RG.Text = "263787667"

        Try

            With oEtTransportador
                .Nome = txtNome.Text
                '.ENT_ENDERECO.Endereco = txtEndereco.Text
                '.ENT_ENDERECO.Bairro = txtBairro.Text
                '.ENT_ENDERECO.Cidade = txtCidade.Text
                .ENT_DOCUMENTO.CNPJ_CPF = txtCNPJ_CPF.Text
                .ENT_DOCUMENTO.IE_RG = txtIE_RG.Text
                .ENT_CONTATO.Telefone = txtTelefone.Text


                '.ENT_CONTRATO.PeriodoLocacao = txtCONTRATO_PERIDO_LOCACAO.Text
                '.ENT_CONTRATO.RetiradaAutomatica = txtCONTRATO_RETIRADA_AUTOMATICA.Text
                '.ENT_CONTRATO.VencimentoAposEntrega = txtCONTRATO_VCTO_APOS_ENTREGA.Text
                '.ENT_CONTRATO.MultaMora = txtCONTRATO_MULTA_MORA.Text
                '.ENT_CONTRATO.MultaDia = txtCONTRATO_MULTA_DIA.Text

                ' '' ENDERECO
                'With oEtEndereco
                '    .Endereco = Me.txtPRINCIPAL_ENDERECO.Text
                '    .Numero = Me.txtPRINCIPAL_NUMERO.Text
                '    .Complemento = Me.txtPRINCIPAL_COMPLEMENTO.Text
                '    .Bairro = Me.txtPRINCIPAL_BAIRRO.Text
                '    .Cep = Replace(Me.mskPRINCIPAL_CEP.Text, "-", "")
                '    .Cidade = Me.txtPRINCIPAL_CIDADE.Text
                '    .Estado = Me.txtPRINCIPAL_ESTADO.Text
                'End With

                '.ENT_ENDERECO = oEtEndereco

                ' '' CONTATO
                'With oEtContato

                '    .Contato = Me.txtPRINCIPAL_CONTATO.Text
                '    .Telefone = Me.txtPRINCIPAL_TELEFONE.Text
                '    .Email = Me.txtPRINCIPAL_EMAIL.Text
                'End With

                '.ENT_CONTATO = oEtContato

                ' '' REGISTRO
                '.CadastroUsuario = "AZS" 'Me.txtCAD_USUARIO.Text

                oNeTransportador.Incluir(oEtTransportador, myConnection)

                MessageBox.Show("salvo")
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Shared Function GetConnectionStringByName(ByVal name As String) As String
        ' Retrieves a connection string by name.
        ' Returns Nothing if the name is not found.

        ' Assume failure
        Dim returnValue As String = Nothing

        ' Look for the name in the connectionStrings section.
        Dim settings As ConnectionStringSettings = _
           ConfigurationManager.ConnectionStrings(name)

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            returnValue = settings.ConnectionString
        End If

        Return returnValue
    End Function
End Class
Imports MySql.Data.MySqlClient

Public Class F_tmp_GERENCIA
    Protected Rotinas As ClasseRotinasDiversas
    Protected BancoDados As ClasseBancoDados

    'Dim cmdComandoSQL As MySqlCommand
    'Dim rdrRegistro As MySqlDataReader

    Private Sub btnSALVAR_TRANSPORTADOR_Click(sender As System.Object, e As System.EventArgs) Handles btnSALVAR_TRANSPORTADOR.Click

        'BancoDados = New ClasseBancoDados(strConexaoWeb)
        'Rotinas = New ClasseRotinasDiversas


        'With BancoDados

        '    .Abrir()
        '    .Operacao = "EDITAR"
        '    .ComandoProcedure = "sp_ADM_TRANSPORTADOR_UPDATE"



        '    .CriaProcedure()

        '    If strCadastro_Tipo = "FISICO" Then
        '        .AdicionaParametro("p_CADASTRO_TIPO", "PF")
        '    ElseIf strCadastro_Tipo = "JURIDICO" Then
        '        .AdicionaParametro("p_CADASTRO_TIPO", "PJ")
        '    End If

        '    .AdicionaParametro("p_NOME_FANTASIA", Me.txtNOME_FANTASIA.Text)
        '    .AdicionaParametro("p_NOME", Me.txtPRINCIPAL_NOME.Text)
        '    .AdicionaParametro("p_ENDERECO", Me.txtPRINCIPAL_ENDERECO.Text)
        '    .AdicionaParametro("p_NUMERO", Me.txtPRINCIPAL_NUMERO.Text)
        '    .AdicionaParametro("p_COMPLEMENTO", Me.txtPRINCIPAL_COMPLEMENTO.Text)
        '    .AdicionaParametro("p_BAIRRO", Me.txtPRINCIPAL_BAIRRO.Text)
        '    .AdicionaParametro("p_CEP", strCEP_PRINCIPAL)
        '    .AdicionaParametro("p_CIDADE", Me.txtPRINCIPAL_CIDADE.Text)
        '    .AdicionaParametro("p_ESTADO", Me.cboPRINCIPAL_ESTADO.Text)
        '    .AdicionaParametro("p_CONTATO", Me.txtPRINCIPAL_CONTATO.Text)
        '    .AdicionaParametro("p_TELEFONE", Me.txtPRINCIPAL_TELEFONE.Text)
        '    .AdicionaParametro("p_EMAIL", Me.txtPRINCIPAL_EMAIL.Text)
        '    .AdicionaParametro("p_CNPJ_CPF", strDocumento)
        '    .AdicionaParametro("p_CADASTRO_STATUS", Me.cboCADASTRO_STATUS.Text)
        '    .AdicionaParametro("p_CADASTRO_OBSERVACAO", Me.cboCADASTRO_OBSERVACAO.Text)


        '    '' CONTROLE DO SISTEMA - USUARIO RESPONSÁVEL PELO CADASTRO
        '    If .Operacao = "ADICIONAR" Then

        '        .AdicionaParametro("p_CADASTRO_USUARIO", "ADM")
        '        .AdicionaParametro("p_SISTEMA_USUARIO", "ADM")
        '        .AdicionaParametro("p_CADASTRO_PROPAGANDA", Me.cboCADASTRO_PROPAGANDA.Text)

        '    ElseIf .Operacao = "EDITAR" Then

        '        .AdicionaParametro("p_SISTEMA_USUARIO", "ADM")

        '    End If



        '    Try
        '        .ExecutaProcedure()
        '    Catch erro As MySqlException
        '        MessageBox.Show("erro ao executar comando: " & erro.Message)

        '    End Try

        '    .Fechar()
        'End With



        ' '' BLOQUEIO
        'Rotinas.BloqueioDeCampo(Me, False)

        'Rotinas.LimparCampos(Me)

        'MsgBox("REGISTRO SALVO.", MsgBoxStyle.OkOnly + MessageBoxIcon.Asterisk)




        'BancoDados.Abrir()
        'Rotinas.LimparCampos(Me)


    End Sub

    Private Sub F_ADM_GERENCIA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Dim strComandoSQL As String

        'Dim DADOS As New DataTable

        'BancoDados = New ClasseBancoDados(strConexaoWeb)
        'Rotinas = New ClasseRotinasDiversas

        'BancoDados.Abrir()
        'Rotinas.LimparCampos(Me)


    End Sub

    Private Sub F_ADM_GERENCIA_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'BancoDados.Fechar()
        BancoDados = Nothing
        Rotinas = Nothing
    End Sub

    Public Sub ReadOrderData(ByVal connectionString As String)
        Dim DADOS As New DataTable

        Dim queryString As String = "SELECT * FROM vw_adm_faturamento_condicao;"

        Using connection As New MySqlConnection(strSERVER)
            Dim command As New MySqlCommand(queryString, connection)
            BancoDados.Abrir()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            dgwCONDICOES.DataSource = DADOS


            Try
                While reader.Read()
                    Console.WriteLine(String.Format("{0}, {1}", reader(0), reader(1)))
                End While
            Finally
                ' Always call Close when done reading.
                reader.Close()
            End Try

        End Using


    End Sub


End Class
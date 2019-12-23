Imports System
Imports System.Configuration

Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbConnection

Imports MySql.Data.MySqlClient

Public Class F_tmp_IMP_DADOS
    Protected Rotinas As ClasseRotinasDiversas
    Protected BancoDados As ClasseBancoDados

    Dim CaminhoBanco As String = "C:\Users\user\Desktop\HIGIA\130412-1053\dbITAU_2012_130201-2035.mdb"

    Private Sub btnCLIENTES_Click(sender As System.Object, e As System.EventArgs) Handles btnCLIENTES.Click

        'Dim CaminhoBanco As String = "C:\Users\user\Desktop\HIGIA\130412-1053\dbITAU_2012_130201-2035.mdb"

        Dim Senha As String = ""

        BancoDados = New ClasseBancoDados(strSERVER)
        Rotinas = New ClasseRotinasDiversas

        Dim RESPOSTA As DialogResult = MessageBox.Show("DESEJA IMPORTAR CLIENTES ?", "IMPORTAR CLIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If RESPOSTA = Windows.Forms.DialogResult.Yes Then

            'Dim rdrRegistro As MySqlDataReader


            'define a string de conexão com o banco de dados
            Dim strConn As String = _
                "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=" & CaminhoBanco & ";" & _
                "Jet OLEDB:Database Locking Mode=1;" & _
                "User ID=Admin;" & _
                "Password=" & Senha & ""


            '' CONTADOR
            Dim sqlCount As String = "SELECT count(*) as qtdCLI FROM qryCLIENTES"
            Dim objCmd As New OleDbCommand(sqlCount, New OleDbConnection(strConn))

            objCmd.Connection.Open()
            Dim intCount As Integer = CInt(objCmd.ExecuteScalar)
            objCmd.Connection.Close()

            'Dim x As Integer = 1

            Me.prnCONTATOS.Maximum = intCount


            'define o objeto OledbConnection usando a string de conexão
            Dim conexao As New OleDbConnection(strConn)

            'define a instrução SQL que será usada para extrair as linhas da tabela Authors
            Dim sql As String = "SELECT * FROM qryCLIENTES"

            'cria o objeto OleDbCommand
            Dim comando As New OleDbCommand(sql, conexao)

            conexao.Open()

            Dim reader As OleDbDataReader = comando.ExecuteReader()


            With BancoDados
                .Abrir()
                Me.prnCONTATOS.Value = 1

                While reader.Read()
                    .ComandoProcedure = "sp_CAD_CLIENTE_INSERT"
                    .CriaProcedure()

                    '' CLIENTE
                    '' DADOS GERAIS
                    .AdicionaParametro("p_NOME_FANTASIA", reader("NOME_FANTASIA").ToString())
                    .AdicionaParametro("p_NOME", reader("NOME").ToString())

                    '' ENDERECO
                    .AdicionaParametro("p_ENDERECO", reader("ENDERECO").ToString())
                    .AdicionaParametro("p_NUMERO", reader("NUMERO").ToString())
                    .AdicionaParametro("p_COMPLEMENTO", reader("COMPLEMENTO").ToString())
                    .AdicionaParametro("p_BAIRRO", reader("BAIRRO").ToString())
                    .AdicionaParametro("p_CEP", reader("CEP").ToString())
                    .AdicionaParametro("p_CIDADE", reader("CIDADE").ToString())
                    .AdicionaParametro("p_ESTADO", reader("ESTADO").ToString())

                    '' CONTATO
                    .AdicionaParametro("p_CONTATO", reader("CONTATO").ToString())
                    .AdicionaParametro("p_TELEFONE", reader("TELEFONE").ToString())
                    .AdicionaParametro("p_EMAIL", reader("EMAIL").ToString())

                    '' DOCUMENTOS
                    .AdicionaParametro("p_CNPJ_CPF", reader("CNPJ_CPF").ToString())
                    .AdicionaParametro("p_IE_RG", reader("IE_RG").ToString())

                    '' OBSERVAÇÕES ADICIONAIS
                    .AdicionaParametro("p_CADASTRO_TIPO", reader("CADASTRO_TIPO").ToString())
                    .AdicionaParametro("p_CADASTRO_STATUS", reader("CADASTRO_STATUS").ToString())
                    .AdicionaParametro("p_CADASTRO_PROPAGANDA", reader("CADASTRO_PROPAGANDA").ToString())
                    .AdicionaParametro("p_CADASTRO_OBSERVACAO", reader("CADASTRO_OBSERVACAO").ToString())

                    '' USUÁRIO RESPONSÁVEL PELO CADASTRO
                    .AdicionaParametro("p_USUARIO", "ADM")

                    '' EXECUÇÃO DA PROCDURE
                    .ExecutaProcedure()
                    If Not (Me.prnCONTATOS.Value = Me.prnCONTATOS.Maximum) Then Me.prnCONTATOS.Value = Me.prnCONTATOS.Value + 1

                End While

                .Fechar()
                reader.Close()
            End With
            MsgBox("OK", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub btnOBRAS_Click(sender As System.Object, e As System.EventArgs) Handles btnOBRAS.Click
        'Dim CaminhoBanco As String = "C:\Users\user\Desktop\HIGIA\130412-1053\dbITAU_2012_130201-2035.mdb"
        Dim Senha As String = ""

        Dim RESPOSTA As DialogResult = MessageBox.Show("DESEJA IMPORTAR OBRAS ?", "IMPORTAR OBRAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If RESPOSTA = Windows.Forms.DialogResult.Yes Then

            BancoDados = New ClasseBancoDados(strSERVER)
            Rotinas = New ClasseRotinasDiversas


            'Dim rdrRegistro As MySqlDataReader


            'define a string de conexão com o banco de dados
            Dim strConn As String = _
                "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=" & CaminhoBanco & ";" & _
                "Jet OLEDB:Database Locking Mode=1;" & _
                "User ID=Admin;" & _
                "Password=" & Senha & ""


            '' CONTADOR
            Dim sqlCount As String = "SELECT count(*) as qtdObras FROM qryOBRAS"
            Dim objCmd As New OleDbCommand(sqlCount, New OleDbConnection(strConn))

            objCmd.Connection.Open()
            Dim intCount As Integer = CInt(objCmd.ExecuteScalar)
            objCmd.Connection.Close()

            'Dim x As Integer = 1

            Me.prgObras.Maximum = intCount


            'define o objeto OledbConnection usando a string de conexão
            Dim conexao As New OleDbConnection(strConn)

            'define a instrução SQL que será usada para extrair as linhas da tabela Authors
            Dim sql As String = "SELECT * FROM qryOBRAS"

            'cria o objeto OleDbCommand
            Dim comando As New OleDbCommand(sql, conexao)

            conexao.Open()

            Dim reader As OleDbDataReader = comando.ExecuteReader()


            With BancoDados
                .Abrir()
                Me.prgObras.Value = 1

                While reader.Read()
                    .ComandoProcedure = "sp_CAD_CLIENTE_INSERT_OBRA"
                    .CriaProcedure()

                    '' OBRA
                    .AdicionaParametro("p_CNPJ_CPF_CLIENTE", reader("CNPJ_CPF").ToString())
                    .AdicionaParametro("p_ENDERECO", reader("OBRA").ToString())
                    .AdicionaParametro("p_NUMERO", reader("NUMERO").ToString())
                    .AdicionaParametro("p_COMPLEMENTO", reader("COMPLEMENTO").ToString())
                    .AdicionaParametro("p_BAIRRO", reader("BAIRRO").ToString())
                    .AdicionaParametro("p_CEP", reader("CEP").ToString())
                    .AdicionaParametro("p_CIDADE", reader("CIDADE").ToString())
                    .AdicionaParametro("p_ESTADO", reader("ESTADO").ToString())

                    '' COBRANÇA
                    .AdicionaParametro("p_COBRANCA_SACADO", reader("COBRANCA_SACADO").ToString())
                    .AdicionaParametro("p_COBRANCA_INSCRICAO", reader("COBRANCA_INSCRICAO").ToString())
                    .AdicionaParametro("p_COBRANCA_LOGRADOURO", reader("COBRANCA_LOGRADOURO").ToString())
                    .AdicionaParametro("p_COBRANCA_BAIRRO", reader("COBRANCA_BAIRRO").ToString())
                    .AdicionaParametro("p_COBRANCA_CEP", reader("COBRANCA_CEP").ToString())
                    .AdicionaParametro("p_COBRANCA_CIDADE", reader("COBRANCA_CIDADE").ToString())
                    .AdicionaParametro("p_COBRANCA_ESTADO", reader("COBRANCA_ESTADO").ToString())
                    .AdicionaParametro("p_COBRANCA_CONTATO", reader("COBRANCA_CONTATO").ToString())
                    .AdicionaParametro("p_COBRANCA_TELEFONE", reader("COBRANCA_TELEFONE").ToString())
                    .AdicionaParametro("p_COBRANCA_EMAIL", reader("COBRANCA_EMAIL").ToString())

                    '' CONTRATO
                    .AdicionaParametro("p_CONTRATO_INICIO", reader("CONTRATO_INICIO").ToString())
                    .AdicionaParametro("p_CONTRATO_TERMINIO", reader("CONTRATO_TERMINIO").ToString())
                    .AdicionaParametro("p_CONTRATO_VALOR", reader("CONTRATO_VALOR").ToString())
                    .AdicionaParametro("p_CONTRATO_NF", CBool(reader("CONTRATO_NF").ToString))
                    .AdicionaParametro("p_CONTRATO_ISS", CBool(reader("CONTRATO_ISS").ToString()))
                    .AdicionaParametro("p_CONTRATO_CTR", CBool(reader("CONTRATO_CTR").ToString()))
                    .AdicionaParametro("P_CONTRATO_FATURAMENTO_DIAS", reader("CONTRATO_FATURAMENTO_DIAS").ToString())
                    .AdicionaParametro("p_CONTRATO_PERIODO_LOCACAO", reader("CONTRATO_PERIODO_LOCACAO").ToString())
                    .AdicionaParametro("p_CONTRATO_FORMA_PAGAMENTO", reader("CONTRATO_FORMA_PAGAMENTO").ToString())
                    .AdicionaParametro("p_CONTRATO_RETIRADA_AUTOMATICA", reader("CONTRATO_RETIRADA_AUTOMATICA").ToString())
                    .AdicionaParametro("p_CONTRATO_VCTO_APOS_ENTREGA", reader("CONTRATO_VCTO_APOS_ENTREGA").ToString())
                    .AdicionaParametro("p_CONTRATO_MULTA_MORA", reader("CONTRATO_MULTA_MORA").ToString())
                    .AdicionaParametro("p_CONTRATO_MULTA_DIA", reader("CONTRATO_MULTA_DIA").ToString())

                    '' USUÁRIO
                    .AdicionaParametro("p_CADASTRO_USUARIO", "ADM")
                    .ExecutaProcedure()
                    If Not (Me.prgObras.Value = Me.prgObras.Maximum) Then Me.prgObras.Value = Me.prgObras.Value + 1

                End While

                .Fechar()
                reader.Close()
            End With
            MsgBox("OK", MsgBoxStyle.Information)


        End If





        ''Cria o objeto DataAdapter
        'Dim adaptador As New OleDbDataAdapter(comando)

        ''Cria o objeto DataSet
        'Dim dsCadastros As New DataSet()

        ''preenche o dataset
        'adaptador.Fill(dsCadastros, "CadastrosObras")


        ''exibe os dados em um datagrid
        'DataGridView1.DataSource = dsCadastros.Tables("CadastrosObras")


    End Sub

    Private Sub btnCONTATOS_Click(sender As System.Object, e As System.EventArgs) Handles btnCONTATOS.Click
        'Dim CaminhoBanco As String = "C:\Users\user\Desktop\HIGIA\130412-1053\dbITAU_2012_130201-2035.mdb"
        Dim Senha As String = ""

        BancoDados = New ClasseBancoDados(strSERVER)
        Rotinas = New ClasseRotinasDiversas

        Dim RESPOSTA As DialogResult = MessageBox.Show("DESEJA IMPORTAR CONTATOS DE CLIENTES ?", "IMPORTAR CONTATOS DE CLIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If RESPOSTA = Windows.Forms.DialogResult.Yes Then

            'Dim rdrRegistro As MySqlDataReader


            'define a string de conexão com o banco de dados
            Dim strConn As String = _
                "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=" & CaminhoBanco & ";" & _
                "Jet OLEDB:Database Locking Mode=1;" & _
                "User ID=Admin;" & _
                "Password=" & Senha & ""


            '' CONTADOR
            Dim sqlCount As String = "SELECT count(*) as qtdCTT FROM qryCONTATOS"
            Dim objCmd As New OleDbCommand(sqlCount, New OleDbConnection(strConn))

            objCmd.Connection.Open()
            Dim intCount As Integer = CInt(objCmd.ExecuteScalar)
            objCmd.Connection.Close()

            'Dim x As Integer = 1

            Me.prnCONTATOS.Maximum = intCount


            'define o objeto OledbConnection usando a string de conexão
            Dim conexao As New OleDbConnection(strConn)

            'define a instrução SQL que será usada para extrair as linhas da tabela Authors
            Dim sql As String = "SELECT * FROM qryCONTATOS"

            'cria o objeto OleDbCommand
            Dim comando As New OleDbCommand(sql, conexao)

            conexao.Open()

            Dim reader As OleDbDataReader = comando.ExecuteReader()


            With BancoDados
                .Abrir()
                Me.prnCONTATOS.Value = 1

                While reader.Read()
                    .ComandoProcedure = "sp_CAD_CLIENTE_INSERT_CONTATO"
                    .CriaProcedure()

                    '' OBRA
                    .AdicionaParametro("p_CNPJ_CPF_CLIENTE", reader("CNPJ_CPF_CLIENTE").ToString())
                    .AdicionaParametro("p_CONTATO_NOME", reader("CONTATO_NOME").ToString())
                    .AdicionaParametro("p_CONTATO_TELEFONE", reader("CONTATO_TELEFONE").ToString())
                    .AdicionaParametro("p_CONTATO_EMAIL", reader("CONTATO_EMAIL").ToString())
                    .AdicionaParametro("p_CONTATO_SOLICITANTE", reader("CONTATO_SOLICITANTE").ToString())
                    .AdicionaParametro("p_CONTATO_OBSERVACAO", reader("CONTATO_OBSERVACAO").ToString())

                    '' USUÁRIO
                    .AdicionaParametro("p_USUARIO", "ADM")
                    .ExecutaProcedure()
                    If Not (Me.prnCONTATOS.Value = Me.prnCONTATOS.Maximum) Then Me.prnCONTATOS.Value = Me.prnCONTATOS.Value + 1

                End While

                .Fechar()
                reader.Close()
            End With
            MsgBox("OK", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub btnHISTORICO_Click(sender As System.Object, e As System.EventArgs) Handles btnHISTORICO.Click
        'Dim CaminhoBanco As String = "C:\Users\user\Desktop\HIGIA\130412-1053\dbITAU_2012_130201-2035.mdb"
        Dim Senha As String = ""

        Dim RESPOSTA As DialogResult = MessageBox.Show("DESEJA IMPORTAR HISTORICO DE CLIENTES ?", "IMPORTAR HISTORICO DE CLIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If RESPOSTA = Windows.Forms.DialogResult.Yes Then


            BancoDados = New ClasseBancoDados(strSERVER)
            Rotinas = New ClasseRotinasDiversas


            'Dim rdrRegistro As MySqlDataReader


            'define a string de conexão com o banco de dados
            Dim strConn As String = _
                "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=" & CaminhoBanco & ";" & _
                "Jet OLEDB:Database Locking Mode=1;" & _
                "User ID=Admin;" & _
                "Password=" & Senha & ""


            '' CONTADOR
            Dim sqlCount As String = "SELECT count(*) as qtdHST FROM qryHISTORICO"
            Dim objCmd As New OleDbCommand(sqlCount, New OleDbConnection(strConn))

            objCmd.Connection.Open()
            Dim intCount As Integer = CInt(objCmd.ExecuteScalar)
            objCmd.Connection.Close()

            'Dim x As Integer = 1

            Me.prnHISTORICO.Maximum = intCount


            'define o objeto OledbConnection usando a string de conexão
            Dim conexao As New OleDbConnection(strConn)

            'define a instrução SQL que será usada para extrair as linhas da tabela Authors
            Dim sql As String = "SELECT * FROM qryHISTORICO"

            'cria o objeto OleDbCommand
            Dim comando As New OleDbCommand(sql, conexao)

            conexao.Open()

            Dim reader As OleDbDataReader = comando.ExecuteReader()


            With BancoDados
                .Abrir()
                Me.prnHISTORICO.Value = 1

                While reader.Read()
                    .ComandoProcedure = "sp_CAD_CLIENTE_INSERT_HISTORICO"
                    .CriaProcedure()

                    '' OBRA
                    .AdicionaParametro("p_CNPJ_CPF_CLIENTE", reader("CNPJ_CPF_CLIENTE").ToString())
                    .AdicionaParametro("p_HISTORICO", reader("HISTORICO").ToString())
                    .AdicionaParametro("p_DT_ALTERACAO", reader("DT_ALTERACAO").ToString())


                    '' USUÁRIO
                    .AdicionaParametro("p_USUARIO", "ADM")
                    .ExecutaProcedure()
                    If Not (Me.prnHISTORICO.Value = Me.prnHISTORICO.Maximum) Then Me.prnHISTORICO.Value = Me.prnHISTORICO.Value + 1

                End While

                .Fechar()
                reader.Close()
            End With
            MsgBox("OK", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub F_IMP_DADOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            MsgBox(GetConnectionStringByName("dbRETEC_SERVER"))
        Catch erro_Conneccao As Exception
            MsgBox("ATENÇÃO: Não foi possivel fazer a conexão com a base de dados " + erro_Conneccao.ToString, MsgBoxStyle.Critical + vbOKOnly)
        End Try

    End Sub

    Private Shared Function GetConnectionStringByName(ByVal name As String) As String
        ' Retrieves a connection string by name.
        ' Returns Nothing if the name is not found.

        ' Assume failure
        Dim returnValue As String = Nothing

        ' Look for the name in the connectionStrings section.
        Dim settings As ConnectionStringSettings = _
           ConfigurationManager.ConnectionStrings(Name)

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            returnValue = settings.ConnectionString
        End If

        Return returnValue
    End Function

    Private Sub btnSOLICITACOES_Click(sender As System.Object, e As System.EventArgs) Handles btnSOLICITACOES.Click

        '' <<< FAZER >>>

        'Dim CaminhoBanco As String = "C:\Users\user\Desktop\HIGIA\130412-1053\dbITAU_2012_130201-2035.mdb"
        Dim Senha As String = ""

        Dim RESPOSTA As DialogResult = MessageBox.Show("DESEJA IMPORTAR SOLICITAÇÕES ?", "IMPORTAR SOLICITAÇÕES", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If RESPOSTA = Windows.Forms.DialogResult.Yes Then


            BancoDados = New ClasseBancoDados(strSERVER)
            Rotinas = New ClasseRotinasDiversas


            'Dim rdrRegistro As MySqlDataReader


            'define a string de conexão com o banco de dados
            Dim strConn As String = _
                "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=" & CaminhoBanco & ";" & _
                "Jet OLEDB:Database Locking Mode=1;" & _
                "User ID=Admin;" & _
                "Password=" & Senha & ""


            '' CONTADOR
            Dim sqlCount As String = "SELECT count(*) as qtdLGC FROM qryLIGACOES"
            Dim objCmd As New OleDbCommand(sqlCount, New OleDbConnection(strConn))

            objCmd.Connection.Open()
            Dim intCount As Integer = CInt(objCmd.ExecuteScalar)
            objCmd.Connection.Close()

            'Dim x As Integer = 1

            Me.prnHISTORICO.Maximum = intCount


            'define o objeto OledbConnection usando a string de conexão
            Dim conexao As New OleDbConnection(strConn)

            'define a instrução SQL que será usada para extrair as linhas da tabela Authors
            Dim sql As String = "SELECT * FROM qryLIGACOES"

            'cria o objeto OleDbCommand
            Dim comando As New OleDbCommand(sql, conexao)

            conexao.Open()

            Dim reader As OleDbDataReader = comando.ExecuteReader()


            With BancoDados
                .Abrir()
                Me.prnHISTORICO.Value = 1

                While reader.Read()
                    .ComandoProcedure = "sp_SRV_LIGACAO_INSERT"
                    .CriaProcedure()

                    '' OBRA
                    .AdicionaParametro("p_CNPJ_CPF_CLIENTE", reader("CNPJ_CPF_CLIENTE").ToString())
                    .AdicionaParametro("p_HISTORICO", reader("HISTORICO").ToString())
                    .AdicionaParametro("p_DT_ALTERACAO", reader("DT_ALTERACAO").ToString())


                    '' USUÁRIO
                    .AdicionaParametro("p_USUARIO", "ADM")
                    .ExecutaProcedure()
                    If Not (Me.prnHISTORICO.Value = Me.prnHISTORICO.Maximum) Then Me.prnHISTORICO.Value = Me.prnHISTORICO.Value + 1

                End While

                .Fechar()
                reader.Close()
            End With
            MsgBox("OK", MsgBoxStyle.Information)

        End If
    End Sub
End Class
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration

Public Class pesquisaAgenda

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub pesquisaAgenda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas

        '' TIPO DE PARAMETROS
        CARREGAR_COMBO("Select * from vw_adm_parametros_ligacoes", "vw_adm_parametros_ligacoes", Rotinas.GetConnectionStringByName("servidor"), cboCampos, "Descricao", "Parametro")

        CARREGAR_DADOS("", mcCalendario.SelectionStart)

        UpdateLabelText()

    End Sub

    Private Sub CARREGAR_DADOS(ByVal strProcurar As String, ByVal strParametro As String)
        Dim con As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strSQL As String


        If strProcurar = "" Then
            strSQL = "SELECT * from vw_dgv_serv_ligacoes where  (SERVICO_EMISSAO = '" & Trim(strParametro) & "')"
        Else
            strSQL = "SELECT * from vw_dgv_serv_ligacoes where  (" & strParametro & " LIKE '%" & Trim(strProcurar) & "%')"
        End If

        Try
            con.Open()
            Dim cmd As New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            With dgvAgenda
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataSource = Nothing
                .DataSource = dt
                .Columns(0).Visible = False
                '.Columns(1).Visible = False
                .ReadOnly = True
                .Refresh()
            End With

            UpdateLabelText()

        Catch ex As Exception
            con.Close()
        End Try

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles mcCalendario.DateChanged
        CARREGAR_DADOS("", mcCalendario.SelectionStart)
        Me.txtProcurar.Text = ""
    End Sub

    'Private Sub cmdProcurar_Click(sender As System.Object, e As System.EventArgs) Handles cmdProcurar.Click
    '    CARREGAR_DADOS(Me.txtProcurar.Text)
    'End Sub

    Private Sub UpdateLabelText()
        Dim ColocaTotal As Integer = 0
        Dim TrocaTotal As Integer = 0
        Dim RetiraTotal As Integer = 0
        Dim counter As Integer

        ' Iterate through all the rows and sum up the appropriate columns.
        For counter = 0 To (dgvAgenda.Rows.Count - 1)
            If Not dgvAgenda.Rows(counter) _
                .Cells("PEDIDO_COLOCA").Value Is Nothing Then

                If Not dgvAgenda.Rows(counter) _
                    .Cells("PEDIDO_COLOCA").Value.ToString().Length = 0 Then

                    ColocaTotal += _
                        Integer.Parse(dgvAgenda.Rows(counter) _
                        .Cells("PEDIDO_COLOCA").Value.ToString())
                End If
            End If

            If Not dgvAgenda.Rows(counter) _
                .Cells("PEDIDO_TROCA").Value Is Nothing Then

                If Not dgvAgenda.Rows(counter) _
                    .Cells("PEDIDO_TROCA").Value.ToString().Length = 0 Then

                    TrocaTotal += _
                        Integer.Parse(dgvAgenda.Rows(counter) _
                        .Cells("PEDIDO_TROCA").Value.ToString())
                End If
            End If

            If Not dgvAgenda.Rows(counter) _
                .Cells("PEDIDO_RETIRA").Value Is Nothing Then

                If Not dgvAgenda.Rows(counter) _
                    .Cells("PEDIDO_RETIRA").Value.ToString().Length = 0 Then

                    RetiraTotal += _
                        Integer.Parse(dgvAgenda.Rows(counter) _
                        .Cells("PEDIDO_RETIRA").Value.ToString())
                End If
            End If

        Next

        '' Iterate through the SelectedCells collection and sum up the values.
        'For counter = 0 To (dgvAgenda.SelectedCells.Count - 1)
        '    If dgvAgenda.SelectedCells(counter).FormattedValueType Is _
        '    Type.GetType("System.String") Then

        '        Dim value As String = Nothing

        '        ' If the cell contains a value that has not been commited,
        '        ' use the modified value.
        '        If (dgvAgenda.IsCurrentCellDirty = True) Then

        '            value = dgvAgenda.SelectedCells(counter) _
        '                .EditedFormattedValue.ToString()
        '        Else

        '            value = dgvAgenda.SelectedCells(counter) _
        '                .FormattedValue.ToString()
        '        End If

        '        If value IsNot Nothing Then

        '            ' Ignore cells in the Description column.
        '            If Not dgvAgenda.SelectedCells(counter).ColumnIndex = _
        '                dgvAgenda.Columns("Description").Index Then

        '                If Not value.Length = 0 Then
        '                    SelectedCellTotal += Integer.Parse(value)
        '                End If
        '            End If
        '        End If
        '    End If

        'Next

        ' Set the labels to reflect the current state of the DataGridView.
        Label1.Text = "Total - Coloca   : " & ColocaTotal.ToString()
        Label2.Text = "Total - Troca    : " & TrocaTotal.ToString()
        Label3.Text = "Total - Retira   : " & RetiraTotal.ToString()
        Label4.Text = "Total - Ligações : " & dgvAgenda.RowCount.ToString()
    End Sub

    Private Sub CARREGAR_COMBO(ByVal myQuery As String, ByVal strTable As String, ByVal strConnection As String, ByVal cbo As ComboBox, ByVal strDisplayMember As String, ByVal strValueMember As String)
        Dim myConnection As New MySqlConnection(strConnection)
        myConnection.Open()

        Dim cmdSQL As New MySqlCommand(myQuery, myConnection)
        Dim adapter As New MySqlDataAdapter(cmdSQL)

        'define o dataset
        Dim ds As New DataSet
        Try
            adapter.Fill(ds, strTable) 'preenche o dataset
        Catch ex As Exception
            MessageBox.Show("Erro ao acessar os dados.")
            Exit Sub
        End Try

        With cbo
            'atribui o datasource a coluna combobox do datagridivew
            .DataSource = ds.Tables(strTable)
            'atribui o valor que será exibido na coluna 
            .DisplayMember = strDisplayMember
            'atribui o valor que será lido quando um item for selecionado
            .ValueMember = strValueMember
        End With

    End Sub

    Private Sub cmdFiltrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFiltrar.Click

        If Me.txtProcurar.Text <> "" Then
            CARREGAR_DADOS(Me.txtProcurar.Text, cboCampos.SelectedValue.ToString)
        Else
            CARREGAR_DADOS("", mcCalendario.SelectionStart)
        End If

    End Sub


    Private Sub dgvAgenda_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAgenda.CellContentDoubleClick
        'If e.RowIndex <> -1 Then
        '    Dim idLigacao As Object = dgvAgenda.Rows(e.RowIndex).Cells(0).Value

        '    If IsDBNull(idLigacao) Then
        '        MsgBox("")
        '    Else
        '        'F_CAD_CLIENTE.txtID_CLIENTE.Text = (CType(idCliente, String))
        '        'F_CAD_CLIENTE.ShowDialog()

        '        SELECIONAR_LIGACAO(idLigacao)

        '    End If
        'End If
    End Sub

    Private Sub SELECIONAR_LIGACAO(ByVal idLigacao As String)

        Dim frm As New cadastroLigacao

        With frm
            .MdiParent = FPrincipal
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .txtID_LIGACAO.Text = idLigacao
            .Show()
        End With


    End Sub

    Private Sub dgvAgenda_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAgenda.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim idLigacao As Object = dgvAgenda.Rows(e.RowIndex).Cells(0).Value

            If IsDBNull(idLigacao) Then
                MsgBox("")
            Else
                'F_CAD_CLIENTE.txtID_CLIENTE.Text = (CType(idCliente, String))
                'F_CAD_CLIENTE.ShowDialog()

                SELECIONAR_LIGACAO(idLigacao)

            End If
        End If
    End Sub
End Class
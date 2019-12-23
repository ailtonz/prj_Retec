Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration

Public Class pesquisaClientes

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub F_PSQ_CLIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Rotinas = New ClasseRotinasDiversas

        CARREGAR_DADOS("")
    End Sub

    Private Sub CARREGAR_DADOS(ByVal strProcurar As String)
        Dim con As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strSQL As String


        If strProcurar = "" Then
            strSQL = "SELECT * from vw_dgv_clientes"
        Else
            strSQL = "SELECT * from vw_dgv_clientes where  (CLIENTE LIKE '%" & Trim(strProcurar) & "%')"
        End If


        Try
            con.Open()
            Dim cmd As New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            With dgvClientes
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .DataSource = Nothing
                .DataSource = dt
                .Columns(0).Visible = False
                .ReadOnly = True
            End With


        Catch ex As Exception
            con.Close()
        End Try

    End Sub

    Private Sub cmdNovo_Click(sender As System.Object, e As System.EventArgs) Handles cmdNovo.Click

        SELECIONAR_CLIENTE(0)

    End Sub

    Private Sub cmdProcurar_Click(sender As System.Object, e As System.EventArgs) Handles cmdProcurar.Click
        CARREGAR_DADOS(Me.txtProcurar.Text)
    End Sub

    Private Sub dgvDados_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim idCliente As Object = dgvClientes.Rows(e.RowIndex).Cells(0).Value

            If IsDBNull(idCliente) Then
                MsgBox("")
            Else
                'F_CAD_CLIENTE.txtID_CLIENTE.Text = (CType(idCliente, String))
                'F_CAD_CLIENTE.ShowDialog()

                SELECIONAR_CLIENTE(idCliente)

            End If
        End If

    End Sub

    Private Sub SELECIONAR_CLIENTE(ByVal idCliente As String)

        Dim frm As New cadastroCliente

        With frm
            .MdiParent = FPrincipal
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .txtID_CLIENTE.Text = idCliente
            .Show()
        End With


    End Sub

    Private Sub F_PSQ_CLIENTES_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub F_PSQ_CLIENTES_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        CARREGAR_DADOS(Me.txtProcurar.Text)
    End Sub

    Private Sub dgvDados_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvClientes.KeyDown

        Select Case e.KeyCode
            Case Keys.Insert
                SELECIONAR_CLIENTE(0)
            Case Keys.F2
                Me.txtProcurar.Focus()
        End Select

    End Sub

End Class
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration

Public Class pesquisaObras

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub F_PSQ_CLIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Rotinas = New ClasseRotinasDiversas

        CARREGAR_DADOS("")
    End Sub

    Private Sub CARREGAR_DADOS(ByVal strProcurar As String)
        Dim con As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strSQL As String


        If strProcurar = "" Then
            strSQL = "SELECT * from vw_dgv_obras"
        Else
            strSQL = "SELECT * from vw_dgv_obras where  (OBRA LIKE '%" & Trim(strProcurar) & "%')"
        End If


        Try
            con.Open()
            Dim cmd As New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            With dgvDados
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .DataSource = Nothing
                .DataSource = dt
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .ReadOnly = True
            End With


        Catch ex As Exception
            con.Close()
        End Try

    End Sub

    Private Sub cmdProcurar_Click(sender As System.Object, e As System.EventArgs) Handles cmdProcurar.Click
        CARREGAR_DADOS(Me.txtProcurar.Text)
    End Sub

    Private Sub dgvDados_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim idObra As Object = dgvDados.Rows(e.RowIndex).Cells(0).Value
            Dim idCliente As Object = dgvDados.Rows(e.RowIndex).Cells(1).Value
            Dim strStatus As Object = dgvDados.Rows(e.RowIndex).Cells(7).Value

            If IsDBNull(idCliente) Then
                MsgBox("")
            Else
                'F_CAD_CLIENTE.txtID_CLIENTE.Text = (CType(idCliente, String))
                'F_CAD_CLIENTE.ShowDialog()

                SELECIONAR_OBRA(idObra, idCliente, strStatus)

            End If
        End If

    End Sub

    Private Sub SELECIONAR_OBRA(ByVal idObra As String, ByVal idCliente As String, ByVal strStatus As String)

        Dim frm As New cadastroLigacao

        With frm
            .MdiParent = FPrincipal
            '.ControlBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .txtID_CLIENTE.Text = idCliente
            .txtID_OBRA.Text = idObra
            .txtStatus.Text = strStatus
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

    Private Sub dgvDados_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvDados.KeyDown

        Select Case e.KeyCode
            'Case Keys.Insert
            '    SELECIONAR_OBRA(0)
            Case Keys.F2
                Me.txtProcurar.Focus()
        End Select

    End Sub

End Class
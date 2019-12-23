Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration

Public Class F_PSQ_CLIENTES

    Private Sub F_PSQ_CLIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        dgvDados.AllowUserToAddRows = False
        dgvDados.AllowUserToDeleteRows = False

        carregarDados("")
    End Sub

    Private Sub carregarDados(ByVal strProcurar As String)
        Dim con As New MySqlConnection(GetConnectionStringByName("servidor"))
        Dim strSQL As String


        If strProcurar = "" Then
            strSQL = "SELECT * from vw_pesquisa_clientes"
        Else
            strSQL = "SELECT * from vw_pesquisa_clientes where  (CLIENTE LIKE '%" & Trim(strProcurar) & "%')"
        End If


        Try
            con.Open()
            Dim cmd As New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            With dgvDados
                .DataSource = Nothing
                .DataSource = dt
                .Columns(0).Visible = False
                .ReadOnly = True
            End With


        Catch ex As Exception
            con.Close()
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

    Private Sub cmdNovo_Click(sender As System.Object, e As System.EventArgs) Handles cmdNovo.Click
        'Dim frmCliente As New F_CAD_CLIENTE

        'With frmCliente
        '    '.MdiParent = Me
        '    '.ControlBox = False
        '    .StartPosition = FormStartPosition.CenterScreen
        '    .Show()
        'End With

        'F_CAD_CLIENTE.ShowDialog()

        MOSTRAR_CLIENTE(0)


    End Sub

    Private Sub cmdProcurar_Click(sender As System.Object, e As System.EventArgs) Handles cmdProcurar.Click
        carregarDados(Me.txtProcurar.Text)
    End Sub

    Private Sub dgvDados_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDados.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim idCliente As Object = dgvDados.Rows(e.RowIndex).Cells(0).Value

            If IsDBNull(idCliente) Then
                MsgBox("")
            Else
                'F_CAD_CLIENTE.txtID_CLIENTE.Text = (CType(idCliente, String))
                'F_CAD_CLIENTE.ShowDialog()

                MOSTRAR_CLIENTE(idCliente)

            End If
        End If

    End Sub

    Private Sub MOSTRAR_CLIENTE(ByVal idCliente As String)

        Dim frm As New F_CAD_CLIENTE

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
    End Sub
End Class
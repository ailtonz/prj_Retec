Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration



Public Class pesquisaAgenda

    Protected Rotinas As ClasseRotinasDiversas

    Private Sub pesquisaAgenda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas

        CARREGAR_DADOS("")

    End Sub

    Private Sub CARREGAR_DADOS(ByVal strProcurar As String)
        Dim con As New MySqlConnection(Rotinas.GetConnectionStringByName("servidor"))
        Dim strSQL As String


        If strProcurar = "" Then
            strSQL = "SELECT * from vw_dgv_agenda"
        Else
            strSQL = "SELECT * from vw_dgv_agenda where  (EMISSAO LIKE '%" & Trim(strProcurar) & "%')"
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
                .Columns(1).Visible = False
                .ReadOnly = True
            End With


        Catch ex As Exception
            con.Close()
        End Try

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles mcCalendario.DateChanged
        CARREGAR_DADOS(mcCalendario.SelectionStart)
    End Sub

    Private Sub cmdProcurar_Click(sender As System.Object, e As System.EventArgs) Handles cmdProcurar.Click
        CARREGAR_DADOS(Me.txtProcurar.Text)
    End Sub

End Class
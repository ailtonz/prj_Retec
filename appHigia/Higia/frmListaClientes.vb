Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System
Imports System.Configuration


Public Class frmListaClientes

    Private Sub frmListaClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregarClientes()
    End Sub

    Private Sub carregarClientes()
        Dim con As New MySqlConnection(GetConnectionStringByName("servidor"))

        Try
            con.Open()
            Dim cmd As New MySqlCommand("Select * from vw_cad_clientes limit 100", con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvClientes.DataSource = dt

            cboCampo.DataSource = dt
            cboCampo.DisplayMember = "cadastro_observacao"


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

End Class
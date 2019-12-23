   Private Sub CARREGAR_GRIDE_OBRAS(ByVal idCliente As String)
        Dim con As New MySqlConnection(GetConnectionStringByName("servidor"))
        Dim strSQL As String

        strSQL = "Select * from vw_cad_clientes_obras where ID_CLIENTE = '" + idCliente + "' "

        Try
            con.Open()
            Dim cmd As New MySqlCommand(strSQL, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable

            da.Fill(dt)

            With dgvOBRAS
                .DataSource = dt
                .Columns(0).Visible = False
                .ReadOnly = True
            End With


        Catch ex As Exception
            con.Close()
        End Try

    End Sub
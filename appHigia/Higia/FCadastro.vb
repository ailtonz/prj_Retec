Imports System
Imports System.Configuration


Public Class FCadastro
    Protected Rotinas As ClasseRotinasDiversas
    Protected BancoDados As ClasseBancoDados

    Protected Sub Mensagem(ByVal strTexto As String)
        lblMensagem.Text = strTexto
    End Sub

    Private Sub btnSAIR_Click(sender As System.Object, e As System.EventArgs) Handles btnSAIR.Click
        Me.Close()
    End Sub

    Private Sub FCadastro_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
        '    e.KeyChar = Microsoft.VisualBasic.Chr(0)
        '    System.Windows.Forms.SendKeys.Send("{TAB}")
        '    MsgBox("OK")
        'End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

    End Sub

    Private Sub FCadastro_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        BancoDados.Fechar()
        BancoDados = Nothing
        Rotinas = Nothing
    End Sub

    Private Sub btnADICIONAR_Click(sender As System.Object, e As System.EventArgs) Handles btnADICIONAR.Click
        BancoDados.Operacao = "ADICIONAR"
        Mensagem("Adição de registro...")
        Rotinas.LimparCampos(Me)
    End Sub

    Private Sub btnEDITAR_Click(sender As System.Object, e As System.EventArgs) Handles btnEDITAR.Click
        BancoDados.Operacao = "EDITAR"
        Mensagem("Edição de registro...")

    End Sub

    Private Sub FCadastro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim strSERVER As String : strSERVER = GetConnectionStringByName("SERVER")

        BancoDados = New ClasseBancoDados(GetConnectionStringByName("SERVER"))
        Rotinas = New ClasseRotinasDiversas

        BancoDados.Abrir()
        Rotinas.LimparCampos(Me)
        Mensagem("")

    End Sub


    ' Retrieves a connection string by name.
    ' Returns Nothing if the name is not found.
    Private Shared Function GetConnectionStringByName(ByVal name As String) As String

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
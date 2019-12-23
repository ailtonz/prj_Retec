Public Class FPesquisa
    Property strValorRetorno As String
    Protected Rotinas As ClasseRotinasDiversas


    Private Sub FPesquisa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Rotinas = New ClasseRotinasDiversas
        strValorRetorno = ""
        Me.txtInformacao.Text = ""
        Me.txtInformacao.Focus()
    End Sub

    Private Sub FPesquisa_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Rotinas = Nothing
    End Sub

    Private Sub txtInformacao_Enter(sender As System.Object, e As System.EventArgs) Handles txtInformacao.Enter
        Rotinas.CorEntrada(sender)
    End Sub

    Private Sub txtInformacao_Leave(sender As System.Object, e As System.EventArgs) Handles txtInformacao.Leave
        Rotinas.CorSaida(sender)
    End Sub


End Class
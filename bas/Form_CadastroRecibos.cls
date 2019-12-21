VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Form_CadastroRecibos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Database
Option Explicit

Private Sub Cliente_Click()
    Me.NM_SACADO = Me.Cliente.Column(1)
    Me.lstBoletos.Requery
End Sub

Private Sub cmdFechar_Click()
On Error GoTo Err_cmdFechar_Click

    DoCmd.DoMenuItem acFormBar, acEditMenu, acUndo, , acMenuVer70
    DoCmd.CancelEvent
    DoCmd.Close

Exit_cmdFechar_Click:
    Exit Sub

Err_cmdFechar_Click:
    If Not (err.Number = 2046 Or err.Number = 0) Then MsgBox err.Description
    DoCmd.Close
    Resume Exit_cmdFechar_Click
End Sub

Private Sub cmdImportar_Click()
Dim intCurrentRow As Integer

For intCurrentRow = 0 To Me.lstBoletos.ListCount - 1
    DoEvents

    If Me.lstBoletos.Selected(intCurrentRow) Then
        If Not IsNull(Me.lstBoletos.Column(0, intCurrentRow)) Then
            ImportarBoletosParaRecibos Me.lstBoletos.Column(0, intCurrentRow), Me.codRecibo.value
            Me.lstBoletos.Selected(intCurrentRow) = False
        End If
    End If

Next intCurrentRow

Me.subCadastroRecibosItens.Requery

End Sub

Private Sub cmdPROCESSO_Click()
    ReciboProcesso Me.codRecibo
    Me.lstBoletos.Requery
End Sub

Private Sub cmdSalvar_Click()
On Error GoTo Err_cmdSalvar_Click

    DoCmd.DoMenuItem acFormBar, acRecordsMenu, acSaveRecord, , acMenuVer70
    Form_Pesquisar.lstCadastro.Requery
    DoCmd.Close
    
Exit_cmdSalvar_Click:
    Exit Sub

Err_cmdSalvar_Click:
    If Not (err.Number = 2046 Or err.Number = 0) Then MsgBox err.Description
    DoCmd.Close
    Resume Exit_cmdSalvar_Click

End Sub

Private Sub cmdTodos_Click()
Dim intCurrentRow As Integer
            
For intCurrentRow = 0 To Me.lstBoletos.ListCount - 1
    If Not IsNull(Me.lstBoletos.Column(0, intCurrentRow)) Then
        Me.lstBoletos.Selected(intCurrentRow) = True
    End If
Next intCurrentRow

End Sub

Private Sub cmdNenhum_Click()
Dim intCurrentRow As Integer
            
For intCurrentRow = 0 To Me.lstBoletos.ListCount - 1
    If Not IsNull(Me.lstBoletos.Column(0, intCurrentRow)) Then
        Me.lstBoletos.Selected(intCurrentRow) = False
    End If
Next intCurrentRow

End Sub

Private Sub cmdRecebido_Click()
    ReciboPago Me.codRecibo
    Me.lstBoletos.Requery
End Sub

Private Sub cmdVoltarStatusOriginal_Click()
    VoltarStatusOriginal Me.codRecibo
    Me.lstBoletos.Requery
End Sub

Private Sub Form_BeforeInsert(Cancel As Integer)
'Dim strSql As String: strSql = "SELECT IIf(IsNull(Max(codRecibo)),1,Max(codRecibo)+1) AS strControle FROM Recibos;"
'Dim rstControle As DAO.Recordset
'
'Set rstControle = CurrentDb.OpenRecordset(strSql)
'
'If Me.codRecibo = 0 Then Me.codRecibo.value = rstControle.Fields("strControle").value
'
'rstControle.Close
'Set rstControle = Nothing

Me.DataDeEmissao.value = Format(Now, "dd/mm/yy")

End Sub

Private Sub Form_Current()
    Me.lstBoletos.Requery
End Sub
Private Sub cmdImprimir_Click()
On Error GoTo Err_cmdImprimir_Click

    Dim stDocName As String

    stDocName = "Recibos"
    DoCmd.DoMenuItem acFormBar, acRecordsMenu, acSaveRecord, , acMenuVer70
    DoCmd.OpenReport stDocName, acPreview, , "codRecibo = " & Me.codRecibo

Exit_cmdImprimir_Click:
    Exit Sub

Err_cmdImprimir_Click:
    MsgBox err.Description
    Resume Exit_cmdImprimir_Click
    
End Sub

Private Function ImportarBoletosParaRecibos(NM_ControleDoParticipante As String, NM_RECIBO As String)
Dim qdfImportarBoletosParaRecibos As DAO.QueryDef

    Set qdfImportarBoletosParaRecibos = CurrentDb.QueryDefs("qryImportarBoletosParaRecibos")
    
    With qdfImportarBoletosParaRecibos
        .Parameters("NM_ControleDoParticipante") = NM_ControleDoParticipante
        .Parameters("NM_RECIBO") = NM_RECIBO
        .Execute
    End With
    
    qdfImportarBoletosParaRecibos.Close
End Function

Private Function VoltarStatusOriginal(NM_RECIBO As String)
Dim qdfVoltarStatusOriginal As DAO.QueryDef

    Set qdfVoltarStatusOriginal = CurrentDb.QueryDefs("qryBoletosReciboVoltarStatus")
    
    With qdfVoltarStatusOriginal
        .Parameters("NM_RECIBO") = NM_RECIBO
        .Execute
    End With
    
    qdfVoltarStatusOriginal.Close
End Function

Private Function ReciboPago(NM_RECIBO As String)
Dim qdfReciboPago As DAO.QueryDef

    Set qdfReciboPago = CurrentDb.QueryDefs("qryBoletosReciboAtualizarStatus")
    
    With qdfReciboPago
        .Parameters("NM_RECIBO") = NM_RECIBO
        .Parameters("NM_STATUS") = "PAGO"
        .Execute
    End With
    
    qdfReciboPago.Close
End Function


Private Function ReciboProcesso(NM_RECIBO As String)
Dim qdfReciboPago As DAO.QueryDef

    Set qdfReciboPago = CurrentDb.QueryDefs("qryBoletosReciboAtualizarStatus")
    
    With qdfReciboPago
        .Parameters("NM_RECIBO") = NM_RECIBO
        .Parameters("NM_STATUS") = "PROCESSO"
        .Execute
    End With
    
    qdfReciboPago.Close
End Function


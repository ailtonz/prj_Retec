VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Form_CadastroFuncionarios"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Database
Option Explicit

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

Private Sub Cliente_Exit(Cancel As Integer)
    Me.Cliente = UCase(Me.Cliente)
End Sub

Private Sub Contato_Exit(Cancel As Integer)
    Me.Contato = UCase(Me.Contato)
End Sub

Private Sub Email_Exit(Cancel As Integer)
    Me.Email = LCase(Me.Email)
End Sub

Private Sub Endereco_Exit(Cancel As Integer)
    Me.Endereco = UCase(Me.Endereco)
End Sub

Private Sub Bairro_Exit(Cancel As Integer)
    Me.Bairro = UCase(Me.Bairro)
End Sub

Private Sub Form_BeforeInsert(Cancel As Integer)
'Dim strSql As String: strSql = "SELECT IIf(IsNull(Max(codCadastro)),1,Max(codCadastro)+1) AS strControle FROM Cadastros;"
'Dim rstControle As DAO.Recordset
'
'Set rstControle = CurrentDb.OpenRecordset(strSql)
'
'If Me.Codigo = 0 Then Me.Codigo.value = rstControle.Fields("strControle").value
'
'rstControle.Close
'Set rstControle = Nothing
End Sub

Private Sub Form_Load()
    
DoCmd.Maximize

End Sub

Private Sub Municipio_Exit(Cancel As Integer)
    Me.Municipio = UCase(Me.Municipio)
End Sub

Private Sub Estado_Exit(Cancel As Integer)
    Me.Estado = UCase(Me.Estado)
End Sub

Private Sub OBS_Exit(Cancel As Integer)
    Me.OBS = UCase(Me.OBS)
End Sub



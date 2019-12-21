VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Form_Ligacoes_old"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Database
Option Explicit

Private Sub Cliente_Click()
    Me.codCadastro = Me.Cliente.Column(1)
    Me.txtATENCAO = Me.Cliente.Column(2)
    Me.NumeroInscricaoDoSacado = Me.Cliente.Column(3)
    Me.lstBoletos.Requery
    
End Sub

Private Sub Cliente_Enter()
Dim strObras As String: strObras = "SELECT Obra, codObra, codCadastro, Razao, CTR FROM CadastrosObras WHERE (((CadastrosObras.codCadastro)=forms.Ligacoes.codcadastro))"
    Me.Cliente.Requery
    Me.Obra.RowSource = strObras
    Me.Obra.Requery
End Sub

Private Sub Form_BeforeInsert(Cancel As Integer)
'Dim strSql As String: strSql = "SELECT IIf(IsNull(Max(codLigacao)),1,Max(codLigacao)+1) AS strControle FROM Ligacoes;"
'Dim rstControle As DAO.Recordset
'
'Set rstControle = CurrentDb.OpenRecordset(strSql)
'
'If Me.codLigacao = 0 Then
'    Me.codLigacao.value = rstControle.Fields("strControle").value
'    DoCmd.DoMenuItem acFormBar, acRecordsMenu, acSaveRecord, , acMenuVer70
'End If
'
'rstControle.Close
'Set rstControle = Nothing
End Sub

Private Sub Obra_Enter()
Dim strObras As String: strObras = "SELECT Obra, codObra, codCadastro, Razao, CTR FROM CadastrosObras"

    If IsNull(Me.Cliente.value) Then
        Me.Obra.RowSource = strObras
        Me.Obra.Requery
    End If

End Sub

Private Sub Cliente_Exit(Cancel As Integer)
    Me.Obra.Requery
    Me.Contato.Requery
End Sub

Private Sub Cliente_NotInList(NewData As String, Response As Integer)
'Permite adicionar a editora à lista
Dim DB As DAO.Database
Dim rst As DAO.Recordset

On Error GoTo ErrHandler

'Pergunta se deseja acrescentar o novo item
If Confirmar("O Cliente: " & NewData & "  não faz parte da lista." & vbCrLf & "Deseja acrescentá-lo?") = True Then
    Set DB = CurrentDb()
    'Abre a tabela, adiciona o novo item e atualiza a combo
    Set rst = DB.OpenRecordset("Cadastros")
    With rst
        .AddNew
        '!codCadastro = NovoCodigo("cadGeral", "codCadastro")
        !Nome = UCase(NewData)
        !TipoCadastro = "CLIENTE"
        .Update
        Response = acDataErrAdded
        .Close
    End With
        
    DoCmd.OpenForm "CadastroCliente", , , "Nome = '" & NewData & "'"
    
Else
    Response = acDataErrDisplay
End If

ExitHere:
Set rst = Nothing
Set DB = Nothing
Exit Sub

ErrHandler:
MsgBox err.Description & vbCrLf & err.Number & _
vbCrLf & err.Source, , "EditoraID_fk_NotInList"
Resume ExitHere

End Sub

Private Sub Contato_Exit(Cancel As Integer)
    Me.Contato = UCase(Me.Contato)
End Sub

Private Sub Form_Load()
    DoCmd.Maximize
    Me.txtATENCAO = Me.Cliente.Column(2)
    Me.NumeroInscricaoDoSacado = Me.Cliente.Column(3)
    Me.lstBoletos.Requery
End Sub

Private Sub Obra_Click()
    Me.codObra = Me.Obra.Column(1)
        
    If IsNull(Me.Cliente.value) Then
        Me.codCadastro = Me.Obra.Column(2)
        Me.Cliente = Me.Obra.Column(3)
        Me.CTR = Me.Obra.Column(4)
    End If
End Sub



Private Sub OBS_Exit(Cancel As Integer)
    Me.OBS = UCase(Me.OBS)
End Sub

Private Sub cmdSalvar_Click()
On Error GoTo Err_cmdSalvar_Click
    
    If IsNull(Me.Propaganda) Or IsNull(Me.Usuarios) Then
        
        MsgBox "Favor preencher os campos de Propaganda e Atendente!", vbExclamation + vbOKOnly, "Campos Obrigatórios"
        Me.Propaganda.SetFocus
        
    Else
    
        Me.DATA = Form_Calendario.Cal.value
        DoCmd.DoMenuItem acFormBar, acRecordsMenu, acSaveRecord, , acMenuVer70
        Form_Calendario.lstLigacoes.Requery
        
        DoCmd.Close

    End If
    
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

Private Sub cmdNovoCliente_Click()
On Error GoTo Err_cmdNovoCliente_Click

    Dim stDocName As String
    Dim stLinkCriteria As String

    stDocName = "CadastroCliente"
    DoCmd.OpenForm stDocName, , , stLinkCriteria, acFormAdd

Exit_cmdNovoCliente_Click:
    Exit Sub

Err_cmdNovoCliente_Click:
    MsgBox err.Description
    Resume Exit_cmdNovoCliente_Click
    
End Sub
Private Sub C_Exit(Cancel As Integer)
    If Me.C <> 0 Then Me.DT_C = CalcularVencimento(Day(Now) + 1, Month(Now), Year(Now))
End Sub

Private Sub R_Exit(Cancel As Integer)
    If Me.R <> 0 Then Me.DT_R = CalcularVencimento(Day(Now) + 1, Month(Now), Year(Now))
End Sub

Private Sub T_Exit(Cancel As Integer)
    If Me.T <> 0 Then Me.DT_T = CalcularVencimento(Day(Now) + 1, Month(Now), Year(Now))
End Sub

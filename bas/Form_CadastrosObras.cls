VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Form_CadastrosObras"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Database

Private Sub Contato_Click()
    Me.Telefone = Me.Contato.Column(1)
    Me.Email = Me.Contato.Column(2)
End Sub

Private Sub Contato_Exit(Cancel As Integer)
    If Me.Contato <> "" Then Me.Contato = UCase(Me.Contato)
End Sub

Private Sub Email_Exit(Cancel As Integer)
    If Me.Email <> "" Then Me.Email = LCase(Me.Email)
End Sub

Private Sub Form_BeforeInsert(Cancel As Integer)
'Dim strSql As String: strSql = "SELECT IIf(IsNull(Max(codObra)),1,Max(codObra)+1) AS strControle FROM CadastrosObras;"
'Dim rstControle As DAO.Recordset
'
'Set rstControle = CurrentDb.OpenRecordset(strSql)
'
'If Me.codObra = 0 Then Me.codObra.value = rstControle.Fields("strControle").value
'
'rstControle.Close
'Set rstControle = Nothing

End Sub

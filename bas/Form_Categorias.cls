VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Form_Categorias"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Database

Private Sub Form_AfterInsert()
    Me.Categoria = Replace(Me.Titulo, " ", "")
End Sub

Private Sub Form_BeforeInsert(Cancel As Integer)
    Me.Principal = True
End Sub
Private Sub cmdFechar_Click()
On Error GoTo Err_cmdFechar_Click


    DoCmd.Close

Exit_cmdFechar_Click:
    Exit Sub

Err_cmdFechar_Click:
    MsgBox err.Description
    Resume Exit_cmdFechar_Click
    
End Sub

Private Sub Form_Load()
    DoCmd.Maximize
End Sub

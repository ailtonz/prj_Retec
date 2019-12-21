VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
END
Attribute VB_Name = "Form_LigacoesPesquisar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Database

Private Sub cmdPesquisar_Click()
Dim sqlConsulta As String: sqlConsulta = "SELECT * from qryLigacoesPesquisar"
Dim sqlCampos As String: sqlCampos = "codCadastro,Nome,CNPJ,Telefone,Obra"
Dim sqlCamposOrdem As String: sqlCamposOrdem = "codCadastro,Nome,CNPJ,Telefone,Obra"
Dim sqlCamposLargura As String: sqlCamposLargura = "0,8,3,3,8"

If IsNull(Me.txtPesquisar) Then
    Filtro Me.lstPesquisar, sqlConsulta, sqlCampos, sqlCamposLargura, sqlCamposOrdem, ""
Else
    Filtro Me.lstPesquisar, sqlConsulta, sqlCampos, sqlCamposLargura, sqlCamposOrdem, Me.txtPesquisar
End If
    
End Sub

Private Sub Form_Open(Cancel As Integer)
'    DoCmd.Restore
Call cmdPesquisar_Click
End Sub

Private Sub Form_Resize()

Me.lstPesquisar.Width = Me.InsideWidth
Me.lstPesquisar.Height = Me.InsideHeight

'Me.lstPesquisar.ColumnWidths = SetColumnWidths(Me.lstPesquisar)

End Sub

Private Function Filtro(ctrList As Control, strConsulta As String, strCampos As String, sqlCamposLargura As String, sqlCamposOrdem As String, Optional Procurar As String, Optional strLIMITE As String)

Dim Sql As String
Dim SqlAux As String
Dim Contagem As Integer
Dim a, b, C, l, x As Integer
Dim Colunas As Integer
Dim matriz As Variant
Dim strTamanho As String

Dim Procuras(30) As String
Dim ProcurasAux As Integer
ProcurasAux = 1

''' ITENS DE PROCURA
For b = 1 To Len(Procurar)
   If Mid(Procurar, b, 1) = "+" Then
      ProcurasAux = ProcurasAux + 1
   Else
      Procuras(ProcurasAux) = Procuras(ProcurasAux) + Mid(Procurar, b, 1)
   End If
Next b

''' LIMITE DE REGISTROS
If strLIMITE <> "" Then
    Sql = "Select  top " & strLIMITE & " "
Else
    Sql = "Select  "
End If

''' NOMES DE COLUNAS
matriz = Split(strCampos, ",")
For b = 0 To UBound(matriz)
    Sql = Sql & matriz(b) & ", "
Next b
Sql = left(Sql, Len(Sql) - 2) & " "

''' CONSULTA
Sql = Sql & " from (" & strConsulta & ") as tmp "

''' CRITÉRIOS
Sql = Sql & " where "
For C = 1 To ProcurasAux
    Sql = Sql & " ( "
    For a = 0 To UBound(matriz)
        Sql = Sql & matriz(a) & " Like '*" & LCase(Trim(Procuras(C))) & "*' OR "
    Next a
    Sql = left(Sql, Len(Sql) - 3) & ") "
Next C

''' ORDEM DE COLUNAS
Sql = Sql & "Order By "
matriz = Split(strCampos, ",")
For x = 0 To UBound(matriz)
    Sql = Sql & matriz(x) & ", "
Next x
Sql = left(Sql, Len(Sql) - 2) & ";"

''' LARGURA DE COLUNAS
matriz = Split(sqlCamposLargura, ",")
For l = 0 To UBound(matriz)
    strTamanho = strTamanho & matriz(l) & "cm; "
Next l
strTamanho = left(strTamanho, Len(strTamanho) - 2) & " "

''' AJUSTES DO CONTROLE
With ctrList
    .RowSource = Sql
    .ColumnHeads = True
    .ColumnCount = UBound(matriz) + 1
    .ColumnWidths = strTamanho
End With



End Function


Private Sub lstPesquisar_DblClick(Cancel As Integer)
Dim strObras As String: strObras = "SELECT Obra, codObra, codCadastro, Razao, CTR FROM CadastrosObras WHERE (((CadastrosObras.codCadastro)=forms.Ligacoes.codcadastro))"

If EstaAberto("ligacoes") Then

    ''' SELEÇÃO DE CLIENTE
    Form_Ligacoes.Cliente.Requery
    Form_Ligacoes.Cliente = Me.lstPesquisar.Column(1)
    
    ''' SELEÇÃO DE OBRA
    Form_Ligacoes.Obra.RowSource = strObras
    Form_Ligacoes.Obra.Requery
    Form_Ligacoes.Obra = Me.lstPesquisar.Column(4)
        
    ''' CADASTRO DE CÓDIGOS DE CONTROLES INTERNOS
    Form_Ligacoes.codCadastro = Form_Ligacoes.Cliente.Column(1)
    Form_Ligacoes.codObra = Form_Ligacoes.Obra.Column(1)
    Form_Ligacoes.CTR = Form_Ligacoes.Obra.Column(4)
    Form_Ligacoes.txtATENCAO = Form_Ligacoes.Cliente.Column(2)
    Form_Ligacoes.NumeroInscricaoDoSacado = Form_Ligacoes.Cliente.Column(3)
    
    ''' ATUALIZAÇÃO DA LISTAGEM DE BOLETOS
    Form_Ligacoes.lstBoletos.Requery
    
End If

Me.SetFocus
DoCmd.Close

End Sub

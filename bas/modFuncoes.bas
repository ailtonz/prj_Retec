Attribute VB_Name = "modFuncoes"
Option Compare Database
Option Explicit

Public strTabela As String
Public strSql As String

Public Function Pesquisar(Tabela As String)
                                   
On Error GoTo Err_Pesquisar
  
    Dim stDocName As String
    Dim stLinkCriteria As String

    stDocName = "Pesquisar"
    strTabela = Tabela
       
    DoCmd.OpenForm stDocName, , , stLinkCriteria
    
Exit_Pesquisar:
    Exit Function

Err_Pesquisar:
    MsgBox err.Description
    Resume Exit_Pesquisar
    
End Function

Function ImpressoraPadrao(prtDefault As String)
Dim XPrint     As Printer
Dim n          As Integer
  
    'Busca o numero da impresora
    For Each XPrint In Printers
        If XPrint.DeviceName = prtDefault Then
           Exit For
        End If
        n = n + 1
    Next
     
    'Efetiva a impressora como padrao
    Set Application.Printer = Application.Printers(n)
 
End Function

Public Function ExecutarSQL(strSql As String)
'Objetivo: Executar comandos SQL sem mostrar msg's do access.
    
    DoCmd.SetWarnings False
    DoCmd.RunSQL strSql
    DoCmd.SetWarnings True

End Function

Public Function Saida(strConteudo As String, strArquivo As String)

    Open Application.CurrentProject.Path & "\" & strArquivo For Append As #1
        Print #1, strConteudo
    Close #1

End Function

Public Function VerificaExistenciaDeArquivo(Localizacao As String) As Boolean

    If Dir(Localizacao, vbArchive) <> "" Then
        VerificaExistenciaDeArquivo = True
    Else
        VerificaExistenciaDeArquivo = False
    End If

End Function

Public Function CaminhoDoBanco() As String
Dim Arq As String
Dim caminho As String

    Arq = "caminho.log"
    caminho = Application.CurrentProject.Path & "\" & Arq
    
    'Verifica a existencia do caminho do banco de dados
    If VerificaExistenciaDeArquivo(caminho) Then
        CaminhoDoBanco = putPath(Application.CurrentProject.Path & "\" & Arq)
    Else
        MsgBox "ATEN��O: N�o � poss�vel localizar o caminho do Banco de dados.", vbExclamation + vbOKOnly, "Caminho do Banco de Dados"
        CaminhoDoBanco = ""
    End If

End Function

Public Function LocalizarBanco(Banco As String) As String

    'Verifica a existencia do banco de dados no caminho informado
    If VerificaExistenciaDeArquivo(Banco) Then
        LocalizarBanco = Banco
    Else
        MsgBox "ATEN��O: N�o � poss�vel localizar o Banco de dados.", vbExclamation + vbOKOnly, "Localiza Banco De Dados"
        LocalizarBanco = ""
    End If

End Function

Public Function NovoCodigo(Tabela, campo)
Dim rstTabela As DAO.Recordset

    Set rstTabela = CurrentDb.OpenRecordset("SELECT Max([" & campo & "])+1 AS CodigoNovo FROM " & Tabela & ";")
    If Not rstTabela.EOF Then
       NovoCodigo = rstTabela.Fields("CodigoNovo")
       If IsNull(NovoCodigo) Then
          NovoCodigo = 1
       End If
    Else
       NovoCodigo = 1
    End If
    rstTabela.Close
    Set rstTabela = Nothing

End Function

Public Function Categoria(strCategoria As String) As String
Dim rstTabela As DAO.Recordset

    Set rstTabela = CurrentDb.OpenRecordset("Select * from Categorias where Principal = -1 and Categoria = '" & strCategoria & "'")
    
    If Not rstTabela.EOF Then
        Categoria = rstTabela.Fields("Descricao01")
    Else
        Categoria = ""
    End If
    
    rstTabela.Close
    Set rstTabela = Nothing

End Function

Public Function Confirmar(sMensagem As String) As Boolean
'Faz uma pergunta ao usu�rio e retorma True se a
'resposta for SIM, e false se a resposta for N�O
Dim intResp As Integer

intResp = MsgBox(sMensagem, vbYesNo + vbQuestion, "Confirma��o")

If intResp = vbYes Then
    Confirmar = True
Else
    Confirmar = False
End If
End Function

Public Function RedimencionaControle(frm As Form, ctl As Control)

Dim intAjuste As Integer
On Error Resume Next

intAjuste = frm.Section(acHeader).Height * frm.Section(acHeader).Visible

intAjuste = intAjuste + frm.Section(acFooter).Height * frm.Section(acFooter).Visible

On Error GoTo 0

intAjuste = Abs(intAjuste) + ctl.Top

If intAjuste < frm.InsideHeight Then
    ctl.Height = frm.InsideHeight - intAjuste
'    ctl.Width = frm.InsideHeight + (intAjuste + intAjuste)
End If

End Function

Public Function EstaAberto(strName As String) As Boolean
On Error GoTo EstaAberto_Err
' Testa se o formul�rio est� aberto

   Dim obj As AccessObject, dbs As Object
   Set dbs = Application.CurrentProject
   ' Procurar objetos AccessObject abertos na cole��o AllForms.
   
   EstaAberto = False
   For Each obj In dbs.AllForms
        If obj.IsLoaded = True And obj.Name = strName Then
            ' Imprimir nome do obj.
            EstaAberto = True
            Exit For
        End If
   Next obj
    
EstaAberto_Fim:
  Exit Function
EstaAberto_Err:
  Resume EstaAberto_Fim
End Function

Public Function IsFormView(frm As Form) As Boolean
On Error GoTo IsFormView_Err
' Testa se o formul�rio est� aberto em
' modo formul�rio (form view)

 IsFormView = False
 If frm.CurrentView = 1 Then
    IsFormView = True
 End If

IsFormView_Fim:
  Exit Function
IsFormView_Err:
  Resume IsFormView_Fim
End Function

Public Function AbrirArquivo(sTitulo As String, sDecricao As String, sTipo As String, SelecaoMultipla As Boolean) As String
Dim fd As Office.FileDialog

    'Di�logo de selecionar arquivo - Office
    Set fd = Application.FileDialog(msoFileDialogFilePicker)
    
    'T�tulo
    fd.TITLE = sTitulo
    
    'Filtros e descri��o dos mesmos
    fd.Filters.Add sDecricao, sTipo
    
    'Premiss�es de sela��o
    fd.AllowMultiSelect = SelecaoMultipla
    
    If fd.Show = -1 Then
        AbrirArquivo = fd.SelectedItems(1)
    End If

End Function

Public Function SelecionarPasta(strTitulo As String) As String
Dim fd As Office.FileDialog

    Set fd = Application.FileDialog(msoFileDialogFolderPicker)
    
    fd.TITLE = strTitulo & " - Favor selecionar a pasta de origem"
    If fd.Show = -1 Then
        fd.InitialFileName = Application.CurrentProject.Path
        SelecionarPasta = fd.SelectedItems(1)
    End If
    
    Set fd = Nothing

End Function

Public Function CriarPasta(sPasta As String) As String
'Cria pasta apartir da origem do sistema
Dim fPasta As New FileSystemObject
Dim MyApl As String

    MyApl = Application.CurrentProject.Path
    
    If Not fPasta.FolderExists(MyApl & "\" & sPasta) Then
       fPasta.CreateFolder (MyApl & "\" & sPasta)
    End If
    
    CriarPasta = MyApl & "\" & sPasta & "\"

End Function

Public Function ListarArquivos(ByVal caminho As String, strExtensaoArquivo As String) As String()
'Aten��o: Fa�a refer�ncia � biblioteca Micrsoft Scripting Runtime
Dim fso As New FileSystemObject
Dim result() As String
Dim Pasta As Folder
Dim arquivo As File
Dim Indice As Long

    ReDim result(0) As String
    If fso.FolderExists(caminho) Then
        Set Pasta = fso.GetFolder(caminho)

        For Each arquivo In Pasta.Files
            If arquivo.Name Like strExtensaoArquivo Then
                Indice = IIf(result(0) = "", 0, Indice + 1)
                ReDim Preserve result(Indice) As String
                result(Indice) = arquivo.Name
            End If
        Next
    End If

    ListarArquivos = result
ErrHandler:
    Set fso = Nothing
    Set Pasta = Nothing
    Set arquivo = Nothing
End Function

Public Function CalcularVencimento(Dia As Integer, Optional Mes As Integer, Optional ANO As Integer) As Date

    If Month(Now) = 2 Then
        If Dia = 29 Or Dia = 30 Or Dia = 31 Then
            Dia = 1
            Mes = Mes + 1
        End If
    End If
    
    If Mes > 0 And ANO > 0 Then
        CalcularVencimento = Format((DateSerial(ANO, Mes, Dia)), "dd/mm/yyyy")
    ElseIf Mes = 0 And ANO > 0 Then
        CalcularVencimento = Format((DateSerial(ANO, Month(Now), Dia)), "dd/mm/yyyy")
    ElseIf Mes = 0 And ANO = 0 Then
        CalcularVencimento = Format((DateSerial(Year(Now), Month(Now), Dia)), "dd/mm/yyyy")
    End If

End Function

Public Function myMes(Mes As String)
Dim myMonth As Variant: myMonth = Array("", "Janeiro", "Fevereiro", "Mar�o", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro")
    myMes = myMonth(Mes)
End Function

Public Function getPath(sPathIn As String) As String
'Esta fun��o ir� retornar apenas o path de uma string que contenha o path e o nome do arquivo:
Dim i As Integer

  For i = Len(sPathIn) To 1 Step -1
     If InStr(":\", Mid$(sPathIn, i, 1)) Then Exit For
  Next

  getPath = left$(sPathIn, i)

End Function

Public Function getFileName(sFileIn As String) As String
' Essa fun��o ir� retornar apenas o nome do  arquivo de uma
' string que contenha o path e o nome do arquiva
Dim i As Integer

  For i = Len(sFileIn) To 1 Step -1
     If InStr("\", Mid$(sFileIn, i, 1)) Then Exit For
  Next

  getFileName = left(Mid$(sFileIn, i + 1, Len(sFileIn) - i), Len(Mid$(sFileIn, i + 1, Len(sFileIn) - i)) - 4)

End Function

Public Function getFileExt(sFileIn As String) As String
' Essa fun��o ir� retornar apenas a extens�o do  arquivo de uma
' string que contenha o path e o nome do arquiva
Dim i As Integer

  For i = Len(sFileIn) To 1 Step -1
     If InStr("\", Mid$(sFileIn, i, 1)) Then Exit For
  Next

  getFileExt = right(Mid$(sFileIn, i + 1, Len(sFileIn) - i), 4)

End Function

Public Function putPath(sPathFile As String) As String
Dim lin As String

    Open sPathFile For Input As #1
        Line Input #1, lin
        putPath = lin
    Close #1

End Function

Function RetValor(frm As Form, NomeObj As String, iCol As Integer) As Double
Dim OldCol As Integer
Dim vTotal As Double
Dim obj As Control
Dim x As Long

    For Each obj In frm.Controls
        If TypeOf obj Is ListBox Then
             If obj.Name = NomeObj Then
                 OldCol = obj.BoundColumn
                 obj.BoundColumn = iCol
                 For x = 1 To obj.ListCount - 1
                     vTotal = vTotal + Nz(obj.ItemData(x), 0)
                 Next
                 obj.BoundColumn = OldCol
                 RetValor = vTotal
                 Exit For
             End If
        End If
    Next obj
End Function

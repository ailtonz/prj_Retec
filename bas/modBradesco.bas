Attribute VB_Name = "modBradesco"
Option Compare Database
Option Explicit

Function BOLETOS_BRADESCO()

LeituraDeRemessaBradesco "BradescoRemessa", CaminhoBradesco("BradescoRemessa")
LeituraDeRemessaBradesco "BradescoRetorno", CaminhoBradesco("BradescoRetorno")
BradescoRemessaAtualizaStatus
BradescoCadastraBoleto
BradescoRemessaAtualizaStatusVencido
BradescoRemessaAtualizaStatusAvencer

MsgBox "Boletos Bradesco, ok!", vbInformation + vbOKOnly, "Remessa/Retorno"

End Function

Sub LeituraDeRemessaBradesco(strCadastro As String, strCaminho As String)

Dim Linha As String ' LINHA DO ARQUIVO
Dim F As Long: F = FreeFile
Dim fso As New FileSystemObject

Dim arquivos() As String
Dim i As Long
Dim y As Long
Dim j As Long

Dim rstCadastro As DAO.Recordset
Set rstCadastro = CurrentDb.OpenRecordset("Select * from " & strCadastro & "")

Dim rstArquivosProcessados As DAO.Recordset
Dim strArquivosProcessados As String: strArquivosProcessados = "SELECT DISTINCT Arquivo FROM " & strCadastro & " ORDER BY Arquivo"

Dim rstCampos As DAO.Recordset
Dim strOrigem As String: strOrigem = right(strCadastro, Len(strCadastro) - 8)
Set rstCampos = CurrentDb.OpenRecordset("Select * from qryBradescoCampos where Origem = '" & strOrigem & "'")

If strCaminho <> "" Then
    arquivos = ListarArquivos(strCaminho, IIf(strOrigem <> "Remessa", "*.ret", "*.rem"))
    
    SysCmd acSysCmdInitMeter, IIf(strOrigem <> "Remessa", "RETORNO: ", "REMESSA: "), UBound(arquivos)
    
    For i = 0 To UBound(arquivos)
        SysCmd acSysCmdUpdateMeter, i
        Set rstArquivosProcessados = CurrentDb.OpenRecordset("Select * from (" & strArquivosProcessados & ") as tmp where Arquivo = '" & arquivos(i) & "'")
        If rstArquivosProcessados.EOF Then
          Open strCaminho & "\" & arquivos(i) For Input As F
            Do While Not EOF(F)
                Line Input #F, Linha
                If Mid(Linha, 1, 1) = 1 Then ' REGISTRO DE TRANSAÇÃO - TIPO 1
                  rstCampos.MoveFirst
                  BeginTrans
                  rstCadastro.AddNew
                  For y = 0 To rstCadastro.Fields.Count - 2
                      If y = 0 Then
                          rstCadastro.Fields(y) = arquivos(i)
                      Else
                          rstCadastro.Fields(y) = Mid(Linha, rstCampos.Fields("POSICAO"), rstCampos.Fields("TAMANHO"))
                          rstCampos.MoveNext
                      End If
                  Next y
                  rstCadastro.Update
                  CommitTrans
                End If
            Loop
          Close #F
        End If
        rstArquivosProcessados.Close
    Next i
    
    SysCmd acSysCmdRemoveMeter
    
End If

Set fso = Nothing

End Sub

Public Function CaminhoBradesco(strCategoria As String) As String
Dim rDados As DAO.Recordset

Set rDados = CurrentDb.OpenRecordset("Select * from Categorias where Categoria = '" & strCategoria & "'")

    If rDados.EOF Then 'Ñ achou o registro
        CaminhoBradesco = ""
    Else
        CaminhoBradesco = rDados.Fields("Descricao01")
    End If
    
    rDados.Close

Set rDados = Nothing

End Function


Sub BradescoRemessaAtualizaStatus()
Dim rstBradescoRemessa As DAO.Recordset
Dim qdfOrcamentoNovoCustos As DAO.QueryDef

Set rstBradescoRemessa = CurrentDb.OpenRecordset("qryBradescoRemessaAtualizaStatusControle")

Set qdfOrcamentoNovoCustos = CurrentDb.QueryDefs("qryBradescoRemessaAtualizaStatus")

While Not rstBradescoRemessa.EOF
    
    With qdfOrcamentoNovoCustos
    
        .Parameters("NM_CONTROLE") = rstBradescoRemessa.Fields("NumeroControleDoParticipante")
        .Execute
        
    End With
    
    rstBradescoRemessa.MoveNext

Wend

rstBradescoRemessa.Close
qdfOrcamentoNovoCustos.Close

End Sub

Sub BradescoRemessaAtualizaStatusVencido()
Dim qdfBradescoRemessaAtualizaStatusVencido As DAO.QueryDef

Set qdfBradescoRemessaAtualizaStatusVencido = CurrentDb.QueryDefs("qryBradescoRemessaAtualizaStatusVencido")

With qdfBradescoRemessaAtualizaStatusVencido

    .Execute
    
End With

qdfBradescoRemessaAtualizaStatusVencido.Close

End Sub

Sub BradescoRemessaAtualizaStatusAvencer()
Dim qdfBradescoRemessaAtualizaStatusAvencer As DAO.QueryDef

Set qdfBradescoRemessaAtualizaStatusAvencer = CurrentDb.QueryDefs("qryBradescoRemessaAtualizaStatusAvencer")

With qdfBradescoRemessaAtualizaStatusAvencer

    .Execute
    
End With

qdfBradescoRemessaAtualizaStatusAvencer.Close

End Sub


Sub BradescoCadastraBoleto()
Dim qdfBradescoCadastraBoleto As DAO.QueryDef

Set qdfBradescoCadastraBoleto = CurrentDb.QueryDefs("qryBradescoCadastraBoleto")

With qdfBradescoCadastraBoleto

    .Execute
    
End With

qdfBradescoCadastraBoleto.Close

End Sub

Public Function AtualizarCaminho(strCategoria As String, strCaminho As String)

Dim qdfCadastroOrcamento As DAO.QueryDef
Set qdfCadastroOrcamento = CurrentDb.QueryDefs("qryBradescoAtualizarCaminho")

    With qdfCadastroOrcamento
        .Parameters("strCATEGORIA") = strCategoria
        .Parameters("strCAMINHO") = strCaminho
        .Execute
    End With

qdfCadastroOrcamento.Close

Set qdfCadastroOrcamento = Nothing

End Function

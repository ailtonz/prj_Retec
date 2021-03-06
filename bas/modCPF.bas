Attribute VB_Name = "modCPF"
Function VerificaCPF(Cpf As String) As Boolean

Dim i As Integer, a As Integer, b As Integer, dv1 As Integer, dv2 As Integer

For i = 1 To 9
a = a + Mid(Cpf, i, 1) * (11 - i)
b = b + Mid(Cpf, i, 1) * (12 - i)
Next i

dv1 = IIf((11 - (a Mod 11)) >= 10, 0, (11 - (a Mod 11)))
b = b + (dv1 * 2)
dv2 = IIf((11 - (b Mod 11)) >= 10, 0, (11 - (b Mod 11)))
VerificaCPF = (Mid(Cpf, 10, 2) = dv1 & dv2)
    If VerificaCPF Then
        MsgBox "CPF v�lido!", vbInformation
    Else
        MsgBox "CPF inv�lido", vbCritical
    End If
End Function

Function DVCPF(Cpf As String) As String

Dim lngSoma, lngInteiro As Long
Dim intNumero, intMais, i, intResto As Integer
Dim intDig1, intDig2 As Integer
Dim strDigVer, strcampo, strCaracter, StrConf As String
Dim dblDivisao As Double
lngSoma = 0
intNumero = 0
intMais = 0
strcampo = left(Cpf, 9)
strDigVer = right(Cpf, 2)
For i = 2 To 10
    strCaracter = right(strcampo, i - 1)
    intNumero = left(strCaracter, 1)
    intMais = intNumero * i
    lngSoma = lngSoma + intMais
Next i
dblDivisao = lngSoma / 11
lngInteiro = Int(dblDivisao) * 11
intResto = lngSoma - lngInteiro
If intResto = 0 Or intResto = 1 Then
    intDig1 = 0
Else
    intDig1 = 11 - intResto
End If
strcampo = strcampo & intDig1
lngSoma = 0
intNumero = 0
intMais = 0
For i = 2 To 11
    strCaracter = right(strcampo, i - 1)
    intNumero = left(strCaracter, 1)
    intMais = intNumero * i
    lngSoma = lngSoma + intMais
Next i
dblDivisao = lngSoma / 11
lngInteiro = Int(dblDivisao) * 11
intResto = lngSoma - lngInteiro
If intResto = 0 Or intResto = 1 Then
    intDig2 = 0
Else
    intDig2 = 11 - intResto
End If
StrConf = intDig1 & intDig2
DVCPF = StrConf

If DVCPF = strDigVer Then
   MsgBox "CPF - V�LIDO!", vbInformation

Else
   MsgBox "CPF - INV�LIDO", vbCritical
   DoCmd.CancelEvent
End If

End Function



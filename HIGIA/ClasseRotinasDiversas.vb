Imports System.Configuration

Public Class ClasseRotinasDiversas

    'Altera a cor de fundo quando o controle recebe foco
    Public Sub CorEntrada(ByVal sender As Object)
        Dim Objeto As Object

        If (TypeOf sender Is TextBox) Then
            Objeto = CType(sender, TextBox)
        ElseIf (TypeOf sender Is ComboBox) Then
            Objeto = CType(sender, ComboBox)
        Else
            Objeto = CType(sender, MaskedTextBox)
        End If

        If Objeto.tag = 0 Then
            Objeto.BackColor = Color.Yellow
        Else
            Objeto.BackColor = Color.Aqua
        End If
    End Sub

    'Altera a cor de fundo quando o controle perder o foco
    Public Sub CorSaida(ByVal sender As Object)
        Dim Objeto As Object

        If (TypeOf sender Is TextBox) Then
            Objeto = CType(sender, TextBox)
        ElseIf (TypeOf sender Is ComboBox) Then
            Objeto = CType(sender, ComboBox)
        Else
            Objeto = CType(sender, MaskedTextBox)
        End If

        Objeto.BackColor = Color.White
    End Sub

    'Verifica se o preenchimento de um controle é obrigatorio
    Public Function ChecarObrigatorio(ByVal Objeto As Object) As Boolean
        Dim strValorCampo As String = Objeto.text.ToString
        Dim blnRetorno As Boolean = True

        If Objeto.tag = 1 Then
            If (Trim(strValorCampo) = "") Or (strValorCampo = "   .   .   -  ") Or (strValorCampo = "  .   .   /    -  ") Or (strValorCampo = "   .   .   .   ") Or (strValorCampo = "     -   ") Then
                MsgBox("É obrigatorio o preenchimento desse campo !", MsgBoxStyle.Exclamation)
                blnRetorno = False
                Objeto.focus()
            End If
        End If
        ChecarObrigatorio = blnRetorno
    End Function

    'Limpa todos os controles de entrada de dados(TextBox ou MaskedTextBox)
    Public Sub BloqueioDeCampo(ByVal Controle As Control, ByVal Bloquear As Boolean)

        For Each Objeto As Control In Controle.Controls
            If Objeto.Controls.Count > 0 Then
                BloqueioDeCampo(Objeto, Bloquear)
            Else
                If (TypeOf Objeto Is TextBox) Or (TypeOf Objeto Is MaskedTextBox) Or (TypeOf Objeto Is ComboBox) Or (TypeOf Objeto Is CheckBox) Then
                    Objeto.Enabled = Bloquear
                End If
            End If
        Next Objeto

    End Sub

    'Limpa todos os controles de entrada de dados(TextBox ou MaskedTextBox)
    Public Sub LimparCampos(ByVal Controle As Control)

        For Each Objeto As Control In Controle.Controls
            If Objeto.Controls.Count > 0 Then
                LimparCampos(Objeto)
            Else
                If (TypeOf Objeto Is TextBox) Or (TypeOf Objeto Is MaskedTextBox) Or (TypeOf Objeto Is ComboBox) Then
                    Objeto.Text = ""
                End If
            End If
        Next Objeto

    End Sub

    Public Sub Limpar_Campos(ByVal controlPai As Control)

        For Each ctl As Control In controlPai.Controls

            If ctl.Controls.Count > 0 Then

                Limpar_Campos(ctl)

            Else
                If TypeOf (ctl) Is TextBox Then 'TextBox

                    DirectCast(ctl, TextBox).Text = String.Empty

                ElseIf TypeOf (ctl) Is CheckBox Then 'CheckBox

                    DirectCast(ctl, CheckBox).Checked = False

                ElseIf TypeOf (ctl) Is ComboBox Then 'ComboBox

                    DirectCast(ctl, ComboBox).Text = ""

                ElseIf TypeOf (ctl) Is MaskedTextBox Then 'MaskedTextBox

                    DirectCast(ctl, MaskedTextBox).Text = String.Empty

                ElseIf TypeOf (ctl) Is DataGridView Then 'Datagrid

                    DirectCast(ctl, DataGridView).DataSource = Nothing
                    DirectCast(ctl, DataGridView).Refresh()

                End If
            End If

        Next ctl

    End Sub

    ' Bloqueia os os controles de entrada de dados
    Public Sub BloquearCampo(ByVal Controle As System.Object)
        Controle.ReadOnly = True
    End Sub

    ' Desbloqueia os os controles de entrada de dados
    Public Sub DesbloquearCampo(ByVal Controle As System.Object)
        Controle.ReadOnly = False
    End Sub

    ' Converte uma data no formato DD/MM/AAAA para AAAA/MM/DD, aceita pelo MysQL
    Public Function DataInvertida(ByVal strData As String)
        Dim strNovaData As String

        strNovaData = strData.Substring(6, 4) + "/" + strData.Substring(3, 2) + "/" + strData.Substring(0, 2)

        Return strNovaData
    End Function

    ' Troca o ponto por vírgula nas casas decimais
    Public Sub PontoParaVirgula(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim strDigitos As String = "0123456789"

        If e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
            If e.KeyChar = "." Then
                System.Windows.Forms.SendKeys.Send(",")
            Else
                If InStr(strDigitos, e.KeyChar) = 0 Then
                    e = Nothing
                End If
            End If
        End If
    End Sub

    ' Troca a vírgula nas casas decimais por ponto
    Public Function VirgulaParaPonto(ByVal strValor As String)
        Return strValor.Replace(",", ".")
    End Function

    ' Limpa controles CheckBox atribuindo o valor False à propriedade Checked
    Public Sub LimparCheckBox(ByVal Controle As Control)
        For Each Objeto As Object In Controle.Controls
            If Objeto.Controls.Count > 0 Then
                LimparCheckBox(Objeto)
            Else
                If (TypeOf Objeto Is CheckBox) Then
                    Objeto.Checked = False
                End If
            End If
        Next Objeto
    End Sub

    'Removendo caracteres especiais
    Public Function RemoveAcentos(ByVal Texto As String) As String

        Dim ComAcentos As String
        Dim SemAcentos As String
        Dim Resultado As String
        Dim Cont As Long

        'Conjunto de Caracteres com acentos
        ComAcentos = "ÁÍÓÚÉÄÏÖÜËÀÌÒÙÈÃÕÂÎÔÛÊáíóúéäïöüëàìòùèãõâîôûêÇçºª,.;!?/"

        'Conjunto de Caracteres sem acentos
        SemAcentos = "AIOUEAIOUEAIOUEAOAIOUEaioueaioueaioueaoaioueCcoa "
        'SemAcentos = "AIOUEAIOUEAIOUEAOAIOUEaioueaioueaioueaoaioueCcoa----"

        Cont = 0
        Resultado = Texto
        If Len(Texto) > 0 Then
            Do While Cont < Len(ComAcentos)
                Cont = Cont + 1
                Resultado = Replace(Resultado, Mid(ComAcentos, Cont, 1), Mid(SemAcentos, Cont, 1))
            Loop
        End If
        RemoveAcentos = Resultado

    End Function

    'Verificar CNPJ
    Public Function VerificaCNPJ(CNPJ As String) As Boolean

        Dim intSoma, intSoma1, intSoma2, intInteiro As Long
        Dim intNumero, intMais, i, intResto As Integer
        Dim intDig1, intDig2 As Integer
        Dim strCampo, strCaracter, StrConf, strCNPJ, strDigVer As String
        Dim dblDivisao As Double

        intSoma = 0
        intSoma1 = 0
        intSoma2 = 0
        intNumero = 0
        intMais = 0

        strDigVer = Right(CNPJ, 2)
        strCampo = Left(CNPJ, 8)
        strCNPJ = Right(CNPJ, 6)
        strCNPJ = Left(strCNPJ, 4)
        strCampo = Right(strCampo, 4) & strCNPJ

        For i = 2 To 9
            strCaracter = Right(strCampo, i - 1)
            intNumero = Left(strCaracter, 1)
            intMais = intNumero * i
            intSoma1 = intSoma1 + intMais
        Next i

        'Separa os 4 primeiros dígitos do CNPJ
        strCampo = Left(CNPJ, 4)
        For i = 2 To 5
            strCaracter = Right(strCampo, i - 1)
            intNumero = Left(strCaracter, 1)
            intMais = intNumero * i
            intSoma2 = intSoma2 + intMais
        Next i

        intSoma = intSoma1 + intSoma2
        dblDivisao = intSoma / 11
        intInteiro = Int(dblDivisao) * 11
        intResto = intSoma - intInteiro

        If intResto = 0 Or intResto = 1 Then
            intDig1 = 0
        Else
            intDig1 = 11 - intResto
        End If

        intSoma = 0
        intSoma1 = 0
        intSoma2 = 0
        intNumero = 0
        intMais = 0

        strCampo = Left(CNPJ, 8)
        strCNPJ = Right(CNPJ, 6)
        strCNPJ = Left(strCNPJ, 4)
        strCampo = Right(strCampo, 3) & strCNPJ & intDig1

        For i = 2 To 9
            strCaracter = Right(strCampo, i - 1)
            intNumero = Left(strCaracter, 1)
            intMais = intNumero * i
            intSoma1 = intSoma1 + intMais
        Next i

        strCampo = Left(CNPJ, 5)
        For i = 2 To 6
            strCaracter = Right(strCampo, i - 1)
            intNumero = Left(strCaracter, 1)
            intMais = intNumero * i
            intSoma2 = intSoma2 + intMais
        Next i

        intSoma = intSoma1 + intSoma2
        dblDivisao = intSoma / 11
        intInteiro = Int(dblDivisao) * 11
        intResto = intSoma - intInteiro

        If intResto = 0 Or intResto = 1 Then
            intDig2 = 0
        Else
            intDig2 = 11 - intResto
        End If

        StrConf = intDig1 & intDig2
        'VerificaCNPJ = StrConf

        If StrConf = strDigVer Then
            VerificaCNPJ = True
        Else
            VerificaCNPJ = False
        End If

    End Function

    'Verificar CPF
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
            VerificaCPF = True
        Else
            VerificaCPF = False
        End If

    End Function

    Function GetConnectionStringByName(ByVal name As String) As String
        ' Retrieves a connection string by name.
        ' Returns Nothing if the name is not found.

        ' Assume failure
        Dim returnValue As String = Nothing

        ' Look for the name in the connectionStrings section.
        Dim settings As ConnectionStringSettings = _
           ConfigurationManager.ConnectionStrings(name)

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            returnValue = settings.ConnectionString
        End If

        Return returnValue
    End Function



    ''Verificar E-Mail
    'Public Function IsEmailValid(strEmail As String) As Boolean
    '    Dim strArray As Object
    '    Dim strItem As Object
    '    Dim i As Long, c As String, blnIsItValid As Boolean
    '    blnIsItValid = True

    '    i = Len(strEmail) - Len(Replace(strEmail, "@", ""))
    '    If i <> 1 Then IsEmailValid = False : Exit Function

    '    ReDim strArray(0 To 2)
    '    strArray(1) = Left(strEmail, InStr(1, strEmail, "@", 1) - 1)
    '    strArray(2) = Replace(Right(strEmail, Len(strEmail) - Len(strArray(1))), "@", "")

    '    For Each strItem In strArray

    '        If Len(strItem) <= 0 Then
    '            blnIsItValid = False
    '            IsEmailValid = blnIsItValid
    '            Exit Function
    '        End If

    '        For i = 1 To Len(strItem)
    '            c = LCase(Mid(strItem, i, 1))
    '            If InStr("abcdefghijklmnopqrstuvwxyz_-.", c) <= 0 And Not IsNumeric(c) Then
    '                blnIsItValid = False
    '                IsEmailValid = blnIsItValid
    '                Exit Function
    '            End If
    '        Next i

    '        If Left(strItem, 1) = "." Or Right(strItem, 1) = "." Then
    '            blnIsItValid = False
    '            IsEmailValid = blnIsItValid
    '            Exit Function
    '        End If

    '    Next strItem

    '    If InStr(strArray(2), ".") <= 0 Then
    '        blnIsItValid = False
    '        IsEmailValid = blnIsItValid
    '        Exit Function
    '    End If

    '    i = Len(strArray(2)) - InStrRev(strArray(2), ".")
    '    If i <> 2 And i <> 3 Then
    '        blnIsItValid = False
    '        IsEmailValid = blnIsItValid
    '        Exit Function
    '    End If

    '    If InStr(strEmail, "..") > 0 Then
    '        blnIsItValid = False
    '        IsEmailValid = blnIsItValid
    '        Exit Function
    '    End If

    '    IsEmailValid = blnIsItValid

    'End Function

    

End Class

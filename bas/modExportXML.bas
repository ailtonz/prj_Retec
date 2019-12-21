Attribute VB_Name = "modExportXML"
Option Compare Database

Sub ExportXML()
Dim strValor As String
Dim rstCadastro As DAO.Recordset
Set rstCadastro = CurrentDb.OpenRecordset("Select * from cadastros where tipoCadastro='CLIENTE'")

Saida "<NewDataSet>", "agenda_131224-0516.xml"


Do While Not rstCadastro.EOF

    strValor = "<Contatos>"
    strValor = strValor & "<Nome>" & Trim(rstCadastro.Fields("Nome")) & "</Nome>"
    strValor = strValor & "<Endereco>" & rstCadastro.Fields("Endereco") & "</Endereco>"
    strValor = strValor & "<Cidade>" & rstCadastro.Fields("Municipio") & "</Cidade>"
    strValor = strValor & "<Estado>" & rstCadastro.Fields("Estado") & "</Estado>"
    strValor = strValor & "<CodPostal>" & Replace(Replace(rstCadastro.Fields("Cep"), "<", ""), ">", "") & "</CodPostal>"
    strValor = strValor & "<Telefone>" & rstCadastro.Fields("Telefone") & "</Telefone>"
    strValor = strValor & "<EMail>" & rstCadastro.Fields("Email") & "</EMail>"
    strValor = strValor & "</Contatos>"
    
    Saida strValor, "agenda_131224-0516.xml"
    
    rstCadastro.MoveNext

Loop

Saida "</NewDataSet>", "agenda_131224-0516.xml"

rstCadastro.Close

Set rstCadastro = Nothing

End Sub

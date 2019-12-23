SELECT RoteirosItens.codLigacao, RoteirosItens.codObra, RoteirosItens.codCadastro, Sum(-RoteirosItens.C) AS TAREFA, RoteirosItens.DATA AS DATA_TAREFA, "COLOCA" AS TIPO_TAREFA, "SAIDA" AS strMovimento, DateAdd("d",6,[DATA]) AS Vencimento, Year(DateAdd("d",6,[DATA])) AS strANO
FROM RoteirosItens
GROUP BY RoteirosItens.codLigacao, RoteirosItens.codObra, RoteirosItens.codCadastro, RoteirosItens.DATA, "COLOCA", "SAIDA", RoteirosItens.C, RoteirosItens.Historico, DateAdd("d",6,[DATA]), Year(DateAdd("d",6,[DATA]))
HAVING ((Not (RoteirosItens.DATA) Is Null) AND ((RoteirosItens.C)>0) AND ((RoteirosItens.Historico)=No));

UNION

SELECT RoteirosItens.codLigacao, RoteirosItens.codObra, RoteirosItens.codCadastro, Sum(-RoteirosItens.T) AS TAREFA, RoteirosItens.DATA AS DATA_TAREFA, "TROCA" AS TIPO_TAREFA, "SAIDA" AS strMovimento, DateAdd("d",6,[DATA]) AS Vencimento, Year(DateAdd("d",6,[DATA])) AS strANO
FROM RoteirosItens
GROUP BY RoteirosItens.codLigacao, RoteirosItens.codObra, RoteirosItens.codCadastro, RoteirosItens.DATA, "TROCA", "SAIDA", RoteirosItens.T, RoteirosItens.Historico, DateAdd("d",6,[DATA]), Year(DateAdd("d",6,[DATA]))
HAVING ((Not (RoteirosItens.DATA) Is Null) AND ((RoteirosItens.T)>0) AND ((RoteirosItens.Historico)=No));

UNION 

SELECT RoteirosItens.codLigacao, RoteirosItens.codObra, RoteirosItens.codCadastro, Sum(RoteirosItens.R) AS TAREFA, RoteirosItens.DATA AS DATA_TAREFA, "RETIRA" AS TIPO_TAREFA, "ENTRADA" AS strMovimento, DateAdd("d",6,[DATA]) AS Vencimento, Year(DateAdd("d",6,[DATA])) AS strANO
FROM RoteirosItens
GROUP BY RoteirosItens.codLigacao, RoteirosItens.codObra, RoteirosItens.codCadastro, RoteirosItens.DATA, "RETIRA", "ENTRADA", RoteirosItens.R, RoteirosItens.Historico, DateAdd("d",6,[DATA]), Year(DateAdd("d",6,[DATA]))
HAVING ((Not (RoteirosItens.DATA) Is Null) AND ((RoteirosItens.R)>0) AND ((RoteirosItens.Historico)=No));

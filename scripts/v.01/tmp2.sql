SELECT 
	`cadastros`.`ID` AS `ID`,
	`cadastros`.`NOME` AS `Nome`,
	`cadastros`.`TELEFONE` AS `Telefone`,
	`cadastros`.`EMAIL` AS `Email`,
	`cadastros`.`CONTATO` AS `Contato`,
	`cadastros`.`ENDERECO` AS `Endereco`,
	
	`cadastros`.`SISTEMA_USUARIO` AS `CAD_USUARIO`,
	`cadastros`.`SISTEMA_EMISSAO` AS `CAD_EMISSAO`
	
FROM 
	`cadastros`
WHERE 
	(`cadastros`.`CADASTRO_CATEGORIA` = _utf8'ADM_UTEIS')
ORDER BY 
	`cadastros`.`NOME` 
	
	
select 
	`cadastros`.`ID` AS `ID`,
	`cadastros`.`NOME` AS `DESCRICAO`,
	`cadastros`.`CADASTRO_OBSERVACAO` AS `LINK`,
	`cadastros`.`SISTEMA_USUARIO` AS `CAD_USUARIO`,
	`cadastros`.`SISTEMA_EMISSAO` AS `CAD_EMISSAO` 

from 
	`cadastros` 
where 
	(`cadastros`.`CADASTRO_CATEGORIA` = _utf8'ADM_LINKS') 

order by `cadastros`.`ID` 	
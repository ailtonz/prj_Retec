SELECT 
	`cadastros`.`ID` AS `ID`,
	`cadastros`.`NOME` AS `NOME`,
	
	`cadastros`.`ENDERECO` AS `ENDERECO`,
	`cadastros`.`NUMERO` AS `NUMERO`,
	`cadastros`.`COMPLEMENTO` AS `COMPLEMENTO`,
	`cadastros`.`BAIRRO` AS `BAIRRO`,
	`cadastros`.`CEP` AS `CEP`,
	`cadastros`.`CIDADE` AS `CIDADE`,
	`cadastros`.`ESTADO` AS `ESTADO`,
	
	`cadastros`.`CNPJ_CPF` AS `CNPJ_CPF`,
	`cadastros`.`IE_RG` AS `IE_RG`,
	
	`cadastros`.`CADASTRO_STATUS` AS `CARGO`,
	
	`cadastros`.`CONTATO` AS `CONTATO`,
	`cadastros`.`TELEFONE` AS `TELEFONE`,
	`cadastros`.`EMAIL` AS `EMAIL`,
	
	`cadastros`.`CADASTRO_CATEGORIA` AS `CADASTRO_CATEGORIA`,	
	`cadastros`.`CADASTRO_EMISSAO` AS `CAD_EMISSAO`,
	`cadastros`.`CADASTRO_USUARIO` AS `CAD_USUARIO`,
	`cadastros`.`SISTEMA_EMISSAO` AS `ALT_EMISSAO`,
	`cadastros`.`SISTEMA_USUARIO` AS `ALT_USUARIO`

FROM 
	`cadastros`
WHERE 
	(`cadastros`.`CADASTRO_CATEGORIA` = _utf8'FUNCIONARIO')
ORDER BY 
`cadastros`.`NOME` 
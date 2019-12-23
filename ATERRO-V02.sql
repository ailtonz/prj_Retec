SELECT 
	`cadastros`.`ID` AS `ID`,
	`cadastros`.`CADASTRO_TIPO` AS `CADASTRO_TIPO`,
	`cadastros`.`NOME_FANTASIA` AS `NOME_FANTASIA`,
	`cadastros`.`NOME` AS `NOME`,
	`cadastros`.`ENDERECO` AS `ENDERECO`,
	`cadastros`.`NUMERO` AS `NUMERO`,
	`cadastros`.`COMPLEMENTO` AS `COMPLEMENTO`,
	`cadastros`.`BAIRRO` AS `BAIRRO`,
	`cadastros`.`CEP` AS `CEP`,
	`cadastros`.`CIDADE` AS `CIDADE`,
	`cadastros`.`ESTADO` AS `ESTADO`,
	`cadastros`.`CONTATO` AS `CONTATO`,
	`cadastros`.`TELEFONE` AS `TELEFONE`,
	`cadastros`.`EMAIL` AS `EMAIL`,
	`cadastros`.`CNPJ_CPF` AS `CNPJ_CPF`,
	`cadastros`.`IE_RG` AS `IE_RG`,
	`cadastros`.`CADASTRO_STATUS` AS `CADASTRO_STATUS`,
	`cadastros`.`CADASTRO_OBSERVACAO` AS `CADASTRO_OBSERVACAO`,
	`cadastros`.`CONTRATO_VALOR` AS `CONTRATO_VALOR`,
	`cadastros`.`SISTEMA_USUARIO` AS `CAD_USUARIO`,
	`cadastros`.`SISTEMA_EMISSAO` AS `CAD_EMISSAO`
FROM `cadastros`
WHERE (`cadastros`.`CADASTRO_CATEGORIA` = _utf8'ATERRO')
ORDER BY `cadastros`.`NOME`

BEGIN
 INSERT INTO cadastros
         (
			CADASTRO_TIPO,
			NOME_FANTASIA,
			NOME,
			ENDERECO,
			NUMERO,
			COMPLEMENTO,
			BAIRRO,
			CEP,
			CIDADE,
			ESTADO,
			CONTATO,
			TELEFONE,
			EMAIL,
			CNPJ_CPF,
			IE_RG,
			CADASTRO_STATUS,
			CADASTRO_OBSERVACAO,
			CONTRATO_VALOR,
            CADASTRO_CATEGORIA     ,
            SISTEMA_USUARIO        ,            
            SISTEMA_EMISSAO
         )
    VALUES 
         (
			trim(ucase(p_CADASTRO_TIPO)),
			trim(ucase(p_NOME_FANTASIA)),
			trim(ucase(p_NOME)),
			trim(ucase(p_ENDERECO)),
			p_NUMERO,
			trim(ucase(p_COMPLEMENTO)),
			trim(ucase(p_BAIRRO)),
			p_CEP,
			trim(ucase(p_CIDADE)),
			trim(ucase(p_ESTADO)),
			trim(ucase(p_CONTATO)),
			p_TELEFONE,
			trim(lcase(p_EMAIL)),
			p_CNPJ_CPF,
			p_IE_RG,
			trim(ucase(p_CADASTRO_STATUS)),
			trim(ucase(p_CADASTRO_OBSERVACAO)),
			p_CONTRATO_VALOR,          , 
			"ATERRO",
			ucase(p_USUARIO)      ,
			curdate()
         );
END
SELECT 
	`servicos`.`ID` AS `ID`,	
	`servicos`.`SERVICO_EMISSAO` AS `DATA_ROTEIRO`,
	`servicos`.`SERVICO_INICIO` AS `INICIO`,
	`servicos`.`SERVICO_TERMINIO` AS `TERMINIO`,
	`servicos`.`SERVICO_DESCRICAO` AS `MOTORISTA`,
	`servicos`.`SERVICO_SOLICITANTE` AS `VEICULO`,
	`servicos`.`SISTEMA_USUARIO` AS `USUARIO`,
	`servicos`.`SISTEMA_EMISSAO` AS `AUTERACAO`,
	`servicos`.`SERVICO_STATUS` AS `STATUS`
FROM `servicos`
WHERE (`servicos`.`SERVICO_CATEGORIA` = _utf8'ROTEIRO')

BEGIN
 INSERT INTO cadastros
			(
			ID_CADASTRO				,
			SERVICO_DESCRICAO		,
			SERVICO_SOLICITANTE		,
			SISTEMA_USUARIO			,            
			SERVICO_CATEGORIA		,
			SERVICO_STATUS			,
			SERVICO_EMISSAO			,	 
			SISTEMA_EMISSAO
			)
    VALUES 
			(
			p_ID_CADASTRO					,
			trim(ucase(p_MOTORISTA))		,
			trim(ucase(p_VEICULO))			,
			trim(ucase(p_USUARIO))			,
			"ROTEIRO"						,
			FALSE							,
			curdate()						,				
			curdate()
);
END
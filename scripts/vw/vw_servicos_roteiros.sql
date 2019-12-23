DELIMITER //

CREATE VIEW vw_servicos_roteiros AS

SELECT 
		servicos.ID_CADASTRO,
		
		servicos.SERVICO_EMISSAO,
		servicos.SERVICO_INICIO,
		servicos.SERVICO_TERMINIO,
		servicos.SERVICO_NOME AS MOTORISTA,
		servicos.SERVICO_CONTATO AS VEICULO,
		servicos.SERVICO_STATUS,
		
		servicos.REGISTRO_CATEGORIA ,
		servicos.REGISTRO_INSERT_EMISSAO ,
		servicos.REGISTRO_INSERT_USUARIO ,
		servicos.REGISTRO_UPDATE_EMISSAO ,
		servicos.REGISTRO_UPDATE_USUARIO  		
		
		
FROM
	servicos
WHERE
	servicos.REGISTRO_CATEGORIA = "ROTEIRO" 
	
DELIMITER ;
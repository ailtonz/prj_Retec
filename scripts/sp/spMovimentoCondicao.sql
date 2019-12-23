DELIMITER //

CREATE  PROCEDURE `spMovimentoCondicao`(IN `p_ID` INT, IN `p_DESCRICAO` VARCHAR(50), IN `p_CONDICAO` VARCHAR(3), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT 'CONDIÇÕES DE FATURAMENTO - EX: DIARIO, SEMANAL E ETC...'
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'MOV_CONDICAO';

IF p_ID = "0" THEN
 INSERT INTO movimentos
         (
				Transacao     , 
				Controle               ,
				REGISTRO_CATEGORIA,
				REGISTRO_INSERT_EMISSAO	,
				REGISTRO_INSERT_USUARIO ,
				REGISTRO_UPDATE_EMISSAO	,
				REGISTRO_UPDATE_USUARIO 
         )
    VALUES 
         (
				trim(ucase(p_DESCRICAO))   , 
				p_CONDICAO            , 
				p_CATEGORIA,
				now(),
				ucase(p_USUARIO),
				now(),
				ucase(p_USUARIO)
         );
ELSEIF p_ID <> "0" THEN

	IF p_DESCRICAO <> "" THEN
	
		UPDATE movimentos
			SET
				Transacao 			= ucase(p_DESCRICAO),
				Controle  					= p_CONDICAO,
				REGISTRO_UPDATE_USUARIO = ucase(p_USUARIO),
				REGISTRO_UPDATE_EMISSAO = now()			
		WHERE
			id = p_ID;
	ELSE
		DELETE FROM movimentos WHERE id = p_ID;
	END IF;

END IF;
         

END //

DELIMITER ;
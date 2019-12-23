DELIMITER //

CREATE PROCEDURE `spStatusPrecificacao`(IN `p_ID` INT, IN `p_STATUS` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'UTEIS_PRECO';

IF p_ID = "0" THEN

 INSERT INTO cadastros
         (
			CONTRATO_OBSERVACAO,		
			
			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 
			)
    VALUES 
         (
			ucase(p_STATUS),		 
			
			p_CATEGORIA,
			now(),
			ucase(p_USUARIO),
			now(),
			ucase(p_USUARIO)
			
			);
			
ELSEIF p_ID <> "0" THEN

	IF p_STATUS <> "" THEN
	
		UPDATE cadastros
			SET
				CONTRATO_OBSERVACAO			= trim(ucase(p_STATUS)),
				REGISTRO_UPDATE_USUARIO   	= trim(ucase(p_USUARIO)),            
				REGISTRO_UPDATE_EMISSAO		= now()			
		WHERE ID = p_ID;		
		
	ELSE
	
		DELETE FROM cadastros WHERE ID IN (SELECT * FROM (SELECT ID FROM cadastros WHERE ID = p_ID) AS p);
	
	END IF;
	
END IF;
  

END //

DELIMITER ;
DELIMITER //

CREATE  PROCEDURE `spServicoStatus`(IN `p_ID` INT, IN `p_STATUS` VARCHAR(50), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'STATUS_SERVICO';

IF p_ID = "0" THEN

 INSERT INTO servicos
         (
			SERVICO_STATUS,		
			
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
	
		UPDATE servicos
			SET
				SERVICO_STATUS				= trim(ucase(p_STATUS)),
				REGISTRO_UPDATE_USUARIO   	= trim(ucase(p_USUARIO)),            
				REGISTRO_UPDATE_EMISSAO		= now()			
		WHERE ID = p_ID;		
		
	ELSE
	
		DELETE FROM servicos WHERE ID IN (SELECT * FROM (SELECT ID FROM servicos WHERE ID = p_ID) AS p);
	
	END IF;
	
END IF;
  

END //

DELIMITER ;
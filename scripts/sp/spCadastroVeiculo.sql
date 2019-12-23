DELIMITER //

CREATE  PROCEDURE `spCadastroVeiculo`(IN `p_ID` INT, IN `p_PLACA` VARCHAR(8), IN `p_MODELO` VARCHAR(25), IN `p_USUARIO` VARCHAR(10))
	LANGUAGE SQL
	NOT DETERMINISTIC
	CONTAINS SQL
	SQL SECURITY DEFINER
	COMMENT ''
BEGIN
DECLARE p_CATEGORIA 	VARCHAR(50);

SET p_CATEGORIA = 'VEICULO';

IF p_ID = "0" THEN
 INSERT INTO cadastros
         (
			CEP, 
			NOME,
			REGISTRO_CATEGORIA,
			REGISTRO_INSERT_EMISSAO	,
			REGISTRO_INSERT_USUARIO ,
			REGISTRO_UPDATE_EMISSAO	,
			REGISTRO_UPDATE_USUARIO 
         )
    VALUES 
         (
			trim(ucase(p_PLACA)), 
			trim(ucase(p_MODELO)), 
			p_CATEGORIA,
			now(), 				
			ucase(p_USUARIO), 
			now(),
			ucase(p_USUARIO) 
         );
ELSEIF p_ID <> "0" THEN
	
	IF p_PLACA <> "" THEN
		UPDATE cadastros
			SET
				CEP						= trim(ucase(p_PLACA)), 
				NOME						= trim(ucase(p_MODELO)),
				REGISTRO_UPDATE_USUARIO 	= p_USUARIO,
				REGISTRO_UPDATE_EMISSAO 	= curdate()			
		WHERE
			ID = p_ID;			
	ELSE
		DELETE FROM cadastros WHERE ID = p_ID;
	END IF;   
	
END IF;
         
        
END //

DELIMITER ;